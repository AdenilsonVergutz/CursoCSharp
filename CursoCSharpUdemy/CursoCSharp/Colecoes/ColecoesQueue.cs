﻿using System;
using System.Collections.Generic;
using System.Collections;


namespace CursoCSharp.Colecoes
{
     class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count());

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count());

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("item A");
            salada.Enqueue(true);
            salada.Enqueue(10.8);

            Console.WriteLine(salada.Contains("item B"));
            Console.WriteLine(salada.Contains("item A"));

        }


    }
}
