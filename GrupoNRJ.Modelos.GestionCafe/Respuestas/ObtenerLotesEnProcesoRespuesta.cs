// <copyright file="ObtenerLotesEnProcesoRespuesta.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Respuestas
{
    public class ObtenerLotesEnProcesoRespuesta
    {
        public ObtenerLotesEnProcesoRespuesta()
        {
            this.IdLote = 0;
            this.TipoGrano = string.Empty;
            this.TipoTueste = string.Empty;
            this.EstadoActual = 0;
            this.FechaUltimoCambio = default(DateTime);
            this.Situacion = string.Empty;
        }

        public int IdLote { get; set; }

        public string TipoGrano { get; set; }

        public string TipoTueste { get; set; }

        public int EstadoActual { get; set; }

        public DateTime FechaUltimoCambio { get; set; }

        public string Situacion { get; set; }
    }
}
