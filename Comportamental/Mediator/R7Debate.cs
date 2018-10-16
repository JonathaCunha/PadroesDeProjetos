using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Mediator
{
    public class R7Debate : MediadorDebate
    {
        public List<Politico> usuarios;
        public R7Debate()
        {
            usuarios = new List<Politico>();
        }

        public void AdicionarUsuario(Politico usuario)
        {
            usuario.AdicionarDebate(this);
            usuarios.Add(usuario);
        }

        public override void EnviarMensagem(string mensagem, Politico usuario)
        {
            foreach (var usuarioEnviar in usuarios)
            {
                if (usuarioEnviar.Equals(usuario))
                    continue;
                string mensagemFormatada = $"De {usuario.Nome}: {mensagem}";
                usuarioEnviar.ReceberMensagem(mensagemFormatada);
            }
        }
    }
}
