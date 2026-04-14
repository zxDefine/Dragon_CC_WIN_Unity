using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using Object = System.Object;

public class LabelInfo
{
    public Func<IEnumerator> MethodDelegate;
    public string FilePath;
}

public class LabelRegistry : MonoBehaviour
{
    public static LabelRegistry Instance;
    private Dictionary<string, LabelInfo> _labelMap = new(); // 存储各种label信息
    private Dictionary<string, Object> _instanceMap = new();  // 存储各种label所在类的实例
    private Dictionary<string, object> _services = new(); // 存储各种需要的实例

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    public void InjectDependency(string key, object obj)
    {
        _services[key] = obj;
    }
    
    public IEnumerator RegisterAllLabelsFromTxt()
    {
        AsyncOperationHandle<TextAsset> handle = Addressables.LoadAssetAsync<TextAsset>("Assets/RenpyResources/middle_data/labels.txt");
        yield return handle; // 等待加载完成

        TextAsset labelAsset = null;
        if (handle.Status == AsyncOperationStatus.Succeeded)
        { 
            labelAsset = handle.Result;
            Debug.Log("加载成功，内容如下：\n" + labelAsset.text);
            // 后续解析文本的逻辑写在这里
        }
        else
        {
            Debug.LogError("labels.txt not found in Addressables");
            yield break;
        }

        string[] lines = labelAsset.text.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            string[] parts = line.Split(',');
            if (parts.Length != 3) continue;

            string methodName = parts[0].Trim();
            string className = parts[1].Trim();
            string filePath = parts[2].Trim();

            // 自动查找类型（可以加命名空间）
            Type type = SafeGetType(className);
            if (type == null)
            {
                // 静默跳过未找到的类（可能是尚未转换的 rpy 文件，如 end7 等）
                continue;
            }

            // ✅ 如果没有实例就 new 一个
            if (!_instanceMap.TryGetValue(className, out object instance))
            {
                try
                {
                    if (!_services.TryGetValue("GameMethods", out var gmObj))
                    {
                        Debug.LogError($"❌ GameMethods 未注入，无法实例化 {className}");
                        continue;
                    }
                    
                    var gm = _services["GameMethods"] as GameMethods;
                    if (gm == null)
                    {
                        Debug.LogError("❌ GameMethods 是 null！");
                        continue;
                    }

                    Debug.Log($"正在查找构造函数: {type.FullName}");
                    var ctor = type.GetConstructor(new[] { typeof(GameMethods) });
                    if (ctor == null)
                    {
                        Debug.LogError($"❌ 没有找到 {className}(GameMethods) 的构造函数！");
                        continue;
                    }
                    instance = ctor.Invoke(new object[] { gm });
                    _instanceMap[className] = instance;
                    Debug.Log($"自动创建实例: {className}");
                }
                catch (Exception e)
                {
                    Debug.LogError($"无法创建类 {className} 的实例: {e.Message}");
                    continue;
                }
            }

            MethodInfo method = type.GetMethod(methodName, BindingFlags.Public | BindingFlags.Instance);
            if (method == null || method.ReturnType != typeof(IEnumerator))
            {
                // 静默跳过未实现的 label 方法（通常是转换器未生成的 menu label）
                continue;
            }

            string labelKey = $"{className}.{methodName}";
            Func<IEnumerator> del = () => (IEnumerator)method.Invoke(instance, null);

            _labelMap[labelKey] = new LabelInfo
            {
                MethodDelegate = del,
                FilePath = filePath
            };

            Debug.Log($"✅ 注册完成: {labelKey}");
        }
    }

    // 通过类名.label名的方式执行
    public IEnumerator RunCoroutineLabel(string labelKey)
    {
        if (_labelMap.TryGetValue(labelKey, out var info))
        {
            yield return info.MethodDelegate();
        }
        else
        {
            Debug.LogError($"Label not found: {labelKey}");
        }
    }
    
    // 通过label名找到协程函数在执行
    public IEnumerator RunCoroutineByMethodOnly(string methodName)
    {
        foreach (var kvp in _labelMap)
        {
            if (kvp.Key.EndsWith($".{methodName}"))
            {
                yield return kvp.Value.MethodDelegate();
                yield break;
            }
        }

        Debug.LogError($"方法名 {methodName} 未找到对应的 label（类名.方法名）");
    }

    
    // 获得原始数据的内容
    public string GetFilePathForLabel(string labelKey)
    {
        if (_labelMap.TryGetValue(labelKey, out var info))
        {
            return info.FilePath;
        }
        return null;
    }

    // 即使没有命名空间的信息，也能查找到对应的类名
    private Type SafeGetType(string className)
    {
        // 优先尝试完整类名
        var type = Type.GetType(className);
        if (type != null) return type;

        // 否则遍历所有程序集
        foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
        {
            foreach (var t in asm.GetTypes())
            {
                if (t.Name == className)
                    return t;
            }
        }

        return null;
    }
    
}