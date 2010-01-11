using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.ModuloDesconto.Processos;

namespace GuiWindowsForms
{
    public partial class telaConfiguracoesDescontoMatricula : Form
    {
        Desconto desconto = new Desconto();

        IDescontoProcesso descontoControlador = null;

        #region SINGLETON DA TELA
        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaConfiguracoesDescontoMatricula telaconfiguracoesdesconto;

        private static bool IsShown = false;
        #endregion

        #region INSTANCIA TELA CONFIGURAÇÕES MATRICULA
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
        #endregion

        #region CONSTRUTOR
        /// <summary>
        /// Construtor da tela
        /// </summary>
        /// 
        public telaConfiguracoesDescontoMatricula()
        {
            InitializeComponent();
        }
        #endregion

        #region MÉTODO PARA VERIFICAR USO DA TELA
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
        /// Evento para o fechamento da tela, não fecha de verdade, 
        /// só a esconde, garantindo a usabilidade da tela
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
        #endregion

        #region USER CONTROLS - MENU ESQUERDA
        private void ucMenuConfiguracoesEsquerda1_EventoAbrirControleDeAcesso()
        {
            this.Hide();
            Program.ultimaTela = 10;
            telaConfiguracoesControleDeAcesso telaconfacesso = telaConfiguracoesControleDeAcesso.getInstancia();
            telaconfacesso.Show();
        }

        private void ucMenuConfiguracoesEsquerda1_Load(object sender, EventArgs e)
        {
            ucMenuConfiguracoesEsquerda1.verificaTela(telaconfiguracoesdesconto);
        }
        #endregion

        #region USER CONTROLS - MENU DIREITA
        private void ucMenuDireita1_EventoAbrirSerie()
        {

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
            ucMenuDireita1.verificaTela(telaconfiguracoesdesconto);
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
        private void telaConfiguracoesDescontoMatricula_Load(object sender, EventArgs e)
        {
            txtValor.Clear();
            txtDescricao.Clear();
        }
        #endregion

        #region EVENTO CADASTRAR
        private void ucMenuInferior1_Load(object sender, EventArgs e)
        {
            descontoControlador = DescontoProcesso.Instance;

            try
            {
                #region VALIDA - DESCRIÇÃO

                if (String.IsNullOrEmpty(txtDescricao.Text))
                {
                    errorProviderTela.SetError(txtDescricao, "Informe a descrição");
                    txtDescricao.Clear();
                    return;
                }
                desconto.Descricao = txtDescricao.Text;

                #endregion

                #region VALIDA - VALOR

                if (String.IsNullOrEmpty(txtDescricao.Text))
                {
                    errorProviderTela.SetError(txtValor, "Informe o valor");
                    txtValor.Clear();
                    return;
                }
                desconto.Percentual = Convert.ToDouble(txtValor.Text);

                #endregion

                descontoControlador.Incluir(desconto);
                descontoControlador.Confirmar();
            }
            catch (Exception ex)
            { 
            
            }
        }
        #endregion

        #region ERROR PROVIDER
        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }
        #endregion
    }
}
