using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics.Models;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro() { Marca = "FIAT", Modelo = "UNO"  };
            Casa casa = new Casa() { Cidade = "Brasilia", Endereco = "QSQ 400" };
            Usuario usuario = new Usuario() { Nome = "Maria", Email = "maria@mail", Senha = "123456" };

            Serializador.Serializar(carro);
            Serializador.Serializar(casa);
            Serializador.Serializar(usuario);

            Carro carro2 = Serializador.Deserializar<Carro>();
            Casa casa2 = Serializador.Deserializar<Casa>();
            Usuario usuario2 = Serializador.Deserializar<Usuario>();

            Console.WriteLine("Carro2: " + carro2.Marca + " - " + carro2.Modelo );
            Console.WriteLine("Casa2: " + casa2.Cidade + " - " + casa2.Endereco );
            Console.WriteLine("Usuario2: " + usuario2.Nome + " - " + casa2.Endereco );
            Console.ReadKey();
        }
    }
}
