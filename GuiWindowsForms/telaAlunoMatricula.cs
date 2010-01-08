using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.ModuloMatricula.Processos;
using Negocios.ModuloSala.Processos;
using Negocios.ModuloSalaPeriodo.Processos;

namespace GuiWindowsForms
{
    public partial class telaAlunoMatricula : Form
    {
        Matricula matricula = new Matricula();
        Sala sala = new Sala();
        SalaPeriodo salaPeriodo = new SalaPeriodo();

        IMatriculaProcesso matriculaControlador = MatriculaProcesso.Instance;
        ISalaProcesso salaControlador = SalaProcesso.Instance;
        ISalaPeriodoProcesso salaPeriodoControlador = SalaPeriodoProcesso.Instance;

        #region SINGLETON DA TELA
        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaAlunoMatricula telaalunomatricula;

        private static bool IsShown = false;
        #endregion

        #region INSTANCIA TELA MATRICULA
        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. Evita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>

        public static telaAlunoMatricula getInstancia()
        {
            if (telaalunomatricula == null)
            {
                telaalunomatricula = new telaAlunoMatricula();
            }
            return telaalunomatricula;
        }
        #endregion

        #region CONSTRUTOR
        /// <summary>
        /// Construtor da tela
        /// </summary>

        public telaAlunoMatricula()
        {
            InitializeComponent();
        }
        #endregion

        #region MÉTODO PARA VERIFICAR USO DA TELA
        /// <summary>
        /// Método para verificar se a tela já esta sendo exibida ou não, 
        /// avita que a tela seja descarregada da memória
        /// </summary>

        /// <summary>
        /// Método para verificar se a tela já esta sendo exibida ou não,
        /// avita que a tela seja descarregada da memória
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
        #endregion

        #region MÉTODO PARA FECHAR A TELA
        /// <summary>
        /// Evento para o fechamento da tela, não fecha de verdade, 
        /// só a esconde, garantindo a usabilidade da tela
        /// pelo singleton
        /// </summary>
        /// <param name="sender">Tela</param>
        /// <param name="e">Cancela seu fechamento, permite só que seja ocultada</param>

        private void telaAlunoMatricula_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IsShown = false;
            this.Hide();

            if (Program.ultimaTela != 4)
            {
                Program.SelecionaForm(Program.ultimaTela);
            }
            else
            {
                Program.ultimaTela = 7;
                Program.SelecionaForm(Program.ultimaTela);
            }
        }
        #endregion

        #region BUTTON MATRICULA 
        private void btnMatriculaAtividade_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 4;
            telaAlunoMatriculaAtividade telaalunomatriculaatividade = telaAlunoMatriculaAtividade.getInstancia();
            telaalunomatriculaatividade.Show();
        }

        private void btnMatriculaAtividade_MouseEnter(object sender, EventArgs e)
        {
            this.btnMatriculaAtividade.BackgroundImage = global::GuiWindowsForms.Properties.Resources.btn_add_atividade_48x48_hover;
            //lblInfoControles.Text = "Matricular aluno em uma atividade.";
            //lblInfoControles.Visible = true;
        }

        private void btnMatriculaAtividade_MouseLeave(object sender, EventArgs e)
        {
            this.btnMatriculaAtividade.BackgroundImage = global::GuiWindowsForms.Properties.Resources.btn_add_atividade_48x48;
            //lblInfoControles.Visible = false;
        }
        #endregion

        #region USER CONTROLS - Controle Inferior - Botões de Navegação

        private void ucAluno1_EventoVoltar()
        {
            this.Hide();

            if (Program.ultimaTela == 7)
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
            this.Hide();
            Program.ultimaTela = 7;
            telaAlunoResponsavel telaalunoresponsavel = telaAlunoResponsavel.getInstancia();
            telaalunoresponsavel.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaMedica()
        {
            this.Hide();
            Program.ultimaTela = 7;
            telaAlunoMedicacao telaalunomedicacao = telaAlunoMedicacao.getInstancia();
            telaalunomedicacao.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaMatricula()
        {
            this.Hide();
            Program.ultimaTela = 7;
            telaAlunoMatricula telaalunomatricula = telaAlunoMatricula.getInstancia();
            telaalunomatricula.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaFinanceiro()
        {
            this.Hide();
            Program.ultimaTela = 7;
            telaAlunoFinanceiro telaalunofinanceiro = telaAlunoFinanceiro.getInstancia();
            telaalunofinanceiro.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaDados()
        {
            this.Hide();
            Program.ultimaTela = 7;
            telaAluno telaaluno = telaAluno.getInstancia();
            telaaluno.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaAcademico()
        {
            this.Hide();
            Program.ultimaTela = 7;
            telaAlunoAcademico telaalunoacademico = telaAlunoAcademico.getInstancia();
            telaalunoacademico.Show();
        }

        #endregion

        #region USER CONTROLS - Menu Lateral
        private void uMenuLateral1_Load(object sender, EventArgs e)
        {
            uMenuLateral1.verificaTela(telaalunomatricula);
        }
        #endregion

        #region LOAD
        private void telaAlunoMatricula_Load(object sender, EventArgs e)
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
                    errorProviderTela.SetError(cmbSerie, "Informe a série");
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

                #region VALIDA - DESCONTO

                if (String.IsNullOrEmpty(cmbDesconto.Text))
                {
                    errorProviderTela.SetError(cmbDesconto, "Informe o desconto");
                    return;
                }

                #endregion

                #region VALIDA - VALOR

                if (String.IsNullOrEmpty(txtValor.Text))
                {
                    errorProviderTela.SetError(txtValor, "Informe o valor");
                    txtValor.Clear();
                    return;
                }

                #endregion

                #region VALIDA - VALOR TOTAL

                if (String.IsNullOrEmpty(txtTotalValor.Text))
                {
                    errorProviderTela.SetError(txtValor, "Informe o valor total");
                    txtTotalValor.Clear();
                    return;
                }

                #endregion

                #region VALIDA - VALOR TOTAL

                if (String.IsNullOrEmpty(cmbVencimento.Text))
                {
                    errorProviderTela.SetError(cmbVencimento, "Informe o vencimento");
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
        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void cmbSerie_TextChanged(object sender, EventArgs e)
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

        private void cmbDesconto_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void cmbVencimento_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }
        #endregion
    }
}
