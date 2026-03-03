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

        string shifr = text.Replace("муха", "слон");
        Console.WriteLine("Результат:");
        Console.WriteLine(shifr);
    }
}

