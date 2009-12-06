using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuiWindowsForms
{
    public partial class telaLogin : Form
    {
        private static telaLogin telalogin;

        public static telaLogin getInstancia()
        {
            if (telalogin == null)
            {
                telalogin = new telaLogin();
            }
            return telalogin;
        }

        public telaLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            telaPrincipal telaPrincipal = telaPrincipal.getInstancia();
            telaPrincipal.Show();          
        }
    }
}
