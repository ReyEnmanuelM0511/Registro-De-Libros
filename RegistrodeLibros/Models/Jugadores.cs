namespace RegistrodeLibros.Models;
using System.ComponentModel.DataAnnotations;

public class Jugadores
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "El campo de Nombre es obligatorio")]
    public string? Nombre { get; set; }
    public int Ranking { get; set; }

}

