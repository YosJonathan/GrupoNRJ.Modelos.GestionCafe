// <copyright file="CombosResponse.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Respuestas
{
    public class CombosResponse
    {
        public CombosResponse()
        {
            this.IdCodigoCombo = 0;
            this.Nombre = string.Empty;
            this.Descripcion = string.Empty;
        }

        public int IdCodigoCombo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }
    }
}
