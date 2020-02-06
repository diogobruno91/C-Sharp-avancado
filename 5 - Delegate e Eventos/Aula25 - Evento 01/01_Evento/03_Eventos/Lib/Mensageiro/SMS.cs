using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Eventos.Lib.Mensageiro
{
    public class SMS
    {
        public void EnviarMensagem(Object sender, VideoEventsArgs args)
        {
            Console.WriteLine("SMS enviado para o video " + args.Video.Nome);
        }
    }
}
