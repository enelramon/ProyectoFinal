using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Entidades
{
    public class Facturas
    {
        [Key]
        public int FacturaId { get; set; }
        public int ClienteId { get; set; }
        public DateTime Fecha { get; set; }
        public Decimal Monto { get; set; }
        public virtual List<FacturaDetalles> Detalles { get; set; }

        public Facturas()
        {
            FacturaId = 0;
            ClienteId = 0;
            Fecha = DateTime.Now;
            Monto = 0;
            Detalles = new List<FacturaDetalles>();
        }

        public Facturas(int facturaId, int clienteId, DateTime fecha, Decimal monto, List<FacturaDetalles> detalles)
        {
            FacturaId = facturaId;
            ClienteId = clienteId;
            Fecha = fecha;
            Monto = monto;
            Detalles = detalles;
        }
    }
}
