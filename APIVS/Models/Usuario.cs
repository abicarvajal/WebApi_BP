using System.ComponentModel.DataAnnotations;

namespace APIVS.Models
{
    public class Usuario
    {
        public int id { get; set; }
        public int idCuenta { get; set; }
        [StringLength(200)]
        public string nombre { get; set; }
        [StringLength(10)]
        public string ci { get; set; }
        public int edad { get; set; }
    }
}
