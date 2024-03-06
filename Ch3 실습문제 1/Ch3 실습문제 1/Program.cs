internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("첫번째 숫자 입력 : ");
        string a = Console.ReadLine();
        Console.Write("두번째 숫자 입력 : ");
        string b = Console.ReadLine();

        int num1 = int.Parse(a);
        int num2 = int.Parse(b);

        if (num1 > num2)
        {
            Console.WriteLine("두 수 중에 큰 수는 " + num1 + "이고, 작은 수는 " + num2 + "이다");
        }

        if (num2 > num1)
        {
            Console.WriteLine("두 수 중에 큰 수는 " + num2 + "이고, 작은 수는 " + num1 + "이다");
        }

    }
}