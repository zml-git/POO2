using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.Exercicios
{
    internal class MotoB : Veiculo
    {
        public int Cilindradas { get; set; }
        public MotoB(string marca, string modelo, int cilindradas) : base(marca, modelo)
        {
            Cilindradas = cilindradas;
        }
        public void ExibirCilindradas()
        {
            Console.WriteLine($"Cilindradas: {Cilindradas}");
        }

    }
}
