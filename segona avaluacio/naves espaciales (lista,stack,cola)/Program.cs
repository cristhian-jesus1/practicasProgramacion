internal class Program
{
    static Stack<string>naves1 = new Stack<string>();
    static Queue<string>naves2 = new Queue<string>();
    static List<string> naves3 = new List<string>();
    static string[] nombresNaves =
        {
            "HALCONMILENARIO","CAZAESTELAR", "SUPERDESTRUCTOR","YWING","XWING"
        };
    private static void Main(string[] args)
    {
       
        int opcion = 0;

        do
        {
            System.Console.WriteLine();
            System.Console.WriteLine(" === SISTEMA DE FABRICACIÓN DE NAVES ESTELARES === ");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("1. Crear una nueva nave");
            System.Console.WriteLine("2. Cambiar nombre de una nave");
            System.Console.WriteLine("3. Listar todas las naves");
            System.Console.WriteLine("4. Listar naves por tipo");
            System.Console.WriteLine("5. Eliminar una nave");
            System.Console.WriteLine("6. Eliminar todas las naves");
            System.Console.WriteLine("7. Salir");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                        GenerarNaves();
                    break;
                case 2:
                        CambiarNombre(); 
                    break;
                case 3:
                        ListarTodasNaves();
                    break;
                case 4:
                        ListarPorTipo();
                    break;
                case 5:
                        EliminarNave();
                    break;
                case 6:
                        EliminarTodo();
                    break;
                case 7:
                        System.Console.WriteLine("Fin del programa!");
                    break;
                default:
                    break;
            }

        } while (opcion != 7);
    }

        static void GenerarNaves()
    {
        
        Random random = new Random();
        string nombreNave = nombresNaves[random.Next(nombresNaves.Length)];
        int numeroNave = random.Next(10,99);

        System.Console.WriteLine();

        string nombre = $"{nombreNave}-{numeroNave}";
        
        if (nombreNave == "HALCONMILENARIO" || nombreNave == "CAZAESTELAR") 
        {
            naves1.Push(nombre);
            System.Console.WriteLine($"✓ Nave creada: {nombre}  (Almacenada en PILA)");
        }
        else if (nombreNave == "SUPERDESTRUCTOR" || nombre == "YWING")
        {
            naves2.Enqueue(nombre);
            System.Console.WriteLine($"✓ Nave creada: {nombre}  (Almacenada en COLA)");
        }else if (nombreNave == "XWING")
        {
            naves3.Add(nombre);
            System.Console.WriteLine($"✓ Nave creada: {nombre}  (Almacenada en LISTA)");
        }
    }

        static void CambiarNombre()
    {
        System.Console.WriteLine("Que estructura desea modificar?");
        System.Console.WriteLine("1. Pila");
        System.Console.WriteLine("2. Cola");
        System.Console.WriteLine("3. Lista");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                if (naves1.Count == 0)
                {
                    System.Console.WriteLine("Pila vacia");
                }
                else 
                {
                    
                    string ultimaNave = naves1.Pop();
                    System.Console.WriteLine($"Nave actual {ultimaNave}");
                    System.Console.WriteLine($"Ingrese nuevo nombre : ");
                    string nuevoNombre = Console.ReadLine();
                    System.Console.WriteLine($"Ingrese nuevo numero : ");
                    int nuevoNumero = int.Parse(Console.ReadLine());

                    string nuevoNombreCompleto = $"{nuevoNombre}-{nuevoNumero}";
                    System.Console.WriteLine($"✓ Nave renombrada:{ultimaNave} → {nuevoNombreCompleto}");
                }
                break;
            case 2:
                if (naves2.Count == 0)
                {
                    System.Console.WriteLine("Cola vacia");
                }
                else
                {
                    string ultimaNave = naves2.Dequeue();
                    System.Console.WriteLine($"Nave actual {ultimaNave}");
                    System.Console.WriteLine($"Ingrese nuevo nombre : ");
                    string nuevoNombre = Console.ReadLine();
                    System.Console.WriteLine($"Ingrese nuevo numero : ");
                    int nuevoNumero = int.Parse(Console.ReadLine());

                    string nuevoNombreCompleto = $"{nuevoNombre}-{nuevoNumero}";
                    System.Console.WriteLine($"✓ Nave renombrada:{ultimaNave} → {nuevoNombreCompleto}");

                }
                break;
            case 3:
                if (naves2.Count == 0)
                {
                    System.Console.WriteLine("Lista vacia");
                }
                else
                {
                    for (int i = 0; i < naves3.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {naves3[i]}");
                    }
                    Console.Write("Seleccione la nave a modificar:(0)(1)(2) etc...");
                    int indice = int.Parse(Console.ReadLine()); 

                    System.Console.WriteLine($"Ingrese nuevo nombre : ");
                    string nuevoNombreLista = Console.ReadLine();
                    System.Console.WriteLine($"Ingrese nuevo numero : ");
                    int nuevoNumero = int.Parse(Console.ReadLine());

                    naves3[indice] = nuevoNombreLista;
                    
                    string nuevoNombreCompleto = $"{nuevoNombreLista}-{nuevoNumero}";
                    System.Console.WriteLine($"✓ Nave renombrada:{naves3} → {nuevoNombreCompleto}");

                }
                break;
            default:
            break;
        }


    }

        static void ListarTodasNaves(string titulo = "=== NAVES FABRICADAS ===")
    {
        System.Console.WriteLine(titulo);
        System.Console.WriteLine();
        System.Console.WriteLine("📦 PILA (LIFO - Last In, First Out):");

        int i = 0;
        System.Console.WriteLine();

        foreach (var nave in naves1)
        {
            System.Console.WriteLine($"[{i++}] {nave}");
        }

        System.Console.WriteLine();

        System.Console.WriteLine("⚙️ COLA (FIFO - First In, First Out):");

        i = 0;
        System.Console.WriteLine();

        foreach (var nave in naves2)
        {
            System.Console.WriteLine($"[{i++}] {nave}");
        }

        System.Console.WriteLine();

        System.Console.WriteLine("📋 LISTA (Acceso por índice):");

        i = 0;
        System.Console.WriteLine();
        foreach (var nave in naves3)
        {
            System.Console.WriteLine($"[{i++}] {nave}");
        }
    }

        static void ListarPorTipo()
        {
            System.Console.WriteLine("Ingrese el tipo de nave a listar");
            System.Console.WriteLine("1.Pila (HALCONMILENARIO, CAZAESTELAR)");
            System.Console.WriteLine("2.Cola (SUPERDESTRUCTOR, YWING)");
            System.Console.WriteLine("3.Lista (XWING)");
            int opcion = int.Parse(Console.ReadLine());
            int i = 0;
            switch (opcion)
            {
                case 1:
                    System.Console.WriteLine(" === NAVES EN PILA === ");
                    foreach (var naves in naves1)
                    {   
                        System.Console.WriteLine($"[{i++}] {naves}");
                    }
                    break;
                case 2:
                    i = 0;
                    System.Console.WriteLine(" === NAVES EN COLA === ");
                    foreach (var naves in naves2)
                    {  
                        System.Console.WriteLine($"[{i++}] {naves}");
                    }
                    break;
                case 3:
                    i = 0;
                    System.Console.WriteLine(" === NAVES EN LISTA === ");
                    foreach (var naves in naves3)
                    {
                        System.Console.WriteLine($"[{i++}] {naves}");
                    }
                break;
                default:
                    break;
            }




        }

        static void EliminarNave()
    {
        System.Console.WriteLine("Ingrese el tipo de nave a eliminar");
        System.Console.WriteLine("1.Pila (HALCONMILENARIO, CAZAESTELAR)");
        System.Console.WriteLine("2.Cola (SUPERDESTRUCTOR, YWING)");
        System.Console.WriteLine("3.Lista (XWING)");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                System.Console.WriteLine($"Nave {naves1.Pop()} eliminada!");
                break;
            case 2:
                System.Console.WriteLine($"Nave {naves2.Dequeue()} eliminada!");
                break;
            case 3:
                System.Console.WriteLine("Cual quieres eliminar?");
                int i = 0;
                foreach (var naves in naves3)
                {
                    System.Console.WriteLine($"[{i++}] {naves}");
                }
                int indice = int.Parse(Console.ReadLine());
                naves3.RemoveAt(indice);

                System.Console.WriteLine("Nave eliminada!");
                break;
            default:
                break;
        }
    }

        static void EliminarTodo()
    {
        System.Console.WriteLine("Quieres Eliminar todas las naves? (S/N)");
        string opcion = Console.ReadLine();

        if (opcion == "s" || opcion == "S")
        {
            naves1.Clear();
            naves2.Clear();
            naves3.Clear();
            System.Console.WriteLine("Todas las naves han sido eliminadas!");

        }else if (opcion == "n" || opcion == "N")
        {
            System.Console.WriteLine("Opcion Cancelada!");
        }
    }

 
    }