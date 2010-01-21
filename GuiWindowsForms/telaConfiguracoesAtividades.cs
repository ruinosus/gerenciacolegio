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
using System.IO;
using Negocios.ModuloAtividadeTurma.Processos;
using Negocios.ModuloAtividadeTurma.Constantes;
using Negocios.ModuloBasico.Enums;

namespace GuiWindowsForms
{
    public partial class telaConfiguracoesAtividades : Form
    {
        Funcionario funcionario = null;
        Atividade atividade = null;
        Atividade atividadeAux = new Atividade();
        AtividadeTurma atividadeTurma = new AtividadeTurma();

        int verificaButton = 0;
        int verificaTelaImagem = 0;

        private Image imagemAuxiliar = null;

        int linhaSelecionadaGrid = -1;

        List<Atividade> listaAtividade = new List<Atividade>();
        List<AtividadeTurma> listaTurmaAtividade = new List<AtividadeTurma>();
        List<classeAuxiliarAtividadeTurma> listaTurmaAtividadeGrid = null;

        IFuncionarioProcesso funcionarioControlador = null;
        IAtividadeProcesso atividadeControlador = null;
        IAtividadeTurmaProcesso atividadeTurmaControlador = null;

        #region MÉTODOS INICIAS DA TELA

        #region SINGLETON DA TELA
        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaConfiguracoesAtividades telaconfiguracoesatividades;

        private static bool IsShown = false;
        #endregion

        #region INSTANCIA TELA CONFIGURACOES ATIVIDADES
        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. 
        /// Evita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>

        public static telaConfiguracoesAtividades getInstancia()
        {
            if (telaconfiguracoesatividades == null)
            {
                telaconfiguracoesatividades = new telaConfiguracoesAtividades();
            }
            return telaconfiguracoesatividades;
        }
        #endregion

        #region CONSTRUTOR
        /// <summary>
        /// Construtor da tela
        /// </summary>

        public telaConfiguracoesAtividades()
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

        #endregion

        #region USER CONTROLS

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
            telaConfiguracoesAtividades telaconfatv = telaConfiguracoesAtividades.getInstancia();
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
            txtNome.Enabled = false;
            txtDescricao.Enabled = false;
            btnAdicionarImagem.Enabled = true;
            ucMenuInferior1.BotaoCadastrar.Enabled = false;
            dataGridView1.Enabled = false;
            btnAlterarAtividade.Enabled = true;
            btnExcluirAtividade.Enabled = true;
            btnAdicionarTurma.Enabled = true;
            btnAdicionarAtividade.Enabled = true;
            txtTurma.Enabled = false;
            txtValor.Enabled = false;
            cmbAtividadeTurma.Enabled = false;
            cmbFuncionario.Enabled = false;
            dtpHorarioFim.Enabled = false;
            dtpHorarioInicio.Enabled = false;
            ckbDomingo.Enabled = false;
            ckbQuarta.Enabled = false;
            ckbQuinta.Enabled = false;
            ckbSabado.Enabled = false;
            ckbSegunda.Enabled = false;
            ckbSexta.Enabled = false;
            ckbTerca.Enabled = false;
            dataGridView2.Enabled = true;
            btnAlterarAtividadeTurma.Enabled = true;
            btnExcluirTurma.Enabled = true;
            ucMenuInferior1.BotaoCadastrar.Enabled = false;

        }

        #endregion

        #endregion

        #region MÉTODOS PARA CARGA E INICIALIZAÇÃO

        #region LOAD
        private void telaConfiguracoesAtividades_Activated(object sender, EventArgs e)
        {
            if (verificaTelaImagem == 0)
            {
                ucMenuInferior1.BotaoCadastrar.Enabled = false;
                btnAdicionarImagem.Enabled = false;
                dataGridView1.Enabled = true;

                funcionarioControlador = FuncionarioProcesso.Instance;
                atividadeControlador = AtividadeProcesso.Instance;

                List<Funcionario> listaFuncionarioCmb = new List<Funcionario>();
                listaFuncionarioCmb = funcionarioControlador.Consultar();
                cmbFuncionario.DataSource = listaFuncionarioCmb;
                cmbFuncionario.DisplayMember = "Nome";

                carregarComboAtividade();

                carregaForm();
                carregaForm2();

                verificaTelaImagem = 0;
            }
        }
        #endregion

        #region CARREGAR COMBO ATIVIDADE
        public void carregarComboAtividade()
        {
            Atividade carregarComboAtividade = new Atividade();

            carregarComboAtividade.Status = (int)Status.Ativo;

            List<Atividade> listaAtividadeCmb = new List<Atividade>();
            listaAtividadeCmb = atividadeControlador.Consultar(carregarComboAtividade, TipoPesquisa.E);
            cmbAtividadeTurma.DataSource = null;
            cmbAtividadeTurma.DataSource = listaAtividadeCmb;
            cmbAtividadeTurma.DisplayMember = "Nome";
        }
        #endregion

        #endregion


        #region CONTROLES (BOTÕES E GRIDS)

        #region CONTROLES DA TELA ATIVIDADE

