using DesignPatternns2.Cap1;
using DesignPatternns2.Cap2;
using DesignPatternns2.Cap3;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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

            Console.ReadLine();
        }
    }
}
