using System.Security.Cryptography.X509Certificates;

internal class Program
{
    // static int numeroTransacciones=0;
    // static double saldoEnEuros=0;
    // static int contador = 0;
    private static void Main(string[] args)
    {
        // DibujarRectangulo(3,10);    
        // MayorEdad(10);

        // System.Console.WriteLine("es mayor de edad " + MayorEdad(10));
        // System.Console.WriteLine(MayorEdad(10)); 

        // EJEMPLO FUNCIONES CON WHILE Y SWITCH 

        // Tarea[] tareas = new Tarea[10];
        // int opcion = 1;
        // int contador = 0;
        // do
        // {
        //     System.Console.WriteLine("MENU");
        //     System.Console.WriteLine("Opcion");
        //     System.Console.WriteLine("1 Agregar tasca");
        //     System.Console.WriteLine("2 Borrar Tasca");
        //     System.Console.WriteLine("3 Tasca completada");
        //     System.Console.WriteLine("4 Mostrar tasca");
        //     System.Console.WriteLine("0 Salir");
        //     opcion = int.Parse(Console.ReadLine());

        //     switch (opcion)
        //     {
        //         case 1:
        //             InsertarNota(tareas);
        //             break;
        //         case 2:
        //             BorrarNota(tareas);
        //             break;
        //         case 3:
        //             TareaCompletada(tareas);
        //             break;
        //         case 4:
        //             VerTodo(tareas);
        //             break;
        //         case 0:
        //             opcion = 1;
        //             break;

        //         default:
        //             break;
        //     }




        // } while (opcion != 0);


        // EJERCICIO CALCULADORA ----------


        // decimal numero1;
        // decimal numero2;
        // string operacion;

        // System.Console.WriteLine("numero1");
        // numero1 = Convert.ToDecimal(Console.ReadLine());

        // System.Console.WriteLine("numero2");
        // numero2 = Convert.ToDecimal(Console.ReadLine());

        // System.Console.WriteLine("operacion?");
        // operacion = Console.ReadLine();

        // System.Console.WriteLine($"el resultado de la operacion es {Calculadora(numero1, numero2, operacion)}");
        
        // Aumentar(ref contador);
        // Aumentar(ref contador);
        // // System.Console.WriteLine(contador);

        // Disminuir(ref contador);
        // System.Console.WriteLine(contador);

        // Mostrar(contador);
        // System.Console.WriteLine(contador);

        // Reiniciar();
        // System.Console.WriteLine(contador);
        // int operacion = 1;

        // System.Console.WriteLine("operacio 1-ingreso euros, 2-ingreso otras monedas 3- retirar, 4-consultar 0-salir");
        // operacion = int.Parse(Console.ReadLine());

        // switch (operacion)
        //     {
        //         case 1:
        //             System.Console.WriteLine("cantidad?");
        //             int cantidad = int.Parse(Console.ReadLine());
        //             Depositar(cantidad);
        //             break;
        //         case 2:
        //             System.Console.WriteLine("cantidad?");
        //             cantidad = int.Parse(Console.ReadLine());
        //             double tipoCambio = 1.20;
        //             Depositar(cantidad, tipoCambio);
        //             break;
        //         case 3:
        //             System.Console.WriteLine("cantidad?");
        //             cantidad = int.Parse(Console.ReadLine());
        //             tipoCambio = 0.5;
        //             Depositar(cantidad, tipoCambio);
        //             break;
        //         case 4:
        //             System.Console.WriteLine("cantidad?");
        //             cantidad = int.Parse(Console.ReadLine());
        //             tipoCambio = 1.20;
        //             Retirar(cantidad);
        //             break;
        //         case 5:
        //             Consultar();
        //             break;
        //         default:
        //             break;
        //     }


        
        










        
    }
    // static decimal Calculadora(decimal numero1, decimal numero2, string operacion)
    // {
    //     decimal restultado = 0;

    //     switch (operacion)
    //     {
    //         case "suma":
    //             restultado = Suma(numero1,numero2);
    //             break;
    //         case "resta":
    //             restultado = Resta(numero1, numero2);
    //             break;
    //         case "multiplicacion":
    //             restultado = Multiplicacion(numero1, numero2);
    //             break;
    //         case "division":
    //             restultado = Division(numero1, numero2);
    //             break;
    //         default:
    //             break;
    //     }
    
