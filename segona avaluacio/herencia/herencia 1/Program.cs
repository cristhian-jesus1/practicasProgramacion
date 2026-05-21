public class Program
{
    private static void Main(string[] args)
    {
        
    }


}

class Proyecto
{
    string Nombre {get;set;}
    string Descripcion {get;set;}
    bool estadoActual {get;set;}
    int diasRestantes {get;set;}
    
    public List<Empleado> Empleados {get;set;}
    public List<Responsable> Responsables { get; set; }
    public List<Tarea> Tareas { get; set; }

    public Proyecto (string nombre, string descripcion, int salario, bool estadoActual,int diasRestantes)
    {
        this.Nombre = nombre;
        this.Descripcion = descripcion;
        this.estadoActual = estadoActual;
        this.diasRestantes = diasRestantes;

        Empleados = new List<Empleado>();
        Responsables = new List<Responsable>();
        Tareas = new List<Tarea>();
    }

    public void AgregarTarea()
    {
        System.Console.WriteLine($"{Nombre} {estadoActual}");
    }
}
class Tarea
{
    
}
class Persona
{
    string nombre {get;set;}
    int salario {get;set;}

    public Persona(string nombre, int salario)
    {
        this.nombre = nombre;
        this.salario = salario;
    }
}

// EN EL SHOWDATA PARA VER LA INFORMACION USAMOS ANTES VIRTUAL, PARA PODER SOBREESCRIBIR 
//  Y EN LA FUNCION QUE QUERAMOS MODIFICAR PONEMOS OVERRIDE 

class Empleado : Persona 
{
    string cargo { get; set; }
    public Empleado(string nombre,int salario, string cargo) : base(nombre,salario)
    {
        this.cargo = cargo;
    }
    public void Currar()
    {
        
    }
}

class Responsable : Persona
{
    string departamento {get;set;}
    public Responsable (string nombre,int salario, string cargo,string departamento): base(nombre, salario)
    {
        this.departamento = departamento;
    }
    public void Supervisar()
    {
        
    }
}
    