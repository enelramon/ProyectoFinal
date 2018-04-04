using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public int ClienteId { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            ClienteId = 0;
            Usuario = string.Empty;
            Clave = string.Empty;
        }

        public Usuarios(int usuarioId, int clienteId,string usuario, string clave)
        {
            UsuarioId = usuarioId;
            ClienteId = clienteId;
            Usuario = usuario;
            Clave = clave;
        }
    }
}
