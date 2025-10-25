// <copyright file="ProductoSolicitud.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Solicitudes
{
    public class ProductoSolicitud
    {
        public ProductoSolicitud()
        {
            this.Codigo = 0;
            this.Descripcion = string.Empty;
        }

        public int Codigo { get; set; }

        public string Descripcion { get; set; }
    }
}
