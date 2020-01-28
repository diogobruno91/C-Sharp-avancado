using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LINQ_GROUP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listNumeros = { 1, 1, 1, 1, 4, 4, 2, 3, 5, 6, 6, 10, 9, 8, };

            //DISTINCT
            var listResult = listNumeros.Distinct().OrderBy(x => x);

            //GROUP
            var listResult2 = listNumeros.GroupBy(a => a).OrderBy(a => a.Key).Select(a => a); 

            foreach(var item in listResult2)
            {
                Console.WriteLine(item.Key);
            }
            Console.ReadKey();
        }
    }
}
