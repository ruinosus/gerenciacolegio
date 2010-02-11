using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Negocios.ModuloAtividadeTurma.Processos;
using Negocios.ModuloFuncionario.Processos;
using Negocios.ModuloAtividade.Processos;
using Negocios.ModuloAtividadeTurma.Constantes;
using Negocios.ModuloBasico.Enums;

namespace GuiWindowsForms
{
    public partial class telaConfiguracoesAtividadeTurma : Form
    {
        // Declarações em uso ao longo da tela

        #region DECLARAÇÕES, COLEÇÕES, VARIÁVEIS E CONSTANTES

        //Variável auxiliar para verificar a abertura da tela de seleção de foto
        int verificaTelaImagem = 0;

        //Variável para verificar qual o estado da tela para habilitação e seleção
        int verificaEstadoTela = 0;

        //Variável para identificar a linha selecionada no grid
        int linhaSelecionadaGrid = -1;

        // atividade - para cadastro, alteração e exclusão das atividades
        Atividade atividade = null;
        AtividadeTurma atividadeTurma = null;
        Funcionario funcionario = null;

        //Controlador do repositório de atividades, atividade turma e funcionário
        IAtividadeTurmaProcesso atividadeTurmaControlador = null;
        IFuncionarioProcesso funcionarioControlador = null;
        IAtividadeProcesso atividadeControlador = null;

        //Lista auxiliar para operar a alteração, exclusão e seleção das atividades no Grid
        List<AtividadeTurma> listaAtividadeTurma = new List<AtividadeTurma>();

        #endregion

        // Métodos de controle da tela, user controls e form load

        #region MÉTODOS INICIAS DA TELA

        #region SINGLETON DA TELA
        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaConfiguracoesAtividadeTurma telaConfiguracoesAtividadeTurmas;

        private static bool IsShown = false;
        #endregion

        #region INSTANCIA TELA CONFIGURACOES ATIVIDADES
        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. 
        /// Evita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>

        public static telaConfiguracoesAtividadeTurma getInstancia()
        {
            if (telaConfiguracoesAtividadeTurmas == null)
            {
                telaConfiguracoesAtividadeTurmas = new telaConfiguracoesAtividadeTurma();
            }
            return telaConfiguracoesAtividadeTurmas;
        }
        #endregion

        #region CONSTRUTOR
        /// <summary>
        /// Construtor da tela
        /// </summary>

        public telaConfiguracoesAtividadeTurma()
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

        private void ucDesconectarLogin1_EventoDesconectar()
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

        private void telaConfiguracoesAtividade_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IsShown = false;
            this.Hide();
            Program.SelecionaForm(Program.ultimaTela);
        }
        #endregion

        #endregion

        #region USER CONTROLS

        private void ucMenuInferior1_EventoVoltar()
        {
            this.Hide();


            Program.ultimaTela = 11;
            Program.SelecionaForm(Program.ultimaTela);

            verificaEstadoTela = (int)OperacoesDaTela.VoltarTela;

            controladorPaisagemTela(verificaEstadoTela);
        }

        #endregion

        #region LOAD

        private void telaConfiguracoesAtividadeTurma_Activated(object sender, EventArgs e)
        {
            verificaEstadoTela = (int)OperacoesDaTela.AbrirTela;

            controladorPaisagemTela(verificaEstadoTela);

            carregaDataGrid1();
            carregarComboFuncionario();
            carregarComboAtividade();
        }

        #endregion

        /* Métodos operacionais de seleção dos botões, atribuição, cadastro e afins
         * bem como métodos complementares operacionais para o controle das atividades
         * da tela
         * */

