using System;

class CrookedDigits
{
    static void Main()
    {
        string n = Console.ReadLine();
        if (n.Length == 1)
        {
            Console.WriteLine(n);
        }

        while (n.Length > 1)
        {
            int sum = 0;

            for (int i = 0; i < n.Length; i++)
            {
                char ch = n[i];
                if (char.IsDigit(n[i]))
                {
                    int digit = int.Parse(ch.ToString());
                    sum += digit;
                }
            }
            if (sum <= 9)
            {
                Console.WriteLine(sum);
            }
            n = sum.ToString();
        }
    }
}