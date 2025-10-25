// <copyright file="GeneracionReportesRespuesta.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Respuestas
{
    public class GeneracionReportesRespuesta
    {
        public GeneracionReportesRespuesta()
        {
            this.ReportesPorLotes = new();
            this.ReportesPorAreas = new();
        }

        public List<ObtenerLotesEnProcesoRespuesta> ReportesPorLotes { get; set; }

        public List<ObtenerProduccionPorAreaRespuesta> ReportesPorAreas { get; set; }
    }
}
