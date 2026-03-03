using System;
using System.ComponentModel;
class B
{
    static void Main()
    {
        BPLA.Elllo();
    }
}
class BPLA
{
    public static void Elllo()
    {
        Console.WriteLine("Введите текст для шифровки (замена муха на слона):");
        string text = Console.ReadLine();

        string shifr = LogicBPLA.GetMena(text);
        Console.WriteLine("Результат:");
        Console.WriteLine(shifr);
    }
}
public class LogicBPLA
{
    
    public static string GetMena(string text)
    {
        if (string.IsNullOrEmpty(text)) return "";
        return text.Replace("муха", "слон");
    }
}

