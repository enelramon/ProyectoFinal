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
    public partial class ClientesReportForm : Form
    {
        List<Clientes> list = null;

        public ClientesReportForm(List<Clientes> list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void ClientescrystalReportViewer_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("B:/UCNE-Clases de Sistema/Programacion Aplicada 1/Proyecto/Proyecto final/Proyecto Final/Proyecto Final/Reportes/ClientesCrystalReport.rpt");
            report.SetDataSource(list);

            ClientescrystalReportViewer.ReportSource = report;
            ClientescrystalReportViewer.Refresh();
        }
    }
}
