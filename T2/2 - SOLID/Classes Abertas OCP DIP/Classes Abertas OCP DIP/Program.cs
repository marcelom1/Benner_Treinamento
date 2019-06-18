using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Abertas_OCP_DIP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Compra compra = new Compra(500,"sao paulo");

            CalculadoraDePrecos calc = new CalculadoraDePrecos(new TabelaDePrecoPadrao(),new Frete());

            double resultado = calc.Calcula(compra);

            Console.WriteLine("O preco da compra é: " + resultado);
        }
    }
}
