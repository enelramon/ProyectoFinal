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
using Proyecto_Final.DAL;

namespace Proyecto_Final.Registros
{
    public partial class rClientes : Form
    {
        public rClientes()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            ClienteIdnumericUpDown.Value = 0;
            NombrestextBox.Text = string.Empty;
            EdadnumericUpDown.Value = 1;
            SexocomboBox.SelectedIndex = -1;
            CiudadtextBox.Text = string.Empty;
            TelefonomaskedTextBox.Text = string.Empty;
            CelularmaskedTextBox.Text = string.Empty;
            EmailtextBox.Text = string.Empty;
            errorProvider.Clear();
        }

        private Clientes LlenaClase()
        {
            return new Clientes(
                (ClienteIdnumericUpDown.Value == 0) ? 0 : (int)ClienteIdnumericUpDown.Value,
                NombrestextBox.Text,
                (int)EdadnumericUpDown.Value,
                SexocomboBox.SelectedItem.ToString().ToCharArray()[0],
                TelefonomaskedTextBox.Text,
                CelularmaskedTextBox.Text,
                EmailtextBox.Text,
                CiudadtextBox.Text
                );
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private bool CanSave()
        {
            bool flag = true;
            if (NombrestextBox.Text == string.Empty)
            {
                errorProvider.SetError(NombrestextBox, "Ingrese el nombre del cliente");
                flag = false;
            }

            if (CiudadtextBox.Text == string.Empty)
            {
                errorProvider.SetError(CiudadtextBox, "Ingrese la ciudad donde reside");
                flag = false;
            }

            if (!TelefonomaskedTextBox.MaskFull)
            {
                errorProvider.SetError(TelefonomaskedTextBox, "Ingrese el telefono");
                flag = false;
            }

            if (!CelularmaskedTextBox.MaskFull)
            {
                errorProvider.SetError(CelularmaskedTextBox, "Ingrese el celular");
                flag = false;
            }

            if (EmailtextBox.Text == string.Empty)
            {
                errorProvider.SetError(EmailtextBox, "Ingrese el correo del cliente");
                flag = false;
            }
            return flag;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Clientes c = GenericBLL.Buscar<Clientes>((int)ClienteIdnumericUpDown.Value);
            if (CanSave())
            {
                if (c == null)
                {
                    if (GenericBLL.Guardar<Clientes>(LlenaClase()))
                        MessageBox.Show("El cliente a sido registrado");
                    else
                        MessageBox.Show("No se pudo registrar el cliente");
                }
                else
                {
                    if (GenericBLL.Modificar<Clientes>(LlenaClase()))
                        MessageBox.Show("Se a modificado el este cliente");
                    else
                        MessageBox.Show("El cliente no pudo ser modificado");
                }
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (GenericBLL.Eliminar<Clientes>((int)ClienteIdnumericUpDown.Value))
                MessageBox.Show("Se elimino este cliente");
            else
                MessageBox.Show("No se pudo eliminar este cliente");
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Clientes c = GenericBLL.Buscar<Clientes>((int)ClienteIdnumericUpDown.Value);
            if (c != null)
            {
                NombrestextBox.Text = c.Nombres;
                EdadnumericUpDown.Value = c.Edad;
                SexocomboBox.SelectedIndex = (c.Sexo == 'M') ? 0 : 1;
                CiudadtextBox.Text = c.Ciudad;
                TelefonomaskedTextBox.Text = c.Telefono;
                CelularmaskedTextBox.Text = c.Celular;
                EmailtextBox.Text = c.Email;
            }
        }

        private void EmailtextBox_TextChanged(object sender, EventArgs e)
        {
            if ((!EmailtextBox.Text.Contains("@") || !EmailtextBox.Text.Contains(".com")))
                errorProvider.SetError(EmailtextBox,"Este correo no es valido");
            else
                errorProvider.SetError(EmailtextBox, "");
        }

        private void NombrestextBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(NombrestextBox,"");
        }

        private void CiudadtextBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(CiudadtextBox,"");
        }

        private void TelefonomaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(TelefonomaskedTextBox, "");
        }

        private void CelularmaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.SetError(CelularmaskedTextBox, "");
        }
    }
}
