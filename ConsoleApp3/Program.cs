using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rabotnik[] sotrudnik = new Rabotnik[2];
            sotrudnik[0] = new Rabotnik("Daniil", "23.12.2003", "+380-68-879-09-29", "Supervisor", "Destrubytor");
            sotrudnik[1] = new Rabotnik("Petr", "12.09.2002", "+380-99-254-34-14", "Manager", "Tovaroved");
            Console.WriteLine(sotrudnik[0] + " \n ");
            Console.WriteLine(sotrudnik[1]);
            Console.WriteLine(" \n ");

            Samolet[] samolet = new Samolet[2];
            samolet[0] = new Samolet("DJ-4122", 2019, "Carg");
            samolet[1] = new Samolet("INJ-521", 2022, "Passenger");
            Console.WriteLine(samolet[0] + " \n ");
            Console.WriteLine(samolet[1]);
            Console.WriteLine(" \n ");

            Mateiza a = new Mateiza();
            Console.WriteLine();
            Console.WriteLine(a);
        }
    }
}
