using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.Exercicios
{
    internal class Animal
    {
        public string Nome { get; set; }
        public void Comer()
        {
            Console.WriteLine(Nome + " está comendo!");
        }
        public void Latir()
        {
            Console.WriteLine(Nome + ": Au Au!");
        }
    }
}
