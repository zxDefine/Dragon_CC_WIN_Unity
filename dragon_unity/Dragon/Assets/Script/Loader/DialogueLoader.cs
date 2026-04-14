using System;
using System.Collections.Generic;
using System.IO;

public class DialogueInfo
{
    public string Dialogue { get; set; }
    public string FilePath { get; set; }
    
    public DialogueInfo(string dialogue, string filePath)
    {
        Dialogue = dialogue;
        FilePath = filePath;
    }
};

public class DialogueLoader
{
    public static Dictionary<int, DialogueInfo> LoadDialogues(string filePath)
    {
        var result = new Dictionary<int, DialogueInfo>();
        int id = 0;

        foreach (var line in File.ReadLines(filePath))
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            int commaIndex = line.LastIndexOf(',');
            if (commaIndex == -1)
            {
                Console.WriteLine($"跳过无法解析的行: {line}");
                continue;
            }

            string dialogue = line.Substring(0, commaIndex).Trim().Trim('"');
            string path = line.Substring(commaIndex + 1).Trim();

            var info = new DialogueInfo(dialogue, path);
            result[id++] = info;
        }

        return result;
    }

    // 用于测试
    // public static void Main()
    // {
    //     string path = "Assets/Resources/dialogue.txt"; // 你的txt文件路径
    //     var dialogues = LoadDialogues(path);
    //
    //     foreach (var kvp in dialogues)
    //     {
    //         Console.WriteLine($"ID: {kvp.Key}");
    //         Console.WriteLine($"对话: {kvp.Value.Dialogue}");
    //         Console.WriteLine($"路径: {kvp.Value.FilePath}");
    //         Console.WriteLine("-----------------------------");
    //     }
    // }
}