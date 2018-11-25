using System;

class ThreeNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a >= b && a >= c)
        {
            Console.WriteLine(a);
        }
        else if (b >= a && b >= c)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(c);
        }

        if (a <= b && a <= c)
        {
            Console.WriteLine(a);
        }
        else if (b <= a && b <= c)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(c);
        }

        decimal arithmeticMean = (a + b + c) / 3.0m;

        Console.WriteLine("{0:F2}", arithmeticMean);
    }
}