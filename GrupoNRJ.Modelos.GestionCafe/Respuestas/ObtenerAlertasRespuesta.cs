// <copyright file="ObtenerAlertasRespuesta.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Respuestas
{
    public class ObtenerAlertasRespuesta
    {
        public ObtenerAlertasRespuesta()
        {
            this.IdProducto = 0;
            this.NombreProducto = string.Empty;
            this.AlertaStock = false;
            this.CantidadMinima = 0;
            this.Existencias = 0;
            this.Mensaje = string.Empty;
        }

        public int IdProducto { get; set; }

        public string NombreProducto { get; set; }

        public bool AlertaStock { get; set; }

        public double CantidadMinima { get; set; }

        public double Existencias { get; set; }

        public string Mensaje { get; set; }
    }
}
