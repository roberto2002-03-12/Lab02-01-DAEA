using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            var user = txtUsuario.Text;
            var password = txtContrasena.Text;

            var ListUsers = new Usuario[4];
            ListUsers[0] = new Usuario();
            ListUsers[0].Name = "Emilio";
            ListUsers[0].Password = "ejemplo1";

            ListUsers[1] = new Usuario();
            ListUsers[1].Name = "Roberto";
            ListUsers[1].Password = "ejemplo2";

            ListUsers[2] = new Usuario();
            ListUsers[2].Name = "Fabriciano";
            ListUsers[2].Password = "ejemplo3";

            ListUsers[3] = new Usuario();
            ListUsers[3].Name = "Contreras";
            ListUsers[3].Password = "ejemplo4";

            foreach (var usuario in ListUsers)
            {
                if (usuario.Name == user && usuario.Password == password)
                {
                    PrincipalMDI principal = new PrincipalMDI();
                    principal.Show();
                    this.Hide();

                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
