using System;

namespace _7._3_Condicional_IR
{
    class Program
    {
        static void Main(string[] args)
        {
            /* O João gostaria de criar um programa sobre Imposto de Renda(IR) e verificou as regras de alíquota. Ele descobriu no site da receita:

             **VALORES ALTERADOS COM ATUAL PLANILHA DO IR DA RECEITA FEDERAL**
             
             De 1903.99 até 2826.65, o IR é de 7.5 % e pode deduzir na declaração o valor de R$ 142.80;
             De 2826.66 até 3751.05, o IR é de 15 % e pode deduzir R$ 354.80;
             De 3751.06 até 4664.68, o IR é de 22.5 % e pode deduzir R$ 636.13;
             Acima de 4664.68 o IR é de 27.5 %  pode deduzir R$ 869.36.

             Agora ajude o João a implementação todas as regras usando condicionais!*/
             

            Console.WriteLine("*****Imposto de Renda (IR)*****");
            double salario = 3300.00;
            double salarioLiq;
            float aliq;
            double valorDeduzir;

            if (salario <1903.99)
            {
                aliq = 0;
                valorDeduzir = 0;       
            }
            else
            {
                if (salario <= 2826.65)
                {
                    aliq = 7.5f;
                    valorDeduzir = 142.80;    
                }
                else
                {
                    if (salario<= 3751.05)
                    {
                        aliq = 15.0f;
                        valorDeduzir = 354.80;
                    }
                    else
                    {
                        if (salario<= 4664.68)
                        {
                            aliq = 22.5f;
                            valorDeduzir = 636.13;                            
                        }
                        else
                        {
                            aliq = 27.5f;
                            valorDeduzir = 869.36;                            
                        }
                    }
                }
            }
            salarioLiq = salario - ((salario / 100 * aliq) - valorDeduzir);
            Console.WriteLine("A sua aliquota é de " + aliq+"%");
            Console.WriteLine("Você pode deduzir até R$" + valorDeduzir);
            Console.WriteLine("O Seu salario após o desconto fica R$" + salarioLiq);

            Console.ReadLine();

        }
    }
}
