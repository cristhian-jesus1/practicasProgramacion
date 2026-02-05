
internal class Program
{
    
    private static void Main(string[] args)
    {
        List<Robot> robots = new List<Robot>();

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
                    // string nombreGenerado = Robot.GetNombre();
                    // string modeloGenerado = Robot.GetModeloRobot();
                    break;
                case 2:

                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5 :
                    break;
                case 6:
                    break;
                default:
                    break;
            }   
        } while (opcion!=6);
    }

    static void CrearRobot(List<Robot>robots)
    {
        System.Console.WriteLine($"que tipo de robot quieres generar");
        string modelo = Console.ReadLine();

        Robot nuevo;

        if (modelo == "R2D2")
        {
            nuevo = new R2D2(Robot.GetNombre(), modelo, 100);
        }
        else if (modelo == "C3PO")
        {
            nuevo = new C3PO(Robot.GetNombre(), modelo , 100);
        }else
        {
            nuevo = new BBB(Robot.GetNombre(), modelo ,100);
        }

        robots.Add(nuevo);
    }
    static void RestablecerRobot()
    {
        System.Console.WriteLine($"Posicion del robot");
        int posicion  = int.Parse(Console.ReadLine());


    }

    static void VerRobot()
    {
        
    }
    


}