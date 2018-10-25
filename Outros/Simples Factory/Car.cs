namespace Outros.Simples_Factory
{
    public abstract class Car
    {
        public string Nome { get; protected set; }
        public Car(string nome)
        {
            Nome = nome;
        }
    }
}