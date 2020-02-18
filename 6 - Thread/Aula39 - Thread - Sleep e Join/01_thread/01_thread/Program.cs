using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _01_thread
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread Sleep
            Console.WriteLine("Inicio do nosso programa.");
            Thread.Sleep(3000);
            Console.WriteLine("Termino do nosso programa.");

            //Thread Join
            Thread t1 = new Thread(ThreadRepeticao);
            t1.Start();
            t1.Join();

            Console.WriteLine("Termino do nosso programa.");
            Console.WriteLine("Termino do nosso programa.");
            Console.WriteLine("Termino do nosso programa.");
            Console.WriteLine("Termino do nosso programa.");



            Console.ReadKey();
        }

        static void ThreadRepeticao(object Id)
        {
            for(int i = 0; i < 1000; i++)
            {
                Console.WriteLine("thread:" + Id + " - Num: " + i + " ID Interno: " + Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
