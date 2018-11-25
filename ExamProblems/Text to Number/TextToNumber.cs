using System;

class TextToNumber
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        long result = 0;

        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];

            if (ch == '@')
            {
                break;
            }
            else if ('0' <= ch && ch <= '9')
            {
                result *= (ch - '0');
            }
            else if ('a' <= ch && ch <= 'z')
            {
                result += (ch - 'a');
            }
            else if ('A' <= ch && ch <= 'Z')
            {
                result += (ch - 'A');
            }
            else
            {
                result %= m;
            }
        }
        Console.WriteLine(result);
    }
}