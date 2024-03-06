internal class Program
{
    private static void Main(string[] args)
    {
        int a = 2000000000;
        int b = 1000000000;

        Console.WriteLine(a + b);

        Console.WriteLine("------------------------------");

        uint unsignedInt = 4147483647;
        ulong unsignedLong = 11223372036854775808;

        Console.WriteLine(unsignedInt);
        Console.WriteLine(unsignedLong);
    }
}