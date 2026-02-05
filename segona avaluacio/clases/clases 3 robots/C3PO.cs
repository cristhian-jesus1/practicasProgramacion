class C3PO : Robot
{
    string Idiomas;

    public C3PO (string nombre, string modelo, string idiomas) 
    : base (nombre, modelo)
    {
        Idiomas = idiomas;
    }

    static void AddIdioma()
    {
        string [] idiomas = ["español","ingles","aleman"];

        Random rndidioma = new Random();

        string newIdioma = idiomas[rndidioma.Next(idiomas.Length)];

        System.Console.WriteLine($"Nuevo idioma generado {newIdioma}");
    } 

    public static void Saludar()
    {
        if (AddIdioma().Idiomas== "español")
        {
            System.Console.WriteLine($"Hola");

        }else if (AddIdioma(). == "ingles")
        {
            System.Console.WriteLine($"Hi");

        }else
        {
            System.Console.WriteLine($"hallo");
        }
    }
    

}