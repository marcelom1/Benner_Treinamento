using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class IHIT : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                foreach (Item item2 in orcamento.Itens)
                {
                    if (item.Nome.Equals(item2.Nome))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13+100;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.01*orcamento.Itens.Count;
        }
        
    }
}
