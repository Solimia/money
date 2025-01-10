using ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {

        MusicalInstrument violin = new Violin("Скрипка", "Струнний інструмент, що грається за допомогою смичка.", "Скрипка має довгу історію, її витоки сягають в середньовіччя.");
        MusicalInstrument trombone = new Trombone("Тромбон", "Мідний духовий інструмент з ковзаючим механізмом для зміни висоти звуку.", "Тромбон виник в 15 столітті і мав різні варіанти розвитку.");
        MusicalInstrument ukulele = new Ukulele("Укулеле", "Маленька гітара з Гавайських островів.", "Укулеле було створено в кінці 19 століття на Гавайях.");
        MusicalInstrument cello = new Cello("Віолончель", "Великий струнний інструмент, що грається сидячи.", "Віолончель виникла в Італії в 16 столітті і стала важливим інструментом в оркестрі.");


        violin.Show();
        violin.Desc();
        violin.HistoryOfInstrument();
        violin.Sound();
        Console.WriteLine();

        trombone.Show();
        trombone.Desc();
        trombone.HistoryOfInstrument();
        trombone.Sound();
        Console.WriteLine();

        ukulele.Show();
        ukulele.Desc();
        ukulele.HistoryOfInstrument();
        ukulele.Sound();
        Console.WriteLine();

        cello.Show();
        cello.Desc();
        cello.HistoryOfInstrument();
        cello.Sound();
    }
}