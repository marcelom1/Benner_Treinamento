using System.Collections.Generic;
using System.Linq;

namespace Alura.LeilaoOnline.Core
{
    public class Leilao
    {
        public enum EstadoLeiao
        {
            LeilaoEmAndamento,
            LeilaoFinalizado,
            LeilaoAntesDoPregao
        }
        private Interessada _ultimoCliente;
        private IList<Lance> _lances;
        public IEnumerable<Lance> Lances => _lances;
        public string Peca { get; }
        public Lance Ganhador { get;private set; }
        public EstadoLeiao Estado { get; private set; }
        public double ValorDestino { get; }
        private IModalidadeAvaliacao _avaliador;


        public Leilao(string peca, IModalidadeAvaliacao avaliador)
        {
            Peca = peca;
            _lances = new List<Lance>();
            Estado = EstadoLeiao.LeilaoAntesDoPregao;
            _avaliador = avaliador;
        }

        private bool NovoLanceEhAceito(Interessada cliente, double valor)
        {
            return (Estado==EstadoLeiao.LeilaoEmAndamento)
                && (cliente!=_ultimoCliente);
        }

        public void RecebeLance(Interessada cliente, double valor)
        {
            
            if (NovoLanceEhAceito(cliente, valor)){ 
                _lances.Add(new Lance(cliente, valor));
                _ultimoCliente = cliente;
            }
        }

        public void IniciaPregao()
        {
            Estado = EstadoLeiao.LeilaoEmAndamento;
        }

        public void TerminaPregao()
        {
            if (Estado != EstadoLeiao.LeilaoEmAndamento)
            {
                throw new System.InvalidOperationException("Não é possivel terminar o pregão sem que ele tenha começado. Para isso utilize o método IniciaPregao()");
            }
            Ganhador = _avaliador.Avalia(this);
            Estado = EstadoLeiao.LeilaoFinalizado;

        }
    }
}
