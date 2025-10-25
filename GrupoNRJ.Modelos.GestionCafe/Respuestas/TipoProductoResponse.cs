// <copyright file="TipoProductoResponse.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Respuestas
{
    public class TipoProductoResponse
    {
        public TipoProductoResponse()
        {
            this.IdTipoProducto = 0;
            this.Nombre = string.Empty;
        }

        public int IdTipoProducto { get; set; }

        public string Nombre { get; set; }
    }
}
