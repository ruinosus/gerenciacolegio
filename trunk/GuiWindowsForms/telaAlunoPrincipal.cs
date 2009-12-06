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
    public partial class telaAlunoPrincipal : Form
    {
        private static telaAlunoPrincipal telaalunoprincipal;

        public static telaAlunoPrincipal getInstancia()
        {
            if (telaalunoprincipal == null)
            {
                telaalunoprincipal = new telaAlunoPrincipal();
            }
            return telaalunoprincipal;
        }

        public telaAlunoPrincipal()
        {
            InitializeComponent();
            telaPrincipal.ActiveForm.Hide();
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            telaAlunoResponsavel telaalunoresponsavel = telaAlunoResponsavel.getInstancia();
            telaalunoresponsavel.Show();
        }

        private void telaAlunoPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            telaPrincipal telaprincipal = telaPrincipal.getInstancia();
            telaprincipal.Show();
        }
    }
}
