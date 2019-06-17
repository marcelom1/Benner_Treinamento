using DesignPatternns2.Cap1;
using DesignPatternns2.Cap2;
using DesignPatternns2.Cap3;
using DesignPatternns2.Cap4;
using DesignPatternns2.Cap5;
using DesignPatternns2.Cap6;
using DesignPatternns2.Cap7;
using DesignPatternns2.Cap8;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternns2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   IDbConnection conexao = new ConnectionFactory().GetConnection();
               IDbCommand comando = conexao.CreateCommand();
               comando.CommandText = "select * from tabela";
           */
            /* NotasMusicais notas = new NotasMusicais();

             IList<INota> doReMiFa = new List<INota>() {
             notas.Pega("do"),
             notas.Pega("re"),
             notas.Pega("mi"),
             notas.Pega("fa"),
             notas.Pega("fa"),
             notas.Pega("fa"),

             notas.Pega("do"),
             notas.Pega("re"),
             notas.Pega("do"),
             notas.Pega("re"),
             notas.Pega("re"),
             notas.Pega("re"),

             notas.Pega("do"),
             notas.Pega("sol"),
             notas.Pega("fa"),
             notas.Pega("mi"),
             notas.Pega("mi"),
             notas.Pega("mi"),

             notas.Pega("do"),
             notas.Pega("re"),
             notas.Pega("mi"),
             notas.Pega("fa"),
             notas.Pega("fa"),
             notas.Pega("fa")
         };
             Piano piano = new Piano();
             piano.Toca(doReMiFa);
             */
            /*
           Historico historico = new Historico();

           Contrato contrato = new Contrato(DateTime.Now, "Mauricio", TipoContrato.Novo);
           historico.Adiciona(contrato.SalvaEstado());

           contrato.Avanca();
           historico.Adiciona(contrato.SalvaEstado());

           contrato.Avanca();
           historico.Adiciona(contrato.SalvaEstado());

           contrato.Avanca();
           historico.Adiciona(contrato.SalvaEstado());

           Console.WriteLine(historico.Pega(2).Contrato.Tipo);
           */

            /* IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
             IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
             IExpressao soma = new Soma(esquerda, direita);

             Console.WriteLine(soma.Avalia());
             IVisitor impressora = new ImpressoraPreFixa();
             soma.Aceita(impressora);
             */
            /*Expression soma2 = Expression.Add(Expression.Constant(10), Expression.Constant(100));
            Func<int> funcao = Expression.Lambda<Func<int>>(soma2).Compile();
            
            Console.WriteLine(funcao());
            */

            /*IEnviador enviador = new EnviaPorEmail();
            IMensagem mensagem = new MensagemAdministrativa("victor");
            mensagem.Enviador = enviador;
            
            mensagem.Envia();*/
            /*
            IEnviador enviador = new EnviaPorSMS();
            IMensagem mensagem = new MensagemCliente("mauricio");
            mensagem.Enviador = enviador;

            mensagem.Envia();
            */
            /*
            Pedido pedido1 = new Pedido("Mauricio", 150.0);
            Pedido pedido2 = new Pedido("Marcelo", 250.0);

            FilaDeTrabalho fila = new FilaDeTrabalho();

            fila.Adiciona(new PagaPedido(pedido1));
            fila.Adiciona(new PagaPedido(pedido2));
            fila.Adiciona(new FinalizaPedido(pedido1));

            fila.Processa();
            */
            Cliente cliente = new Cliente();
            cliente.Nome = "victor";
            cliente.Endereco = "Rua Vergueiro";
            cliente.DataDeNascimento = DateTime.Now;

            GeradorDeXml gerador = new GeradorDeXml();
            string xml = gerador.GeraXml(cliente);

            Console.WriteLine(xml);
            Console.ReadLine();
        }
    }
}
