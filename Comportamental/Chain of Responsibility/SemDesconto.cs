namespace Comportamental.Chain_of_Responsibility
{
    public class SemDesconto : Desconto
    {
        public override decimal Calcular(Pedido pedido)
        {
            return 0;
        }
    }
}