using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        // STACK

        // var cars = new Stack<string>();

        // cars.Push("SEAT");// add elementos
        // cars.Push("Audi");
        // cars.Push("VW");

        // foreach (var item in cars)
        // {
        //     System.Console.WriteLine(item);
        // }

        // cars.Pop(); // Borrar de la pila

        // foreach (var item in cars)
        // {
        //     System.Console.WriteLine(item);
        // }

        // System.Console.WriteLine("Peek de la pila : ", cars.Peek());// peek() retorna el ultim 

        // foreach (var item in cars)
        // {
        //     System.Console.WriteLine(item);
        // }
        // cars.Clear(); // borrar todos los elementos

        // System.Console.WriteLine("Contenido de la pila", cars.Count);


        // EJERCICIO 

        var nombres = new Stack<string>();

        nombres.Push("cris");
        nombres.Push("marc");
        nombres.Push("arman");
        nombres.Push("hamsa");
        nombres.Push("albert");

        foreach (var item in nombres)
        {
            System.Console.WriteLine(item);
        }

        System.Console.WriteLine(nombres.Peek()); // MOSTRAR ULTIMO ELEMENTO

        string ultimoElemento=nombres.Pop();// BORRAMOS EL ULTIMO ELEMENTO PERO LO GUARDAMOS EN UNA VARIABLE

        System.Console.WriteLine(nombres.Peek());// MOSTRAMOS EL ULTIMO ELEMENTO

        nombres.Push(ultimoElemento); //ADD EL ELEMENTO QUE BORRAMOS


    }
}