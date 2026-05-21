
internal class Program
{
    static List<Robot> robots = new List<Robot>();
    private static void Main(string[] args)
    {

        int opcion = 0;
        do
        {

            System.Console.WriteLine("MENU");
            System.Console.WriteLine("1.Generar Robot");
            System.Console.WriteLine("2.Restablecer Robot (Nuevo Nombre)");
            System.Console.WriteLine("3.Ver robot guardado (posicion?)");
            System.Console.WriteLine("4.Eliminar robot (posicion?)");
            System.Console.WriteLine("5.Ver todos los robots");
            System.Console.WriteLine("6.Salir");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    CrearRobot();
                    break;
                case 2:

                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5 :
                    VerTodosRobots();
                    break;
                case 6:
                    break;
                default:
                    break;
            }   
        } while (opcion!=6);
    }

    public static void CrearRobot()
    {
        
        string nombre = GetNombre();
        string modelo = GetModeloRobot();

        Robot nuevoRobot;

        switch (modelo)
        {
            case "R2D2":
                nuevoRobot = new R2D2(nombre,modelo,100);
                break;
            case "C3PO":
                nuevoRobot = new C3PO(nombre,modelo,"español");
                break;
            case "BBB":
                nuevoRobot = new BBB(nombre,modelo,50);
                break;
            default:
                nuevoRobot = new Robot(nombre,modelo);
                break;
        }

        robots.Add(nuevoRobot);

        System.Console.WriteLine($"Robot creado {nombre}-{modelo}");
    
    }
    public static string GetNombre()
    {

        Random rnd = new();
        string[] letras = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M"];

        string letra1 = letras[rnd.Next(letras.Length)];
        string letra2 = letras[rnd.Next(letras.Length)];
        string letra3 = letras[rnd.Next(letras.Length)];
        string nombre = letra1 + letra2 + letra3;

        int numero = rnd.Next(100, 999);

        string nombreCompleto = $"{nombre}-{numero}";

        return nombreCompleto;


    }

    public static string GetModeloRobot()
    {
        Random random = new Random();
        string[] modelo = ["R2D2", "C3PO", "BBB"];

        string modeloRobot = modelo[random.Next(modelo.Length)];
        return modeloRobot;
    }




    static void RestablecerRobot()
    {
        System.Console.WriteLine($"Posicion del robot");
        int posicion  = int.Parse(Console.ReadLine());

        if (posicion == )
        {
            
        }

    }

    static void VerTodosRobots()
    {
        foreach (var verRobot in robots)
        {
            System.Console.WriteLine(verRobot);
        }
    }
    
    static void VerUnRobot()
    {
        System.Console.WriteLine($"Dime la posicion del robot que quieres ver?");
        int posicion = int.Parse(Console.ReadLine());

        if (posicion >= 0 && posicion < robots.Count)
        {
            Robot r = robots[posicion];
            System.Console.WriteLine($"Nombre : {r.nombre}");
        }
    }


}