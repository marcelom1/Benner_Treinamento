using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Diretor
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double salario { get; set; }


        public double GetBonificacao()
        {
            return salario;
        }
    }
}
