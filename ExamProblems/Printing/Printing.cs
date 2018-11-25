using System;

class Printing
{
    static void Main()
    {
        // read input: n = number of students; s = sheets per student; p = price of realm
        int n = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());
        // realm = box with paper sheets
        double realm = 500;

        double result = ((n * s) / realm) * p;

        // print result: the total amount of money for paper
        Console.WriteLine("{0:F2}", result);
    }
}