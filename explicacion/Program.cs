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

        int numero = 1;

        do
        {
            System.Console.WriteLine("Dime un numero de cuatro cifras");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                System.Console.WriteLine("este numero es divisible entre dos");
            }
            else if (numero % 3 == 0)
            {
                System.Console.WriteLine("numero divisible entre tres");
            }
            else if (numero % 5 == 0)
            {
                System.Console.WriteLine("numero divisible entre cinco");
            }
            else
            {
                System.Console.WriteLine("no es divisible por 2 3 5");
            }

        } while (numero > 999 && numero < 10000);

    }
}

