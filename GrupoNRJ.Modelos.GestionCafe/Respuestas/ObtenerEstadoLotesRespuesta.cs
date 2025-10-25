// <copyright file="ObtenerEstadoLotesRespuesta.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Respuestas
{
    public class ObtenerEstadoLotesRespuesta
    {
        public ObtenerEstadoLotesRespuesta()
        {
            this.IdLote = 0;
            this.Cantidad = 0;
            this.TipoGrano = string.Empty;
            this.TipoTueste = string.Empty;
            this.FechaInicio = string.Empty;
            this.FechaFin = string.Empty;
        }

        public int IdLote { get; set; }

        public double Cantidad { get; set; }

        public string TipoGrano { get; set; }

        public string TipoTueste { get; set; }

        public string FechaInicio { get; set; }

        public string FechaFin { get; set; }
    }
}
