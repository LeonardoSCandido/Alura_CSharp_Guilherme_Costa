using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente pedro = new Cliente();

            pedro.nome = "Pedro";
            pedro.cpf = "285.645.975-78";
            pedro.profissao = "Desenvolvedor";
            
            ContaCorrente conta = new ContaCorrente();

            conta.titular = pedro;
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 528763;

            Console.WriteLine(pedro.nome);
            Console.WriteLine(conta.titular.nome);

            Console.ReadLine();
        }
    }
}
