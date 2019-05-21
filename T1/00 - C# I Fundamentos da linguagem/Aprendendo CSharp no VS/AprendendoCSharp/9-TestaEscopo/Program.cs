using System;

namespace _9_TestaEscopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando condicionais - Escopo");

            int idade = 16;
            int quantidadePessoas = 1;
            bool acompanhado;
            if (quantidadePessoas >= 3)
            {
                acompanhado = true;
            }
            else
            {
                acompanhado = false;
            }

            if (idade >= 18 || acompanhado)
            {
                Console.WriteLine("Seja bem Vindo");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar");
            }
            Console.ReadLine();
        }
    }
}
