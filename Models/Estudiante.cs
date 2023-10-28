using System.ComponentModel.DataAnnotations;

namespace ApiEmpresa.Models;
public class Estudiante{
    [Key]
    public int id_estudiante { get; set; }
    public string? carne { get; set; }
    public string? nombres { get; set; }
    public string? apellidos { get; set; }
    public string? direccion { get; set; }
    public string? telefono { get; set; }
    public string? correo_electronico { get; set; }
    public DateTime? fecha_nacimiento { get; set; }


}