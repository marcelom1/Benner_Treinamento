using DesignPatternns2.Cap5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternns2.Cap4
{
    public interface IExpressao
    {
        int Avalia();
        void Aceita(IVisitor impressora);
    }
}
