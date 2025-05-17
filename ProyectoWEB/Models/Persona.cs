namespace ProyectoWEB.Models
{
        public class Persona
        {
            public int Id { get; set; }
            public string NombreCompleto { get; set; } = string.Empty;
            public string Usuario { get; set; } = string.Empty;
            public string Contrasena { get; set; } = string.Empty;
            public string Correo { get; set; } = string.Empty;
            public string Sexo { get; set; } = string.Empty;
            public string Ciudad { get; set; } = string.Empty;
            public bool AceptaTerminos { get; set; }
        }
    }