using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_Atributos
{

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method)]
    class MeuAtributo : Attribute
    {
        public string Nome { get; set; }
        public string Descrição { get; set; }

        public MeuAtributo(string nome)
        {
            Nome = nome;
        }
    }
}
