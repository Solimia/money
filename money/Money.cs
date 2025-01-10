

public class Money
{
    public int WholePart { get; set; }  
    public int FractionalPart { get; set; }  

    public Money(int wholePart, int fractionalPart)
    {
        WholePart = wholePart;
        FractionalPart = fractionalPart;
        Normalize();  
    }

    private void Normalize()
    {
        if (FractionalPart >= 100)
        {
            WholePart += FractionalPart / 100;
            FractionalPart = FractionalPart % 100;
        }
    }


    public void Display()
    {
        Console.WriteLine($"Сума: {WholePart} грн {FractionalPart} коп.");
    }

    public void SetValues(int wholePart, int fractionalPart)
    {
        WholePart = wholePart;
        FractionalPart = fractionalPart;
        Normalize();
    }

    public void Add(Money amount)
    {
        WholePart += amount.WholePart;
        FractionalPart += amount.FractionalPart;
        Normalize();
    }

    public void Subtract(Money amount)
    {
        WholePart -= amount.WholePart;
        FractionalPart -= amount.FractionalPart;
        if (FractionalPart < 0)
        {
            WholePart -= 1;
            FractionalPart += 100;
        }
    }
}
