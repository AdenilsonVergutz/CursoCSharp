﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{

     class ColecoesSet 
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto>()
            {
                new Produto("Camisa", 29.9),
                new Produto("Kit 4 camisa", 99.9),
                new Produto("Livro Harry Pottter", 38.5),
                new Produto("Livro Harry Pottter", 38.5)

            };

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
            // carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
                // Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} - {item.Preco}");
            }
            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);

            // Console.WriteLine(carrinho.LastIndexOf(livro));

        }
    }
}
