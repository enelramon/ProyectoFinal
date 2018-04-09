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
    public partial class cClientes : Form
    {
        Expression<Func<Clientes, bool>> filter = x => 1 == 1;

        public cClientes()
        {
            InitializeComponent();
        }

        private bool Validacion()
        {
            if (BuscartextBox.Text == string.Empty && (FiltrarcomboBox.SelectedIndex >= 0 && FiltrarcomboBox.SelectedIndex < 8))
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
                case 0://ClienteId
                    dato = int.Parse(BuscartextBox.Text);
                    filter = (x => x.ClienteId == dato);
                    break;

                case 1://Nombres
                    filter = (x => x.Nombres.Contains(BuscartextBox.Text));
                    break;

                case 2://Edad
                    filter = (x => x.Edad >= dato);
                    break;

                case 3://Sexo
                    filter = (x => x.Sexo.Equals(BuscartextBox.Text.ToCharArray()[0]));
                    break;

                case 4://Telefono
                    filter = (x => x.Telefono.Equals(BuscartextBox.Text));
                    break;

                case 5://Celular
                    filter = (x => x.Celular.Equals(BuscartextBox.Text));
                    break;

                case 6://Email
                    filter = (x => x.Email.Equals(BuscartextBox.Text));
                    break;

                case 7://Ciudad
                    filter = (x => x.Ciudad.Equals(BuscartextBox.Text));
                    break;

                case 8://Todo
                    filter = x => 1 == 1;
                    break;
            }
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {
                Filtrar();
                dataGridView.DataSource = GenericBLL.GetList<Clientes>(filter);
            }
        }

        private void Reportebutton_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {
                Filtrar();
                new ClientesReportForm(GenericBLL.GetList<Clientes>(filter)).Show();
            }
        }

        private void BuscartextBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(BuscartextBox, "");
        }
    }
}
