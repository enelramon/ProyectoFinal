using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Entidades
{
    public class UsuarioEmpleados
    {
        [Key]
        public int UsuarioEmpleadoId { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }

        public UsuarioEmpleados()
        {
            UsuarioEmpleadoId = 0;
            Usuario = string.Empty;
            Clave = string.Empty;
        }

        public UsuarioEmpleados(int usuarioId, string usuario, string clave)
        {
            UsuarioEmpleadoId = usuarioId;
            Usuario = usuario;
            Clave = clave;
        }
    }
}
