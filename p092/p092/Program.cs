internal class Program
{
    private static void Main(string[] args)
    {
        string output = "hello ";
        output += "world ";
        output += "!";

        Console.WriteLine(output);

        Console.WriteLine();

        string output2 = "hello ";
        output2 = output2 + "world ";
        output2 = output2 + "!";

        Console.WriteLine(output2);

    }
}