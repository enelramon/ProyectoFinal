using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Entidades
{
    public class FacturaDetalles
    {
        [Key]
        public int Id { get; set; }
        public int FacturaId { get; set; }
        public int PaqueteId { get; set; }
        public string Contenido { get; set; }
        public string Proveedor { get; set; }
        public double Peso { get; set; }
        public double Descuento { get; set; }
        public Decimal Precio { get; set; }

        public FacturaDetalles()
        {
            Id = 0;
            FacturaId = 0;
            PaqueteId = 0;
            Contenido = string.Empty;
            Proveedor = string.Empty;
            Peso = 0;
            Descuento = 0;
            Precio = 0;
        }

        public FacturaDetalles(int id, int facturaId, int paqueteId, string contenido, string proveedor, double peso, double descuento, Decimal precio)
        {
            Id = id;
            FacturaId = facturaId;
            PaqueteId = paqueteId;
            Contenido = contenido;
            Proveedor = proveedor;
            Peso = peso;
            Descuento = descuento;
            Precio = precio;
        }
    }
}
