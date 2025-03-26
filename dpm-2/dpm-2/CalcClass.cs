using System;
class Comperor
{
    public int num1;
    public int num2;

    // Конструктор с телом
    public Comperor(int num1, int num2)
    {
        this.num1 = num1;
        this.num2 = num2;
    }

    public void Comperasion()
    {
        if (num1 > num2)
        {
            Console.WriteLine($"{num1} is greater than {num2}");
        }
        else if (num1 < num2)
        {
            Console.WriteLine($"{num2} is greater than {num1}");
        }
        else if (num1 == num2)
        {
            Console.WriteLine("both numbers are equal");
        }
    }
}