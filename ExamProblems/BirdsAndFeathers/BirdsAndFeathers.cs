using System;

class BirdsAndFeathers
{
    static void Main()
    {
        int b = int.Parse(Console.ReadLine());
        long f = long.Parse(Console.ReadLine());

        double ave = (double)f / b;

        if (b == 0)
        {
            ave = 0;
        }
        if (b % 2 == 0)
        {
            ave *= 123123123123;
        }
        if (b % 2 == 1)
        {
            ave /= 317;
        }
        Console.WriteLine("{0:F4}", ave);
    }
}