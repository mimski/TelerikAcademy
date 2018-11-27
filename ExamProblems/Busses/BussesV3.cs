using System;

class BussesV3
{
    static void Main()
    {
        int groups = 0;
        int index = 0;

        int busses = int.Parse(Console.ReadLine());

        int[] array = new int[busses];

        for (int i = 0; i < busses; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i < busses; i++)
        {
            if (array[index] >= array[i])
            {
                groups += 1;
                index = i;
            }
        }
        Console.WriteLine(groups + 1);
    }
}