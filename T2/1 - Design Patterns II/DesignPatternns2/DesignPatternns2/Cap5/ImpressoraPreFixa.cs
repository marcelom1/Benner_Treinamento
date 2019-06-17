using DesignPatternns2.Cap4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternns2.Cap5
{
    public class ImpressoraPreFixa :IVisitor
    {
        public void ImprimeSoma(Soma soma)
        {
            Console.Write("(");
            Console.Write(" + ");
            soma.Esquerda.Aceita(this);
           
            soma.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeSubtracao(Subtracao subtracao)
        {
            Console.Write("(");
            Console.Write(" - ");
            subtracao.Esquerda.Aceita(this);
            
            subtracao.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeRaizQuadrada(RaizQuadrada raizQuadrada)
        {
            Console.Write("(");

            Console.Write(" v¬ ");
            raizQuadrada.Expressao.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeNumero(Numero numero)
        {
            Console.Write(" ");
            Console.Write(numero.Valor);
            Console.Write(" ");
        }

        public void ImprimeMultiplicacao(Multiplicacao multiplicacao)
        {
            Console.Write("(");
            Console.Write(" * ");
            multiplicacao.Esquerda.Aceita(this);
            
            multiplicacao.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeDivisao(Divisao divisao)
        {
            Console.Write("(");
            Console.Write(" / ");
            divisao.Esquerda.Aceita(this);
           
            divisao.Direita.Aceita(this);
            Console.Write(")");
        }
    }
}
