using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final.Registros;
using Proyecto_Final.Consultas;

namespace Proyecto_Final.Registros
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void transporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTransportes trans = new rTransportes();
            trans.MdiParent = this;
            trans.Show();
        }

        private void paqueteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rPaquetes paq = new rPaquetes();
            paq.MdiParent = this;
            paq.Show();
        }

        private void clienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            rClientes cli = new rClientes();
            cli.MdiParent = this;
            cli.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUsuarios us = new rUsuarios();
            us.MdiParent = this;
            us.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rFacturas fac = new rFacturas();
            fac.MdiParent = this;
            fac.Show();
        }

        private void ctransporteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cTransportes ctran = new cTransportes();
            ctran.MdiParent = this;
            ctran.Show();
        }

        private void cclienteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            cClientes cClientes = new cClientes();
            cClientes.MdiParent = this;
            cClientes.Show();
        }

        private void cusuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cUsuarios cUsuarios = new cUsuarios();
            cUsuarios.MdiParent = this;
            cUsuarios.Show();
        }

        private void cpaqueteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cPaquetes cPaquetes = new cPaquetes();
            cPaquetes.MdiParent = this;
            cPaquetes.Show();
        }

        private void cfacturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cFacturas facturas = new cFacturas();
            facturas.MdiParent = this;
            facturas.Show();
        }
    }
}
