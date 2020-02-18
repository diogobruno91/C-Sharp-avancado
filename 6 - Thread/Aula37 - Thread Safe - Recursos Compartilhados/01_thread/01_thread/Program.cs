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
        static int Rede = 0;
        static object variavelDeControle = 0;

        //IO - Input/Output - Lento(Tela, Rede, Armazenamento, Impressora-Rede);
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

        static void ThreadRepeticao()
        {
            //FIFO - First In and First Out
            for (int i = 0; i < 1000; i++)
            {
                lock (variavelDeControle)
                {
                    Console.WriteLine("Num" + i);
                    Rede++;
                }
            }

            Console.WriteLine("Datetime: " + DateTime.Now);
        }
    }
}
