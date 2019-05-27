using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
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

            using (var contexto = new LojaContex())
            {
                var serviceProvider = contexto.GetInfrastructure<IServiceProvider>();
                var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(SqlLoggerProvider.Create());
                var produtos = contexto.Produtos.ToList();

                ExibeEntries(contexto.ChangeTracker.Entries());

                //  var p1 = produtos.Last();
                //p1.Nome = "007 - O Espiao";

                var novoProduto = new Produto()
                {
                    Nome = "Sabão Em Pó",
                    Categoria = "Limpeza",
                    Preco = 4.99

                };
                contexto.Produtos.Add(novoProduto);

                contexto.Produtos.Remove(novoProduto);

                ExibeEntries(contexto.ChangeTracker.Entries());


                Console.WriteLine("=================");

                contexto.SaveChanges();

                ExibeEntries(contexto.ChangeTracker.Entries());

                var entry = contexto.Entry(novoProduto);
                Console.WriteLine("\n\n" + entry.Entity.ToString() + " - " + entry.State);

            }
        }

        private static void ExibeEntries(IEnumerable<EntityEntry> entries)
        {
            Console.WriteLine("=================");
            foreach (var e in entries)
            {
                Console.WriteLine(e.Entity.ToString() + " - " + e.State);
            }
        }
    }           
}
