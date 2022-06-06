using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();  

            Funcionario Luiz = new Funcionario();
            Luiz.Nome = "Luiz";
            Luiz.CPF = "485.768.256-20";
            Luiz.Salario = 3000;
            gerenciador.Registrar(Luiz);

            Diretor Laura = new Diretor();
            Laura.Nome = "Laura";
            Laura.CPF = "652.248.579-41";
            Laura.Salario = 5000;
            gerenciador.Registrar(Laura);

            Console.WriteLine(Luiz.Nome);
            Console.WriteLine(Luiz.GetBonificacao());

            Console.WriteLine(Laura.Nome);
            Console.WriteLine(Laura.GetBonificacao());

            Console.WriteLine("Total de bonificação: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
