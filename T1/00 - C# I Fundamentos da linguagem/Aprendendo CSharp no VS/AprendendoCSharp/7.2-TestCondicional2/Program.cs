using System;

namespace _7._2_TestCondicional2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando condicionais");

            int idade = 16;
            int quantidadePessoas = 3;
            bool acompanhado = quantidadePessoas>=2;
            if (idade>=18 && acompanhado)
            {
                Console.WriteLine("Seja bem Vindo");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar");
            }
        }
    }
}
