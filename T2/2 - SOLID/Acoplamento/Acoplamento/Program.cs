using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acoplamento
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exemplo de uma classe com acoplamento
            /*class GeradorDeNotaFiscal
            {
                    private EnviadorDeEmail email;
                    private NotaFiscalDao dao;

                    public GeradorDeNotaFiscal(EnviadorDeEmail email, NotaFiscalDao dao) {
                    this.email = email;
                    this.dao = dao;
                    }

                public NotaFiscal Gera(Fatura fatura) {

                    double valor = fatura.ValorMensal;

                    NotaFiscal nf = new NotaFiscal(valor, ImpostoSimplesSobreO(valor));

                    email.EnviaEmail(nf);
                    dao.Persiste(nf);

                    return nf;
                }

                private double ImpostoSimplesSobreO(double valor) {
                    return valor * 0.06;
                }
            }*/

            EnviadorDeEmail enviadorDeEmail = new EnviadorDeEmail();
            NotaFiscalDao notadao = new NotaFiscalDao();
            IList<IAcaoAposGerarNota> acoes = new List<IAcaoAposGerarNota>();
            acoes.Add(new EnviadorDeEmail());
            acoes.Add(new NotaFiscalDao());
            GeradorDeNotaFiscal gfn = new GeradorDeNotaFiscal(acoes);
            Fatura fatura = new Fatura(200, "Marcelo");
            gfn.gera(fatura);

            Console.ReadLine();
              
             
        }
    }
}
