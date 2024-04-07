using System.ComponentModel.DataAnnotations;

namespace LibrosAPI.Models;

public class LibroInsert
{
    
    [Required]
    [MaxLength(100)]
    public string Titulo {get; set;} = string.Empty;

    [Required]
    [MaxLength(100)]
    public string Autor {get; set;} = string.Empty;

    [Required]
    [MaxLength(30)]
    public string Genero {get; set;} = string.Empty;

    [Required]
    [MaxLength(50)]
    public string FechaPublicacion {get; set;} = string.Empty;

}