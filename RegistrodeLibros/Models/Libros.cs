namespace Models;
using System.ComponentModel.DataAnnotations;
public class Libros
{
    [Key]
    public int LibroID { get; set;}
    public string? Titulo {get; set;}
    public string? Autor {get; set;}
    public string? AnoPublicacion {get; set;}
}