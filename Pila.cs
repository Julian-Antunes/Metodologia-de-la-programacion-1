using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia_de_la_programacion_1
{ //ejercicio 4
    public class Pila : iColeccionable
    {
        List<iComparable> elementos;
        public Pila() { this.elementos = new List<iComparable>(); }
        public void apilar(iComparable c) { this.elementos.Add(c); }
        public iComparable desapilar()
        {
            iComparable e = this.elementos[this.elementos.Count - 1];
            this.elementos.RemoveAt(this.elementos.Count - 1);
            return e;
        }

        public int cuantos() { return this.elementos.Count; }
        public iComparable minimo()
        {
            iComparable masChico = this.elementos[0];

            for (int i = 1; i < elementos.Count; i++)
            {
                if (this.elementos[i].sosMenor(masChico))
                    masChico = this.elementos[i];
            }
            return masChico;
        }
        public iComparable maximo()
        {
            iComparable masGrande = this.elementos[0];
            for (int i = 1; i < elementos.Count; i++)
            {
                if (this.elementos[i].sosMayor(masGrande))
                    masGrande = this.elementos[i];
            }
            return masGrande;
        }
        public void agregar(iComparable c)
        {
            this.apilar(c);
        }

        public bool contiene(iComparable c)
        { 
            foreach (iComparable e in this.elementos)
            {
                if (e.sosIgual(c))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
