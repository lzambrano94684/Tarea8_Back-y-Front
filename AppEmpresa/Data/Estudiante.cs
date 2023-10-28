namespace AppEmpresa.Data;
using System.Text.Json.Serialization;

    public class Estudiante
    {

        [JsonPropertyName("id_estudiante")]
        public int Id { get; set; }

        [JsonPropertyName("carne")]
        public string? carne { get; set; }

        [JsonPropertyName("nombres")]
        public string? nombres { get; set; }

        [JsonPropertyName("apellidos")]
        public string? apellidos { get; set; }
        
        [JsonPropertyName("direccion")]
        public string? direccion { get; set; }

        [JsonPropertyName("telefono")]
        public string? telefono { get; set; }

        [JsonPropertyName("correo_electronico")]
        public string? correo_electronico { get; set; }

        [JsonPropertyName("fecha_nacimiento")]
        public DateTime? fecha_nacimiento { get; set; }





    }