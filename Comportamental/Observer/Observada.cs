using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Comportamental.Observer
{
    public class Observada
    {
        public int Numero { get; protected set; }
        protected List<ObservadorAbstrato> Observadores { get; set; }


        public void AlterarNumero(int numero)
        {
            Numero = numero;
            NotifiqueTodos();
        }

        public Observada()
        {
            Observadores = new List<ObservadorAbstrato>();
        }


        public void AdicioneObservador(ObservadorAbstrato observador)
        {
            Observadores.Add(observador);
        }

        public void RemovaObservador(int indice)
        {
            Observadores.RemoveAt(indice);
        }

        public void NotifiqueTodos()
        {
            foreach (var observador in Observadores)
            {
                observador.Notifique();
            }
        }
    }
}
