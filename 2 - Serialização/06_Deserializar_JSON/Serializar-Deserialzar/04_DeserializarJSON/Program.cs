using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Biblioteca;
using System.IO;
using System.Web.Script.Serialization;

namespace _04_DeserializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader(@"C:\Users\dbruno\Downloads\c-sharp - Avancado\2 - Serialização\02_SerializarJSON.json");
            string linhasDoArquivo = stream.ReadToEnd();

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            Usuario usuario = (Usuario)serializador.Deserialize(linhasDoArquivo, typeof(Usuario));

            Console.WriteLine("Nome: {0}, CPF: {1}, e Email: {2}", usuario.Nome, usuario.CPF, usuario.Email);
            Console.ReadKey();
        }
    }
}
