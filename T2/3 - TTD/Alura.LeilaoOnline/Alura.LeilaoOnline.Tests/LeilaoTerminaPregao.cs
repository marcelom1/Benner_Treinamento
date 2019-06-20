using Alura.LeilaoOnline.Core;
using Xunit;

namespace Alura.LeilaoOnline.Tests
{
    public class LeilaoTerminaPregao
    {
        [Theory]
        [InlineData(1200,1250, new double[] { 800,1150,1400,1250})]
        public void RetornaValorSuperiorMaisProximoDadoLeilaoNessaModalidade(double valorDestino,double valorEsperado, double[] ofertas)
        {
            //Arranje - Cenário
            var modalidade = new OfertaSuperiorMaisProxima(valorDestino);
            var leilao = new Leilao("Van Gogh", modalidade);
            var fulano = new Interessada("Fulano", leilao);
            var maria = new Interessada("Maria", leilao);

            leilao.IniciaPregao();
            for (int i = 0; i < ofertas.Length; i++)
            {
                var valor = ofertas[i];
                if ((i % 2) == 0)
                {
                    leilao.RecebeLance(fulano, valor);
                }
                else
                {
                    leilao.RecebeLance(maria, valor);
                }
            }


            //ACT - Método sob Teste
            leilao.TerminaPregao();


            //Assert 

            var valorObtido = leilao.Ganhador.Valor;


            Assert.Equal(valorEsperado, valorObtido);
        }

        [Fact]
        public void LancaInvalidOperationExceptionDadoPregaoNaoForIniciado()
        {
            //Arranje - Cenário
            var modalidade = new MaiorValor();
            var leilao = new Leilao("Van Gogh",modalidade);



            var excecaoObtida = Assert.Throws<System.InvalidOperationException>(
                //ACT - Método sob Teste
                ()=>leilao.TerminaPregao()
            );
            var msgEsperada = "Não é possivel terminar o pregão sem que ele tenha começado. Para isso utilize o método IniciaPregao()";
            Assert.Equal(msgEsperada, excecaoObtida.Message);
        }

        [Fact]
        public void RetornaZeroDadoLeilaoSemLance()
        {


            //Arranje - Cenário
            var modalidade = new MaiorValor();
            var leilao = new Leilao("Van Gogh",modalidade);

            leilao.IniciaPregao();
            //ACT - Método sob Teste
            //Quando o pregao/leilao termina
            leilao.TerminaPregao();


            //Assert 
            //Então o valor esperado é o maior valor dado
            //  e o valor ganhador é o que deu o maior lance 
            var valorEsperado = 0;
            var valorObtido = leilao.Ganhador.Valor;


            Assert.Equal(valorEsperado, valorObtido);

        }
        

       
        


        [Theory]
        [InlineData(1600,new double[] { 500, 600, 1000, 1600 })]
        [InlineData(1000,new double[] { 500, 600, 1000, 600 })]
        [InlineData(500,new double[] { 500 })]
        public void RetornaMaiorValorDadoLeilaoComPeloMenosUmLance(double valorEsperado,double[] ofertas)
        {
            //Arranje - Cenário
            IModalidadeAvaliacao modalidade= new MaiorValor();
            var leilao = new Leilao("Van Gogh",modalidade);
            var fulano = new Interessada("Fulano", leilao);
            var maria = new Interessada("Maria", leilao);

            leilao.IniciaPregao();
            for (int i = 0; i < ofertas.Length; i++)
            {
                var valor = ofertas[i];
                if ((i % 2) == 0)
                {
                    leilao.RecebeLance(fulano, valor);
                }
                else
                {
                    leilao.RecebeLance(maria, valor);
                }
            }


            //ACT - Método sob Teste
            leilao.TerminaPregao();


            //Assert 
       
            var valorObtido = leilao.Ganhador.Valor;


            Assert.Equal(valorEsperado, valorObtido);
        }

    }
}
    

