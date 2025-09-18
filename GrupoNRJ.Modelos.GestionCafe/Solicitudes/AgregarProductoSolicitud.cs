// <copyright file="AgregarProductoSolicitud.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Solicitudes
{
    public class AgregarProductoSolicitud
    {
        public AgregarProductoSolicitud()
        {
            this.Nombre = string.Empty;
            this.Cantidad = 0;
            this.IdGrano = 0;
            this.ValorMinimo = 0;
            this.Grano = string.Empty;
            this.NivelTostado = 0;
        }

        public string Nombre { get; set; }

        public double Cantidad { get; set; }

        public int IdGrano { get; set; }

        public double ValorMinimo { get; set; }

        public string Grano { get; set; }

        public int NivelTostado { get; set; }
    }
}
