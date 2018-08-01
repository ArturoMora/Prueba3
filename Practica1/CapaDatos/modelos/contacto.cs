using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.modelos
{
    public class Contacto
    {
        [Key]
        public int contactoId { get; set; }
        public string nombre { get; set; }
        public string apellidopaterno { get; set; }
        public string apellidomaterno { get; set; }
        public int edad { get; set; }
        public string telefono { get; set; }

    }
}
