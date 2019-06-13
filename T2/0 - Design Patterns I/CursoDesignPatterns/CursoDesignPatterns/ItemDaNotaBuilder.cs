using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class ItemDaNotaBuilder
    {
        public String Nome { get; private set; }
        public double Valor { get; private set; }

        public ItemDaNota CriarItem()
        {
            return new ItemDaNota(Nome, Valor);
        }
        public ItemDaNotaBuilder ItemNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public ItemDaNotaBuilder ItemValor(double valor)
        {
            Valor = valor;
            return this;
        }
    }
}
