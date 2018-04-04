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
    public partial class rUsuarioEmpleados : Form
    {
        public rUsuarioEmpleados()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            UsuariotextBox.Text = string.Empty;
            ClavetextBox.Text = string.Empty;
            errorProvider.Clear();
        }

        private UsuarioEmpleados LlenaClase()
        {
            return new UsuarioEmpleados(
                (IdnumericUpDown.Value == 0) ? 0 : (int)IdnumericUpDown.Value,
                UsuariotextBox.Text,
                ClavetextBox.Text
                );
        }

        private bool CanSave()
        {
            bool flag = true;
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
            UsuarioEmpleados us = GenericBLL.Buscar<UsuarioEmpleados>((int)IdnumericUpDown.Value);
            if (CanSave())
            {
                if (us == null)
                {
                    if (GenericBLL.Guardar<UsuarioEmpleados>(LlenaClase()))
                    {
                        MessageBox.Show("Usuario registrado");
                        Limpiar();
                    }
                    else
                        MessageBox.Show("No se pudo registrar el usuario");
                }
                else
                {
                    if (GenericBLL.Guardar<UsuarioEmpleados>(LlenaClase()))
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
            if (GenericBLL.Eliminar<UsuarioEmpleados>((int)IdnumericUpDown.Value))
                MessageBox.Show("Usuario eliminado");
            else
                MessageBox.Show("El usuario no fue eliminado");
        }

        private void UsuariotextBox_TextChanged(object sender, EventArgs e)
        {
            if (GenericBLL.GetList<UsuarioEmpleados>(x => x.Usuario.Equals(UsuariotextBox.Text)).Count > 0)
                errorProvider.SetError(UsuariotextBox, "Este usuario ya existe");
            else
                errorProvider.SetError(UsuariotextBox, "");
        }

        private void ClavetextBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(ClavetextBox, "");
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            UsuarioEmpleados us = GenericBLL.Buscar<UsuarioEmpleados>((int)IdnumericUpDown.Value);
            if (us != null)
            {
                UsuariotextBox.Text = us.Usuario;
                ClavetextBox.Text = us.Clave;
            }
            else
                MessageBox.Show("Este usuario no existe");
        }
    }
}
