internal class Program
{
    private static void Main(string[] args)
    {
        double number = 52.276103;
        Console.WriteLine(number.ToString("0.0"));
        Console.WriteLine(number.ToString("0.00"));
        Console.WriteLine(number.ToString("0.000"));
        Console.WriteLine(number.ToString("0.0000"));

        Console.WriteLine();

        Console.WriteLine(52 + 273);
        Console.WriteLine("52" + 273);
        Console.WriteLine(52 + "273");
        Console.WriteLine("52" + "273");

    }
}