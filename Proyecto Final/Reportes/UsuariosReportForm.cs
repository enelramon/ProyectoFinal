using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.CrystalReports.Engine;
using System.Windows.Forms;
using Proyecto_Final.Entidades;

namespace Proyecto_Final.Reportes
{
    public partial class UsuariosReportForm : Form
    {
        List<Usuarios> list = null;

        public UsuariosReportForm(List<Usuarios> list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void UsuarioscrystalReportViewer_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("B:/UCNE-Clases de Sistema/Programacion Aplicada 1/Proyecto/Proyecto final/Proyecto Final/Proyecto Final/Reportes/UsuariosCrystalReport.rpt");
            report.SetDataSource(list);

            UsuarioscrystalReportViewer.ReportSource = report;
            UsuarioscrystalReportViewer.Refresh();
        }
    }
}
