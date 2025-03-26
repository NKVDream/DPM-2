using System;
class Task1
{
    static void Main()
    {
        Console.WriteLine("write down first number: "); int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("write down second number: ");int num2 = int.Parse(Console.ReadLine());
        Comperor comparater = new Comperor(num1,num2);
        comparater.Comperasion();
    }
}