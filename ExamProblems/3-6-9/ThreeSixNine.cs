using System;

class ThreeSixNine
{
    static void Main()
    {
        long result = 0;

        long a = long.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());

        if (b == 3)
        {
            result = a + c;
        }
        else if (b == 6)
        {
            result = a * c;
        }
        else if (b == 9)
        {
            result = a % c;
        }

        if (result % 3 == 0)
        {
            Console.WriteLine(result / 3);
        }
        else
        {
            Console.WriteLine(result % 3);
        }
        Console.WriteLine(result);
    }
}