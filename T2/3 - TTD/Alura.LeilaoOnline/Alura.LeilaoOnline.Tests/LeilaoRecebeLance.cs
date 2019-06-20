using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Alura.LeilaoOnline.Core;
using System.Linq;

namespace Alura.LeilaoOnline.Tests
{
    public class LeilaoRecebeLance
    {
        [Fact]
        public void NaoAceitaProximoLanceDadoMesmoClienteRealizouUltimoLance()
        {

            //Arranje - Cenário
            var modalidade = new MaiorValor();
            var leilao = new Leilao("Van Gogh",modalidade);
            var fulano = new Interessada("Fulano", leilao);

            leilao.IniciaPregao();
            leilao.RecebeLance(fulano, 800);
            

            //ACT - Método sob Teste
            leilao.RecebeLance(fulano, 1000);

            leilao.TerminaPregao();
            //Assert 
            //Então o valor esperado é o maior valor dado
            //  e o valor ganhador é o que deu o maior lance 
            var qtdEsperada = 1;
            var qtdObtido = leilao.Lances.Count();

            Assert.Equal(qtdEsperada, qtdObtido);

        }

        [Theory]
        [InlineData(4,new double[] { 1000,1200,1400,1300})]
        [InlineData(2, new double[] { 800, 900 })]
        public void NaoPermiteNovosLancesDadoLeilaoFinalizado(int qtdEsperada, double[] ofertas)
        {

            //Arranje - Cenário
            var modalidade = new MaiorValor();
            var leilao = new Leilao("Van Gogh",modalidade);
            var fulano = new Interessada("Fulano", leilao);
            var maria = new Interessada("Maria", leilao);

            leilao.IniciaPregao();

            for (int i = 0; i<ofertas.Length; i++)
            {
                var valor = ofertas[i];
                if ((i%2) == 0)
                {
                    leilao.RecebeLance(fulano, valor);
                }
                else
                {
                    leilao.RecebeLance(maria, valor);
                }
            }

            leilao.TerminaPregao();


            //ACT - Método sob Teste
            leilao.RecebeLance(fulano, 1000);


            //Assert 
            //Então o valor esperado é o maior valor dado
            //  e o valor ganhador é o que deu o maior lance 
            
            var qtdObtido = leilao.Lances.Count();

            Assert.Equal(qtdEsperada, qtdObtido);

        }

    }
}
