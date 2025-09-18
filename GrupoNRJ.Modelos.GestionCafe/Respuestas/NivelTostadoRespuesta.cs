// <copyright file="NivelTostadoRespuesta.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Respuestas
{
    public class NivelTostadoRespuesta
    {
        public NivelTostadoRespuesta()
        {
            this.IdNivelTostado = 0;
            this.Nombre = string.Empty;
        }

        public int IdNivelTostado { get; set; }

        public string Nombre { get; set; }
    }
}
