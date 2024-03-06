internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("변환할 정수 하나를 입력하시오 : ");
        string a = Console.ReadLine();
        double num = double.Parse(a);

        Console.WriteLine(num + "cm = " + (num * 2.54));
    }
}