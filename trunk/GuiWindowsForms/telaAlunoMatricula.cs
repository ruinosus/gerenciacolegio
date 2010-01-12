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

namespace GuiWindowsForms
{
    public partial class telaAlunoMatricula : Form
    {
        Matricula matricula = new Matricula();

        IMatriculaProcesso matriculaControlador = MatriculaProcesso.Instance;
        ISalaPeriodoProcesso salaPeriodoControlador = null;
        IDescontoProcesso descontoControlador = null; 

        List<SalaAuxiliar> listaSalaAuxiliar = null;
        List<SalaPeriodo> listaSalaPeriodo = null;
        List<Desconto> listaDescontoAux = null;

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
                Program.ultimaTela = 7;
                Program.SelecionaForm(Program.ultimaTela);
            }
        }
        #endregion

        #region BUTTON MATRICULA 
        private void btnMatriculaAtividade_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 4;
            telaAlunoMatriculaAtividade telaalunomatriculaatividade = telaAlunoMatriculaAtividade.getInstancia();
            telaalunomatriculaatividade.Show();
        }

        private void btnMatriculaAtividade_MouseEnter(object sender, EventArgs e)
        {
            this.btnMatriculaAtividade.BackgroundImage = global::GuiWindowsForms.Properties.Resources.btn_add_atividade_48x48_hover;
            //lblInfoControles.Text = "Matricular aluno em uma atividade.";
            //lblInfoControles.Visible = true;
        }

        private void btnMatriculaAtividade_MouseLeave(object sender, EventArgs e)
        {
            this.btnMatriculaAtividade.BackgroundImage = global::GuiWindowsForms.Properties.Resources.btn_add_atividade_48x48;
            //lblInfoControles.Visible = false;
        }
        #endregion

        #region USER CONTROLS - Controle Inferior - Botões de Navegação

        private void ucAluno1_EventoVoltar()
        {
            this.Hide();

            if (Program.ultimaTela == 7)
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
            this.Hide();
            Program.ultimaTela = 7;
            telaAlunoResponsavel telaalunoresponsavel = telaAlunoResponsavel.getInstancia();
            telaalunoresponsavel.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaMedica()
        {
            this.Hide();
            Program.ultimaTela = 7;
            telaAlunoMedicacao telaalunomedicacao = telaAlunoMedicacao.getInstancia();
            telaalunomedicacao.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaMatricula()
        {
            this.Hide();
            Program.ultimaTela = 7;
            telaAlunoMatricula telaalunomatricula = telaAlunoMatricula.getInstancia();
            telaalunomatricula.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaFinanceiro()
        {
            this.Hide();
            Program.ultimaTela = 7;
            telaAlunoFinanceiro telaalunofinanceiro = telaAlunoFinanceiro.getInstancia();
            telaalunofinanceiro.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaDados()
        {
            this.Hide();
            Program.ultimaTela = 7;
            telaAluno telaaluno = telaAluno.getInstancia();
            telaaluno.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaAcademico()
        {
            this.Hide();
            Program.ultimaTela = 7;
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
            descontoControlador = DescontoProcesso.Instance;
            carregaComboSerie();
            
            cmbSerie.DataSource = listaSalaAuxiliar;

            listaDescontoAux = new List<Desconto>();

            listaDescontoAux = descontoControlador.Consultar();
            cmbDesconto.DataSource = listaDescontoAux;
            cmbDesconto.DisplayMember = "Descricao";

            carregarValorTotal();

        }
        #endregion

        #region EVENTO CADASTRAR
        private void ucMenuInferior1_EventoCadastrar()
        {
            try
            {
                #region VALIDA - SERIE

                if (String.IsNullOrEmpty(cmbSerie.Text))
                {
                    errorProviderTela.SetError(cmbSerie, "Informe a série");
                    return;
                }
                matricula.SalaPeriodo.ID = ((SalaPeriodo)cmbSerie.SelectedItem).ID;

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

                matricula.DiaVencimento = Int32.Parse(cmbDesconto.Text);

                #endregion
            }
            catch (Exception ex)
            { 
            
            }
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

            listaSalaPeriodo = salaPeriodoControlador.Consultar();

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

        private void cmbDesconto_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarValorTotal();
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
