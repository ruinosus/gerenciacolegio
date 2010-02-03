using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloSerie.Processos;
using Negocios.ModuloMatricula.Entidades;
using Negocios.ModuloBoletoAtividade.Processos;
using Negocios.ModuloBoletoMensalidade.Processos;

namespace GuiWindowsForms
{
    public partial class telaFinanceiro : Form
    {
        ClasseColetoraFinanceiro classeColetoraFinanceiro = null;

        #region Métodos e Instâncias padrão da tela
        #region SINGLETON DA TELA
        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaFinanceiro telaafinanceiro;

        private static bool IsShown = false;
        #endregion

        #region INSTANCIA TELA FINANCEIRO
        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. Evita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>

        public static telaFinanceiro getInstancia()
        {
            if (telaafinanceiro == null)
            {
                telaafinanceiro = new telaFinanceiro();
            }
            return telaafinanceiro;
        }
        #endregion

        #region CONSTRUTOR
        /// <summary>
        /// Construtor da tela
        /// </summary>

        public telaFinanceiro()
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

        private void ucDesconectarLogin1_EventoDesconectar()
        {
            Program.ultimaTela = 9;
            this.Close();
            telaLogin telalogin = telaLogin.getInstancia();
            telalogin.Show();
        }
        #endregion

        #region  MÉTODO PARA FECHAR A TELA
        /// <summary>
        /// Evento para o fechamento da tela, não fecha de verdade, só a esconde,
        /// garantindo a usabilidade da tela
        /// pelo singleton
        /// </summary>
        /// <param name="sender">Tela</param>
        /// <param name="e">Cancela seu fechamento, permite só que seja ocultada</param>

        private void telaAlunoResponsavel_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IsShown = false;
            this.Hide();

            if (Program.ultimaTela != 16)
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

        #region BUTTON IMPIRMIR
        private void btnImprimir_MouseEnter(object sender, EventArgs e)
        {
            this.btnImprimir.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_impressora_51x53_hover;
        }

        private void btnImprimir_MouseLeave(object sender, EventArgs e)
        {
            this.btnImprimir.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_impressora_51x53;
        }
        #endregion

        #region BUTTON PESQUISAR
        private void btnPesquisar_MouseEnter(object sender, EventArgs e)
        {
            this.btnPesquisar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_busca_73x75_hover;
        }

        private void btnPesquisar_MouseLeave(object sender, EventArgs e)
        {
            this.btnPesquisar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_busca_73x75;
        }
        #endregion

        #region USER CONTROLS - Controle Inferior - Botões de Navegação

        private void ucAluno1_EventoVoltar()
        {
            this.Hide();

            Program.ultimaTela = 6;
            Program.SelecionaForm(Program.ultimaTela);
        }

        #endregion

        #endregion

        /// <summary>
        /// Método de pesquisa 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                #region VALIDA - TXTBUSCA

                if (String.IsNullOrEmpty(txtBusca.Text))
                {
                    errorProviderTela.SetError(txtBusca, "Informe o nome do aluno a pesquisar");
                    txtBusca.Clear();
                    return;
                }
                classeColetoraFinanceiro.aluno = txtBusca.Text;

                #endregion

                #region VALIDA - SERIE

                if (!String.IsNullOrEmpty(cmbSerie.Text))
                {
                    classeColetoraFinanceiro.serie = cmbSerie.Text;
                }

                #endregion

                #region VALIDA - CHECKBOXES MATRICULA E ATIVIDADE

                if (ckbAtividade.Checked == true && ckbMatricula.Checked == true)
                {
                    classeColetoraFinanceiro.tipo = (int)selecaoMatriculaAtividade.Ambos;

                }
                else if (ckbMatricula.Checked == true && ckbAtividade.Checked == false)
                {
                    classeColetoraFinanceiro.tipo = (int)selecaoMatriculaAtividade.Matricula;
                }
                else if (ckbMatricula.Checked == false && ckbAtividade.Checked == true)
                {
                    classeColetoraFinanceiro.tipo = (int)selecaoMatriculaAtividade.Atividade;
                }

