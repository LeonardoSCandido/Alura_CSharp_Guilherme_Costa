using ByteBank.Funcionarios;
using ByteBank.Sistemas;
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
            //CaucularBonificacao();

            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemasInternos sistemaInterno = new SistemasInternos();

            Diretor Laura = new Diretor("643.742.988.01");
            Laura.Nome = "Laura";
            Laura.Senha = "123";

            GerenteDeConta Maria = new GerenteDeConta("306.741.875.94");
            Maria.Nome = "Maria";
            Maria.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");
            sistemaInterno.Logar(Laura, "123");
            sistemaInterno.Logar(Maria, "abc");
        }

        public static void CaucularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer Luiz = new Designer("765.752.984.35");
            Luiz.Nome = "Luiz";

            Diretor Laura = new Diretor("643.742.988.01");
            Laura.Nome = "Laura";

            Auxiliar Pedro = new Auxiliar("985.134.852.46");
            Pedro.Nome = "Pedro";

            GerenteDeConta Maria = new GerenteDeConta("306.741.875.94");
            Maria.Nome = "Maria";

            gerenciadorBonificacao.Registrar(Luiz);
            gerenciadorBonificacao.Registrar(Laura);
            gerenciadorBonificacao.Registrar(Pedro);
            gerenciadorBonificacao.Registrar(Maria);

            Console.WriteLine("Total de bonificacao do mês " + gerenciadorBonificacao.GetTotalBonificacao());

        }
    }
}
