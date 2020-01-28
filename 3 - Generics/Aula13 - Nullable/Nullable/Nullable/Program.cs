using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Struct - Por valor
            //ERRO: int i = null;

            //Class - Por Referência
            Object o = null;

            //MySQL - Oracle - PostGreeSQL ...  NoSQL - Informações Opcionais
            Nullable<int> Idade = null;
            int? Idade2 = null;
            //ERRO: int Idade3 = null;
        }
    }
}
