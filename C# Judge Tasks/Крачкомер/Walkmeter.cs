using System;

class Walkmeter
{
    static void Main()
    {
        int stepsInMiles = int.Parse(Console.ReadLine());
        
        Console.WriteLine("{0}", stepsInMiles * 1609);
    }
}