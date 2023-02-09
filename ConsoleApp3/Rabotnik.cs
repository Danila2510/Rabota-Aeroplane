using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Rabotnik
    {
        private string PolnoyeImya { get; set; }
        private string Rojdenie { get; set; }
        private string Nomer { get; set; }
        private string Opicanie { get; set; }
        private string Tip { get; set; }

        private static string Pocta;

        public Rabotnik() { }
        public Rabotnik(string polnoyeImya, string rojdenie, string nomer, string opicanie , string tip)
        {
            PolnoyeImya = polnoyeImya;
            Rojdenie = rojdenie;
            Nomer = nomer;
            Opicanie = opicanie;
            Tip = tip;
        }
        static Rabotnik()
        {
            Console.WriteLine("\n Enter your email ");
            Pocta = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine($" PolnoyeImya {PolnoyeImya}\n Rojdenie {Rojdenie}\n Nomer {Nomer}\n Pocta {Pocta}\n Opicanie {Opicanie}\n Tip {Tip}");
        }
        public override string ToString()
        {
            return $" PolnoyeImya {PolnoyeImya}\n Rojdenie {Rojdenie}\n Nomer {Nomer}\n Pocta {Pocta}\n Opicanie {Opicanie}\n Tip {Tip}";
        }
    }
}