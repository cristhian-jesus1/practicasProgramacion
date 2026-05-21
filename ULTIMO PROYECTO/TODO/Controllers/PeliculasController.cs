using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using TodoMVC.Data;
using TodoMVC.Models;

namespace TodoMVC.Controllers;

public class PeliculasController : Controller
{
    public IActionResult Index()
    {
        var peliculas = new List<Pelicula>();

        using var conexion = Database.AbrirConexion();
        var sql = "SELECT Id, Titulo, Genero, Anio, Vista FROM Peliculas ORDER BY Id DESC";
        using var comando = new SqliteCommand(sql, conexion);
        using var reader = comando.ExecuteReader();

        while (reader.Read())
        {
            peliculas.Add(new Pelicula
            {
                Id = reader.GetInt32(0),
                Titulo = reader.GetString(1),
                Genero = reader.GetString(2),
                Anio = reader.GetInt32(3),
                Vista = reader.GetInt32(4) == 1
            });
        }

        return View(peliculas);
    }

    public IActionResult Crear()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Crear(Pelicula pelicula)
    {
        if (string.IsNullOrWhiteSpace(pelicula.Titulo) || pelicula.Titulo.Length < 3)
        {
            ViewBag.Error = "El título debe tener al menos 3 caracteres.";
            return View(pelicula);
        }
        if (string.IsNullOrWhiteSpace(pelicula.Genero))
        {
            ViewBag.Error = "El género no puede estar vacío.";
            return View(pelicula);
        }

        using var conexion = Database.AbrirConexion();
        var sql = "INSERT INTO Peliculas (Titulo, Genero, Anio, Vista) VALUES (@titulo, @genero, @anio, 0)";
        using var comando = new SqliteCommand(sql, conexion);
        comando.Parameters.AddWithValue("@titulo", pelicula.Titulo);
        comando.Parameters.AddWithValue("@genero", pelicula.Genero);
        comando.Parameters.AddWithValue("@anio", pelicula.Anio);
        comando.ExecuteNonQuery();

        return RedirectToAction("Index");
    }

    public IActionResult Editar(int id)
    {
        using var conexion = Database.AbrirConexion();
        var sql = "SELECT Id, Titulo, Genero, Anio, Vista FROM Peliculas WHERE Id = @id";
        using var comando = new SqliteCommand(sql, conexion);
        comando.Parameters.AddWithValue("@id", id);
        using var reader = comando.ExecuteReader();

        if (!reader.Read())
            return RedirectToAction("Index");

        var pelicula = new Pelicula
        {
            Id = reader.GetInt32(0),
            Titulo = reader.GetString(1),
            Genero = reader.GetString(2),
            Anio = reader.GetInt32(3),
            Vista = reader.GetInt32(4) == 1
        };

        return View(pelicula);
    }

    [HttpPost]
    public IActionResult Editar(Pelicula pelicula)
    {
        if (string.IsNullOrWhiteSpace(pelicula.Titulo) || pelicula.Titulo.Length < 3)
        {
            ViewBag.Error = "El título debe tener al menos 3 caracteres.";
            return View(pelicula);
        }
        if (string.IsNullOrWhiteSpace(pelicula.Genero))
        {
            ViewBag.Error = "El género no puede estar vacío.";
            return View(pelicula);
        }

        using var conexion = Database.AbrirConexion();
        var sql = "UPDATE Peliculas SET Titulo = @titulo, Genero = @genero, Anio = @anio, Vista = @vista WHERE Id = @id";
        using var comando = new SqliteCommand(sql, conexion);
        comando.Parameters.AddWithValue("@titulo", pelicula.Titulo);
        comando.Parameters.AddWithValue("@genero", pelicula.Genero);
        comando.Parameters.AddWithValue("@anio", pelicula.Anio);
        comando.Parameters.AddWithValue("@vista", pelicula.Vista ? 1 : 0);
        comando.Parameters.AddWithValue("@id", pelicula.Id);
        comando.ExecuteNonQuery();

        return RedirectToAction("Index");
    }

    public IActionResult Marcar(int id)
    {
        using var conexion = Database.AbrirConexion();
        var sql = "UPDATE Peliculas SET Vista = 1 WHERE Id = @id";
        using var comando = new SqliteCommand(sql, conexion);
        comando.Parameters.AddWithValue("@id", id);
        comando.ExecuteNonQuery();

        return RedirectToAction("Index");
    }

    public IActionResult Eliminar(int id)
    {
        using var conexion = Database.AbrirConexion();
        var sql = "DELETE FROM Peliculas WHERE Id = @id";
        using var comando = new SqliteCommand(sql, conexion);
        comando.Parameters.AddWithValue("@id", id);
        comando.ExecuteNonQuery();

        return RedirectToAction("Index");
    }
}
