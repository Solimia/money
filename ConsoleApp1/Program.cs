using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Device kettle = new Kettle("Чайник", "Електричний чайник для кип'ятіння води.");
        Device microwave = new Microwave("Мікрохвильовка", "Мікрохвильова піч для розігріву їжі.");
        Device car = new Car("Автомобіль", "Легковий автомобіль для перевезення людей.");
        Device steamboat = new Steamboat("Пароплав", "Пароплав, що рухається за допомогою пари.");

        kettle.Show();
        kettle.Desc();
        kettle.Sound();
        Console.WriteLine();

        microwave.Show();
        microwave.Desc();
        microwave.Sound();
        Console.WriteLine();

        car.Show();
        car.Desc();
        car.Sound();
        Console.WriteLine();

        steamboat.Show();
        steamboat.Desc();
        steamboat.Sound();
    }
}