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
            telaLogin telalogin = telaLogin.getInstancia();
            telalogin.Hide();
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            telaAlunoResponsavel telaalunoresponsavel = telaAlunoResponsavel.getInstancia();
            telaalunoresponsavel.Show();
        }

        private void telaAlunoPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            telaLogin telalogin = telaLogin.getInstancia();
            telalogin.Show();
        }

        /// <summary>
        /// Altera a cor do controle ao ser ativado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLogin_Enter(object sender, EventArgs e)
        {
            txtBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Retorna a cor do controle para a original ao perder o foco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLogin_Leave(object sender, EventArgs e)
        {
            txtBusca.BackColor = System.Drawing.Color.White;
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            telaalunoprincipal.Close();
        }
    }
}
