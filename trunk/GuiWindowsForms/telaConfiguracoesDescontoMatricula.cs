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
    public partial class telaConfiguracoesDescontoMatricula : Form
    {

        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaConfiguracoesDescontoMatricula telaconfiguracoesdesconto;

        private static bool IsShown = false;

        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. Evita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>

        public static telaConfiguracoesDescontoMatricula getInstancia()
        {
            if (telaconfiguracoesdesconto == null)
            {
                telaconfiguracoesdesconto = new telaConfiguracoesDescontoMatricula();
            }
            return telaconfiguracoesdesconto;
        }

        /// <summary>
        /// Construtor da tela
        /// </summary>
        /// 
        public telaConfiguracoesDescontoMatricula()
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

            //return SelecionaForm(aux);
        }

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

        /// <summary>
        /// Evento para o fechamento da tela, não fecha de verdade, só a esconde, garantindo a usabilidade da tela
        /// pelo singleton
        /// </summary>
        /// <param name="sender">Tela</param>
        /// <param name="e">Cancela seu fechamento, permite só que seja ocultada</param>

        private void telaConfiguracoesDescontoMatricula_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IsShown = false;
            this.Hide();

            Program.SelecionaForm(Program.ultimaTela);
        }

        #region Ações dos botões de navegação

        private void btnControledeAcesso_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 10;
            telaConfiguracoesControleDeAcesso telaconfacesso = telaConfiguracoesControleDeAcesso.getInstancia();
            telaconfacesso.Show();
        }

        private void btnSerie_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 10;
            telaConfiguracoesSerie telaconfserie = telaConfiguracoesSerie.getInstancia();
            telaconfserie.Show();
        }

        private void lblDesconto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 10;
            telaConfiguracoesDescontoMatricula telaconfdesconto = telaConfiguracoesDescontoMatricula.getInstancia();
            telaconfdesconto.Show();
        }

        private void btnAtividades_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 10;
            telaConfiguracoesAtividades telaconfatv = telaConfiguracoesAtividades.getInstancia();
            telaconfatv.Show();
        }

        #endregion

        #region Controle de mudança das figuras e exibição dos textos das mesmas

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnControledeAcesso_MouseEnter(object sender, EventArgs e)
        {
            this.btnControledeAcesso.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_acesso_64x80_hover;
            lblControleAcesso_menu.Visible = true;
        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnControledeAcesso_MouseLeave(object sender, EventArgs e)
        {
            this.btnControledeAcesso.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_acesso_64x80;
            lblControleAcesso_menu.Visible = false;
        }

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnSerie_MouseEnter(object sender, EventArgs e)
        {
            this.btnSerie.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_serie_64x70_hover;
            lblSerie_menu.Visible = true;
        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnSerie_MouseLeave(object sender, EventArgs e)
        {
            this.btnSerie.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_serie_64x70;
            lblSerie_menu.Visible = false;
        }

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void lblDesconto_MouseEnter(object sender, EventArgs e)
        {
            this.btnDesconto.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_desconto_79x80_hover;
            lblDesconto_menu.Visible = true;
        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void lblDesconto_MouseLeave(object sender, EventArgs e)
        {
            this.btnDesconto.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_desconto_79x80;
            lblDesconto_menu.Visible = false;
        }

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAtividades_MouseEnter(object sender, EventArgs e)
        {
            this.btnAtividade.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_atividades_84x75_hover;
            lblAtividade_menu.Visible = true;
        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAtividades_MouseLeave(object sender, EventArgs e)
        {
            this.btnAtividade.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_atividades_84x75;
            lblAtividade_menu.Visible = false;
        }

        #endregion

        #region Controle dos textos e das ações dos botões de ação inferiores

        /// <summary>
        /// Exibe o texto referente ao controle quando o mouse passa sobre ele
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnVoltar_MouseEnter(object sender, EventArgs e)
        {
            lblInfoControles.Visible = true;
            lblInfoControles.Text = "Voltar";
        }

        /// <summary>
        /// Oculta o texto referente ao controle quando o mouse passa sobre ele
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnVoltar_MouseLeave(object sender, EventArgs e)
        {
            lblInfoControles.Visible = false;
        }

        /// <summary>
        /// Retorna para tela anterior ocultando a atual e chamando a instância da última tela acessada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Program.SelecionaForm(Program.ultimaTela);
        }

        /// <summary>
        /// Exibe o texto referente ao controle quando o mouse passa sobre ele
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void btnSalvar_MouseLeave(object sender, EventArgs e)
        {
            lblInfoControles.Visible = false;
        }

        /// <summary>
        /// Exibe o texto referente ao controle quando o mouse passa sobre ele
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnSalvar_MouseEnter(object sender, EventArgs e)
        {
            lblInfoControles.Visible = true;
            lblInfoControles.Text = "Salvar Informações";
        }

        #endregion

    }
}
