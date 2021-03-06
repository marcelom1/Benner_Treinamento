﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class EmAprovacao : EstadoDeUmOrcamento
    {
        bool DescontoJaAplicado = false;
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (DescontoJaAplicado = !true)
            {
                orcamento.Valor -= orcamento.Valor * 0.05;
                DescontoJaAplicado = true;
            }
        }
        public void Aprova(Orcamento orcamento)
        {
           
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Reprova(Orcamento orcamento)
        {
            
            orcamento.EstadoAtual = new Reprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            
            throw new Exception("Orcamento em aprovação não podem ir para finalizado diretamente");
        }
    }
}
