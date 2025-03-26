using System;
class Task2
{
    static void Main()
    {
        Console.WriteLine("x ="); double x = double.Parse(Console.ReadLine());
        if (x > 0) 
        { 
            double y = Math.Sin(x);
            Console.WriteLine(y);
        }
        else if (x < 0) 
        { 
            double y = Math.Cos(x);
            Console.WriteLine(y);
        }
    }
}