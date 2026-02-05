class Robot
{
    string nombre;
    string modelo;


    public Robot(string nombre, string modelo)
    {
        this.nombre = nombre;
        this.modelo = modelo;
    }

    public static string GetNombre()
    {

        Random rnd = new();
        string[] letras = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M"];

        string letra1 = letras[rnd.Next(letras.Length)];
        string letra2 = letras[rnd.Next(letras.Length)];
        string letra3 = letras[rnd.Next(letras.Length)];
        string nombre = letra1 + letra2 + letra3;

        int numero = rnd.Next(100, 999);

        string nombreCompleto = $"{nombre}-{numero}";

        return nombreCompleto; 


    }

    public static string GetModeloRobot()
    {
        Random random = new  Random();
        string [] modelo = ["R2D2","C3PO","BBB"];

        string modeloRobot = modelo[random.Next(modelo.Length)];
        return modeloRobot;
    }


}