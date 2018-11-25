using System;

class DecodingV4
{
    static void Main()
    {
        int salt = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        for (int i = 0; i < text.Length; i++)
        {
            long result;
            if (text[i] == '@')
            {
                break;
            }
            else if (Char.IsLetter(text[i]))
            {
                result = text[i] * salt + 1000;
            }
            else if (Char.IsDigit(text[i]))
            {
                result = text[i] + salt + 500;
            }
            else
            {
                result = text[i] - salt;
            }
            if (i % 2 == 0)
            {
                Console.WriteLine("{0:F2}", result / 100.0);
            }
            else
            {
                Console.WriteLine(result * 100);
            }
        }
    }
}