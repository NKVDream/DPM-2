using System;
class Task3
{
    static void Main()
    {
        Console.WriteLine("inches = ");double  inch = double.Parse(Console.ReadLine());
        Console.WriteLine("centimetrs= ");double centimeter = double.Parse(Console.ReadLine());
        //centimeter = centimeter*254/100;
        if (centimeter * 0.39370 > inch)
        {
            Console.WriteLine($"{centimeter} centimeters is greater than{inch} inches");
        }
        else if (centimeter * 0.39370 < inch)
        {
            Console.WriteLine($"{inch} inches is greater than {centimeter} centimeters");
        }
        else if( centimeter * 0.39370 == inch)
        {
            Console.WriteLine("both are equal");
        }
    }
}