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
            telaLogin.ActiveForm.Hide();
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

        private void btnAluno_Enter(object sender, EventArgs e)
        {
            lblAlunoOculto.Visible = true;
        }

        private void btnAluno_Leave(object sender, EventArgs e)
        {
            lblAlunoOculto.Visible = false;
        }

        private void btnFuncionario_Enter(object sender, EventArgs e)
        {
            lblAlunoOculto.Visible = false;
            lblFuncOculto.Visible = true;
        }

        private void btnFuncionario_Leave(object sender, EventArgs e)
        {
            lblFuncOculto.Visible = false;
        }

        private void btnConfiguracoes_Enter(object sender, EventArgs e)
        {
            lblAlunoOculto.Visible = false;
            lblConfOculto.Visible = true;
        }

        private void btnConfiguracoes_Leave(object sender, EventArgs e)
        {
            lblConfOculto.Visible = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtBusca.Text))
                {
                    txtBusca.BackColor = System.Drawing.Color.LawnGreen;
                    throw new Exception("Digite algum critério para a pesquisa.");
                }
                else if (txtBusca.Text.Length < 4)
                {
                    txtBusca.BackColor = System.Drawing.Color.LawnGreen;
                    throw new Exception("Digite argumentos para pesquisa maiores que 3 caracteres.");
                }
                else
                {
                    lblErro.Visible = false;
                }
            }
            catch (Exception ex)
            {
                lblErro.Visible = true;
                lblErro.Text = ex.Message;
            }
        }
    }
}
