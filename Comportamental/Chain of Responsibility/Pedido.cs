namespace Comportamental.Chain_of_Responsibility
{
    public class Pedido
    {
        public Pedido(decimal valor, int quantidadesItens)
        {
            Valor = valor;
            QuatidadesItens = quantidadesItens;
        }
        public decimal Valor { get; set; }
        public int QuatidadesItens { get; set; }
    }
}