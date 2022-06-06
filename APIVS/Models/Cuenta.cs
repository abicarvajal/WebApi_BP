using System.ComponentModel.DataAnnotations;

namespace APIVS.Models
{
    public class Cuenta
    {
        public int id { get; set; }
        [StringLength(200)]
        public string numeroCuenta { get; set; }
        [StringLength(32)]
        public string tipoCuenta { get; set; }
        public double saldo { get; set; }
    }
}
