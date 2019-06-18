using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acoplamento
{
    public class GeradorDeNotaFiscal
    {
       
        private IList<IAcaoAposGerarNota> acoes;

       

        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes1)
        {
            this.acoes = acoes1;
        }

        public NotaFiscal gera(Fatura fatura)
        {
            double valor = fatura.ValorMensal;
            NotaFiscal nf = new NotaFiscal(valor, ImpostoSimplesSobreO(valor));
            foreach (IAcaoAposGerarNota acao in acoes)
            {
                acao.Executa(nf);
            }
            return nf;
        }
        private double ImpostoSimplesSobreO(double valor)
        {
            return valor * 0.06;
        }
    }
}
