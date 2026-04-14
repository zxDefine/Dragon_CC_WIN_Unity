using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// M4 UGUI 屏幕调度器。屏幕按栈管理（Main Menu → Load 画面 → 返回 → Main Menu）。
/// 运行时通过 <see cref="Show{T}"/> 激活屏幕，未注册则第一次延迟创建。
/// </summary>
public class UIScreenManager : MonoBehaviour
{
    public static UIScreenManager Instance { get; private set; }

    private Dictionary<Type, UIScreenBase> _screens = new Dictionary<Type, UIScreenBase>();
    private Stack<UIScreenBase> _stack = new Stack<UIScreenBase>();

    /// <summary>
    /// 启动期自动 bootstrap：在任何场景加载前创建 UIScreenManager 宿主 GameObject。
    /// 这样 Start.unity 不需要手动挂载本脚本——场景里缺席也能工作。
    /// </summary>
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void AutoBootstrap()
    {
        if (Instance != null) return;
        GameObject host = new GameObject("UIScreenManager (auto)");
        host.AddComponent<UIScreenManager>();
        // AutoBootstrap 内 DontDestroyOnLoad 由 Awake 处理
    }

    private void Awake()
    {
        if (Instance != null && Instance != this) { Destroy(gameObject); return; }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    /// <summary>显示屏幕 T；若没有实例则即时创建。之前显示的屏幕保留在栈里但不隐藏。</summary>
    public T Show<T>(bool hidePrevious = true) where T : UIScreenBase
    {
        T screen = GetOrCreate<T>();
        if (hidePrevious && _stack.Count > 0)
        {
            _stack.Peek().Hide();
        }
        screen.SortingOrder = 100 + _stack.Count * 10;
        _stack.Push(screen);
        screen.Show();
        return screen;
    }

    /// <summary>弹出顶层屏幕，回到前一个。</summary>
    public void Pop()
    {
        if (_stack.Count == 0) return;
        UIScreenBase top = _stack.Pop();
        top.Hide();
        if (_stack.Count > 0) _stack.Peek().Show();
    }

    /// <summary>清空栈。通常用于"返回主菜单"。</summary>
    public void PopAll()
    {
        while (_stack.Count > 0)
        {
            _stack.Pop().Hide();
        }
    }

    public T GetOrCreate<T>() where T : UIScreenBase
    {
        if (_screens.TryGetValue(typeof(T), out UIScreenBase existing)) return (T)existing;
        GameObject go = new GameObject(typeof(T).Name);
        go.transform.SetParent(transform, false);
        T screen = go.AddComponent<T>();
        _screens[typeof(T)] = screen;
        return screen;
    }

    public bool IsTop<T>() where T : UIScreenBase
    {
        return _stack.Count > 0 && _stack.Peek() is T;
    }
}
