using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace PilaresPOO.Exercicios
{
    internal class Contato
    {
        private string Nome;
        private string Telefone;
        private string Email;

        public Contato(string Nome, string Telefone, string Email)
        {
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Email = Email;
        }
        public Contato(string Nome, string Telefone)
        {
            this.Nome = Nome;
            this.Telefone = Telefone;
           
        }
        public void Exibir()
        {
            Console.WriteLine($"{Nome} | {Telefone} | {Email}");
        }
    }
}
