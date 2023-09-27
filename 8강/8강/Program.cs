using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        int i = 0; //초기 변수 선언

        Console.Write("배열의 크기 입력 : "); //배열의 크기 입력하기
        string number = Console.ReadLine();
        int number2 = Convert.ToInt32(number);

        int[] array = new int[number2]; //지정한 배열의 개수만큼 내용 입력하기 
        Console.WriteLine($"배열 {number2}개를 입력하시오");
        while (i < number2)
        {
            Console.Write((i + 1) + "번째 입력 : ");
            array[i] = int.Parse(Console.ReadLine());
            i++;
        }

        Console.WriteLine();
        i = 0;

        while (i < array.Length)
        {
            Console.WriteLine((i+1) + "번째 출력 : " + array[i]);

            i++;
        }

        Console.WriteLine();
        i = 0;

        int sum = 0;

        while (i < array.Length)
        {
            sum = sum + array[i];
            i++;
        }
        Console.WriteLine(sum);
    }
}