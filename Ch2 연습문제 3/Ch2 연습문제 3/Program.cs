internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("원의 반지름을 입력하시오 : ");
        string a = Console.ReadLine();
        double len = double.Parse(a);

        double pi = 3.14;

        double round = 2 * pi * len;
        double area = pi * len * len;

        Console.Write("둘레 = ");
        Console.WriteLine(round.ToString("0.000"));

        Console.Write("넓이 = ");
        Console.WriteLine(area.ToString("0.000"));


    }
}