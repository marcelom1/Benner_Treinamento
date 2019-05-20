using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1_TestChar
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra = 'a';
            Console.WriteLine(letra);

            char valor = (char)65;
            Console.WriteLine(valor);

            valor = (char)(valor + 1);
            Console.WriteLine(valor);

            string palavra = "alura cursos online de tecnologia";
            Console.WriteLine(palavra);

            palavra = palavra + 2020;
            Console.WriteLine(palavra);
            Console.ReadLine();
        }
    }
}
