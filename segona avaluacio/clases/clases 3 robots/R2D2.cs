class R2D2 : Robot
{
    int Energia;

    public R2D2(string nombre, string modelo, int energia) : base (nombre,modelo)
    {
        Energia = energia;
    }

    public void ActivarRadar()
    {
        System.Console.WriteLine("R2D2 activa radar");
    }

    public void Rodar()
    {
        System.Console.WriteLine("R2D2 activa rodar");
    }
}