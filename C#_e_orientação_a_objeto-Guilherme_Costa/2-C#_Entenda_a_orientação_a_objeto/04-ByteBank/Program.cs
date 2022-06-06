using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaBruno = new ContaCorrente();

            contaBruno.titular = "Bruno";

            Console.WriteLine(contaBruno.saldo);

            bool resultadoSaque = contaBruno.Sacar(500);
            
            Console.WriteLine(resultadoSaque);
            Console.WriteLine(contaBruno.saldo);

            contaBruno.Depositar(500);

            Console.WriteLine(contaBruno.saldo);

            ContaCorrente contaLuiz = new ContaCorrente();

            contaLuiz.titular = "Luiz";

            Console.WriteLine("Valor conta Luiz: " + contaLuiz.saldo);
            Console.WriteLine("Valor conta Bruno: " + contaBruno.saldo);

            bool resultadoDaTransferencia = contaBruno.Tranferir(200, contaLuiz);

            Console.WriteLine("Valor conta Luiz: " + contaLuiz.saldo);
            Console.WriteLine("Valor conta Bruno: " + contaBruno.saldo);
            Console.WriteLine("Resultado da transferência: " + resultadoDaTransferencia);

            Console.ReadLine();
        }
    }
}
