// <copyright file="EliminarProductoRespuesta.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Respuestas
{
    public class EliminarProductoRespuesta
    {
        public EliminarProductoRespuesta()
        {
            this.RegistroEliminadoExitosamente = false;
            this.Mensaje = string.Empty;
        }

        public bool RegistroEliminadoExitosamente { get; set; }

        public string Mensaje { get; set; }
    }
}
