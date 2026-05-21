using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {

        // PRIMER EJEMPLO

        // TipoPersona persona1;

        // persona1.name = "albert";
        // persona1.age = 22;
        // persona1.surname = "rodriguez";

        // TipoPersona[] personas = new TipoPersona[2];

        // for (int i = 0; i < 2; i++)
        // {
        //     System.Console.WriteLine("name?");
        //     personas[i].name = Console.ReadLine();

        //     System.Console.WriteLine("surname?");
        //     personas[i].surname = Console.ReadLine();

        //     System.Console.WriteLine("age?");
        //     personas[i].age = int.Parse(Console.ReadLine());
        // }

        // foreach (var persona in personas)
        // {
        //     System.Console.WriteLine($"Dato alumno : nombre {persona.name}  apellido {persona.surname} edad {persona.age}");
        // }



        // 1 - 

        // Temperatura [,] ciudades = new Temperatura[2,2];

        // for (int i = 0; i < 2; i++)
        // {
        //     for (int j = 0; j < 2; j++)
        //     {
        //         System.Console.WriteLine("Temperatura maxima?");
        //         ciudades[i,j].temperaturaMaxima = int.Parse(Console.ReadLine());

        //         System.Console.WriteLine("Temperatura minima");
        //         ciudades[i,j].temperaturaMinima = int.Parse(Console.ReadLine());
        //     }
        // }
        // System.Console.WriteLine($"temperatura maxima bcn {ciudades[0,0]} y minima {ciudades[0,1]}");
        // System.Console.WriteLine($"temperatura maxima bcn {ciudades[1, 0]} y minima {ciudades[1, 1]}");

        // 2- 
        //   DEFINE UN STRUCT ** PRODUCTO** CON : NOMBRE, PRECIO Y STOCK
        // CREA UN ARRAY DE 5 PRODUCTOS Y MUESTRA CUAL TIENE UN PRECIO SUPERIOR A 10€ 

        // Prodcuto[] prodcutos = new Prodcuto[5];

        // for (int i = 0; i < 5; i++)
        // {
        //     System.Console.WriteLine("name?");
        //     prodcutos[i].name = Console.ReadLine();

        //     System.Console.WriteLine("price?");
        //     prodcutos[i].price = int.Parse(Console.ReadLine());

        //     System.Console.WriteLine("stock?");
        //     prodcutos[i].stock = int.Parse(Console.ReadLine());
        // }
        // foreach (var item in prodcutos)
        // {
        //     if (item.price > 10 )
        //     {
        //         System.Console.WriteLine($"{item.name}, {item.price} ,{item.stock}");
        //     }
        // }


        // 3- 

        // Videojuego[] juegos = new Videojuego[5];

        // for (int i = 0; i < 5; i++)
        // {
        //     System.Console.WriteLine("titulo");
        //     juegos[i].nombre = Console.ReadLine();

        //     System.Console.WriteLine("horas");
        //     juegos[i].horasJugadas = int.Parse(Console.ReadLine());
        // }

        // foreach (var juego in juegos)
        // {
        //     if (juego.horasJugadas > 20)
        //     {
        //         System.Console.WriteLine($"Juego : {juego.nombre}  horas : {juego.horasJugadas}");
        //     }
        // }

        // RESERVA HABITACION HOTEL

        // Hotel [] reservaHabitacion = new Hotel[2];

        // Hotel reserva = new Hotel ();
        
        // System.Console.WriteLine("nombre?");
        // reserva.name = Console.ReadLine();

        // System.Console.WriteLine("apellido?");
        // reser.surename = Console.ReadLine();

        // System.Console.WriteLine("numero habitacion?");
        // reserva.numRoom = int.Parse(Console.ReadLine());

        // System.Console.WriteLine("numero cama?");
        // reserva.numBed = int.Parse(Console.ReadLine());

        // for (int i = 0; i < 2; i++)
        // {
        //     System.Console.WriteLine("nombre?");
        //     reservaHabitacion[i].name = Console.ReadLine();

        //     System.Console.WriteLine("apellido?");
        //     reservaHabitacion[i].surename = Console.ReadLine();

        //     System.Console.WriteLine("numero habitacion?");
        //     reservaHabitacion[i].numRoom = int.Parse(Console.ReadLine());

        //     System.Console.WriteLine("numero cama?");
        //     reservaHabitacion[i].numBed = int.Parse(Console.ReadLine());
        // }

        // foreach (var reserva in reservaHabitacion)
        // {
        //     System.Console.WriteLine($"Reserva hecha para {reserva.name} {reserva.surename}");

        // }


        // for (int i = 0; i < clientes.GetLength(0); i++)
        // {
        //     for (int j = 0; j < clientes.GetLength(1); j++)
        //     {
        //         System.Console.WriteLine("Nombre?");
        //         clientes[i,j].name = Console.ReadLine();

        //         System.Console.WriteLine("Apellido?");
        //         clientes[i, j].surename = Console.ReadLine();

        //         System.Console.WriteLine("numeroHabitacion?");
        //         clientes[i, j].numRoom = int.Parse(Console.ReadLine());

        //     }
        // }
       

        // Hotel[,] clientes = new Hotel[3, 3];
        // Hotel cliente = new Hotel();

        // Hotel[,] hotel = new Hotel[3, 3];
        // int opcion =1;

        // do
        // {
        //     System.Console.WriteLine("Que opcion quieres hacer (1)(2)(3)(0)");
        //     System.Console.WriteLine("1. añadir solo un usuario");
        //     System.Console.WriteLine("2. añadir todos los usuarios");
        //     System.Console.WriteLine("3. ver todos los usuarios");
        //     System.Console.WriteLine("0. para salir");
        //     opcion = int.Parse(Console.ReadLine());
        //     switch (opcion)
        //     {

        //         case 1:
        //             System.Console.WriteLine("Nombre?");
        //             cliente.name = Console.ReadLine();

        //             System.Console.WriteLine("Apellido?");
        //             cliente.surename = Console.ReadLine();

        //             System.Console.WriteLine("Numero Habitacion?");
        //             cliente.numRoom = int.Parse(Console.ReadLine());

        //             System.Console.WriteLine("numero planta");
        //             int planta =int.Parse(Console.ReadLine());

        //             hotel[planta,cliente.numRoom] = cliente;
        //             break;
        //         case 2:

        //             for (int i = 0; i < hotel.GetLength(0); i++)
        //             {
        //                 for (int j = 0; j < hotel.GetLength(1); j++)
        //                 {
        //                     System.Console.WriteLine("Nombre?");
        //                     cliente.name = Console.ReadLine();

        //                     System.Console.WriteLine("Apellido?");
        //                     cliente.surename = Console.ReadLine();

        //                     System.Console.WriteLine("Numero Habitacion?");
        //                     cliente.numRoom = int.Parse(Console.ReadLine());

        //                     hotel[i,j] = cliente;
        //                 }
        //             }
        //             break;
        //         case 3:
        //             foreach (var ver in hotel)
        //             {
        //                 System.Console.WriteLine($"Nombre {ver.name}");
        //                 System.Console.WriteLine($"Nombre {ver.surename}");
        //                 System.Console.WriteLine($"Nombre {ver.numRoom}");
        //             }
        //             break;
        //         case 0:
        //             System.Console.WriteLine("saliendo del programa");
        //         break;
        //         default:
        //             System.Console.WriteLine("Opcion no valida");
        //             break;
        //     }
        // } while (opcion !=0);
        

        // foreach (var reserva in clientes)
        // {
        //     System.Console.WriteLine($"Reserva hecha para {reserva.name} {reserva.surename}");
        // }

        Datos_Imagen[] imagenes = new Datos_Imagen[10];
        int opcion = 1;
        do
        {
            System.Console.WriteLine("MENU");
            System.Console.WriteLine("Que quieres hacer");
            System.Console.WriteLine("1. Añadir todas las fichas");
            System.Console.WriteLine("2. Ver todas las fichas");
            System.Console.WriteLine("3. Buscar fichar por nombre");
            string nombre = Console.ReadLine();
            System.Console.WriteLine("4. Salir");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    for (int i = 0; i < 10; i++)
                    {
                        System.Console.WriteLine("Introduce el nombre de la ficha");
                        imagenes[i].nombre = Console.ReadLine();

                        System.Console.WriteLine("Introduce el ancho de la ficha");
                        imagenes[i].ancho = int.Parse(Console.ReadLine());

                        System.Console.WriteLine("Introduce el alto de la ficha");
                        imagenes[i].alto = int.Parse(Console.ReadLine());

                        System.Console.WriteLine("Introduce el tamaño de la ficha");
                        imagenes[i].size = float.Parse(Console.ReadLine());
                    }
                    break;
                case 2:
                    foreach (var verTodo in imagenes)
                    {
                        System.Console.WriteLine($"nombre {verTodo.nombre}");
                        System.Console.WriteLine($"ancho {verTodo.ancho}");
                        System.Console.WriteLine($"alto {verTodo.alto}");
                        System.Console.WriteLine($"tamaño {verTodo.size}");
                    }
                    break;
                case 3:
                    foreach (var ver in imagenes)
                    {
                        if (nombre == ver.nombre)
                        {
                            System.Console.WriteLine($"nombre {ver.nombre}");
                            System.Console.WriteLine($"ancho {ver.ancho}");
                            System.Console.WriteLine($"alto {ver.alto}");
                            System.Console.WriteLine($"tamaño {ver.size}");
                        }
                    }
                    break;
                case 4:
                    System.Console.WriteLine("Saliendo del programa");
                    break;
                default:
                    System.Console.WriteLine("Opcion no valida");
                    break;
            }
        } while (opcion != 4);

    }

    // PRIMER EJEMPLO STRUC

    // struct TipoPersona
    // {
    //     public string name;
    //     public string surname;
    //     public int age;

    // }

    // EJERCICIO

    // 1- GUARDAR LAS TEMPERATURS MAXIMAS Y MINIMAS DE MADRID Y BARCELONA EN UNA SEMANA 
    // struct Temperatura
    // {
    //     public string ciudad;
    //     public int temperaturaMaxima;
    //     public int temperaturaMinima;
    // }


    // SEGUNDO EJERCICIO STRUC

    // 2-  DEFINE UN STRUCT ** PRODUCTO** CON : NOMBRE, PRECIO Y STOCK
    // CREA UN ARRAY DE 5 PRODUCTOS Y MUESTRA CUAL TIENE UN PRECIO SUPERIOR A 10€ 


    // struct Prodcuto 
    // {
    //     public string name;
    //     public int price;
    //     public int stock;
    // }

    // 3- CODIFICA UN STRUCT ** VIDEOJUEGO** CON TITULO Y HORAS JGUADAS
    // PERMITE INTRODUCIR 5 JUEGOS Y MUESTRA ELQ UE TIENE MAS DE 20 HORAS JUGADAS 
    // struct Videojuego
    // {
    //     public string nombre;
    //     public int horasJugadas;
    // }

// Define un struct DiaTemperatura con mínima y máxima.
// Crea un array para 7 días y muestra el día con temperaturaMáxima > 20 y mínima < 10.


// Crea un struct Contacto con nombre y teléfono.
// Permite almacenar 10 contactos y mostrar solo los que se apellidan lópez



// Define un struct Alumno con nombre y nota.
// Introduce 5 alumnos y calcula la nota media.


// Define un struct Pelicula con título, año y duración.
// Guarda 8 películas y muestra todas las que duren más de 120 minutos.



// ESTRUCTS AMB CONSTRUCTOR 

    // struct Hotel
    // {
    //     public string name;
    //     public string surename;
    //     public int numRoom;

    // }

struct Datos_Imagen
    {
        public string nombre;
        public int ancho;
        public int  alto;
        public float size;

    }


}