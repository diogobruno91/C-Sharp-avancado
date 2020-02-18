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

            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThreadRepeticao);
                t1.IsBackground = true;
                t1.Start(i);
            }
            Console.ReadKey();
        }

        //IO - Tela(Monitor), rede, Armazenamento
        static void ThreadRepeticao(Object Id)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Thread " + Id + " - Num:" + i + " ID Interno" + Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
