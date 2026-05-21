internal class Program
{
    private static void Main(string[] args)
    {
        List<Tarea> tareas = new List<Tarea>();

        Tarea tarea = new Tarea();
        bool condicion = true;

        while (condicion)
        {
            System.Console.WriteLine("A. AGREGAR TAREA");
            System.Console.WriteLine("B. ELIMINAR TAREA");
            System.Console.WriteLine("C. MARCAR TAREA COMO COMPLEATADO");
            System.Console.WriteLine("D. LISTAR TAREA");
            System.Console.WriteLine("E. SALIR");

            System.Console.WriteLine("elige opcion");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "A": 
                    System.Console.WriteLine("texto tarea?");
                    tarea.tarea = Console.ReadLine();
                    tarea.completado = true;
                    tareas.Add(tarea);
                    System.Console.WriteLine("tarea agregada");
                    break;
                case "B":
                    System.Console.WriteLine("tarea a eliminar?");
                    int indice = int.Parse(Console.ReadLine());
                    tareas.RemoveAt(indice);
                    System.Console.WriteLine("Tarea eliminada");
                    break;
                case "C":
                    System.Console.WriteLine("Indice de la tarea a completar");
                    int indiceCompletada = int.Parse(Console.ReadLine());
                break;
                default:
                    break;
            }
        }


    }



    struct Tarea
    {
        public string tarea;
        public bool completado;
    }
}