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

        #region USER CONTROLS - MENU INFERIOR
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
        #endregion

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

                #region VALIDA - ENDEREÇO

                if (String.IsNullOrEmpty(txtLogradouro.Text))
                {
                    errorProviderTela.SetError(txtLogradouro, "Informe o endereço");
                    txtLogradouro.Clear();
                    return;
                }

                #endregion

                #region VALIDA - COMPLEMENTO

                if (String.IsNullOrEmpty(txtComplemento.Text))
                {
                    errorProviderTela.SetError(txtComplemento, "Informe o complemento");
                    txtComplemento.Clear();
                    return;
                }

                #endregion

                #region VALIDA - NOME EDIFÍCIL

                if (String.IsNullOrEmpty(txtNomeEdificil.Text))
                {
                    errorProviderTela.SetError(txtNomeEdificil, "Informe o nome edifícil");
                    txtNomeEdificil.Clear();
                    return;
                }

                #endregion

                #region VALIDA - BAIRRO

                if (String.IsNullOrEmpty(txtBairro.Text))
                {
                    errorProviderTela.SetError(txtBairro, "Informe o bairro");
                    txtBairro.Clear();
                    return;
                }

                #endregion

                #region VALIDA - UF

                if (String.IsNullOrEmpty(cmbUf.Text))
                {
                    errorProviderTela.SetError(cmbUf, "Informe o uf");
                    return;
                }

                #endregion

                #region VALIDA - CIDADE

                if (String.IsNullOrEmpty(txtCidade.Text))
                {
                    errorProviderTela.SetError(txtCidade, "Informe a cidade");
                    txtCidade.Clear();
                    return;
                }

                #endregion

                #region VALIDA - CEP

                if (mskCep.MaskCompleted == false)
                {
                    errorProviderTela.SetError(mskCep, "Informe o cep");
                    mskCep.Clear();
                    return;
                }

                #endregion

                #region VALIDA - FONE RESIDENCIA

                if (mskFoneResidencia.MaskCompleted == false)
                {
                    errorProviderTela.SetError(mskFoneResidencia, "Informe o fone da residência");
                    mskFoneResidencia.Clear();
                    return;
                }

                #endregion

                #region VALIDA - FILIAÇÃO PAI

                if (String.IsNullOrEmpty(txtFiliacaoPai.Text))
                {
                    errorProviderTela.SetError(txtFiliacaoPai, "Informe o nome do pai");
                    txtFiliacaoPai.Clear();
                    return;
                }

                #endregion

                #region VALIDA - FILIAÇÃO MÃE

                if (String.IsNullOrEmpty(txtFiliacaoMae.Text))
                {
                    errorProviderTela.SetError(txtFiliacaoMae, "Informe o nome da mãe");
                    txtFiliacaoMae.Clear();
                    return;
                }

                #endregion

                #region VALIDA - ESTADO CIVIL

                if (String.IsNullOrEmpty(cmbEstadoCivil.Text))
                {
                    errorProviderTela.SetError(cmbEstadoCivil, "Informe o estado civil");
                    return;
                }

                #endregion

                #region VALIDA - NACIONALIDADE

                if (String.IsNullOrEmpty(cmbNacionalidade.Text))
                {
                    errorProviderTela.SetError(cmbNacionalidade, "Informe a nacionalidade");
                    return;
                }

                #endregion

            }
            catch (Exception ex) 
            { 
            

            }
        }
        #endregion

        #region STRING PARA ALIMENTAR COMBOBOX

        string[] estados = { "", "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" };

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

        #region LOAD
        private void telaFuncionario_Load(object sender, EventArgs e)
        {
            cmbUf.DataSource = estados;
        }
        #endregion

        #region TEXTBOX UF EVENTO SELECTED
        // Quando selecionar a UF o campo CIDADE é selecionado a capital correspondente
        private void cmbUf_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbUf.Text == "") { txtCidade.Text = ""; }
            if (cmbUf.Text == "AC") { txtCidade.Text = "RIO BRANCO"; }
            if (cmbUf.Text == "AL") { txtCidade.Text = "MACEIO"; }
            if (cmbUf.Text == "AM") { txtCidade.Text = "MANAUS"; }
            if (cmbUf.Text == "AP") { txtCidade.Text = "MACAPÁ"; }
            if (cmbUf.Text == "BA") { txtCidade.Text = "SALVADOR"; }
            if (cmbUf.Text == "CE") { txtCidade.Text = "FORTALEZA"; }
            if (cmbUf.Text == "DF") { txtCidade.Text = "BRASÍLIA"; }
            if (cmbUf.Text == "ES") { txtCidade.Text = "VITÓRIA"; }
            if (cmbUf.Text == "GO") { txtCidade.Text = "GOIÂNIA"; }
            if (cmbUf.Text == "MA") { txtCidade.Text = "SÃO LUIZ"; }
            if (cmbUf.Text == "MG") { txtCidade.Text = "BELO HORIZONTE"; }
            if (cmbUf.Text == "MS") { txtCidade.Text = "CAMPO GRANDE"; }
            if (cmbUf.Text == "MT") { txtCidade.Text = "CUIABÁ"; }
            if (cmbUf.Text == "PA") { txtCidade.Text = "BELÉM"; }
            if (cmbUf.Text == "PB") { txtCidade.Text = "JOÃO PESSOA"; }
            if (cmbUf.Text == "PE") { txtCidade.Text = "RECIFE"; }
            if (cmbUf.Text == "PI") { txtCidade.Text = "TEREZINA"; }
            if (cmbUf.Text == "PR") { txtCidade.Text = "PARANÁ"; }
            if (cmbUf.Text == "RJ") { txtCidade.Text = "RIO DE JANEIRO"; }
            if (cmbUf.Text == "RN") { txtCidade.Text = "NATAL"; }
            if (cmbUf.Text == "RO") { txtCidade.Text = "PORTO VELHO"; }
            if (cmbUf.Text == "RR") { txtCidade.Text = "BOA VISTA"; }
            if (cmbUf.Text == "RS") { txtCidade.Text = "PORTO ALEFRE"; }
            if (cmbUf.Text == "SC") { txtCidade.Text = "FLORIANÓPOLIS"; }
            if (cmbUf.Text == "SE") { txtCidade.Text = "ARACAJÚ"; }
            if (cmbUf.Text == "SP") { txtCidade.Text = "SÃO PAULO"; }
            if (cmbUf.Text == "TO") { txtCidade.Text = "PALMAS"; }
        }
        #endregion
    }
}
