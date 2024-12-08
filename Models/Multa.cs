namespace AppDIGESETT.Models
{
    public class Multa
    {
        public int Id { get; set; }
        public string Cedula { get; set; } ="";
        public string Nombre { get; set; }="";
        public string Concepto { get; set; }="";
        public string Descripcion { get; set; }="";
        public string Coordenadas { get; set; }="";
        public string Foto { get; set; }="";
        public DateTime Fecha { get; set; }
        public string Estado { get; set; } ="";// Activa, Pagada, Perdonada
        public int Monto { get; set; } = 0;
    }
}
