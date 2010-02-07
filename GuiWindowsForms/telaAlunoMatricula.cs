using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.ModuloMatricula.Processos;
using Negocios.ModuloSala.Processos;
using Negocios.ModuloSalaPeriodo.Processos;
using Negocios.ModuloDesconto.Processos;
using Negocios.ModuloBasico.VOs;
using Negocios.ModuloMatricula.Constantes;
using Negocios.ModuloBoletoMensalidade.Processos;
using System.Globalization;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloAluno.Processos;
using Negocios.ModuloAtividadeTurma.Processos;
using Negocios.ModuloMatriculaVinculo.Processos;

namespace GuiWindowsForms
{
    public partial class telaAlunoMatricula : Form
    {
        Aluno alunoMatriculaAux = new Aluno();
        Matricula matricula = new Matricula();
        BoletoMensalidade boletoMensalidade = new BoletoMensalidade();

        IMatriculaProcesso matriculaControlador = MatriculaProcesso.Instance;
        ISalaPeriodoProcesso salaPeriodoControlador = null;
        IDescontoProcesso descontoControlador = null;
        IBoletoMensalidadeProcesso boletoMensalidadeControlador = null;


        //#region NOVO BOLETO VINCULO

        //IMatriculaVinculoProcesso processo = MatriculaVinculoProcesso.Instance;
        //MatriculaVinculo mv = new MatriculaVinculo();
        //mv.MatriculaPrincipalID = <ID_DA_MATRICULA_PRINCIPAL>;
        //mv.Status = (int)Status.Ativo;

        //#endregion

        List<SalaAuxiliar> listaSalaAuxiliar = null;
        List<SalaPeriodo> listaSalaPeriodo = null;
        List<Desconto> listaDescontoAux = null;

        Memoria memoria = Memoria.Instance;

        String[] meses = new String[] { "-", "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

        #region SINGLETON DA TELA
        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaAlunoMatricula telaalunomatricula;

        private static bool IsShown = false;
        #endregion

        #region INSTANCIA TELA MATRICULA
        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. Evita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>

        public static telaAlunoMatricula getInstancia()
        {
            if (telaalunomatricula == null)
            {
                telaalunomatricula = new telaAlunoMatricula();
            }
            return telaalunomatricula;
        }
        #endregion

        #region CONSTRUTOR
        /// <summary>
        /// Construtor da tela
        /// </summary>

        public telaAlunoMatricula()
        {
            InitializeComponent();
        }
        #endregion

        #region MÉTODO PARA VERIFICAR USO DA TELA
        /// <summary>
        /// Método para verificar se a tela já esta sendo exibida ou não, 
        /// avita que a tela seja descarregada da memória
        /// </summary>

        /// <summary>
        /// Método para verificar se a tela já esta sendo exibida ou não,
        /// avita que a tela seja descarregada da memória
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

        #region MÉTODO PARA FECHAR A TELA
        /// <summary>
        /// Evento para o fechamento da tela, não fecha de verdade, 
        /// só a esconde, garantindo a usabilidade da tela
        /// pelo singleton
        /// </summary>
        /// <param name="sender">Tela</param>
        /// <param name="e">Cancela seu fechamento, permite só que seja ocultada</param>

        private void telaAlunoMatricula_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IsShown = false;
            this.Hide();

            if (Program.ultimaTela != 4)
            {
                Program.SelecionaForm(Program.ultimaTela);
            }
            else
            {
                Program.ultimaTela = 1;
                Program.SelecionaForm(Program.ultimaTela);
            }
        }
        #endregion

        #region BUTTON MATRICULA 
        private void btnMatriculaAtividade_Click(object sender, EventArgs e)
        {

            if ((!String.IsNullOrEmpty(alunoMatriculaAux.SerieAtual))&&verificaTurmaAtividade()>0)
            {
                this.Hide();
                Program.ultimaTela = 4;
                telaAlunoMatriculaAtividade telaalunomatriculaatividade = telaAlunoMatriculaAtividade.getInstancia();
                telaalunomatriculaatividade.Show();
            }
            else
            {
                MessageBox.Show("O aluno deve estar matriculado em uma série e existir turmas das atividades antes de vincular-se a atividades", "Colégio Conhecer - Matricula");
            }
        }

        private void btnMatriculaAtividade_MouseEnter(object sender, EventArgs e)
        {
            this.btnMatriculaAtividade.BackgroundImage = global::GuiWindowsForms.Properties.Resources.btn_add_atividade_48x48_hover;
            ucMenuInferior1.exibirMensagem("Matricular aluno em uma atividade");
        }

