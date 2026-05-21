internal class Program
{
    private static void Main(string[] args)
    {
        // Escribe un programa que introduciendo tres notas de un alumno por consola, calcule la media e indique 
        // si está suspendido o aprobado(nota media mayor o igual a 5)

        // System.Console.WriteLine("Dime una nota");
        // int nota1 = Convert.ToInt32(Console.ReadLine());

        // System.Console.WriteLine("Dime una nota");
        // int nota2 = Convert.ToInt32(Console.ReadLine());

        // System.Console.WriteLine("Dime una nota");
        // int nota3 = Convert.ToInt32(Console.ReadLine());

        // int media = (nota1 + nota2 + nota3) / 3;

        // if (media>=5)
        // {
        //     System.Console.WriteLine("Aprobado");
        // }else
        // {
        //     System.Console.WriteLine("Suspendido");
        // }

        // Codifica un programa que pida números al usuario y finalice la 
        // ejecución con el número 0.Cuando acabe, deberá mostrar por consola cuantos fueron pares y cuantos impares. 


        // int numero = 1;
        // int numeroPar =0;
        // int numeroImpar =0;

        // while (numero != 0)
        // {
        //     System.Console.WriteLine("Dime un numero (0 para terminar)");
        //     numero = Convert.ToInt32(Console.ReadLine());

        //     if (numero % 2 == 0)
        //     {
        //         numeroPar++;
        //     }
        //     else
        //     {
        //         numeroImpar++;
        //     }
        // }

        // System.Console.WriteLine($"Numero par {numeroPar} , numero impar {numeroImpar}");


        // Codifica un programa “Calculadora”, con las 4 operacions básicas,
        // sumar restar, multiplicar y dividir siguiendo estos pasos: 

        // int numero1;
        // int numero2;
        // int operacion;
        // int total;
        // int respuesta =2;
        // do
        // {
        //     System.Console.WriteLine("Introduce un numero");
        //     numero1 = Convert.ToInt32(Console.ReadLine());

        //     System.Console.WriteLine("Introduce un numero");
        //     numero2 = Convert.ToInt32(Console.ReadLine());

        //     System.Console.WriteLine("Que operacion quieres hacer sumar(1) restar(2) multiplicar(3) dividir(4)");
        //     operacion = Convert.ToInt32(Console.ReadLine());

        //     switch (operacion)
        //     {
        //         case 1:
        //             total = numero1 + numero2;
        //             System.Console.WriteLine($"La suma es {total} ");
        //             break;
        //         case 2:
        //             total = numero1 - numero2;
        //             System.Console.WriteLine($"La resta es {total} ");
        //             break;
        //         case 3:
        //             total = numero1 * numero2;
        //             System.Console.WriteLine($"La multiplicacion es {total} ");
        //             break;
        //         case 4:
        //             if (numero2!=0)
        //             {
        //                 System.Console.WriteLine("");
        //                 total = numero1 / numero2;
        //                 System.Console.WriteLine($"La division es {total} ");
        //             }

        //             break;
        //         default:
        //             System.Console.WriteLine("operacion no encontrada");
        //             break;
        //     }
        //     System.Console.WriteLine("Seguir (1)o no (0)");
        //     respuesta = Convert.ToInt32(Console.ReadLine());


        // } while (respuesta!=0);


        // Letra del DNI.
        // La letra del DNI se calcula dividiendo el número de documento entre 23.A partir del resto, se obtiene la letra a partir de los caracteres del cuadro de abajo.
        // Codificar un programa que pida números al usuario hasta que encuentre uno compatible con la letra a

        // int numero;
        // System.Console.WriteLine("Numero DNI");
        // numero = Convert.ToInt32(Console.ReadLine());

        // int resto = numero % 23;

        // if (resto==3)
        // {
        //     System.Console.WriteLine($"El numero {numero} es a");
        // }

        // Imprime en pantalla un triangulo de 15 asteriscos de altura x 15 de base.

        // for (int i = 1; i < 15; i++)
        // {
        //     for (int j = 1; j < i; j++)
        //     {
        //         System.Console.Write("*");
        //     }
        //     System.Console.WriteLine();
        // }

        // Imprime en pantalla un triangulo de 15 asteriscos de altura x 1 de base.

    //    for (int i = 15; i > 1; i--)
    //    {
    //         for (int j = 1; j < i; j++)
    //         {
    //             System.Console.Write("*");
    //         }
    //         System.Console.WriteLine();
    //    }

    }
}