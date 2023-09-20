internal class Program
{
    private static void Main(string[] args)
    {
        //소수점 표시
       
        //double num = 3.14159265358979323846;

        //Console.WriteLine(num.ToString("0.00"));
        //Console.WriteLine(num.ToString("F2"));
        //Console.WriteLine(num.ToString("F5"));


        //double num1 = 123456789.123456789;
        //Console.WriteLine(num.ToString("E2"));


        //연습문제 3. 원의 반지름을 입력하여 둘레와 넓이 구하기
       
        string Strnum1; //입력할 반지름을 string을 이용해 선언

        double pi = 3.14159; //파이값을 double로 선언

        Console.Write("반지름의 길이 입력하시오 : ");
        Strnum1 = Console.ReadLine(); // 반지름의 길이 읽어오기
        double b = double.Parse(Strnum1); //b를 double로 선언해 string형태로 되어있는 반지름값을 double형으로 강제로 바꿔서 넣기

        double line = 2 * pi * b; //원의 둘레

        double area = pi * b * b; //원의 넓이

        Console.Write("원의 둘레 = ");
        Console.WriteLine(line.ToString("F3")); //원의 둘레가 소수점 3자리 숫자까지만 나오게 하기
        Console.Write("원의 넓이 = ");
        Console.WriteLine(area.ToString("F3")); //원의 넓이가 소수점 3자리 숫자까지만 나오게 하기

        Console.WriteLine();

        //연습문제 4. 콘솔 창에서 한 문자를 입력받아 정수 5를 더한 후 값 출력하기(조건 : Console.Read()와 Convert.ToChar() 포함시키기)

        int letter; //정수 선언
        Console.Write("문자입력 : ");
        letter = Console.Read(); //정수 읽어오기(문자 하나만)

        Console.WriteLine("1. 연산 수행전");
        Console.WriteLine("- 아스키코드 값 : " + letter); //문자가 아스키코드 값을 통해 정수로 변형되어서 출력
        char cletter; //letter을 char형으로 바꿔서 넣을 변수 선언
        cletter = Convert.ToChar(letter); //letter을 char형태로 바꿔 cletter에 넣기
        Console.WriteLine("- 변환된 문자 출력 : " + cletter); //문자 출력

        Console.WriteLine();

        Console.WriteLine("2. 연산 수행 후");
        Console.WriteLine("- 아스키코드 값 : " + (letter + 5)); //문자가 아스키코드 값을 통해 정수로 변형되어서 출력
        int letter2 = letter + 5; 
        char cletter2; //letter2을 char형으로 바꿔서 넣을 변수 선언 
        cletter2 = Convert.ToChar(letter2); //letter2을 char형태로 바꿔 cletter2에 넣기
        Console.WriteLine("- 변환된 문자 출력 : " + cletter2); //문자 출력





    }

}