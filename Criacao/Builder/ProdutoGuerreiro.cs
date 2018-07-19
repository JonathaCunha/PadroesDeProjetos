using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Builder
{
    public class ProdutoGuerreiro
    {
        public ProdutoGuerreiro()
        {
            Espada = "Sem Espada";
            Escudo = "Sem Escudo";
            Flecha = "Sem Flecha";
        }

        public string Tipo { get; set; }
        public string Espada { get; protected set; }
        public string Escudo { get; protected set; }
        public string Flecha { get; protected set; }

        public void AdicionarEspada(string espada)
        {
            Espada = espada;
        }

        public void AdicionarEscudo(string escudo)
        {
            Escudo = escudo;
        }

        public void AdicionarFlecha(string flecha)
        {
            Flecha = flecha;
        }

    }
}
