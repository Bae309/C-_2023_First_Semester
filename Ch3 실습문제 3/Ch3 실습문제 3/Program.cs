internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("나이 입력 : ");
        string a = Console.ReadLine();

        int age = int.Parse(a);

        if (age < 9)
        {
            Console.WriteLine("입장 불가!");
        }

        if (age >= 9)
        {
            Console.Write("키 입력 : ");
            string b = Console.ReadLine();
            int height = int.Parse(b);

            if (height < 130)
            {
                Console.WriteLine("저속 롤러코스터 입장 가능");
            }

            if (height >= 130)
            {
                Console.WriteLine("고속 롤러코스터 입장 가능");
            }
        }
    }
}