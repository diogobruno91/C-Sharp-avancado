using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varDinamic
{
    class Program
    {
        static void Main(string[] args)
        {
            Object t1 = "";
            Object t2 = 123456;
            t2 = "";

            var v1 = "";
            var v2 = 123456;
            //ERRO: var v3;
            //ERRO: v2 = "";

            dynamic d1 = new Usuario {Nome = "Maria" };

            Console.Write(d1.Nome);
            //ERRO: Console.Write(d1.Senha);

            d1 = "";

            Console.ReadKey();
        }

        class Usuario
        {
            public string Nome { get; set; }
        }
    }
}
