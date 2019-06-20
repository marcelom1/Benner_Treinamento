using System;
using Alura.LeilaoOnline.Core;

namespace Alura.LeilaoOnline.ConsoleApp
{
    class Program
    {
        private static void Verifica(double esperado, double obtido)
        {
            var cor = Console.ForegroundColor;
            if (esperado == obtido)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Teste Ok");
            }
            else
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Teste Falhou! Esperado: {esperado}, Obtido: {obtido}.");
            }
            Console.ForegroundColor = cor;
        }
        static void Main()
        {
            LeilaoComVariosLances();
            LeilaoComApenasUmLance();
            Console.ReadLine();

        }


        private static void LeilaoComApenasUmLance()
        {
            //Arranje - Cenário
            var modalidade = new MaiorValor();
            var leilao = new Leilao("Van Gogh",modalidade);
            var fulano = new Interessada("Fulano", leilao);
           

            leilao.RecebeLance(fulano, 500);
            

            //ACT - Método sob Teste
            leilao.TerminaPregao();


            //Assert 
            var valorEsperado = 500;
            var valorObtido = leilao.Ganhador.Valor;

            Verifica(valorEsperado, valorObtido);


        }
        private static void LeilaoComVariosLances()
        {
            //Arranje - Cenário
            var modalidade = new MaiorValor();
            var leilao = new Leilao("Van Gogh",modalidade);
            var fulano = new Interessada("Fulano", leilao);
            var maria = new Interessada("Maria", leilao);

            leilao.RecebeLance(fulano, 500);
            leilao.RecebeLance(maria, 600);
            leilao.RecebeLance(fulano, 1000);
            leilao.RecebeLance(maria, 600);

            //ACT - Método sob Teste
            leilao.TerminaPregao();


            //Assert 
            var valorEsperado = 1000;
            var valorObtido = leilao.Ganhador.Valor;


            Verifica(valorEsperado, valorObtido);
        }
        
    }
}
