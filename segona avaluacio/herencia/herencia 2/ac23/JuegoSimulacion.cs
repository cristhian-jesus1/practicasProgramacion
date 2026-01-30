public class Simulacion : Juego
{
    string Ambito {get;set;}
    
    public Simulacion(string nombre, int yearPublicacion, string estudio, string ambito)
     : base(nombre, yearPublicacion, estudio)
    {
        Ambito = ambito;
    }

    public int TurnosNecesarios()
    {
        Random random = new Random();
        int totalTurnos = random.Next(5, 100);
        return totalTurnos;
    }
    public override void ShowData()
    {
        base.ShowData();
        System.Console.WriteLine($"Ambito {Ambito} , Turnos {TurnosNecesarios()}");
    }
}