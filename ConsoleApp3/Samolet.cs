using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
     class Samolet
    {
        private string Imya { get; set; }
        private int God { get; set; }
        private string Tip { get; set; }

        private static string Breand;

        public Samolet() { }
        public Samolet(string name, int year, string type)
        {
            Imya = name;
            God = year;
            Tip = type;
        }

        static Samolet()
        {
            Console.WriteLine("\n Enter Breand");
            Breand = Console.ReadLine();
        }
        public void Print()
        {
            Console.WriteLine($" Name samolet{Imya} \n Breand {Breand} \n God {God} \n Tip {Tip}");
        }

        public override string ToString()
        {
            return $" Name samolet {Imya}\n Brean {Breand}\n God  {God}\n Tip {Tip}";
        }
    }
}