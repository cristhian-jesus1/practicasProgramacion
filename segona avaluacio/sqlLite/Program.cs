using System.Data.SQLite;
internal class Program
{
    static void Main(string[] args)
    {
        bool salir = true;

        string connectionBBDD = "Data Source = personas.db";
        SQLiteConnection connection = new SQLiteConnection(connectionBBDD);

        connection.Open();

        // creacion tabla 

        string creacionTabla = "CREATE TABLE IF NOT EXISTS Personas(Id INTERGER PRIMARY KEY, Nombre VARCHAR, Edad INT)";
        SQLiteCommand tablaCommand = new SQLiteCommand(creacionTabla,connection);
        tablaCommand.ExecuteNonQuery();

        while (salir)
        {
            System.Console.WriteLine("MENÚ");
            System.Console.WriteLine("1. Crear Registro(persona)");
            System.Console.WriteLine("2. Listar Registro");
            System.Console.WriteLine("3. Buscar Registro");
            System.Console.WriteLine("4. UpDate Registro");
            System.Console.WriteLine("5. Delete Registro");
            System.Console.WriteLine("6. Salir");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1": CreacionRegistro(connection);break;
                case "2": ListarRegistro(connection);break;
                case "3": BuscarRegistro(connection);break;
                case "4": UpdateRegistro(connection);break;
                case "5": DeleteRegistro(connection);break;
                case "6": salir = false; break;
                default:break;
            }
        }

        connection.Close();
    }


    static void CreacionRegistro(SQLiteConnection connection)
    {
        System.Console.WriteLine("Nombre?");
        string nombre = Console.ReadLine();
        System.Console.WriteLine("Edad?");
        int edad = Convert.ToInt32(Console.ReadLine());

        string insertQuery = "INSERT INTO Personas(nombre,edad) VALUES (@nombre,@edad)";
        SQLiteCommand insertCommand = new SQLiteCommand(insertQuery,connection);

        insertCommand.Parameters.AddWithValue("@nombre",nombre);
        insertCommand.Parameters.AddWithValue("@edad", edad);

        insertCommand.ExecuteNonQuery();

    }

    static void ListarRegistro(SQLiteConnection connection)
    {
        string selectRegistro = "SELECT * FROM Personas";

        SQLiteCommand selectCommand = new SQLiteCommand(selectRegistro,connection);
        SQLiteDataReader result = selectCommand.ExecuteReader();

        while (result.Read())
        {
                System.Console.WriteLine("Id: {0}, Nombre: {1}, Edad: {2}",result["id"],result["Nombre"],result["Edad"]);
        }

    }
    static void BuscarRegistro(SQLiteConnection connection)
    {
        System.Console.WriteLine("nombre a buscar");
        string buscarNombre = Console.ReadLine();

        string buscarQuery = "SELECT * FROM Personas WHERE nombre=@Nombre";

        SQLiteCommand buscarCommand = new SQLiteCommand(buscarQuery,connection);

        SQLiteDataReader resultBuscar = buscarCommand.ExecuteReader();
        while (resultBuscar.Read())
        {
            System.Console.WriteLine("Id: {0}, Nombre: {1}, Edad: {2}", resultBuscar["id"], resultBuscar["Nombre"], 
            resultBuscar["Edad"]);
        }

    }
    static void UpdateRegistro(SQLiteConnection connection)
    {
        System.Console.WriteLine("nombre a cambiar?");
        string nombreAntiguo = Console.ReadLine();

        string updateQuery = "UPDATE Personas SET EDAD = @edad WHERE Nombre = @nombre";

        SQLiteCommand updateCommand = new SQLiteCommand(updateQuery,connection);

        updateCommand.Parameters.AddWithValue("@nombre","nombre");
        updateCommand.Parameters.AddWithValue("@edad","Edad");

        updateCommand.ExecuteNonQuery();


    }
    static void DeleteRegistro(SQLiteConnection connection)
    {
        System.Console.WriteLine("nombre a borrar?");
        string borrarPersona = Console.ReadLine();

        string deleteQuery = "DELETE FROM Personas WHERE Nombre = @Nombre";

        SQLiteCommand deleteCommand = new SQLiteCommand(deleteQuery,connection);

        deleteCommand.Parameters.AddWithValue("@nombre","nombre");
        
        deleteCommand.ExecuteNonQuery();
    }


}