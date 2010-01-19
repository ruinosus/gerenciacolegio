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

        private void telaAlunoResponsavelBusca_Activated(object sender, EventArgs e)
        {
            if (memoria.Aluno != null)
            {
                CarregarCombos();
                uMenuImagem1.carregaAluno(memoria.Aluno);
                IResponsavelAlunoProcesso processo = ResponsavelAlunoProcesso.Instance;
                dgvResponsavelAluno.AutoGenerateColumns = false;
                ResponsavelAluno responsavelAluno = new ResponsavelAluno();
                responsavelAluno.AlunoID = memoria.Aluno.ID;
                responsavelAluno.Status = (int)Status.Ativo;
                responsavelAlunoLista = processo.Consultar(responsavelAluno, Negocios.ModuloBasico.Enums.TipoPesquisa.E);
                dgvResponsavelAluno.DataSource = responsavelAlunoLista;
            }
        }



        private void dgvResponsavelAluno_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());

            if (linhaSelecionadaGrid != -1)
                dgvResponsavelAluno.Rows[linhaSelecionadaGrid].Selected = true;

        }

        private void dgvResponsavelAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());

            if (linhaSelecionadaGrid != -1)
                dgvResponsavelAluno.Rows[linhaSelecionadaGrid].Selected = true;
        }

        private void ucMenuInferior1_EventoCadastrar()
        {
            try
            {
                if (memoria.Aluno != null)
                {
                    IResponsavelAlunoProcesso processo = ResponsavelAlunoProcesso.Instance;
                    ResponsavelAluno responsavelAluno = new ResponsavelAluno();
                    responsavelAluno.Status = (int)Status.Ativo;
                    responsavelAluno.AlunoID = memoria.Aluno.ID;
                    responsavelAluno.ResponsavelID = ((Responsavel)comboResponsavel.SelectedItem).ID;

                    if (processo.Consultar(responsavelAluno, Negocios.ModuloBasico.Enums.TipoPesquisa.E).Count > 0)
                    {
                        throw new Exception("Responsável já vinculado ao Aluno.");
                    }

                    responsavelAluno.GrauParentesco = cmbGrauParentesco.Text;
                    if (!ckbResideCom.Checked)
                        responsavelAluno.ResideCom = 0;
                    else
                        responsavelAluno.ResideCom = 1;
                    responsavelAluno.Restricoes = txtRestricoes.Text;





                    processo.Incluir(responsavelAluno);
                    processo.Confirmar();

                    Program.ultimaTela = 8;
                    this.Close();
                    telaAlunoResponsavel telaRespAux = new telaAlunoResponsavel();
                    telaRespAux.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void CarregarCombos()
        {
            IResponsavelProcesso processo = ResponsavelProcesso.Instance;
            comboResponsavel.DataSource = processo.Consultar();
            comboResponsavel.DisplayMember = "Nome";

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                IResponsavelAlunoProcesso processo = ResponsavelAlunoProcesso.Instance;
                processo.Excluir(responsavelAlunoLista[linhaSelecionadaGrid]);
                processo.Confirmar();
            }
            catch (Exception)
            {

                
            }

        }

        private void ucDesconectarLogin1_EventoDesconectar()
        {
            Program.ultimaTela = 9;
            this.Close();
            telaLogin telalogin = telaLogin.getInstancia();
            telalogin.Show();
        }
    }
}
