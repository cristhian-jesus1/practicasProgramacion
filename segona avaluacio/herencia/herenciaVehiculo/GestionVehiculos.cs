public class Vehiculos
{
    string marca;
    string tipoVehiculo;
    int nivelCombustible;

    public Vehiculos(string marca, string tipoVehiculo, int nivelCombustible)
    {
        this.marca = marca;
        this.tipoVehiculo = tipoVehiculo;
        this.nivelCombustible = nivelCombustible;
    }

    public virtual void ShowData()
    {
        System.Console.WriteLine(marca);
        System.Console.WriteLine(tipoVehiculo);
        System.Console.WriteLine(nivelCombustible);
    }


}