// <copyright file="CatalogoProductoResponse.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Respuestas
{
    public class CatalogoProductoResponse
    {
        public CatalogoProductoResponse()
        {
            this.Codigo = 0;
            this.Nombre = string.Empty;
        }

        public int Codigo { get; set; }

        public string Nombre { get; set; }
    }
}
