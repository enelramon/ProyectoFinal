using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Proyecto_Final.Entidades;

namespace Proyecto_Final.DAL
{
    public class ContextoGenerico<TEntity> : DbContext where TEntity : class
    {
        public ContextoGenerico() : base("ConStr")
        {

        }

        public DbSet<TEntity> Entidad { get; set; } 
        public DbSet<FacturaDetalles> Detalle { get; set; }
    }
}
