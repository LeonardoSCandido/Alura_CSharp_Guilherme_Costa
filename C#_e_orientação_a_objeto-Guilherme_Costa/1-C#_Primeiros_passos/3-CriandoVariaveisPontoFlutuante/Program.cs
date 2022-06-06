using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Criando variaveis ponto flutuante");

            double salario;

            salario = 1700.70;
            Console.WriteLine(salario);

            //Necessário colocar o "." para reconhercer como ponto flutuante, caso não coloque, será reconhecido como inteiro.//
            salario = 1500.60 / 3;
            Console.WriteLine("Seu salário é " + salario + ".");

            Console.WriteLine("Execusão finalizada. Tecle enter para sair...");
            Console.ReadLine(); 
        }
    }
}
