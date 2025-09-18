// <copyright file="ProductoRespuesta.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Respuestas
{
    public class ProductoRespuesta
    {
        public ProductoRespuesta()
        {
            this.IdProducto = 0;
            this.Nombre = string.Empty;
            this.Grano = string.Empty;
            this.Cantidad = 0;
            this.NivelTostado = string.Empty;
        }

        public int IdProducto { get; set; }

        public string Nombre { get; set; }

        public string Grano { get; set; }

        public double Cantidad { get; set; }

        public string NivelTostado { get; set; }
    }
}
