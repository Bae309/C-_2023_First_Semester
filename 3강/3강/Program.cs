internal class Program
{
    private static void Main(string[] args)
    {
        /*char character = 'a';
        string outputB = character + "";
        Console.WriteLine(outputB);*/

        /*double number = 52.276103;
        Console.WriteLine(number.ToString("0.0"));
        Console.WriteLine(number.ToString("0.00"));
        Console.WriteLine(number.ToString("0.000"));
        Console.WriteLine(number.ToString("0.0000"));*/

        /*Console.Write("값을 입력하세요 : ");
        string inch = Console.ReadLine(2.54);
        string cm = Console.ReadLine();

        Console.WriteLine(double.Parse(inch));
        Console.WriteLine(int.Parse(cm));*/

        //연습문제 1. inch단위를 cm로 변환해서 출력하기

        /*String strnum1;

        Console.Write("inch 입력 : ");
        strnum1 = Console.ReadLine();
      

        Console.WriteLine((2.54 * double.Parse(strnum1)) + "cm 입니다.");*/

        //연습문제 2. 두 숫자를 입력하여 사칙연산 출력하기

        /*string Strnum1;
        string Strnum2;

        Console.Write("첫번째 숫자 입력 : ");
        Strnum1 = Console.ReadLine();

        Console.Write("두번째 숫자 입력 : ");
        Strnum2 = Console.ReadLine();

        Console.WriteLine(double.Parse(Strnum1) + " + " + double.Parse(Strnum2) + " = " + (double.Parse(Strnum1) + double.Parse(Strnum2)));

        Console.WriteLine(double.Parse(Strnum1) + " - " + double.Parse(Strnum2) + " = " + (double.Parse(Strnum1) - double.Parse(Strnum2)));

        Console.WriteLine(double.Parse(Strnum1) + " * " + double.Parse(Strnum2) + " = " + (double.Parse(Strnum1) * double.Parse(Strnum2)));

        Console.WriteLine(double.Parse(Strnum1) + " / " + double.Parse(Strnum2) + " = " + (double.Parse(Strnum1) / double.Parse(Strnum2)));*/

        string Strnum1;
        string Strnum2;

        Console.Write("첫번째 숫자 입력 : ");
        Strnum1 = Console.ReadLine();

        Console.Write("두번째 숫자 입력 : ");
        Strnum2 = Console.ReadLine();

        double num1 = double.Parse(Strnum1);
        double num2 = double.Parse(Strnum2);


        Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));

        Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));

        Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));

        Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));





    }
}