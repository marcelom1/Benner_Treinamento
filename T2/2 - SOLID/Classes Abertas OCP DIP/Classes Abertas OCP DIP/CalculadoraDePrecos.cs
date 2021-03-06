﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Abertas_OCP_DIP
{
    public class CalculadoraDePrecos
    {
        private ITabelaDePreco tabela;
        private IServicoDeEntrega entrega;

        public CalculadoraDePrecos(ITabelaDePreco tabela, IServicoDeEntrega entrega)
        {
            this.tabela = tabela;
            this.entrega = entrega;
        }

        public double Calcula(Compra produto)
        {
            
            double desconto = tabela.DescontoPara(produto.Valor);
            double frete = entrega.Para(produto.Cidade);

            return produto.Valor * (1 - desconto) + frete;
        }
    }
}
