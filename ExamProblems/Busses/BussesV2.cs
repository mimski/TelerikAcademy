using System;

class BussesV2
{
    static void Main()
    {
        int groups = 0;

        int busses = int.Parse(Console.ReadLine());
        
        int maxSpeed = int.MaxValue;

        for (int bus = 0; bus < busses; bus++)
        {
            int speed = int.Parse(Console.ReadLine());

            if (speed <= maxSpeed)
            {
                groups++;
                maxSpeed = speed;
            }
        }
        Console.WriteLine(groups);
    }
}
