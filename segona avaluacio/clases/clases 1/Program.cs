using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        Persona persona1 = new Persona("pepe",30,"pepe@gmail.com");
        Producto producto1 = new Producto("0001","mochila",1500, 10);
        System.Console.WriteLine("mostrar datos");
        // persona1.ShowData();
        producto1.ShowProduct();
        producto1.AumentarStock(4);
        producto1.DisminuirStock(2);
        System.Console.WriteLine(producto1.CalcularTotal());


    }
}

public class Persona
{

    // VARIABLES INTERNAS 
    private string nombre;
    private int edad;
    private string email;


    // CONSTRUCTOR

    public Persona(string nombre, int edad, string email)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.email = email;

    }

    // METODO 

    public void ShowData()
    {
        System.Console.WriteLine($" nombre {nombre}, edad {edad}, email {email}");
    }


}

public class Producto
{
    private string codigoProducto;
    private string nombre;
    private double precio;
    private int stock;


    public Producto(string codigoProducto, string nombre, double precio, int stock)
    {
        this.codigoProducto = codigoProducto;
        this.nombre = nombre;
        this.precio = precio;
        this.stock = stock;
    }

    public string GetCodigoProdcuto()
    {
        return codigoProducto;
    }

    public void SetCodigoProducto(string value)
    {
        codigoProducto = value;
    }

    public  string GetNombre()
    {
        return nombre;
    }
    public void SetNombre(string value)
    {
        nombre = value;
    }

    public double GetPrecio()
    {
        return precio;
    }

    public void SetPrecio(int value)
    {
        precio = value;
    }
    public double GetStock()
    {
        return stock;
    }

    public void SetStock(int value)
    {
        stock = value;
    }

    public void AumentarStock(int cantidad)
    {
        stock+= cantidad;
    }

    public void DisminuirStock(int cantidad)
    {
        stock -= cantidad;
    }
    public double CalcularTotal()
    {
        double calcularTotal;
        calcularTotal = precio * stock;
        return calcularTotal;
    }


    public void ShowProduct()
    {
        System.Console.WriteLine($"{codigoProducto}, nombre {nombre}, precio {precio}, stock {stock}");
    }
}