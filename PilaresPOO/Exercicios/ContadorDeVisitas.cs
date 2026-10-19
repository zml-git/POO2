using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.Exercicios
{
    internal class ContadorDeVisitas
    {
        private int visitas { get; set; }
        public void RegistrarVisita()
        {
            visitas++;
        }
        public int ObterTotal()
        {
            return visitas;
        }
    }
}