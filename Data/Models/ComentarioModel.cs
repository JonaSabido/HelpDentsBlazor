namespace HelpDentsProyecto.Data.Models
{
    public class ComentarioModel
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string? Nombres{get; set;}
        public string? Apellidos{get; set;}
        public string? Descripcion{get; set;}
    }
}