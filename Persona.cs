using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia_de_la_programacion_1
{
    public class Persona :iComparable
    {
        private string nombre;
        private int dni;
        public Persona(string n, int d) { this.nombre = n; this.dni = d; }
        
        public string getNombre() { return this.nombre; }
        public int getDNI() { return this.dni; }

        public bool sosIgual(iComparable c) { return this.dni == ((Numero)c).getValor(); }
        public bool sosMenor(iComparable c) { return this.dni < ((Numero)c).getValor(); }
        public bool sosMayor(iComparable c) { return this.dni > ((Numero)c).getValor(); }
    }
}
