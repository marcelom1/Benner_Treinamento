﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //GravarUsandoAdoNet();
            //GravarUsandoEntity();
            // RecuperarProdutos();
            // ExcluirProdutos();
            // RecuperarProdutos();
             AtualizarProduto();


            Console.ReadLine();
        }

        private static void AtualizarProduto()
        {
            RecuperarProdutos();
            using (var repo = new LojaContex())
            {
                Produto primeiro = repo.Produtos.First();
                primeiro.Nome = "Vingadores - Ultimato 2";
                repo.Produtos.Update(primeiro);
                repo.SaveChanges();

            }
            RecuperarProdutos();
            
            
        }

        private static void ExcluirProdutos()
        {
            using (var repo = new LojaContex())
            {
                IList<Produto> produtos = repo.Produtos.ToList();
                foreach (var item in produtos)
                {
                    repo.Produtos.Remove(item);

                }
                repo.SaveChanges();
            }
        }

        private static void RecuperarProdutos()
        {
            using (var repo = new LojaContex())
            {
                IList<Produto> produtos = repo.Produtos.ToList();
                Console.WriteLine("Foram encontrados {0} produtos(s).", produtos.Count);
                foreach (var item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }
            }
        }

        private static void GravarUsandoEntity()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var contexto = new LojaContex())
            {
                contexto.Produtos.Add(p);
                contexto.SaveChanges();
            }

        }

        private static void GravarUsandoAdoNet()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var repo = new ProdutoDAO())
            {
                repo.Adicionar(p);
            }
        }
    }
}