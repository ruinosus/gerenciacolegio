using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.ModuloFuncionario.Processos;

namespace GuiWindowsForms
{
    public partial class telaFuncionarioDadosProfissionais : Form
    {
        Funcionario funcionario = new Funcionario();
        IFuncionarioProcesso funcionarioControlador = FuncionarioProcesso.Instance;

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

        #region EVENTO VOLTAR
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

        #region EVENTO CADASTRAR
        private void ucMenuInferior1_EventoCadastrar()
        {

            try
            {

                #region VALIDA - CBO

                if (String.IsNullOrEmpty(txtCBO.Text))
                {
                    errorProviderTela.SetError(txtCBO, "Informe o C.B.O");
                    txtCBO.Clear();
                    return;
                }
                funcionario.Cbo = txtCBO.Text;

                #endregion

                #region VALIDA - TITULO ELEITOR

                if (String.IsNullOrEmpty(txtTituloEleitor.Text))
                {
                    errorProviderTela.SetError(txtTituloEleitor, "Informe o titulo eleitor");
                    txtTituloEleitor.Clear();
                    return;
                }
                funcionario.TituloEleitor = txtTituloEleitor.Text;

                #endregion

                #region VALIDA - ZONA

                if (String.IsNullOrEmpty(txtZona.Text))
                {
                    errorProviderTela.SetError(txtZona, "Informe a zona");
                    txtZona.Clear();
                    return;
                }
                funcionario.Zona = txtZona.Text;

                #endregion

                #region VALIDA - PIS

                if (String.IsNullOrEmpty(txtPis.Text))
                {
                    errorProviderTela.SetError(txtPis, "Informe o PIS");
                    txtPis.Clear();
                    return;
                }
                funcionario.Pis = txtPis.Text;

                #endregion

                #region VALIDA - CTPS

                if (String.IsNullOrEmpty(txtCtps.Text))
                {
                    errorProviderTela.SetError(txtCtps, "Informe o Ctps");
                    txtCtps.Clear();
                    return;
                }
                funcionario.Ctps = txtCtps.Text;

                #endregion

                #region VALIDA - SERIE

                if (String.IsNullOrEmpty(txtSerie.Text))
                {
                    errorProviderTela.SetError(txtSerie, "Informe a série");
                    txtSerie.Clear();
                    return;
                }
                funcionario.Serie = txtSerie.Text;

                #endregion

                #region VALIDA - GRAU DE INSTRUÇÃO

                if (String.IsNullOrEmpty(cmbGrau.Text))
                {
                    errorProviderTela.SetError(cmbGrau, "Informe a nacionalidade");
                    return;
                }
                funcionario.GrauInstrucao = cmbGrau.Text;

                #endregion

                #region VALIDA - COR

                if (String.IsNullOrEmpty(cmbCor.Text))
                {
                    errorProviderTela.SetError(cmbCor, "Informe a cor");
                    return;
                }
                funcionario.Cor = cmbCor.Text;

                #endregion

                #region VALIDA - PRIMEIRO EMPREGO

                if (rdbSim.Checked == false && rdbNao.Checked == false)
                {
                    errorProviderTela.SetError(rdbNao, "Informe o primeiro emprego");
                    return;
                }
                if (rdbSim.Checked == true)
                {
                    funcionario.PrimeiroEmprego = 0;
                }
                else
                {
                    funcionario.PrimeiroEmprego = 1;
                }

                #endregion

                #region VALIDA - CURSO

                if (String.IsNullOrEmpty(txtCurso.Text))
                {
                    errorProviderTela.SetError(txtSerie, "Informe o curso");
                    txtCurso.Clear();
                    return;
                }
                funcionario.Curso = txtCurso.Text;

                #endregion

                #region VALIDA - INSTITUIÇÃO

                if (String.IsNullOrEmpty(txtInstituicao.Text))
                {
                    errorProviderTela.SetError(txtInstituicao, "Informe a instituição");
                    txtInstituicao.Clear();
                    return;
                }
                funcionario.Instituicao = txtInstituicao.Text;

                #endregion

                #region VALIDA - FUNÇÃO

                if (String.IsNullOrEmpty(cmbFuncao.Text))
                {
                    errorProviderTela.SetError(cmbFuncao, "Informe a função");
                    return;
                }
                funcionario.Cargo = cmbFuncao.Text;

                #endregion

                funcionario.DataEfetivacao = dtpDataAdmissao.Value;
                funcionario.DataFormacao = dtpDataFormacao.Value;

                funcionarioControlador.Alterar(funcionario);
                funcionarioControlador.Confirmar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region EVENTO ALTERAR
        private void ucMenuInferior1_EventoAlterar()
        {

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

        private void ucMenuLateralFunc1_Load(object sender, EventArgs e)
        {
            ucMenuLateralFunc1.verificaTela(teladfuncProfissional);
        }
        #endregion

        #region LOAD
        private void telaFuncionarioDadosProfissionais_Load(object sender, EventArgs e)
        {
            funcionario = Program.funcionarioAux;
            if(funcionario!=null)
            ucMenuImagemFunc1.carregaFuncionario(funcionario);
            carregarCampos();
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

        #region LIMPAR CAMPOS
        public void limparCamposTela()
        {
            txtCBO.Clear();
            txtCtps.Clear();
            txtCurso.Clear();
            txtInstituicao.Clear();
            txtPis.Clear();
            txtSerie.Clear();
            txtTituloEleitor.Clear();
            txtZona.Clear();
            cmbCor.Select();
            cmbFuncao.Select();
            cmbGrau.Select();
            dtpDataAdmissao.Value = DateTime.Today;
            dtpDataFormacao.Value = DateTime.Today;
            rdbNao.Checked = false;
            rdbSim.Checked = false;
        }
        #endregion

        #region CARREGAR CAMPOS
        public void carregarCampos()
        {
            txtCBO.Text = funcionario.Cbo;
            txtCtps.Text = funcionario.Ctps;
            txtCurso.Text = funcionario.Curso;
            txtInstituicao.Text = funcionario.Instituicao;
            txtPis.Text = funcionario.Pis;
            txtSerie.Text = funcionario.Serie;
            txtTituloEleitor.Text = funcionario.TituloEleitor;
            txtZona.Text = funcionario.Zona;
            cmbCor.Text = funcionario.Cor;
            cmbFuncao.Text = funcionario.Cargo;
            cmbGrau.Text = funcionario.GrauInstrucao;
            if (funcionario.PrimeiroEmprego == 0)
            {
                rdbSim.Select();
            }
            else
            {
                rdbNao.Select();
            }
        }
        #endregion

        #region DESCONECTAR
        private void ucDesconectarLogin1_EventoDesconectar()
        {
            Program.ultimaTela = 9;
            this.Close();
            telaLogin telalogin = telaLogin.getInstancia();
            telalogin.Show();
        }
        #endregion

        #region ACTIVATED
        private void telaFuncionarioDadosProfissionais_Activated(object sender, EventArgs e)
        {

        }
        #endregion

        #region METODOS ENABLED

        /// <summary>
        ///  Método para Ativar a Alteração
        ///  de todos os campos de Funcionario
        /// </summary>
        private void Enabled_True()
        {
            txtCBO.Enabled = true;
            txtTituloEleitor.Enabled = true;
            txtZona.Enabled = true;
            txtPis.Enabled = true;
            txtCtps.Enabled = true;
            txtSerie.Enabled = true;
            cmbGrau.Enabled = true;
            cmbCor.Enabled = true;
            rdbSim.Enabled = true;
            rdbNao.Enabled = true;
            txtCurso.Enabled = true;
            dtpDataAdmissao.Enabled = true;
            dtpDataFormacao.Enabled = true;
            txtInstituicao.Enabled = true;
            cmbFuncao.Enabled = true;
        }

        /// <summary>
        ///  Método para Desativar a Alteração
        ///  de todos os campos de Funcionario
        /// </summary>
        private void Enabled_False()
        {
            txtCBO.Enabled = false;
            txtTituloEleitor.Enabled = false;
            txtZona.Enabled = false;
            txtPis.Enabled = false;
            txtCtps.Enabled = false;
            txtSerie.Enabled = false;
            cmbGrau.Enabled = false;
            cmbCor.Enabled = false;
            rdbSim.Enabled = false;
            rdbNao.Enabled = false;
            txtCurso.Enabled = false;
            dtpDataAdmissao.Enabled = false;
            dtpDataFormacao.Enabled = false;
            txtInstituicao.Enabled = false;
            cmbFuncao.Enabled = false;
        }

        #endregion

        #region CARREGAR FUNCIONARIO
        public void carregarFuncionario()
        {
            txtCBO.Text = funcionario.Cbo;
            txtTituloEleitor.Text = funcionario.TituloEleitor;
            txtZona.Text = funcionario.Zona;
            txtPis.Text = funcionario.Pis;
            txtCtps.Text = funcionario.Serie;
            txtSerie.Text = funcionario.Serie;
            cmbGrau.Text = funcionario.GrauInstrucao;
            cmbCor.Text = funcionario.Cor;
            txtCurso.Text = funcionario.Curso;
            dtpDataAdmissao.Value = funcionario.DataEfetivacao.Value;
            dtpDataFormacao.Value = funcionario.DataFormacao.Value;
            txtInstituicao.Text = funcionario.Instituicao;
            cmbFuncao.Text = funcionario.Cargo;

            if (funcionario.PrimeiroEmprego == 0)
            {
                rdbSim.Select();
            }
            else
            {
                rdbNao.Select();
            }
        }
        #endregion

    }
}
