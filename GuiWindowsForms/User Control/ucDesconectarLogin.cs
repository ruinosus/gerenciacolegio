using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuiWindowsForms.User_Control
{
    public partial class ucDesconectarLogin : UserControl
    {
        public ucDesconectarLogin()
        {
            InitializeComponent();
        }

        public delegate void delegateDesconectar();
        public event delegateDesconectar EventoDesconectar;

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            if (EventoDesconectar != null)
                EventoDesconectar();
        }

        public void alterarNomeUsuario(bool visivel, string nome)
        {
            if (Program.usuarioLogin != null)
            {
                lblHelloUsuario.Visible = visivel;
                lblHelloUsuario.Text = Program.usuarioLogin;
            }
        }
    }
}
