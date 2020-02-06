using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Delegate
{
    class Program
    {
        delegate int Calcula(int a, int b);
        static void Main(string[] args)
        {
            Calcula calc = new Calcula(Soma);
            int so = calc(10, 20);

            Calcula calcula = new Calcula(Subtrair);
            int su = calcula(30, 15);

            //var so = Soma(10, 20);

            //var su = Subtrair(20, 10);

            Console.WriteLine("Soma: " + so);
            Console.WriteLine("Subtração: " + su);

            Console.ReadKey();
        }

        static int Soma(int a, int b)
        {
            return a + b;
        }
        
        static int Subtrair(int a, int b)
        {
            return a - b;
        }
    }
}
