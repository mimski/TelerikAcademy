using System;
using System.Linq;

class EvenDifferencesV2
{
    static void Main()
    {
        //read input
        var sequence = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

        long sumOfEvenDiff = 0;

        for (int i = 1; i < sequence.Length; i++)
        {
            // find the abs difference
            long absDiff = Math.Abs(sequence[i] - sequence[i - 1]);

            if (absDiff % 2 == 0) // if even
            {
                i++; //make even jump
                sumOfEvenDiff += absDiff; // sum abs difference
            }
        }
        Console.WriteLine(sumOfEvenDiff);
    }
}