using System;
class Task4
{
    static void Main()
    {
        Console.WriteLine("write down deposit amount");int Amo = int.Parse(Console.ReadLine());
        Procent procent = new Procent(Amo);
        procent.Procents();

    }
}