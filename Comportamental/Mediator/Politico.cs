using System;

namespace Comportamental.Mediator
{
    public abstract class Politico
    {
        public string Nome { get; private set; }
        protected MediadorDebate mediator;

        public Politico(string nome)
        {
            Nome = nome;
        }
        public void AdicionarDebate(MediadorDebate debate)
        {
            mediator = debate;
        }
        public void EnviarMensagem(string mensagem)
        {
            mediator.EnviarMensagem(mensagem, this);
        }

        public abstract void ReceberMensagem(string mensagem);
    }
}