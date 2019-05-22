using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(2000, cpf)
        {

        }

        public override void AumentarSalario()
        {
            salario *= 1.1;
        }

        public override double GetBonificacao()
        {
            return salario * 0.2;
        }
    }
}
