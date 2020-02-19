using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() => Metodo01());
            Task.Run(() => Metodo01());
            Task.Factory.StartNew(Metodo01);
            Console.ReadKey();
        }

        static void Metodo01()
        {
            for(int i =0; i < 1000; i++)
            {
                Console.WriteLine("Valor: " + i + " TaskId: " + Task.CurrentId);
            }
        }
    }
}
