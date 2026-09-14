namespace Models;
using System.ComponentModel.DataAnnotations;
public class Libros
{
    [Key]
    public int LibroID { get; set;}
    [Required(ErrorMessage = "El campo de Titulo es Obligatorio")]
    public string? Titulo {get; set;}
    [Required(ErrorMessage = "El campo de Autor es Requerido")]
    public string? Autor {get; set;}
    [Required(ErrorMessage ="El campo de AnoPublicacion es obligatorio")]
    public string? AnoPublicacion {get; set;}
}