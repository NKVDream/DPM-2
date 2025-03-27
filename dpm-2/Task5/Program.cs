using System;
//using CalcClass;
class Task5
{
    static void Main()
    {
        Console.WriteLine("x = "); int x = int.Parse(Console.ReadLine());
        Console.WriteLine("y = "); int y = int.Parse(Console.ReadLine());
        Console.WriteLine("z = "); int z = int.Parse(Console.ReadLine());
        Console.WriteLine($"{x} * 5 > {y}?; {x} : {y} > {z}? {y} : {z}.");
        Task5.Sol(x, y, z);
        Comperor test = new Comperor(x, y);
        test.Comperasion();
    }
    static void Sol(int x, int y, int z)
    {
        Console.WriteLine(x * 5 > y? x : y > z? y : z);
    }
}
