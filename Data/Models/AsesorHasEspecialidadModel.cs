namespace HelpDentsProyecto.Data.Models
{
    public class AsesorHasEspecialidadModel
    {
        public int Id {get; set;}
        public int Asesor_idAsesor { get; set; }
        public int Especialidad_idEspecialidad { get; set; }
    }
}
