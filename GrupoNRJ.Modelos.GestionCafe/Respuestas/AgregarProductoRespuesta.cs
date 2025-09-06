// <copyright file="AgregarProductoRespuesta.cs" company="GrupoAnalisis">
// Copyright (c) GrupoAnalisis. All rights reserved.
// </copyright>

namespace GrupoNRJ.Modelos.GestionCafe.Respuestas
{
    public class AgregarProductoRespuesta
    {
        public AgregarProductoRespuesta()
        {
            this.RegistroIngresadoCorrectamente = false;
            this.Mensaje = string.Empty;
        }

        public bool RegistroIngresadoCorrectamente { get; set; }

        public string Mensaje { get; set; }
    }
}
