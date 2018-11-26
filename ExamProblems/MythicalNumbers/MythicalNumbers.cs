using System;

class MythicalNumbers
{
    static void Main()
    {
        int abc = int.Parse(Console.ReadLine());
        int a = (abc / 100) % 10;
        int b = (abc / 10) % 10;
        int c = abc % 10;

        double result;

        if (c == 0)
        {
            result = a * b;
        }
        else if (c <= 5)
        {
            result = a * b / (double)c;
        }
        else
        {
            result = (a + c) * c;
        }
        Console.WriteLine($"{result:F2}");
    }
}