        private void btnMatriculaAtividade_MouseLeave(object sender, EventArgs e)
        {
            this.btnMatriculaAtividade.BackgroundImage = global::GuiWindowsForms.Properties.Resources.btn_add_atividade_48x48;
            ucMenuInferior1.ocultarMensagem();
        }
        #endregion

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

        #region USER CONTROLS - Controle Lateral - Botões de Navegação

        private void uMenuLateral1_EventoAbrirTelaResponsavel()
        {
            //this.Hide();
            //Program.ultimaTela = 7;
            //telaAlunoResponsavel telaalunoresponsavel = telaAlunoResponsavel.getInstancia();
            //telaalunoresponsavel.Show();

            this.Hide();
            Program.ultimaTela = 1;
            telaAlunoResponsavelVinculo tela = telaAlunoResponsavelVinculo.getInstancia();
            tela.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaMedica()
        {
            this.Hide();
            Program.ultimaTela = 1;
            telaAlunoMedicacao telaalunomedicacao = telaAlunoMedicacao.getInstancia();
            telaalunomedicacao.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaMatricula()
        {
            this.Hide();
            Program.ultimaTela = 1;
            telaAlunoMatricula telaalunomatricula = telaAlunoMatricula.getInstancia();
            telaalunomatricula.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaFinanceiro()
        {
            this.Hide();
            Program.ultimaTela = 1;
            telaAlunoFinanceiro telaalunofinanceiro = telaAlunoFinanceiro.getInstancia();
            telaalunofinanceiro.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaDados()
        {
            this.Hide();
            Program.ultimaTela = 1;
            telaAluno telaaluno = telaAluno.getInstancia();
            telaaluno.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaAcademico()
        {
            this.Hide();
            Program.ultimaTela = 1;
            telaAlunoAcademico telaalunoacademico = telaAlunoAcademico.getInstancia();
            telaalunoacademico.Show();
        }

        #endregion

        #region USER CONTROLS - Menu Lateral
        private void uMenuLateral1_Load(object sender, EventArgs e)
        {
            uMenuLateral1.verificaTela(telaalunomatricula);
        }
        #endregion

        #region LOAD
        private void telaAlunoMatricula_Load(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region EVENTO CADASTRAR
        private void ucMenuInferior1_EventoCadastrar()
        {
            matriculaControlador = MatriculaProcesso.Instance;

            matricula = new Matricula();

            try
            {
                #region VALIDA - SERIE

                if (String.IsNullOrEmpty(cmbSerie.Text))
                {
                    errorProviderTela.SetError(cmbSerie, "Informe a série");
                    return;
                }
                int salaPeriodoIdAux = ((SalaAuxiliar)cmbSerie.SelectedItem).IdSalaAux;
                matricula.SalaPeriodoID = salaPeriodoIdAux;
                
                #endregion

                #region VALIDA - DESCONTO

                if (String.IsNullOrEmpty(cmbDesconto.Text))
                {
                    errorProviderTela.SetError(cmbDesconto, "Informe o desconto");
                    return;
                }
                matricula.DescontoID = ((Desconto)cmbDesconto.SelectedItem).ID;

                #endregion

                #region VALIDA - VALOR

                if (String.IsNullOrEmpty(txtValor.Text))
                {
                    errorProviderTela.SetError(txtValor, "Informe o valor");
                    txtValor.Clear();
                    return;
                }

                #endregion

                #region VALIDA - VALOR TOTAL

                if (String.IsNullOrEmpty(txtTotalValor.Text))
                {
                    errorProviderTela.SetError(txtValor, "Informe o valor total");
                    txtTotalValor.Clear();
                    return;
                }
                matricula.Valor = Convert.ToDouble(txtTotalValor.Text);

                #endregion

                #region VALIDA - DIA VENCIMENTO

                if (String.IsNullOrEmpty(cmbVencimento.Text))
                {
                    errorProviderTela.SetError(cmbVencimento, "Informe o vencimento");
                    return;
                }

                matricula.DiaVencimento = Convert.ToInt32(cmbVencimento.Text);

                #endregion

                matricula.DataMatricula = DateTime.Now;
                matricula.Ano = DateTime.Now.Year;
                matricula.NumMatricula = lblNumeroMatricula.Text;
                matricula.Status = 1;
                matricula.AlunoID = alunoMatriculaAux.ID;

                if (verificaSeJaInserido(matricula) == false)
                {
                    matriculaControlador.Incluir(matricula);
                    matriculaControlador.Confirmar();

                    for (int i = 0; i < 12; i++)
                    {
                        boletoMensalidadeControlador = BoletoMensalidadeProcesso.Instance;
                        boletoMensalidade = new BoletoMensalidade();

                        boletoMensalidade.Descricao = "BOLETO";

                        DateTime novoDtParcela = new DateTime(DateTime.Now.Year, 1, Convert.ToInt32(cmbVencimento.Text));

                        boletoMensalidade.DataVencimento = novoDtParcela.AddMonths(i);

                        boletoMensalidade.Status = 1;
                        boletoMensalidade.Desconto = ((Desconto)cmbDesconto.SelectedItem).Percentual;

                        boletoMensalidade.Parcela = meses[novoDtParcela.AddMonths(i).Month];
                        
                        boletoMensalidade.MatriculaID = matricula.ID;
                        boletoMensalidade.DataEmissao = DateTime.Now;
                        boletoMensalidade.Valor = matricula.Valor;

                        boletoMensalidadeControlador.Incluir(boletoMensalidade);
                        boletoMensalidadeControlador.Confirmar();

                    }
                    IAlunoProcesso alunoControlador = AlunoProcesso.Instance;

                    alunoMatriculaAux.SerieAtual = matricula.SalaPeriodo.Sala.Serie.Nome;

                    alunoControlador.Alterar(alunoMatriculaAux);
                    alunoControlador.Confirmar();

                    MessageBox.Show(MatriculaConstantes.MATRICULA_INCLUIDA, "Colégio Conhecer - Inserir Matrícula");

                    memoria.Aluno = alunoMatriculaAux;
                }
                else
                {
                    MessageBox.Show("A Matrícula já existe na base de dados", "Colégio Conhecer - Inserir Matrícula");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            limparTela();
        }
        #endregion

        #region Função para verificar se a matricula já esta cadastrada
        public bool verificaSeJaInserido(Matricula matricula)
        {
            matriculaControlador = MatriculaProcesso.Instance;

            List<Matricula> listaAuxiliar = new List<Matricula>();
            listaAuxiliar = matriculaControlador.Consultar();

            bool testa = false;

            foreach (Matricula b in listaAuxiliar)
            {
                if ((b.AlunoID == matricula.AlunoID) && (b.Ano == matricula.Ano))
                {
                    testa = true;
                }
            }
            return testa;
        }
        #endregion

        #region Evento para limpar os campos da tela
        public void limparTela()
        {
            txtTotalValor.Clear();
            txtValor.Clear();
            if(cmbDesconto.Items.Count>0)
            cmbDesconto.SelectedIndex = 0;
            if (cmbSerie.Items.Count > 0)
            cmbSerie.SelectedIndex = 0;
            if (cmbVencimento.Items.Count > 0)
            cmbVencimento.SelectedIndex = 0;
        }
        #endregion

        #region LIMPAR ERRO PROVIDER
        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void cmbSerie_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void cmbTurno_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void cmbTurma_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void cmbDesconto_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void cmbVencimento_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }
        #endregion

        #region Método para carregar as séries do Ano Corrente no Combo
        private void carregaComboSerie()
        {
            salaPeriodoControlador = SalaPeriodoProcesso.Instance;

            listaSalaPeriodo = new List<SalaPeriodo>();
            listaSalaAuxiliar = new List<SalaAuxiliar>();

            SalaPeriodo sl = new SalaPeriodo();
            sl.Status = (int)Status.Ativo;


            listaSalaPeriodo = salaPeriodoControlador.Consultar(sl, TipoPesquisa.E);

            foreach (SalaPeriodo a in listaSalaPeriodo)
            {
                SalaAuxiliar classeSalaAux = new SalaAuxiliar();

                if (a.Ano == DateTime.Now.Year)
                {
                    classeSalaAux.IdSalaAux = a.ID;
                    classeSalaAux.SerieAux = a.Sala.Serie.Nome;
                    classeSalaAux.TurmaAux = a.Sala.Turma.Nome;
                    classeSalaAux.TurnoAux = a.Sala.Turno.Nome;

                    listaSalaAuxiliar.Add(classeSalaAux);
                }
            }
        }
        #endregion

        #region Evento para alimentar a caixa de valor com o valor da Série selecionada
        private void cmbSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            SalaAuxiliar salaAuxiliarAux = new SalaAuxiliar();
            SalaPeriodo salaPeriodoAux = new SalaPeriodo();

            salaAuxiliarAux.IdSalaAux = ((SalaAuxiliar)cmbSerie.SelectedItem).IdSalaAux;
            salaPeriodoAux.ID = salaAuxiliarAux.IdSalaAux;
            salaPeriodoAux = salaPeriodoControlador.Consultar(salaPeriodoAux, Negocios.ModuloBasico.Enums.TipoPesquisa.E)[0];
            txtValor.Text = salaPeriodoAux.Sala.Valor.ToString();
        }
        #endregion

        #region Função para carregar o valor total no campo
        public void carregarValorTotal()
        {
            double valorAux = Convert.ToDouble(txtValor.Text);
            double descontoAux = ((Desconto)cmbDesconto.SelectedItem).Percentual;
            double resultado = valorAux - (valorAux * descontoAux/100);

            txtTotalValor.Text = resultado.ToString();
        }
        #endregion

        private void geraNumeroMatricula(int id)
        {
            if(id>0 && id<10)
                lblNumeroMatricula.Text = DateTime.Now.Year.ToString() + ".000" + id.ToString();
            if (id > 9 && id < 100)
                lblNumeroMatricula.Text = DateTime.Now.Year.ToString() + ".00" + id.ToString();
            if (id > 99 && id < 1000)
                lblNumeroMatricula.Text = DateTime.Now.Year.ToString() + ".0" + id.ToString();
            if (id > 999 && id < 10000)
                lblNumeroMatricula.Text = DateTime.Now.Year.ToString() + "." + id.ToString();
        }

        private void cmbDesconto_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarValorTotal();
        }

        private void telaAlunoMatricula_Activated(object sender, EventArgs e)
        {
        
            uMenuLateral1.verificaTela(telaalunomatricula);
            uMenuImagem1.ocultarBotaoAdicionarImagem();

            if (memoria.Aluno != null)
            {
                uMenuImagem1.carregaAluno(memoria.Aluno);
                alunoMatriculaAux = memoria.Aluno;
                geraNumeroMatricula(memoria.Aluno.ID);

            }
            else
            {
                limparTela();
            }

            uMenuImagem1.ocultarBotaoAdicionarImagem();

            descontoControlador = DescontoProcesso.Instance;
            carregaComboSerie();

            cmbSerie.DataSource = listaSalaAuxiliar;

            Desconto d = new Desconto();
            d.Status = (int)Status.Ativo;

            listaDescontoAux = new List<Desconto>();

            listaDescontoAux = descontoControlador.Consultar(d, TipoPesquisa.E);
            cmbDesconto.DataSource = listaDescontoAux;
            cmbDesconto.DisplayMember = "Descricao";

            carregarValorTotal();
        }

        private void ucDesconectarLogin1_EventoDesconectar()
        {
            Program.ultimaTela = 9;
            this.Close();
            telaLogin telalogin = telaLogin.getInstancia();
            telalogin.Show();
        }

        private int verificaTurmaAtividade()
        {
            int aux = 0;
            AtividadeTurma atvTurmaAux = new AtividadeTurma();
            IAtividadeTurmaProcesso atvTurmaControladorAux = AtividadeTurmaProcesso.Instance;

            atvTurmaAux.Status = (int)Status.Ativo;

            List<AtividadeTurma> listaAtvTurmaAux = new List<AtividadeTurma>();
            listaAtvTurmaAux = atvTurmaControladorAux.Consultar(atvTurmaAux, TipoPesquisa.E);

            if (listaAtvTurmaAux.Count > 0)
            {
                aux = listaAtvTurmaAux.Count;
            }
            return aux;
        }

        private void btnVincularAluno_MouseEnter(object sender, EventArgs e)
        {
            ucMenuInferior1.exibirMensagem("Vincular aluno a um outro aluno matriculado");
        }

        private void btnVincularAluno_MouseLeave(object sender, EventArgs e)
        {
            ucMenuInferior1.ocultarMensagem();
        }

        private void btnVincularAluno_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 4;
            telaAlunoMatriculaVinculo telaalunomatriculavinculo = telaAlunoMatriculaVinculo.getInstancia();
            Memoria.Instance.StatusTelaAlunoMatriculaVinculo = OperacoesDaTela.AbrirTela;
            telaalunomatriculavinculo.Show();
        }
    }

    #region CLASSE AUXILIAR PARA USO PARA EXIBIR A SALA

    public class SalaAuxiliar
    {
        string serieAux;

        public string SerieAux
        {
            get { return serieAux; }
            set { serieAux = value; }
        }
        string turmaAux;

        public string TurmaAux
        {
            get { return turmaAux; }
            set { turmaAux = value; }
        }
        string turnoAux;

        public string TurnoAux
        {
            get { return turnoAux; }
            set { turnoAux = value; }
        }

        int idSalaAux;

        public int IdSalaAux
        {
            get { return idSalaAux; }
            set { idSalaAux = value; }
        }

        public override string ToString()
        {
            return serieAux + "-" + turmaAux + "-" + turnoAux;
        }
    }

    #endregion
}
