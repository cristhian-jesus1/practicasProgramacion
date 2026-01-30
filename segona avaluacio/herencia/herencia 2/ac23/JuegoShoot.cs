public class JuegoShoot : Juego
{
    public int Pegi {get;set;}

    public JuegoShoot(string nombre, int yearPublicacion, string estudio, int pegi)
    : base( nombre,yearPublicacion,estudio)
    {
        Pegi = pegi;
        
    }

    public int horasNecesarias()
    {
        Random random = new Random();
        int totalHoras = random.Next(5,100);
        return totalHoras;
    }

       public override void ShowData()
    {
        base.ShowData();
        System.Console.WriteLine($"Pegi : {Pegi}, horas necesarias {horasNecesarias()}");
    }


}