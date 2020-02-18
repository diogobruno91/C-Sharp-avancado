using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01_thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DataIni: " + DateTime.Now);

            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThreadRepeticao);
                t1.IsBackground = true;
                t1.Start();
            }
            Console.ReadKey();
        }

        //IO - Tela(Monitor), rede, Armazenamento
        static void ThreadRepeticao()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Num" + i);
            }
            Console.WriteLine("Datetime: " + DateTime.Now);
        }        
    }
}
