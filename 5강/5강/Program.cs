using System.IO.Compression;

internal class Program
{
    private static void Main(string[] args)
    {
        // Problem_if
        // 실습문제 1)

        Console.Write("첫번째 숫자 입력 : ");  
        string a = Console.ReadLine(); //첫번째 숫자(문자열) 입력하기

        Console.Write("두번째 숫자 입력 : ");
        string b = Console.ReadLine(); //두번째 숫자(문자열) 입력하기

        int a1 = int.Parse(a); //첫번쨰 숫자 정수형으로 바꾸기
        int b1 = int.Parse(b); //두번째 숫자 정수형으로 바꾸기

        if (a1 > b1) //첫번째 숫자가 두번쨰 숫자보다 더 큰 경우
        {
            Console.WriteLine("두 수 중에 큰 수는 " + a1 + "이고, 작은 수는 " + b1 + "이다");
        }

        if (a1 < b1) //두번쨰 숫자가 첫번쨰 숫자보다 더 큰 경우
        {
            Console.WriteLine("두 수 중에 큰 수는 " + b1 + "이고, 작은 수는 " + a1 + "이다");
        }

        Console.WriteLine();

        // 실습문제 2)

        Console.Write("숫자 입력");
        string c = Console.ReadLine(); //숫자(문자열) 입력하기

        double c1 = double.Parse(c); //숫자를 정수형으로 바꾸기

        if (c1 < 0) //c1이 음수일때
        {
            Console.WriteLine("입력 값 " + c1 + "는(은) 음수이다");
        }

         if (c1 == 0) //c1이 0일때
        {
            Console.WriteLine("입력 값 " + c1 + "는(은) zero이다");
        }

        if (c1 > 0) //c1이 양수일떄
        {
            Console.WriteLine("입력 값 " + c1 + "는(은) 양수이다");
        }

        Console.WriteLine();

        //실습문제 1-1) 초기화를 이용하여 출력하기
        Console.Write("첫번째 숫자 입력 : ");
        string a_1 = Console.ReadLine();

        Console.Write("두번째 숫자 입력 : ");
        string b_1 = Console.ReadLine();

        int a1_1 = int.Parse(a_1);
        int b1_1 = int.Parse(b_1);

        if (a1_1 > b1_1)
        {
            Console.WriteLine("두 수 중에 큰 수는 {0}이고, 작은 수는 {1}이다", a1_1, b1_1);
        }

        if (a1_1 < b1_1)
        {
            Console.WriteLine("두 수 중에 큰 수는 {0}이고, 작은 수는 {1}이다", b1_1, a1_1);
        }

        //실습문제 1-2) 문자열 보간을 이용하여 출력하기
        Console.Write("첫번째 숫자 입력 : ");
        string a_2 = Console.ReadLine();

        Console.Write("두번째 숫자 입력 : ");
        string b_2 = Console.ReadLine();

        int a1_2 = int.Parse(a_2);
        int b1_2 = int.Parse(b_2);

        if (a1_2 > b1_2)
        {
            Console.WriteLine($"두 수 중에 큰 수는 {a1_2}이고, 작은 수는 {b1_2}이다");
        }

        if (a1 < b1)
        {
            Console.WriteLine($"두 수 중에 큰 수는 {b1_2}이고, 작은 수는 {a1_2}이다");
        }

        //실습문제 3)

        Console.Write("나이 입력 : ");
        string age = Console.ReadLine(); //나이 입력(문자열)
        int age1 = int.Parse(age); //나이 정수형으로 변환

        if (age1 >= 9) //나이가 9살 이상일때
        {
            Console.Write("키 입력 : "); 
            string height = Console.ReadLine(); //키 입력(문자열)
            int height1 = int.Parse(height); //키 정수형으로 변환

            if (height1 >= 130) //키가 130 이상일때
            {
                Console.WriteLine("고속 롤러코스트 입장 가능");
            }

            if (height1 <= 130) //키가 130 미만일떄
            {
                Console.WriteLine("저속 롤러코스트 입장 가능");
            }
        }

        if (age1 < 9) //나이가 9살 미만일때
        {
            Console.WriteLine("입장 불가!");
        }
    }
}