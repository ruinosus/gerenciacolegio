using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.ModuloFuncionario.Constantes;
using Negocios.ModuloFuncionario.Processos;
using Negocios.ModuloBasico.VOs;
using Negocios.ModuloBasico.Enums;

namespace GuiWindowsForms
{
    public partial class telaFuncionario : Form
    {
        Funcionario funcionario = null;
        IFuncionarioProcesso funcionarioControlador = FuncionarioProcesso.Instance;

        //atributo para verificar se o button de Alterar foi clicado 
        int verificaButton = 0;


        public static int verificaFoto = 0;

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

        #region USER CONTROLS - Controle Inferior - Botões de Navegação

        #region EVENTO VOLTAR
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

        #region EVENTO ALTERAR
        private void ucMenuInferior1_EventoAlterar()
        {
            Enabled_True();
            ucMenuLateralFunc1.Enabled = false;
            btnImprimir.Enabled = false;
            verificaButton = 1;
        }
        #endregion

        #region EVENTO CADASTRAR
        private void ucMenuInferior1_EventoCadastrar()
        {
            try
            {
                #region CADASTRAR FUNCIONARIO


                if (verificaButton == 0)
                {

                    #region VALIDA - NOME

                    if (String.IsNullOrEmpty(txtNome.Text))
                    {
                        errorProviderTela.SetError(txtNome, "Informe o nome");
                        txtNome.Clear();
                        return;
                    }
                    funcionario.Nome = txtNome.Text;

                    #endregion

                    #region VALIDA - SEXO

                    if (rdbMasc.Checked == false && rdbFem.Checked == false)
                    {
                        errorProviderTela.SetError(rdbFem, "Informe o sexo");
                        return;
                    }
                    if (rdbFem.Checked == true)
                    {
                        funcionario.Sexo = 0;
                    }
                    else
                    {
                        funcionario.Sexo = 1;
                    }

                    #endregion

                    #region VALIDA - NASCIMENTO

                    funcionario.Nascimento = dtpNascimento.Value;

                    #endregion

                    #region VALIDA - IDENTIDADE

                    //if (String.IsNullOrEmpty(txtRg.Text))
                    //{
                    //    errorProviderTela.SetError(txtRg, "Informe a identidade");
                    //    txtRg.Clear();
                    //    return;
                    //}
                    funcionario.Rg = txtRg.Text;

                    #endregion

                    #region VALIDA - CPF

                    //if (mskCpf.MaskCompleted == false)
                    //{
                    //    errorProviderTela.SetError(mskCpf, "Informe o cpf");
                    //    mskCpf.Clear();
                    //    return;
                    //}
                    funcionario.Cpf = mskCpf.Text;

                    #endregion

                    #region VALIDA - NACIONALIDADE

                    //if (String.IsNullOrEmpty(cmbNacionalidade.Text))
                    //{
                    //    errorProviderTela.SetError(cmbNacionalidade, "Informe a nacionalidade");
                    //    return;
                    //}
                    funcionario.Nacionalidade = cmbNacionalidade.Text;

                    #endregion

                    #region VALIDA - NATURALIDADE

                    //if (String.IsNullOrEmpty(txtNaturalidade.Text))
                    //{
                    //    errorProviderTela.SetError(txtNaturalidade, "Informe a naturalidade");
                    //    txtNaturalidade.Clear();
                    //    return;
                    //}
                    funcionario.Naturalidade = txtNaturalidade.Text;

                    #endregion

                    #region VALIDA - ESTADO CIVIL

                    //if (String.IsNullOrEmpty(cmbEstadoCivil.Text))
                    //{
                    //    errorProviderTela.SetError(cmbEstadoCivil, "Informe o estado civil");
                    //    return;
                    //}
                    funcionario.EstadoCivil = cmbEstadoCivil.Text;

                    #endregion

                    #region VALIDA - ENDEREÇO

                    //if (String.IsNullOrEmpty(txtLogradouro.Text))
                    //{
                    //    errorProviderTela.SetError(txtLogradouro, "Informe o endereço");
                    //    txtLogradouro.Clear();
                    //    return;
                    //}
                    funcionario.Logradouro = txtLogradouro.Text;

                    #endregion

                    #region VALIDA - COMPLEMENTO

                    //if (String.IsNullOrEmpty(txtComplemento.Text))
                    //{
                    //    errorProviderTela.SetError(txtComplemento, "Informe o complemento");
                    //    txtComplemento.Clear();
                    //    return;
                    //}
                    funcionario.ComplementoEndereco = txtComplemento.Text;

                    #endregion

                    #region VALIDA - NOME EDIFÍCIL

                    //if (String.IsNullOrEmpty(txtNomeEdificil.Text))
                    //{
                    //    errorProviderTela.SetError(txtNomeEdificil, "Informe o nome edifícil");
                    //    txtNomeEdificil.Clear();
                    //    return;
                    //}
                    funcionario.Edificio = txtNomeEdificil.Text;

                    #endregion

                    #region VALIDA - BAIRRO

                    //if (String.IsNullOrEmpty(txtBairro.Text))
                    //{
                    //    errorProviderTela.SetError(txtBairro, "Informe o bairro");
                    //    txtBairro.Clear();
                    //    return;
                    //}
                    funcionario.Bairro = txtBairro.Text;

                    #endregion

                    #region VALIDA - CEP

                    //if (mskCep.MaskCompleted == false)
                    //{
                    //    errorProviderTela.SetError(mskCep, "Informe o cep");
                    //    mskCep.Clear();
                    //    return;
                    //}
                    funcionario.Cep = mskCep.Text;

                    #endregion

                    #region VALIDA - UF

                    //if (String.IsNullOrEmpty(cmbUf.Text))
                    //{
                    //    errorProviderTela.SetError(cmbUf, "Informe o uf");
                    //    return;
                    //}
                    funcionario.Uf = cmbUf.Text;

                    #endregion

                    #region VALIDA - CIDADE

                    //if (String.IsNullOrEmpty(txtCidade.Text))
                    //{
                    //    errorProviderTela.SetError(txtCidade, "Informe a cidade");
                    //    txtCidade.Clear();
                    //    return;
                    //}
                    funcionario.Cidade = txtCidade.Text;

                    #endregion

                    #region VALIDA - FONE

                    //if (mskFoneResidencia.MaskCompleted == false)
                    //{
                    //    errorProviderTela.SetError(mskFoneResidencia, "Informe o fone da residência");
                    //    mskFoneResidencia.Clear();
                    //    return;
                    //}
                    funcionario.FoneEmergencia = mskFoneResidencia.Text;

                    #endregion

                    #region VALIDA - FONE OPCIONAL

                    //if (mskFoneOpcional.MaskCompleted == false)
                    //{
                    //    errorProviderTela.SetError(mskFoneOpcional, "Informe um fone opcional");
                    //    mskFoneOpcional.Clear();
                    //    return;
                    //}
                    funcionario.FoneOpcional = mskFoneOpcional.Text;

                    #endregion

                    #region VALIDA - FILIAÇÃO PAI

                    //if (String.IsNullOrEmpty(txtFiliacaoPai.Text))
                    //{
                    //    errorProviderTela.SetError(txtFiliacaoPai, "Informe o nome do pai");
                    //    txtFiliacaoPai.Clear();
                    //    return;
                    //}
                    funcionario.FiliacaoPai = txtFiliacaoPai.Text;

                    #endregion

                    #region VALIDA - FILIAÇÃO MÃE

                    //if (String.IsNullOrEmpty(txtFiliacaoMae.Text))
                    //{
                    //    errorProviderTela.SetError(txtFiliacaoMae, "Informe o nome da mãe");
                    //    txtFiliacaoMae.Clear();
                    //    return;
                    //}
                    funcionario.FiliacaoMae = txtFiliacaoMae.Text;

                    #endregion

                    funcionario.PerfilID = 1;
                    funcionario.Status = (int)Status.Ativo;

                    funcionario = ucMenuImagemFunc1.retornaFuncionario(funcionario);
                    Memoria memoria = Memoria.Instance;
                    if (memoria.Funcionario == null)
                    {
                        if (verificaSeJaCadastrado(funcionario) == false)
                        {
                            funcionario = ucMenuImagemFunc1.retornaFuncionario(funcionario);
                            funcionarioControlador.Incluir(funcionario);
                            funcionarioControlador.Confirmar();
                            ucMenuImagemFunc1.carregaFuncionario(funcionario);

                            memoria.Funcionario = funcionario;

                            MessageBox.Show(FuncionarioConstantes.FUNCIONARIO_INCLUIDO, "Colégio Conhecer");
                        }
                        else
                        {
                            funcionarioControlador.Alterar(funcionario);
                            ucMenuImagemFunc1.carregaFuncionario(funcionario);

                            MessageBox.Show(FuncionarioConstantes.FUNCIONARIO_ALTERADO, "Colégio Conhecer");
                        }

                    }
                }

                #endregion

                #region ALTERAR FUNCIONARIO


                if (verificaButton == 1)
                {

                    #region VALIDA - NOME

                    if (String.IsNullOrEmpty(txtNome.Text))
                    {
                        errorProviderTela.SetError(txtNome, "Informe o nome");
                        txtNome.Clear();
                        return;
                    }
                    funcionario.Nome = txtNome.Text;

                    #endregion

                    #region VALIDA - SEXO

                    if (rdbMasc.Checked == false && rdbFem.Checked == false)
                    {
                        errorProviderTela.SetError(rdbFem, "Informe o sexo");
                        return;
                    }
                    if (rdbFem.Checked == true)
                    {
                        funcionario.Sexo = 0;
                    }
                    else
                    {
                        funcionario.Sexo = 1;
                    }

                    #endregion

                    #region VALIDA - NASCIMENTO

                    funcionario.Nascimento = dtpNascimento.Value;

                    #endregion

                    #region VALIDA - IDENTIDADE

                    //if (String.IsNullOrEmpty(txtRg.Text))
                    //{
                    //    errorProviderTela.SetError(txtRg, "Informe a identidade");
                    //    txtRg.Clear();
                    //    return;
                    //}
                    funcionario.Rg = txtRg.Text;

                    #endregion

                    #region VALIDA - CPF

                    //if (mskCpf.MaskCompleted == false)
                    //{
                    //    errorProviderTela.SetError(mskCpf, "Informe o cpf");
                    //    mskCpf.Clear();
                    //    return;
                    //}
                    funcionario.Cpf = mskCpf.Text;

                    #endregion

                    #region VALIDA - NACIONALIDADE

                    //if (String.IsNullOrEmpty(cmbNacionalidade.Text))
                    //{
                    //    errorProviderTela.SetError(cmbNacionalidade, "Informe a nacionalidade");
                    //    return;
                    //}
                    funcionario.Nacionalidade = cmbNacionalidade.Text;

                    #endregion

                    #region VALIDA - NATURALIDADE

                    //if (String.IsNullOrEmpty(txtNaturalidade.Text))
                    //{
                    //    errorProviderTela.SetError(txtNaturalidade, "Informe a naturalidade");
                    //    txtNaturalidade.Clear();
                    //    return;
                    //}
                    funcionario.Naturalidade = txtNaturalidade.Text;

                    #endregion

                    #region VALIDA - ESTADO CIVIL

                    //if (String.IsNullOrEmpty(cmbEstadoCivil.Text))
                    //{
                    //    errorProviderTela.SetError(cmbEstadoCivil, "Informe o estado civil");
                    //    return;
                    //}
                    funcionario.EstadoCivil = cmbEstadoCivil.Text;

                    #endregion

                    #region VALIDA - ENDEREÇO

                    //if (String.IsNullOrEmpty(txtLogradouro.Text))
                    //{
                    //    errorProviderTela.SetError(txtLogradouro, "Informe o endereço");
                    //    txtLogradouro.Clear();
                    //    return;
                    //}
                    funcionario.Logradouro = txtLogradouro.Text;

                    #endregion

                    #region VALIDA - COMPLEMENTO

                    //if (String.IsNullOrEmpty(txtComplemento.Text))
                    //{
                    //    errorProviderTela.SetError(txtComplemento, "Informe o complemento");
                    //    txtComplemento.Clear();
                    //    return;
                    //}
                    funcionario.ComplementoEndereco = txtComplemento.Text;

                    #endregion

                    #region VALIDA - NOME EDIFÍCIL

                    //if (String.IsNullOrEmpty(txtNomeEdificil.Text))
                    //{
                    //    errorProviderTela.SetError(txtNomeEdificil, "Informe o nome edifícil");
                    //    txtNomeEdificil.Clear();
                    //    return;
                    //}
                    funcionario.Edificio = txtNomeEdificil.Text;

                    #endregion

                    #region VALIDA - BAIRRO

                    //if (String.IsNullOrEmpty(txtBairro.Text))
                    //{
                    //    errorProviderTela.SetError(txtBairro, "Informe o bairro");
                    //    txtBairro.Clear();
                    //    return;
                    //}
                    funcionario.Bairro = txtBairro.Text;

                    #endregion

                    #region VALIDA - CEP

                    //if (mskCep.MaskCompleted == false)
                    //{
                    //    errorProviderTela.SetError(mskCep, "Informe o cep");
                    //    mskCep.Clear();
                    //    return;
                    //}
                    funcionario.Cep = mskCep.Text;

                    #endregion

                    #region VALIDA - UF

                    //if (String.IsNullOrEmpty(cmbUf.Text))
                    //{
                    //    errorProviderTela.SetError(cmbUf, "Informe o uf");
                    //    return;
                    //}
                    funcionario.Uf = cmbUf.Text;

                    #endregion

                    #region VALIDA - CIDADE

                    //if (String.IsNullOrEmpty(txtCidade.Text))
                    //{
                    //    errorProviderTela.SetError(txtCidade, "Informe a cidade");
                    //    txtCidade.Clear();
                    //    return;
                    //}
                    funcionario.Cidade = txtCidade.Text;

                    #endregion

                    #region VALIDA - FONE

                    //if (mskFoneResidencia.MaskCompleted == false)
                    //{
                    //    errorProviderTela.SetError(mskFoneResidencia, "Informe o fone da residência");
                    //    mskFoneResidencia.Clear();
                    //    return;
                    //}
                    funcionario.FoneEmergencia = mskFoneResidencia.Text;

                    #endregion

                    #region VALIDA - FONE OPCIONAL

                    //if (mskFoneOpcional.MaskCompleted == false)
                    //{
                    //    errorProviderTela.SetError(mskFoneOpcional, "Informe um fone opcional");
                    //    mskFoneOpcional.Clear();
                    //    return;
                    //}
                    funcionario.FoneOpcional = mskFoneOpcional.Text;

                    #endregion

                    #region VALIDA - FILIAÇÃO PAI

                    //if (String.IsNullOrEmpty(txtFiliacaoPai.Text))
                    //{
                    //    errorProviderTela.SetError(txtFiliacaoPai, "Informe o nome do pai");
                    //    txtFiliacaoPai.Clear();
                    //    return;
                    //}
                    funcionario.FiliacaoPai = txtFiliacaoPai.Text;

                    #endregion

                    #region VALIDA - FILIAÇÃO MÃE

                    //if (String.IsNullOrEmpty(txtFiliacaoMae.Text))
                    //{
                    //    errorProviderTela.SetError(txtFiliacaoMae, "Informe o nome da mãe");
                    //    txtFiliacaoMae.Clear();
                    //    return;
                    //}
                    funcionario.FiliacaoMae = txtFiliacaoMae.Text;

                    #endregion

                    funcionario.PerfilID = 1;
                    funcionario.Status = (int)Status.Ativo;


                    Memoria memoria = Memoria.Instance;
                    if (memoria.Funcionario == null)
                    {                                
                        funcionarioControlador.Alterar(funcionario);
                        MessageBox.Show(FuncionarioConstantes.FUNCIONARIO_ALTERADO, "Colégio Conhecer");
                        ucMenuImagemFunc1.carregaFuncionario(funcionario);
                    }
                }

                #endregion

           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Habilitar o User Control lateral
            ucMenuLateralFunc1.Enabled = true;

            //Habilitar o Button Imprimir
            btnImprimir.Enabled = false;

            //Desabilitar todos os campos da tela
            Enabled_False();

            //Zerar o verificador de botao "Alterar" e "Cadastrar"
            verificaButton = 0;

        }
        #endregion

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


        #region LOAD
        private void ucMenuLateralFunc1_Load(object sender, EventArgs e)
        {
            ucMenuLateralFunc1.verificaTela(teladfunc);
        }
        #endregion


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
            //funcionario.PerfilID = 1;
            //funcionario = funcionarioControlador.Consultar(funcionario, Negocios.ModuloBasico.Enums.TipoPesquisa.E)[0];
            //carregarFuncionario();
            //ucMenuImagemFunc1.carregaFuncionario(funcionario);
            //Program.funcionarioAux = funcionario;
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

        #region LIMPAR FUNCIONARIO
        public void limparFuncionario()
        {
            txtBairro.Clear();
            txtCidade.Clear();
            txtComplemento.Clear();
            txtFiliacaoMae.Clear();
            txtFiliacaoPai.Clear();
            txtLogradouro.Clear();
            txtNome.Clear();
            txtNomeEdificil.Clear();
            txtRg.Clear();
            mskCep.Clear();
            mskCpf.Clear();
            mskFoneResidencia.Clear();
            dtpNascimento.Value = DateTime.Today;
            cmbEstadoCivil.Select();
            cmbNacionalidade.Select();
            cmbUf.Select();
            rdbMasc.Checked = false;
            rdbFem.Checked = false;
        }
        #endregion

        #region CARREGAR FUNCIONARIO
        public void carregarFuncionario()
        {
            txtBairro.Text = funcionario.Bairro;
            txtCidade.Text = funcionario.Cidade;
            txtComplemento.Text = funcionario.ComplementoEndereco;
            txtFiliacaoMae.Text = funcionario.FiliacaoMae;
            txtFiliacaoPai.Text = funcionario.FiliacaoPai;
            txtLogradouro.Text = funcionario.Logradouro;
            txtNaturalidade.Text = funcionario.Naturalidade;
            txtNome.Text = funcionario.Nome;
            txtNomeEdificil.Text = funcionario.Edificio;
            txtRg.Text = funcionario.Rg;
            mskCep.Text = funcionario.Cep;
            mskCpf.Text = funcionario.Cpf;
            mskFoneResidencia.Text = funcionario.FoneEmergencia;
            mskFoneOpcional.Text = funcionario.FoneOpcional;
            cmbEstadoCivil.Text = funcionario.EstadoCivil;
            cmbNacionalidade.Text = funcionario.Nacionalidade;
            cmbUf.Text = funcionario.Uf;
            //dtpNascimento.Value = funcionario.Nascimento.Value;
            if (funcionario.Sexo == 0)
            {
                rdbFem.Select();
            }
            else
            {
                rdbMasc.Select();
            }
        }
        #endregion

        #region BUTTON DESCONECTAR
        private void ucDesconectarLogin1_EventoDesconectar()
        {
            Program.ultimaTela = 9;
            this.Close();
            telaLogin telalogin = telaLogin.getInstancia();
            telalogin.Show();
        }
        #endregion

        #region ACTIVATED

        private void telaFuncionario_Activated_1(object sender, EventArgs e)
        {
           // ucMenuImagemFunc1.
            Memoria memoria = Memoria.Instance;

            cmbUf.DataSource = estados;
            ucMenuImagemFunc1.ocultarBotaoAdicionarImagem();

            if (memoria.Status == StatusBanco.Inativo)
            {
                ucMenuInferior1.apagarBotaoAlterar();
                ucMenuInferior1.apagarBotaoDeletar();
                ucMenuInferior1.apagarBotaoIncluir();

                memoria.Status = StatusBanco.Inclusao;

                if (memoria.Funcionario != null)
                {
                    funcionario = memoria.Funcionario;
                    ucMenuImagemFunc1.carregaFuncionario(funcionario);
                    carregarFuncionario();

                }
                else
                {
                    limparFuncionario();
                }
                Enabled_True();
                txtNome.Focus();

                //VALIDA EXIBICAO DOS BOTAO DO MENU_INFERIOR
                if (Program.ultimaTelaCadastrar == 2)
                {
                    Enabled_False();
                    ucMenuInferior1.exibirBotaoAlterar();
                }

                if (Program.ultimaTelaCadastrar == 3)
                {
                    Enabled_False();
                    ucMenuInferior1.exibirBotaoAlterar();
                }
                Program.ultimaTelaCadastrar = 0;
            }
        }


        #endregion

        #region METODOS ENABLED

        /// <summary>
        ///  Método para Ativar a Alteração
        ///  de todos os campos de Funcionario
        /// </summary>
        private void Enabled_True()
        {
            txtNome.Enabled = true;
            txtRg.Enabled = true;
            mskCpf.Enabled = true;
            rdbFem.Enabled = true;
            rdbMasc.Enabled = true;
            dtpNascimento.Enabled = true;
            cmbNacionalidade.Enabled = true;
            txtNaturalidade.Enabled = true;
            txtLogradouro.Enabled = true;
            txtComplemento.Enabled = true;
            txtNomeEdificil.Enabled = true;
            txtBairro.Enabled = true;
            mskCep.Enabled = true;
            cmbUf.Enabled = true;
            mskFoneResidencia.Enabled = true;
            mskFoneOpcional.Enabled = true;
            txtCidade.Enabled = true;
            cmbEstadoCivil.Enabled = true;
            txtFiliacaoMae.Enabled = true;
            txtFiliacaoPai.Enabled = true;
        }

        /// <summary>
        ///  Método para Desativar a Alteração
        ///  de todos os campos de Funcionario
        /// </summary>
        private void Enabled_False()
        {
            txtNome.Enabled = false;
            txtRg.Enabled = false;
            mskCpf.Enabled = false;
            rdbFem.Enabled = false;
            rdbMasc.Enabled = false;
            dtpNascimento.Enabled = false;
            cmbNacionalidade.Enabled = false;
            txtNaturalidade.Enabled = false;
            txtLogradouro.Enabled = false;
            txtComplemento.Enabled = false;
            txtNomeEdificil.Enabled = false;
            txtBairro.Enabled = false;
            mskCep.Enabled = false;
            cmbUf.Enabled = false;
            mskFoneResidencia.Enabled = false;
            mskFoneOpcional.Enabled = false;
            txtCidade.Enabled = false;
            cmbEstadoCivil.Enabled = false;
            txtFiliacaoMae.Enabled = false;
            txtFiliacaoPai.Enabled = false;
        }

        #endregion

        #region SELECIONA CIDADE
        private void cmbUf_SelectedIndexChanged(object sender, EventArgs e)
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

        #region METODO VERIFICA_SE_JA_CADASTRADO
        public Boolean verificaSeJaCadastrado(Funcionario funcionarioAux)
        {
            bool testa = false;

            List<Funcionario> listaFuncionario = new List<Funcionario>();
            
            listaFuncionario = funcionarioControlador.Consultar();

            foreach (Funcionario f in listaFuncionario)
            {

                if ((f.Nome == funcionarioAux.Nome) && (f.Nascimento == funcionarioAux.Nascimento)) 
                {
                    testa = true;
                }

            }
            return testa;
        }
        #endregion


    }
}