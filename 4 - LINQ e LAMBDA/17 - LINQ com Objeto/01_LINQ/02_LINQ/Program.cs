using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ e LAMBDA
            //LAMBDA = (entrada) => (expressa) 
            int[] lista = { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };

            //LAMBDA
            //var listResult = lista.Where(a => a > 10).OrderBy(a => a).Select(a => a);
            
            //LINQ
            var listResult = (from a in lista
                              where a > 10
                              orderby a
                              select a
                              );

            foreach (var item in listResult)
            {
                Console.WriteLine(" - " + item);
            }
            Console.ReadKey();
        }
    }
}
