// <copyright file="ObtenerProduccionPorAreaRespuesta.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Respuestas
{
    public class ObtenerProduccionPorAreaRespuesta
    {
        public ObtenerProduccionPorAreaRespuesta()
        {
            this.IdLote = 0;
            this.Estado = 0;
            this.Area = string.Empty;
        }

        public int IdLote { get; set; }

        public int Estado { get; set; }

        public string Area { get; set; }
    }
}
