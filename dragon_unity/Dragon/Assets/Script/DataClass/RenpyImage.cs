using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering.Universal;
using UnityEngine.ResourceManagement.AsyncOperations;

public class RenpyImage
{
    // image名
    private string _name;
    
    // 是chara还是layer
    // 有没有贴图的选择拼贴处理
    private bool _isLayer = false;
    
    // 保存原始读取用的json
    private readonly JToken _loadJson;
    
    // 保存读取的贴图
    private Dictionary<string, List<AsyncOperationHandle<Texture2D>>> _textureHandles = new Dictionary<string, List<AsyncOperationHandle<Texture2D>>>();
    
    // 保存设置元素
    private Dictionary<string, object> _attributes = new Dictionary<string, object>();
    
    // 保存嵌套image名
    private List<string> _subImages = new List<string>();
    
    // 保存特效函数名
    private List<string> _effctFunctions = new List<string>();
    
    // 是否进行了读取
    private bool _isLoaded = false;
    
    // 保存之前显示的parts名
    private List<string> _oldPartsNames = new List<string>();
    
    public RenpyImage(string name, JToken loadJson)
    {
        _name = name;
        _loadJson = loadJson;
        
        // 读取元素跟贴图
        load(_loadJson, 0);
    }

    // 动态加载用
    public void Load()
    {
        // 已经读取成功
        if (_isLoaded)
        {
            return;
        }
        
        // 读取元素跟贴图
        load(_loadJson, 0);
        _isLoaded = true;
    }

    private void load(JToken token, int indentLevel, string key = null)
    {
        string indent = new string(' ', indentLevel * 2);

        switch (token.Type)
        {
            case JTokenType.String:
                // Debug.Log($"字符串: {token.ToString()}");

                if (key == "effect_function")
                {
                    // 加载需要的特效函数
                    _effctFunctions.Add(token.ToString());
                }
                else if (token.ToString().Contains(".png") || token.ToString().Contains(".jpg") || token.ToString().Contains(".jpeg"))
                {
                    // 作为图片加载
                    string fileString = token.ToString();
                    string fullPath = $"Assets/RenpyResources/{fileString}";
                    AsyncOperationHandle<Texture2D> handle = Addressables.LoadAssetAsync<Texture2D>(fullPath);
                    if (!_textureHandles.ContainsKey(key))
                    {
                        _textureHandles[key] = new List<AsyncOperationHandle<Texture2D>>();
                    }
                    _textureHandles[key].Add(handle);
                }
                else
                {
                    // 保存嵌套image名
                    string subImageName = token.ToString();
                    _subImages.Add(subImageName);
                    // Debug.Log($"add subimage {_name} : {subImageName}");
                }

                break;

            case JTokenType.Array:
                // Debug.Log("列表:");
                foreach (var item in (JArray)token)
                {
                    // Debug.Log($"    - {item}");
                    if (key == "file")
                    {
                        // layered类型贴图
                        // 加载贴图
                        string fileString = (string)item;
                        string fullPath = $"Assets/RenpyResources/{fileString}";
                        AsyncOperationHandle<Texture2D> handle = Addressables.LoadAssetAsync<Texture2D>(fullPath);
                        if (!_textureHandles.ContainsKey("file"))
                        {
                            _textureHandles["file"] = new List<AsyncOperationHandle<Texture2D>>();
                        }
                        _textureHandles["file"].Add(handle);
                    }
                    else if (key == "subImage")
                    {
                        // 保存嵌套保存嵌套image名
                        string subImageName = (string)item;
                        _subImages.Add(subImageName);
                        // Debug.Log($"嵌套image {subImageName}");
                    }
                    else if (key == "always")
                    {
                        // chara类型贴图
                        // 加载贴图
                        string fileString = (string)item;
                        string fullPath = $"Assets/RenpyResources/{fileString}";
                        AsyncOperationHandle<Texture2D> handle = Addressables.LoadAssetAsync<Texture2D>(fullPath);
                        if (!_textureHandles.ContainsKey("always"))
                        {
                            _textureHandles["always"] = new List<AsyncOperationHandle<Texture2D>>();
                        }
                        _textureHandles["always"].Add(handle);
                    }
                }

                break;

            case JTokenType.Float:
            case JTokenType.Integer:
                // Debug.Log($"数字: {value.ToObject<double>()}");
                if (key == "zoom")
                {
                    _attributes["zoom"] = token.ToObject<float>();
                }
                break;
            
            case JTokenType.Boolean:
                if (key == "layer")
                {
                    _isLayer = token.ToObject<bool>();
                }
                break;

            case JTokenType.Object:
                // Debug.Log("嵌套对象:");
                foreach (var property in ((JObject)token).Properties())
                {
                    // Debug.Log($"KEY: {property.Name}, Type: {property.Value.Type}");
                    load(property.Value, indentLevel + 1, property.Name);
                }
                break;

            default:
                Debug.Log($"未知类型: {token.Type}");
                break;
        }
    }
    
