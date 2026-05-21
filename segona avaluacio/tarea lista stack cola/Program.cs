internal class Program
{
    private static void Main(string[] args)
    {
        // 1 Codifica una lista de nombres


        // 1.Crear una lista con 4 nombres
        // 2.Mostrar todos los nombres
        // 3.Agregar un nuevo nombre a la lista
        // 4.Mostrar la lista actualizada
        // 5.Eliminar un nombre
        // 6.Mostrar los nombres finales
        // 7.Contar cuántos nombres hay en total

        // List<string> nombres = new List<string>();

        // nombres.Add("Juan");
        // nombres.Add("Maria");
        // nombres.Add("Carlos");
        // nombres.Add("Ana");

        // // System.Console.WriteLine("nombres");

        // for (int i = 0; i < nombres.Count; i++)
        // {
        //     System.Console.WriteLine($"{nombres[i]}");
        // }

        // System.Console.WriteLine("añado otro nombre");
        // nombres.Add("PEDRO");               // AÑADIR NOMBRE A LA LISTA

        // System.Console.WriteLine("Lista nombres");

        // foreach (var item in nombres)
        // {
        //     System.Console.WriteLine($"{item}"); // MOSTRAR LISTA
        // }

        // System.Console.WriteLine("Eliminar Maria");

        // nombres.Remove("Maria");        // Eliminar Maria

        // System.Console.WriteLine("Borrar toda la lista");

        // nombres.Clear();        // BORRAR TODA LA LISTA

        // System.Console.WriteLine("Lista nombres");

        // for (int i = 0; i < nombres.Count; i++)
        // {
        //     System.Console.WriteLine($"{nombres[i]}");  // MOSTRAR LISTA
        // }

        // System.Console.WriteLine($"Total nombres en la lista {nombres.Count}");  // cCUENTA CUANTOS NOMBRES HAY EN LA LISTA







        // STACK 


        // 2 Codifica una pila de números


        // 1.Agregar 5 números a la pila(10, 20, 30, 40, 50)
        // 2.Mostrar cuántos números hay en la pila
        // 3.Ver el primer número sin sacarlo(Peek)
        // 4.Sacar todos los números uno por uno mostrando cada uno
        // 5.Mostrar que la pila está vacía al final


        //     Stack<int> numeros = new Stack<int>();

        //     System.Console.WriteLine("añadimos numeros");

        //     numeros.Push(10);
        //     numeros.Push(20);
        //     numeros.Push(30);
        //     numeros.Push(40);
        //     numeros.Push(50);

        //     System.Console.WriteLine($"numeros en la pila {numeros.Count}");

        //     System.Console.WriteLine($"primer numero en el peek {numeros.Peek()}"); // 50   
            
        //     System.Console.WriteLine(numeros.Pop());
        //     System.Console.WriteLine(numeros.Peek());
        //    System.Console.WriteLine($"La pila tiene {numeros.Count} elementos");

        //    System.Console.WriteLine("desapilando!");

        //    while (numeros.Count < 5  )
        //    {
        //     int numero = numeros.Pop();  // pop para borrar
        //     // System.Console.WriteLine($"Número desapilado {numero} (quedan {numeros.Count})");
        //     System.Console.WriteLine(numeros.Peek());
        //    }

        //    System.Console.WriteLine($"Total en la pila {numeros.Count}");

           

        // COLAA


         // 3 Codifica una cola de personas


        // 1.Agregar 4 personas a la cola
        // 2.Mostrar el total de personas esperando
        // 3.Ver quién es el siguiente sin sacarlo(Peek)
        // 4.Atender personas una por una(Dequeue)
        // 5.Mostrar que la cola está vacía al final


        Queue<string> personas = new Queue<string>();

        System.Console.WriteLine("agregar personas a la cola");

        personas.Enqueue("Marc");
        System.Console.WriteLine("Marc entra a la cola");
        personas.Enqueue("Albert");
        System.Console.WriteLine("Albert entra a la cola");
        personas.Enqueue("Pablo");
        System.Console.WriteLine("Pablo entra a la cola");
        personas.Enqueue("Judit");
        System.Console.WriteLine("Judit entra a la cola");


        System.Console.WriteLine("Mostrar personas esperando");

        System.Console.WriteLine($"Hay {personas.Count} personas esperando"); // 4

        System.Console.WriteLine($"El siguiente en la cola es {personas.Peek()}"); // MARC 

        System.Console.WriteLine($"{personas.Dequeue()}");
        System.Console.WriteLine($"{personas.Peek()}");
        while (personas.Count > 0)
        {
            string persona = personas.Dequeue();       // PARA BORRAR NOMBRES
            System.Console.WriteLine($"nombre {persona} quedan en la cola {personas.Count}");
        }


        System.Console.WriteLine($"Cola vacia : {personas.Count}  personas en la cola");






    }


}