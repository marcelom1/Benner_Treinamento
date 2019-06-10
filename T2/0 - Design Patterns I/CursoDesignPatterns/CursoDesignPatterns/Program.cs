using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Imposto iss = new ISS();
            Imposto icms = new ICMS();
            Imposto iccc = new ICCC();
            
             Orcamento orcamento = new Orcamento(3001);

            CalculadorDeImpostos calculadora = new CalculadorDeImpostos();
             */

            /*Investimento conservador = new Conservador();
            Investimento moderado = new Moderado();
            Investimento arrojado = new Arrojado();

            Conta marcelo = new Conta();

            marcelo.Deposita(50);

            RealizadorDeInvestimentos calInvest = new RealizadorDeInvestimentos();

            calInvest.Realiza(marcelo, conservador);
            calInvest.Realiza(marcelo, moderado);
            calInvest.Realiza(marcelo, arrojado);
            */
            /*
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();
            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("CANETA", 250));
            orcamento.AdicionaItem(new Item("LAPIS", 250));
            orcamento.AdicionaItem(new Item("copo", 250));

            double desconto = calculador.Calcula(orcamento);
            Console.WriteLine(desconto);
            */
            /*
            Conta marcelo = new Conta(100, "Marcelo");

            //CorrenteArquivo d4 = new CorrenteSemArquivo();
            CorrenteArquivo d3 = new CorrenteXML();
            CorrenteArquivo d2 = new CorrentePORCENTO(d3);           
            CorrenteArquivo d1 = new CorrenteCSV(d2);
           
           
            

            d1.OutroResultado = d2;
            d2.OutroResultado = d3;
            d3.OutroResultado = d4;

            d1.Resultado(new Requisicao(Formato.PORCENTO), marcelo);
            d1.Resultado(new Requisicao(Formato.XML), marcelo);
            d1.Resultado(new Requisicao(Formato.CSV), marcelo);
            */

            Imposto ikcv = new IKCV();
            Imposto icpp = new ICPP();
            Imposto ihit = new IHIT();


            Orcamento orcamento = new Orcamento(100);
            orcamento.AdicionaItem(new Item("CANETA", 250));
            orcamento.AdicionaItem(new Item("LAPIS", 250));
            orcamento.AdicionaItem(new Item("copo", 250));

            CalculadorDeImpostos calculadora = new CalculadorDeImpostos();

            calculadora.RealizaCalculo(orcamento, ikcv);
            calculadora.RealizaCalculo(orcamento, icpp);
            calculadora.RealizaCalculo(orcamento, ihit);
            Console.ReadLine();
        }

      
    }
}
