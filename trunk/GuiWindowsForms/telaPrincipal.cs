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
    public partial class telaPrincipal : Form
    {
        private static telaPrincipal telaprincipal;

        public static telaPrincipal getInstancia()
        {
            if (telaprincipal == null)
            {
                telaprincipal = new telaPrincipal();
            }
            return telaprincipal;
        }
        
        
        public telaPrincipal()
        {
            InitializeComponent();
            telaLogin.ActiveForm.Hide();
        }

        /// <summary>
        /// Botão chama a tela principal de Aluno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAluno_Click(object sender, EventArgs e)
        {
            telaAlunoPrincipal telaAlunoPrincipal = telaAlunoPrincipal.getInstancia();
            telaAlunoPrincipal.Show();
        }


        #region Controla a mudança das imagens e exibição dos textos dos botões

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAluno_MouseEnter(object sender, EventArgs e)
        {
            this.btnAluno.BackgroundImage = global::GuiWindowsForms.Properties.Resources.icone_aluno_142x113_hover;
            lblAlunoOculto.Visible = true;
        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAluno_MouseLeave(object sender, EventArgs e)
        {
            this.btnAluno.BackgroundImage = global::GuiWindowsForms.Properties.Resources.icone_aluno_142x113;
            lblAlunoOculto.Visible = false;
        }

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFuncionario_MouseLeave(object sender, EventArgs e)
        {
            this.btnFuncionario.BackgroundImage = global::GuiWindowsForms.Properties.Resources.icone_prof_142x113;
            lblFuncionarioOculto.Visible = false;
        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFuncionario_MouseEnter(object sender, EventArgs e)
        {
            this.btnFuncionario.BackgroundImage = global::GuiWindowsForms.Properties.Resources.icone_prof_142x113_hover;
            lblFuncionarioOculto.Visible = true;
        }

        #endregion

        private void telaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            telaLogin telalogin = telaLogin.getInstancia();
            telalogin.Show();
        }

        #region Controla as alterações de cores dos campos do form

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

        #endregion

    }
}
