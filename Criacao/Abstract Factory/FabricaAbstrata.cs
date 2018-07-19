
/// <summary>
/// Fornecer uma interface para criação de famílias de objetos relacionados ou dependentes sem especificar suas classes concretas.
/// </summary>
namespace Criacao.Abstract_Factory
{
    public abstract class FabricaAbstrata
    {
        public abstract BotaoAbstrato CrieBotao();

        public abstract JanelaAbstrata CrieJanela();
    }
}