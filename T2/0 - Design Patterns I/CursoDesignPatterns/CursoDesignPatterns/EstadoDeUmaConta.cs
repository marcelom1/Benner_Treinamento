using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
  
    public interface EstadoDeUmaConta
    {
        void Saca(Conta conta, double valor);
        void Deposita(Conta conta, double valor);

    }
}
