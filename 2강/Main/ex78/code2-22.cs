using System.Runtime.ConstrainedExecution;
using System.Xml;

internal class code
{
    private static void Main(string[] args)
    {
        Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);
        Console.WriteLine(3 < DateTime.Now.Hour && DateTime.Now.Hour < 8);

        int a = -2147483648;
        int b = 1;

        Console.WriteLine(a + b);
        Console.WriteLine();

        int c = 2000000000;
        int d = 1000000000;
        Console.WriteLine(c + d);
        Console.WriteLine();
        uint unsignedInt = 4147483647;
        ulong unsignedLong = 11223372036854775808;

        Console.WriteLine(unsignedInt);
        Console.WriteLine(unsignedLong);
        Console.WriteLine();

        double e = 52.273;
        double f = 103.32;

        Console.WriteLine(e + f);
        Console.WriteLine(e - f);
        Console.WriteLine(e * f);
        Console.WriteLine(e / f);
        Console.WriteLine();

        char g = 'a';
        Console.WriteLine(g);
        Console.WriteLine();

        Console.WriteLine("int : " + sizeof(int));
        Console.WriteLine("int : " + sizeof(long));
        Console.WriteLine("int : " + sizeof(float));
        Console.WriteLine("int : " + sizeof(double));
        Console.WriteLine("int : " + sizeof(char));
        Console.WriteLine();

        char h = 'A';
        char i = 'B';

        Console.WriteLine(h + i);
        Console.WriteLine(h - i);
        Console.WriteLine(h * i);
        Console.WriteLine(h / i);
        Console.WriteLine(h % i);
        Console.WriteLine((int)h);
        Console.WriteLine((int)i);
        Console.WriteLine();
        Console.WriteLine(h + " : " + h * 1);
        Console.WriteLine(i + " : " + i * 1);
        Console.WriteLine();

        string message = "반갑습니다";
       
        Console.WriteLine(message + "!");
        Console.WriteLine(message[0]);
        Console.WriteLine(message[1]);
        Console.WriteLine(message[2]);
        Console.WriteLine();

        bool one = 10 < 0;
        bool other = 20 > 30;

        Console.WriteLine(one);
        Console.WriteLine(other);
    }
}
