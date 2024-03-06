internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("2자리 정수 입력(10~99) : ");
        string a = Console.ReadLine();
        int num = int.Parse(a);

        if(num > 99 || num < 10)
        {
            Console.WriteLine("10~99 사이의 정수만 입력하세요");
        }

        if (num >= 10 && num <=99)
        {
            if(num % 11==0)
            {
                Console.WriteLine("Yes! 10의 자리와 1의 자리가 같습니다.");
            }

            else
            {
                Console.WriteLine("No, 10의 자리와 1의 자리가 다릅니다.");
            }
        }
    }
}