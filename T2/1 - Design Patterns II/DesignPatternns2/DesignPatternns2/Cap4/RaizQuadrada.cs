using DesignPatternns2.Cap5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternns2.Cap4
{
    public class RaizQuadrada
    {
        public IExpressao Expressao { get; private set; }
        
        
        public RaizQuadrada(IExpressao expressao)
        {
            Expressao = expressao;
        }

        public double Avalia()
        {
            int valorExpressao = Expressao.Avalia();

            return Math.Sqrt(valorExpressao);
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeRaizQuadrada(this);
        }
    }
}
