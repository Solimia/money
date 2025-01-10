class Program
{
    static void Main(string[] args)
    {

        Money price = new Money(100, 50);  
        Money discount = new Money(10, 25);  

        Product product = new Product("Торт", price);

        product.DisplayProductInfo();

        product.Discount(discount);

        Console.WriteLine("Після знижки:");
        product.DisplayProductInfo();
    }
}