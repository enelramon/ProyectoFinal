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
    public partial class rFacturas : Form
    {
        List<FacturaDetalles> detalles = new List<FacturaDetalles>();

        public rFacturas()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            FechadateTimePicker.Value = DateTime.Now;
            IdnumericUpDown.Value = 0;
            ClienteIdnumericUpDown.Value = 0;
            dataGridView.DataSource = null;
            MontotextBox.Text = string.Empty;
        }

        private Facturas LlenaClase(List<FacturaDetalles> detalles)
        {
            return new Facturas(
                (IdnumericUpDown.Value == 0) ? 0 : (int)IdnumericUpDown.Value,
                (int)ClienteIdnumericUpDown.Value,
                FechadateTimePicker.Value,
                Decimal.Parse(MontotextBox.Text),
                detalles
                );
        }

        private void ActualizarDatos()
        {
            double descuento = 0;
            Decimal total = 0;

            for(int i = 0; i<dataGridView.Rows.Count; i++)
            {
                detalles[i].Descuento = ((double)dataGridView.Rows[i].Cells["Descuento"].Value);
                descuento = detalles[i].Descuento / 100;
                descuento *= (double)detalles[i].Precio;
                detalles[i].Precio -= (Decimal)descuento;
                total += detalles[i].Precio;
            }
            dataGridView.DataSource = detalles.ToList();
            MontotextBox.Text = total.ToString();
        }

        private bool CanSave()
        {
            bool flag = true;
            if (dataGridView.DataSource == null)
            {
                errorProvider.SetError(dataGridView, "No hay paquetes añadidos para facturar");
                flag = false;
            }

            if (ClienteIdnumericUpDown.Value == 0)
            {
                errorProvider.SetError(Addbutton, "Este cliente no existe");
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
            Facturas factura = GenericBLL.Buscar<Facturas>((int)IdnumericUpDown.Value);
            if (CanSave())
            {
                if (factura == null)
                {
                    if (GenericBLL.Guardar<Facturas>(LlenaClase(detalles)))
                    {
                        MessageBox.Show("Se guardo la factura");
                        Limpiar();
                    }
                    else
                        MessageBox.Show("No se pudo guardar la factura");
                }
                else
                {
                    if (GenericBLL.Modificar<Facturas>(LlenaClase(detalles)))
                    {
                        MessageBox.Show("Se modifico la factura");
                        Limpiar();
                    }
                    else
                        MessageBox.Show("No se pudo modificar la factura");
                }
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (GenericBLL.Eliminar<Facturas>((int)IdnumericUpDown.Value))
            {
                MessageBox.Show("Se elimino la factura");
                Limpiar();
            }
            else
                MessageBox.Show("No se pudo eliminar la factura");
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            Decimal monto = 0;
            var lista = GenericBLL.GetList<Paquetes>(x => (x.ClienteId == (int)ClienteIdnumericUpDown.Value && x.Estado.Equals("Disponible"))).ToList();
            detalles.Clear();
            foreach (Paquetes p in lista)
            {
                FacturaDetalles f = new FacturaDetalles(
                    0,
                    (IdnumericUpDown.Value == 0) ? 0 : (int)IdnumericUpDown.Value,
                    p.PaqueteId,
                    p.Contenido,
                    p.Proveedor,
                    p.Peso,
                    0,
                    (p.Peso <= 1) ? 180 : (Decimal)(180 * p.Peso)
                    );
                monto += f.Precio;
                detalles.Add(f);
            }

            dataGridView.DataSource = detalles.ToList();
            MontotextBox.Text = monto.ToString();
            errorProvider.SetError(dataGridView,"");
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
                ActualizarDatos();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Facturas f = GenericBLL.Buscar<Facturas>((int)IdnumericUpDown.Value);
            if (f != null)
            {
                detalles = f.Detalles;
                ClienteIdnumericUpDown.Value = f.ClienteId;
                dataGridView.DataSource = detalles.ToList();
                MontotextBox.Text = f.Monto.ToString();
            }
        }

        private void ClienteIdnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (ClienteIdnumericUpDown.Value > 0)
                errorProvider.SetError(Addbutton,"");
        }
    }
}
