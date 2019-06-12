using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class FiltroContaAberturaNoMes : Filtro
    {
        public FiltroContaAberturaNoMes(Filtro outroFiltro) : base(outroFiltro) { }
        public FiltroContaAberturaNoMes() : base() { }
        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> Filtrados;
            Filtrados = new List<Conta>();
            foreach (Conta Fcontas in contas)
            {
                if (Fcontas.DataAbertura.Month == DateTime.Now.Month)
                {
                    Filtrados.Add(Fcontas);
                }
            }

            foreach (Conta Pcontas in Proximo(contas))
            {
                Filtrados.Add(Pcontas);
            }
          

            return Filtrados;

        }

        
    }
}
