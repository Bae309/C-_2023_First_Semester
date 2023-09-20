using System;
using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello,\tWorld!");
        Console.Write("Hello\nWorld!");
        Console.WriteLine("Hello, World!");

        Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);
        Console.WriteLine(3 < DateTime.Now.Hour && DateTime.Now.Hour < 8);
    }
}