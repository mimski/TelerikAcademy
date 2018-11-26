using System;

class HiddenMessageV2
{
    static void Main()
    {
        string hiddenMessage = "";

        string input = Console.ReadLine();
       
        while (input != "end")
        {
            int i = int.Parse(input);
            int s = int.Parse(Console.ReadLine());
            string subtitles = Console.ReadLine();

            if (i < 0) //if i is a negative int (-i)
            {
                i += subtitles.Length; 
            }

            while (i >= 0 && i < subtitles.Length)
            {
                hiddenMessage += subtitles[i];
                i += s; //if (+i) goes right, if (-i) goes left
            }
            input = Console.ReadLine();
        }
        Console.WriteLine(hiddenMessage);
    }
}