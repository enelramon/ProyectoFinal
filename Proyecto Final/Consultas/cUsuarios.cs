﻿using System;
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
    public partial class cUsuarios : Form
    {
        Expression<Func<Usuarios, bool>> filter = x => 1 == 1;

        public cUsuarios()
        {
            InitializeComponent();
        }

        private void Filtrar()
        {
            int id = 0;
            switch (FiltarcomboBox.SelectedIndex)
            {
                case 0://UsuarioId
                    id = int.Parse(BuscartextBox.Text);
                    filter = (x => x.UsuarioId == id);
                    break;

                case 1://ClienteId
                    id = int.Parse(BuscartextBox.Text);
                    filter = (x => x.ClienteId == id);
                    break;

                case 2://Usuario
                    filter = (x => x.Usuario.Contains(BuscartextBox.Text));
                    break;

                case 3://Clave
                    filter = (x => x.Clave.Contains(BuscartextBox.Text));
                    break;
            }
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            Filtrar();
            dataGridView.DataSource = GenericBLL.GetList<Usuarios>(filter);
        }

        private void Reportebutton_Click(object sender, EventArgs e)
        {
            Filtrar();
            new UsuariosReportForm(GenericBLL.GetList<Usuarios>(filter)).Show();
        }
    }
}
