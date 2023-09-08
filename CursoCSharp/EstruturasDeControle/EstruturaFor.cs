using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.EstruturasDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {
           // for (int i =1;  i<=10; i++)
           // {
          //      Console.WriteLine($"O valor de i é {i}^.");
          //  }

            double somatorio = 0;
            string entrada;

            Console.WriteLine("informe o tamanho da sua turma: ");
            entrada= Console.ReadLine();
            int.TryParse(entrada, out int tamanhoturma);

            for (int i = 1; i <= tamanhoturma; i++)
            {
                Console.WriteLine("Informe a nota do aluno {0}: ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }

            double media = tamanhoturma > 0 ? somatorio / tamanhoturma : 0;
            Console.WriteLine("A Média da turma: {0}", media);

        }
    }
}
