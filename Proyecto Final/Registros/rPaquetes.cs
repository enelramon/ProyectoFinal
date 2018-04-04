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
    public partial class rPaquetes : Form
    {
        public rPaquetes()
        {
            InitializeComponent();
            TransportistacomboBox.DataSource = GenericBLL.GetList<Transportes>(x => 1 == 1).ToList();
            TransportistacomboBox.DisplayMember = "Compania";
            TransportistacomboBox.ValueMember = "Compania";
        }

        private void Limpiar()
        {
            PaqueteIdnumericUpDown.Value = 0;
            ClienteIdnumericUpDown.Value = 0;
            EstatuscomboBox.SelectedIndex = -1;
            TransportistacomboBox.SelectedIndex = -1;
            ClienteNombretextBox.Text = string.Empty;
            TrackingtextBox.Text = string.Empty;
            ContenidotextBox.Text = string.Empty;
            ProveedortextBox.Text = string.Empty;
            PesonumericUpDown.Value = 0;
            errorProvider.Clear();
        }

        private Paquetes LlenaClase()
        {
            return new Paquetes(
                (PaqueteIdnumericUpDown.Value == 0) ? 0 : (int)PaqueteIdnumericUpDown.Value,
                (int)ClienteIdnumericUpDown.Value,
                ((Transportes)TransportistacomboBox.SelectedItem).TransporteId,
                EstatuscomboBox.SelectedItem.ToString(),
                TrackingtextBox.Text,
                ContenidotextBox.Text,
                ProveedortextBox.Text,
                TransportistacomboBox.GetItemText(TransportistacomboBox.SelectedItem),
                (double)PesonumericUpDown.Value
                );
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private bool CanSave()
        {
            bool flag = true;
            if (ClienteIdnumericUpDown.Value == 0 && ClienteNombretextBox.Text == string.Empty)
            {
                errorProvider.SetError(BuscarClientebutton, "Debe especificar el cliente de este paquete");
                flag = false;
            }

            if (EstatuscomboBox.SelectedIndex == -1)
            {
                errorProvider.SetError(EstatuscomboBox, "Debe indicar el estatus de este paquete");
                flag = false;
            }

            if (TrackingtextBox.Text == string.Empty)
            {
                errorProvider.SetError(TrackingtextBox, "Ingresa el numero de tracking");
                flag = false;
            }

            if (ContenidotextBox.Text == string.Empty)
            {
                errorProvider.SetError(ContenidotextBox, "Ingrese el contenido del paquete");
                flag = false;
            }

            if (ProveedortextBox.Text == string.Empty)
            {
                errorProvider.SetError(ProveedortextBox, "Ingrese el proveedor del paquete");
                flag = false;
            }
            return flag;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Paquetes p = GenericBLL.Buscar<Paquetes>((int)PaqueteIdnumericUpDown.Value);
            if (CanSave())
            {
                if (p == null)
                {
                    if (GenericBLL.Guardar<Paquetes>(LlenaClase()))
                    {
                        MessageBox.Show("Paquete guardado");
                        Limpiar();
                    }
                    else
                        MessageBox.Show("El paquete no pudo ser guardado");
                }
                else
                {
                    if (GenericBLL.Modificar<Paquetes>(LlenaClase()))
                    {
                        MessageBox.Show("Se modifico el paquete");
                        Limpiar();
                    }
                    else
                        MessageBox.Show("El paquete no pudo ser modificado");
                }
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (GenericBLL.Eliminar<Paquetes>((int)PaqueteIdnumericUpDown.Value))
            {
                MessageBox.Show("Se elimino el paquete");
                Limpiar();
            }
            else
                MessageBox.Show("El paquete no pudo ser elimiando");
        }

        private void BuscarPaquetebutton_Click(object sender, EventArgs e)
        {
            Paquetes p = GenericBLL.Buscar<Paquetes>((int)PaqueteIdnumericUpDown.Value);
            if (p != null)
            {
                Clientes cliente = GenericBLL.Buscar<Clientes>(p.ClienteId);
                ClienteIdnumericUpDown.Value = cliente.ClienteId;
                ClienteNombretextBox.Text = cliente.Nombres;
                EstatuscomboBox.SelectedIndex = EstatuscomboBox.FindStringExact(p.Estado);
                TransportistacomboBox.SelectedIndex = p.TransporteId-1;
                TrackingtextBox.Text = p.Tracking;
                ContenidotextBox.Text = p.Contenido;
                ProveedortextBox.Text = p.Proveedor;
                PesonumericUpDown.Value = (Decimal)p.Peso;
            }
        }

        private void BuscarClientebutton_Click(object sender, EventArgs e)
        {
            Clientes cliente = GenericBLL.Buscar<Clientes>((int)ClienteIdnumericUpDown.Value);
            if (cliente != null)
            {
                ClienteNombretextBox.Text = cliente.Nombres;
            }
        }

        private void EstatuscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EstatuscomboBox.SelectedIndex != -1)
                errorProvider.SetError(EstatuscomboBox,"");
        }

        private void TrackingtextBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(TrackingtextBox, "");
        }

        private void ContenidotextBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(ContenidotextBox, "");
        }

        private void ProveedortextBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(ProveedortextBox, "");
        }

        private void ClienteNombretextBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(BuscarClientebutton, "");
        }
    }
}
