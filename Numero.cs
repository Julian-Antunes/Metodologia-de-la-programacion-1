using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia_de_la_programacion_1
{//ejercicio 2
    public class Numero :iComparable
    {
        private int valor;
        public Numero(int valor) { this.valor = valor; }
        public int getValor() { return this.valor; }
        public bool sosIgual(iComparable c) { return this.valor == ((Numero)c).getValor(); }
        public bool sosMenor(iComparable c) { return this.valor < ((Numero)c).getValor(); }
        public bool sosMayor(iComparable c) { return this.valor > ((Numero)c).getValor(); }

        public override string ToString()
        {
            return this.valor.ToString();
        }
    }
}
