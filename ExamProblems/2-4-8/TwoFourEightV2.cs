using System;

class TwoFourEightV2
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        byte b = byte.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());

        long r1 = 0;
        switch (b)
        {
            case 2: r1 = a % c; break;
            case 4: r1 = a + c; break;
            case 8: r1 = a * c; break;
        }

        long r2 = r1 % 4 == 0 ? (r1 / 4) : (r1 % 4);

        Console.WriteLine(r2);
        Console.WriteLine(r1);
    }
}