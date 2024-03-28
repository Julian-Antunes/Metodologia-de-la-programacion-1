using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia_de_la_programacion_1
{
    public class ColeccionMultiple :iColeccionable
    {
        Pila pila;
        Cola cola;
        public ColeccionMultiple(Pila p, Cola c) { this.pila = p; this.cola = c; }

        public void agregar(iComparable c)
        {
            return;
        }

        public bool contiene(iComparable c)
        {
            if (this.pila.contiene(c) || this.cola.contiene(c)) return true;
            else { return false; }

        }

        public int cuantos()
        {
           var suma = this.pila.cuantos() + this.cola.cuantos();
           return suma ;
        }

        public iComparable maximo()
        {
            var maxPila=(Numero)this.pila.maximo();
            var maxCola =(Numero)this.cola.maximo();
            if (maxPila.getValor() > maxCola.getValor()){ return maxPila; }
 
            else { return maxCola; }
        }

        public iComparable minimo()
        {
            var minPila = (Numero)this.pila.minimo();
            var minCola = (Numero)this.cola.minimo();
            if (minPila.getValor()  < minCola.getValor()) { return minPila; }

            else { return minCola; }
        }
    }
}
