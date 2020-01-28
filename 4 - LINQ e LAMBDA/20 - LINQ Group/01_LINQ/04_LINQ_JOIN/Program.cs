using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_LINQ_JOIN
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Autor> listAutor = new List<Autor>();
            listAutor.Add(new Autor() { Id = 1 , Nome = "Albert Crown" });
            listAutor.Add(new Autor() { Id = 2 , Nome = "Marie Adams" });
            listAutor.Add(new Autor() { Id = 3 , Nome = "Jospeh Morgan" });

            List<Livro> listLivros = new List<Livro>();
            listLivros.Add(new Livro() { Id = 1, IdAutor = 2, Titulo = "Amor amado" });
            listLivros.Add(new Livro() { Id = 2, IdAutor = 2, Titulo = "Bem amado" });
            listLivros.Add(new Livro() { Id = 3, IdAutor = 3, Titulo = "Um espiao em DC" });
            listLivros.Add(new Livro() { Id = 4, IdAutor = 1, Titulo = "A vida na terra" });

            var listaJoin = (from livro in listLivros
                             join autor in listAutor on livro.IdAutor equals autor.Id
                             select new { livro, autor }
                             ) ;

            foreach (var item in listaJoin)
            {
                Console.WriteLine("Livro: " + item.livro.Titulo + " - Autor: " + item.autor.Nome);
            }
            Console.ReadKey();
        }
    }
}
