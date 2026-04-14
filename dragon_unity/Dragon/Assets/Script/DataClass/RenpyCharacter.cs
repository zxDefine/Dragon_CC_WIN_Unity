using System;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class RenpyCharacter
{
    private string _name;
    private string _voiceTag;
    private string _whatPrefix;
    private string _whatSuffix;
    
    Dictionary<string, object> _characterImageDict = new Dictionary<string, object>();
    Dictionary<string, object> _characterPartsDict = new Dictionary<string, object>();

    public RenpyCharacter(Dictionary<string, object> characterImageDict)
    {
        _characterImageDict = characterImageDict;
        
        // 读取默认信息
        LoadBaseInfo();

        // 读取对应的image
        LoadImage();
        
        // 测试
        // PrintDict(_characterPartsDict, 0);
    }
    
    private void LoadBaseInfo()
    {
        if (_characterImageDict.ContainsKey("name"))
        {
            _name = _characterImageDict["name"].ToString();
        }

        if (_characterImageDict.ContainsKey("voice_tag"))
        {
            _voiceTag = _characterImageDict["voice_tag"].ToString();
        }

        if (_characterImageDict.ContainsKey("what_prefix"))
        {
            _whatPrefix = _characterImageDict["what_prefix"].ToString();
        }

        if (_characterImageDict.ContainsKey("what_suffix"))
        {
            _whatSuffix = _characterImageDict["what_suffix"].ToString();
        }
    }

    private void LoadImage()
    {
        if (_characterImageDict.ContainsKey("image_info"))
        {
            Dictionary<string, object> imageInfo = _characterImageDict["image_info"] as Dictionary<string, object>;
            if (imageInfo.ContainsKey("image"))
            {
                // image名
                string imageName = imageInfo["image"] as string;
                
                // 读取image
                // ImageManger.Instance.LoadImage(imageName);
                
                _characterPartsDict["image"] = imageName;
            }
            if (imageInfo.ContainsKey("rect"))
            {
                _characterPartsDict["image_rect"] = new List<float>();
                List<float> floatList = _characterPartsDict["image_rect"] as List<float>;
                foreach (var num in imageInfo["rect"] as List<object>)
                {
                    floatList.Add(Convert.ToSingle(num));
                }
            }
            if (imageInfo.ContainsKey("zoom"))
            {
                _characterPartsDict["image_zoom"] = Convert.ToSingle(imageInfo["zoom"]);
            }
            if (imageInfo.ContainsKey("side_pos"))
            {
                _characterPartsDict["image_side_pos"] = new List<float>();
                List<float> floatList = _characterPartsDict["image_side_pos"] as List<float>;
                foreach (var num in imageInfo["side_pos"] as List<object>)
                {
                    floatList.Add(Convert.ToSingle(num));
                }
            }
        }
    }

    public string GetCharacterName()
    {
        return _name;
    }

    public List<string> GetCharacterTalkSymbol()
    {
        return new List<string> {_whatPrefix, _whatSuffix};
    }

    public string GetImageName()
    {
        return _characterPartsDict["image"] as string;
    }
    
    public List<float> GetRectList()
    {
        if (_characterPartsDict.ContainsKey("image_rect"))
        {
            return _characterPartsDict["image_rect"] as List<float>;   
        }
        return null;
    }
    
    public float GetImageZoom()
    {
        if (_characterPartsDict.ContainsKey("image_zoom"))
        {
            return (float)_characterPartsDict["image_zoom"];
        }

        return 1.0f;
    }
    
    public List<float> GetImageSidePos()
    {
        if (_characterPartsDict.ContainsKey("image_side_pos"))
        {
            return _characterPartsDict["image_side_pos"] as List<float>;   
        }
        return null;
    }
    
    // test用函数
    private void PrintDict(Dictionary<string, object> dict, int indent)
    {
        string prefix = new string(' ', indent * 2);
        foreach (var kvp in dict)
        {
            if (kvp.Value is Dictionary<string, object> nested)
            {
                Debug.Log($"{prefix}{kvp.Key}:");
                PrintDict(nested, indent + 1);
            }
            else
            {
                Debug.Log($"{prefix}{kvp.Key}: {kvp.Value}");
            }
        }
    }
}