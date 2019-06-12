using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class FiltroContaSaldoMaior500Reais : Filtro
    {
       

        public FiltroContaSaldoMaior500Reais(Filtro outroFiltro) : base(outroFiltro) { }
        public FiltroContaSaldoMaior500Reais() : base() { }

        

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> Filtrados;
            Filtrados = new List<Conta>();
            foreach (Conta Fcontas in contas)
            {
                if (Fcontas.Saldo>500000)
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
