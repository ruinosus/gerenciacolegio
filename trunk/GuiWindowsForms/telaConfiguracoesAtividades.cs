using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.ModuloFuncionario.Processos;
using Negocios.ModuloAtividade.Processos;
using Negocios.ModuloAtividade.Constantes;

namespace GuiWindowsForms
{
    public partial class txtNomeAtividade : Form
    {
        Funcionario funcionario = null;
        Atividade atividade = null;

        int linhaSelecionadaGrid = -1;

        List<Atividade> listaAtividade = null;

        IFuncionarioProcesso funcionarioControlador = null;
        IAtividadeProcesso atividadeControlador = null;

        #region SINGLETON DA TELA
        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static txtNomeAtividade telaconfiguracoesatividades;

        private static bool IsShown = false;
        #endregion

        #region INSTANCIA TELA CONFIGURACOES ATIVIDADES
        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. 
        /// Evita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>

        public static txtNomeAtividade getInstancia()
        {
            if (telaconfiguracoesatividades == null)
            {
                telaconfiguracoesatividades = new txtNomeAtividade();
            }
            return telaconfiguracoesatividades;
        }
        #endregion

        #region CONSTRUTOR
        /// <summary>
        /// Construtor da tela
        /// </summary>

        public txtNomeAtividade()
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
            txtNomeAtividade telaconfatv = txtNomeAtividade.getInstancia();
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
            funcionarioControlador = FuncionarioProcesso.Instance;
            atividadeControlador = AtividadeProcesso.Instance;

            List<Funcionario> listaFuncionarioCmb = new List<Funcionario>();
            listaFuncionarioCmb = funcionarioControlador.Consultar();
            cmbFuncionario.DataSource = listaFuncionarioCmb;
            cmbFuncionario.DisplayMember = "Nome";

            List<Atividade> listaAtividadeCmb = new List<Atividade>();
            listaAtividadeCmb = atividadeControlador.Consultar();
            cmbAtividadeTurma.DataSource = listaAtividadeCmb;
            cmbAtividadeTurma.DisplayMember = "Nome";

            carregaForm();

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


