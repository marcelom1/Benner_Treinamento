using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coesao
{
    public class CalculadoraDeSalario
    {
        //Exemplo de uma classe não coesa.
        /*public double calcula(Funcionario funcionario)
        {
            if (funcionario.Cargo is Desenvolvedor)
            {
                return dezOuVintePorcento(funcionario);
            }

            if (funcionario.Cargo is Dba || funcionario.Cargo is Tester)
            {
                return quinzeOuVinteCincoPorcento(funcionario);
            }

            throw new Exception("funcionario invalido");
        }

        private double dezOuVintePorcento(Funcionario funcionario)
        {
            if (funcionario.SalarioBase > 3000.0)
            {
                return funcionario.SalarioBase * 0.8;
            }
            else
            {
                return funcionario.SalarioBase * 0.9;
            }
        }

        private double quinzeOuVinteCincoPorcento(Funcionario funcionario)
        {
            if (funcionario.SalarioBase > 2000.0)
            {
                return funcionario.SalarioBase * 0.75;
            }
            else
            {
                return funcionario.SalarioBase * 0.85;
            }
        }*/

        public double Calcula(Funcionario funcionario)
        {

            return funcionario.CalculaSalario();
        }
    }
}
