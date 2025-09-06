// <copyright file="ConsultarMovimientosProductoRespuesta.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Respuestas
{
    public class ConsultarMovimientosProductoRespuesta
    {
        public ConsultarMovimientosProductoRespuesta()
        {
            this.IdProducto = 0;
            this.NombreProducto = string.Empty;
            this.TipoMovimiento = string.Empty;
            this.Cantidad = 0;
            this.FechaMovimiento = default(DateTime);
        }

        public int IdProducto { get; set; }

        public string NombreProducto { get; set; }

        public string TipoMovimiento { get; set; }

        public double Cantidad { get; set; }

        public DateTime FechaMovimiento { get; set; }
    }
}
