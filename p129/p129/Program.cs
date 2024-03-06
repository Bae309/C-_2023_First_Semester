internal class Program
{
    private static void Main(string[] args)
    {
        if (DateTime.Now.Hour < 12)
        {
            Console.WriteLine("오전입니다.");
        }

        if (12 <= DateTime.Now.Hour)
        {
            Console.WriteLine("오후입니다.");
        }
    }
}