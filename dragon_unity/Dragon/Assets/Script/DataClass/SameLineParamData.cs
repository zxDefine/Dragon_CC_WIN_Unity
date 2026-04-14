using System.Collections.Generic;
using UnityEngine;

public class SameLineParamData
{
    public Dictionary<string, object> paramDict = new Dictionary<string, object>();

    public SameLineParamData(Dictionary<string, object> dict)
    {
        paramDict = dict;
    }
    
    
    // debug用
    public void DebugLog()
    {
        foreach (var item in paramDict)
        {
            Debug.Log(item.Key + " : " + item.Value);
        }
    }
}