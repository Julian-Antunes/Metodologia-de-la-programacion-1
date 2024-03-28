using Metodologia_de_la_programacion_1;
using System.Text.RegularExpressions;


Console.WriteLine("Hello, World!");

static void llenar(iColeccionable c)
{
    Random random= new Random();
    for(int i=0; i<=19; i++)
    {
        var numero = new Numero(random.Next(100));
        c.agregar(numero);
        Console.WriteLine("Número "+ i + " es "+ numero+ " ahora la cola es: "+ c);
    }
}
void informar (iColeccionable c)
{
    Console.WriteLine("Cant= "+c.cuantos());
    Console.WriteLine("Min= "+c.minimo());
    Console.WriteLine("Max= "+c.maximo());
    Console.WriteLine("Ingrese un valor");
    iComparable elemento = new Numero(int.Parse(Console.ReadLine()));
    if (c.contiene(elemento))
        Console.WriteLine("El elemento leído está en la colección");
    else
        Console.WriteLine("El elemento leído no está en la colección");
}

Pila pila = new Pila();
Cola cola = new Cola();
ColeccionMultiple multiple = new ColeccionMultiple(pila,cola);
llenar(pila);
llenar(cola);
informar(pila);
informar(cola);
informar(multiple);


