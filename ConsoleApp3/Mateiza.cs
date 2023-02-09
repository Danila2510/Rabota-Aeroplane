using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Mateiza
    {
        private static int rady;
        private static int stolb;
        private int[,] mat = new int[rady, stolb];
        private int Min { get; set; } = 0;
        private int Max { get; set; } = 0;
        public Mateiza()
        {
            Random random = new Random();
            for (int i = 0; i < rady; i++)
                for (int j = 0; j < stolb; j++)
                    mat[i, j] = random.Next(1, 20);
            for (int i = 0; i < rady; i++)
                for (int j = 0; j < stolb; j++)
                {
                    if (Min > mat[i, j])
                        Min = mat[i, j];
                    if (Max < mat[i, j])
                        Max = mat[i, j];
                }
        }

        static Mateiza()
        {
            Console.WriteLine("\n Enter number of lines");
            rady = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Enter number of columns ");
            stolb = Convert.ToInt32(Console.ReadLine());
        }

        public void Print()
        {
            for (int i = 0; i < rady; i++)
            {
                for (int j = 0; j < stolb; j++)
                    Console.Write(mat[i, j] + " \t ");
                Console.WriteLine();
            }
            Console.WriteLine($"\n Minimum {Min}, \n Maximum {Max}");
        }

        public override string ToString()
        {
            Print();
            return " ";
        }
    }
}

