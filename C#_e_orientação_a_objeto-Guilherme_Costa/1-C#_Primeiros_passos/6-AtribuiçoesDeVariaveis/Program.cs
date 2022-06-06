using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuiçoesDeVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6");

            int idade = 20;
            int idadePedro = idade;

            idade = 30;

            Console.WriteLine(idade);
            Console.WriteLine(idadePedro);


            Console.ReadLine();
        }
    }
}
