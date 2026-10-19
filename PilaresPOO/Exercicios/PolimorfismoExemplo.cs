using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.Exercicios
{
    internal class PolimorfismoExemplo
    {
        //exemplo sobrecarga
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public double Somar(double a, double b)
        {
            return a + b;
        }

        // Inválido
        //public int Somar(int a, int b)
        //{
        //    return a - b;
        //}

        public int Somar(int a, int b, int c)
        {
            Console.WriteLine("Somei 3 numeros!");
            return a + b + c;
        }

        //exemplo override
        internal class Animal
        {
            public virtual void FazerSom()
            {
                Console.WriteLine("O animal faz um som");
            }
        }

        internal class Cachorro : Animal
        {
            public override void FazerSom()
            {
                Console.WriteLine("Au au!");
            }
        }


        internal class Gato : Animal
        {
            public override void FazerSom()
            {
                Console.WriteLine("Miau!");
            }
        }

    }
}

