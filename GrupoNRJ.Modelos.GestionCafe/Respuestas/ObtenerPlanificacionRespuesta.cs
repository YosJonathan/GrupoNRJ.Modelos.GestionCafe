namespace GrupoNRJ.Modelos.GestionCafe.Respuestas
{
    public class ObtenerPlanificacionRespuesta
    {
        public ObtenerPlanificacionRespuesta()
        {
            this.IdPlanificacion = 0;
            this.IdLote = 0;
            this.Estado = string.Empty;
            this.FechaInicio = string.Empty;
            this.FechaFin = string.Empty;
        }

        public int IdPlanificacion { get; set; }

        public int IdLote { get; set; }

        public string Estado { get; set; }

        public string FechaInicio { get; set; }

        public string FechaFin { get; set; }
    }
}
