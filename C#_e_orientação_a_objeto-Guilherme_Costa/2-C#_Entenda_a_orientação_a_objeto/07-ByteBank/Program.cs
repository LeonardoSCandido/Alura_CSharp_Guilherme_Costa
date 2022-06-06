using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(856, 86542158);

            Console.WriteLine(conta.Numero);
            Console.WriteLine(conta.Agencia);         

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine(); 
        }
    }
}
