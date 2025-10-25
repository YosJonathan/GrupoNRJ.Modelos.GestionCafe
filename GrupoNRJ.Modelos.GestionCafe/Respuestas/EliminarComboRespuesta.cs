// <copyright file="EliminarComboRespuesta.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Respuestas
{
    public class EliminarComboRespuesta
    {
        public EliminarComboRespuesta()
        {
            this.ComboEliminadoExitosamente = false;
            this.Mensaje = string.Empty;
        }

        public bool ComboEliminadoExitosamente { get; set; }

        public string Mensaje { get; set; }
    }
}
