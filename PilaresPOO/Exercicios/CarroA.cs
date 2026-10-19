using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.Exercicios
{
    internal class CarroA : Veiculo
    {
        public int Portas { get; set; }
        public CarroA(string marca, string modelo, int portas) : base(marca, modelo)
        {
            Portas = portas;
        }
        public string Exibir;
        public void ExibirPortas()
        {
            Console.WriteLine($"Portas: {Portas}");
        }

    }
}
