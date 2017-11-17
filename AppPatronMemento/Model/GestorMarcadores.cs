using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPatronMemento.Model
{
    public class GestorMarcadores
    {
        private  List<Memento> marcadores = new  List<Memento> ()  ;
        public void addPosicionMarcador(Memento m)
        {
            marcadores.Add(m);
        }
        
        public Memento getPosicionMarcador(int indice)
        {
            return marcadores.ElementAt(indice);
        }
    }
}