    //     static decimal Suma(decimal num1, decimal num2)
    //     {
    //         return num1 + num2;
    //     }
    //     static decimal Resta(decimal num1, decimal num2)
    //     {
    //         return num1 - num2;
    //     }
    //     static decimal Multiplicacion(decimal num1, decimal num2)
    //     {
    //         return num1 * num2;
    //     }
    //     static decimal Division(decimal num1, decimal num2)
    //     {
    //         return num1 / num2;
    //     }

    //     return restultado;
        

    // FUNCION RECTANGULO

    //  static void DibujarRectangulo(int ancho, int alto)
    // {
    //     for (int i = 0; i < ancho; i++)
    //     {
    //         for (int j = 0; j < alto; j++)
    //         {
    //             System.Console.Write("*");
    //         }
    //         System.Console.WriteLine();
    //     }
    // }

    // FUNCION EDAD

    // static void MayorEdad(int year)
    // {
    //     if (25-year < 18)
    //     {
    //         System.Console.WriteLine("menor de edad");
    //     }
    //     else
    //     {
    //         System.Console.WriteLine("mayor de edad");
    //     }
    // }

    // static string MayorEdad(int year)
    // {
    //     if (25 - year < 18)
    //     {
    //         return "es  menor de edad";
    //     }
    //     else
    //     {
    //         return "es mayor de edad";
    //     }
    // }



    // EJEMPLO FUNCIONES CON WHILE Y SWITCH 

    // private static void InsertarNota(Tarea[] tareas)
    // {
    //     System.Console.WriteLine("Que posicion quieres guardar la tarea");
    //     int posicion = Convert.ToInt32(Console.ReadLine());

    //     if (posicion >= 0 && posicion <= 9)
    //     {
    //         System.Console.WriteLine("asunto?");
    //         tareas[posicion].asunto = Console.ReadLine();

    //         System.Console.WriteLine("estado?");
    //         tareas[posicion].hecho = int.Parse(Console.ReadLine());
    //     }
    // }

    // private static void BorrarNota(Tarea[] tareas)
    // {
    //     System.Console.WriteLine("Borrar Nota");
    //     int posicion = Convert.ToInt32(Console.ReadLine());

    //     if (posicion >= 0 && posicion <= 9)
    //     {
    //         tareas[posicion].asunto = "";

    //         tareas[posicion].hecho = 0;
    //     }
    // }

    // private static void TareaCompletada(Tarea[] tareas)
    // {
    //     System.Console.WriteLine("tarea");
    //     int posicion = Convert.ToInt32(Console.ReadLine());

    //     if (posicion >= 0 && posicion <= 9)
    //     {
    //         tareas[posicion].hecho = 1;
    //     }
    // }

    // private static void VerTodo(Tarea[] tareas)
    // {
    //     foreach (var item in tareas)
    //     {
    //         System.Console.WriteLine(item.asunto);
    //         System.Console.WriteLine(item.hecho);
    //     }
    // }

    // struct Tarea
    // {
    //     public string asunto;

    //     public int hecho;
    // }

    // static void Aumentar(ref int contador)
    // {
    //     contador++;
    // }
    // static void Disminuir(ref int contador)
    // {
    //     contador--;
    // }
    // static void Mostrar( int contador)
    // {
    //     System.Console.WriteLine(contador);
    // }
    // static void Reiniciar( contador)
    // {
    //     contador = 0;
    // }


    // static void Depositar(int cantidad)
    // {
    //     saldoEnEuros = saldoEnEuros + cantidad;
    //     numeroTransacciones++;
    // }


    // static void Depositar(int cantidad, double tipoDeCambio = 1)
    // {
    //     saldoEnEuros = saldoEnEuros + (cantidad * tipoDeCambio);
    //     numeroTransacciones++;
    // }

    // static void Retirar(int cantidad)
    // {
    //     numeroTransacciones++;
    //     saldoEnEuros -= cantidad;
    // }

    // static void Consultar()
    // {
    //     numeroTransacciones++;
    //     System.Console.WriteLine($"Saldo actual {saldoEnEuros} EUROS");
    //     System.Console.WriteLine($"Numero de transacciones {numeroTransacciones}");
    // }

































}