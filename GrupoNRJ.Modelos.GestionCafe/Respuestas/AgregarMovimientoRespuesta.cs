// <copyright file="AgregarMovimientoRespuesta.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Respuestas
{
    public class AgregarMovimientoRespuesta
    {
        public AgregarMovimientoRespuesta()
        {
            this.Codigo = 0;
            this.Mensaje = string.Empty;
        }

        public int Codigo { get; set; }

        public string Mensaje { get; set; }
    }
}
