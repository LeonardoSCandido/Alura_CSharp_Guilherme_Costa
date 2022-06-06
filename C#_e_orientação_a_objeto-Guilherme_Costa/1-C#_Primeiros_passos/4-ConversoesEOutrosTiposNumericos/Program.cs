using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario;
            salario = 1200.50;

            int salarioEmInteiro;
            salarioEmInteiro = (int) salario;
            Console.WriteLine(salarioEmInteiro);

            //Long é uma variável de 64bits
            long idade = 1300000;
            Console.WriteLine(idade);

            //Short é uma variavel de 16bits
            short data = 10;
            Console.WriteLine(data);

            //Float suporta menos casas decimais que o double. Necessário colocar o "f" apos o valor atribuido, se não ele vai apresentar sum erro dizendo que o valor pode ser double.
            float preco = 1500.50f;
            Console.WriteLine(preco);


            Console.ReadLine();
        }
    }
}
