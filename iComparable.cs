using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia_de_la_programacion_1
{//ejercicio 1
    public interface iComparable
    {
        bool sosIgual(iComparable c);
        bool sosMenor(iComparable c);
        bool sosMayor(iComparable c);
    }
}
