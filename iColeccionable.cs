using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia_de_la_programacion_1
{ //ejerciccio 3
    public interface iColeccionable
    {
        int cuantos();
        iComparable minimo();
        iComparable maximo();
        void agregar(iComparable c);
        public bool contiene(iComparable c);
    }
}
