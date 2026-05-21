internal class Program
{
    private static void Main(string[] args)
    {
        
    }
}


public class Libro
{
    // VARIABLES 
    private string titulo;
    private string autor;
    private string isbn;
    private int numeroPaginas;
    private int yearPublicacion;

    // CONSTRUSCTOR 
    public Libro(string titulo, string autor, string isbn, int numeroPaginas, int yearPublicacion)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.isbn = isbn;
        this.numeroPaginas = numeroPaginas;
        this.yearPublicacion = yearPublicacion;
    }

    // METODO 

    public void ObtenerInfo()
    {
        System.Console.WriteLine($"Titulo {titulo}, autor {autor}, isbn {isbn}, numero de paginas {numeroPaginas}, año de publicacion {yearPublicacion}");
    }

    



}