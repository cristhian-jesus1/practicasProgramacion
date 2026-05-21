using System.Text.RegularExpressions;
using Microsoft.VisualBasic.FileIO;

internal class Program
{
    private static void Main(string[] args)
    {
        string texto = @"En una aplicación común es necesario validar distintos tipos de datos antes de procesarlos. 
        Por ejemplo, un correo electrónico válido como usuario@correo.com permite identificar correctamente al usuario, mientras que formatos incorrectos como usuario@correo no deberían aceptarse. 
        También es importante verificar números de teléfono como 123-456-7890, ya que formatos sin separadores como 1234567890 pueden generar errores. 
        En cuanto a fechas, una entrada como 29/02/2024 sigue el formato correcto, pero valores como 31/13/2023 no son válidos. 
        Las direcciones IP como 192.168.1.1 identifican dispositivos en red, a diferencia de valores erróneos como 999.999.1.1. 
        Para direcciones, un código postal como 08001 es válido, mientras que 1234 no cumple con la longitud requerida. 
        Si se solicita una palabra, entradas como Hola son correctas, pero Hola123 no deberían permitirse. 
        En datos numéricos, un entero positivo como 123 es válido, mientras que -123 o 12.5 no lo son. 
        Las URLs como http://www.ejemplo.com permiten acceder a recursos web, a diferencia de formatos incompletos como http:/ejemplo. 
        En diseño, colores como #A3C1D7 son válidos en formato hexadecimal, pero valores como #ZZZZZZ no lo son. 
        Finalmente, números decimales como 12.34 son correctos, mientras que 12 o 12,34 no cumplen con el formato esperado.";


        string patternCorreo = @"[A-Za-z]+@[A-Za-z]+\.[A-Za-z]{2,3}";
        MatchCollection matchesCorreo = Regex.Matches(texto, patternCorreo);
        

        string patternNumeroTelefono = @"\d{3}-\d{3}-\d{4}";
        MatchCollection matchesTelefono = Regex.Matches(texto, patternNumeroTelefono);

        string patternFecha = @"\d{2}/\d{2}/\d{4}";
        MatchCollection matchesFecha = Regex.Matches(texto, patternFecha);

        string patternIP = @"\d{1,3}(\.\d{1,3}){3}";
        MatchCollection matchesIP = Regex.Matches(texto, patternIP);

        string patternCP = @"\b\d{5}\b";
        MatchCollection matchesCP = Regex.Matches(texto, patternCP);

        string patternPalabra = @"\b[A-Za-z]+\b";
        MatchCollection matchesPalabra = Regex.Matches(texto, patternPalabra);

        string patternURL = @"http:\/\/[A-Za-z\.]+";
        MatchCollection matchesURL = Regex.Matches(texto, patternURL);
    }
}

