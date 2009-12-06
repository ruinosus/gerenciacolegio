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
    public partial class telaAlunoResponsavel : Form
    {

        private static telaAlunoResponsavel telaalunoresponsavel;

        public static telaAlunoResponsavel getInstancia()
        {
            if (telaalunoresponsavel == null)
            {
                telaalunoresponsavel = new telaAlunoResponsavel();
            }
            return telaalunoresponsavel;
        }

        public telaAlunoResponsavel()
        {
            InitializeComponent();
            telaAlunoPrincipal.ActiveForm.Hide();
        }

        private void telaAlunoResponsavel_FormClosing(object sender, FormClosingEventArgs e)
        {
            telaAlunoPrincipal telaalunoprincipal = telaAlunoPrincipal.getInstancia();
            telaalunoprincipal.Show();
        }
    }
}
