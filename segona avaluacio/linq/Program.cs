internal class Program
{
    private static void Main(string[] args)
    {
        List<Empleado> empleados = new List<Empleado>
        {
            new Empleado ("Laura", 28, "Marketing"),
            new Empleado ("Carlos", 35, "Ventas"),
            new Empleado ("Sofía", 23, "Marketing"),
            new Empleado ("Javier", 42, "Finanzas"),
            new Empleado ("Marta", 31, "Ventas")
        };
        

        // ● Obtener empleados menores de 20 años
        var menor20 =   from empleado in empleados
                        where empleado.Edad < 20
                        select empleado;
        foreach (var item in menor20)
        {
            System.Console.WriteLine(item);
        }
        // ● Haz una media de edad de todos los empleados
        var mediaEdad = (from empleado in empleados 
                        select empleado.Edad).Average();
        
        // ● Ordena la lista de empleados por departamento en orden ascendente
        var ordenAscendente =   from empleado in empleados
                                orderby empleado.Departamento 
                                select empleado;
        foreach (var item in ordenAscendente)
        {
            System.Console.WriteLine(item);
        }
                            
        // ● Selecciona el empleado de mayor edad
        var empleadoMayor = empleados.First(e => e.Edad == empleados.Max(e => e.Edad));
        // ● Selecciona el primer empleado que tenga más de 30 años
        var primerEmpleado = empleados.First(e=>e.Edad > 30);
        // ● Selecciona los 2 primeros empleados
        var dosPrimeros = empleados.Take(2);


    }
    public class Empleado
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Departamento { get; set; }
        public Empleado(string nombre, int edad, string
        departamento)
        {
            Nombre = nombre;
            Edad = edad;
            Departamento = departamento;
        }
    }


}