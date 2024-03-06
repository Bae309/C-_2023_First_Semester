internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("문자 입력 : ");
        int a1 = Console.Read();
        char b1 = Convert.ToChar(a1);

        char b2 = Convert.ToChar(a1 + 5);

        Console.WriteLine("1. 연산 수행 전 ");
        Console.WriteLine("- 아스키코드 값 : " + a1);
        Console.WriteLine("- 변환된 문자 출력 : " + b1);

        Console.WriteLine("1. 연산 수행 전 ");
        Console.WriteLine("- 아스키코드 값 : " + (a1 + 5));
        Console.WriteLine("- 변환된 문자 출력 : " + b2);

    }
}