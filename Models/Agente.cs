using System.ComponentModel.DataAnnotations;

namespace AppDIGESETT.Models
{
    public class Agente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La cédula es obligatoria.")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "La clave es obligatoria.")]
        public string Clave { get; set; }
        public string Nombre { get; set; }="";
        public string Apellido { get; set; }="";
        public string Rol { get; set; } = "Agente";
        public bool Activo { get; set; }
    }
}
