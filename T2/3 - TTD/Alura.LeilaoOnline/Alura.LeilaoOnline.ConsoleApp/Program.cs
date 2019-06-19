using System;
using Alura.LeilaoOnline.Core;

namespace Alura.LeilaoOnline.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano",leilao);
            var maria = new Interessada("Maria", leilao);

            leilao.RecebeLance(fulano,500);
            leilao.RecebeLance(maria, 600);
            leilao.RecebeLance(fulano, 1000);
            leilao.RecebeLance(maria, 600);

            leilao.TerminaPregao();

            Console.WriteLine(leilao.Ganhador.Valor);

            Console.ReadLine();

        }
    }
}
