using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base(2000, cpf)
        {

        }

        public override void AumentarSalario()
        {
            salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return salario * 0.1;
        }
    }
}
