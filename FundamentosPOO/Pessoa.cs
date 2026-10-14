using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace semana_4
{
    public class Pessoa
    {
        // Atributos - Caracteristicas
        // NomeDoCliente, Item, Quantidade, Preco
        public string Nome;
        public int Idade;
        // Metodos - Ações
        public void Apresentar()
        {
            Console.WriteLine("oi" + Nome + Idade);
        }
        public void Cumprimentar()
        {
            Console.WriteLine($"Olá, eu sou {Nome}");
        }
        public void CumprimentarAlguem(string outraPessoa)
        {
            Console.WriteLine($"Olá, {outraPessoa}! Eu sou {Nome}.");
        }
        public string ObterApresentacao()
        {
            return $"Meu Nome é {Nome}";
        }
    }
}








