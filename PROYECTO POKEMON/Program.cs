internal class Program
{
    private static void Main(string[] args)
    {

        System.Console.WriteLine("--- BATALLA POKEMON ---");
        System.Console.WriteLine();

        // MATRIZ
        Pokemon [,] equipos = new Pokemon[2,3];

        // //OBJETO RANDOM
        Random random = new Random();

        // EQUIPO POKEMON 1
        equipos[0, 0] = new Pokemon {nombre="Charmander", tipoElemental="Fuego",vida=100, vidaMaxima=100, ataque=40, defensa=20, estaVivo=true};
        equipos[0, 1] = new Pokemon { nombre = "Bulbasur", tipoElemental = "Planta", vida = 110, vidaMaxima = 110, ataque = 35, defensa = 25, estaVivo = true };
        equipos[0, 2] = new Pokemon { nombre = "Squirtle", tipoElemental = "Agua", vida = 105, vidaMaxima = 105, ataque = 38, defensa = 22, estaVivo = true };

        // EQUIPO POKEMON 2
        equipos[1, 0] = new Pokemon { nombre = "Pikachu", tipoElemental = "Electrico", vida = 95, vidaMaxima = 95, ataque = 42, defensa = 18, estaVivo = true };
        equipos[1, 1] = new Pokemon { nombre = "Pidgey", tipoElemental = "Roca", vida = 120, vidaMaxima = 120, ataque = 30, defensa = 30, estaVivo = true };
        equipos[1, 2] = new Pokemon { nombre = "Geodude", tipoElemental = "Volador", vida = 90, vidaMaxima = 90, ataque = 36, defensa = 20, estaVivo = true };

        // EQUIPO JUGADOR
        System.Console.WriteLine();
        System.Console.WriteLine("--- EQUIPO JUGADOR ---");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Equipo : {0} Nombre : {equipos[0,i].nombre} Tipo : {equipos[0,i].tipoElemental}  Vida : {equipos[0,i].vida} VidaMaxima : {equipos[0,i].vidaMaxima} Ataque : {equipos[0,i].ataque} Defensa: {equipos[0,i].defensa}");
        }
        System.Console.WriteLine();


        // EQUIPO CPU 
        System.Console.WriteLine("--- EQUIPO CPU ---");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Equipo : {1} Nombre : {equipos[1, i].nombre} Tipo : {equipos[1, i].tipoElemental}  Vida : {equipos[1, i].vida} VidaMaxima : {equipos[1, i].vidaMaxima} Ataque : {equipos[1, i].ataque} Defensa: {equipos[1, i].defensa}");
        }

        System.Console.WriteLine();


        // PERSONALZAR POKEMON


        Console.WriteLine("¿Deseas personalizar tu primer Pokémon? (s/n): "); 
        string respuesta = Console.ReadLine();

        if (respuesta == "s" || respuesta == "S")
        {
            Console.Write("Nombre: "); 
            equipos[0, 0].nombre = Console.ReadLine();

            Console.Write("Vida (50-150): ");
            equipos[0, 0].vida = Convert.ToInt32(Console.ReadLine());
            equipos[0, 0].vidaMaxima = equipos[0, 0].vida;

            Console.Write("Ataque (20-50): ");
            equipos[0, 0].ataque = Convert.ToInt32(Console.ReadLine());

            Console.Write("Defensa (10-35): ");
            equipos[0, 0].defensa = Convert.ToInt32(Console.ReadLine());
        }
        int turno = 1; bool combateActivo = true;

        while (combateActivo)
        {
            Console.WriteLine($"\n--- TURNO {turno} ---");

            // 1. Buscar Pokémon activo del jugador (primer estaVivo = true en fila 0)
            int pokemonJugador = -1;
            for (int i = 0; i < 3; i++)
            {
                if (equipos[0, i].estaVivo)
                {
                    pokemonJugador = i;
                    break;
                }
            }
            // 2. Buscar Pokémon activo de la CPU (primer estaVivo = true en fila 1)
            int pokemonCPU = -1;
            for (int j = 0; j < 3; j++)
            {
                if (equipos[1, j].estaVivo)
                {
                    pokemonCPU = j;
                    break;
                }
            }
        
            // 3. Mostrar estado de ambos Pokémon
            Console.WriteLine($"[JUGADOR] {equipos[0, pokemonJugador].nombre} ({equipos[0, pokemonJugador].tipoElemental})");
            Console.WriteLine($"HP: {equipos[0, pokemonJugador].vida}/{equipos[0, pokemonJugador].vidaMaxima}");
            Console.WriteLine($"ATQ: {equipos[0, pokemonJugador].ataque} | DEF: {equipos[0, pokemonJugador].defensa}");


            System.Console.WriteLine("");

            System.Console.WriteLine("             VS            ");

            System.Console.WriteLine("");


            Console.WriteLine($"[CPU] {equipos[1, pokemonCPU].nombre} ({equipos[1, pokemonCPU].tipoElemental})");
            System.Console.WriteLine($"HP: {equipos[1, pokemonCPU].vida}/{equipos[1, pokemonCPU].vidaMaxima}");
            System.Console.WriteLine($"ATQ: {equipos[1, pokemonCPU].ataque} | DEF: {equipos[1, pokemonCPU].defensa}");

            // 4. Preguntar al jugador si quiere continuar
                Console.Write("¿Atacar? (s/n): ");
            string accion = Console.ReadLine();

            if (accion == "n" || accion == "N")
            {
                Console.WriteLine("¡Te has rendido! La CPU gana.");
                combateActivo = false;
                break; // Salir del bucle while
            }

            // 5. ATAQUE DEL JUGADOR

            // - Calcular daño
            int damagePlayer = equipos[0, pokemonJugador].ataque - equipos[1, pokemonCPU].defensa;
            if (damagePlayer < 1) damagePlayer = 1;
            if (damagePlayer > 50) damagePlayer = 50;


            // - Comprobar crítico (15% probabilidad)
             if (random.Next(0, 100) < 15)
            {
                Console.WriteLine("¡Golpe crítico!");
                damagePlayer *= 2;
            }

            // - Aplicar daño a la CPU

               equipos[1, pokemonCPU].vida = equipos[1, pokemonCPU].vida - damagePlayer;


            // - Actualizar estaVivo si vida <= 0
            
            Console.WriteLine($"{equipos[0, pokemonJugador].nombre} ataca a {equipos[1, pokemonCPU].nombre}!");
            Console.WriteLine($"Daño infligido: {damagePlayer}");

            if (equipos[1, pokemonCPU].vida <= 0)
            {
                equipos[1, pokemonCPU].vida = 0;
                equipos[1, pokemonCPU].estaVivo = false;
            }

            // - Mostrar mensaje
            Console.WriteLine($"{equipos[1, pokemonCPU].nombre} ha sido derrotado!");

            // 6. Comprobar si la CPU ha perdido todos sus Pokémon
            // - Usar bucle for para contar cuántos tienen estaVivo = false
              bool cpuMuerta = true;
            for (int i = 0; i < 3; i++)
            {
                if (equipos[1, i].estaVivo)
                {
                    cpuMuerta = false;
                    break;
                }

            }
            if (cpuMuerta)
            {
                Console.WriteLine("¡Ganas! Todos los Pokémon de la CPU han caído.");
                break;
            }

            if (!equipos[1, pokemonCPU].estaVivo)
            {
                turno++;
                continue;
            }


            // 7. ATAQUE DE LA CPU (si sigue viva)

            int damagePlayer2 = equipos[1, pokemonCPU].ataque - equipos[0, pokemonJugador].defensa;
            if (damagePlayer2 < 1) damagePlayer2 = 1;
            if (damagePlayer2 > 50) damagePlayer2 = 50;
            
            if (random.Next(0, 100) < 15)
            {
                Console.WriteLine("¡Golpe crítico de la CPU!");
                damagePlayer2 *= 2;
            }

            equipos[0, pokemonJugador].vida = equipos[0, pokemonJugador].vida - damagePlayer2;

            Console.WriteLine($"{equipos[1, pokemonCPU].nombre} ataca a {equipos[0, pokemonJugador].nombre}!");
            Console.WriteLine($"Daño infligido: {damagePlayer2}");

            if (equipos[0, pokemonJugador].vida <= 0)
            {
                equipos[0, pokemonJugador].vida = 0;
                equipos[0, pokemonJugador].estaVivo = false;

            }

             Console.WriteLine($"{equipos[0, pokemonJugador].nombre} ha sido derrotado!");

            // 8. Comprobar si el jugador ha perdido

            bool jugadorMuerto = true;

            for (int i = 0; i < 3; i++)
            {
                if (equipos[0, i].estaVivo)
                {
                    jugadorMuerto = false;
                    break;
                }
            }
            if (jugadorMuerto)
            {
                Console.WriteLine("Has sido derrotado. La CPU gana.");
                break;
            }

            // 9. Incrementar contador de turnos
                    turno = turno + 1;


            Console.WriteLine("\n=--------------------------------");
            Console.WriteLine("       FIN DEL COMBATE      ");
            Console.WriteLine("-----------------------------------");

           
            Console.WriteLine("\nPokémon restantes del jugador:");
            
            for (int i = 0; i < 3; i++)
                if (equipos[0, i].estaVivo)
                    Console.WriteLine($"{equipos[0, i].nombre} - HP: {equipos[0, i].vida}/{equipos[0, i].vidaMaxima}");

            Console.WriteLine("\nPokémon restantes de la CPU:");
            for (int i = 0; i < 3; i++)
                if (equipos[1, i].estaVivo)
                    Console.WriteLine($"{equipos[1, i].nombre} - HP: {equipos[1, i].vida}/{equipos[1, i].vidaMaxima}");
        }
    }






    }

    struct Pokemon
    {
        public string nombre;
        public string tipoElemental;
        public int vida;
        public int vidaMaxima;
        public int ataque;
        public int defensa;
        public bool estaVivo; // TRUE = SI ESTA VIVO
                              // FALSE = SI HA SIDO DERROTADO 

    }

}
