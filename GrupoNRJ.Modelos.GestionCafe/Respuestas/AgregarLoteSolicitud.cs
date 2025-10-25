// <copyright file="AgregarLoteSolicitud.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Respuestas
{
    public class AgregarLoteSolicitud
    {
        public AgregarLoteSolicitud()
        {
            this.Cantidad = 0;
            this.TipoGrano = string.Empty;
            this.TipoTueste = string.Empty;
        }

        public decimal Cantidad { get; set; }

        public string TipoGrano { get; set; }

        public string TipoTueste { get; set; }
    }
}
