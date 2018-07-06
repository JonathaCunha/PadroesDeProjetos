namespace Criacao.Abstract_Factory
{
    public abstract class FabricaAbstrata
    {
        public abstract BotaoAbstrato CrieBotao();

        public abstract JanelaAbstrata CrieJanela();
    }
}