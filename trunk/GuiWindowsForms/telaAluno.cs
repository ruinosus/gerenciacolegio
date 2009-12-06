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
    public partial class telaAluno : Form
    {

        private static telaAluno telaaluno;

        public static telaAluno getInstancia()
        {
            if (telaaluno == null)
            {
                telaaluno = new telaAluno();
            }
            return telaaluno;
        }

        public telaAluno()
        {
            InitializeComponent();
            telaAlunoPrincipal.ActiveForm.Hide();
        }

        private void btnResponsaveis_Click(object sender, EventArgs e)
        {
            telaAlunoResponsavel telaAlunoRespons = telaAlunoResponsavel.getInstancia();
            telaAlunoRespons.Show();
        }

        private void telaAluno_FormClosing(object sender, FormClosingEventArgs e)
        {
            telaAlunoPrincipal telaalunoprincipal = telaAlunoPrincipal.getInstancia();
            telaalunoprincipal.Show();
        }
    }
}
