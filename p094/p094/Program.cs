internal class Program
{
    private static void Main(string[] args)
    {
        int number = 10;
        Console.WriteLine(number);
        Console.WriteLine(number++);
        Console.WriteLine(number--);
        Console.WriteLine(number);
        Console.WriteLine();

        Console.WriteLine(number);
        Console.WriteLine(++number);
        Console.WriteLine(--number);
        Console.WriteLine(number);
        Console.WriteLine();

        Console.WriteLine(number);
        Console.WriteLine(number); number += 1;
        Console.WriteLine(number); number -= 1;
        Console.WriteLine(number);
        Console.WriteLine();

        Console.WriteLine(number++);
        Console.WriteLine(++number);
        Console.WriteLine(number--);
        Console.WriteLine(--number);
        Console.WriteLine();

        Console.WriteLine(number);
        number++;
        number++;
        Console.WriteLine(number);
        Console.WriteLine(number);
        number--;
        number--;
        Console.WriteLine(number);
        Console.WriteLine();

    }
}