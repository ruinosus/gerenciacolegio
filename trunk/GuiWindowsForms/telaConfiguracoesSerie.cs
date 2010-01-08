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
    public partial class telaConfiguracoesSerie : Form
    {
        #region SINGLETON DA TELA
        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaConfiguracoesSerie telaconfiguracoesserie;

        private static bool IsShown = false;
        #endregion

        #region INSTANCIA TELA FUNCIONARIO
        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. Evita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>

        public static telaConfiguracoesSerie getInstancia()
        {
            if (telaconfiguracoesserie == null)
            {
                telaconfiguracoesserie = new telaConfiguracoesSerie();
            }
            return telaconfiguracoesserie;
        }
        #endregion

        #region CONSTRUTOR
        /// <summary>
        /// Construtor da tela
        /// </summary>

        public telaConfiguracoesSerie()
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

        #region MÉTODO PARA FECHAR A TELA
        /// <summary>
        /// Evento para o fechamento da tela, 
        /// não fecha de verdade, só a esconde, garantindo a usabilidade da tela
        /// pelo singleton
        /// </summary>
        /// <param name="sender">Tela</param>
        /// <param name="e">Cancela seu fechamento, permite só que seja ocultada</param>

        private void telaConfiguracoesSerie_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IsShown = false;
            this.Hide();

            Program.SelecionaForm(Program.ultimaTela);
        }

        private void ucMenuConfiguracoesEsquerda1_EventoAbrirControleDeAcesso()
        {
            this.Hide();
            Program.ultimaTela = 10;
            telaConfiguracoesControleDeAcesso telaconfacesso = telaConfiguracoesControleDeAcesso.getInstancia();
            telaconfacesso.Show();
        }
        #endregion

        #region USER CONTROLS - MENU DIREITA
        private void ucMenuDireita1_EventoAbrirSerie()
        {
            this.Hide();
            Program.ultimaTela = 10;
            telaConfiguracoesSerie telaconfserie = telaConfiguracoesSerie.getInstancia();
            telaconfserie.Show();
        }

        private void ucMenuDireita1_EventoAbrirAtividade()
        {
            this.Hide();
            Program.ultimaTela = 10;
            telaConfiguracoesAtividade telaconfatv = telaConfiguracoesAtividade.getInstancia();
            telaconfatv.Show();
        }


        private void ucMenuDireita1_EventoAbrirDesconto()
        {
            this.Hide();
            Program.ultimaTela = 10;
            telaConfiguracoesDescontoMatricula telaconfdesconto = telaConfiguracoesDescontoMatricula.getInstancia();
            telaconfdesconto.Show();
        }

        private void ucMenuDireita1_Load(object sender, EventArgs e)
        {
            ucMenuDireita1.verificaTela(telaconfiguracoesserie);
        }
        #endregion

        #region USER CONTROLS - MENU ESQUERDA
        private void ucMenuConfiguracoesEsquerda1_Load(object sender, EventArgs e)
        {
            ucMenuConfiguracoesEsquerda1.verificaTela(telaconfiguracoesserie);
        }
        #endregion

        #region USER CONTROLS - Controle Inferior - Botões de Navegação

        private void ucAluno1_EventoVoltar()
        {
            this.Hide();

            if (Program.ultimaTela == 10)
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

        #region LOAD
        private void telaConfiguracoesSerie_Load(object sender, EventArgs e)
        {


        }
        #endregion

        #region EVENTO CADASTRAR
        private void ucMenuInferior1_EventoCadastrar()
        {
            try
            {
                #region VALIDA - SERIE

                if (String.IsNullOrEmpty(cmbSerie.Text))
                {
                    errorProviderTela.SetError(cmbSerie, "Informe a serie");
                    return;
                }

                #endregion

                #region VALIDA - CICLO

                if (String.IsNullOrEmpty(txtCiclo.Text))
                {
                    errorProviderTela.SetError(txtCiclo, "Informe o ciclo");
                    return;
                }

                #endregion

                #region VALIDA - TURNO

                if (String.IsNullOrEmpty(cmbTurno.Text))
                {
                    errorProviderTela.SetError(cmbTurno, "Informe o turno");
                    return;
                }

                #endregion

                #region VALIDA - TURMA

                if (String.IsNullOrEmpty(cmbTurma.Text))
                {
                    errorProviderTela.SetError(cmbTurma, "Informe a turma");
                    return;
                }

                #endregion

                #region VALIDA - VALOR

                if (String.IsNullOrEmpty(txtValor.Text))
                {
                    errorProviderTela.SetError(txtValor, "Informe o valor");
                    return;
                }

                #endregion

                
            }
            catch (Exception ex)
            { 
            
            }

        }
        #endregion

        #region LIMPAR ERRO PROVIDER
        private void cmbSerie_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtCiclo_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void cmbTurno_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void cmbTurma_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void cmbSerie_Click(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void cmbTurno_Click(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void cmbTurma_Click(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        #endregion



    }
}
