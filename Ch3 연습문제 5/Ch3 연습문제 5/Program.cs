internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("정수 3개 입력 : ");
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        string c = Console.ReadLine();

        int num1 = int.Parse(a);
        int num2 = int.Parse(b);
        int num3 = int.Parse(c);

        if ((num3 > num1 && num1 > num2)|| (num2 > num1 && num1 > num3))
        {
            Console.WriteLine("중간 값은 : " + num1);
        }

        if ((num3 > num2 && num2 > num1) || (num1 > num2 && num2 > num3))
        {
            Console.WriteLine("중간 값은 : " + num2);
        }

        if ((num2 > num3 && num3 > num1) || (num1 > num3 && num3 > num2))
        {
            Console.WriteLine("중간 값은 : " + num3);
        }
    }
}