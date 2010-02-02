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
    public partial class telaConfiguracoesControleDeAcesso : Form
    {
        #region SINGLETON DA TELA
        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaConfiguracoesControleDeAcesso telaconfiguracoesacesso;

        private static bool IsShown = false;
        #endregion

        #region INSTANCIA TELA CONTROLE DE ACESSO
        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. Evita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>

        public static telaConfiguracoesControleDeAcesso getInstancia()
        {
            if (telaconfiguracoesacesso == null)
            {
                telaconfiguracoesacesso = new telaConfiguracoesControleDeAcesso();
            }
            return telaconfiguracoesacesso;
        }
        #endregion

        #region CONSTRUTOR 
        /// <summary>
        /// Construtor da tela
        /// </summary>

        public telaConfiguracoesControleDeAcesso()
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

        private void telaConfiguracoesControleDeAcesso_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IsShown = false;
            this.Hide();

            Program.SelecionaForm(Program.ultimaTela);
        }
        #endregion

        #region USER CONTROLS - MENU CONFIGURAÇÕES ESQUERDA
        private void ucMenuConfiguracoesEsquerda1_EventoAbrirControleDeAcesso()
        {
            this.Hide();
            Program.ultimaTela = 10;
            telaConfiguracoesControleDeAcesso telaconfacesso = telaConfiguracoesControleDeAcesso.getInstancia();
            telaconfacesso.Show();
        }

        private void ucMenuConfiguracoesEsquerda1_Load(object sender, EventArgs e)
        {
            ucMenuConfiguracoesEsquerda1.verificaTela(telaconfiguracoesacesso);
        }
        #endregion

        #region USER CONTROLS - MENU CONFIGURAÇÕES DIREITA
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
            ucMenuDireita1.verificaTela(telaconfiguracoesacesso);
        }
        #endregion

        #region USER CONTROLS - MENU INFERIOR

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

        #region EVENTO CADASTRAR
        private void ucMenuInferior1_EventoCadastrar()
        {
            try
            {
                #region ALUNO

                

                #endregion

            }
            catch (Exception ex)
            { 
            
            }
        }
        #endregion

        #region SELECIONA O CHECKBOX 
        //seleciona o checkbox visualização correspondente quando é selecionado
        //o checkbox alteração
        private void ckbAlteracaoAluno_Click(object sender, EventArgs e)
        {
            ckbVisualizacaoAluno.Checked = true;
        }

        private void ckbAlteracaoFuncionario_Click(object sender, EventArgs e)
        {
            ckbVisualizacaoFuncionario.Checked = true;
        }

        private void ckbAlteracaoTurma_Click(object sender, EventArgs e)
        {
            ckbVisualizacaoTurma.Checked = true;
        }

        private void ckbAlteracaoSerie_Click(object sender, EventArgs e)
        {
            ckbVisualizacaoSerie.Checked = true;
        }

        private void ckbAlteracaoTurno_Click(object sender, EventArgs e)
        {
            ckbVisualizacaoTurno.Checked = true;
        }

        private void ckbAlteracaoRemanejamento_Click(object sender, EventArgs e)
        {
            ckbVisualizacaoRemanejamento.Checked = true;
        }

        private void ckbAlteracaoNotas_Click(object sender, EventArgs e)
        {
            ckbVisualizacaoNotas.Checked = true;
        }

        private void ckbAlteracaoMensalidades_Click(object sender, EventArgs e)
        {
            ckbVisualizacaoMensalidades.Checked = true;
        }

        private void ckbAlteracaoAtividades_Click(object sender, EventArgs e)
        {
            ckbVisualizacaoAtividades.Checked = true;
        }

        private void ckbAlteracaoContasPagar_Click(object sender, EventArgs e)
        {
            ckbVisualizacaoContasPagar.Checked = true;
        }

        private void ckbAlteracaoFinanceiro_Click(object sender, EventArgs e)
        {
            ckbVisualizacaoFinanceiro.Checked = true;
        }

        private void ckbAlteracaoBoletim_Click(object sender, EventArgs e)
        {
            ckbVisualizacaoBoletim.Checked = true;
        }

        private void ckbAlteracaoGre_Click(object sender, EventArgs e)
        {
            ckbVisualizacaoGre.Checked = true;
        }

        private void ckbAlteracaoDebitos_Click(object sender, EventArgs e)
        {
            ckbVisualizacaoDebitos.Checked = true;
        }

        private void ckbAlteracaoCheques_Click(object sender, EventArgs e)
        {
            ckbVisualizacaoCheques.Checked = true;
        }

        private void ckbAlteracaoHistorico_Click(object sender, EventArgs e)
        {
            ckbVisualizacaoHistorico.Checked = true;
        }

        private void ckbAlteracaoCertificado_Click(object sender, EventArgs e)
        {
            ckbVisualizacaoCertificado.Checked = true;
        }

        private void ckbAlteracaoAniver_Click(object sender, EventArgs e)
        {
            ckbVisualizacaoAniver.Checked = true;
        }

        private void ckbAlteracaoDeclaQuitacao_Click(object sender, EventArgs e)
        {
            ckbVisualizacaoDeclaQuitacao.Checked = true;
        }

        private void ckbAlteracaoFolhaPonto_Click(object sender, EventArgs e)
        {
            ckbVisualizacaoFolhaPonto.Checked = true;
        }

        private void ckbAlteracaoFreqFuncionario_Click(object sender, EventArgs e)
        {
            ckbVisualizacaoFreqFuncionario.Checked = true;
        }

        private void ckbAlteracaoEnviarEmail_Click(object sender, EventArgs e)
        {
            ckbVisualizacaoEnviarEmail.Checked = true;
        }

        private void ckbAlteracaFreqAlunos_Click(object sender, EventArgs e)
        {
            ckbVisualizacaoFreqAlunos.Checked = true;
        }

        private void ckbAlteracaoRankingNotas_Click(object sender, EventArgs e)
        {
            ckbVisualizacaoRankingNotas.Checked = true;
        }

        private void ckbAlteracaoAdvertAtraso_Click(object sender, EventArgs e)
        {
            ckbVisualizacaoAdvertAtraso.Checked = true;
        }

        private void ckbAlteracaoAnotacoes_Click(object sender, EventArgs e)
        {
            ckbVisualizacaoAnotacoes.Checked = true;
        }

        private void ckbAlteracaoFolhaCham_Click(object sender, EventArgs e)
        {
            ckbVisualizacaoFolhaCham.Checked = true;
        }

        #endregion

        private void ucDesconectarLogin1_EventoDesconectar()
        {
            Program.ultimaTela = 9;
            this.Close();
            telaLogin telalogin = telaLogin.getInstancia();
            telalogin.Show();
        }

        private void cmbFuncionario_MouseEnter(object sender, EventArgs e)
        {
            ucMenuInferior1.exibirMensagem("Selecione um funcionário para a criação do perfil vinculado");
        }

        private void cmbFuncionario_MouseLeave(object sender, EventArgs e)
        {
            ucMenuInferior1.ocultarMensagem();
        }

        private void telaConfiguracoesControleDeAcesso_Activated(object sender, EventArgs e)
        {
            ucMenuDireita1.verificaTela(telaConfiguracoesControleDeAcesso.getInstancia());
        }


    }
}
