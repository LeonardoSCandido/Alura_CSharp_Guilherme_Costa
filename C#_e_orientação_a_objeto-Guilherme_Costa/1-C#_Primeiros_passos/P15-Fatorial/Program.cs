﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15_Fatorial
{
    internal class Program
    {
        static void Main(String[] args)
        {
            int fatorial = 1;
            for (int i = 1; i < 11; i++)
            {
                fatorial *= i;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
            }
            Console.ReadLine(); 
        }
    }
}

