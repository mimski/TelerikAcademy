using System;

class DecodingV2
{
    static void Main()
    {
        int salt = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        double result = 0;

        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];

            if (ch == '@')
            {
                break;
            }
            else if (('a' <= ch && ch <= 'z') || ('A' <= ch && ch <= 'Z'))
            {
                result = (ch * salt) + 1000;
            }
            else if ('0' <= ch && ch <= '9')
            {
                result = ch + salt + 500;
            }
            else
            {
                result = ch - salt;
            }
            if (i % 2 == 0)
            {
                result /= 100;
                Console.WriteLine("{0:F2}", result);
            }
            else
            {
                result *= 100;
                Console.WriteLine(result);
            }
            result = 0;
        }
    }
}