using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    enum Formato
    {
        XML,
        CSV,
        PORCENTO
    }

    class Requisicao
    {
        public Formato Formato { get; private set; }

        public Requisicao(Formato formato)
        {
            this.Formato = formato;
        }
    }
}
