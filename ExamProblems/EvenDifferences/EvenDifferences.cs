using System;
using System.Linq;

class EvenDifferences
{
    static void Main()
    {
        //read input
        var sequence = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

        long sum = 0;
        int index = 1;

        while (index < sequence.Length)
        {
            // find the abs difference
            long absDiff = Math.Abs(sequence[index] - sequence[index - 1]);

            if (absDiff % 2 == 0) //if even
            {
                // sum abs difference
                sum += absDiff;
                //make even jump
                index += 2;
            }
            else //if odd
            {
                //make odd jump
                index++;
            }
        }
        Console.WriteLine(sum);
    }
}