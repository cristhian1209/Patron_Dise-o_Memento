using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPatronMemento.Model
{
    public class Memento
    {
        private int estado;
      
        public Memento(int estado)
        {
            this.estado = estado;
        }

        public void setMarcadorPagina(int estado)
        {
            this.estado = estado;
        }
   
        public int getMarcadorPagina()
        {
            return this.estado;
        }
    }
}
