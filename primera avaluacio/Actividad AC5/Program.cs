internal class Program
{
    private static void Main(string[] args)
    {
        //    Codifica un array de 7x2 donde cada fila representa un día y las columnas guardan la temperatura mínima y máxima. 
        //     Muestra un resumen con el día más caluroso y el más frío.

        // int maxTemperatura = 0;
        // int minTemperatura = 100;
        // int[,] temperaturas = {{10, 12, 15, 14, 13, 18, 24},
        //                        {5,  4,  11, 11,  4,  9,  5}};

        // for (int i = 0; i < 2; i++)
        // {
        //     for (int j = 0; j < 7; j++)
        //     {
        //         if (temperaturas[i, j] > maxTemperatura)
        //         {
        //             maxTemperatura = temperaturas[i, j];
        //         }
        //         if (temperaturas[i, j] < minTemperatura)
        //         {
        //             minTemperatura = temperaturas[i, j];
        //         }
        //     }
        // }
        // Console.WriteLine("La temperatura máxima es: " + maxTemperatura);
        // Console.WriteLine("La temperatura mínima es: " + minTemperatura);



        //     Guarda las notas de 4 alumnos en 3 asignaturas.
        //     Muestra las notas de un alumno concreto que el usuario elija.

        // int[,] notaalumnos = {{7, 6, 9},
        //                       {6, 5, 4},
        //                       {7, 9, 8},
        //                       {3, 5, 2}};

        // Console.WriteLine("Dime el posició del alumne (0-3): ");
        // int posicionalumno = Convert.ToInt32(Console.ReadLine());

        // if (posicionalumno >= 0 && posicionalumno <= 3)
        // {
        //     for (int i = 0; i < notaalumnos.GetLength(0); i++)
        //     {
        //        Console.WriteLine("la nota en la asignatura " + (i + 1) + " és: " + notaalumnos[posicionalumno, i]);
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("Posició d'alumne no vàlida.");
        // }


        //     Codifica un array de 5 filas y 5 columnas que represente asientos. 
        //     Pide al usuario que marque algunos como ocupados(por ejemplo, con un “X”) y muestra el plano del cine actualizado.

        // int[,] asientocine = {{0, 0, 0, 0, 0},
        //                    {0, 0, 0, 0, 0},
        //                    {0, 0, 0, 0, 0},
        //                    {0, 0, 0, 0, 0},
        //                    {0, 0, 0, 0, 0}};

        // int fila;
        // int columna;
        // int comprobante = 0;

        // while (comprobante ==0)
        // {
        //     Console.WriteLine("Dime la fila:");
        //     fila = Convert.ToInt32(Console.ReadLine());

        //     Console.WriteLine("Dime la columna:");
        //     columna = Convert.ToInt32(Console.ReadLine());

        //     Console.WriteLine("Si quieres salir pulsa 1, si quieres continuar pulsa 0:");
        //     comprobante = Convert.ToInt32(Console.ReadLine());

        //     asientocine[fila, columna] = 1;
        // }
        // Console.WriteLine(" ");
        // Console.WriteLine("Plano del cine actualizado: ");
        // for (int i = 0; i < asientocine.GetLength(0); i++)
        // {
        //     for (int j = 0; j < asientocine.GetLength(1); j++)
        //     {
        //         if (asientocine[i, j] == 1)
        //         {
        //             Console.Write("X ");
        //         }
        //         else
        //         {
        //             Console.Write("O ");
        //         }
        //     }
        //     Console.WriteLine();
        // }



        //         Declara un array 3x4 donde cada fila representa un almacén y cada columna un producto. 
        //         Pide al usuario que rellene las cantidades y muestra un informe por almacén.

        // int[,] productosalmacen = {{0, 0, 0, 0},
        //                            {0, 0, 0, 0},
        //                            {0, 0, 0, 0} };

        // for (int i = 0; i < productosalmacen.GetLength(0); i++)
        // {
        //     for (int j = 0; j < productosalmacen.GetLength(1); j++)
        //     {
        //         Console.WriteLine("Dime la cantidad de productos en la almacen " + (i + 1) + " Categoria " + (j + 1) + ": ");
        //         productosalmacen[i, j] = Convert.ToInt32(Console.ReadLine());
        //     }
        // }

        // Console.WriteLine(" ");
        // Console.WriteLine("El inventario del almacén es: ");
        // for (int i = 0; i < productosalmacen.GetLength(0); i++)
        // {
        //     for (int j = 0; j < productosalmacen.GetLength(1); j++)
        //     {
        //         Console.WriteLine("En la almacen " + (i+1) + " Categoria " + (j+1) + " hay " + productosalmacen[i, j] + " productos.");
        //     }
        // }



        //         Usa un array 3x3 para representar las habitaciones de un pequeño hotel.
        //         Permite marcar cuáles están ocupadas y muestra cuántas quedan libres.


        // int[,] habitacioneshotel = {{0, 0, 0},
        //                             {0, 0, 0},
        //                             {0, 0, 0} };
        // int libres = 0;
        // int ocupadas = 0;


        // for (int i = 0; i < habitacioneshotel.GetLength(0); i++)
        // {
        //     for (int j = 0; j < habitacioneshotel.GetLength(1); j++)
        //     {
        //         Console.WriteLine("La habitación [" + (i + 1) + "," + (j + 1) + "] está ocupada? (1 = Si, 0 = No): ");
        //         habitacioneshotel[i, j] = Convert.ToInt32(Console.ReadLine());
        //     }
        // }

        // Console.WriteLine("Disponibilidad: ");
        // for (int i = 0; i < habitacioneshotel.GetLength(0); i++)
        // {
        //     for (int j = 0; j < habitacioneshotel.GetLength(1); j++)
        //     {
        //         if (habitacioneshotel[i, j] == 0)
        //         {
        //             Console.Write("L ");
        //             libres++;
        //         }
        //         else
        //         {
        //             Console.Write("O ");
        //             ocupadas++;
        //         }
        //     }
        //     Console.WriteLine();
        // }

        // Console.WriteLine("Habitaciones libres: " + libres);
        // Console.WriteLine("Habitaciones ocupadas: " + ocupadas);

        //         Representa con un array 5x5 la asistencia de 5 alumnos durante 5 días.Usa “A” para asistido y “F” para falta. 
        //         Luego muestra cuántas faltas tiene cada alumno.


        // string[,] asistenciaalumnos = {{"A", "F", "A", "A", "F"},
        //                                {"A", "A", "A", "F", "A"},
        //                                {"F", "F", "A", "A", "A"},
        //                                {"A", "A", "F", "A", "F"},
        //                                {"A", "F", "F", "A", "A"} };


        // for (int i = 0; i < asistenciaalumnos.GetLength(0); i++)
        // {
        //     int faltas = 0;
        //     for (int j = 0; j < asistenciaalumnos.GetLength(1); j++)
        //     {
        //         if (asistenciaalumnos[i, j] == "F")
        //         {
        //             faltas++;
        //         }
        //     }
        //     Console.WriteLine("El alumno " + i + " tiene " + faltas + " faltas.");
        // }


        //         Codifica un array de 5x3 donde las filas sean días(lunes a viernes) y las columnas sean horas(mañana, tarde, noche).
        //         Pide al usuario que introduzca una actividad por celda y muestra toda la agenda.

        // int[,] agenda = new int[5, 3];

        // for (int i = 0; i < agenda.GetLength(0); i++)
        // {
        //     for (int j = 0; j < agenda.GetLength(1); j++)
        //     {
        //         Console.WriteLine("Dime la actividad para el día " + (i + 1) + " en la hora " + (j + 1) + ": ");
        //         agenda[i, j] = Convert.ToInt32(Console.ReadLine());
        //     }
        // }

        // for (int i = 0; i < agenda.GetLength(0); i++)
        // {
        //     for (int j = 0; j < agenda.GetLength(1); j++)
        //     {
        //         Console.WriteLine("Día " + (i + 1) + " Hora " + (j + 1) + ": " + agenda[i, j]);
        //     }
        // }




        //         Codifica un array 4x3 donde las filas representan productos y las columnas las valoraciones de 3 usuarios.
        //         Muestra qué producto tiene la valoración media más alta.

        // int[,] valoracionesproductos = {{5, 4, 3},
        //                                 {2, 3, 4},
        //                                 {5, 5, 5},
        //                                 {1, 2, 3} };

        // int mediaalta = 0;
        // int productoMejorValorado = -1;

        // for (int i = 0; i < valoracionesproductos.GetLength(0); i++)
        // {
        //     int suma = 0;

        //     for (int j = 0; j < valoracionesproductos.GetLength(1); j++)
        //     {
        //         suma += valoracionesproductos[i, j];
        //     }

        //     media = suma / valoracionesproductos.GetLength(1);

        //     if (media > mediaalta)
        //     {
        //         mediaalta = media;
        //         productoMejorValorado = i;
        //     }
        // }


        // Console.WriteLine("El producto " + (productoMejorValorado + 1) + " tiene media mas alta de " + mediaalta);



        //         Simula un parking de 4x4.Cada posición puede estar “L” (libre)o “O” (ocupada).
        //         Permite aparcar un coche, retirarlo y mostrar el estado del aparcamiento.
        //          

    }
}