                #endregion

                #region VALIDA - CHECKBOXES REGULAR E PENDENTE

                if (ckbAtivo.Checked == true && ckbPendente.Checked == true)
                {
                    classeColetoraFinanceiro.situacao = (int)selecaoPagamentoPendenteAtivo.Ambos;
                }
                else if (ckbAtivo.Checked == true && ckbPendente.Checked == false)
                {
                    classeColetoraFinanceiro.situacao = (int)selecaoPagamentoPendenteAtivo.Ativo;
                }
                else if (ckbAtivo.Checked == false && ckbPendente.Checked == true)
                {
                    classeColetoraFinanceiro.situacao = (int)selecaoPagamentoPendenteAtivo.Pendente;
                }

                #endregion

                #region VALIDA - DEMAIS CAMPOS

                //Verifica se o campo de data foi alterado do original
                if (dateTimePicker1.Value != DateTime.Now && dateTimePicker2.Value != DateTime.Now)
                {
                    classeColetoraFinanceiro.dataInicioPeriodo = dateTimePicker1.Value;
                    classeColetoraFinanceiro.dataFimPeriodo = dateTimePicker2.Value;
                }
                else if (dateTimePicker1.Value != DateTime.Now)
                {
                    classeColetoraFinanceiro.dataInicioPeriodo = dateTimePicker1.Value;
                    classeColetoraFinanceiro.dataFimPeriodo = DateTime.Now;
                }
                else
                {
                    throw new Exception("A data de inicio não pode ser maior que a data de fim");
                }

                //Verifica se o radioButton de desconto esta selecionado ou não
                if (rdbNao.Checked == true)
                {
                    classeColetoraFinanceiro.desconto = (int)selecaoMatriculaDesconto.SemDesconto;
                }
                else
                {
                    classeColetoraFinanceiro.desconto = (int)selecaoMatriculaDesconto.Desconto;
                }


                #endregion
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void telaFinanceiro_Activated(object sender, EventArgs e)
        {
            //Operações responsáveis por carregar o Combo de Série
            cmbSerie.DataSource = null;
            cmbSerie.DataSource = CarregarComboSerie();
            cmbSerie.DisplayMember = "Nome";

            //Operações responsáveis por alimentar o grid principal da tela
            dtgResultado.AutoGenerateColumns = false;
            dtgResultado.DataSource = null;
            dtgResultado.DataSource = CarregarDataGridGeral();
        }

        #region Métodos Auxiliares
        /// <summary>
        /// Método responsável por carregar o combo de série 
        /// </summary>
        /// <returns>Lista de séries ativas</returns>
        private List<Serie> CarregarComboSerie()
        {
            Serie serieObj = new Serie();
            serieObj.Status = (int)Status.Ativo;

            ISerieProcesso serieControlador = SerieProcesso.Instance;
            List<Serie> listSerie = new List<Serie>();

            listSerie = serieControlador.Consultar(serieObj, TipoPesquisa.E);

            return listSerie;
        }

        /// <summary>
        /// Método responsável por filtrar os resultados no grid de acordo com a escolha do usuário
        /// </summary>
        /// <param name="dataInicio">dataInicioPeriodo</param>
        /// <param name="dataFim">dataFimPeriodo</param>
        /// <param name="tipoPagamento">tipoPagamento(Atividade/Mensalidade)</param>
        /// <param name="situacaoAluno">situacaoAluno(Regular/Pendente)</param>
        /// <param name="contemDesconto">contemDesconto(Sim/Nao)</param>
        /// <returns></returns>
        //private List<ClasseAuxiliarFinanceiro> FiltroGeral(DateTime dataInicio, DateTime dataFim, bool tipoPagamento, bool situacaoAluno, bool contemDesconto)
        //{
        //    IEnumerable<ClasseAuxiliarFinanceiro> query = null;
        //    string condicoesWhere = null;

