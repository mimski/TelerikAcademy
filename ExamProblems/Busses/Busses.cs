using System;

class Busses
{
    static void Main()
    {
        int groups = 1;

        int busses = int.Parse(Console.ReadLine());
        int busAspeed = int.Parse(Console.ReadLine());

        for (int bus = 1; bus < busses; bus++)
        {
            int busBspeed = int.Parse(Console.ReadLine());

            if (busBspeed <= busAspeed)
            {
                groups++;
                busAspeed = busBspeed;
            }
        }
        Console.WriteLine(groups);
    }
}