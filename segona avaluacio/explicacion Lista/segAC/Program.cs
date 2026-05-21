internal class Program
{
    private static void Main(string[] args)
    {
        // Crea un juego simple que registre las puntuaciones de los jugadores en una lista. 
        // Luego, clasifica las puntuaciones de mayor a menor utilizando el método Sort() y muestra el ranking.
        List<Jugador> jugadores = new List<Jugador>();

        Jugador jugador = new Jugador();

        bool condicion = true;

        while (condicion)
        {
            System.Console.WriteLine("A. AGREGAR JUGADORES");
            System.Console.WriteLine("B. ORDENAR JUGADRES");
            System.Console.WriteLine("C. MOSTRAR RANKING");
            System.Console.WriteLine("E. SALIR");

            System.Console.WriteLine("elige opcion");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "A":
                    AgregarJugador(jugadores, jugador);
                    break;
                case "B":
                    // jugadores.Sort(); MENOR A MAYOR (A - Z)
                    jugadores.Reverse();    //  MAYOR A MENOR (Z - A) siempre despues de un SORT();
                    break;
                case "C":
                    foreach (var item in jugadores)
                    {
                        System.Console.WriteLine(item.nombre);
                        System.Console.WriteLine(item.puntuacion);
                    }
                    break;

                case "E":
                    System.Console.WriteLine("Fin programa");
                    break;
                default:
                    System.Console.WriteLine("OPCION NO VALIDA");
                    break;
            }
        }


        // CODIFICA UN PROGRAMA QUE GUARDE HASTA 5 NOMBRES EN UNA LISTA Y DEVUELVE EL RESULTADO ORDENADO

        var nombres = new List<string>();

        for (int i = 0; i < 5; i++)
        {
            System.Console.WriteLine("Nombre?");
            nombres.Add(Console.ReadLine());
        }

        nombres.Sort();
        
        foreach (var mostrar in nombres)
        {
            System.Console.WriteLine(mostrar);
        }
        

        



    }


    static void AgregarJugador(List<Jugador> jugadores, Jugador jugador)
    {
        bool salir = false;

        while (!salir)
        {
            System.Console.WriteLine("nombre jugador");
            jugador.nombre = Console.ReadLine();

            System.Console.WriteLine("puntos jugador");
            jugador.puntuacion = int.Parse(Console.ReadLine());

            jugadores.Add(jugador);

            System.Console.WriteLine("quieres salir?");
            salir = bool.Parse(Console.ReadLine());

        }
    }






    struct Jugador
    {
        public string nombre;
        public int puntuacion;
    }
}