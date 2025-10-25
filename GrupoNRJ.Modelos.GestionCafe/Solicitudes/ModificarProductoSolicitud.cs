// <copyright file="ModificarProductoSolicitud.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Solicitudes
{
    public class ModificarProductoSolicitud
    {
        public ModificarProductoSolicitud()
        {
            this.IdProducto = 0;
            this.Nombre = string.Empty;
            this.GranoId = 0;
            this.ValorMinimo = 0;
        }

        public int IdProducto { get; set; }

        public string Nombre { get; set; }

        public int GranoId { get; set; }

        public double ValorMinimo { get; set; }
    }
}
