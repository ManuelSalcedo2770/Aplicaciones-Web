using System.ComponentModel.DataAnnotations;
namespace RazorPagesMovie.Models;

public class Alumnos
{
    public int Id { get; set; }

    public string? Nombre { get; set; }
    [DataType(DataType.Date)]


    public int Edad { get; set; }

    public string? Genero { get; set; }
}


