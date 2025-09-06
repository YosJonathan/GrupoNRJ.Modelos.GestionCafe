// <copyright file="AgregarMovimientoSolicitud.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Solicitudes
{
    public class AgregarMovimientoSolicitud
    {
        public AgregarMovimientoSolicitud()
        {
            this.IdProducto = 0;
            this.TipoMovimiento = 0;
            this.Cantidad = 0;
        }

        public int IdProducto { get; set; }

        public int TipoMovimiento { get; set; }

        public double Cantidad { get; set; }
    }
}
