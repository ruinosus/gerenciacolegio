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
    public partial class telaAlunoResponsavelBusca : Form
    {

        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */
        List<ResponsavelAluno> responsavelAlunoLista;
        int linhaSelecionadaGrid = -1;
        private static telaAlunoResponsavelBusca telaalunoresponsavelbusca;
        Memoria memoria = Memoria.Instance;
        bool bloquearCampos = false;
        Responsavel responsavel;
        StatusBanco statusBanco;

        private static bool IsShown = false;

        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. Evita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>
        public static telaAlunoResponsavelBusca getInstancia()
        {
            if (telaalunoresponsavelbusca == null)
            {
                telaalunoresponsavelbusca = new telaAlunoResponsavelBusca();
            }
            return telaalunoresponsavelbusca;
        }

        /// <summary>
        /// Construtor da tela
        /// </summary>
        public telaAlunoResponsavelBusca()
        {
            InitializeComponent();

        }

        private void CarregarGrid()
        {
            IResponsavelAlunoProcesso processo = ResponsavelAlunoProcesso.Instance;
            dgvResponsavelAluno.AutoGenerateColumns = false;
            ResponsavelAluno responsavelAluno = new ResponsavelAluno();
            responsavelAluno.AlunoID = memoria.Aluno.ID;
            responsavelAluno.Status = (int)Status.Ativo;
            responsavelAlunoLista = processo.Consultar(responsavelAluno, Negocios.ModuloBasico.Enums.TipoPesquisa.E);
            dgvResponsavelAluno.DataSource = responsavelAlunoLista;
        }

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

        /// <summary>
        /// Evento para o fechamento da tela, não fecha de verdade, só a esconde, garantindo a usabilidade da tela
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

        private void telaAlunoResponsavelBusca_Load(object sender, EventArgs e)
        {
            uMenuImagem1.ocultarBotaoAdicionarImagem();
        }

        private void dgvResponsavelAluno_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());

            if (linhaSelecionadaGrid != -1)
            {
                dgvResponsavelAluno.Rows[linhaSelecionadaGrid].Selected = true;


                cmbGrauParentesco.Text = responsavelAlunoLista[linhaSelecionadaGrid].GrauParentesco;
                txtNome.Text = responsavelAlunoLista[linhaSelecionadaGrid].Responsavel.Nome;
                mskCpf.Text = responsavelAlunoLista[linhaSelecionadaGrid].Responsavel.Cpf;
                ckbResideCom.Checked = Convert.ToBoolean(responsavelAlunoLista[linhaSelecionadaGrid].ResideCom.Value);
                txtRestricoes.Text = responsavelAlunoLista[linhaSelecionadaGrid].Restricoes;
                responsavel = responsavelAlunoLista[linhaSelecionadaGrid].Responsavel;
                ManipularCampos(true);
            }

        }

        private void dgvResponsavelAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());

            if (linhaSelecionadaGrid != -1)
            {
                dgvResponsavelAluno.Rows[linhaSelecionadaGrid].Selected = true;


                cmbGrauParentesco.Text = responsavelAlunoLista[linhaSelecionadaGrid].GrauParentesco;
                txtNome.Text = responsavelAlunoLista[linhaSelecionadaGrid].Responsavel.Nome;
                mskCpf.Text = responsavelAlunoLista[linhaSelecionadaGrid].Responsavel.Cpf;
                ckbResideCom.Checked = Convert.ToBoolean(responsavelAlunoLista[linhaSelecionadaGrid].ResideCom.Value);
                txtRestricoes.Text = responsavelAlunoLista[linhaSelecionadaGrid].Restricoes;
                responsavel = responsavelAlunoLista[linhaSelecionadaGrid].Responsavel;
                ManipularCampos(true);
            }
        }

        private void ucMenuInferior1_EventoCadastrar()
        {
            try
            {
                if (memoria.Aluno != null)
                {


                    #region VALIDA - NOME

                    if (string.IsNullOrEmpty(txtNome.Text))
                    {
                        errorProviderTela.SetError(txtNome, "Informe o nome");
                        return;
                    }
                    responsavel.Nome = txtNome.Text;



                    #endregion

                    #region VALIDA - CPF

                    //if (mskCpf.MaskCompleted == false)
                    //{
                    //    errorProviderTela.SetError(mskCpf, "Informe o cpf");
                    //    return;
                    //}
                    //  responsavel.Cpf = mskCpf.Text;

                    #endregion

                    #region VALIDA - GRAU PARENTESCO

                    if (string.IsNullOrEmpty(cmbGrauParentesco.Text) || cmbGrauParentesco.Text.ToLower().Equals("selecione"))
                    {
                        errorProviderTela.SetError(cmbGrauParentesco, "Informe o Grau de Parentesco");
                        return;
                    }

                    #endregion

                    if (responsavel == null || responsavel.ID <= 0)
                    {
                        responsavel = new Responsavel();
                        responsavel.Nome = txtNome.Text;
                        responsavel.Cpf = mskCpf.Text;
                        IResponsavelProcesso processoReponsavel = ResponsavelProcesso.Instance;
                        responsavel.Status = (int)Status.Ativo;
                        processoReponsavel.Incluir(responsavel);
                        processoReponsavel.Confirmar();
                        Memoria m = Memoria.Instance;
                        m.Responsavel = responsavel;
                        m.Status = StatusBanco.Alteracao;
                    }

                    IResponsavelAlunoProcesso processo = ResponsavelAlunoProcesso.Instance;
                    ResponsavelAluno responsavelAluno = new ResponsavelAluno();
                    responsavelAluno.Status = (int)Status.Ativo;
                    responsavelAluno.AlunoID = memoria.Aluno.ID;
                    responsavelAluno.ResponsavelID = responsavel.ID;

                   

                    responsavelAluno.GrauParentesco = cmbGrauParentesco.Text;
                    if (!ckbResideCom.Checked)
                        responsavelAluno.ResideCom = 0;
                    else
                        responsavelAluno.ResideCom = 1;
                    responsavelAluno.Restricoes = txtRestricoes.Text;




                    switch (statusBanco)
                    {
                        case StatusBanco.Inclusao:
                            {
                                if (processo.Consultar(responsavelAluno, Negocios.ModuloBasico.Enums.TipoPesquisa.E).Count > 0)
                                {
                                    throw new Exception("Responsável já vinculado ao Aluno.");
                                }
                                processo.Incluir(responsavelAluno);
                                processo.Confirmar();
                                break;
                            }
                        case StatusBanco.Alteracao:
                            {
                                responsavelAluno.ID = responsavelAlunoLista[linhaSelecionadaGrid].ID;
                                processo.Alterar(responsavelAluno);
                                processo.Confirmar();
                                break;
                            }
                       
                    }
                   
                

                    if (memoria.Status == StatusBanco.Alteracao)
                    {
                        Program.ultimaTela = 8;
                        this.Hide();
                        telaAlunoResponsavel telaRespAux = telaAlunoResponsavel.getInstancia();
                        telaRespAux.Show();
                    }
                    else
                    {
                        CarregarGrid();
                        ManipularCampos(true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void ucDesconectarLogin1_EventoDesconectar()
        {
            Program.ultimaTela = 9;
            this.Close();
            telaLogin telalogin = telaLogin.getInstancia();
            telalogin.Show();
        }

        private void mskCpf_Leave(object sender, EventArgs e)
        {
            mskCpf.BackColor = System.Drawing.Color.White;
        }

        private void mskCpf_Enter(object sender, EventArgs e)
        {
            mskCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        private void mskCpf_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
            try
            {
                if (mskCpf.MaskCompleted && !mskCpf.ReadOnly)
                {
                    IResponsavelProcesso processo = ResponsavelProcesso.Instance;
                    responsavel = new Responsavel();
                    responsavel.Cpf = mskCpf.Text;
                    List<Responsavel> resultado = processo.Consultar(responsavel, TipoPesquisa.E);

                    if (resultado.Count > 0)
                    {
                        responsavel = resultado[0];
                        txtNome.Text = responsavel.Nome;
                        bloquearCampos = true;
                        BloquearCampos();
                    }
                }
            }
            catch (Exception)
            {


            }
        }

        private void BloquearCampos()
        {
            txtNome.ReadOnly = bloquearCampos;
            mskCpf.ReadOnly = bloquearCampos;
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            responsavel = new Responsavel();
            mskCpf.Clear();
            bloquearCampos = false;
            BloquearCampos();
        }

        private void ucMenuInferior1_EventoDeletar()
        {
            try
            {
                IResponsavelAlunoProcesso processo = ResponsavelAlunoProcesso.Instance;
                processo.Excluir(responsavelAlunoLista[linhaSelecionadaGrid]);
                processo.Confirmar();
                CarregarGrid();
            }
            catch (Exception)
            {


            }

        }

        private void telaAlunoResponsavelBusca_Activated(object sender, EventArgs e)
        {

            LimparCampos();
            if (memoria.Aluno != null)
            {
                // CarregarCombos();
                ManipularCampos(true);
                bloquearCampos = false;
                responsavel = new Responsavel();
                uMenuImagem1.carregaAluno(memoria.Aluno);
                CarregarGrid();
                ucMenuInferior1.exibirBotaoIncluir();
                ucMenuInferior1.exibirBotaoDeletar();
                ucMenuInferior1.exibirBotaoAlterar();
                if (responsavelAlunoLista.Count > 0)
                {
                    dgvResponsavelAluno.Rows[0].Selected = true;
                    linhaSelecionadaGrid = 0;
                    
                }
                
                uMenuImagem1.ocultarBotaoAdicionarImagem();
            }



            if (memoria.Status == StatusBanco.Alteracao)
            {

                CarregarGrid();
            }
        }

        public void LimparCampos()
        {
            txtNome.Clear();
            mskCpf.Clear();
            txtRestricoes.Clear();
            ckbResideCom.Checked = false;

        }

        private void dgvResponsavelAluno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Memoria memoria = Memoria.Instance;
            memoria.Responsavel = responsavelAlunoLista[linhaSelecionadaGrid].Responsavel;
            memoria.Responsavel.ID = responsavelAlunoLista[linhaSelecionadaGrid].ResponsavelID;
            memoria.Status = StatusBanco.Alteracao;
            Program.ultimaTela = 8;
            this.Hide();
            telaAlunoResponsavel telaRespAux = telaAlunoResponsavel.getInstancia();
            telaRespAux.Show();
        }

        private void ManipularCampos(bool bloquear)
        {
            if (bloquear)
            {
                cmbGrauParentesco.Enabled = false;
                txtRestricoes.ReadOnly = true;
                txtNome.ReadOnly = true;
                mskCpf.ReadOnly = true;
                ckbResideCom.Enabled = false;
                btnPesquisar.Enabled = false;
            }
            else
            {
                cmbGrauParentesco.Enabled = true;
                txtRestricoes.ReadOnly = false;
                txtNome.ReadOnly = false;
                mskCpf.ReadOnly = false;
                ckbResideCom.Enabled = true;
                btnPesquisar.Enabled = true;

            }

        }

        private void ucMenuInferior1_EventoIncluir()
        {
            ManipularCampos(false);
            LimparCampos();
            statusBanco = StatusBanco.Inclusao;
        }

        private void ucMenuInferior1_EventoAlterar()
        {
            ManipularCampos(false);

            statusBanco = StatusBanco.Alteracao;
        }
       
    }
}
