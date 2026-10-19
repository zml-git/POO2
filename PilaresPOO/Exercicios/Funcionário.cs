using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.Exercicios
{
    internal class Funcionario
    {
        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public string Nome { get; set; }
        public double Salario { get; set; }
    }
}
