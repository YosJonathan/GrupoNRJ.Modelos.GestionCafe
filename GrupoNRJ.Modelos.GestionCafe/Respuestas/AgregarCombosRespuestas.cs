// <copyright file="AgregarCombosRespuestas.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Respuestas
{
    public class AgregarCombosRespuestas
    {
        public AgregarCombosRespuestas()
        {
            this.Mensaje = string.Empty;
            this.ComboAgregado = false;
        }

        public bool ComboAgregado { get; set; }

        public string Mensaje { get; set; }
    }
}
