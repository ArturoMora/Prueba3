using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.modelos
{
 
    [Table("cat_Empresas")]
    public class Empresa
    {
        [Key]
        public int empresaId { get; set; }

        [MaxLength(100)]
        public string nombreEmpresa { get; set; }

        public DateTime fechaRegistro { get; set; }

        public string pais { get; set; }

        [MinLength(7)]
        public string telefono { get; set; }

        public Boolean estado { get; set; }

        public string nombreTitular { get; set; }

        //[ForeignKey("contacto")]
        //public int contactoId { get; set; }
        //public Contacto contacto { get; set; }

    }
}