        //    try
        //    {
        //        if (ValidaDatas(dataInicio, dataFim))
        //        {
        //            condicoesWhere = "DataVencimento > dataInicio AND DataVencimento < dataFim"
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Colégio Conhecer - Financeiro");
        //    }
        //}

        /// <summary>
        /// Método para validar a data dentro do período permitido
        /// </summary>
        /// <param name="dataInicio">dataInicioPeriodo</param>
        /// <param name="dataFim">dataFimPeriodo</param>
        /// <returns>Retorna Verdadeiro se aceito e Falso se não aceito</returns>
        private bool ValidaDatas(DateTime dataInicio, DateTime dataFim)
        {
            int? validaData = null;
            bool retornoMetodo = false;

            if (dataInicio != null && dataFim == null && validaData == null)
            {
                dataFim = DateTime.Now;
                validaData = DateTime.Compare(dataInicio, dataFim);
            }
            else if (dataInicio != null && dataFim != null && validaData == null)
            {
                validaData = DateTime.Compare(dataInicio, dataFim);
            }

            if (validaData > 0)
            {
                throw new Exception("A data inicial deve ser inferior a data final");
            }
            else
            {
                retornoMetodo = true;
            }
            return retornoMetodo;
        }

        /// <summary>
        /// Método para carregar o dataGrid com todos os resultados
        /// </summary>
        /// <returns>Lista da classe auxiliar para alimentar o DataGrid Financeiro</returns>
        private List<ClasseAuxiliarFinanceiro> CarregarDataGridGeral()
        {
            List<ClasseAuxiliarFinanceiro> classeAuxiliarFinanceiroList = new List<ClasseAuxiliarFinanceiro>();

            classeAuxiliarFinanceiroList.AddRange(CarregarDataGridFinanceiroAtividade());
            classeAuxiliarFinanceiroList.AddRange(CarregarDataGridFinanceiroMensalidade());

            IEnumerable<ClasseAuxiliarFinanceiro> query = from objFinanceiro in classeAuxiliarFinanceiroList orderby objFinanceiro.aluno, objFinanceiro.dataVencimento select objFinanceiro;

            List<ClasseAuxiliarFinanceiro> classeAuxiliarFinanceiroList2 = new List<ClasseAuxiliarFinanceiro>();

            foreach (ClasseAuxiliarFinanceiro objFinanceiro in query)
            {
                classeAuxiliarFinanceiroList2.Add(objFinanceiro);
            }

            return classeAuxiliarFinanceiroList2;
        }

        /// <summary>
        /// Método para carregar o DataGrid de Boleto Mensalidade
        /// </summary>
        /// <returns>Lista da classe auxiliar para alimentar o financeiro</returns>
        private List<ClasseAuxiliarFinanceiro> CarregarDataGridFinanceiroMensalidade()
        {
            List<ClasseAuxiliarFinanceiro> classeAuxiliarFinanceiroList = new List<ClasseAuxiliarFinanceiro>();

            foreach (BoletoMensalidade b in RetornaListaAtivosMensalidade())
            {
                ClasseAuxiliarFinanceiro classeAuxiliarFinanceiro = new ClasseAuxiliarFinanceiro();

                classeAuxiliarFinanceiro.aluno = b.Matricula.Aluno.Nome;
                if (b.DataPagamento.HasValue == true)
                {
                    classeAuxiliarFinanceiro.dataPagamento = Convert.ToDateTime(b.DataPagamento);
                }
                classeAuxiliarFinanceiro.dataVencimento = b.DataVencimento;
                if (b.Desconto.HasValue == true)
                {
                    classeAuxiliarFinanceiro.desconto = Convert.ToDouble(b.Desconto);
                }
                classeAuxiliarFinanceiro.matriculaId = Convert.ToInt32(b.MatriculaID);
                classeAuxiliarFinanceiro.parcela = b.Parcela;
                classeAuxiliarFinanceiro.serie = b.Matricula.SalaPeriodo.Sala.Serie.Nome;
                classeAuxiliarFinanceiro.valor = Convert.ToDouble(b.Valor);

                classeAuxiliarFinanceiroList.Add(classeAuxiliarFinanceiro);
            }

            return classeAuxiliarFinanceiroList;

        }

