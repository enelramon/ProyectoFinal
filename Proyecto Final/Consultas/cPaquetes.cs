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
    public partial class cPaquetes : Form
    {
        Expression<Func<Paquetes, bool>> filter = x => 1 == 1;

        public cPaquetes()
        {
            InitializeComponent();
        }

        private bool Validacion()
        {
            Console.WriteLine(FiltrarcomboBox.SelectedIndex);
            if (BuscartextBox.Text == string.Empty && (FiltrarcomboBox.SelectedIndex >= 0 && FiltrarcomboBox.SelectedIndex < 9))
            {
                errorProvider.SetError(BuscartextBox, "Debe indicar el filtro");
                return false;
            }
            return true;
        }

        private void Filtrar()
        {
            int dato = 0;
            switch (FiltrarcomboBox.SelectedIndex)
            {
                case 0://PaqueteId
                    dato = int.Parse(BuscartextBox.Text);
                    filter = (x => x.PaqueteId == dato);
                    break;

                case 1://ClienteId
                    dato = int.Parse(BuscartextBox.Text);
                    filter = (x => x.ClienteId == dato);
                    break;

                case 2://TransporteId
                    dato = int.Parse(BuscartextBox.Text);
                    filter = (x => x.TransporteId == dato);
                    break;

                case 3://Estado
                    filter = (x => x.Estado.Equals(BuscartextBox.Text));
                    break;

                case 4://Tracking
                    filter = (x => x.Tracking.Contains(BuscartextBox.Text));
                    break;

                case 5://Contenido
                    filter = (x => x.Contenido.Contains(BuscartextBox.Text));
                    break;

                case 6://Proveedor
                    filter = (x => x.Proveedor.Contains(BuscartextBox.Text));
                    break;

                case 7://Transportista
                    filter = (x => x.Transportista.Contains(BuscartextBox.Text));
                    break;

                case 8://Peso
                    double peso = double.Parse(BuscartextBox.Text);
                    filter = (x => x.Peso >= peso);
                    break;

                case 9://Todo
                    filter = x => 1 == 1;
                    break;
            }
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {
                Filtrar();
                dataGridView.DataSource = GenericBLL.GetList<Paquetes>(filter);
            }
        }

        private void Reportebutton_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {
                Filtrar();
                new PaquetesReportForm(GenericBLL.GetList<Paquetes>(filter)).Show();
            }
        }

        private void BuscartextBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(BuscartextBox, "");
        }
    }
}
