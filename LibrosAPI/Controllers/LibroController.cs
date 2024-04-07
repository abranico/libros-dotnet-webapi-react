using Microsoft.AspNetCore.Mvc;
using LibrosAPI.Models;
using LibrosAPI.Services;
using LibrosAPI.Helpers;

namespace LibrosAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LibroController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Libro>> GetLibros()
    {
        return Ok(LibrosDataStore.Current.Libros);
    }

    [HttpGet("{libroId}")]
    public ActionResult<Libro> GetLibro(int libroId)
    {
        var libro = LibrosDataStore.Current.Libros.FirstOrDefault(x => x.Id == libroId);

        if (libro == null) return NotFound(Mensajes.Libro.NotFound);

        return Ok(libro);
    }

    [HttpPost]
    public ActionResult<Libro> PostLibro(LibroInsert libroInsert)
    {   
        int libroMaxId = LibrosDataStore.Current.Libros.Max(x => x.Id);

        var nuevoLibro = new Libro(){
            Id = libroMaxId + 1,
            Titulo = libroInsert.Titulo,
            Autor = libroInsert.Autor,
            Genero = libroInsert.Genero,
            FechaPublicacion = libroInsert.FechaPublicacion
        };

        LibrosDataStore.Current.Libros.Add(nuevoLibro);

        return CreatedAtAction(
            nameof(GetLibro),
            new { libroId = nuevoLibro.Id + 1 },
            nuevoLibro
        );
    }
}