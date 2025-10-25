// <copyright file="CatalogoRespuesta.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Respuestas
{
    public class CatalogoRespuesta
    {
        public CatalogoRespuesta()
        {
            this.IdCatalogo = 0;
            this.Nombre = string.Empty;
        }

        public int IdCatalogo { get; set; }

        public string Nombre { get; set; }
    }
}
