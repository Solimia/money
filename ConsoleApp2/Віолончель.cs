using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Cello : MusicalInstrument
    {

        public Cello(string name, string description, string history) : base(name, description, history) { }

        public override void Sound()
        {
            Console.WriteLine("Віолончель видає глибокий і серйозний звук!");
        }
    }
}
