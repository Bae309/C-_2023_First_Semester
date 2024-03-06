internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("숫자 입력 : ");
        string a = Console.ReadLine();
        int num = int.Parse(a);

        if (num < 0)
        {
            Console.WriteLine("입력 값 " + num + "는(은) 음수이다.");
        }

        if (num == 0)
        {
            Console.WriteLine("입력 값 " + num + "은 Zero이다.");
        }

        if (num > 0)
        {
            Console.WriteLine("입력 값 " + num + "는(은) 양수이다.");
        }
    }
}