using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    using System;

    public class MusicalInstrument
    {
        public string Name { get; set; }  
        public string Description { get; set; }  
        public string History { get; set; }  

        public MusicalInstrument(string name, string description, string history)
        {
            Name = name;
            Description = description;
            History = history;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Музичний інструмент звучить...");
        }

        public void Show()
        {
            Console.WriteLine($"Назва інструменту: {Name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Опис інструменту: {Description}");
        }

        public void HistoryOfInstrument()
        {
            Console.WriteLine($"Історія інструменту: {History}");
        }
    }
}
