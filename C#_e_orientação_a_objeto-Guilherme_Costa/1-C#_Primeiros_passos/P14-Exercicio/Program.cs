using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int mutiploPor3 = 1; mutiploPor3 < 100; mutiploPor3++)
            {
                if(mutiploPor3 % 3 == 0)
                {
                    Console.WriteLine(mutiploPor3);
                }  
            }
            Console.ReadLine();
        }
    }
}
