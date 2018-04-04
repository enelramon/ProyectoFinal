using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Entidades
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public int Edad { get; set; }
        public char Sexo { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Ciudad { get; set; }

        public Clientes()
        {
            ClienteId = 0;
            Nombres = string.Empty;
            Edad = 0;
            Sexo = ' ';
            Telefono = string.Empty;
            Celular = string.Empty;
            Email = string.Empty;
            Ciudad = string.Empty;
        }

        public Clientes(int clienteId, string nombres, int edad, char sexo, string telefono, string celular, string email, string ciudad)
        {
            ClienteId = clienteId;
            Nombres = nombres;
            Edad = edad;
            Sexo = sexo;
            Telefono = telefono;
            Celular = celular;
            Email = email;
            Ciudad = ciudad;
        }       
    }
}
