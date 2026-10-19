using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.Exercicios
{
    internal class Viagem
    {
            public string Destino;
            public int Dias;
            public double ValorDiaria;

            public Viagem(string Destino, int Dias, double ValorDiaria)
            {
                this.Destino = Destino;
                this.Dias = Dias;
                this.ValorDiaria = ValorDiaria;
            }
        public double CalcularTotal()
        {
            { return Dias * ValorDiaria; }
        }
            public void Exibir()
            {
                Console.WriteLine($"a viagem para {Destino}, {Dias} dias, com diária de {ValorDiaria}, ficará no valor de {CalcularTotal().ToString("F2")}");
            }
      
    }
}
