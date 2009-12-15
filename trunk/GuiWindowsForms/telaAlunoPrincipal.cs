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

        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaAlunoPrincipal telaalunoprincipal;

        private static bool IsShown = false;

        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. Evita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>

        public static telaAlunoPrincipal getInstancia()
        {
            if (telaalunoprincipal == null)
            {
                telaalunoprincipal = new telaAlunoPrincipal();
            }
            return telaalunoprincipal;
        }

        /// <summary>
        /// Construtor da tela
        /// </summary>

        public telaAlunoPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para verificar se a tela já esta sendo exibida ou não, avita que a tela seja descarregada da memória
        /// </summary>

        public new void Show()
        {
            if (IsShown)
                base.Show();
            else
            {
                base.Show();
                IsShown = true;
            }
        }

        /// <summary>
        /// Fecha a tela ativa e exibe a tela de responsáveis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 6;
            telaAlunoResponsavel telaalunoresponsavel = telaAlunoResponsavel.getInstancia();
            telaalunoresponsavel.Show();
        }

        /// <summary>
        /// Evento para o fechamento da tela, não fecha de verdade, só a esconde, garantindo a usabilidade da tela
        /// pelo singleton
        /// </summary>
        /// <param name="sender">Tela</param>
        /// <param name="e">Cancela seu fechamento, permite só que seja ocultada</param>

        private void telaAlunoPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IsShown = false;
            this.Hide();

            if (Program.ultimaTela != 6)
            {
                Program.SelecionaForm(Program.ultimaTela);
            }
            else
            {
                Program.ultimaTela = 9;
                Program.SelecionaForm(Program.ultimaTela);
            }
        }

        #region Mudança de cores das textboxes e outros controles

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

        /// <summary>
        /// Botão para esconder a tela e voltar para a tela de login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
    
        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            Program.ultimaTela = 9;
            this.Close();
            telaLogin telalogin = telaLogin.getInstancia();
            telalogin.Show();
        }

        #region Controle de mudança das figuras e exibição dos textos das mesmas

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

        /// <summary>
        /// Exibe o nome do botão relacionado, só sendo escondido ao se clicar em outro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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

        /// <summary>
        /// Esconde o texto do botão selecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnConfiguracoes_Leave(object sender, EventArgs e)
        {
            lblConfOculto.Visible = false;
            this.btnConfiguracoes.BackgroundImage = global::GuiWindowsForms.Properties.Resources.configuracoes_137x101;
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

        
        /// <summary>
        /// Conforme o botão clidado, será realizada uma pesquisa específica a ser exibida em um datagrid
        /// algumas validações serão exigidas para tal
        /// O parâmetro de funcionamento são os dados para pesquisa preenchidos na textbox txtbusca
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
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

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 6;
            telaConfiguracoes telaconfiguracoes = telaConfiguracoes.getInstancia();
            telaconfiguracoes.Show();
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {

        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 6;
            telaFuncionario telafuncionario = telaFuncionario.getInstancia();
            telafuncionario.Show();
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 6;
            telaFinanceiro telafinanceiro = telaFinanceiro.getInstancia();
            telafinanceiro.Show();
        }

    }
}
