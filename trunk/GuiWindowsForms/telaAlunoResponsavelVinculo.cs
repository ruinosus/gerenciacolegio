using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.ModuloResponsavelAluno.Processos;
using Negocios.ModuloBasico.VOs;
using Negocios.ModuloResponsavel.Processos;
using Negocios.ModuloBasico.Enums;

namespace GuiWindowsForms
{
    public partial class telaAlunoResponsavelVinculo : Form
    {
        #region SINGLETON
        /*
        * Atributo para o Singleton da tela
        * Atributo para controle de exibição da tela
        * */
        private static telaAlunoResponsavelVinculo telaalunoresponsavelbusca;
        private static bool IsShown = false;
        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. 
        /// Evita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>
        public static telaAlunoResponsavelVinculo getInstancia()
        {
            if (telaalunoresponsavelbusca == null)
            {
                telaalunoresponsavelbusca = new telaAlunoResponsavelVinculo();
            }
            return telaalunoresponsavelbusca;
        }
        #endregion

        #region CONSTRUTOR
        /// <summary>
        /// Construtor da tela
        /// </summary>
        private telaAlunoResponsavelVinculo()
        {
            InitializeComponent();

        }
        #endregion

        #region VERIFICA TELA
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

        }
        #endregion

        #region ESCONDE A TELA
        /// <summary>
        /// Evento para o fechamento da tela, não fecha de verdade, 
        /// só a esconde, garantindo a usabilidade da tela
        /// pelo singleton
        /// </summary>
        /// <param name="sender">Tela</param>
        /// <param name="e">Cancela seu fechamento, permite só que seja ocultada</param>
        private void telaAlunoResponsavelBusca_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IsShown = false;
            this.Hide();

            if (Program.ultimaTela != 1)
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

        #region USER CONTROLS - Menu Inferior

