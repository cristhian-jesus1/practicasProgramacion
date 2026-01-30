internal class Program
{
    private static void Main(string[] args)
    {
        List<Juego> juegos  = new List<Juego>();

        juegos.Add(new JuegoShoot("modern warfare", 2020, "uni soft",18));
        juegos.Add(new Aventura("Beautiful", 2019, "brotherhood"));
        juegos.Add(new Simulacion("sim city", 1989, "maxis","ciudades"));

        juegos.Add(new JuegoShoot("modern warfare", 2020, "uni soft", 18));
        juegos.Add(new Aventura("Beautiful", 2019, "brotherhood"));
        juegos.Add(new Simulacion("sim city", 1989, "maxis", "ciudades"));

        foreach (var item in juegos)
        {
            item.ShowData();
        }


    }



}