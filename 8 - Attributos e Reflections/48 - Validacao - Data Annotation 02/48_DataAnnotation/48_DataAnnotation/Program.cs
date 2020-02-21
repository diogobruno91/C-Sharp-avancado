using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _48_DataAnnotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "Jose", Email = "jose@email.com", Senha = " 123456" };

            ValidationContext contexto = new ValidationContext(usuario);
            List<ValidationResult> resultados = new List<ValidationResult>();

            if (Validator.TryValidateObject(usuario, contexto, resultados, true) == false)
            {
                //Mensagens
                foreach (var error in resultados)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }

            Console.ReadKey();
        }
    }
}
