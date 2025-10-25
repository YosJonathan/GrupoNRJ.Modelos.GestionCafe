// <copyright file="ListadoCatalogoProductosRespuesta.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Respuestas
{
    public class ListadoCatalogoProductosRespuesta
    {
        public ListadoCatalogoProductosRespuesta()
        {
            this.Cafe = new();
            this.Tasa = new();
            this.Filtros = new();
        }

        public List<CatalogoProductoResponse> Cafe { get; set; }

        public List<CatalogoProductoResponse> Tasa { get; set; }

        public List<CatalogoProductoResponse> Filtros { get; set; }
    }
}
