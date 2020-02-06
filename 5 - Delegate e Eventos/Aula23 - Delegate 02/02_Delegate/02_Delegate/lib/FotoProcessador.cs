using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Delegate.lib
{
    class FotoProcessador
    {
        public delegate void FotoFiltroHandler(Foto foto);

        public static FotoFiltroHandler filtros;

        public static void Processar(Foto foto)
        {
            filtros(foto);
            //var filtros = new FotoFiltro();
            //filtros.Colorir(foto);
            //filtros.PretoBranco(foto);
            //filtros.GerarThumb(foto);
            //filtros.RedimensionarTamMedio(foto);
        }
    }
}
