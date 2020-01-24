using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Biblioteca;
using System.IO;
using System.Web.Script.Serialization;

namespace _03_SerializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "Maria Costa Silva", CPF = "333.333.333-33", Email = "maria@gmail.com" };

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string stringObjSerializado = serializador.Serialize(usuario);

            StreamWriter sw = new StreamWriter(@"C:\Users\dbruno\Downloads\c-sharp - Avancado\2 - Serialização\02_SerializarJSON");

            sw.WriteLine(stringObjSerializado);
            sw.Close();
        }
    }
}
