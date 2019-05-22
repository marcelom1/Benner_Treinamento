using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double  salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }


        public Funcionario (double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");
            CPF = cpf;
            this.salario = salario;
            TotalDeFuncionarios++;
        }

        public virtual void AumentarSalario()
        {
            salario *= 1.10;
        }

        public virtual double GetBonificacao()
        {
            return salario * 0.10;
        }
    }
}
