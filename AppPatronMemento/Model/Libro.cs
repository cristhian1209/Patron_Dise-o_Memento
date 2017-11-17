using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPatronMemento.Model
{
    public class Libro
    {

        private int pagina_actual;

        public void irPagina(int pagina)
        {
            this.pagina_actual = pagina;
            Console.WriteLine("Agregado marcador en página [" + this.pagina_actual + "]");

        }

        public Memento guardarMarcador()
        {
            Console.WriteLine("Marcador guardado");

            return new Memento(this.pagina_actual);
        }

        public void recuperarPagina(Memento m)
        {
            this.pagina_actual = m.getMarcadorPagina();
            Console.WriteLine("Volvemos a la página: " + pagina_actual);

        }
    }
}
