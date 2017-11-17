using AppPatronMemento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPatronMemento
{
    class Program
    {
        static void Main(string[] args)
        {
            GestorMarcadores objGestorMarcadores = new GestorMarcadores();
           
            Libro libro = new Libro();
            libro.irPagina(10);
         
            objGestorMarcadores.addPosicionMarcador(libro.guardarMarcador());
           
            libro.irPagina(83);
            
            objGestorMarcadores.addPosicionMarcador(libro.guardarMarcador());
            
            libro.recuperarPagina(objGestorMarcadores.getPosicionMarcador(0));
          
            libro.recuperarPagina(objGestorMarcadores.getPosicionMarcador(1));

            Console.ReadKey();
        }
    }
}
