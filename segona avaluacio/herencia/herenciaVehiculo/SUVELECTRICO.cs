

public class VehiculoSUVElectrico : VehiculoSUV
{
    int capacidadCarga;

    public VehiculoSUVElectrico(string marca, string tipoVehiculo, int nivelCombustible, string ultimaRevision, int capacidadCarga)
    : base (marca, tipoVehiculo, nivelCombustible, ultimaRevision)
    {
        this.capacidadCarga = capacidadCarga;
    }
    public int CapacidadCarga()
    {
        return capacidadCarga;
    }
    public int RutasRecorridas()
    {
        int rutasRecorridas = 100;
        return rutasRecorridas;
    }
}