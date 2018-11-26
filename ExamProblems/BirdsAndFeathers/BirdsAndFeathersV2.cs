using System;

class BirdsAndFeathersV2
{
    static void Main()
    {
        int b = int.Parse(Console.ReadLine());
        long f = long.Parse(Console.ReadLine());

        double ave = 0;

        if (b != 0)
        {
            ave = (double)f / b;

            if (b % 2 == 0) //if even
            {
                ave *= 123123123123;
            }
            else //if (b % 2 == 1) //if odd
            {
                ave /= 317;
            }
        }
        Console.WriteLine("{0:F4}", ave);
    }
}