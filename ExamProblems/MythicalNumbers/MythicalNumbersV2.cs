using System;

class MythicalNumbersV2
{
    static void Main()
    {
        string abc = Console.ReadLine();
        int a = abc[0] - '0';
        int b = abc[1] - '0';
        int c = abc[2] - '0';

        double result = 0;
        if (c == 0)
        {
            result = a * b;
        }
        else if (c <= 5)
        {
            result = (a * b) / (double)c;
        }
        else if (c > 5)
        {
            result = (a + b) * c;
        }
        Console.WriteLine("{0:F2}", result);
    }
}