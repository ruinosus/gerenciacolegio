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
    public partial class ucMenuInicial : UserControl
    {

        public ucMenuInicial()
        {
            InitializeComponent();
        }

        #region BUTTON ALUNO



        private void btnAluno_Click(object sender, EventArgs e)
        {
            //btnCadastrarFuncionario.Visible = false;
            //btnCadastrarAluno.Visible = true;
        }

        /// <summary>
        /// Exibe o nome do botão relacionado, só sendo escondido ao se clicar em outro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAluno_Enter(object sender, EventArgs e)
        {
            lblAlunoOculto.Visible = true;
            this.btnAluno.BackgroundImage = global::GuiWindowsForms.Properties.Resources.icone_aluno_142x113_hover;
        }

        /// <summary>
        /// Esconde o texto do botão selecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAluno_Leave(object sender, EventArgs e)
        {
            lblAlunoOculto.Visible = false;
            this.btnAluno.BackgroundImage = global::GuiWindowsForms.Properties.Resources.icone_aluno_142x113;
        }

        #endregion

        #region BUTTON FUNCIONARIO

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            //btnCadastrarAluno.Visible = false;
            //btnCadastrarFuncionario.Visible = true;
        }

        private void btnFuncionario_Enter(object sender, EventArgs e)
        {
            lblAlunoOculto.Visible = false;
            lblFuncOculto.Visible = true;
            this.btnFuncionario.BackgroundImage = global::GuiWindowsForms.Properties.Resources.icone_prof_142x113_hover;
        }


        /// <summary>
        /// Esconde o texto do botão selecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFuncionario_Leave(object sender, EventArgs e)
        {

            lblFuncOculto.Visible = false;
            this.btnFuncionario.BackgroundImage = global::GuiWindowsForms.Properties.Resources.icone_prof_142x113;
        }

        #endregion

        #region BUTTON CONFIGURAÇÕES

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            //btnCadastrarAluno.Visible = false;
            //btnCadastrarFuncionario.Visible = false;
            this.Hide();
            Program.ultimaTela = 6;
            telaConfiguracoes telaconfiguracoes = telaConfiguracoes.getInstancia();
            telaconfiguracoes.Show();
        }

        /// <summary>
        /// Exibe o nome do botão relacionado, só sendo escondido ao se clicar em outro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfiguracoes_Enter(object sender, EventArgs e)
        {
            lblAlunoOculto.Visible = false;
            lblConfOculto.Visible = true;
            this.btnConfiguracoes.BackgroundImage = global::GuiWindowsForms.Properties.Resources.configuracoes_137x101_hover;
        }

        #endregion

        #region BUTTON FINANCEIRO

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            //btnCadastrarAluno.Visible = false;
            //btnCadastrarFuncionario.Visible = false;
            this.Hide();
            Program.ultimaTela = 6;
            telaFinanceiro telafinanceiro = telaFinanceiro.getInstancia();
            telafinanceiro.Show();
        }


        /// <summary>
        /// Exibe o nome do botão relacionado, só sendo escondido ao se clicar em outro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinanceiro_Enter(object sender, EventArgs e)
        {
            lblAlunoOculto.Visible = false;
            lblFinanceiro.Visible = true;
            this.btnFinanceiro.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_gnd_120x110_png_hover;

        }

        /// <summary>
        /// Esconde o texto do botão selecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinanceiro_Leave(object sender, EventArgs e)
        {
            lblFinanceiro.Visible = false;
            this.btnFinanceiro.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_gnd_120x110;

        }

        #endregion


    }
}
