

public class Juego
{
     string Nombre {get;set;}
     int YearPublicacion {get;set;}
     string Estudio {get;set;}

    public Juego(string nombre,int yearPublicacion,string estudio)
    {
        Nombre =  nombre;
        YearPublicacion = yearPublicacion;
        Estudio = estudio;
    }

    public virtual void ShowData()
    {
        System.Console.WriteLine($"El nombre del juego es {Nombre}");
        System.Console.WriteLine($"El año de publicacion es {YearPublicacion}");
        System.Console.WriteLine($"El estudio es {Estudio}");
    }
}