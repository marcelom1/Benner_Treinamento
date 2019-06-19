using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Boleto> boletos = new List<Boleto>();
            boletos.Add(new Boleto(200));
            boletos.Add(new Boleto(200));
            boletos.Add(new Boleto(200));

            Fatura fatura = new Fatura("Caelum", 900);

            ProcessadorDeBoletos pdb = new ProcessadorDeBoletos();

            pdb.Processa(boletos, fatura);

            Console.WriteLine(fatura.Pago);
            Console.ReadLine();

        }
    }
}
