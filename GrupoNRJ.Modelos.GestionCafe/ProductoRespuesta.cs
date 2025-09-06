namespace GrupoNRJ.Modelos.GestionCafe
{
    public class ProductoRespuesta
    {
        public ProductoRespuesta()
        {
            Nombre = string.Empty;
            Grano = string.Empty;
            Cantidad = 0;
        }
        public string Nombre { get; set; }
        public string Grano { get; set; }
        public double Cantidad { get; set; }
    }
}
