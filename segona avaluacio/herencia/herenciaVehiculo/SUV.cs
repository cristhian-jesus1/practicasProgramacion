public class VehiculoSUV : Vehiculos
{
    string ultimaRevision;

    public VehiculoSUV(string marca, string tipoVehiculo, int nivelCombustible, string ultimaRevision)
    : base(marca, tipoVehiculo, nivelCombustible)
    {
        this.ultimaRevision = ultimaRevision;
    }
    public string UltimaRevision()
    {
        return ultimaRevision;
    }
        
    public virtual int TerrenosSuperados()
    {
        int terrenoSuperados = 10;
       return terrenoSuperados;
    }

}