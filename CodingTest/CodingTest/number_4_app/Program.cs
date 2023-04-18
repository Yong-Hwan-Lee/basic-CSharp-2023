using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> rainbowColors = new Dictionary<string, string>()
        {
            {"빨간색", "Red"},
            {"주황색", "Orange"},
            {"노란색", "Yellow"},
            {"초록색", "Green"},
            {"파란색", "Blue"},
            {"남색", "Indigo"},
            {"보라색", "Purple"}
        };
        Console.Write("무지개 색은");
        foreach (KeyValuePair<string, string> color in rainbowColors)
        {
            Console.Write(" {0},", color.Key);
        }
        Console.WriteLine("입니다.");

        Console.WriteLine("Key와 Value 확인");
        string targetColor = "Purple";
        foreach (KeyValuePair<string, string> color in rainbowColors)
        {
            if (color.Value == targetColor)
            {
                Console.WriteLine("{0}은 {1}입니다.", targetColor, color.Key);
                break;
            }
        }
    }
}
