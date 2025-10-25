namespace GrupoNRJ.Modelos.GestionCafe.Solicitudes
{
    public class LoginSolicitud
    {
        public LoginSolicitud()
        {
            this.Username = string.Empty;
            this.Password = string.Empty;
        }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
