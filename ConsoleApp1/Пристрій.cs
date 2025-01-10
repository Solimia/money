using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;

    public class Device
    {
        public string Name { get; set; } 
        public string Description { get; set; }  

        public Device(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Пристрій видає звук...");
        }

        public void Show()
        {
            Console.WriteLine($"Назва пристрою: {Name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Опис пристрою: {Description}");
        }
    }
}
