using System.ComponentModel.DataAnnotations;

namespace HelpDentsProyecto.Data.Models
{
    public class AsesorModel
    {
        public int Id { get; set; }
        public int UsuarioIdUsuario { get; set; }
        public string? Nombres{get; set;}
        public string? Apellidos{get; set;}
        public string? Especialidad{get; set;}
        public string? Turno{get; set;}
        public double? Costo{get; set;}
        public string? Telefono{get; set;}
        public string? Facebook{get; set;}
        public string? Instagram{get; set;}
        public string? Youtube{get; set;}
        public string? Twitter{get; set;}
        public string? Descripcion{get; set;}

    }
}