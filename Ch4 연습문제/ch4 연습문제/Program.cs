internal class Program
{
    private static void Main(string[] args)
    {
        int i = 0;
        while (true)
        {
            Console.Write("나이 입력(종료 : exit) : ");
            int age = int.Parse(Console.ReadLine());

            if (age < 9)
            {
                Console.WriteLine("입장 불가!");
                Console.WriteLine("-------------------------------------------");
            }

            else
            {
                Console.Write("키 입력 : ");
                int height = int.Parse(Console.ReadLine());
                if (height < 130)
                {
                    Console.WriteLine("저속 롤러코스터 입장 가능");
                    Console.WriteLine("----------------------------------------")
                }

                else
                {
                    Console.WriteLine("고속 롤러코스터 입장 가능");
                    Console.WriteLine("----------------------------------------")
                }

            }

        }
    }
}