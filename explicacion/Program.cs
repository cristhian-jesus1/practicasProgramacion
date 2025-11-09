using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {

        //SWITCH CASE

        // System.Console.WriteLine("Dime un numero del 1 al 5");
        // int numero = Convert.ToInt32(Console.ReadLine());

        // switch (numero)
        // {
        //     case 1:
        //         System.Console.WriteLine("Numero uno");
        //         break;
        //     case 2:
        //         System.Console.WriteLine("Numero dos");
        //         break;
        //     case 3:
        //         System.Console.WriteLine("Numero tres");
        //         break;
        //     case 4:
        //         System.Console.WriteLine("Numero cuatro");
        //         break;
        //     case 5:
        //         System.Console.WriteLine("Numero cinco");
        //         break;
        //     default:
        //         System.Console.WriteLine("Numero incorrecto");
        //         break;
        // }  

        // BUCLES WHILE

        // int password;

        // while (true)
        // {
        //     System.Console.WriteLine("Dime una contraseña");
        //     password = Convert.ToInt32(Console.ReadLine());

        //     if (password==1234)
        //     {
        //         System.Console.WriteLine("Correcto");
        //         break;
        //     }else
        //     {
        //         System.Console.WriteLine("Incorrecto, prueba otra vez");
        //     }

        // }

        // int password;
        // System.Console.WriteLine("Dime una contraseña");
        // password = Convert.ToInt32(Console.ReadLine());

        // while (password != 1234)
        // {
        //     System.Console.WriteLine("Intentalo de nuevo!");
        //     password = Convert.ToInt32(Console.ReadLine());

        // }
        // System.Console.WriteLine("Acceso concedido");

        // System.Console.WriteLine("Dime un numero");
        // int numero = Convert.ToInt32(Console.ReadLine());


        // while (numero != 0)
        // {
        //     int total = numero * numero;
        //     System.Console.WriteLine("El cuadrado del numero es : " + total);

        //     System.Console.WriteLine("Teclea otro numero");
        //     numero = Convert.ToInt32(Console.ReadLine());
        // }

        // System.Console.WriteLine("fin");

        // n++
        // n--
        // n+2 

        // int numero = 1;

        // while (numero<=20)
        // {
        //     if (numero % 2 == 0)
        //     {
        //         System.Console.WriteLine($"Este numero {numero} es par");
        //     }
        //     numero++;
        // }

        // int numero = 1;

        // do
        // {
        //     System.Console.WriteLine("Dime un numero de cuatro cifras");
        //     numero = Convert.ToInt32(Console.ReadLine());

        //     if (numero % 2 == 0)
        //     {
        //         System.Console.WriteLine("este numero es divisible entre dos");
        //     }
        //     else if (numero % 3 == 0)
        //     {
        //         System.Console.WriteLine("numero divisible entre tres");
        //     }
        //     else if (numero % 5 == 0)
        //     {
        //         System.Console.WriteLine("numero divisible entre cinco");
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("no es divisible por 2 3 5");
        //     }

        // } while (numero > 999 && numero < 10000);

        // ARRAYS

        // int[] numeros = new int[4];
        // numeros[0] = 1;
        // numeros[1] = 2;
        // numeros[2] = 3;
        // numeros[3] = 4;

        // for (int i = 0; i < 4; i++)
        // {
        // System.Console.WriteLine(numeros[i]);  // 1234
        // } 

        // foreach (var numero in numeros)
        // {
        //     System.Console.WriteLine(numeros); // 1234
        // }


        // int[] numeroLista = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        // string[] semaforo = { "rojo", "amarillo", "verde" };

        // foreach (var numero in numeroLista)
        // {
        //     System.Console.WriteLine(numero);
        // }

        // foreach (var color in semaforo)
        // {
        //     System.Console.WriteLine(color);
        // }

        // int[] numeros2 = new int[4];

        // for (int i = 0; i < 4; i++)
        // {
        //     numeros2[i] = i + 1;
        // }

        // foreach (var item in numeros2)
        // {
        //     System.Console.WriteLine(item);
        // }

        // CODIFICA UN PROGRAMA QUE SUME TODOS LOS ELEMENTOS DE UN ARRAY DE 5 PSI

        // OPCION 1

        // int[] numerosEnteros = new int[5];
        // int suma =0;

        // for (int i = 0; i < 5; i++)
        // {
        //     numerosEnteros[i] = i;
        // }

        // foreach (var entero in numerosEnteros)
        // {
        //     suma += entero;

        // }
        // System.Console.WriteLine(suma);

        // OPCION 2

        // int[] numerosEnteros = { 1, 2, 3, 4, 5 };
        // int suma = 0;

        // foreach (var entero in numerosEnteros)
        // {
        //     suma += entero;
        // }
        // System.Console.WriteLine(suma);

        // PIDE AL USUARIO UN NUMERO Y MUESTRA CUANTAS VECES APARECE EN UN ARRAY CON ESTOS VALORES 2,3,4,5,6,7,2,3,4

        // int[] numeros = { 2, 3, 4, 5, 6, 7, 2, 3, 4 };
        // int contador = 0;
        // int numero;

        // System.Console.WriteLine("Dime un numero");
        // numero = int.Parse(Console.ReadLine());

        // foreach (var item in numeros)
        // {
        //     if (numero == item)
        //     {
        //         contador++;
        //     }
        // }
        // System.Console.WriteLine($"El numero {numero} se repetie {contador}");

        //  CODIFICA UN NUEVO ARRAY QUE CONTENGA LOS MISMOS ELEMENTOS QUE OTRO

        // int[] numeros = { 2, 3, 4, 5, 6, 7, 2, 3, 4 };

        // int[] array = new int[9];

        // for (int i = 0; i < 10; i++)
        // {
        //     array[i] = numeros[i];
        // }

        // foreach (var item in array)
        // {
        //     System.Console.WriteLine(item);
        // }

        // Codifica l’exemple anterior, col·locant al costat de cada lletra la posició que ocupa la cadena


        // string cadena = "hello world";
        // int a = 0;
        // foreach (char letra in cadena)
        // {
        //     Console.WriteLine($"{letra}  {a}");
        //     a++;
        // }

        // Codifica un programa que saludi a totes les persones d’un array de noms

        // string[] nombres = { "albert", "marc", "judit", "monica" };

        // foreach (var nombre in nombres)
        // {
        //     System.Console.WriteLine($"Hola! {nombre}");
        // }

        // pide al usuario que rellene un array de 10 posiciones.Después pide un número y
        // busca si existe en el array, mostrando su posición o un mensaje si no se
        // encuentra.

        // int[] numeros = new int[10];
        // int contador = 0;
        // int comprobante = 0;


        // for (int i = 0; i < 10; i++)
        // {
        //     System.Console.WriteLine("Dime un numero");
        //     numeros[i] = int.Parse(Console.ReadLine());
        // }

        // System.Console.WriteLine("Dame numero a buscar");
        // int buscarNumero = int.Parse(Console.ReadLine());

        // foreach (var numero in numeros)
        // {
        //     if (numero == buscarNumero)
        //     {
        //         System.Console.WriteLine($"numero {numero} encontrado en la posicion {contador}");
        //         comprobante++;
        //     }
        //     contador++;
        // }

        // if (comprobante==0)
        // {
        //     System.Console.WriteLine("No se ha encontrado ninguna");
        // }




        // ESTRUCTURAS Y MATRICES !!!!!!!!!

        // int[,] array = new int[3, 3];
        // int contador = 0;
        // for (int i = 0; i < array.GetLength(0); i++)
        // {
        //     for (int j = 0; j < array.GetLength(1); j++)
        //     {
        //         // array[i, j] = 1;
        //         System.Console.WriteLine("Dame dato");
        //         array[i, j] = int.Parse(Console.ReadLine());
        //     }
        // }
        // foreach (var item in array)
        // {
        //     // System.Console.WriteLine(item);
        //     if (item == 2)
        //     {
        //         contador++;
        //     }

        //     System.Console.WriteLine($"Se han vendido {contador} entradas");
        // }

        // CREA UN PROGRAMA QUE SUME TODOS LOS ELEMENTOS DE UNA MATRIZ 3X3 DE ENTEROS

        // int[,] matriz = new int[3, 3];
        // int suma = 0;
        // int media = 0;


        // for (int i = 0; i < matriz.GetLength(0); i++)
        // {
        //     for (int j = 0; j < matriz.GetLength(1); j++)
        //     {
        //         matriz[i, j] = 2;
        //     }
        // }

        // foreach (var item in matriz)
        // {
        //     suma += item;
        //     media++;
        // }
        // System.Console.WriteLine($"La media es {suma/media}");



        //  IMAGINA UNA SALA DE CNE CON 12 BUTACAS, CODIFICA UN PROGRAMA QUE VALIDE SI UNA BUTACA ESTA DISPONIBLE POR FILA Y ASIENTO
        //  LA VENTA INICIAL EMPIEZA ASI, MUESTRA MENSAJE DE ASIENTO OCUPADO O RESERVA REALIZADA

        // int[,] salaCine = {
        //                     { 1, 1, 1, 0 },
        //                     { 0, 0, 0, 1 },
        //                     { 1, 0, 0, 1 } };

        // int fila;
        // int asiento;
        // int comprobante = 0;

        // while (comprobante == 0)
        // {
        //     System.Console.WriteLine("Fila");
        //     fila = int.Parse(Console.ReadLine());

        //     System.Console.WriteLine("Asiento");
        //     asiento = int.Parse(Console.ReadLine());

        //     if (salaCine[fila,asiento] == 1)
        //     {
        //         System.Console.WriteLine("Ocupado");
        //     }else
        //     {
        //         System.Console.WriteLine("reserva realizada");
        //         salaCine[fila, asiento] = 1;
        //         comprobante = 1;
        //     }
        // }
        //     int ocupado = 0;
        //     int libre = 0;
        //     foreach (var item in salaCine)
        //     {
        //         if (item == 1)
        //         {
        //             ocupado++;
        //         }else
        //         {
        //             libre++;
        //         }
        //     }
        //    System.Console.WriteLine($"Asietos disponibles {libre}, asientos ocupados {ocupado}");

        // Codifica un array de 7x2 donde cada fila representa un día y las columnas guardan la temperatura mínima y máxima. 
        // Muestra un resumen con el día más caluroso y el más frío.

        // int[,] temperatura = { { 20, 18, 15, 16, 21, 14, 11 },
        //                         {18,14,13,12,11,18,9}};

        // int tempMax = 100;
        // int tempMin = 0;

        // for (int i = 0; i < temperatura.GetLength(0); i++)
        // {
        //     for (int j = 0; j < temperatura.GetLength(1); j++)
        //     {
        //         if (temperatura[i, j] > tempMin)
        //         {
        //             tempMin = temperatura[i, j];
        //         }
        //         else if (temperatura[i, j] < tempMax)
        //         {
        //             tempMax = temperatura[i, j];
        //         }
        //     }
        // }
        // System.Console.WriteLine($"temp maxima {tempMax}");
        // System.Console.WriteLine($"temp min {tempMin}");

        // Guarda las notas de 4 alumnos en 3 asignaturas. Muestra las notas de un alumno concreto que el usuario elija.

        // int[,] notaAlumno = { { 6, 5, 8 },
        //                       { 6, 5, 4 },
        //                       { 8, 8, 6 },
        //                       { 5, 5, 4 } };

        // System.Console.WriteLine("nota alumno? (0)(1)(2)(3)");
        // int numero = int.Parse(Console.ReadLine());

        // for (int i = 0; i < notaAlumno.GetLength(0); i++)
        // {
        //     System.Console.WriteLine($"Nota {i+1} es {notaAlumno[numero,i]}");
        // }

        //  Codifica un array de 5 filas y 5 columnas que represente asientos. Pide al usuario que marque algunos como ocupados (por ejemplo, con un “X”) 
        // y muestra el plano del cine actualizado.


        // int[,] salaCine = {{0,0,0,0,0},
        //                     {0,0,0,0,0},
        //                     {0,0,0,0,0},
        //                     {0,0,0,0,0},
        //                     {0,0,0,0,0}};

        // int fila;
        // int asiento;

        // for (int i = 0; i < 5; i++)
        // {
        //     System.Console.WriteLine("Fila?");
        //     fila = int.Parse(Console.ReadLine());

        //     System.Console.WriteLine("asientos?");
        //     asiento = int.Parse(Console.ReadLine());

        //     salaCine[fila, asiento] = 1;
        // }

        // for (int i = 0; i < salaCine.GetLength(0); i++)
        // {
        //     for (int j = 0; j < salaCine.GetLength(1); j++)
        //     {
        //         System.Console.Write(salaCine[i, j]);
        //     }
        //     System.Console.WriteLine("");
        // }



        // Declara un array 3x4 donde cada fila representa un almacén y cada columna un producto. 
        // Pide al usuario que rellene las cantidades y muestra un informe por almacén.

        // int[,] almacen = new int[3, 4];     // 1 1 1 1
        //                                     // 1 1 1 1
        //                                     // 1 1 1 1

        // int numProducto;
        // int verAlmacen;
        // for (int i = 0; i < 3; i++)
        // {
        //     for (int j = 0; j < 4; j++)
        //     {
        //         System.Console.WriteLine("introduce num producto");
        //         numProducto = int.Parse(Console.ReadLine());
        //     }
        // }

        // System.Console.WriteLine("que almacen quieres ver (0)(1)(2)");
        // verAlmacen = int.Parse(Console.ReadLine());

        // for (int i = 0; i < almacen.GetLength(0); i++)
        // {
        //    System.Console.WriteLine($"Almacen {verAlmacen+1} tiene {almacen[verAlmacen,i]} ");
        // }
    }
}

