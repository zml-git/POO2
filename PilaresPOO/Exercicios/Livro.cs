using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.Exercicios
{
    internal class Livro
    {
        public string Titulo;
        public string Autor;
        public int Paginas;

        public Livro (string Titulo, string Autor, int Paginas)
        {
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.Paginas = Paginas;
        }
        public void Exibir()
        {
            Console.WriteLine($"Título: {Titulo}\nAutor: {Autor}\nPáginas: {Paginas}");
        }
    }
}
