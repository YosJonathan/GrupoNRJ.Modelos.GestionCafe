// <copyright file="EliminarProductoSolicitud.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Solicitudes
{
    public class EliminarProductoSolicitud
    {
        public EliminarProductoSolicitud()
        {
            this.IdProducto = 0;
        }

        public int IdProducto { get; set; }
    }
}
