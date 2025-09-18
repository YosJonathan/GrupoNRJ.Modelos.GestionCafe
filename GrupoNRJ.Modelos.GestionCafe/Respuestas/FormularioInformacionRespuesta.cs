// <copyright file="FormularioInformacionRespuesta.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Respuestas
{
    public class FormularioInformacionRespuesta
    {
        public FormularioInformacionRespuesta()
        {
            this.IdFormulario = 0;
            this.Nombre = string.Empty;
            this.Fecha = default(DateTime);
        }

        public int IdFormulario { get; set; }

        public string Nombre { get; set; }

        public DateTime Fecha { get; set; }
    }
}
