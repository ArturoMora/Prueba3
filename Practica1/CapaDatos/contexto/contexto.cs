using CapaDatos.modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.contexto
{
    public class contexto: DbContext
    {
        public contexto() : base("name=cursoContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Empresa> Empresa { get; set; }
    }
}
