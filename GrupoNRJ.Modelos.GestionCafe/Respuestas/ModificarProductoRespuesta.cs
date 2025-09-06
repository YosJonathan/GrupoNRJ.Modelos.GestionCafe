// <copyright file="ModificarProductoRespuesta.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Respuestas
{
    public class ModificarProductoRespuesta
    {
        public ModificarProductoRespuesta()
        {
            this.RegistroModificadoExitosamente = false;
            this.Mensaje = string.Empty;
        }

        public bool RegistroModificadoExitosamente { get; set; }

        public string Mensaje { get; set; }
    }
}
