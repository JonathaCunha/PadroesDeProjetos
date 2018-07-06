using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Abstract_Factory
{
    public class Cliente
    {
        public Cliente(FabricaAbstrata fabrica)
        {
            Janela = fabrica.CrieJanela();
            Botao = fabrica.CrieBotao();
        }
        public JanelaAbstrata Janela { get; set; }
        public BotaoAbstrato Botao { get; set; }

        public void Desenhe()
        {
            Console.WriteLine("Desenhando");
            Console.WriteLine($"{Janela.Titulo} Cor {Janela.Cor} Botão Cor {Botao.Cor}");            
        }
    }
}
