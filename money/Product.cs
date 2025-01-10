using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public class Product
{
    public string Name { get; set; } 
    public Money Price { get; set; }  

    public Product(string name, Money price)
    {
        Name = name;
        Price = price;
    }

    public void Discount(Money discount)
    {
        Price.Subtract(discount);
    }


    public void DisplayProductInfo()
    {
        Console.WriteLine($"Продукт: {Name}");
        Price.Display();
    }
}