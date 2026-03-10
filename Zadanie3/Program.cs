using System;
using System.ComponentModel;
class MainProgram
{
    static void Main()
    {
        UserInterace.PrintMenu();
    }
}
class UserInterace
{
    public static void PrintMenu()
    {
        Console.WriteLine("Введите текст для шифровки (замена муха на слона):");
        string text = Console.ReadLine();

        string encryptedText = Logic.GetEncryptedText(text);
        Console.WriteLine("Результат:");
        Console.WriteLine(encryptedText);
    }
}
public class Logic
{
    
    public static string GetEncryptedText(string text)
    {
        if (string.IsNullOrEmpty(text)) return "";
        return text.Replace("муха", "слон");
    }
}

