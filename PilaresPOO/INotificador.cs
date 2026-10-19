using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO
{
    internal interface INotificador
    {
        //apenas métodos
        void Enviar(string mensagem);
    }
    public class Email : INotificador
    {
        public void Enviar(string mensagem)
        {
            Console.WriteLine($"Email enviado: {mensagem}");
        }
    }
    public class Zapzap : INotificador
    {
        public void Enviar(string mensagem)
        {
            Console.WriteLine($"Zap coisado: {mensagem}");
        }
    }

    public class Loja
    {
        public void Finalizar(INotificador notificador)
        {
            notificador.Enviar("Compra confirmada!");
        }
    }


}

