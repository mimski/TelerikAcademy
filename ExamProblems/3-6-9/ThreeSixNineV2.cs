using System;

class ThreeSixNineV2
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        byte b = byte.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());

        long r1 = 0;
        switch (b)
        {
            case 3: r1 = a + c; break;
            case 6: r1 = a * c; break;
            case 9: r1 = a % c; break;
        }

        long r2 = r1 % 3 == 0 ? (r1 / 3) : (r1 % 3);

        Console.WriteLine(r2);
        Console.WriteLine(r1);
    }
}