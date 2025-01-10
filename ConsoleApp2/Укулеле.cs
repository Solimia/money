using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Ukulele : MusicalInstrument
    {
        public Ukulele(string name, string description, string history) : base(name, description, history) { }

        public override void Sound()
        {
            Console.WriteLine("Укулеле видає яскравий і веселий звук!");
        }
    }
}
