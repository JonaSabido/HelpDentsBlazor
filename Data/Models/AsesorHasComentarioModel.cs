namespace HelpDentsProyecto.Data.Models
{
    public class AsesorHasComentarioModel
    {
        public int Id { get; set; }
        public int Asesor_idAsesor { get; set; }
        public int Comentario_IdComentario { get; set; }
    }
}
