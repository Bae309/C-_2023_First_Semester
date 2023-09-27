internal class Program
{
    private static void Main(string[] args)
    {
        // 실습문제 4)
        /*Console.Write("2자리 숫자 입력(10~99) : ");
        string num = Console.ReadLine();
        int num1 = int.Parse(num);

        if (num1 < 10 || num1 > 99)
        {
            Console.WriteLine("10~99사이의 정수만 입력하세요.");
        }

        if ((num1 >= 10) && (num1 <= 99))
        {
            if (num[0] == num[1])
            {
                Console.WriteLine("Yes! 10의 자리와 1의 자리가 같습니다! ");
            }

            if (num[0] != num[1])
            {
                Console.WriteLine("No! 10의 자리와 1의 자리가 같지 않습니다.");
            }
        }

        // 실습문제 4-1)
        Console.Write("2자리 숫자 입력(10~99) : ");
        string a = Console.ReadLine();
        int a1 = int.Parse(a);

        if (a1 < 10 || a1 > 99)
        {
            Console.WriteLine("10~99사이의 정수만 입력하세요.");
        }

        if ((a1 >= 10) && (a1 <= 99))
        {
            if (a1/10 == a1%10)
            {
                Console.WriteLine("Yes! 10의 자리와 1의 자리가 같습니다! ");
            }

            if (a1 / 10 != a1 % 10)
            {
                Console.WriteLine("No! 10의 자리와 1의 자리가 같지 않습니다.");
            }
        }

        // 실습문제 4-2)
        Console.Write("2자리 숫자 입력(10~99) : ");
        string a = Console.ReadLine();
        int a1 = int.Parse(a);

        if (a1 < 10 || a1 > 99)
        {
            Console.WriteLine("10~99사이의 정수만 입력하세요.");
        }

        if ((a1 >= 10) && (a1 <= 99))
        {
            if (a1 / 11 == 0)
            {
                Console.WriteLine("Yes! 10의 자리와 1의 자리가 같습니다! ");
            }

            if (a1 / 11 != 0)
            {
                Console.WriteLine("No! 10의 자리와 1의 자리가 같지 않습니다.");
            }
        }*/
        

        // 실습문제 5)
        Console.Write("정수 3개 입력 : ");
        string n1 = Console.ReadLine();
        string n2 = Console.ReadLine();
        string n3 = Console.ReadLine();

        int n1_1 = int.Parse(n1);
        int n2_1 = int.Parse(n2);
        int n3_1 = int.Parse(n3);

        if ((n1_1 > n2_1) && (n2_1 > n3_1))
        {
            Console.WriteLine("중간 값은  : " + n2_1);
        }

        if ((n3_1 > n2_1) && (n2_1 > n1_1))
        {
            Console.WriteLine("중간 값은  : " + n2_1);
        }

        if ((n2_1 > n1_1) && (n1_1 > n3_1))
        {
            Console.WriteLine("중간 값은  : " + n1_1);
        }

        if ((n3_1 > n1_1) && (n1_1 > n2_1))
        {
            Console.WriteLine("중간 값은  : " + n1_1);
        }

        if ((n2_1 > n3_1) && (n3_1 > n1_1))
        {
            Console.WriteLine("중간 값은  : " + n3_1);
        }

        if ((n1_1 > n3_1) && (n3_1 > n2_1))
        {
            Console.WriteLine("중간 값은  : " + n3_1);
        }


        //연습문제 7)

        Console.Write("태어난 연도 입력 : ");
        string year = Console.ReadLine();
        int year1 = int.Parse(year);


    }
}