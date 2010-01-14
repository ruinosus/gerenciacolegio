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
    public partial class telaFinanceiro : Form
    {
        #region SINGLETON DA TELA
        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaFinanceiro telaafinanceiro;

        private static bool IsShown = false;
        #endregion

        #region INSTANCIA TELA FINANCEIRO
        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. Evita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>

        public static telaFinanceiro getInstancia()
        {
            if (telaafinanceiro == null)
            {
                telaafinanceiro = new telaFinanceiro();
            }
            return telaafinanceiro;
        }
        #endregion

        #region CONSTRUTOR
        /// <summary>
        /// Construtor da tela
        /// </summary>

        public telaFinanceiro()
        {
            InitializeComponent();
        }
        #endregion

        #region MÉTODO PARA VERIFICAR USO DA TELA
        /// <summary>
        /// Método para verificar se a tela já esta sendo exibida ou não, 
        /// evita que a tela seja descarregada da memória
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
        #endregion 

        #region  BUTTON DESCONECTAR
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
        #endregion

        #region  MÉTODO PARA FECHAR A TELA
        /// <summary>
        /// Evento para o fechamento da tela, não fecha de verdade, só a esconde,
        /// garantindo a usabilidade da tela
        /// pelo singleton
        /// </summary>
        /// <param name="sender">Tela</param>
        /// <param name="e">Cancela seu fechamento, permite só que seja ocultada</param>

        private void telaAlunoResponsavel_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IsShown = false;
            this.Hide();

            if (Program.ultimaTela != 16)
            {
                Program.SelecionaForm(Program.ultimaTela);
            }
            else
            {
                Program.ultimaTela = 6;
                Program.SelecionaForm(Program.ultimaTela);
            }
        }
        #endregion

        #region BUTTON IMPIRMIR
        private void btnImprimir_MouseEnter(object sender, EventArgs e)
        {
            this.btnImprimir.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_impressora_51x53_hover;
        }

        private void btnImprimir_MouseLeave(object sender, EventArgs e)
        {
            this.btnImprimir.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_impressora_51x53;
        }
        #endregion

        #region BUTTON PESQUISAR
        private void btnPesquisar_MouseEnter(object sender, EventArgs e)
        {
            this.btnPesquisar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_busca_73x75_hover;
        }
       
        private void btnPesquisar_MouseLeave(object sender, EventArgs e)
        {
            this.btnPesquisar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_busca_73x75;
        }
        #endregion

        #region USER CONTROLS - Controle Inferior - Botões de Navegação

        private void ucAluno1_EventoVoltar()
        {
            this.Hide();

            Program.ultimaTela = 6;
            Program.SelecionaForm(Program.ultimaTela);
        }

        #endregion
    }
}
