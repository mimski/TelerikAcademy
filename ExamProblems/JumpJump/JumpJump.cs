using System;

class JumpJump
{
    static void Main()
    {
        string instructions = Console.ReadLine();

        string message = "Fell off the dancefloor at {0}!";

        int position = 0;
        while (position >= 0 && position < instructions.Length)
        {
            char ch = instructions[position];
            int num = ch - '0';
            //int num = (int)Char.GetNumericValue(ch);
            
            if (ch == '^')
            {
                message = "Jump, Jump, DJ Tomekk kommt at {0}!";
                break;
            }
            else if (num == 0)
            {
                message = "Too drunk to go on after {0}!";
                break;
            }
            else if (num % 2 == 0)
            {
                position += num;
            }
            else if (num % 2 == 1)
            {
                position -= num;
            }
        }
        Console.WriteLine(message, position);
    }
}