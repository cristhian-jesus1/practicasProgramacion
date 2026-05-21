internal class Program
{
    private static void Main(string[] args)
    {
        // Un estadio tiene gradas con diferente número de asientos según la zona.
        //  Cada asiento ocupado se marca con 1 y los libres con 0.

        // ●	Calcule el total de asientos ocupados(1) y libres(0).
        // ●	Indique qué grada tiene más ocupación.
        // ●	Muestre el porcentaje de ocupación del estadio.

        //         int[][] estadio = {
        //             new int[] { 1, 1, 1, 0, 1, 1 },
        //             new int[] { 1, 0, 1, 1 },
        //             new int[] { 0, 0, 1 },
        //             new int[] { 1, 1 }
        //   };           
        //         int asientoLibre = 0;
        //         int asientoOcupado = 0;   
        //         int sumaFila = 0;   
        //         double asientoTotal;  
        //         double porcentajeOcupacion;

        //         for (int i = 0; i < estadio.Length; i++)
        //         {
        //             for (int j = 0; j < estadio[i].Length; j++)
        //             {
        //                 if (estadio[i][j] == 0)
        //                 {
        //                     asientoLibre++;
        //                 }else
        //                 {
        //                     asientoOcupado++;
        //                 }
        //             }
        //         }
        //         asientoTotal = asientoLibre + asientoOcupado;
        //         porcentajeOcupacion = asientoOcupado / asientoTotal * 100;

        //         System.Console.WriteLine($"El estadio tiene {asientoLibre} asientos libres y {asientoOcupado} asientos ocupados");
        //         System.Console.WriteLine($"El porcentaje de ocupacion es {porcentajeOcupacion:F0}%");

        //         for (int i = 0; i < estadio.Length; i++)
        //         {
        //             sumaFila = 0;

        //             for (int j = 0; j < estadio[i].Length; j++)
        //             {
        //                 sumaFila+= estadio [i][j]; 
        //             }
        //             System.Console.WriteLine($"La grada {i+1} tiene {sumaFila}");

        //         }

        // Un aparcamiento tiene plantas con distinto número de plazas.
        // Cada posición representa una plaza: 1 indica que está ocupada y 0 que está libre.

        // ●	Muestre las plazas libres de cada planta.
        // ●	Permita registrar la entrada de un coche(0 → 1) o su salida(1 → 0).
        // ●	Indique cuántas plazas libres quedan en todo el aparcamiento.

        // int[][] parking = {
        //         new int[] { 1, 1, 0, 0 },
        //         new int[] { 1, 1, 1 },
        //         new int[] { 0, 0 },
        //         new int[] { 1 }
        //         };
        //         int registro = -1 ;
        //         int plazaOcupadas = 0;
        //         int plazaLibres = 0;
        //     for (int i = 0; i < parking.Length; i++)
        //     {
        //         int plazaLibrePlanta = 0;
        //         for (int j = 0; j < parking[i].Length; j++)
        //         {
        //             if (parking[i][j] == 0)
        //             {
        //                 plazaLibrePlanta++;
        //             }
        //         }
        //         System.Console.WriteLine($"En la planta {i+1} hay {plazaLibrePlanta}");
        //     }

        //     for (int i = 0; i < parking.Length; i++)
        //     {
        //         for (int j = 0; j < parking[i].Length; j++)
        //         {
        //            System.Console.WriteLine($"Dime registro de planta {i} y posicion {j} (0para libre y 1 para ocupado)");
        //            registro = int.Parse(Console.ReadLine());
        //            if (registro == 1)
        //            {
        //                 parking[i][j] = registro;
        //                 plazaOcupadas++;
        //            }else if (registro == 0)
        //            {
        //             parking[i][j]= registro;
        //             plazaLibres++;
        //            }else
        //            {
        //             System.Console.WriteLine("registro no valido");
        //            }

        //         }

        //         System.Console.WriteLine($"plazas totales : { plazaLibres+plazaOcupadas}");
        //         System.Console.WriteLine($"plaza libre : {plazaLibres}");
        //         System.Console.WriteLine($"total plaza ocupadas : {plazaOcupadas}");
        //     }
        // int plazaLibre = 0;
        // int plazaOcupada = 0;
        // int registro;


        // System.Console.WriteLine($"Entrada(0) o Salida (1) ? ");
        // registro = int.Parse(Console.ReadLine());

        // for (int i = 0; i < parking.Length; i++)
        // {
        //     for (int j = 0; j < parking[i].Length; j++)
        //     {

        //         if (registro == 0)
        //         {
        //             // registro = 1;
        //             plazaOcupada++;
        //             parking[i][j] = 1;

        //         }else 
        //         {
        //             // registro = 0;
        //             plazaLibre++;
        //             parking[i][j] = 0;
        //         }

        //     }
        // }
        // System.Console.WriteLine($"Plazas {plazaLibre}");
        // for (int i = 0; i < parking.Length; i++)
        // {
        //     for (int j = 0; j < parking[i].Length; j++)
        //     {
        //         System.Console.Write($"{parking[i][j]}");
        //     }
        //     System.Console.WriteLine();
        // }

        //  Una fábrica controla su producción diaria en diferentes líneas, 
        //  pero no todas fabrican el mismo número de piezas por día.
        //  Codifica un programa que:

        // ●	Calcule el total general de piezas producidas.
        // ●	Muestre la producción total por línea.
        // ●	Determine cuál fue la línea más productiva.

        // int[][] produccion = {
        //         new int[] { 12, 15, 10, 9 },
        //         new int[] { 20, 18, 22 },
        //         new int[] { 10, 11 },
        //         new int[] { 25 , 32, 33, 33}
        //   };

        //   int sumaTotal = 0;
        //   int sumaFila;
        //   int maximo = 0;
        //   int posicion = 0;

        //   for (int i = 0; i < produccion.Length; i++)
        //   {
        //     sumaFila = 0;
        //     for (int j = 0; j < produccion[i].Length; j++)
        //     {
        //         sumaTotal+=produccion[i][j];
        //         sumaFila+=produccion[i][j];
        //         if (sumaFila > maximo)
        //         {
        //             maximo = sumaFila;
        //             posicion = i;

        //         }
        //     }
        //     System.Console.WriteLine($"El total por fabrica es {sumaFila}");
        //   }
        //   System.Console.WriteLine($"El total es : {sumaTotal}");
        //   System.Console.WriteLine($"La linea {posicion+1} fue mas productiva con {maximo}");


        // Cada estudiante ha realizado una cantidad distinta de pruebas durante el trimestre.
        // Cada número representa la nota obtenida en cada pruebaCodifica un programa que:

        // ●	Permita introducir el número de estudiante y calcular su media.
        // ●	Muestre la media general del grupo.
        // ●	Indique qué estudiante obtuvo la mejor nota media.

        // int[][] notas = {
        //                     new int[] { 7, 8, 6, 9 },
        //                     new int[] { 5, 6, 7 },
        //                     new int[] { 9, 9 },
        //                     new int[] { 10 }
        //                 };

        // int sumaNotaEstudiante = 0;
        // int mediaEstudiante = 0;

        // int sumaTotalAlumnos = 0;
        // int mediaGeneral = 0;
        
        // int mejorMedia = 0;
        // int notaslongitud= 0;

        // System.Console.WriteLine("Dime nummero de estudiante (0 a 3)");
        // int estudiante = int.Parse(Console.ReadLine());

        // for (int i = 0; i < notas[estudiante].Length; i++)
        // {   
        //    System.Console.Write(notas[estudiante][i]);
        //    sumaNotaEstudiante+=notas[estudiante][i];
        // }
        // System.Console.WriteLine();

        // mediaEstudiante = sumaNotaEstudiante / notas[estudiante].Length;
       
        // System.Console.WriteLine($"La media del estudiante {estudiante} es {mediaEstudiante}");

        // for (int i = 0; i < notas.Length; i++)
        // {
        //     for (int j = 0; j < notas[i].Length; j++)
        //     {
        //         sumaTotalAlumnos+=notas[i][j];
        //         notaslongitud++;
        //     }
        // }
        // mediaGeneral=sumaTotalAlumnos/notaslongitud;
        // System.Console.WriteLine();
        // System.Console.WriteLine($"La media general del grupo es {mediaGeneral}");
      










    }
}