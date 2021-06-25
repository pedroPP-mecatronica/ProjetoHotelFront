using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetodeHotel
{
    public partial class FRMLogin : Form
    {
        public FRMLogin()
        {
            InitializeComponent();
        }

        private void FRMLogin_Load(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(Width / 2 - 332 / 2, Height / 2 - 340 / 2);
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Txtusuario(object sender, EventArgs e)
        {

        }

        private void BtnLogin(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" )
            {
                MessageBox.Show("Insira os dados de login");
                txtUsuario.Focus();
                return;
            }
            if(txtSenha.Text =="")
            {
                MessageBox.Show("insira a senha");
            }
            //codigo para Login
        }
    }
}
