using System;

class HiddenMessage
{
    static void Main()
    {
        string hiddenMessage = "";

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "end")
            {
                break;
            }

            int i = int.Parse(input);
            int s = int.Parse(Console.ReadLine());

            string subtitles = Console.ReadLine();

            if (i < 0)
            {
                i += subtitles.Length;
            }

            for (; i < subtitles.Length && i >= 0; i += s)
            {
                hiddenMessage += subtitles[i];
            }
        }
        Console.WriteLine(hiddenMessage);
    }
}