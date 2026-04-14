using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public static class JsonHelper
{
    public static Dictionary<string, object> ParseJsonToNestedDict(string json)
    {
        var jObject = JsonConvert.DeserializeObject<JObject>(json);
        return ParseJToken(jObject);
    }

    private static Dictionary<string, object> ParseJToken(JToken token)
    {
        var dict = new Dictionary<string, object>();

        foreach (var child in token.Children<JProperty>())
        {
            var key = child.Name;
            var value = child.Value;

            if (value.Type == JTokenType.Object)
            {
                dict[key] = ParseJToken(value); // 递归解析对象
            }
            else if (value.Type == JTokenType.Array)
            {
                dict[key] = ParseJArray(value as JArray);
            }
            else
            {
                dict[key] = ((JValue)value).Value; // 解析基本类型
            }
        }

        return dict;
    }

    private static List<object> ParseJArray(JArray array)
    {
        var list = new List<object>();

        foreach (var item in array)
        {
            if (item.Type == JTokenType.Object)
                list.Add(ParseJToken(item));
            else if (item.Type == JTokenType.Array)
                list.Add(ParseJArray((JArray)item));
            else
                list.Add(((JValue)item).Value);
        }

        return list;
    }
}