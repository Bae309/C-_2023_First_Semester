internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("피라미드 높이를 입력하시오 : ");
        int height = int.Parse(Console.ReadLine());

        for (int i = 1; i < height; i++)
        {
            for (int j = 1; j <= height - i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= (2 * i) - 1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

    }
}