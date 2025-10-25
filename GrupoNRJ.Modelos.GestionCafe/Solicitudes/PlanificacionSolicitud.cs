// <copyright file="PlanificacionSolicitud.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Solicitudes
{
    public class PlanificacionSolicitud
    {
        public PlanificacionSolicitud()
        {
            this.IdPlani = 0;
            this.IdLote = 0;
            this.IdEstado = 0;
            this.FechaEstimada = default(DateTime);
            this.FechaFinEstimada = default(DateTime);
        }

        public int IdPlani { get; set; }

        public int IdLote { get; set; }

        public int IdEstado { get; set; }

        public DateTime? FechaEstimada { get; set; }

        public DateTime? FechaFinEstimada { get; set; }
    }
}