        #region BOTÕES DE OPERAÇÃO PARA CADASTRO, ALTERAÇÃO, EXCLUSÃO E CONFIRMAR TRANSAÇÕES

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir a turma ?", "Colégio Conhecer - Excluir Atividade - Turma", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                if (linhaSelecionadaGrid != -1)
                {
                    atividadeTurmaControlador.Excluir(listaAtividadeTurma[linhaSelecionadaGrid]);
                    atividadeTurmaControlador.Confirmar();
                    carregaDataGrid1();
                    linhaSelecionadaGrid = -1;
                }
                else
                {
                    MessageBox.Show("Selecione uma opção na tabela abaixo para exclusão, então pressione excluir.", "Colégio Conhecer - Excluir Atividade - Turma");
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            verificaEstadoTela = (int)OperacoesDaTela.Incluir;

            verificaTelaImagem = 1;
            controladorPaisagemTela(verificaEstadoTela);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            verificaEstadoTela = (int)OperacoesDaTela.Alterar;

            controladorPaisagemTela(verificaEstadoTela);
        }

        private void ucMenuInferior1_EventoCadastrar()
        {
            if (verificaEstadoTela == (int)OperacoesDaTela.Alterar)
            {
                #region ALTERAR ATIVIDADE

                //Controladores e objetos para operação da alteração
                atividadeControlador = AtividadeProcesso.Instance;
                atividadeTurmaControlador = AtividadeTurmaProcesso.Instance;
                funcionarioControlador = FuncionarioProcesso.Instance;

                atividade = new Atividade();
                funcionario = new Funcionario();
                atividadeTurma = new AtividadeTurma();

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

                    atividadeTurma.Status = (int)Status.Ativo;

                    if (!atividadeTurma.HoraInicio.Equals(atividadeTurma.HoraFim))
                    {

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
                    else
                    {
                        MessageBox.Show("O horário de inicio e fim da atividade não podem ser iguais", "Colégio Conhecer");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                carregaDataGrid1();
                verificaEstadoTela = (int)OperacoesDaTela.AbrirTela;

                controladorPaisagemTela(verificaEstadoTela);

                #endregion
            }
            else if (verificaEstadoTela == (int)OperacoesDaTela.Incluir)
            {
                #region ADICIONAR ATIVIDADE

                //Controladores e objetos para operação da alteração
                atividadeControlador = AtividadeProcesso.Instance;
                atividadeTurmaControlador = AtividadeTurmaProcesso.Instance;
                funcionarioControlador = FuncionarioProcesso.Instance;

                atividade = new Atividade();
                funcionario = new Funcionario();
                atividadeTurma = new AtividadeTurma();

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

                    atividadeTurma.HoraInicio = dtpHorarioInicio.Value.ToString();
                    atividadeTurma.HoraFim = dtpHorarioFim.Value.ToString();

                    atividadeTurma.Status = (int)Status.Ativo;

                    if (!atividadeTurma.HoraInicio.Equals(atividadeTurma.HoraFim))
                    {

                        if (verificaSeJaExistenteBD(atividadeTurma) == false)
                        {
                            atividadeTurma.Status = (int)Status.Ativo;
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
                    else
                    {
                        MessageBox.Show("O horário de inicio e fim da atividade não podem ser iguais", "Colégio Conhecer");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                carregaDataGrid1();
                verificaEstadoTela = (int)OperacoesDaTela.AbrirTela;

                controladorPaisagemTela(verificaEstadoTela);

                #endregion
            }
        }

        #endregion

        #region MÉTODOS AUXILIARES

        /// <summary>
        /// Método para controle de operação na tela
        /// </summary>
        /// <param name="operacao">operacao (Enum que identifica de onde vem o chamado)</param>
        /// <param name="opcao">Opção que identifica se a tela de imagem foi chamada</param>
        private void controladorPaisagemTela(int operacao)
        {
            if (operacao == (int)OperacoesDaTela.AbrirTela)
            {
                limparTela();

                DesabilitarTela();
                ucMenuInferior1.BotaoCadastrar.Enabled = false;
                btnAdicionar.Enabled = true;
                btnExcluir.Enabled = true;
                btnAlterar.Enabled = true;
                dataGridView1.Enabled = true;
            }
            else if (operacao == (int)OperacoesDaTela.Incluir)
            {
                limparTela();

                HabilitarTela();
                ucMenuInferior1.BotaoCadastrar.Enabled = true;
                dataGridView1.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            else if (operacao == (int)OperacoesDaTela.Alterar)
            {
                HabilitarTela();
                ucMenuInferior1.BotaoCadastrar.Enabled = true;
                dataGridView1.Enabled = false;
                btnAdicionar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            else if (operacao == (int)OperacoesDaTela.Excluir)
            {

            }
            else if (operacao == (int)OperacoesDaTela.VoltarTela)
            {
                DesabilitarTela();
                ucMenuInferior1.BotaoCadastrar.Enabled = false;
                dataGridView1.Enabled = false;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnAdicionar.Enabled = true;
                verificaTelaImagem = 0;
            }

        }

        /// <summary>
        /// Método para limpeza da tela identificando se a tela de Imagem foi chamada
        /// </summary>
        /// <param name="opcao"></param>
        private void limparTela()
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

        /// <summary>
        /// Método para habilitar campos da tela 
        /// </summary>
        /// <param name="opcao"></param>
        private void HabilitarTela()
        {
            cmbAtividadeTurma.Enabled = true;
            cmbFuncionario.Enabled = true;
            txtTurma.Enabled = true;
            txtValor.Enabled = true;
            dtpHorarioFim.Enabled = true;
            dtpHorarioInicio.Enabled = true;
            ckbDomingo.Enabled = true;
            ckbQuarta.Enabled = true;
            ckbQuinta.Enabled = true;
            ckbSabado.Enabled = true;
            ckbSegunda.Enabled = true;
            ckbSexta.Enabled = true;
            ckbTerca.Enabled = true;
        }

        /// <summary>
        /// Método para desabilitar campos da tela 
        /// </summary>
        /// <param name="opcao"></param>
        private void DesabilitarTela()
        {
            cmbAtividadeTurma.Enabled = false;
            cmbFuncionario.Enabled = false;
            txtTurma.Enabled = false;
            txtValor.Enabled = false;
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

        /// <summary>
        /// Método que recebe uma atividade e verifica se esta já esta cadastrada na base de dados
        /// </summary>
        /// <param name="atividade">Objeto do tipo Atividade</param>
        /// <returns>Booleano onde se verdadeiro já existe cadastro e se falso não</returns>
        public bool verificaSeJaExistenteBD(AtividadeTurma atividadeTurma)
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

        /// <summary>
        /// Evento para bloquear o campo somente para números
        /// </summary>
        /// <param name="sender">Controle da tela</param>
        /// <param name="e">Evento (KeyPress - Tecla)</param>
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Método para alimentar o grid com todas as atividades ativas cadastradas no banco de dados
        /// </summary>
        private void carregaDataGrid1()
        {
            AtividadeTurma atividadeTurmaAux = new AtividadeTurma();
            atividadeTurmaAux.Status = (int)Status.Ativo;

            atividadeTurmaControlador = AtividadeTurmaProcesso.Instance;

            List<classeAuxiliarAtividadeTurma2> listaAtividadeTurmaAuxiliar = new List<classeAuxiliarAtividadeTurma2>();

            listaAtividadeTurma = atividadeTurmaControlador.Consultar(atividadeTurmaAux, TipoPesquisa.E);

            foreach (AtividadeTurma a in listaAtividadeTurma)
            {
                classeAuxiliarAtividadeTurma2 classeAtvTurma = new classeAuxiliarAtividadeTurma2();

                classeAtvTurma.ID = a.ID;
                classeAtvTurma.AtividadeAuxTurma2 = a.Atividade.Nome;
                classeAtvTurma.TurmaAuxTurma2 = a.Turma;
                classeAtvTurma.FuncionarioAuxTurma2 = a.Funcionario.Nome;
                classeAtvTurma.HoraInicioAuxTurma2 = a.HoraInicio;
                classeAtvTurma.HoraFimAuxTurma2 = a.HoraFim;
                classeAtvTurma.ValorAuxTurma2 = a.Valor.ToString();
                classeAtvTurma.SegundaAuxTurma2 = Convert.ToBoolean(a.Segunda);
                classeAtvTurma.TercaAuxTurma2 = Convert.ToBoolean(a.Terca);
                classeAtvTurma.QuartaAuxTurma2 = Convert.ToBoolean(a.Quarta);
                classeAtvTurma.QuintaAuxTurma2 = Convert.ToBoolean(a.Quinta);
                classeAtvTurma.SextaAuxTurma2 = Convert.ToBoolean(a.Sexta);
                classeAtvTurma.SabadoAuxTurma2 = Convert.ToBoolean(a.Sabado);
                classeAtvTurma.DomingoAuxTurma2 = Convert.ToBoolean(a.Domingo);

                listaAtividadeTurmaAuxiliar.Add(classeAtvTurma);
            }

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaAtividadeTurmaAuxiliar;
        }

        #region Eventos de Operação do Grid

        /// <summary>
        /// Evento para operar os datagrids com a seleção e alimentação dos dados na tela
        /// </summary>
        /// <param name="sender">Form que envia (DataGrid)</param>
        /// <param name="e">Evento em uso (Seleção da linha do grid)</param>
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            if (linhaSelecionadaGrid >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;

                cmbAtividadeTurma.Text = listaAtividadeTurma[linhaSelecionadaGrid].Atividade.Nome;
                cmbFuncionario.Text = listaAtividadeTurma[linhaSelecionadaGrid].Funcionario.Nome;
                txtTurma.Text = listaAtividadeTurma[linhaSelecionadaGrid].Turma;
                txtValor.Text = listaAtividadeTurma[linhaSelecionadaGrid].Valor.ToString();
                dtpHorarioInicio.Value = Convert.ToDateTime(listaAtividadeTurma[linhaSelecionadaGrid].HoraInicio.ToString());
                dtpHorarioFim.Value = Convert.ToDateTime(listaAtividadeTurma[linhaSelecionadaGrid].HoraFim.ToString());

                if (listaAtividadeTurma[linhaSelecionadaGrid].Segunda == 0)
                {
                    ckbSegunda.Checked = true;
                }
                else
                {
                    ckbSegunda.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Terca == 0)
                {
                    ckbTerca.Checked = true;
                }
                else
                {
                    ckbTerca.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Quarta == 0)
                {
                    ckbQuarta.Checked = true;
                }
                else
                {
                    ckbQuarta.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Quinta == 0)
                {
                    ckbQuinta.Checked = true;
                }
                else
                {
                    ckbQuinta.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Sexta == 0)
                {
                    ckbSexta.Checked = true;
                }
                else
                {
                    ckbSexta.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Sabado == 0)
                {
                    ckbSabado.Checked = true;
                }
                else
                {
                    ckbSabado.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Domingo == 0)
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

        /// <summary>
        /// Evento para operar os datagrids com a seleção e alimentação dos dados na tela
        /// </summary>
        /// <param name="sender">Form que envia (DataGrid)</param>
        /// <param name="e">Evento em uso (Seleção da linha do grid)</param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            if (linhaSelecionadaGrid >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;

                cmbAtividadeTurma.Text = listaAtividadeTurma[linhaSelecionadaGrid].Atividade.Nome;
                cmbFuncionario.Text = listaAtividadeTurma[linhaSelecionadaGrid].Funcionario.Nome;
                txtTurma.Text = listaAtividadeTurma[linhaSelecionadaGrid].Turma;
                txtValor.Text = listaAtividadeTurma[linhaSelecionadaGrid].Valor.ToString();
                dtpHorarioInicio.Value = Convert.ToDateTime(listaAtividadeTurma[linhaSelecionadaGrid].HoraInicio.ToString());
                dtpHorarioFim.Value = Convert.ToDateTime(listaAtividadeTurma[linhaSelecionadaGrid].HoraFim.ToString());

                if (listaAtividadeTurma[linhaSelecionadaGrid].Segunda == 0)
                {
                    ckbSegunda.Checked = true;
                }
                else
                {
                    ckbSegunda.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Terca == 0)
                {
                    ckbTerca.Checked = true;
                }
                else
                {
                    ckbTerca.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Quarta == 0)
                {
                    ckbQuarta.Checked = true;
                }
                else
                {
                    ckbQuarta.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Quinta == 0)
                {
                    ckbQuinta.Checked = true;
                }
                else
                {
                    ckbQuinta.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Sexta == 0)
                {
                    ckbSexta.Checked = true;
                }
                else
                {
                    ckbSexta.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Sabado == 0)
                {
                    ckbSabado.Checked = true;
                }
                else
                {
                    ckbSabado.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Domingo == 0)
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

        /// <summary>
        /// Evento para operar os datagrids com a seleção e alimentação dos dados na tela
        /// </summary>
        /// <param name="sender">Form que envia (DataGrid)</param>
        /// <param name="e">Evento em uso (Seleção da linha do grid)</param>
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            if (linhaSelecionadaGrid >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;

                cmbAtividadeTurma.Text = listaAtividadeTurma[linhaSelecionadaGrid].Atividade.Nome;
                cmbFuncionario.Text = listaAtividadeTurma[linhaSelecionadaGrid].Funcionario.Nome;
                txtTurma.Text = listaAtividadeTurma[linhaSelecionadaGrid].Turma;
                txtValor.Text = listaAtividadeTurma[linhaSelecionadaGrid].Valor.ToString();
                dtpHorarioInicio.Value = Convert.ToDateTime(listaAtividadeTurma[linhaSelecionadaGrid].HoraInicio.ToString());
                dtpHorarioFim.Value = Convert.ToDateTime(listaAtividadeTurma[linhaSelecionadaGrid].HoraFim.ToString());

                if (listaAtividadeTurma[linhaSelecionadaGrid].Segunda == 0)
                {
                    ckbSegunda.Checked = true;
                }
                else
                {
                    ckbSegunda.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Terca == 0)
                {
                    ckbTerca.Checked = true;
                }
                else
                {
                    ckbTerca.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Quarta == 0)
                {
                    ckbQuarta.Checked = true;
                }
                else
                {
                    ckbQuarta.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Quinta == 0)
                {
                    ckbQuinta.Checked = true;
                }
                else
                {
                    ckbQuinta.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Sexta == 0)
                {
                    ckbSexta.Checked = true;
                }
                else
                {
                    ckbSexta.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Sabado == 0)
                {
                    ckbSabado.Checked = true;
                }
                else
                {
                    ckbSabado.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Domingo == 0)
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

        /// <summary>
        /// Evento para operar os datagrids com a seleção e alimentação dos dados na tela
        /// </summary>
        /// <param name="sender">Form que envia (DataGrid)</param>
        /// <param name="e">Evento em uso (Seleção da linha do grid)</param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            if (linhaSelecionadaGrid >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;

                cmbAtividadeTurma.Text = listaAtividadeTurma[linhaSelecionadaGrid].Atividade.Nome;
                cmbFuncionario.Text = listaAtividadeTurma[linhaSelecionadaGrid].Funcionario.Nome;
                txtTurma.Text = listaAtividadeTurma[linhaSelecionadaGrid].Turma;
                txtValor.Text = listaAtividadeTurma[linhaSelecionadaGrid].Valor.ToString();
                dtpHorarioInicio.Value = Convert.ToDateTime(listaAtividadeTurma[linhaSelecionadaGrid].HoraInicio.ToString());
                dtpHorarioFim.Value = Convert.ToDateTime(listaAtividadeTurma[linhaSelecionadaGrid].HoraFim.ToString());

                if (listaAtividadeTurma[linhaSelecionadaGrid].Segunda == 0)
                {
                    ckbSegunda.Checked = true;
                }
                else
                {
                    ckbSegunda.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Terca == 0)
                {
                    ckbTerca.Checked = true;
                }
                else
                {
                    ckbTerca.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Quarta == 0)
                {
                    ckbQuarta.Checked = true;
                }
                else
                {
                    ckbQuarta.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Quinta == 0)
                {
                    ckbQuinta.Checked = true;
                }
                else
                {
                    ckbQuinta.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Sexta == 0)
                {
                    ckbSexta.Checked = true;
                }
                else
                {
                    ckbSexta.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Sabado == 0)
                {
                    ckbSabado.Checked = true;
                }
                else
                {
                    ckbSabado.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Domingo == 0)
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

        /// <summary>
        /// Evento para operar os datagrids com a seleção e alimentação dos dados na tela
        /// </summary>
        /// <param name="sender">Form que envia (DataGrid)</param>
        /// <param name="e">Evento em uso (Seleção da linha do grid)</param>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            if (linhaSelecionadaGrid >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;

                cmbAtividadeTurma.Text = listaAtividadeTurma[linhaSelecionadaGrid].Atividade.Nome;
                cmbFuncionario.Text = listaAtividadeTurma[linhaSelecionadaGrid].Funcionario.Nome;
                txtTurma.Text = listaAtividadeTurma[linhaSelecionadaGrid].Turma;
                txtValor.Text = listaAtividadeTurma[linhaSelecionadaGrid].Valor.ToString();
                dtpHorarioInicio.Value = Convert.ToDateTime(listaAtividadeTurma[linhaSelecionadaGrid].HoraInicio.ToString());
                dtpHorarioFim.Value = Convert.ToDateTime(listaAtividadeTurma[linhaSelecionadaGrid].HoraFim.ToString());

                if (listaAtividadeTurma[linhaSelecionadaGrid].Segunda == 0)
                {
                    ckbSegunda.Checked = true;
                }
                else
                {
                    ckbSegunda.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Terca == 0)
                {
                    ckbTerca.Checked = true;
                }
                else
                {
                    ckbTerca.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Quarta == 0)
                {
                    ckbQuarta.Checked = true;
                }
                else
                {
                    ckbQuarta.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Quinta == 0)
                {
                    ckbQuinta.Checked = true;
                }
                else
                {
                    ckbQuinta.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Sexta == 0)
                {
                    ckbSexta.Checked = true;
                }
                else
                {
                    ckbSexta.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Sabado == 0)
                {
                    ckbSabado.Checked = true;
                }
                else
                {
                    ckbSabado.Checked = false;
                }
                if (listaAtividadeTurma[linhaSelecionadaGrid].Domingo == 0)
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

        // Tratamentos de erros na tela de campos obrigatórios, hints e carga dos comboBoxes

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

        private void btnAlterar_MouseEnter(object sender, EventArgs e)
        {
            ucMenuInferior1.exibirMensagem("Alterar uma atividade");
        }

        private void btnAlterar_MouseLeave(object sender, EventArgs e)
        {
            ucMenuInferior1.ocultarMensagem();
        }

        private void btnAdicionarImagem_MouseEnter(object sender, EventArgs e)
        {
            ucMenuInferior1.exibirMensagem("Inserir uma imagem para a atividade");
        }

        private void btnAdicionarImagem_MouseLeave(object sender, EventArgs e)
        {
            ucMenuInferior1.ocultarMensagem();
        }

        #endregion

        #region LIMPAR ERRO PROVIDER

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

        #region Métodos para carga dos comboBoxes

        private void carregarComboFuncionario()
        {
            Funcionario carregarFuncionario = new Funcionario();
            funcionarioControlador = FuncionarioProcesso.Instance;

            carregarFuncionario.Status = (int)Status.Ativo;

            List<Funcionario> listaFuncionarioCmb = new List<Funcionario>();
            List<Funcionario> listaFuncionarioCmbAuxiliar = new List<Funcionario>();

            listaFuncionarioCmb = funcionarioControlador.Consultar();

            foreach (Funcionario f in listaFuncionarioCmb)
            {
                if (f.Status == (int)Status.Ativo)
                {
                    listaFuncionarioCmbAuxiliar.Add(f);
                }
            }

            cmbFuncionario.DataSource = null;
            cmbFuncionario.DataSource = listaFuncionarioCmbAuxiliar;
            cmbFuncionario.DisplayMember = "Nome";
        }

        private void carregarComboAtividade()
        {
            Atividade carregarComboAtividade = new Atividade();
            atividadeControlador = AtividadeProcesso.Instance;

            carregarComboAtividade.Status = (int)Status.Ativo;

            List<Atividade> listaAtividadeCmb = new List<Atividade>();
            listaAtividadeCmb = atividadeControlador.Consultar(carregarComboAtividade, TipoPesquisa.E);
            cmbAtividadeTurma.DataSource = null;
            cmbAtividadeTurma.DataSource = listaAtividadeCmb;
            cmbAtividadeTurma.DisplayMember = "Nome";
        }

        #endregion
    }

    #region CLASSE AUXILIAR
    public class classeAuxiliarAtividadeTurma2
    {
        public int? ID { get; set; }

        string atividadeAuxTurma2;

        public string AtividadeAuxTurma2
        {
            get { return atividadeAuxTurma2; }
            set { atividadeAuxTurma2 = value; }
        }
        string funcionarioAuxTurma2;

        public string FuncionarioAuxTurma2
        {
            get { return funcionarioAuxTurma2; }
            set { funcionarioAuxTurma2 = value; }
        }
        string turmaAuxTurma2;

        public string TurmaAuxTurma2
        {
            get { return turmaAuxTurma2; }
            set { turmaAuxTurma2 = value; }
        }
        string valorAuxTurma2;

        public string ValorAuxTurma2
        {
            get { return valorAuxTurma2; }
            set { valorAuxTurma2 = value; }
        }
        string horaFimAuxTurma2;

        public string HoraFimAuxTurma2
        {
            get { return horaFimAuxTurma2; }
            set { horaFimAuxTurma2 = value; }
        }
        string horaInicioAuxTurma2;

        public string HoraInicioAuxTurma2
        {
            get { return horaInicioAuxTurma2; }
            set { horaInicioAuxTurma2 = value; }
        }
        bool segundaAuxTurma2;

        public bool SegundaAuxTurma2
        {
            get { return segundaAuxTurma2; }
            set { segundaAuxTurma2 = value; }
        }
        bool tercaAuxTurma2;

        public bool TercaAuxTurma2
        {
            get { return tercaAuxTurma2; }
            set { tercaAuxTurma2 = value; }
        }
        bool quartaAuxTurma2;

        public bool QuartaAuxTurma2
        {
            get { return quartaAuxTurma2; }
            set { quartaAuxTurma2 = value; }
        }
        bool quintaAuxTurma2;

        public bool QuintaAuxTurma2
        {
            get { return quintaAuxTurma2; }
            set { quintaAuxTurma2 = value; }
        }
        bool sextaAuxTurma2;

        public bool SextaAuxTurma2
        {
            get { return sextaAuxTurma2; }
            set { sextaAuxTurma2 = value; }
        }
        bool sabadoAuxTurma2;

        public bool SabadoAuxTurma2
        {
            get { return sabadoAuxTurma2; }
            set { sabadoAuxTurma2 = value; }
        }
        bool domingoAuxTurma2;

        public bool DomingoAuxTurma2
        {
            get { return domingoAuxTurma2; }
            set { domingoAuxTurma2 = value; }
        }
    #endregion
    }
}
