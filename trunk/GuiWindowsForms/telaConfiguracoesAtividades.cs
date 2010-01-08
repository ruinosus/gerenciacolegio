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
    public partial class telaConfiguracoesAtividade : Form
    {
        #region SINGLETON DA TELA
        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaConfiguracoesAtividade telaconfiguracoesatividades;

        private static bool IsShown = false;
        #endregion

        #region INSTANCIA TELA CONFIGURACOES ATIVIDADES
        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. 
        /// Evita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>

        public static telaConfiguracoesAtividade getInstancia()
        {
            if (telaconfiguracoesatividades == null)
            {
                telaconfiguracoesatividades = new telaConfiguracoesAtividade();
            }
            return telaconfiguracoesatividades;
        }
        #endregion

        #region CONSTRUTOR
        /// <summary>
        /// Construtor da tela
        /// </summary>

        public telaConfiguracoesAtividade()
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

        private void telaConfiguracoesAtividades_FormClosing(object sender, FormClosingEventArgs e)
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
            ucMenuConfiguracoesEsquerda1.verificaTela(telaconfiguracoesatividades);
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
            ucMenuDireita1.verificaTela(telaconfiguracoesatividades);
        }
        #endregion

        #region USER CONTROLS MENU CONTROLE INFERIOR 

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
        private void ckbTerca_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region EVENTRO CADASTRAR
        private void ucMenuInferior1_EventoCadastrar()
        {
            #region VALIDA - CONFIGURAÇÕES ATIVIDADES

            if (String.IsNullOrEmpty(txtDescricao.Text))
            {
                errorProviderTela.SetError(txtDescricao, "Informe a configuração de atividades");
                txtDescricao.Clear();
                return;
            }

            #endregion

            #region VALIDA - TURMA

            if (String.IsNullOrEmpty(txtTurma.Text))
            {
                errorProviderTela.SetError(txtTurma, "Informe a turma");
                txtTurma.Clear();
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

            #region VALIDA - DIA DA SEMANA
            if (ckbDomingo.Checked == false && ckbSegunda.Checked == false && ckbTerca.Checked == false &&
                ckbQuarta.Checked == false && ckbQuinta.Checked == false && ckbSexta.Checked == false && ckbSabado.Checked == false) 
            {
                errorProviderTela.SetError(txtValor, "Informe o dia da semana");
                return;
            }
            #endregion
        }
        #endregion

        #region LIMPAR ERRO PROVIDER
        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void ckbDomingo_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void checkBox2_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void checkBox1_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void ckbQuarta_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void ckbQuinta_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void ckbSexta_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void ckbSabado_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }
        #endregion

    }
}
