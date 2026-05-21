using System.Data.Common;

internal class Program
{
    private static void Main(string[] args)
    {




        List<Persona> personas = new List<Persona>
        {
            new("jennifer", 30),
            new("Amine", 31),
            new("Cristian", 25),
            new("Angelo", 36),
            new("Ian", 25),
            new("Lis", 30),
            new("Chorouq", 30),
            new("Ahmed", 31),
            new("Chams", 25),
            new("Lisbeth", 36),
            new("Dani", 25),
            new("Yassen", 30)
        };

        // 1.Encuentra el nombre de la persona mas joven en la lista personas.
        var masJoven = (from persona in personas
                        orderby persona.Edad
                        select persona).First();
        System.Console.WriteLine($"{masJoven.Nombre}{masJoven.Edad}");
        // 2.Calcula la edad promedio de todas las personas en la lista personas.
        var promedioEdad = (from persona in personas
                            select persona.Edad).Average();

        // 3.Encuentra todas las personas mayores de 25 años en la lista personas y ordenalas alfabeticamente por nombre.
        var mayor25 = ( from persona in personas 
                        where persona.Edad>25
                        orderby persona.Nombre ascending
                        select persona);

        foreach (var item in mayor25)
        {
            System.Console.WriteLine($"{item.Nombre}-{item.Edad}");
        }

        // 4.Encuentra todas las personas cuyo nombre comienza con la letra "M" en la lista personas y ordÃ©nalas por edad de forma descendente.
        var empiezaM = (from persona in personas
                        where persona.Nombre.StartsWith("M")
                        orderby persona.Edad descending
                        select persona);

        foreach (var item in empiezaM)
        {
            System.Console.WriteLine($"{item.Nombre}-{item.Edad}");
        }
        // 5.Verifica si todas las personas en la lista personas son mayores de 18 años.
        var Verifica18 = (from persona in personas
                            where persona.Edad<18
                            select persona).Count();
        if (Verifica18>0)
        {
            System.Console.WriteLine("hay menores");
        }else{System.Console.WriteLine("no hay menores");}

        // 6.Encuentra la persona mÃ¡s joven en la lista personas que tenga un nombre que contenga la letra "a".
        var personaConA = (from persona in personas
                            where persona.Nombre.Contains("a")
                            orderby persona.Edad ascending
                            select persona).First();

        System.Console.WriteLine($"{personaConA.Nombre}");

        // 7.Agrupa las personas en la lista personas por su primera letra de nombre y muestra cuÃ¡ntas personas hay en cada grupo. 
        // 8.Encuentra el nombre de la persona mÃ¡s joven que tenga una edad impar en la lista personas.
        var personaImpar = (from persona in personas
                            where persona.Edad%2!=0
                            orderby persona.Edad
                            select persona).First();
        System.Console.WriteLine(personaImpar.Nombre);
        // 9.Elimina a todas las personas cuyas edades sean multiplos de 5 de la lista personas y muestra la lista resultante
        var eliminarMultiplo = (from persona in personas
                                where persona.Edad %5==0
                                select persona);
        foreach (var item in eliminarMultiplo)
        {
            System.Console.WriteLine($"{item.Nombre}");
        }
        // 10.Calcula la diferencia de edad entre la persona mÃ¡s joven y la persona mÃ¡s vieja en la lista personas.
        var personaJoven = (from persona in personas
                                orderby persona.Edad
                                select persona.Edad).First();
        var personaVieja = (from persona in personas 
                            orderby persona.Edad descending
                            select persona.Edad).First();
        var diferencia = personaVieja - personaJoven;
        System.Console.WriteLine($"{diferencia}");


        // Obtén las personas cuya edad esté entre 26 y 35.
        var edadEntre = (from persona in personas
                            where persona.Edad>26 & persona.Edad>35
                            select persona);
        foreach (var item in edadEntre)
        {
            System.Console.WriteLine($"{item.Nombre}-{item.Edad}");
        }








        List <Persona2> personas2 = new List<Persona2> 
        { 
            new Persona2 { Id = 1, Nombre = "Ana", IdCiudad = 1 }
        };
        List<Ciudad> ciudades = new List<Ciudad> 
        {
            new Ciudad { IdCiudad = 1, NombreCiudad = "Madrid" }
        };

        var resultado = (from persona in personas2 join ciudad in ciudades
                        on persona.IdCiudad equals ciudad.IdCiudad
                        select new {persona.Nombre , ciudad.NombreCiudad});
        foreach (var item in resultado)
        {
            System.Console.WriteLine($"{item.Nombre}{item.NombreCiudad}");
        }
        // List<int> numeros = new List<int> { 5, 8, 12, 15, 20 };

        // int primerMayorA10 = numeros.First(n => n > 10);

        // int primerMayor102 = (from numero in numeros
        //                         where numero > 10
        //                         select numero ).First();
        // System.Console.WriteLine($"{primerMayorA10}{primerMayor102}");

    }

    class Persona
    {
        public string Nombre;
        public int Edad;

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public void showdata()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        }
    }

    class Persona2
    {
        public int Id;
        public string Nombre;
        public int IdCiudad;
        // public int Edad;

        public Persona2(int id =1, string nombre = "Ana",int idCiudad = 1)
        {
            Id = id;
            Nombre = nombre;
            IdCiudad = idCiudad;
            // Edad = edad;
        }

        // public void showdata()
        // {
        //     Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        // }
    }

    class Ciudad
    {
        public int IdCiudad;
        public string NombreCiudad;

        public Ciudad(int idCiudad = 1,string nombreCiudad = "Madrid")
        {
            IdCiudad=idCiudad;
            NombreCiudad=nombreCiudad;
        }
    }
}