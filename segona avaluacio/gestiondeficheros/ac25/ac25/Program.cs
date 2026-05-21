internal class Program
{
    static List<string> listaLocales = new List<string>(); 
    static string path = "mensaje.txt";

    private static void Main(string[] args)
    {
        int opcion = 0;

        do
        {
            System.Console.WriteLine("Menú");
            System.Console.WriteLine("1.Añadir mensaje al local");
            System.Console.WriteLine("2.Lista todos los usuarios");
            System.Console.WriteLine("3.Leer mensaje local (por usuario)");
            System.Console.WriteLine("4.Leer todos los mensajes locales (todos los usuarios)");
            System.Console.WriteLine("5.Pasar mensajes locales a archivos(mensajes.txt)");
            System.Console.WriteLine("6.Leer todos los mensajes de archivo");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:MensajeNuevo(); break;
                case 2:ListarPorUsuario();break;
                case 3:LeerPorUsuario();break;
                case 4:LeerTodosLocales();break;
                default:break;
            }
        } while (opcion!=7);
    }

   

    static void MensajeNuevo()
    {
       System.Console.WriteLine("usuario");
       string usuario = Console.ReadLine();
       System.Console.WriteLine("asunto");
       string asunto = Console.ReadLine();
       System.Console.WriteLine("mensaje");
       string mensaje = Console.ReadLine();

        listaLocales.Add($"{usuario};{asunto};{mensaje}");
        System.Console.WriteLine("mensaje guardado");

    }
    static void ListarPorUsuario()
    {
        foreach (string linea in listaLocales)
        {
            string[] partes = linea.Split(';');
            Console.WriteLine("- " + partes[0]);
        }
    }

    static void LeerPorUsuario()
    {
        {
            Console.Write("nombre usuario?");
            string buscar = Console.ReadLine();
            bool check = false;

            foreach (string linea in listaLocales)
            {
                string[] cadena = linea.Split(';');

                if (cadena[0] == buscar)
                {
                    Console.WriteLine($"[{cadena[1]}] -> {cadena[2]}");
                    check = true;
                }
            }
            if (!check) Console.WriteLine("Nsin mensajes");
        }
    }
    
    static void LeerTodosLocales()
    {
        foreach (string item in listaLocales)
        {
            System.Console.WriteLine(item);
        }
    }
    static void GuardarEnArchivo()
    {
        StreamWriter fichero = new StreamWriter(path, true);
        foreach (string  item in listaLocales)
        {
            fichero.WriteLine(item); 
        }
        listaLocales.Clear();

        Console.WriteLine("mensajes enviados!");

        fichero.Close();
    }

    static void LeerDeArchivo()
    {
        if (File.Exists(path))
        {
            string[] lineas = File.ReadAllLines(path);

            foreach (string item in lineas)
            {
                Console.WriteLine(item);
            }
        }
        else { Console.WriteLine("no existe el fichero"); }
    }


}