using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Entidades
{
    public class Paquetes
    {
        [Key]
        public int PaqueteId { get; set; }
        public int ClienteId { get; set; }
        public int TransporteId { get; set; }
        public string Estado { get; set; }
        public string Tracking { get; set; }
        public string Contenido { get; set; }
        public string Proveedor { get; set; }
        public string Transportista { get; set; }
        public double Peso { get; set; }

        public Paquetes(int paqueteId, int clienteId, int transporteId, string estado, string tracking, string contenido, string proveedor, string transportista, double peso)
        {
            PaqueteId = paqueteId;
            ClienteId = clienteId;
            TransporteId = transporteId;
            Estado = estado;
            Tracking = tracking;
            Contenido = contenido;
            Proveedor = proveedor;
            Transportista = transportista;
            Peso = peso;
        }

        public Paquetes()
        {
            PaqueteId = 0;
            ClienteId = 0;
            TransporteId = 0;
            Estado = string.Empty;
            Tracking = string.Empty;
            Contenido = string.Empty;
            Proveedor = string.Empty;
            Transportista = string.Empty;
            Peso = 0;
        }
    }
}
