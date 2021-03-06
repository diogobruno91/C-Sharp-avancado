﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> lista = new List<Usuario>();
            lista.Add(new Usuario(){ Nome = "Jose", Email = "jose@gmail.com" });
            lista.Add(new Usuario(){ Nome = "Maria", Email = "maria@hotmail.com" });
            lista.Add(new Usuario(){ Nome = "Lucas", Email = "lucas@ig.com" });
            lista.Add(new Usuario(){ Nome = "Diogo", Email = "diogo@gmail.com" });
            lista.Add(new Usuario(){ Nome = "Bruno", Email = "bruno@gmail.com" });

            var listaResultado = lista.Where(x => x.Email.Contains("@gmail.com")).OrderBy(x => x.Nome).Select(x => x);

            foreach (var item in listaResultado)
            {
                Console.WriteLine("{0} - {1} ", item.Nome, item.Email);
            }
            Console.ReadKey();
        }
    }
}
