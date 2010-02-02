using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.ModuloBasico.VOs;

namespace GuiWindowsForms
{
    public partial class telaAlunoFinanceiro : Form
    {

        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        Memoria memoria = Memoria.Instance;

        private static telaAlunoFinanceiro telaAlunofinanceiro;

        private static bool IsShown = false;

        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. Evita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>

        public static telaAlunoFinanceiro getInstancia()
        {
            if (telaAlunofinanceiro == null)
            {
                telaAlunofinanceiro = new telaAlunoFinanceiro();
            }
            return telaAlunofinanceiro;
        }

        /// <summary>
        /// Construtor da tela
        /// </summary>

        public telaAlunoFinanceiro()
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

        #region BUTTON DESCONECTAR
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

        private void ucDesconectarLogin1_EventoDesconectar()
        {
            Program.ultimaTela = 9;
            this.Close();
            telaLogin telalogin = telaLogin.getInstancia();
            telalogin.Show();
        }


        #endregion

        #region FECHA TELA
        /// <summary>
        /// Evento para o fechamento da tela, não fecha de verdade, só a esconde, 
        /// garantindo a usabilidade da tela
        /// pelo singleton
        /// </summary>
        /// <param name="sender">Tela</param>
        /// <param name="e">Cancela seu fechamento, permite só que seja ocultada</param>

        private void telaAlunoFinanceiro_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IsShown = false;
            this.Hide();

            if (Program.ultimaTela != 1)
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


        private void btnImprimir_MouseEnter(object sender, EventArgs e)
        {

            this.btnImprimir.BackgroundImage = global::GuiWindowsForms.Properties.Resources.btn_imprimir_48x48_hover;
            //lblInfoControles.Text = "Abrir Impressões.";
            //lblInfoControles.Visible = true;
        }

        private void btnImprimir_MouseLeave(object sender, EventArgs e)
        {
            this.btnImprimir.BackgroundImage = global::GuiWindowsForms.Properties.Resources.btn_imprimir_48x48;
            //lblInfoControles.Visible = false;
        }

        #region USER CONTROLS - Controle Inferior - Botões de Navegação

        private void ucAluno1_EventoVoltar()
        {
            this.Hide();

            if (Program.ultimaTela == 1)
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

        #region USER CONTROLS - Controle Lateral - Botões de Navegação

        private void uMenuLateral1_EventoAbrirTelaResponsavel()
        {
            //this.Hide();
            //Program.ultimaTela = 7;
            //telaAlunoResponsavel telaalunoresponsavel = telaAlunoResponsavel.getInstancia();
            //telaalunoresponsavel.Show();

            this.Hide();
            Program.ultimaTela = 1;
            telaAlunoResponsavelBusca tela = telaAlunoResponsavelBusca.getInstancia();
            tela.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaMedica()
        {
            this.Hide();
            Program.ultimaTela = 1;
            telaAlunoMedicacao telaalunomedicacao = telaAlunoMedicacao.getInstancia();
            telaalunomedicacao.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaMatricula()
        {
            this.Hide();
            Program.ultimaTela = 1;
            telaAlunoMatricula telaalunomatricula = telaAlunoMatricula.getInstancia();
            telaalunomatricula.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaFinanceiro()
        {
            this.Hide();
            Program.ultimaTela = 1;
            telaAlunoFinanceiro telaalunofinanceiro = telaAlunoFinanceiro.getInstancia();
            telaalunofinanceiro.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaDados()
        {
            this.Hide();
            Program.ultimaTela = 1;
            telaAluno telaaluno = telaAluno.getInstancia();
            telaaluno.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaAcademico()
        {
            this.Hide();
            Program.ultimaTela = 1;
            telaAlunoAcademico telaalunoacademico = telaAlunoAcademico.getInstancia();
            telaalunoacademico.Show();
        }

        private void uMenuLateral1_Load(object sender, EventArgs e)
        {
            uMenuLateral1.verificaTela(telaAlunofinanceiro);
        }


        #endregion

        #region BUTTON IMPRIMIR
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            telaRelatorioBoletoMensalidade telaBoleto = new telaRelatorioBoletoMensalidade();
            //telaRelatorioBoletoMensalidadeVinculo telaBoleto = new telaRelatorioBoletoMensalidadeVinculo();
            telaBoleto.ShowDialog();
        }
        #endregion

        #region USER CONTROLS - Controle Imagem - Botões de Navegação
        private void telaAlunoFinanceiro_Load(object sender, EventArgs e)
        {
            uMenuImagem1.ocultarBotaoAdicionarImagem();
        }

        #endregion

        #region ACTIVATED
        private void telaAlunoFinanceiro_Activated(object sender, EventArgs e)
        {
            uMenuLateral1.verificaTela(telaAlunofinanceiro);
            uMenuImagem1.ocultarBotaoAdicionarImagem();

            if (memoria.Aluno != null)
            {
                uMenuImagem1.carregaAluno(memoria.Aluno);
            }
        }

        #endregion

    }

    
}
