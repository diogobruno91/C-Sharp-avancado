using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03_Eventos.Lib
{
    public class VideoEncode
    {
        //public delegate void VideoEncodedHandle(Video video);
        //public event VideoEncodedHandle Encoded;

        public event EventHandler<VideoEventsArgs> Encoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Convertendo o Video...");
            Thread.Sleep(2000);
            Console.WriteLine("Video convertido!");

            Encoded(this, new VideoEventsArgs() { Video = video });
        }
    }

    public class VideoEventsArgs : EventArgs{
        public Video Video { get; set; }  
    }
}
