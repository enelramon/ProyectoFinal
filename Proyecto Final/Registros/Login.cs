using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Proyecto_Final.Registros;
using Proyecto_Final.Entidades;
using Proyecto_Final.BLL;

namespace Proyecto_Final
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Registrarbutton_Click(object sender, EventArgs e)
        {
            new rUsuarioEmpleados().Show();
        }

        private void Accederbutton_Click(object sender, EventArgs e)
        {
            var lista = GenericBLL.GetList<UsuarioEmpleados>(x => x.Usuario.Equals(UsuariotextBox.Text) && x.Clave.Equals(ClavetextBox.Text));
            UsuarioEmpleados us = (lista != null && lista.Count > 0) ? lista[0] : null;
            if (us != null)
            {
                this.Close();
                Thread t = new Thread(OpenForm);
                t.Start();
                return;
            }
            else
                MessageBox.Show("Usuario invalido");
        }

        private void OpenForm()
        {
            Application.Run(new MenuPrincipal());
        }
    }
}
