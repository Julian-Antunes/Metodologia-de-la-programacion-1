using Metodologia_de_la_programacion_1;
using System.Text.RegularExpressions;
using System.Xml.Schema;

Console.WriteLine("Hello, World!");

static void llenar(iColeccionable c)
{
    Random random= new Random();
    for(int i=0; i<=19; i++)
    {
        var numero = new Numero(random.Next(100));
        c.agregar(numero);

    }
}
static void llenarPersonas(iColeccionable c)
{
    for (int i = 0; i <= 19; i++)
    {
        Persona comparable = new Persona(nombre_al_azar(), dni_al_azar());
        c.agregar(comparable);
    }
}
static int dni_al_azar()
{
    Random rnd = new Random();
    return rnd.Next(10000000, 99999999);
}
static string nombre_al_azar()
{
    string[] nombres = { "Juan", "María", "Carlos", "Ana", "Pedro", "Laura", "Diego", "Sofía", "Luis", "Valeria",
                             "Miguel", "Lucía", "Alejandro", "Paula", "Javier", "Elena", "José", "Clara", "Fernando", "Carmen",
                             "Ricardo", "Isabel", "Pablo", "Ailen", "Alberto", "Silvia", "Antonio", "Marina", "Roberto", "Natalia",
                             "Manuel", "Andrea", "Francisco", "Eva", "David", "Beatriz", "Jorge", "Patricia", "Ángel", "Cristina",
                             "Daniel", "Martina", "Mario", "Lucía", "Joaquín", "Olivia", "Jesús", "Carolina" };
    Random rnd = new Random();
    return nombres[rnd.Next(nombres.Length)];
}
void informar (iColeccionable c)
{
    var minimo = c.minimo();
    var maximo = c.maximo();
    
    Console.WriteLine("Cantidad= "+c.cuantos());
    if (minimo is Persona) Console.WriteLine("Numero Minimo= " + ((Persona)minimo).getDNI());
    else Console.WriteLine("Numero Minimo= " + minimo);
    if (maximo is Persona) Console.WriteLine("Numero Maximo= " + ((Persona)maximo).getDNI());
    else Console.WriteLine("Numero maximo= " + maximo);

    Console.WriteLine("Ingrese un valor a consultar");
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
llenarPersonas(cola);
informar(pila);
informar(cola);
informar(multiple);


