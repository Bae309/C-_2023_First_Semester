internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("숫자 입력 : ");
        int input = int.Parse(Console.ReadLine());

        if (input % 2 == 0)
        {
            Console.WriteLine("짝수입니다.");
        }

        else
        {
            Console.WriteLine("홀수입니다.");
        }

        Console.WriteLine();

        if (DateTime.Now.Hour < 12)
        {
            Console.WriteLine("오전입니다.");
        }

        else
        {
            Console.WriteLine("오후입니다.");
        }
    
    }
}