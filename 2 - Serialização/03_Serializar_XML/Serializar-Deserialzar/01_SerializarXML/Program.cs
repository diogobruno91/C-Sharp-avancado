using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Biblioteca;
using System.Xml.Serialization;
using System.IO;

namespace _01_SerializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "José Costa Silva", CPF = "222.222.222-22", Email = "jose@gmail.com" };

            //XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            XmlSerializer serializador = new XmlSerializer(usuario.GetType());

            StreamWriter stream = new StreamWriter(@"C:\Users\dbruno\Downloads\c-sharp - Avancado\2 - Serialização\01_SerializarXML.xml");

            serializador.Serialize(stream, usuario);
        }
    }
}
