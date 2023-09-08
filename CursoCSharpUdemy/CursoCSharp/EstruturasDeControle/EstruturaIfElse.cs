using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.EstruturasDeControle
{
    class EstruturaIfElse
    {
        public static void Executar()
        {
            string entrada;

            Console.Write("Digite a nota do Aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Não fez mais que sua obrigação...");
            }else
            {
                Console.WriteLine("Recuperação!");
            }
          

        }
    }
}
