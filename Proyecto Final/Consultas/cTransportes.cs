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
    public partial class cTransportes : Form
    {
        Expression<Func<Transportes, bool>> filter = x => 1 == 1;

        public cTransportes()
        {
            InitializeComponent();
        }

        private void Filtrar()
        {
            switch (FiltrarPorcomboBox.SelectedIndex)
            {
                case 0://TransporteId
                    int id = int.Parse(FiltrotextBox.Text);
                    filter = (x => x.TransporteId == id);
                    break;

                case 1://Compania
                    filter = (x => x.Compania.Contains(FiltrotextBox.Text));
                    break;

                case 2://Telefono
                    filter = (x => x.Telefono.Equals(FiltrotextBox.Text));
                    break;
            }
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            Filtrar();   
            dataGridView.DataSource = GenericBLL.GetList<Transportes>(filter);
        }

        private void Reportebutton_Click(object sender, EventArgs e)
        {
            Filtrar();
            new TransportesReportForm(GenericBLL.GetList<Transportes>(filter)).Show();
        }
    }
}
