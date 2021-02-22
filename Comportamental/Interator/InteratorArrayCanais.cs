namespace Comportamental.Interator
{
    internal class InteratorArrayCanais : Interator
    {
        private readonly Canal[] canais;
        private int contador;

        public InteratorArrayCanais(Canal[] canais)
        {
            this.canais = canais;
        }

        public Canal CurrentItem()
        {
            return canais[contador];
        }

        public bool HasValue()
        {
            return contador < canais.Length;
        }

        public void Next()
        {
            contador++;
        }
    }
}