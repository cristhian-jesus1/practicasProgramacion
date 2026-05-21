using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        // AC1
        // string archivo = "registro.txt";
        // string frase = "";
        // StreamWriter fichero = new StreamWriter(archivo);

        // while (frase != "salir")
        // {
        //     Console.WriteLine("que quieres guardar?");
        //     frase = Console.ReadLine();

        //     if (frase != "salir")
        //     {
        //         fichero.WriteLine(frase);
        //     }
        // }   
        // fichero.Close();

        // AC2

        // string archivo = "listaproducto.txt";

        // StreamWriter fichero = new StreamWriter(archivo,true);

        // string nombreProducto = "";

        // while (nombreProducto != "salir")
        // {
        //     System.Console.WriteLine("nombre producto?");
        //     nombreProducto = Console.ReadLine();

        //     if (nombreProducto != "salir")
        //     {
        //         Console.WriteLine("dime precio");
        //         string precioProducto = Console.ReadLine();

        //         fichero.WriteLine(nombreProducto + ":" + precioProducto);
        //     }  
        
        // }
        // fichero.Close(); 

        // AC3

    //     string archivo1 = "archivo1.txt";
    //     string archivo2 = "archivo2.txt";
    //     string archivoSeleccionado;

    //     System.Console.WriteLine("titulo nota");
    //     string tituloNota = Console.ReadLine();

    //     System.Console.WriteLine("texto nota");
    //     string textoNota = Console.ReadLine();

    //     System.Console.WriteLine("donde lo guardas 1 o 2");
    //     string opcionArchivo = Console.ReadLine();

    //     switch (opcionArchivo)
    //     {
    //         case "1":archivoSeleccionado = archivo1;break;
    //         case "2":archivoSeleccionado = archivo2;break;
    //         default: System.Console.WriteLine("no se ha selecionado ninguna opcion correcta");return;
    //     }

    //     StreamWriter archivo = new StreamWriter(archivoSeleccionado);
    //     archivo.WriteLine("{0}{1}",tituloNota,textoNota);
    //     archivo.Close();

    }
}