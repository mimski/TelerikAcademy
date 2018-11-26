using System;

class MixingNumbersV2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] nums = new int[n];

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        int[] mixArr = new int[n - 1];
        int[] subArr = new int[n - 1];

        for (int i = 0; i < mixArr.Length; i++)
        {
            mixArr[i] = (nums[i] % 10) * ((nums[i + 1] / 10) % 10);
            subArr[i] = Math.Abs(nums[i] - nums[i + 1]);
        }
        Console.WriteLine(string.Join(" ", mixArr));
        Console.WriteLine(string.Join(" ", subArr));
    }
}