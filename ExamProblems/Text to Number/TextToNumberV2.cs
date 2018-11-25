using System;

class TextToNumberV2
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        text = text.ToLower();

        long result = 0;

        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];
            if (ch == '@')
            {
                break;
            }
            else if('0' <= ch && ch <= '9')
            {
                result *= (ch - '0');
            }
            else if ('a' <= ch && ch <= 'z')
            {
                result += (ch - 'a');
            }
            else
            {
                result %= m;
            }
        }
        Console.WriteLine(result);
    }
}