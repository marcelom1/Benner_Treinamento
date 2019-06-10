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
            Investimento conservador = new Conservador();
            Investimento moderado = new Moderado();
            Investimento arrojado = new Arrojado();

            Conta marcelo = new Conta();

            marcelo.Deposita(50);

            RealizadorDeInvestimentos calInvest = new RealizadorDeInvestimentos();

            calInvest.Realiza(marcelo, conservador);
            calInvest.Realiza(marcelo, moderado);
            calInvest.Realiza(marcelo, arrojado);





            Console.ReadLine();
        }
    }
}
