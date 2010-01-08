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
    public partial class telaFuncionarioDadosProfissionais : Form
    {
        #region SINGLETON DA TELA
        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaFuncionarioDadosProfissionais teladfuncProfissional;

        private static bool IsShown = false;
        #endregion

        #region INSTANCIA TELA FUNCIONARIO
        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. Evita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>

        public static telaFuncionarioDadosProfissionais getInstancia()
        {
            if (teladfuncProfissional == null)
            {
                teladfuncProfissional = new telaFuncionarioDadosProfissionais();
            }
            return teladfuncProfissional;
        }
        #endregion

        #region CONSTRUTOR
        /// <summary>
        /// Construtor da tela
        /// </summary>

        public telaFuncionarioDadosProfissionais()
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
        /// Evento para o fechamento da tela, não fecha de verdade, só a esconde, 
        /// garantindo a usabilidade da tela
        /// pelo singleton
        /// </summary>
        /// <param name="sender">Tela</param>
        /// <param name="e">Cancela seu fechamento, permite só que seja ocultada</param>

        private void telaFuncionarioDadosProfissionais_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IsShown = false;
            this.Hide();

            Program.ultimaTela = 17;
            Program.SelecionaForm(Program.ultimaTela);
        }
        #endregion

        #region Controle dos textos e das ações dos botões de ação inferiores



        ///// <summary>
        ///// Retorna para tela anterior ocultando a atual e chamando a instância da última tela acessada
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>

        //private void btnVoltar_Click(object sender, EventArgs e)
        //{
        //    this.Hide();

        //    Program.ultimaTela = 17;
        //    Program.SelecionaForm(Program.ultimaTela);
        //}

        #endregion

        #region BUTTON IMPRIMIR
        //private void btnImprimir_MouseEnter(object sender, EventArgs e)
        //{
        //    lblInfoControles.Text = "Abrir impressões.";
        //    lblInfoControles.Visible = true;
        //    this.btnImprimir.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_imprimir_50x50_hover;
        //}

        private void btnImprimir_MouseLeave(object sender, EventArgs e)
        {
            //lblInfoControles.Visible = false;
            this.btnImprimir.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_imprimir_50x50;
        }
        #endregion

        #region USER CONTROLS - MENU INFERIOR
        private void ucMenuInferior1_EventoVoltar()
        {
            this.Hide();

            if (Program.ultimaTela != 7)
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

        #region USER CONTROLS - MENU LATERAL
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

        private void ucMenuLateralFunc1_Load(object sender, EventArgs e)
        {
            ucMenuLateralFunc1.verificaTela(teladfuncProfissional);
        }
        #endregion

        #region LOAD
        private void telaFuncionarioDadosProfissionais_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region EVENTO CADASTRAR
        private void ucMenuInferior1_EventoCadastrar()
        {

            try
            {
                #region VALIDA - CPF
                if (mskCpf.MaskCompleted == false)
                {
                    errorProviderTela.SetError(mskCpf, "Informe o cpf");
                    mskCpf.Clear();
                    return;
                }
                #endregion

                #region VALIDA - CBO

                if (String.IsNullOrEmpty(txtCBO.Text))
                {
                    errorProviderTela.SetError(txtCBO, "Informe o C.B.O");
                    txtCBO.Clear();
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

                #region VALIDA - EMISSOR

                if (String.IsNullOrEmpty(txtEmissor.Text))
                {
                    errorProviderTela.SetError(txtRg, "Informe o órgão emissor");
                    txtEmissor.Clear();
                    return;
                }


                #endregion

                #region VALIDA - EMISSOR UF

                if (String.IsNullOrEmpty(cmbEmissorUf.Text))
                {
                    errorProviderTela.SetError(cmbEmissorUf, "Informe o uf");
                    return;
                }

                #endregion

                #region VALIDA - TITULO ELEITOR

                if (String.IsNullOrEmpty(txtTituloEleitor.Text))
                {
                    errorProviderTela.SetError(txtTituloEleitor, "Informe o titulo eleitor");
                    txtTituloEleitor.Clear();
                    return;
                }

                #endregion            

                #region VALIDA - ZONA

                if (String.IsNullOrEmpty(txtZona.Text))
                {
                    errorProviderTela.SetError(txtZona, "Informe a zona");
                    txtZona.Clear();
                    return;
                }

                #endregion

                #region VALIDA - PIS

                if (String.IsNullOrEmpty(txtPis.Text))
                {
                    errorProviderTela.SetError(txtPis, "Informe o PIS");
                    txtPis.Clear();
                    return;
                }

                #endregion

                #region VALIDA - CTPS

                if (String.IsNullOrEmpty(txtCtps.Text))
                {
                    errorProviderTela.SetError(txtCtps, "Informe o Ctps");
                    txtCtps.Clear();
                    return;
                }

                #endregion

                #region VALIDA - SERIE

                if (String.IsNullOrEmpty(txtSerie.Text))
                {
                    errorProviderTela.SetError(txtSerie, "Informe a série");
                    txtSerie.Clear();
                    return;
                }

                #endregion

                #region VALIDA - NACIONALIDADE

                if (String.IsNullOrEmpty(cmbGrau.Text))
                {
                    errorProviderTela.SetError(cmbGrau, "Informe a nacionalidade");
                    return;
                }

                #endregion

                #region VALIDA - COR

                if (String.IsNullOrEmpty(cmbCor.Text))
                {
                    errorProviderTela.SetError(cmbCor, "Informe a cor");
                    return;
                }

                #endregion

                #region VALIDA - PRIMEIRO EMPREGO

                if (rdbSim.Checked == false && rdbNao.Checked == false)
                {
                    errorProviderTela.SetError(rdbNao, "Informe o primeiro emprego");
                    return;
                }

                #endregion

                #region VALIDA - CURSO

                if (String.IsNullOrEmpty(txtCurso.Text))
                {
                    errorProviderTela.SetError(txtSerie, "Informe o curso");
                    txtCurso.Clear();
                    return;
                }

                #endregion

                #region VALIDA - INSTITUIÇÃO

                if (String.IsNullOrEmpty(txtInstituicao.Text))
                {
                    errorProviderTela.SetError(txtInstituicao, "Informe a instituição");
                    txtInstituicao.Clear();
                    return;
                }

                #endregion

                #region VALIDA - FUNÇÃO

                if (String.IsNullOrEmpty(cmbFuncao.Text))
                {
                    errorProviderTela.SetError(cmbFuncao, "Informe a função");
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
        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtCBO_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtRg_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtEmissor_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtEmissorUf_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtTituloEleitor_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtZona_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtPis_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtCtps_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtSerie_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void cmbGrau_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void cmbCor_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void rdbSim_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void rdbNao_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtCurso_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtInstituicao_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void cmbFuncao_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }
#endregion

    }
}
