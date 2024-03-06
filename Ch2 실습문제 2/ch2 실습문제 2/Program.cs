internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("1. 첫번째 정수 입력 : ");
        string a = Console.ReadLine();

        Console.Write("2. 두번쨰 정수 입력 : ");
        string b = Console.ReadLine();

        double num1 = double.Parse(a);
        double num2 = double.Parse(b);
        double result = num1 / num2;

        Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
        Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
        Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
        Console.Write(num1 + " / " + num2 + " = ");
        Console.WriteLine(result.ToString("0.0"));


    }
}