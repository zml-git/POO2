using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.Exercicios
{
        internal class Violao : Instrumento
        {
            public override void Tocar()
            {
                Console.WriteLine("Violão: plim plim");
            }
        }
}
