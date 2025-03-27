using System;
class Procent
{
    public int Amount;
    public Procent(int amount)
    {
        this.Amount = amount;
    }
    public void Procents()
    {
        if (Amount < 100)
        {
            Amount += Amount / 100 * 5;
            Console.WriteLine(Amount);
        }
        else if (Amount > 100 && Amount <= 200)
        {
            Amount += Amount / 100 * 5;
            Console.WriteLine(Amount);
        }
        else if(Amount > 200)
        {
            Amount += Amount / 100 * 10;
            Console.WriteLine(Amount);
        }
        else if (Amount == 0)
        {
            Console.WriteLine("broke ass((((");
        }
    }

}
