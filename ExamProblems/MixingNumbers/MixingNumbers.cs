using System;

class MixingNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string mixLine = "";
        string subLine = ""; 

        int ab = int.Parse(Console.ReadLine());
        for (int i = 0; i < n - 1; i++)
        {
            int cd = int.Parse(Console.ReadLine());

            mixLine += string.Format("{0} ", (ab % 10) * ((cd / 10) % 10));
            subLine += string.Format("{0} ", Math.Abs(ab - cd));

            ab = cd;
        }

        Console.WriteLine(mixLine);
        Console.WriteLine(subLine);
    }
}