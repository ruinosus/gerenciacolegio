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
    public partial class telaFuncionario : Form
    {
        #region SINGLETON DA TELA
        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaFuncionario teladfunc;

        private static bool IsShown = false;
        #endregion

        #region INSTANCIA TELA FUNCIONARIO
        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. 
        /// Evita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>

        public static telaFuncionario getInstancia()
        {
            if (teladfunc == null)
            {
                teladfunc = new telaFuncionario();
            }
            return teladfunc;
        }
        #endregion

        #region CONSTRUTOR
        /// <summary>
        /// Construtor da tela
        /// </summary>
        
        public telaFuncionario()
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
        /// Evento para o fechamento da tela, não fecha de verdade, 
        /// só a esconde, garantindo a usabilidade da tela
        /// pelo singleton
        /// </summary>
        /// <param name="sender">Tela</param>
        /// <param name="e">Cancela seu fechamento, permite só que seja ocultada</param>

        private void telaFuncionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IsShown = false;
            this.Hide();

            if (Program.ultimaTela != 17)
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


        private void ucMenuInferior1_EventoVoltar()
        {
            this.Hide();

            if (Program.ultimaTela != 17)
            {
                Program.SelecionaForm(Program.ultimaTela);
            }
            else
            {
                Program.ultimaTela = 6;
                Program.SelecionaForm(Program.ultimaTela);
            }
        }

        private void ucMenuLateralFunc1_EventoAbrirDadosProfissionais()
        {
            this.Hide();
            Program.ultimaTela = 17;
            telaFuncionarioDadosProfissionais telaafuncprofissionais = telaFuncionarioDadosProfissionais.getInstancia();
            telaafuncprofissionais.Show();
        }

        private void ucMenuLateralFunc1_EventoAbrirDadosPessoais()
        {
            this.Hide();
            Program.ultimaTela = 17;
            telaFuncionario telaafuncdados = telaFuncionario.getInstancia();
            telaafuncdados.Show();
        }

        #region LOAD
        private void ucMenuLateralFunc1_Load(object sender, EventArgs e)
        {
            ucMenuLateralFunc1.verificaTela(teladfunc);
        }
        #endregion

        #region EVENTO CADASTRAR
        private void ucMenuInferior1_EventoCadastrar()
        {
            try
            {
                #region VALIDA - NOME

                if (String.IsNullOrEmpty(txtNome.Text))
                {
                    errorProviderTela.SetError(txtNome, "Informe o nome");
                    txtNome.Clear();
                    return;
                }

                #endregion

                #region VALIDA - SEXO

                if (rdbMasc.Checked == false && rdbFem.Checked == false)
                {
                    errorProviderTela.SetError(rdbFem, "Informe o sexo");
                    return;
                }

                #endregion

                #region VALIDA - CPF

                if (mskCpf.MaskCompleted == false)
                {
                    errorProviderTela.SetError(mskCpf, "Informe o cpf");
                    mskCpf.Clear();
                    return;
                }

                #endregion

                #region VALIDA - IDENTIDADE

                if (String.IsNullOrEmpty(txtRg.Text))
                {
                    errorProviderTela.SetError(txtRg, "Informe a identidade");
                    txtRg.Clear();
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
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void rdbMasc_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void rdbFem_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void mskCpf_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtRg_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtLogradouro_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtNomeEdificil_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void cmbUf_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void mskCep_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void mskFoneResidencia_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtFiliacaoPai_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtFiliacaoMae_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void cmbNacionalidade_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }
        #endregion
    }
}
