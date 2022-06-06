using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Luiz";
            conta.numero = 587634;

            ContaCorrente conta2 = new ContaCorrente();

            conta2.titular = "Luiz";
            conta2.numero = 587634;

            Console.WriteLine("Igualdade do tipo de referência: " + (conta == conta2));
            Console.WriteLine("Igualdade do tipo de valor: " + (conta.titular == conta2.titular));

            Console.ReadLine();
        }
    }
}
