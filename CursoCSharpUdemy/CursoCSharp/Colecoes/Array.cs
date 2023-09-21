using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
     class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "Adenilson";
            alunos[1] = "Patrícia";
            alunos[2] = "Ade";
            alunos[3] = "Vergutz";
            alunos[4] = "Anna";

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = {9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach (var nota in notas)
            {
                somatorio += nota;
            }

            //for (int i = 0; i < notas.Length; i++)
            //{
            //    somatorio += notas[i];
            //}

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'R', 'R', 'A', 'Y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}
