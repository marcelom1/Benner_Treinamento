using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario carlos = new Funcionario();
            carlos.Nome = "Carlos";
            carlos.CPF = "589.541.954-71";
            carlos.salario = 2000;

            Diretor gabriela = new Diretor();
            gabriela.Nome = "Gabriela";
            gabriela.CPF = "965.652.852-72";
            gabriela.salario = 5000;

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            gerenciador.Registrar(carlos);
            gerenciador.Registrar(gabriela);

            Console.WriteLine("Total de bonificação: " + gerenciador.GetTotalBonificacao());



            Console.ReadLine();
        }
    }
}
