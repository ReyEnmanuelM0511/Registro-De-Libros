namespace RegistrodeLibros.Models;
using System.ComponentModel.DataAnnotations;

public class Partidas
{
    [Key]
    public int JugadorId { get; set; }
    public int Puntaje { get; set; }

    public Jugadores? Jugadores;
}