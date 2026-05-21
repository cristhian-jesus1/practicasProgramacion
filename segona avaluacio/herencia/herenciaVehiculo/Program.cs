internal class Program
{
    private static void Main(string[] args)
    {
        List<Vehiculos> vehiculos = new List<Vehiculos>();

    
     

        vehiculos.Add(new VehiculoDeportivo("Mustang", "Deportivo", 90));
        vehiculos.Add(new VehiculoDeportivo("Ferrari", "Deportivo", 90));

        
        vehiculos.Add(new VehiculoSUV("audi","suv",80,"10 dias"));
        vehiculos.Add(new VehiculoSUV("mercedes","suv",90,"9 dias"));




        vehiculos.Add(new VehiculoSUVElectrico ("tesla","suvElectrico",90,"10 dias", 1000));
        vehiculos.Add(new VehiculoSUVElectrico("mercedes", "suvElectrico", 95, "12 dias", 1200));

        

        foreach (var item in vehiculos)
        {
            System.Console.WriteLine(item.ShowData);
        }



    }
}