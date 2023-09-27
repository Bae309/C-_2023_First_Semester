internal class Program
{
    private static void Main(string[] args)
    {
        //실습문제 1

        /*Console.Write("2자리 숫자 입력(10~99) : ");
        string a = Console.ReadLine();
        int a1 = int.Parse(a);

        if (a1 < 10)
        {
            Console.WriteLine("10~99사이의 정수만 입력하세요.");
        }

        else if(a1 > 99)
        {
            Console.WriteLine("10~99사이의 정수만 입력하세요.");
        }

        else 
        {
            if (a1 / 10 == a1 % 10)
            {
                Console.WriteLine("Yes! 10의 자리와 1의 자리가 같습니다! ");
            }

            else 
            {
                Console.WriteLine("No! 10의 자리와 1의 자리가 같지 않습니다.");
            }
        }*/

        // 실습문제 2
        /*Console.Write("정수 3개 입력 : ");
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

        else if ((n3_1 > n2_1) && (n2_1 > n1_1))
        {
            Console.WriteLine("중간 값은  : " + n2_1);
        }

        else if ((n2_1 > n1_1) && (n1_1 > n3_1))
        {
            Console.WriteLine("중간 값은  : " + n1_1);
        }

        else if ((n3_1 > n1_1) && (n1_1 > n2_1))
        {
            Console.WriteLine("중간 값은  : " + n1_1);
        }

        else if ((n2_1 > n3_1) && (n3_1 > n1_1))
        {
            Console.WriteLine("중간 값은  : " + n3_1);
        }

        else
        {
            Console.WriteLine("중간 값은  : " + n3_1);
        }*/

        //실습문제 3
        Console.Write("점수 입력 : ");
        string s = Console.ReadLine();

        int score = int.Parse(s);

        if (score > 90 && score <= 100)
        {
            Console.WriteLine("A학점");
        }

        else if (score > 80)
        {
            Console.WriteLine("B학점");
        }

        else if (score > 70)
        {
            Console.WriteLine("C학점");
        }

        else if (score > 60)
        {
            Console.WriteLine("D학점");
        }

        else if (score >= 0)
        {
            Console.WriteLine("재수강");
        }

        else
        {
            Console.WriteLine("0에서 100 사이의 숫자만 입력하시오!");
        }

        //실습문제 3-1
        Console.Write("");
        string n1 = Console.ReadLine();
        string n2 = Console.ReadLine();
        string cal = Console.ReadLine();

        double num1 = double.Parse(n1);
        double num2 = double.Parse(n2);

        if (cal == "+")
        {
            Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
        }

        else if (cal == "-")
        {
            Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
        }

        else if (cal == "*")
        {
            Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
        }

        else if (cal == "+")
        {
            Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
        }

        else if (cal == "%")
        {
            Console.WriteLine(num1 + " % " + num2 + " = " + (num1 % num2));
        }

        else
        {
            Console.WriteLine("+, -, *, /, % 중에 하나만 입력해주세요!");
        }

        //실습문제 4
        Console.Write("점수 입력 : ");
        string s1 = Console.ReadLine();

        int score1 = int.Parse(s1);

        switch (score1)
        {
            case 100:
            case 99:
            case 98:
            case 97:
            case 96:
            case 95: 
            case 94:
            case 93:
            case 92:
            case 91:
            case 90:
                Console.WriteLine("A학점");
                break;

            case 89:
            case 88:
            case 87:
            case 86:
            case 85:
            case 84:
            case 83:
            case 82:
            case 81:
            case 80:
                Console.WriteLine("B학점");
                break;

            case 79:
            case 78:
            case 77:
            case 76:
            case 75:
            case 74:
            case 73:
            case 72:
            case 71:
            case 70:
                Console.WriteLine("C학점");
                break;

            case 69:
            case 68:
            case 67:
            case 66:
            case 65:
            case 64:
            case 63:
            case 62:
            case 61:
            case 60:
                Console.WriteLine("D학점");
                break;

            default:
                Console.WriteLine("재수강");
                break;

        }

        //실습문제 4-1
        Console.Write("");
        string n1_1 = Console.ReadLine();
        string n2_1 = Console.ReadLine();
        string cal_1 = Console.ReadLine();

        double num1_1 = double.Parse(n1_1);
        double num2_1 = double.Parse(n2_1);
        char c = Convert.ToChar(cal_1);

        switch(c)
        {
            case '+':
                {
                    Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
                    break;
                }

            case '-':
                {
                    Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
                    break;
                }

            case '*':
                {
                    Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
                    break;
                }

            case '/':
                {
                    Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
                    break;
                }

            case '%':
                {
                    Console.WriteLine(num1 + " % " + num2 + " = " + (num1 % num2));
                    break;
                }

        }

        //실습문제 4
        Console.Write("점수 입력 : ");
        string s2 = Console.ReadLine();

        int score2 = int.Parse(s2);

        switch (score2/10)
        {
            case 9:
                Console.WriteLine("A학점");
                break;

            case 8:
                Console.WriteLine("B학점");
                break;

            case 7:
                Console.WriteLine("C학점");
                break;

            case 6:
                Console.WriteLine("D학점");
                break;

            default:
                Console.WriteLine("재수강");
                break;

        }
    }
}