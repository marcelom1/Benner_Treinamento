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
            Funcionario carlos = new Funcionario(2000, "589.541.954-71");
            carlos.Nome = "Carlos";
            Console.WriteLine( Funcionario.TotalDeFuncionarios);
         
            carlos.AumentarSalario();
            Console.WriteLine("Novo salário do carlos " + carlos.salario);

            Diretor gabriela = new Diretor("965.652.852 - 72");
            gabriela.Nome = "Gabriele";
            Console.WriteLine(Funcionario.TotalDeFuncionarios);


            gabriela.AumentarSalario();
            Console.WriteLine("Novo salário da Gabriela " + gabriela.salario);

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Console.WriteLine("Bonificacao de uma referencia de Diretor: " + gabriela.GetBonificacao());
            Console.WriteLine("Bonificacao de uma referencia de Funcionario: " + gabriela.GetBonificacao());

            Console.WriteLine(carlos.Nome);
            gerenciador.Registrar(carlos);
            Console.WriteLine(carlos.GetBonificacao());


            Console.WriteLine(gabriela.Nome);
            gerenciador.Registrar(gabriela);
            Console.WriteLine(gabriela.GetBonificacao());

            Console.WriteLine("Total de bonificação: " + gerenciador.GetTotalBonificacao());



            Console.ReadLine();
        }
    }
}