        #region INCLUIR ATIVIDADE
        private void btnAdicionarAtividade_Click(object sender, EventArgs e)
        {
            atividadeControlador = AtividadeProcesso.Instance;
            funcionarioControlador = FuncionarioProcesso.Instance;

            funcionario = new Funcionario();
            atividade = new Atividade();

            try
            {

                #region VALIDA - NOME

                if (String.IsNullOrEmpty(txtNome.Text))
                {
                    errorProviderTela.SetError(txtNome, "Informe o nome");
                    txtNome.Clear();
                    return;
                }
                atividade.Nome = txtNome.Text;

                #endregion

                #region VALIDA - DESCRIÇÃO

                if (String.IsNullOrEmpty(txtDescricao.Text))
                {
                    errorProviderTela.SetError(txtDescricao, "Informe a descrição");
                    txtDescricao.Clear();
                    return;
                }
                atividade.Descricao = txtDescricao.Text;

                #endregion

                if (verificaSeJaInserido(atividade) == false)
                {
                    atividade.Status = 0;
                    atividadeControlador.Incluir(atividade);
                    atividadeControlador.Confirmar();
                    linhaSelecionadaGrid = -1;

                    MessageBox.Show(AtividadeConstantes.ATIVIDADE_INCLUIDA, "Colégio Conhecer - Inserir Atividade");
                }
                else
                {
                    MessageBox.Show("A atividade já existe na base de dados", "Colégio Conhecer - Inserir Atividade");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            carregaForm();
            limparTela();
        }
        #endregion

        #region ALTERAR ATIVIDADE/TURMA
        private void ucMenuInferior1_EventoCadastrar()
        {
            try
            {
                atividadeControlador = AtividadeProcesso.Instance;

                if (pagCadastrarAtividade.Focused == true)
                {
                    #region VALIDA - NOME

                    if (String.IsNullOrEmpty(txtNome.Text))
                    {
                        errorProviderTela.SetError(txtNome, "Informe o nome");
                        txtNome.Clear();
                        return;
                    }

                    #endregion

                    #region VALIDA - DESCRIÇÃO

                    if (String.IsNullOrEmpty(txtDescricao.Text))
                    {
                        errorProviderTela.SetError(txtDescricao, "Informe a descrição");
                        txtDescricao.Clear();
                        return;
                    }

                    #endregion
                }
                else
                {
                    #region VALIDA - FUNCIONARIO

                    if (String.IsNullOrEmpty(cmbFuncionario.Text))
                    {
                        errorProviderTela.SetError(cmbFuncionario, "Informe a configuração de atividades");
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            carregaForm();
        }
        #endregion


        #region Evento para limpar os campos da tela
        public void limparTela()
        {
            txtDescricao.Clear();
            txtNome.Clear();
            txtTurma.Clear();
            txtValor.Clear();
            dtpHorarioFim.Value = DateTime.Now;
            dtpHorarioInicio.Value = DateTime.Now;
            ckbDomingo.Checked = false;
            ckbQuarta.Checked = false;
            ckbQuinta.Checked = false;
            ckbSabado.Checked = false;
            ckbSegunda.Checked = false;
            ckbSexta.Checked = false;
            ckbTerca.Checked = false;
        }
        #endregion

        #region Função para verificar se a atividade já esta cadastrado
        public bool verificaSeJaInserido(Atividade atividade)
        {
            atividadeControlador = AtividadeProcesso.Instance;

            List<Atividade> listaAuxiliar = new List<Atividade>();
            listaAuxiliar = atividadeControlador.Consultar();

            bool testa = false;

            foreach (Atividade b in listaAuxiliar)
            {
                if ((b.Descricao == atividade.Descricao) && (b.Nome == atividade.Nome))
                {
                    testa = true;
                }
            }
            return testa;
        }
        #endregion

        #region EVENTO PARA ALIMENTAR E ATUALIZAR O DATAGRID
        private void carregaForm()
        {
            atividadeControlador = AtividadeProcesso.Instance;

            listaAtividade = new List<Atividade>();

            listaAtividade = atividadeControlador.Consultar();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaAtividade;
        }
        #endregion

        #region EVENTOS DO GRID

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            if (linhaSelecionadaGrid >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;

                txtDescricao.Text = listaAtividade[linhaSelecionadaGrid].Descricao;
                txtValor.Text = listaAtividade[linhaSelecionadaGrid].Nome;
            }
            else
            {
                linhaSelecionadaGrid = -1;
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            if (linhaSelecionadaGrid >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;

                txtDescricao.Text = listaAtividade[linhaSelecionadaGrid].Descricao;
                txtValor.Text = listaAtividade[linhaSelecionadaGrid].Nome;
            }
            else
            {
                linhaSelecionadaGrid = -1;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            if (linhaSelecionadaGrid >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;

                txtDescricao.Text = listaAtividade[linhaSelecionadaGrid].Descricao;
                txtValor.Text = listaAtividade[linhaSelecionadaGrid].Nome;
            }
            else
            {
                linhaSelecionadaGrid = -1;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            if (linhaSelecionadaGrid >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;

                txtDescricao.Text = listaAtividade[linhaSelecionadaGrid].Descricao;
                txtValor.Text = listaAtividade[linhaSelecionadaGrid].Nome;
            }
            else
            {
                linhaSelecionadaGrid = -1;
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            if (linhaSelecionadaGrid >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;

                txtDescricao.Text = listaAtividade[linhaSelecionadaGrid].Descricao;
                txtValor.Text = listaAtividade[linhaSelecionadaGrid].Nome;
            }
            else
            {
                linhaSelecionadaGrid = -1;
            }
        }

        #endregion
    }
}
