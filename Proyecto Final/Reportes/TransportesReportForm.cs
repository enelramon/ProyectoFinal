using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Proyecto_Final.Entidades;
using System.IO;

namespace Proyecto_Final.Reportes
{
    public partial class TransportesReportForm : Form
    {
        List<Transportes> list = null;

        public TransportesReportForm(List<Transportes> list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void TransportescrystalReportViewer_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("B:/UCNE-Clases de Sistema/Programacion Aplicada 1/Proyecto/Proyecto final/Proyecto Final/Proyecto Final/Reportes/TransportesCrystalReport.rpt");
            report.SetDataSource(list);

            TransportescrystalReportViewer.ReportSource = report;
            TransportescrystalReportViewer.Refresh();
        }
    }
}
