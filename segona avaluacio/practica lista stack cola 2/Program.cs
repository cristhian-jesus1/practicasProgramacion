internal class Program
{
    private static void Main(string[] args)
    {

        // 4 Separa los números en dos lista pares / impares


        // 1.Crear una lista con números
        // 2.Pide 10 números al usuario
        // 3.Separar los números en dos listas(pares e impares)
        // 4.Mostrar los números pares
        // 5.Mostrar los números impares
        // 6.Mostrar el total de cada tipo


        //     List<int> numeros = new List<int>();

        //     List<int> numerosPares = new List<int>();

        //     List<int> numerosImpares = new List<int>();

        //     for (int i = 0; i < 10; i++)
        //     {
        //         System.Console.WriteLine($"Dime 10 numeros");
        //         int pedirNumero = int.Parse(Console.ReadLine()); 
        //         numeros.Add(pedirNumero); 
        //     }
        //     foreach (var num in numeros)
        //     {
        //         if (num %2==0)
        //         {
        //             numerosPares.Add(num);
        //         }else
        //         {
        //             numerosImpares.Add(num);
        //         }
        //     }
        //     foreach (var verNumero in numerosPares)
        //     {
        //         System.Console.WriteLine(verNumero);
        //     }

        //     foreach (var verNumero in numerosImpares)
        //     {
        //         System.Console.WriteLine(verNumero);
        //     }

        //     System.Console.WriteLine($"Total de numeros pares es {numerosPares.Count}");

        //     System.Console.WriteLine($"Total de numeros pares es {numerosImpares.Count}");



        // 5 Usa una pila para invertir un texto.


        // 1.Recibir un texto
        // 2.Agregar cada carácter a la pila(Push)
        // 3.Sacar los caracteres uno por uno(Pop)
        // 4.Mostrar el texto invertido


        Stack<char> texto = new Stack<char>();
        string textoInvertido = "";
        string text = "HOLA K ASE";

        foreach (var letras in text)
        {
            texto.Push(letras);
        }

        System.Console.WriteLine($"Total letras {texto.Count}");

        while (texto.Count > 0)
        {
            char letra = texto.Pop();
            textoInvertido += letra;
            System.Console.WriteLine(letra);
        }

        System.Console.WriteLine($"Muestra texto invertido {textoInvertido}");

















    }
}