        #region BOTÃO INCLUIR ATIVIDADE
        private void btnAdicionarAtividade_Click(object sender, EventArgs e)
        {
            IniciarCamposAtividade();

            verificaButton = 1;

            txtNome.Enabled = true;
            txtDescricao.Enabled = true;
            btnAdicionarImagem.Enabled = true;
            ucMenuInferior1.BotaoCadastrar.Enabled = true;
            dataGridView1.Enabled = false;
            btnAlterarAtividade.Enabled = false;
            btnExcluirAtividade.Enabled = false;
            pctImagemAtividade.Image = null;
        }
        #endregion

        #region BOTÃO ALTERAR ATIVIDADE
        private void btnAlterarAtividade_Click(object sender, EventArgs e)
        {
            verificaButton = 2;

            txtNome.Enabled = true;
            txtDescricao.Enabled = true;
            btnAdicionarImagem.Enabled = true;
            ucMenuInferior1.BotaoCadastrar.Enabled = true;
            dataGridView1.Enabled = false;
            btnAdicionarAtividade.Enabled = false;
            btnExcluirAtividade.Enabled = false;
        }
        #endregion

        #region BOTÃO EXCLUIR ATIVIDADE
        private void btnExcluirAtividade_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir a atividade ?", "Colégio Conhecer - Excluir Atividade", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                if (linhaSelecionadaGrid != -1)
                {
                    atividadeControlador.Excluir(listaAtividade[linhaSelecionadaGrid]);
                    atividadeControlador.Confirmar();
                    carregaForm();
                    linhaSelecionadaGrid = -1;
                }
                else
                {
                    MessageBox.Show("Selecione uma opção na tabela abaixo para exclusão, então pressione excluir.", "Colégio Conhecer - Excluir Atividade");
                }
            }
        }
        #endregion

        #endregion

        #region CONTROLES DA TELA TURMA (ATIVIDADE)

        #region BOTÃO EXCLUIR TURMA
        private void btnExcluirTurma_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir a turma ?", "Colégio Conhecer - Excluir Atividade - Turma", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                if (linhaSelecionadaGrid != -1)
                {
                    atividadeTurmaControlador.Excluir(listaTurmaAtividade[linhaSelecionadaGrid]);
                    atividadeTurmaControlador.Confirmar();
                    carregaForm2();
                    linhaSelecionadaGrid = -1;
                }
                else
                {
                    MessageBox.Show("Selecione uma opção na tabela abaixo para exclusão, então pressione excluir.", "Colégio Conhecer - Excluir Atividade - Turma");
                }
            }
        }
        #endregion

        #region BOTÃO INSERIR TURMA
        private void btnAdicionarTurma_Click(object sender, EventArgs e)
        {
            IniciarCamposTurma();

            verificaButton = 3;

            txtTurma.Enabled = true;
            txtValor.Enabled = true;
            cmbAtividadeTurma.Enabled = true;
            cmbFuncionario.Enabled = true;
            dtpHorarioFim.Enabled = true;
            dtpHorarioInicio.Enabled = true;
            ckbDomingo.Enabled = true;
            ckbQuarta.Enabled = true;
            ckbQuinta.Enabled = true;
            ckbSabado.Enabled = true;
            ckbSegunda.Enabled = true;
            ckbSexta.Enabled = true;
            ckbTerca.Enabled = true;
            dataGridView2.Enabled = false;
            btnAlterarAtividadeTurma.Enabled = false;
            btnExcluirTurma.Enabled = false;
            ucMenuInferior1.BotaoCadastrar.Enabled = true;
        }
        #endregion

        #region BOTÃO ALTERAR TURMA
        private void btnAlterarAtividadeTurma_Click(object sender, EventArgs e)
        {
            verificaButton = 4;

            txtTurma.Enabled = true;
            txtValor.Enabled = true;
            cmbAtividadeTurma.Enabled = true;
            cmbFuncionario.Enabled = true;
            dtpHorarioFim.Enabled = true;
            dtpHorarioInicio.Enabled = true;
            ckbDomingo.Enabled = true;
            ckbQuarta.Enabled = true;
            ckbQuinta.Enabled = true;
            ckbSabado.Enabled = true;
            ckbSegunda.Enabled = true;
            ckbSexta.Enabled = true;
            ckbTerca.Enabled = true;
            dataGridView2.Enabled = false;
            btnAdicionarTurma.Enabled = false;
            btnExcluirTurma.Enabled = false;
            ucMenuInferior1.BotaoCadastrar.Enabled = true;
        }
        #endregion

        #endregion

        #region CONTROLE DOS GRIDS

        #region EVENTO PARA ALIMENTAR E ATUALIZAR OS DATAGRIDS
        private void carregaForm()
        {
            Atividade atividadeAux = new Atividade();
            atividadeAux.Status = (int)Status.Ativo;

            atividadeControlador = AtividadeProcesso.Instance;

            listaAtividade = atividadeControlador.Consultar(atividadeAux, TipoPesquisa.E);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaAtividade;
        }

        private void carregaForm2()
        {
            atividadeTurmaControlador = AtividadeTurmaProcesso.Instance;

            listaTurmaAtividade = atividadeTurmaControlador.Consultar();
            listaTurmaAtividadeGrid = new List<classeAuxiliarAtividadeTurma>();

            foreach (AtividadeTurma a in listaTurmaAtividade)
            {
                classeAuxiliarAtividadeTurma classeAtvTurma = new classeAuxiliarAtividadeTurma();

                classeAtvTurma.AtividadeAuxTurma = a.Turma;
                classeAtvTurma.FuncionarioAuxTurma = a.Funcionario.Nome;
                classeAtvTurma.HoraInicioAuxTurma = a.HoraInicio;
                classeAtvTurma.HoraFimAuxTurma = a.HoraFim;
                classeAtvTurma.ValorAuxTurma = a.Valor.ToString();
                classeAtvTurma.SegundaAuxTurma = Convert.ToBoolean(a.Segunda);
                classeAtvTurma.TercaAuxTurma = Convert.ToBoolean(a.Terca);
                classeAtvTurma.QuartaAuxTurma = Convert.ToBoolean(a.Quarta);
                classeAtvTurma.QuintaAuxTurma = Convert.ToBoolean(a.Quinta);
                classeAtvTurma.SextaAuxTurma = Convert.ToBoolean(a.Sexta);
                classeAtvTurma.SabadoAuxTurma = Convert.ToBoolean(a.Sabado);
                classeAtvTurma.DomingoAuxTurma = Convert.ToBoolean(a.Domingo);

                listaTurmaAtividadeGrid.Add(classeAtvTurma);
            }

            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = listaTurmaAtividadeGrid;
        }
        #endregion

        #region EVENTOS DOS GRIDS

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            if (linhaSelecionadaGrid >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;

                txtDescricao.Text = listaAtividade[linhaSelecionadaGrid].Descricao;
                txtNome.Text = listaAtividade[linhaSelecionadaGrid].Nome;
                Byte[] imagemAux = listaAtividade[linhaSelecionadaGrid].Imagem;
                if (imagemAux.Length > 0)
                {
                    pctImagemAtividade.Image = arrayParaImagem(imagemAux);
                }
                else
                {
                    pctImagemAtividade.Image = null;
                }
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
                txtNome.Text = listaAtividade[linhaSelecionadaGrid].Nome;
                Byte[] imagemAux = listaAtividade[linhaSelecionadaGrid].Imagem;
                if (imagemAux.Length > 0)
                {
                    pctImagemAtividade.Image = arrayParaImagem(imagemAux);
                }
                else
                {
                    pctImagemAtividade.Image = null;
                }
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
                txtNome.Text = listaAtividade[linhaSelecionadaGrid].Nome;
                Byte[] imagemAux = listaAtividade[linhaSelecionadaGrid].Imagem;
                if (imagemAux.Length > 0)
                {
                    pctImagemAtividade.Image = arrayParaImagem(imagemAux);
                }
                else
                {
                    pctImagemAtividade.Image = null;
                }
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
                txtNome.Text = listaAtividade[linhaSelecionadaGrid].Nome;
                Byte[] imagemAux = listaAtividade[linhaSelecionadaGrid].Imagem;
                if (imagemAux.Length > 0)
                {
                    pctImagemAtividade.Image = arrayParaImagem(imagemAux);
                }
                else
                {
                    pctImagemAtividade.Image = null;
                }
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
                txtNome.Text = listaAtividade[linhaSelecionadaGrid].Nome;
                Byte[] imagemAux = listaAtividade[linhaSelecionadaGrid].Imagem;
                if (imagemAux.Length > 0)
                {
                    pctImagemAtividade.Image = arrayParaImagem(imagemAux);
                }
                else
                {
                    pctImagemAtividade.Image = null;
                }
            }
            else
            {
                linhaSelecionadaGrid = -1;
            }
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            if (linhaSelecionadaGrid >= 0)
            {
                dataGridView2.Rows[e.RowIndex].Selected = true;

                cmbAtividadeTurma.Text = listaTurmaAtividade[linhaSelecionadaGrid].Atividade.Nome;
                cmbFuncionario.Text = listaTurmaAtividade[linhaSelecionadaGrid].Funcionario.Nome;
                txtTurma.Text = listaTurmaAtividade[linhaSelecionadaGrid].Turma;
                txtValor.Text = listaTurmaAtividade[linhaSelecionadaGrid].Valor.ToString();
                dtpHorarioInicio.Value = Convert.ToDateTime(listaTurmaAtividade[linhaSelecionadaGrid].HoraInicio.ToString());
                dtpHorarioFim.Value = Convert.ToDateTime(listaTurmaAtividade[linhaSelecionadaGrid].HoraFim.ToString());

                if (listaTurmaAtividade[linhaSelecionadaGrid].Segunda == 0)
                {
                    ckbSegunda.Checked = true;
                }
                else
                {
                    ckbSegunda.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Terca == 0)
                {
                    ckbTerca.Checked = true;
                }
                else
                {
                    ckbTerca.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Quarta == 0)
                {
                    ckbQuarta.Checked = true;
                }
                else
                {
                    ckbQuarta.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Quinta == 0)
                {
                    ckbQuinta.Checked = true;
                }
                else
                {
                    ckbQuinta.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Sexta == 0)
                {
                    ckbSexta.Checked = true;
                }
                else
                {
                    ckbSexta.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Sabado == 0)
                {
                    ckbSabado.Checked = true;
                }
                else
                {
                    ckbSabado.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Domingo == 0)
                {
                    ckbDomingo.Checked = true;
                }
                else
                {
                    ckbDomingo.Checked = false;
                }

            }
            else
            {
                linhaSelecionadaGrid = -1;
            }
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            if (linhaSelecionadaGrid >= 0)
            {
                dataGridView2.Rows[e.RowIndex].Selected = true;

                cmbAtividadeTurma.Text = listaTurmaAtividade[linhaSelecionadaGrid].Atividade.Nome;
                cmbFuncionario.Text = listaTurmaAtividade[linhaSelecionadaGrid].Funcionario.Nome;
                txtTurma.Text = listaTurmaAtividade[linhaSelecionadaGrid].Turma;
                txtValor.Text = listaTurmaAtividade[linhaSelecionadaGrid].Valor.ToString();
                dtpHorarioInicio.Value = Convert.ToDateTime(listaTurmaAtividade[linhaSelecionadaGrid].HoraInicio.ToString());
                dtpHorarioFim.Value = Convert.ToDateTime(listaTurmaAtividade[linhaSelecionadaGrid].HoraFim.ToString());

                if (listaTurmaAtividade[linhaSelecionadaGrid].Segunda == 0)
                {
                    ckbSegunda.Checked = true;
                }
                else
                {
                    ckbSegunda.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Terca == 0)
                {
                    ckbTerca.Checked = true;
                }
                else
                {
                    ckbTerca.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Quarta == 0)
                {
                    ckbQuarta.Checked = true;
                }
                else
                {
                    ckbQuarta.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Quinta == 0)
                {
                    ckbQuinta.Checked = true;
                }
                else
                {
                    ckbQuinta.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Sexta == 0)
                {
                    ckbSexta.Checked = true;
                }
                else
                {
                    ckbSexta.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Sabado == 0)
                {
                    ckbSabado.Checked = true;
                }
                else
                {
                    ckbSabado.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Domingo == 0)
                {
                    ckbDomingo.Checked = true;
                }
                else
                {
                    ckbDomingo.Checked = false;
                }
            }
            else
            {
                linhaSelecionadaGrid = -1;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            if (linhaSelecionadaGrid >= 0)
            {
                dataGridView2.Rows[e.RowIndex].Selected = true;

                cmbAtividadeTurma.Text = listaTurmaAtividade[linhaSelecionadaGrid].Atividade.Nome;
                cmbFuncionario.Text = listaTurmaAtividade[linhaSelecionadaGrid].Funcionario.Nome;
                txtTurma.Text = listaTurmaAtividade[linhaSelecionadaGrid].Turma;
                txtValor.Text = listaTurmaAtividade[linhaSelecionadaGrid].Valor.ToString();
                dtpHorarioInicio.Value = Convert.ToDateTime(listaTurmaAtividade[linhaSelecionadaGrid].HoraInicio.ToString());
                dtpHorarioFim.Value = Convert.ToDateTime(listaTurmaAtividade[linhaSelecionadaGrid].HoraFim.ToString());

                if (listaTurmaAtividade[linhaSelecionadaGrid].Segunda == 0)
                {
                    ckbSegunda.Checked = true;
                }
                else
                {
                    ckbSegunda.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Terca == 0)
                {
                    ckbTerca.Checked = true;
                }
                else
                {
                    ckbTerca.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Quarta == 0)
                {
                    ckbQuarta.Checked = true;
                }
                else
                {
                    ckbQuarta.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Quinta == 0)
                {
                    ckbQuinta.Checked = true;
                }
                else
                {
                    ckbQuinta.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Sexta == 0)
                {
                    ckbSexta.Checked = true;
                }
                else
                {
                    ckbSexta.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Sabado == 0)
                {
                    ckbSabado.Checked = true;
                }
                else
                {
                    ckbSabado.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Domingo == 0)
                {
                    ckbDomingo.Checked = true;
                }
                else
                {
                    ckbDomingo.Checked = false;
                }
            }
            else
            {
                linhaSelecionadaGrid = -1;
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            if (linhaSelecionadaGrid >= 0)
            {
                dataGridView2.Rows[e.RowIndex].Selected = true;

                cmbAtividadeTurma.Text = listaTurmaAtividade[linhaSelecionadaGrid].Atividade.Nome;
                cmbFuncionario.Text = listaTurmaAtividade[linhaSelecionadaGrid].Funcionario.Nome;
                txtTurma.Text = listaTurmaAtividade[linhaSelecionadaGrid].Turma;
                txtValor.Text = listaTurmaAtividade[linhaSelecionadaGrid].Valor.ToString();
                dtpHorarioInicio.Value = Convert.ToDateTime(listaTurmaAtividade[linhaSelecionadaGrid].HoraInicio.ToString());
                dtpHorarioFim.Value = Convert.ToDateTime(listaTurmaAtividade[linhaSelecionadaGrid].HoraFim.ToString());

                if (listaTurmaAtividade[linhaSelecionadaGrid].Segunda == 0)
                {
                    ckbSegunda.Checked = true;
                }
                else
                {
                    ckbSegunda.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Terca == 0)
                {
                    ckbTerca.Checked = true;
                }
                else
                {
                    ckbTerca.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Quarta == 0)
                {
                    ckbQuarta.Checked = true;
                }
                else
                {
                    ckbQuarta.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Quinta == 0)
                {
                    ckbQuinta.Checked = true;
                }
                else
                {
                    ckbQuinta.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Sexta == 0)
                {
                    ckbSexta.Checked = true;
                }
                else
                {
                    ckbSexta.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Sabado == 0)
                {
                    ckbSabado.Checked = true;
                }
                else
                {
                    ckbSabado.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Domingo == 0)
                {
                    ckbDomingo.Checked = true;
                }
                else
                {
                    ckbDomingo.Checked = false;
                }
            }
            else
            {
                linhaSelecionadaGrid = -1;
            }
        }

        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            if (linhaSelecionadaGrid >= 0)
            {
                dataGridView2.Rows[e.RowIndex].Selected = true;

                cmbAtividadeTurma.Text = listaTurmaAtividade[linhaSelecionadaGrid].Atividade.Nome;
                cmbFuncionario.Text = listaTurmaAtividade[linhaSelecionadaGrid].Funcionario.Nome;
                txtTurma.Text = listaTurmaAtividade[linhaSelecionadaGrid].Turma;
                txtValor.Text = listaTurmaAtividade[linhaSelecionadaGrid].Valor.ToString();
                dtpHorarioInicio.Value = Convert.ToDateTime(listaTurmaAtividade[linhaSelecionadaGrid].HoraInicio.ToString());
                dtpHorarioFim.Value = Convert.ToDateTime(listaTurmaAtividade[linhaSelecionadaGrid].HoraFim.ToString());

                if (listaTurmaAtividade[linhaSelecionadaGrid].Segunda == 0)
                {
                    ckbSegunda.Checked = true;
                }
                else
                {
                    ckbSegunda.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Terca == 0)
                {
                    ckbTerca.Checked = true;
                }
                else
                {
                    ckbTerca.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Quarta == 0)
                {
                    ckbQuarta.Checked = true;
                }
                else
                {
                    ckbQuarta.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Quinta == 0)
                {
                    ckbQuinta.Checked = true;
                }
                else
                {
                    ckbQuinta.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Sexta == 0)
                {
                    ckbSexta.Checked = true;
                }
                else
                {
                    ckbSexta.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Sabado == 0)
                {
                    ckbSabado.Checked = true;
                }
                else
                {
                    ckbSabado.Checked = false;
                }
                if (listaTurmaAtividade[linhaSelecionadaGrid].Domingo == 0)
                {
                    ckbDomingo.Checked = true;
                }
                else
                {
                    ckbDomingo.Checked = false;
                }
            }
            else
            {
                linhaSelecionadaGrid = -1;
            }
        }

        #endregion

        #endregion

        #endregion


        #region BOTÃO SALVAR INFORMAÇÕES
        private void ucMenuInferior1_EventoCadastrar()
        {
            //Verifica o button selecionado se é Alterar numero(2) 
            //ou Adicionar numero(1)

            if (verificaButton == 2)
            {
                #region ALTERAR ATIVIDADE
                atividadeControlador = AtividadeProcesso.Instance;
                atividadeTurmaControlador = AtividadeTurmaProcesso.Instance;

                atividade = new Atividade();
                atividadeTurma = new AtividadeTurma();

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

                    //if (String.IsNullOrEmpty(txtDescricao.Text))
                    //{
                    //    errorProviderTela.SetError(txtDescricao, "Informe a descrição");
                    //    txtDescricao.Clear();
                    //    return;
                    //}
                    atividade.Descricao = txtDescricao.Text;

                    #endregion

                    if (pctImagemAtividade.Image != null)
                    {
                        atividade.Imagem = atividadeAux.Imagem;
                    }

                    if (linhaSelecionadaGrid != -1)
                    {
                        atividade.ID = listaAtividade[linhaSelecionadaGrid].ID;
                        atividade.Status = (int)Status.Ativo;
                        atividadeControlador.Alterar(atividade);
                        atividadeControlador.Confirmar();
                        linhaSelecionadaGrid = -1;

                        carregarComboAtividade();
                        pctImagemAtividade.Image = null;

                        MessageBox.Show(AtividadeConstantes.ATIVIDADE_ALTERADA, "Colégio Conhecer");
                    }
                    else
                    {
                        MessageBox.Show("Selecione um registro para alterar, caso queira inserir use o botão +", "Colégio Conhecer");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                btnAdicionarImagem.Enabled = false;
                carregaForm();
                limparTela();

                #endregion
            }
            else if (verificaButton == 1)
            {
                #region ADICIONAR ATIVIDADE

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

                    //if (String.IsNullOrEmpty(txtDescricao.Text))
                    //{
                    //    errorProviderTela.SetError(txtDescricao, "Informe a descrição");
                    //    txtDescricao.Clear();
                    //    return;
                    //}
                    atividade.Descricao = txtDescricao.Text;

                    #endregion

                    if (pctImagemAtividade.Image != null)
                    {
                        atividade.Imagem = atividadeAux.Imagem;
                    }

                    if (verificaSeJaInserido(atividade) == false)
                    {
                        atividade.Status = (int)Status.Ativo;
                        atividadeControlador.Incluir(atividade);
                        atividadeControlador.Confirmar();
                        linhaSelecionadaGrid = -1;

                        carregarComboAtividade();
                        pctImagemAtividade.Image = null;

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
                btnAdicionarImagem.Enabled = false;

                #endregion
            }
            else if (verificaButton == 4)
            {
                #region ALTERAR ATIVIDADE TURMA
                try
                {
                    #region VALIDA - FUNCIONARIO

                    if (String.IsNullOrEmpty(cmbFuncionario.Text))
                    {
                        errorProviderTela.SetError(cmbFuncionario, "Informe o funcionário da atividade");
                        return;
                    }
                    atividadeTurma.FuncionarioID = ((Funcionario)cmbFuncionario.SelectedItem).ID;


                    #endregion

                    #region VALIDA - ATIVIDADE

                    if (String.IsNullOrEmpty(cmbAtividadeTurma.Text))
                    {
                        errorProviderTela.SetError(cmbAtividadeTurma, "Informe a atividade a ser configurada");
                        return;
                    }
                    atividadeTurma.AtividadeID = ((Atividade)cmbAtividadeTurma.SelectedItem).ID;


                    #endregion

                    #region VALIDA - TURMA

                    if (String.IsNullOrEmpty(txtTurma.Text))
                    {
                        errorProviderTela.SetError(txtTurma, "Informe a turma");
                        txtTurma.Clear();
                        return;
                    }
                    atividadeTurma.Turma = txtTurma.Text;

                    #endregion

                    #region VALIDA - VALOR

                    if (String.IsNullOrEmpty(txtValor.Text))
                    {
                        errorProviderTela.SetError(txtValor, "Informe o valor");
                        txtValor.Clear();
                        return;
                    }
                    atividadeTurma.Valor = Convert.ToDouble(txtValor.Text);

                    #endregion

                    #region VALIDA - DIA DA SEMANA
                    if (ckbDomingo.Checked == false && ckbSegunda.Checked == false && ckbTerca.Checked == false &&
                        ckbQuarta.Checked == false && ckbQuinta.Checked == false && ckbSexta.Checked == false && ckbSabado.Checked == false)
                    {
                        errorProviderTela.SetError(ckbSabado, "Informe o dia da semana");
                        return;
                    }
                    if (ckbDomingo.Checked == true)
                        atividadeTurma.Domingo = 0;
                    if (ckbQuarta.Checked == true)
                        atividadeTurma.Quarta = 0;
                    if (ckbQuinta.Checked == true)
                        atividadeTurma.Quinta = 0;
                    if (ckbSabado.Checked == true)
                        atividadeTurma.Sabado = 0;
                    if (ckbSegunda.Checked == true)
                        atividadeTurma.Segunda = 0;
                    if (ckbSexta.Checked == true)
                        atividadeTurma.Sexta = 0;
                    if (ckbTerca.Checked == true)
                        atividadeTurma.Terca = 0;

                    #endregion

                    atividadeTurma.HoraInicio = dtpHorarioFim.ToString();
                    atividadeTurma.HoraFim = dtpHorarioFim.ToString();

                    atividadeTurma.Status = 0;

                    if (linhaSelecionadaGrid != -1)
                    {
                        atividadeTurmaControlador.Alterar(atividadeTurma);
                        atividadeTurmaControlador.Confirmar();
                        linhaSelecionadaGrid = -1;

                        MessageBox.Show(AtividadeTurmaConstantes.ATIVIDADETURMA_ALTERADA, "Colégio Conhecer");
                    }
                    else
                    {
                        MessageBox.Show("Selecione um registro para alterar, caso queira inserir use o botão +", "Colégio Conhecer");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                carregaForm2();
                limparTela();
                #endregion
            }
            else
            {
                #region EVENTO ADICIONAR TURMA

                atividadeTurma = new AtividadeTurma();
                atividadeTurmaControlador = AtividadeTurmaProcesso.Instance;

                try
                {
                    #region VALIDA - FUNCIONARIO

                    //if (String.IsNullOrEmpty(cmbFuncionario.Text))
                    //{
                    //    errorProviderTela.SetError(cmbFuncionario, "Informe o funcionário da atividade");
                    //    return;
                    //}
                    atividadeTurma.FuncionarioID = ((Funcionario)cmbFuncionario.SelectedItem).ID;


                    #endregion

                    #region VALIDA - ATIVIDADE

                    if (String.IsNullOrEmpty(cmbAtividadeTurma.Text))
                    {
                        errorProviderTela.SetError(cmbAtividadeTurma, "Informe a atividade a ser configurada");
                        return;
                    }
                    atividadeTurma.AtividadeID = ((Atividade)cmbAtividadeTurma.SelectedItem).ID;


                    #endregion

                    #region VALIDA - TURMA

                    //if (String.IsNullOrEmpty(txtTurma.Text))
                    //{
                    //    errorProviderTela.SetError(txtTurma, "Informe a turma");
                    //    txtTurma.Clear();
                    //    return;
                    //}
                    atividadeTurma.Turma = txtTurma.Text;

                    #endregion

                    #region VALIDA - VALOR

                    if (String.IsNullOrEmpty(txtValor.Text))
                    {
                        errorProviderTela.SetError(txtValor, "Informe o valor");
                        txtValor.Clear();
                        return;
                    }
                    atividadeTurma.Valor = Convert.ToDouble(txtValor.Text);

                    #endregion

                    #region VALIDA - DIA DA SEMANA
                    if (ckbDomingo.Checked == false && ckbSegunda.Checked == false && ckbTerca.Checked == false &&
                        ckbQuarta.Checked == false && ckbQuinta.Checked == false && ckbSexta.Checked == false && ckbSabado.Checked == false)
                    {
                        errorProviderTela.SetError(ckbSabado, "Informe o dia da semana");
                        return;
                    }
                    if (ckbDomingo.Checked == true)
                        atividadeTurma.Domingo = 1;
                    if (ckbQuarta.Checked == true)
                        atividadeTurma.Quarta = 1;
                    if (ckbQuinta.Checked == true)
                        atividadeTurma.Quinta = 1;
                    if (ckbSabado.Checked == true)
                        atividadeTurma.Sabado = 1;
                    if (ckbSegunda.Checked == true)
                        atividadeTurma.Segunda = 1;
                    if (ckbSexta.Checked == true)
                        atividadeTurma.Sexta = 1;
                    if (ckbTerca.Checked == true)
                        atividadeTurma.Terca = 1;

                    #endregion

                    atividadeTurma.HoraInicio = dtpHorarioInicio.Value.ToString();
                    atividadeTurma.HoraFim = dtpHorarioFim.Value.ToString();

                    atividadeTurma.Status = 0;

                    if (verificaSeJaInserido2(atividadeTurma) == false)
                    {
                        atividadeTurma.Status = 0;
                        atividadeTurmaControlador.Incluir(atividadeTurma);
                        atividadeTurmaControlador.Confirmar();
                        linhaSelecionadaGrid = -1;

                        MessageBox.Show(AtividadeTurmaConstantes.ATIVIDADETURMA_INCLUIDA, "Colégio Conhecer");
                    }
                    else
                    {
                        MessageBox.Show("A turma já existe na base de dados", "Colégio Conhecer");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                carregaForm2();
                limparTela();

                #endregion
            }

            if (verificaButton == 1 || verificaButton == 2)
            {
                dataGridView1.Enabled = true;
                btnAdicionarAtividade.Enabled = true;
                btnExcluirAtividade.Enabled = true;
                btnAlterarAtividade.Enabled = true;
                txtNome.Enabled = false;
                txtDescricao.Enabled = false;
                pctImagemAtividade.Enabled = false;
            }
            else
            {
                dataGridView2.Enabled = true;
                btnAlterarAtividadeTurma.Enabled = true;
                btnExcluirTurma.Enabled = true;
                btnAdicionarTurma.Enabled = true;
                txtTurma.Enabled = false;
                txtValor.Enabled = false;
                cmbAtividadeTurma.Enabled = false;
                cmbFuncionario.Enabled = false;
                dtpHorarioFim.Enabled = false;
                dtpHorarioInicio.Enabled = false;
                ckbDomingo.Enabled = false;
                ckbQuarta.Enabled = false;
                ckbQuinta.Enabled = false;
                ckbSabado.Enabled = false;
                ckbSegunda.Enabled = false;
                ckbSexta.Enabled = false;
                ckbTerca.Enabled = false;
            }

            verificaButton = 0;
        }
        #endregion


        #region ADICIONAR IMAGEM

        /// <summary>
        /// Função que converte de um array de byte para uma imagem
        /// </summary>
        /// <param name="imagem"></param>
        /// <returns></returns>
        private Image arrayParaImagem(Byte[] imagem)
        {
            MemoryStream ms = new MemoryStream(imagem, 0, imagem.Length);

            if (imagem.Length > 0)
                ms.Write(imagem, 0, imagem.Length);
            return Image.FromStream(ms, true);
        }

        /// <summary>
        /// Função que converte de uma imagem para um array de byte
        /// </summary>
        /// <param name="imagem"></param>
        /// <returns></returns>
        private byte[] imagemParaArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();

            if (imageIn != null)
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        /// <summary>
        /// Função que retorna a imagem e chama a caixa de diálogo para associação.
        /// </summary>
        /// <returns></returns>
        private Image retornarImagem()
        {
            Bitmap imagem = null;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (openFileDialog1.OpenFile() != null)
                    {
                        imagem = new Bitmap(new Bitmap(openFileDialog1.OpenFile()));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                openFileDialog1.Dispose();
            }
            else
            {
                openFileDialog1.Dispose();
            }

            return imagem;
        }

        /// <summary>
        /// Ação para adicionar a imagem ao controle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdicionarImagem_Click(object sender, EventArgs e)
        {
            verificaTelaImagem = 1;
            pctImagemAtividade.SizeMode = PictureBoxSizeMode.StretchImage;

            pctImagemAtividade.Image = retornarImagem();

            if (pctImagemAtividade.Image != null)
            {
                imagemAuxiliar = pctImagemAtividade.Image;
                atividadeAux.Imagem = imagemParaArray(imagemAuxiliar);
            }
        }

        #endregion

        #region MENSAGENS E MÉTODOS DE LIMPEZA

        #region LIMPA CAMPOS DA TELA ATIVIDADE
        private void IniciarCamposAtividade()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            //pctImagemAtividade.Dispose();
        }
        #endregion

        #region LIMPA CAMPOS DA TELA TURMA
        private void IniciarCamposTurma()
        {
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

        #region LIMPA CAMPO DE AMBAS AS TELAS
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

        #region MENSAGENS
        private void btnExcluirAtividade_MouseEnter(object sender, EventArgs e)
        {
            ucMenuInferior1.exibirMensagem("Excluir uma atividade");
        }

        private void btnExcluirAtividade_MouseLeave(object sender, EventArgs e)
        {
            ucMenuInferior1.ocultarMensagem();
        }

        private void btnAdicionarAtividade_MouseEnter(object sender, EventArgs e)
        {
            ucMenuInferior1.exibirMensagem("Adicionar uma atividade");
        }

        private void btnAdicionarAtividade_MouseLeave(object sender, EventArgs e)
        {
            ucMenuInferior1.ocultarMensagem();
        }

        private void dataGridView1_MouseEnter(object sender, EventArgs e)
        {
            ucMenuInferior1.exibirMensagem("Selecione um registro para alterar ou excluir");
        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {
            ucMenuInferior1.ocultarMensagem();
        }

        #endregion

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

        public bool verificaSeJaInserido2(AtividadeTurma atividadeTurma)
        {
            atividadeTurmaControlador = AtividadeTurmaProcesso.Instance;

            List<AtividadeTurma> listaTurmaAuxiliar2 = new List<AtividadeTurma>();
            listaTurmaAuxiliar2 = atividadeTurmaControlador.Consultar();

            bool testa = false;

            foreach (AtividadeTurma b in listaTurmaAuxiliar2)
            {
                if ((b.AtividadeID == atividadeTurma.AtividadeID) && (b.FuncionarioID == atividadeTurma.FuncionarioID) && (b.Valor == atividadeTurma.Valor) && (b.Turma == atividadeTurma.Turma))
                {
                    testa = true;
                }
            }
            return testa;
        }

        #endregion

        private void ucDesconectarLogin1_EventoDesconectar()
        {
            Program.ultimaTela = 9;
            this.Close();
            telaLogin telalogin = telaLogin.getInstancia();
            telalogin.Show();
        }


    }

    #region CLASSE AUXILIAR
    public class classeAuxiliarAtividadeTurma
    {
        string atividadeAuxTurma;

        public string AtividadeAuxTurma
        {
            get { return atividadeAuxTurma; }
            set { atividadeAuxTurma = value; }
        }
        string funcionarioAuxTurma;

        public string FuncionarioAuxTurma
        {
            get { return funcionarioAuxTurma; }
            set { funcionarioAuxTurma = value; }
        }
        string turmaAuxTurma;

        public string TurmaAuxTurma
        {
            get { return turmaAuxTurma; }
            set { turmaAuxTurma = value; }
        }
        string valorAuxTurma;

        public string ValorAuxTurma
        {
            get { return valorAuxTurma; }
            set { valorAuxTurma = value; }
        }
        string horaFimAuxTurma;

        public string HoraFimAuxTurma
        {
            get { return horaFimAuxTurma; }
            set { horaFimAuxTurma = value; }
        }
        string horaInicioAuxTurma;

        public string HoraInicioAuxTurma
        {
            get { return horaInicioAuxTurma; }
            set { horaInicioAuxTurma = value; }
        }
        bool segundaAuxTurma;

        public bool SegundaAuxTurma
        {
            get { return segundaAuxTurma; }
            set { segundaAuxTurma = value; }
        }
        bool tercaAuxTurma;

        public bool TercaAuxTurma
        {
            get { return tercaAuxTurma; }
            set { tercaAuxTurma = value; }
        }
        bool quartaAuxTurma;

        public bool QuartaAuxTurma
        {
            get { return quartaAuxTurma; }
            set { quartaAuxTurma = value; }
        }
        bool quintaAuxTurma;

        public bool QuintaAuxTurma
        {
            get { return quintaAuxTurma; }
            set { quintaAuxTurma = value; }
        }
        bool sextaAuxTurma;

        public bool SextaAuxTurma
        {
            get { return sextaAuxTurma; }
            set { sextaAuxTurma = value; }
        }
        bool sabadoAuxTurma;

        public bool SabadoAuxTurma
        {
            get { return sabadoAuxTurma; }
            set { sabadoAuxTurma = value; }
        }
        bool domingoAuxTurma;

        public bool DomingoAuxTurma
        {
            get { return domingoAuxTurma; }
            set { domingoAuxTurma = value; }
        }
    #endregion
    }
}


