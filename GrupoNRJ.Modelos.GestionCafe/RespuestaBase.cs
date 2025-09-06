namespace GrupoNRJ.Modelos.GestionCafe
{
    public class RespuestaBase<T>
    {
        public RespuestaBase()
        {
            Codigo = 0;
            Mensaje = string.Empty;
            Datos = default;
        }

        public int Codigo { get; set; }
        public string Mensaje { get; set; }
        public T? Datos { get; set; }
    }
}
