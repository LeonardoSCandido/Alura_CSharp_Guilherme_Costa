using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executanto projeto 7");

            int idadeJoao = 16;
            int quantidadePessoa = 2;
            if (idadeJoao >= 18)
            {
                Console.WriteLine("Joao possui mais de 18 anos de idade. Pode entrar.");
            }

            else
            {
                if (quantidadePessoa >= 2)
                {
                    Console.WriteLine("Joao não possui mais de 18 anos, porem está acompanhado. Pode entrar.");
                }
                else
                {
                    Console.WriteLine("Joao não possui mais de 18 anos de idade. Não pode entrar.");
                }                
            }

            Console.ReadLine();
        }
    }
}
