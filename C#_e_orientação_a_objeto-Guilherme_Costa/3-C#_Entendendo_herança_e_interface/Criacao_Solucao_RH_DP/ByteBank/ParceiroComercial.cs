using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ParceiroComercial : IAutenticavel
    {
        
        public string Senho { get; set; }


        public bool Autenticar(string senha)
        {
        
            return Senho == senha;
        }

    }
}
