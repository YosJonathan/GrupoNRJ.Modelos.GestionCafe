// <copyright file="ConsultarMovimientosProductoSolicitud.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Solicitudes
{
    public class ConsultarMovimientosProductoSolicitud
    {
        public ConsultarMovimientosProductoSolicitud()
        {
            this.IdProducto = 0;
        }

        public int IdProducto { get; set; }
    }
}
