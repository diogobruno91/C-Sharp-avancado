using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _49_reflection.Modelo;

namespace _49_reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario()
            {
                Nome = "José",
                Email = "jose@email.com",
                Senha = "123456abc"
            };
            Log.Gravar(usuario.Clone());

            usuario.Nome = "Jose Costa";
            Log.Gravar(usuario.Clone());

            Carro carro = new Carro() { Marca = "Fiat", Modelo = "Uno" };
            Log.Gravar(carro);

            Log.ApresentarLog();

            Console.WriteLine("Log gravado!");
            Console.ReadKey();

        }
    }
}