        #region EVENTO CADASTRAR
        private void ucMenuInferior1_EventoCadastrar()
        {
            try
            {


                if (Memoria.Instance.Aluno != null)
                {


                    #region VALIDA - RESPONSAVEL

                    if (Memoria.Instance.Responsavel == null || Memoria.Instance.Responsavel.ID <= 0)
                    {
                        errorProviderTela.SetError(btnPesquisar, "Informe o responsável");
                        return;
                    }
                    #endregion

                    #region VALIDA - GRAU PARENTESCO

                    if (string.IsNullOrEmpty(cmbGrauParentesco.Text) || cmbGrauParentesco.Text.ToLower().Equals("selecione"))
                    {
                        errorProviderTela.SetError(cmbGrauParentesco, "Informe o Grau de Parentesco");
                        return;
                    }

                    #endregion


                    IResponsavelAlunoProcesso processo = ResponsavelAlunoProcesso.Instance;
                    ResponsavelAluno responsavelAluno = new ResponsavelAluno();
                    responsavelAluno.Status = (int)Status.Ativo;
                    responsavelAluno.AlunoID = Memoria.Instance.Aluno.ID;
                    responsavelAluno.ResponsavelID = Memoria.Instance.Responsavel.ID;

                    responsavelAluno.GrauParentesco = cmbGrauParentesco.Text;
                    if (!ckbResideCom.Checked)
                        responsavelAluno.ResideCom = 0;
                    else
                        responsavelAluno.ResideCom = 1;
                    responsavelAluno.Restricoes = txtRestricoes.Text;

                    switch (Memoria.Instance.StatusTelaAlunoResponsavelBusca)
                    {
                        case OperacoesDaTela.Incluir:
                            {
                                if (processo.Consultar(responsavelAluno, Negocios.ModuloBasico.Enums.TipoPesquisa.E).Count > 0)
                                {
                                    throw new Exception("Responsável já vinculado ao Aluno.");
                                }
                                processo.Incluir(responsavelAluno);
                                processo.Confirmar();
                                break;
                            }
                        case OperacoesDaTela.Alterar:
                            {
                                responsavelAluno.ID = ((List<ResponsavelAluno>)dgvResponsavelAluno.DataSource)[dgvResponsavelAluno.CurrentRow.Index].ID;
                                processo.Alterar(responsavelAluno);
                                processo.Confirmar();
                                break;
                            }
                    }
                    Atualizar();

                }
                Memoria.Instance.StatusTelaAlunoResponsavelBusca = OperacoesDaTela.Navegar;
                AjustarBotoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        #endregion

        #region EVENTO VOLTAR
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

        #region EVENTO INCLUIR
        private void ucMenuInferior1_EventoIncluir()
        {
            Memoria.Instance.StatusTelaAlunoResponsavelBusca = OperacoesDaTela.Incluir;
            AjustarBotoes();
        }
        #endregion

        #region EVENTO ALTERAR
        private void ucMenuInferior1_EventoAlterar()
        {
            Memoria.Instance.StatusTelaAlunoResponsavelBusca = OperacoesDaTela.Alterar;
            AjustarBotoes();

        }
        #endregion

        #region EVENTO DELETAR
        private void ucMenuInferior1_EventoDeletar()
        {
            try
            {
                Memoria.Instance.StatusTelaAlunoResponsavelBusca = OperacoesDaTela.Excluir;
                if (MessageBox.Show("Tem certeza que deseja excluir o responsável ?", "Colégio Conhecer", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    IResponsavelAlunoProcesso processo = ResponsavelAlunoProcesso.Instance;
                    processo.Excluir(((List<ResponsavelAluno>)dgvResponsavelAluno.DataSource)[dgvResponsavelAluno.CurrentRow.Index]);
                    processo.Confirmar();
                    Memoria.Instance.StatusTelaAlunoResponsavelBusca = OperacoesDaTela.Navegar;
                    Atualizar();
                    AjustarBotoes();
                }
                else
                {
                    MessageBox.Show("Selecione uma opção na tabela abaixo para exclusão, então pressione excluir.", "Colégio Conhecer");
                }

            }
            catch (Exception)
            {


            }

        }
        #endregion

        #endregion

        #region EVENTOS GRID

        private void dgvResponsavelAluno_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            AjustarBotoes();

        }

        private void dgvResponsavelAluno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Memoria.Instance.Responsavel = ((List<ResponsavelAluno>)dgvResponsavelAluno.DataSource)[dgvResponsavelAluno.CurrentRow.Index].Responsavel;
            Memoria.Instance.Responsavel.ID = ((List<ResponsavelAluno>)dgvResponsavelAluno.DataSource)[dgvResponsavelAluno.CurrentRow.Index].ResponsavelID;
            Memoria.Instance.StatusTelaAlunoResponsavel = OperacoesDaTela.Alterar;
            Program.ultimaTela = 8;
            this.Hide();
            telaAlunoResponsavel telaRespAux = telaAlunoResponsavel.getInstancia();
            telaRespAux.Show();
        }

        #endregion

        #region CARREGAR GRID
        private void CarregarGrid()
        {
            IResponsavelAlunoProcesso processo = ResponsavelAlunoProcesso.Instance;
            dgvResponsavelAluno.AutoGenerateColumns = false;
            ResponsavelAluno responsavelAluno = new ResponsavelAluno();
            responsavelAluno.AlunoID = Memoria.Instance.Aluno.ID;
            responsavelAluno.Status = (int)Status.Ativo;
            dgvResponsavelAluno.AutoGenerateColumns = false;
            dgvResponsavelAluno.DataSource = processo.Consultar(responsavelAluno, Negocios.ModuloBasico.Enums.TipoPesquisa.E); ;
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

        #region EVENTOS DOS CAMPOS
        private void mskCpf_Leave(object sender, EventArgs e)
        {
            mskCpf.BackColor = System.Drawing.Color.White;
        }

        private void mskCpf_Enter(object sender, EventArgs e)
        {
            mskCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            txtNome.BackColor = System.Drawing.Color.White;
        }

        private void txtRestricoes_Leave(object sender, EventArgs e)
        {
            txtRestricoes.BackColor = System.Drawing.Color.White;
        }

        private void txtRestricoes_Enter(object sender, EventArgs e)
        {
            txtRestricoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        #endregion

        #region ACTIVATED
        private void telaAlunoResponsavelBusca_Activated(object sender, EventArgs e)
        {
            switch (Memoria.Instance.StatusTelaAlunoResponsavelBusca)
            {
                case OperacoesDaTela.Navegar:
                    {
                        CarregarGrid();
                        uMenuImagem1.carregaAluno(Memoria.Instance.Aluno);
                        AjustarBotoes();
                        btnCadastrarResponsavel.Enabled = false;
                        break;
                    }
                case OperacoesDaTela.AbrirTela:
                    {
                        if (Memoria.Instance.Aluno != null)
                        {
                            LimparTela();
                            Memoria.Instance.StatusTelaAlunoResponsavelBusca = OperacoesDaTela.Navegar;
                            CarregarGrid();
                            uMenuImagem1.carregaAluno(Memoria.Instance.Aluno);
                            AjustarBotoes();
                            btnCadastrarResponsavel.Enabled = false;
                        }
                        break;
                    }
                case OperacoesDaTela.Incluir: 
                case OperacoesDaTela.Alterar:
                    {
                        CarregarResponsavel();
                        break;
                    }
            }

        }

        
        #endregion

        #region MÉTODOS DE MANIPULAÇÃO DA INFORMAÇÃO
        private void CarregarResponsavel()
        {
            if (Memoria.Instance.Responsavel != null)
            {
                txtNome.Text = Memoria.Instance.Responsavel.Nome;
                mskCpf.Text = Memoria.Instance.Responsavel.Cpf;
            }
        }
        private void AjustarBotoes()
        {
            switch (Memoria.Instance.StatusTelaAlunoResponsavelBusca)
            {
                case OperacoesDaTela.Incluir:
                    {
                        ApagarBotoes();
                        btnPesquisar.Enabled = true;
                        btnCadastrarResponsavel.Enabled = true;
                        break;
                    }
                case OperacoesDaTela.Alterar:
                    {
                        ApagarBotoes();
                        btnPesquisar.Enabled = true;
                        break;
                    }
                case OperacoesDaTela.Navegar:
                    {
                        btnPesquisar.Enabled = false;
                        ApagarBotoes();
                        if (((List<ResponsavelAluno>)dgvResponsavelAluno.DataSource).Count > 0)
                        {
                            ucMenuInferior1.exibirBotaoAlterar();
                            ucMenuInferior1.exibirBotaoDeletar();
                        }
                        ucMenuInferior1.exibirBotaoIncluir();
                        break;
                    }
                default:
                    break;
            }
            AjustarEdits();
        }

        private void ApagarBotoes()
        {
            uMenuImagem1.ocultarBotaoAdicionarImagem();
            ucMenuInferior1.apagarBotaoAlterar();
            ucMenuInferior1.apagarBotaoDeletar();
            ucMenuInferior1.apagarBotaoIncluir();
        }

        private void AjustarEdits()
        {
            switch (Memoria.Instance.StatusTelaAlunoResponsavelBusca)
            {
                case OperacoesDaTela.Incluir:
                    {
                        ckbResideCom.Enabled = true;
                        mskCpf.ReadOnly = true;
                        txtNome.ReadOnly = true;
                        cmbGrauParentesco.Enabled = true;
                        txtRestricoes.ReadOnly = false;
                        dgvResponsavelAluno.Enabled = false;
                        LimparTela();
                        break;
                    }
                case OperacoesDaTela.Alterar:
                    {
                        ckbResideCom.Enabled = true;
                        mskCpf.ReadOnly = true;
                        txtNome.ReadOnly = true;
                        txtRestricoes.ReadOnly = false;
                        cmbGrauParentesco.Enabled = true;
                        dgvResponsavelAluno.Enabled = false;
                        break;
                    }
                case OperacoesDaTela.Navegar:
                    {
                        LimparTela();
                        if (dgvResponsavelAluno.CurrentRow != null)
                        {
                            cmbGrauParentesco.Text = ((List<ResponsavelAluno>)dgvResponsavelAluno.DataSource)[dgvResponsavelAluno.CurrentRow.Index].GrauParentesco;
                            txtNome.Text = ((List<ResponsavelAluno>)dgvResponsavelAluno.DataSource)[dgvResponsavelAluno.CurrentRow.Index].Responsavel.Nome;
                            mskCpf.Text = ((List<ResponsavelAluno>)dgvResponsavelAluno.DataSource)[dgvResponsavelAluno.CurrentRow.Index].Responsavel.Cpf;
                            if (((List<ResponsavelAluno>)dgvResponsavelAluno.DataSource)[dgvResponsavelAluno.CurrentRow.Index].ResideCom.HasValue)
                                ckbResideCom.Checked = Convert.ToBoolean(((List<ResponsavelAluno>)dgvResponsavelAluno.DataSource)[dgvResponsavelAluno.CurrentRow.Index].ResideCom.Value);
                            txtRestricoes.Text = ((List<ResponsavelAluno>)dgvResponsavelAluno.DataSource)[dgvResponsavelAluno.CurrentRow.Index].Restricoes;
                            Memoria.Instance.Responsavel = ((List<ResponsavelAluno>)dgvResponsavelAluno.DataSource)[dgvResponsavelAluno.CurrentRow.Index].Responsavel;
                        }
                        ckbResideCom.Enabled = false;
                        mskCpf.ReadOnly = true;
                        txtNome.ReadOnly = true;
                        cmbGrauParentesco.Enabled = false;
                        txtRestricoes.ReadOnly = true;
                        dgvResponsavelAluno.Enabled = true;
                        LimparErro();
                        break;
                    }
                default:
                    break;
            }

        }

        private void LimparTela()
        {

            txtNome.Text = string.Empty;
            mskCpf.Text = string.Empty;
            txtRestricoes.Text = string.Empty;
            cmbGrauParentesco.SelectedIndex = 0;
            ckbResideCom.Checked = false;
            LimparErro();
        }

        private void Atualizar()
        {
            CarregarGrid();
        }
        #endregion

        #region LIMPAR ERROPROVIDER
        private void LimparErro()
        {
            errorProviderTela.Clear();
        }
        #endregion

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            telaAlunoResponsavelBusca tela = new telaAlunoResponsavelBusca();
            tela.ShowDialog();
        }

        private void btnCadastrarResponsavel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 8;

            Memoria.Instance.Responsavel = null;;
            Memoria.Instance.Status = Negocios.ModuloBasico.Enums.StatusBanco.Inativo;
            Memoria.Instance.StatusTelaAlunoResponsavelBusca = OperacoesDaTela.Navegar;
            telaAlunoResponsavel telaAlunoRespon = telaAlunoResponsavel.getInstancia();
            telaAlunoRespon.limparTela();
            telaAlunoRespon.Show();
        }

    }
}
