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

namespace GuiWindowsForms
{
    public partial class txtNomeAtividade : Form
    {
        Funcionario funcionario = null;
        Atividade atividade = null;
        Atividade atividadeAux = new Atividade();
        AtividadeTurma atividadeTurma = new AtividadeTurma();

        private Image imagemAuxiliar = null;

        int linhaSelecionadaGrid = -1;

        List<Atividade> listaAtividade = new List<Atividade>();
        List<AtividadeTurma> listaTurmaAtividade = new List<AtividadeTurma>();

        IFuncionarioProcesso funcionarioControlador = null;
        IAtividadeProcesso atividadeControlador = null;
        IAtividadeTurmaProcesso atividadeTurmaControlador = null;   

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
            carregaForm2();

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


        #region EVENTO INCLUIR ATIVIDADE
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

                atividade.Imagem = atividadeAux.Imagem;

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

        #region EVENTO ALTERAR ATIVIDADE/TURMA
        private void ucMenuInferior1_EventoCadastrar()
        {
                atividadeControlador = AtividadeProcesso.Instance;
                atividadeTurmaControlador = AtividadeTurmaProcesso.Instance;

                atividade = new Atividade();
                atividadeTurma = new AtividadeTurma();

                if (tbcAtividade.SelectedIndex==0)
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

                        atividade.Imagem = atividadeAux.Imagem;

                        if (linhaSelecionadaGrid != -1)
                        {
                            atividadeControlador.Alterar(atividade);
                            atividadeControlador.Confirmar();
                            linhaSelecionadaGrid = -1;

                            MessageBox.Show(AtividadeConstantes.ATIVIDADE_ALTERADA, "Colégio Conhecer - Alterar Atividade");
                        }
                        else
                        {
                            MessageBox.Show("Selecione um registro para alterar, caso queira inserir use o botão +", "Colégio Conhecer - Alterar Atividade");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    carregaForm();
                    limparTela();
                }
                else
                {
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
                            errorProviderTela.SetError(txtValor, "Informe o dia da semana");
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

                        atividadeTurma.HoraInicio = dtpHorarioFim.Value;
                        atividadeTurma.HoraFim = dtpHorarioFim.Value;

                        atividadeTurma.Status = 0;

                        if (linhaSelecionadaGrid != -1)
                        {
                            atividadeTurmaControlador.Alterar(atividadeTurma);
                            atividadeTurmaControlador.Confirmar();
                            linhaSelecionadaGrid = -1;

                            MessageBox.Show(AtividadeTurmaConstantes.ATIVIDADETURMA_ALTERADA, "Colégio Conhecer - Alterar Atividade - Turma");
                        }
                        else
                        {
                            MessageBox.Show("Selecione um registro para alterar, caso queira inserir use o botão +", "Colégio Conhecer - Alterar Atividade - Turma");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    carregaForm2();
                    limparTela();
                }
            }

        #endregion

        #region EVENTO EXCLUIR ATIVIDADE
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

        #region EVENTO EXCLUIR TURMA
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

        #region EVENTO INSERIR TURMA
        private void btnAdicionarTurma_Click(object sender, EventArgs e)
        {
            atividadeTurma = new AtividadeTurma();
            atividadeTurmaControlador = AtividadeTurmaProcesso.Instance;

                try
                {
                    #region VALIDA - FUNCIONARIO

                    if (String.IsNullOrEmpty(cmbFuncionario.Text))
                    {
                        errorProviderTela.SetError(cmbFuncionario, "Informe o funcionário da atividade");
                        return;
                    }
                    atividadeTurma.FuncionarioID = uint.Parse(((Funcionario)cmbFuncionario.SelectedItem).ID.ToString());


                    #endregion

                    #region VALIDA - ATIVIDADE

                    if (String.IsNullOrEmpty(cmbAtividadeTurma.Text))
                    {
                        errorProviderTela.SetError(cmbAtividadeTurma, "Informe a atividade a ser configurada");
                        return;
                    }
                    atividadeTurma.AtividadeID = uint.Parse(((Atividade)cmbAtividadeTurma.SelectedItem).ID.ToString());


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
                        errorProviderTela.SetError(txtValor, "Informe o dia da semana");
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

                    atividadeTurma.HoraInicio = dtpHorarioInicio.Value;
                    atividadeTurma.HoraFim = dtpHorarioFim.Value;

                    atividadeTurma.Status = 0;

                    if (verificaSeJaInserido2(atividadeTurma) == false)
                    {
                        atividadeTurma.Status = 0;
                        atividadeTurmaControlador.Incluir(atividadeTurma);
                        atividadeTurmaControlador.Confirmar();
                        linhaSelecionadaGrid = -1;

                        MessageBox.Show(AtividadeTurmaConstantes.ATIVIDADETURMA_INCLUIDA, "Colégio Conhecer - Inserir Atividade - Turma");
                    }
                    else
                    {
                        MessageBox.Show("A turma já existe na base de dados", "Colégio Conhecer - Inserir Atividade - Turma");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                carregaForm2();
                limparTela();
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


        public bool verificaSeJaInserido2(AtividadeTurma atividadeTurma)
        {
            atividadeTurmaControlador = AtividadeTurmaProcesso.Instance;

            List<AtividadeTurma> listaTurmaAuxiliar2 = new List<AtividadeTurma>();
            listaTurmaAuxiliar2 = atividadeTurmaControlador.Consultar();

            bool testa = false;

            foreach (AtividadeTurma b in listaTurmaAuxiliar2)
            {
                if ((b.AtividadeID == atividadeTurma.AtividadeID) && (b.FuncionarioID == atividadeTurma.FuncionarioID))
                {
                    testa = true;
                }
            }
            return testa;
        }

        #endregion

        #region EVENTO PARA ALIMENTAR E ATUALIZAR OS DATAGRIDS
        private void carregaForm()
        {
            atividadeControlador = AtividadeProcesso.Instance;

            listaAtividade = atividadeControlador.Consultar();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaAtividade;
        }

        private void carregaForm2()
        {
            atividadeTurmaControlador = AtividadeTurmaProcesso.Instance;

            listaTurmaAtividade = atividadeTurmaControlador.Consultar();

            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = listaTurmaAtividade;
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
                pctImagemAtividade.Image = arrayParaImagem(imagemAux);
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
                pctImagemAtividade.Image = arrayParaImagem(imagemAux);
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
                pctImagemAtividade.Image = arrayParaImagem(imagemAux);
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
                if(imagemAux.Length>0)
                pctImagemAtividade.Image = arrayParaImagem(imagemAux);
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
                dtpHorarioInicio.Value = listaTurmaAtividade[linhaSelecionadaGrid].HoraInicio.Value;
                dtpHorarioFim.Value = listaTurmaAtividade[linhaSelecionadaGrid].HoraFim.Value;
                
                if (listaTurmaAtividade[linhaSelecionadaGrid].Segunda == 0)
                    ckbSegunda.Checked = true;
                if (listaTurmaAtividade[linhaSelecionadaGrid].Terca == 0)
                    ckbTerca.Checked = true;
                if (listaTurmaAtividade[linhaSelecionadaGrid].Quarta == 0)
                    ckbQuarta.Checked = true;
                if (listaTurmaAtividade[linhaSelecionadaGrid].Quinta == 0)
                    ckbQuinta.Checked = true;
                if (listaTurmaAtividade[linhaSelecionadaGrid].Sexta == 0)
                    ckbSexta.Checked = true;
                if (listaTurmaAtividade[linhaSelecionadaGrid].Sabado == 0)
                    ckbSabado.Checked = true;
                if (listaTurmaAtividade[linhaSelecionadaGrid].Domingo == 0)
                    ckbDomingo.Checked = true;

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
                dtpHorarioInicio.Value = listaTurmaAtividade[linhaSelecionadaGrid].HoraInicio.Value;
                dtpHorarioFim.Value = listaTurmaAtividade[linhaSelecionadaGrid].HoraFim.Value;

                if (listaTurmaAtividade[linhaSelecionadaGrid].Segunda == 0)
                    ckbSegunda.Checked = true;
                if (listaTurmaAtividade[linhaSelecionadaGrid].Terca == 0)
                    ckbTerca.Checked = true;
                if (listaTurmaAtividade[linhaSelecionadaGrid].Quarta == 0)
                    ckbQuarta.Checked = true;
                if (listaTurmaAtividade[linhaSelecionadaGrid].Quinta == 0)
                    ckbQuinta.Checked = true;
                if (listaTurmaAtividade[linhaSelecionadaGrid].Sexta == 0)
                    ckbSexta.Checked = true;
                if (listaTurmaAtividade[linhaSelecionadaGrid].Sabado == 0)
                    ckbSabado.Checked = true;
                if (listaTurmaAtividade[linhaSelecionadaGrid].Domingo == 0)
                    ckbDomingo.Checked = true;
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
                dtpHorarioInicio.Value = listaTurmaAtividade[linhaSelecionadaGrid].HoraInicio.Value;
                dtpHorarioFim.Value = listaTurmaAtividade[linhaSelecionadaGrid].HoraFim.Value;

                if (listaTurmaAtividade[linhaSelecionadaGrid].Segunda == 0)
                    ckbSegunda.Checked = true;
                if (listaTurmaAtividade[linhaSelecionadaGrid].Terca == 0)
                    ckbTerca.Checked = true;
                if (listaTurmaAtividade[linhaSelecionadaGrid].Quarta == 0)
                    ckbQuarta.Checked = true;
                if (listaTurmaAtividade[linhaSelecionadaGrid].Quinta == 0)
                    ckbQuinta.Checked = true;
                if (listaTurmaAtividade[linhaSelecionadaGrid].Sexta == 0)
                    ckbSexta.Checked = true;
                if (listaTurmaAtividade[linhaSelecionadaGrid].Sabado == 0)
                    ckbSabado.Checked = true;
                if (listaTurmaAtividade[linhaSelecionadaGrid].Domingo == 0)
                    ckbDomingo.Checked = true;
            }
            else
            {
                linhaSelecionadaGrid = -1;
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

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
                dtpHorarioInicio.Value = listaTurmaAtividade[linhaSelecionadaGrid].HoraInicio.Value;
                dtpHorarioFim.Value = listaTurmaAtividade[linhaSelecionadaGrid].HoraFim.Value;
                
                if (listaTurmaAtividade[linhaSelecionadaGrid].Segunda == 0)
                    ckbSegunda.Checked = true;
                if (listaTurmaAtividade[linhaSelecionadaGrid].Terca == 0)
                    ckbTerca.Checked = true;
                if (listaTurmaAtividade[linhaSelecionadaGrid].Quarta == 0)
                    ckbQuarta.Checked = true;
                if (listaTurmaAtividade[linhaSelecionadaGrid].Quinta == 0)
                    ckbQuinta.Checked = true;
                if (listaTurmaAtividade[linhaSelecionadaGrid].Sexta == 0)
                    ckbSexta.Checked = true;
                if (listaTurmaAtividade[linhaSelecionadaGrid].Sabado == 0)
                    ckbSabado.Checked = true;
                if (listaTurmaAtividade[linhaSelecionadaGrid].Domingo == 0)
                    ckbDomingo.Checked = true;
            }
            else
            {
                linhaSelecionadaGrid = -1;
            }
        }

        #endregion

        #region Mensagens dos botões
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

        #region ADICIONAR IMAGEM

        /// <summary>
        /// Função que converte de um array de byte para uma imagem
        /// </summary>
        /// <param name="imagem"></param>
        /// <returns></returns>
        private Image arrayParaImagem(Byte[] imagem)
        {
            MemoryStream ms = new MemoryStream(imagem, 0, imagem.Length);

            if(imagem.Length>0)
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

            if(imageIn!=null)
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
            pctImagemAtividade.SizeMode = PictureBoxSizeMode.StretchImage;
            pctImagemAtividade.Image = retornarImagem();
            imagemAuxiliar = pctImagemAtividade.Image;
            atividadeAux.Imagem = imagemParaArray(imagemAuxiliar);
        }

        #endregion

    }
}
