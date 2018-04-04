using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using Proyecto_Final.BLL;
using Proyecto_Final.Entidades;
using Proyecto_Final.Reportes;

namespace Proyecto_Final.Consultas
{
    public partial class cFacturas : Form
    {
        Expression<Func<Facturas, bool>> filter = x => 1 == 1;

        public cFacturas()
        {
            InitializeComponent();
        }

        private void Filtrar()
        {
            int dato = 0;
            switch (FiltrarcomboBox.SelectedIndex)
            {
                case 0://FacturaId
                    dato = int.Parse(BuscartextBox.Text);
                    filter = (x => x.FacturaId == dato && ((x.Fecha >= FechaInicialdateTimePicker.Value) && (x.Fecha <= FechaFinaldateTimePicker.Value)));
                    break;

                case 1://ClienteId
                    dato = int.Parse(BuscartextBox.Text);
                    filter = (x => x.ClienteId == dato && ((x.Fecha >= FechaInicialdateTimePicker.Value) && (x.Fecha <= FechaFinaldateTimePicker.Value)));
                    break;

                case 2://Fecha
                    DateTime date = DateTime.Parse(BuscartextBox.Text);
                    filter = (x => x.Fecha == date);
                    break;

                case 3://Monto
                    Decimal monto = Decimal.Parse(BuscartextBox.Text);
                    filter = (x => x.Monto >= monto && ((x.Fecha >= FechaInicialdateTimePicker.Value) && (x.Fecha <= FechaFinaldateTimePicker.Value)));
                    break;
            }
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            Filtrar();
            dataGridView.DataSource = GenericBLL.GetList<Facturas>(filter);
        }

        private void Reportebutton_Click(object sender, EventArgs e)
        {
            Filtrar();
            new FacturaReportForm(GenericBLL.GetList<Facturas>(filter)).Show();
        }
    }
}
