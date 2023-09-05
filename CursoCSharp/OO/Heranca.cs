﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{

    public class Carro
    {
        protected readonly int velocidadeMaxima;
        int velocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            velocidadeMaxima = velocidadeMaxima;

        }

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = velocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                velocidadeAtual = 0;
            }
            else if (novaVelocidade > velocidadeMaxima)
            {
                velocidadeAtual = velocidadeMaxima;
            }
            else
            {
                velocidadeAtual = novaVelocidade;
            }

            return velocidadeAtual;

        }

        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);
        }

        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro
    {
        public Uno() : base(200)
        {

        }
    }
    public class Ferrari : Carro
        {
        public Ferrari() : base(350)
        {

        }

        public override int Acelerar()
            {
                return AlterarVelocidade(15);
            }

        // Oculta o método da classe pai
        public new int Frear()
            {
                return AlterarVelocidade(-15);
            }
        
    }


     class Heranca
    {
        
        
        public static void Executar()
        {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());


            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
        }
    }
}
