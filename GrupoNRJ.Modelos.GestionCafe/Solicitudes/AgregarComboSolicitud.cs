// <copyright file="AgregarComboSolicitud.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Solicitudes
{
    public class AgregarComboSolicitud
    {
        public AgregarComboSolicitud()
        {
            this.Nombre = string.Empty;
            this.Cafe = new();
            this.Tasa = new();
            this.Filtro = new();
        }

        public string Nombre { get; set; }

        public ProductoSolicitud Cafe { get; set; }

        public ProductoSolicitud Tasa { get; set; }

        public ProductoSolicitud Filtro { get; set; }
    }
}
