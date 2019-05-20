using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_CVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");
            double salario = 1200.50;

            int salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            long idade = 130000000000000;
            Console.WriteLine(idade);

            short quantidadedeProdutos = 15000;
            Console.WriteLine(quantidadedeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