    // character绘制专用
    // oldImagePartsName[partsName:texName]
    public List<Texture2D> GetCharaDrawTexture(List<string> imagePartsName)
    {
        List<Texture2D> ret = new List<Texture2D>();
        Dictionary<string, List<AsyncOperationHandle<Texture2D>>> processed = new Dictionary<string, List<AsyncOperationHandle<Texture2D>>>();
        
        if (_isLayer)
        {
            // layer(背景贴图等)
            // 添加file里面的贴图
            if (_textureHandles.ContainsKey("file"))
            {
                foreach (var fileItem in _textureHandles["file"])
                {
                    ret.Add(fileItem.WaitForCompletion());
                }
            }

            // 添加always里面的贴图
            if (_textureHandles.ContainsKey("always"))
            {
                foreach (var fileItem in _textureHandles["always"])
                {
                    ret.Add(fileItem.WaitForCompletion());
                }
            }
        
            // 检查指代的嵌套image的贴图
            if (_subImages.Count > 0)
            {
                foreach (var subImage in _subImages)
                {
                    // 拿到sub的image数据
                    RenpyImage image =  ImageManager.Instance.GetImage(subImage);
                    List<Texture2D> temp = image.GetCharaDrawTexture(null);
                    ret.AddRange(temp);
                }
            }
        }
        else
        {
            // 角色立绘
            // 添加always
            if (_textureHandles.ContainsKey("always"))
            {
                processed["always"] = _textureHandles["always"];
            }
            
            // 需要绘制的parts内容
            // [部位名 : 部位原名]
            Dictionary<string, string> drawPartsName = new Dictionary<string, string>();
            
            // 根据default，来生成对应的部位名称
            List<string> checkList = new List<string>();
            
            // 先用default填充所有图层
            foreach (var kvp in _textureHandles)
            {
                if (kvp.Key.StartsWith("default_"))
                {
                    // 获得部位名
                    string bodyKey = GetPartBodyKey(kvp.Key);
                    
                    // 添加默认的default部位名
                    drawPartsName[bodyKey] = kvp.Key;
                    
                    // 添加需要check的部位名
                    checkList.Add(bodyKey);
                }
            }
            
            //////////////////////////////////////
            /// 测试
            // foreach (var key in checkList)
            // {
            //     Debug.Log($"check body key -> {key}");
            // }
            // Debug.Log("============================================> delete");
            
            // 找到需要显示・删除的图层
            List<string> showPartsName = new List<string>();
            List<string> deletePartsName = new List<string>();
            if (imagePartsName != null && imagePartsName.Count > 0)
            {
                foreach (var name in imagePartsName)
                {
                    // Debug.Log($"iiiiiiiiiiiiiiiiiiiiiiiii {name}");
                    if (name.StartsWith("-"))
                    {
                        string cName = name.Replace("-", "");
                        // Debug.Log($"iiiiiiiiiiiiiiiiiiiiiiiii {cName}");
                        deletePartsName.Add(cName);
                    }
                    else
                    {
                        showPartsName.Add(name);
                    }
                }
            }
            //////////////////////////////////////
            /// 测试
            // foreach (var key in deletePartsName)
            // {
            //     Debug.Log($"delete parts name -> {key}");
            // }
            // Debug.Log("============================================> show");
            // foreach (var key in showPartsName)
            // {
            //     Debug.Log($"show parts name -> {key}");
            // }
            // Debug.Log("============================================> old old");
            //////////////////////////////////////
            /// 测试
            // foreach (var name in _oldPartsNames)
            // {
            //     Debug.Log($"old parts name -> {name}");
            // }
            // Debug.Log("============================================> draw");
            
            // 如果有需要删除的话，就从旧的parts里面删除
            if (deletePartsName.Count > 0)
            {
                if (_oldPartsNames != null && _oldPartsNames.Count > 0)
                {
                    foreach (var name in _oldPartsNames)
                    {
                        // 如果不是需要删除的parts，那就重新放入进行重绘
                        if (!deletePartsName.Contains(name))
                        {
                            // 获得部位名
                            string bodyKey = GetPartBodyKey(name);
                            if (checkList.Contains(bodyKey))
                            {
                                drawPartsName[bodyKey] = name;
                            }
                            else
                            {
                                // 非default部分，就保存原版的所有信息
                                drawPartsName[name] = name;
                            }
                        }
                    }
                }
                else
                {
                    Debug.LogError($"没有需要删除的图层，但是触发了删除的处理1");
                    return null;
                }
            }
            else
            {
                if (_oldPartsNames != null && _oldPartsNames.Count > 0)
                {
                    foreach (var name in _oldPartsNames)
                    {
                        // 获得部位名
                        string bodyKey = GetPartBodyKey(name);
                        if (checkList.Contains(bodyKey))
                        {
                            drawPartsName[bodyKey] = name;
                        }
                        else
                        {
                            // 非default部分，就保存原版的所有信息
                            drawPartsName[name] = name;
                        }
                    }
                }
            }
            //////////////////////////////////////
            /// 测试
            // foreach (var kvp in drawPartsName)
            // {
            //     Debug.Log($"draw parts1 name -> {kvp.Key} : {kvp.Value}");
            // }
            // Debug.Log("============================================> draw2");
            
            // 添加新的需要绘制的parts信息
            if (showPartsName.Count > 0)
            {
                foreach (var name in showPartsName)
                {
                    // 获得部位名
                    string bodyKey = GetPartBodyKey(name);
                    if (checkList.Contains(bodyKey))
                    {
                        drawPartsName[bodyKey] = name;
                    }
                    else
                    {
                        // 非default部分，就保存原版的所有信息
                        drawPartsName[name] = name;
                    }
                }
            }
            //////////////////////////////////////
            /// 测试
            // foreach (var kvp in drawPartsName)
            // {
            //     Debug.Log($"draw parts2 name -> {kvp.Key} : {kvp.Value}");
            // }
            // Debug.Log("============================================> old");
            
            // 将需要绘制的图层信息添加到process
            _oldPartsNames.Clear();
            foreach (var kvp in drawPartsName)
            {
                string name = kvp.Value;
                List<AsyncOperationHandle<Texture2D>> handles = new List<AsyncOperationHandle<Texture2D>>();
            
                // 拿到指定的texture
                if (_textureHandles.ContainsKey($"default_{name}"))
                {
                    // 如果是default的image部位
                    handles = _textureHandles[$"default_{name}"];
                }
                else if (!_textureHandles.ContainsKey(name))
                {
                    // 如果是嵌套的image
                    // 先从json里面拿到subimage的名字
                    string subImageName = _loadJson[name].ToString();
                    // 先拿到对应的image
                    RenpyImage image = ImageManager.Instance.GetImage(subImageName);
                    handles = image.GetCharacterHandleList();
                }
                else
                {
                    handles = _textureHandles[name];
                }
                
                // 保存绘制的parts名称
                _oldPartsNames.Add(name);
            
                // 拿到部位的key
                string partsKey = Regex.Replace(name, @"\d", "");
                if (checkList.Contains(partsKey))
                {
                    // 如果是有default的部位
                    // 用部位名进行添加
                    processed.Add(partsKey, new List<AsyncOperationHandle<Texture2D>>());
                    processed[partsKey] = handles;
                }
                else
                {
                    // 用素材名称进行添加
                    processed.Add(name, new List<AsyncOperationHandle<Texture2D>>());
                    processed[name] = handles;
                }
            }
            //////////////////////////////////////
            /// 测试
            // foreach (var name in _oldPartsNames)
            // {
            //     Debug.Log($"old parts name -> {name}");
            // }
            // Debug.Log("============================================>");

            // 将所有贴图存到返回List中
            foreach (var item in processed)
            {
                List<AsyncOperationHandle<Texture2D>> temp = item.Value;
                foreach (var handle in temp)
                {
                    Texture2D tex = handle.WaitForCompletion();
                    if (ret.Contains(tex))
                    {
                        // 跳过重复贴图
                        continue;
                    }

                    // 添加绘制贴图
                    if (item.Key == "d")
                    {
                        // 强制放到最前头
                        ret.Insert(0, tex);
                    }
                    else
                    {
                        ret.Add(tex);
                    }
                }
            }
            //////////////////////////////////////
            /// 测试
            // foreach (var tex in ret)
            // {
            //     Debug.Log($"get tex name -> {tex}, {tex.name}");   
            // }
            // Debug.Log("============================================>");
        }

        return ret;
    }

    public List<AsyncOperationHandle<Texture2D>> GetCharacterHandleList()
    {
        List<AsyncOperationHandle<Texture2D>> ret = new List<AsyncOperationHandle<Texture2D>>();
        
        // 检查自带的贴图
        if (_textureHandles.ContainsKey("file"))
        {
            ret.AddRange(_textureHandles["file"]);
        }

        return ret;
    }

    public void ClearOldPartsNames()
    {
        _oldPartsNames.Clear();
    }

    // 根据zui4, default_yan2，这样的名称
    // 返回zui,, yan这样形式的，返回部位名
    private string GetPartBodyKey(string partsName)
    {
        string bodyKey;
        if (partsName.StartsWith("default_"))
        {
            string newKey = partsName.Substring("default_".Length);
            bodyKey = Regex.Replace(newKey, @"\d", "");
        }
        else
        {
            bodyKey = Regex.Replace(partsName, @"\d", "");
        }
        return bodyKey;
    }
}