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
    public partial class telaAlunoMatriculaAtividade : Form
    {
        Memoria memoria = Memoria.Instance;

        #region SINGLETON DA TELA
        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaAlunoMatriculaAtividade telaalunomatriculatividade;

        private static bool IsShown = false;
        #endregion

        #region INSTANCIA TELA MATRICULA
        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. E
        /// vita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>

        public static telaAlunoMatriculaAtividade getInstancia()
        {
            if (telaalunomatriculatividade == null)
            {
                telaalunomatriculatividade = new telaAlunoMatriculaAtividade();
            }
            return telaalunomatriculatividade;
        }
        #endregion

        #region CONSTRUTOR
        /// <summary>
        /// Construtor da tela
        /// </summary>

        public telaAlunoMatriculaAtividade()
        {
            InitializeComponent();
        }
        #endregion

        #region MÉTODO PARA VERIFICAR USO DA TELA
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
        /// Evento para o fechamento da tela, não fecha de verdade, só a esconde, 
        /// garantindo a usabilidade da tela
        /// pelo singleton
        /// </summary>
        /// <param name="sender">Tela</param>
        /// <param name="e">Cancela seu fechamento, permite só que seja ocultada</param>

        private void telaAlunoMatriculaAtividade_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IsShown = false;
            this.Hide();

            Program.ultimaTela = 4;
            Program.SelecionaForm(Program.ultimaTela);
        }
        #endregion
        
        #region BUTTON MATRICULA ATIVIDADE
 
        private void btnMatriculaSerie_MouseEnter(object sender, EventArgs e)
        {
            this.btnMatriculaSerie.BackgroundImage = global::GuiWindowsForms.Properties.Resources.add_matricula_47x49_hover;
            //lblInfoControles.Text = "Matricular um aluno.";
            //lblInfoControles.Visible = true;
        }

        private void btnMatriculaSerie_MouseLeave(object sender, EventArgs e)
        {
            this.btnMatriculaSerie.BackgroundImage = global::GuiWindowsForms.Properties.Resources.add_matricula_47x49;
            //lblInfoControles.Visible = false;
        }

        private void btnMatriculaSerie_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 6;
            telaAlunoMatricula telaalunomatricula = telaAlunoMatricula.getInstancia();
            telaalunomatricula.Show();

        }

        #endregion

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

        #endregion

        #region USER CONTROLS - Menu Lateral

        private void uMenuLateral1_Load(object sender, EventArgs e)
        {
            uMenuLateral1.verificaTela(telaalunomatriculatividade);
        }

        #endregion

        #region LOAD
        private void telaAlunoMatriculaAtividade_Load(object sender, EventArgs e)
        {
            uMenuImagem1.ocultarBotaoAdicionarImagem();
        }
        #endregion

        #region EVENTO CADASTRAR

        private void ucMenuInferior1_EventoCadastrar()
        {
            try
            {
                #region VALIDA - ATIVIDADE

                if (String.IsNullOrEmpty(cmbAtividade.Text))
                {
                    errorProviderTela.SetError(cmbAtividade, "Informe a atividade");
                    return;
                }

                #endregion

                #region VALIDA - DESCRIÇÃO

                if (String.IsNullOrEmpty(txtDescricao.Text))
                {
                    errorProviderTela.SetError(txtDescricao, "Informe a descrição");
                    txtDescricao.Clear();
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

                #region VALIDA - DESCONTO

                if (String.IsNullOrEmpty(txtDesconto.Text))
                {
                    errorProviderTela.SetError(txtDesconto, "Informe o valor");
                    txtDesconto.Clear();
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



            }
            catch (Exception ex)
            { 
            
            }
        }

        #endregion

        #region LIMPAR ERRO PROVIDER
        private void cmbAtividade_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void btnAdicionarImagem_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }
        #endregion

        private void ucDesconectarLogin1_EventoDesconectar()
        {
            Program.ultimaTela = 9;
            this.Close();
            telaLogin telalogin = telaLogin.getInstancia();
            telalogin.Show();
        }

        private void telaAlunoMatriculaAtividade_Activated(object sender, EventArgs e)
        {
            uMenuLateral1.verificaTela(telaalunomatriculatividade);
            uMenuImagem1.ocultarBotaoAdicionarImagem();

            if (memoria.Aluno != null)
            {
                uMenuImagem1.carregaAluno(memoria.Aluno);
            }
        }
    }
}
