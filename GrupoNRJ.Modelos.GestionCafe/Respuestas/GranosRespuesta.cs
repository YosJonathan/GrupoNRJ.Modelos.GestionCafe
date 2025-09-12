// <copyright file="GranosRespuesta.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Respuestas
{
    public class GranosRespuesta
    {
        public GranosRespuesta()
        {
            this.IdGranos = 0;
            this.Nombre = string.Empty;
        }

        public int IdGranos { get; set; }

        public string Nombre { get; set; }
    }
}
