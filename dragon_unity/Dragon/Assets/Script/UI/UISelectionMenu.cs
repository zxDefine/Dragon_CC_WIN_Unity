using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UISelectionMenu : MonoBehaviour
{
    public GameObject buttonPrefab;
    public Transform sceneLayer;  // 目标父对象：LayerCanvas/screens

    private string _selectedLabel = null;
    private bool _isShow = false;
    
    private List<GameObject> _buttons = new List<GameObject>(); // 分支按钮
    
    void Start()
    {
        if (buttonPrefab == null)
        {
            Debug.LogError("buttonPrefab 未赋值！");
        }

        if (sceneLayer == null)
        {
            Debug.LogError("sceneLayer 未赋值！");
        }
    }

    public IEnumerator OpenMenu(SelectInfo selectInfo)
    {
        // 0.让ui有效
        gameObject.SetActive(true);
        _isShow = true;
        _selectedLabel = null;
        
        // 1. 长度校验
        if (selectInfo.textList.Count != selectInfo.labelList.Count)
        {
            Debug.LogError("SelectInfo: textList 和 labelList 数量不一致！");
            yield break;
        }

        // 3. 动态生成按钮
        
        // 计算各个按键的y
        int count = selectInfo.textList.Count;
        float spacing = 50;
        // 计算起始Y：让最中间的按钮（或按钮组）对齐中心
        float startY;
        if (count % 2 == 0)
        {
            // 偶数：从 -(n/2 - 0.5) * spacing 开始
            startY = -((count / 2f - 0.5f) * spacing);
        }
        else
        {
            // 奇数：从 -(n/2) * spacing 开始
            startY = -((count / 2) * spacing);
        }
        for (int i = 0; i < selectInfo.textList.Count; i++)
        {
            string text = selectInfo.textList[i];
            string label = selectInfo.labelList[i];

            // 生成按键的GameObject
            GameObject go = Instantiate(buttonPrefab, sceneLayer);
            go.name = "Choice_" + label;
            _buttons.Add(go);
            
            // 设置按键内容
            Button btn = go.GetComponent<Button>();
            TextMeshProUGUI btnText = go.GetComponentInChildren<TextMeshProUGUI>();
            btnText.text = text;
            
            // 确保按键有启用
            btn.interactable = true;
            
            // 设置按键位置
            RectTransform rt = btn.GetComponent<RectTransform>();
            float y = startY - i * spacing;
            rt.anchoredPosition = new Vector2(0f, y);
            
            // 设置按键处理
            btn.onClick.AddListener(() =>
            {
                _selectedLabel = label;
                Debug.Log("选择了：" + _selectedLabel);
            });
        }
        
        // 设置layerCanvas的raycaster，使得ui可以控制
        SetGraphRaycaster(true);

        // 4. 等待选择完成
        while (_selectedLabel == null)
        {
            yield return null;   
        }

        // 5. 清理 UI
        // foreach (GameObject btn in _buttons)
        // {
        //     Destroy(btn);
        // }

        // 6. 跳转处理
        yield return OnSelect(_selectedLabel);
    }

    private IEnumerator OnSelect(string label)
    {
        // 关闭ui
        CloseMenu();
        
        Debug.Log($"→ 跳转到 label：{label}");
        // 你可以在这里根据 label 名字去调用对应的跳转逻辑
        // 比如调用 Lua、Renpy、剧情控制器等
        
        // 跳转函数
        GameObject go = GameObject.Find("Game Methods");
        if (go == null)
        {
            // 找不到，直接返回
            Debug.LogError("Error - selectionMenu - gameobject is not exist");
            yield break;
        }

        GameMethods gm = go.GetComponent<GameMethods>();
        if (gm == null)
        {
            // 组件没挂，返回false
            Debug.LogError("Error - selectionMenu - GameMethods is not exist");
            yield break;
        }
        yield return gm.ChangeLabelTo(label);
    }

    private void SetGraphRaycaster(bool enable)
    {
        CanvasGroup cg = sceneLayer.gameObject.GetComponent<CanvasGroup>();
        cg.blocksRaycasts = enable;
    }

    private void CloseMenu()
    {
        _isShow = false;
        
        // 使得ui不可控
        SetGraphRaycaster(false);
        
        foreach (GameObject btn in _buttons)
        {
            Debug.Log($"close -> {btn.name}");
            Destroy(btn);
        }
    }

    void Update()
    {
        // test
        if (Input.GetMouseButtonDown(0))
        {
            PointerEventData pointerData = new PointerEventData(EventSystem.current)
            {
                position = Input.mousePosition
            };

            List<RaycastResult> results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(pointerData, results);

            foreach (var result in results)
            {
                Debug.Log("点击命中了：" + result.gameObject.name);
            }
        }
    }

    public bool IsShow()
    {
        return _isShow;
    }
}