        /// <summary>
        /// Método para carregar o DataGrid de Boleto Atividade
        /// </summary>
        /// <returns>Lista da classe auxiliar para alimentar o financeiro</returns>
        private List<ClasseAuxiliarFinanceiro> CarregarDataGridFinanceiroAtividade()
        {
            List<ClasseAuxiliarFinanceiro> classeAuxiliarFinanceiroList = new List<ClasseAuxiliarFinanceiro>();

            foreach (BoletoAtividade b in RetornaListaAtivosAtividade())
            {
                ClasseAuxiliarFinanceiro classeAuxiliarFinanceiro = new ClasseAuxiliarFinanceiro();

                classeAuxiliarFinanceiro.aluno = b.Matricula.Aluno.Nome;
                if (b.DataPagamento.HasValue == true)
                {
                    classeAuxiliarFinanceiro.dataPagamento = Convert.ToDateTime(b.DataPagamento);
                }
                classeAuxiliarFinanceiro.dataVencimento = b.DataVencimento;
                if (b.Desconto.HasValue == true)
                {
                    classeAuxiliarFinanceiro.desconto = Convert.ToDouble(b.Desconto);
                }
                classeAuxiliarFinanceiro.matriculaId = Convert.ToInt32(b.MatriculaID);
                classeAuxiliarFinanceiro.parcela = b.Parcela;
                classeAuxiliarFinanceiro.serie = b.Matricula.SalaPeriodo.Sala.Serie.Nome;
                classeAuxiliarFinanceiro.valor = Convert.ToDouble(b.Valor);

                classeAuxiliarFinanceiroList.Add(classeAuxiliarFinanceiro);
            }

            return classeAuxiliarFinanceiroList;

        }

        /// <summary>
        /// Método responsável por retornar uma lista dos objetos ativos de BoletoAtividade
        /// </summary>
        /// <returns>Lista de Boleto Atividade ativos</returns>
        private List<BoletoAtividade> RetornaListaAtivosAtividade()
        {
            IBoletoAtividadeProcesso boletoAtividadeControlador = BoletoAtividadeProcesso.Instance;

            List<BoletoAtividade> boletoAtividadeList = new List<BoletoAtividade>();
            List<BoletoAtividade> boletoAtividadeList2 = new List<BoletoAtividade>();

            boletoAtividadeList = boletoAtividadeControlador.Consultar();

            IEnumerable<BoletoAtividade> query = from b in boletoAtividadeList where b.Status == 1 select b;

            foreach (BoletoAtividade boleto in query)
            {
                boletoAtividadeList2.Add(boleto);
            }

            return boletoAtividadeList2;
        }

        /// <summary>
        /// Método responsável por retornar uma lista dos objetos ativos de BoletoMensalidade
        /// </summary>
        /// <returns>Lista de Boleto Mensalidade ativos</returns>
        private List<BoletoMensalidade> RetornaListaAtivosMensalidade()
        {
            IBoletoMensalidadeProcesso boletoMensalidadeControlador = BoletoMensalidadeProcesso.Instance;

            List<BoletoMensalidade> boletoMensalidadeList = new List<BoletoMensalidade>();
            List<BoletoMensalidade> boletoMensalidadeList2 = new List<BoletoMensalidade>();

            boletoMensalidadeList = boletoMensalidadeControlador.Consultar();

            IEnumerable<BoletoMensalidade> query = from b in boletoMensalidadeList where b.Status == 1 select b;

            foreach (BoletoMensalidade boleto in query)
            {
                boletoMensalidadeList2.Add(boleto);
            }

            return boletoMensalidadeList2;
        }
        #endregion
    }
}
