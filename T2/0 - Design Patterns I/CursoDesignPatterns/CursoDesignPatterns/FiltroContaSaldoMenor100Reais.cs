using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class FiltroContaSaldoMenor100Reais : Filtro
    {
        public FiltroContaSaldoMenor100Reais(Filtro outroFiltro) : base(outroFiltro) { }
        public FiltroContaSaldoMenor100Reais() : base() { }
        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> Filtrados;
            Filtrados = new List<Conta>();
            foreach (Conta Fcontas in contas)
            {
                if (Fcontas.Saldo < 100)
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
