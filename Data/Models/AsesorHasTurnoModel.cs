namespace HelpDentsProyecto.Data.Models
{
    public class AsesorHasTurnoModel
    {
        public int Id { get; set; }
        public int Asesor_idAsesor { get; set; }
        public int Turno_idTurno { get; set; }
    }
}
