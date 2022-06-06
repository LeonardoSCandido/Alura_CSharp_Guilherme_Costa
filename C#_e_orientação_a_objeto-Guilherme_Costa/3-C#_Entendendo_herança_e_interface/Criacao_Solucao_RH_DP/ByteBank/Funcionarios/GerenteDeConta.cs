using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    internal class GerenteDeConta : Funcionario
    {
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("Criando Auxiliar");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.5;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
