using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_LINQ_OBJ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> lista = new List<Usuario>();
            lista.Add(new Usuario() { Nome = "Jose", Email = "jose@gmail.com" });
            lista.Add(new Usuario() { Nome = "Maria", Email = "maria@hotmail.com" });
            lista.Add(new Usuario() { Nome = "Lucas", Email = "lucas@ig.com" });
            lista.Add(new Usuario() { Nome = "Diogo", Email = "diogo@gmail.com" });
            lista.Add(new Usuario() { Nome = "Bruno", Email = "bruno@gmail.com" });

            var listResult = lista.Where(a => a.Email.Contains("@gmail.com")).OrderBy(a => a.Nome).Select(a => a);

            foreach (var item in listResult)
            {
                Console.WriteLine("{0} - {1}", item.Nome, item.Email);
            }
            Console.ReadKey();
        }
    }
}
