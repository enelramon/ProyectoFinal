using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final.Entidades;
using Proyecto_Final.BLL;

namespace Proyecto_Final.Registros
{
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            UsuarioIdnumericUpDown.Value = 0;
            UsuariotextBox.Text = string.Empty;
            ClavetextBox.Text = string.Empty;
            ClienteIdnumericUpDown.Value = 0;
            ClienteNombrestextBox.Text = string.Empty;
            errorProvider.Clear();
        }

        private Usuarios LlenaClase()
        {
            return new Usuarios(
                (UsuarioIdnumericUpDown.Value == 0) ? 0 : (int)UsuarioIdnumericUpDown.Value,
                (int)ClienteIdnumericUpDown.Value,
                UsuariotextBox.Text,
                ClavetextBox.Text
                );
        }

        private bool CanSave()
        {
            bool flag = true;
            if (ClienteIdnumericUpDown.Value == 0 && ClienteNombrestextBox.Text == string.Empty)
            {
                errorProvider.SetError(BuscarClientebutton, "Debe especificar el cliente de este usuario");
                flag = false;
            }

            if (UsuariotextBox.Text == string.Empty)
            {
                errorProvider.SetError(UsuariotextBox, "Ingrese un nombre de usuario");
                flag = false;
            }

            if (ClavetextBox.Text == string.Empty)
            {
                errorProvider.SetError(ClavetextBox, "Ingrese una clave");
                flag = false;
            }
            return flag;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Usuarios us = GenericBLL.Buscar<Usuarios>((int)UsuarioIdnumericUpDown.Value);
            if (CanSave())
            {
                if (us == null)
                {
                    if (GenericBLL.Guardar<Usuarios>(LlenaClase()))
                    {
                        MessageBox.Show("Usuario registrado");
                        Limpiar();
                    }
                    else
                        MessageBox.Show("No se pudo registrar el usuario");
                }
                else
                {
                    if (GenericBLL.Guardar<Usuarios>(LlenaClase()))
                    {
                        MessageBox.Show("Se modifico el usuario");
                        Limpiar();
                    }
                    else
                        MessageBox.Show("No se pudo modificar el usuario");
                }
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if(GenericBLL.Eliminar<Usuarios>((int)UsuarioIdnumericUpDown.Value))
                MessageBox.Show("Usuario eliminado");
            else
                MessageBox.Show("El usuario no fue eliminado");
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Usuarios us = GenericBLL.Buscar<Usuarios>((int)UsuarioIdnumericUpDown.Value);
            if (us != null)
            {
                UsuarioIdnumericUpDown.Value = us.UsuarioId;
                UsuariotextBox.Text = us.Usuario;
                ClavetextBox.Text = us.Clave;
            }
            else
                MessageBox.Show("Este usuario no existe");
        }

        private void BuscarClientebutton_Click(object sender, EventArgs e)
        {
            Clientes c = GenericBLL.Buscar<Clientes>((int)ClienteIdnumericUpDown.Value);
            if (c != null)       
                ClienteNombrestextBox.Text = c.Nombres;
            else
                MessageBox.Show("Este cliente no existe");
        }

        private void UsuariotextBox_TextChanged(object sender, EventArgs e)
        {
            if (GenericBLL.GetList<Usuarios>(x => x.Usuario.Equals(UsuariotextBox.Text)).Count > 0)
                errorProvider.SetError(UsuariotextBox,"Este usuario ya existe");
            else
                errorProvider.SetError(UsuariotextBox, "");
        }

        private void ClienteNombrestextBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(BuscarClientebutton, "");
        }

        private void ClavetextBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(ClavetextBox, "");
        }
    }
}
