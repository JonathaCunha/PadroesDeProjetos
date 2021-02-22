using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Comportamental.Command
{
    public class CaixaDeMensagem
    {
        public IDictionary<string, string> mensagemRecebidas;
        public string Nome { get; set; }

        public CaixaDeMensagem(string nome)
        {
            Nome = nome;
            mensagemRecebidas = new Dictionary<string, string>();
        }        

        public string ReceberMensagem(string mensagem)
        {
            string idMensagem = GerarID(mensagem);
            mensagemRecebidas.Add(idMensagem, mensagem);
            Console.WriteLine($"{Nome} recebeu: {mensagem} - Id {idMensagem}");
            return idMensagem;
        }

        private string GerarID(string mensagem)
        {
            return Nome.Substring(1)
                            + DateTime.Now.Ticks
                            + "L" + mensagem.Length;
        }
        public void ExcluarMensagem(string idMensagem)
        {
            mensagemRecebidas.Remove(idMensagem);
            Console.WriteLine($"Exclusão Mensagem {idMensagem} Contato: {Nome}");
        }
    }
}