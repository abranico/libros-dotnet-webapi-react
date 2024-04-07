namespace LibrosAPI.Models;

public class Libro
{
    public int Id { get; set; }

    public string Titulo { get; set; } = string.Empty;

    public string Autor { get; set; } = string.Empty;

    public string Genero { get; set; } = string.Empty;

    public string FechaPublicacion { get; set; } = string.Empty;

}