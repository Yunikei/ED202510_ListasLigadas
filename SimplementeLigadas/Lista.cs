using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplementeLigadas
{
    internal class Lista
    {
        private Nodo _nodoInicial;

        public Lista()
        {
            _nodoInicial = new Nodo();
        }

        public void Agregar(string valor)
        {
           //Llegar al final de la lista
           Nodo nodoActual = _nodoInicial;
           while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
            }
            
           Nodo nuevoNodo = new Nodo(valor);
           nodoActual.Siguiente = nuevoNodo;
        }
    }
}
