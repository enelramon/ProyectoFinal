using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Entidades
{
    public class Transportes
    {
        [Key]
        public int TransporteId { get; set; }
        public string Compania { get; set; }
        public string Telefono { get; set; }

        public Transportes()
        {
            TransporteId = 0;
            Compania = string.Empty;
            Telefono = string.Empty;
        }

        public Transportes(int transporteId, string compania, string telefono)
        {
            TransporteId = transporteId;
            Compania = compania;
            Telefono = telefono;
        }
    }
}
