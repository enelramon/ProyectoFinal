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
    public partial class rTransportes : Form
    {
        public rTransportes()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            TransporteIdnumericUpDown.Value = 0;
            CompaniatextBox.Text = string.Empty;
            TelefonomaskedTextBox.Text = string.Empty;
            errorProvider.Clear();
        }

        private Transportes LlenaClase()
        {
            return new Transportes(
                (TransporteIdnumericUpDown.Value == 0) ? 0 : (int)TransporteIdnumericUpDown.Value,
                CompaniatextBox.Text,
                TelefonomaskedTextBox.Text
                );
        }

        private bool CanSave()
        {
            bool flag = true;
            if (CompaniatextBox.Text == string.Empty)
            {
                errorProvider.SetError(CompaniatextBox, "Ingrese nombre de la compañia");
                flag = false;
            }

            if (!TelefonomaskedTextBox.MaskFull)
            {
                errorProvider.SetError(TelefonomaskedTextBox, "Ingrese el telefono");
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
            Transportes tr = GenericBLL.Buscar<Transportes>((int)TransporteIdnumericUpDown.Value);
            if (CanSave())
            {
                if (tr == null)
                {
                    if (GenericBLL.Guardar<Transportes>(LlenaClase()))
                    {
                        MessageBox.Show("Compañia de transporte registrado");
                        Limpiar();
                    }
                    else
                        MessageBox.Show("No se pudo registrar la compañia transportista");
                }
                else
                {
                    if (GenericBLL.Guardar<Transportes>(LlenaClase()))
                    {
                        MessageBox.Show("Se modifico la compañia transportista");
                        Limpiar();
                    }
                    else
                        MessageBox.Show("No se pudo modificar la compañia transportista");
                }
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (GenericBLL.Eliminar<Transportes>((int)TransporteIdnumericUpDown.Value))
                MessageBox.Show("Esta compañia transportista a sido eliminada");
            else
                MessageBox.Show("Esta compañia transportista no fue eliminado");
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Transportes tr = GenericBLL.Buscar<Transportes>((int)TransporteIdnumericUpDown.Value);
            if (tr != null)
            {
                TransporteIdnumericUpDown.Value = tr.TransporteId;
                CompaniatextBox.Text = tr.Compania;
                TelefonomaskedTextBox.Text = tr.Telefono;
            }
            else
                MessageBox.Show("Esta compañia transportist no existe");
        }

        private void CompaniatextBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(CompaniatextBox,"");
        }

        private void TelefonomaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(TelefonomaskedTextBox, "");
        }
    }
}
