internal class Program
{
    private static void Main(string[] args)
    {
        ApiGenerica<Cliente> apiCliente = new ApiGenerica<Cliente>();
        apiCliente.AgregarElemento(new Cliente{nombre= "Marc",edad=40});
        apiCliente.AgregarElemento(new Cliente { nombre = "Albert", edad = 40 });
        apiCliente.AgregarElemento(new Cliente { nombre = "Judit", edad = 40 });
        apiCliente.EliminarElemento(1);
        ApiGenerica<Productos> apiProductos = new ApiGenerica<Productos>();
        apiProductos.AgregarElemento(new Productos { nombreProducto = "Mochila", precio = 40 });
        apiProductos.AgregarElemento(new Productos { nombreProducto = "Laptop", precio = 100 });
        apiProductos.AgregarElemento(new Productos { nombreProducto = "Mesa", precio = 40 });
        apiProductos.EliminarElemento(0);
        ApiGenerica<Empleado> apiEmpleado = new ApiGenerica<Empleado>();
        apiEmpleado.AgregarElemento(new Empleado {nombreEmpleado= "Marc1", edad=40, id=10});
        apiEmpleado.AgregarElemento(new Empleado { nombreEmpleado = "Albert1", edad = 40, id = 9 });
        apiEmpleado.AgregarElemento(new Empleado { nombreEmpleado = "Judit1", edad = 40, id = 8 });
        apiEmpleado.EliminarElemento(2);
        
        System.Console.WriteLine("Cliente");
        apiCliente.MostrarElementos();
        System.Console.WriteLine("Productos");
        apiProductos.MostrarElementos();
        System.Console.WriteLine("Empleado");
        apiEmpleado.MostrarElementos();
    }
    public class Cliente
    {
        public required string nombre { get; set; }
        public int edad { get; set; }
        public override string ToString()
        {
            return $"nombre: {nombre} edad: {edad}";
        }

        // public Cliente(string nombre, int edad)
        // {
        //     this.nombre = nombre;
        //     this.edad = edad;
        // }
    }
    public class Productos
    {
        public required string nombreProducto { get; set; }
        public int precio { get; set; }
        public override string ToString()
        {
            return $"Nombre: {nombreProducto} precio: {precio}";
        }

        // public Productos(string nombreProducto, int precio)
        // {
        //     this.nombreProducto = nombreProducto;
        //     this.precio = precio;
        // }
    }
    public class Empleado
    {
        public required string nombreEmpleado { get; set; }
        public int edad { get; set; }
        public int id { get; set; }
        public override string ToString()
        {
            return $"nombre: {nombreEmpleado} edad: {edad} id: {id}";
        }

        // public Empleado(string nombreEmpleado, int edad, int id)
        // {
        //     this.nombreEmpleado = nombreEmpleado;
        //     this.edad = edad;
        //     this.id = id;
        // }
    }

    public class ApiGenerica<T>
    {
        private List<T> elementos;

        public ApiGenerica()
        {
            elementos = new List<T>();
        }

        public void AgregarElemento(T elemento)
        {
            elementos.Add(elemento);
        }
        public void EliminarElemento(int indice)
        {
            if (indice >= 0 && indice < elementos.Count)
            {
                elementos.RemoveAt(indice);
            }
            else
            {
                Console.WriteLine("Indice fuera de rango");
            }
        }

        public T ObtenerElemento(int indice)
        {
            if (indice >= 0 && indice < elementos.Count)
            {
                return elementos[indice];
            }
            else
            {
                Console.WriteLine("Error! fuera de rango, devuelvo el primer elemento de la lista");
                return elementos[0];
            }
        }

        public void MostrarElementos()
        {
            Console.WriteLine("Elementos almacenados:");
            foreach (var elemento in elementos)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}
