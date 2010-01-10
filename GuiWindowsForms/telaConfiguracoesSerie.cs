using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.ModuloSerie.Processos;
using Negocios.ModuloTurno.Processos;
using Negocios.ModuloTurma.Processos;
using Negocios.ModuloSala.Processos;

namespace GuiWindowsForms
{
    public partial class telaConfiguracoesSerie : Form
    {
        int linhaSelecionadaGrid = -1;

        List<ClasseGrid> listaGrid = null;
        List<Sala> listaSala = null;

        Serie serie = new Serie();
        Turno turno = new Turno();
        Turma turma = new Turma();
        Sala sala = new Sala();

        ISerieProcesso serieControlador = SerieProcesso.Instance;
        ITurnoProcesso turnoControlador = TurnoProcesso.Instance;
        ITurmaProcesso turmaControlador = TurmaProcesso.Instance;
        ISalaProcesso salaControlador = SalaProcesso.Instance;

        #region SINGLETON DA TELA
        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaConfiguracoesSerie telaconfiguracoesserie;

        private static bool IsShown = false;
        #endregion

        #region INSTANCIA TELA FUNCIONARIO
        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. Evita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>

        public static telaConfiguracoesSerie getInstancia()
        {
            if (telaconfiguracoesserie == null)
            {
                telaconfiguracoesserie = new telaConfiguracoesSerie();
            }
            return telaconfiguracoesserie;
        }
        #endregion

        #region CONSTRUTOR
        /// <summary>
        /// Construtor da tela
        /// </summary>

        public telaConfiguracoesSerie()
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
        /// Evento para o fechamento da tela, 
        /// não fecha de verdade, só a esconde, garantindo a usabilidade da tela
        /// pelo singleton
        /// </summary>
        /// <param name="sender">Tela</param>
        /// <param name="e">Cancela seu fechamento, permite só que seja ocultada</param>

        private void telaConfiguracoesSerie_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IsShown = false;
            this.Hide();

            Program.SelecionaForm(Program.ultimaTela);
        }

        private void ucMenuConfiguracoesEsquerda1_EventoAbrirControleDeAcesso()
        {
            this.Hide();
            Program.ultimaTela = 10;
            telaConfiguracoesControleDeAcesso telaconfacesso = telaConfiguracoesControleDeAcesso.getInstancia();
            telaconfacesso.Show();
        }
        #endregion

        #region USER CONTROLS - MENU DIREITA
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
            telaConfiguracoesAtividade telaconfatv = telaConfiguracoesAtividade.getInstancia();
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
            ucMenuDireita1.verificaTela(telaconfiguracoesserie);
        }
        #endregion

        #region USER CONTROLS - MENU ESQUERDA
        private void ucMenuConfiguracoesEsquerda1_Load(object sender, EventArgs e)
        {
            ucMenuConfiguracoesEsquerda1.verificaTela(telaconfiguracoesserie);
        }
        #endregion

        #region USER CONTROLS - Controle Inferior - Botões de Navegação

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
        private void telaConfiguracoesSerie_Load(object sender, EventArgs e)
        {
            List<Serie> listaSerie = new List<Serie>();
            listaSerie = serieControlador.Consultar();
            cmbSerie.DataSource = listaSerie;
            cmbSerie.DisplayMember = "Nome";

            List<Turma> listaTurma = new List<Turma>();
            listaTurma = turmaControlador.Consultar();
            cmbTurma.DataSource = listaTurma;
            cmbTurma.DisplayMember = "Nome";

            List<Turno> listaTurno = new List<Turno>();
            listaTurno = turnoControlador.Consultar();
            cmbTurno.DataSource = listaTurno;
            cmbTurno.DisplayMember = "Nome";

            carregaForm();

        }
        #endregion

        #region EVENTO CADASTRAR
        private void ucMenuInferior1_EventoCadastrar()
        {
            try
            {

                salaControlador = SalaProcesso.Instance;

                #region VALIDA - SERIE

                if (String.IsNullOrEmpty(cmbSerie.Text))
                {
                    errorProviderTela.SetError(cmbSerie, "Informe a serie");
                    return;
                }
                sala.SerieID = ((Serie)cmbSerie.SelectedItem).ID;
                serie = ((Serie)cmbSerie.SelectedItem);


                #endregion

                #region VALIDA - CICLO

                if (String.IsNullOrEmpty(cmbCiclo.Text))
                {
                    errorProviderTela.SetError(cmbCiclo, "Informe o ciclo");
                    return;
                }
                sala.Ciclo = cmbCiclo.Text;

                #endregion

                #region VALIDA - TURNO

                if (String.IsNullOrEmpty(cmbTurno.Text))
                {
                    errorProviderTela.SetError(cmbTurno, "Informe o turno");
                    return;
                }
                sala.TurnoID = ((Turno)cmbTurno.SelectedItem).ID;

                #endregion

                #region VALIDA - TURMA

                if (String.IsNullOrEmpty(cmbTurma.Text))
                {
                    errorProviderTela.SetError(cmbTurma, "Informe a turma");
                    return;
                }
                sala.TurmaID = ((Turma)cmbTurma.SelectedItem).ID;

                #endregion

                #region VALIDA - VALOR

                if (String.IsNullOrEmpty(txtValor.Text))
                {
                    errorProviderTela.SetError(txtValor, "Informe o valor");
                    return;
                }
                sala.Valor = Convert.ToDouble(txtValor.Text);

                #endregion

                Sala salaAux = null;

                if (salaControlador.Consultar(sala, Negocios.ModuloBasico.Enums.TipoPesquisa.E).Count > 0)
                {
                    salaAux = salaControlador.Consultar(sala, Negocios.ModuloBasico.Enums.TipoPesquisa.E)[0];
                }

                //if (sala != null && sala.Equals(salaAux) == false)
                if (linhaSelecionadaGrid== -1)
                {
                    sala.Status =0 ;
                    salaControlador.Incluir(sala);
                    salaControlador.Confirmar();

                    
                    
                }
                else
                {
                    sala.ID = listaSala[linhaSelecionadaGrid].ID;
                    salaControlador.Alterar(sala);
                    carregaForm();
  
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            carregaForm();
        }
        #endregion

        #region LIMPAR ERRO PROVIDER
        private void cmbSerie_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtCiclo_TextChanged(object sender, EventArgs e)
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

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void cmbSerie_Click(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void cmbTurno_Click(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void cmbTurma_Click(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        #endregion

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            salaControlador.Excluir(listaSala[linhaSelecionadaGrid]);
            salaControlador.Confirmar();
            carregaForm();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            cmbCiclo.Text = listaGrid[linhaSelecionadaGrid].CicloAux;
            txtValor.Text = listaGrid[linhaSelecionadaGrid].ValorAux.ToString();
            cmbSerie.Text = listaGrid[linhaSelecionadaGrid].SerieAux;
            cmbTurma.Text = listaGrid[linhaSelecionadaGrid].TurmaAux;
            cmbTurno.Text = listaGrid[linhaSelecionadaGrid].TurnoAux;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            cmbCiclo.Text = listaGrid[linhaSelecionadaGrid].CicloAux;
            txtValor.Text = listaGrid[linhaSelecionadaGrid].ValorAux.ToString();
            cmbSerie.Text = listaGrid[linhaSelecionadaGrid].SerieAux;
            cmbTurma.Text = listaGrid[linhaSelecionadaGrid].TurmaAux;
            cmbTurno.Text = listaGrid[linhaSelecionadaGrid].TurnoAux;
        }

        private void carregaForm()
        {
            salaControlador = SalaProcesso.Instance;
            listaSala = new List<Sala>();
            listaGrid = new List<ClasseGrid>();

            listaSala = salaControlador.Consultar();

            foreach (Sala a in listaSala)
            {
                ClasseGrid classeGridAux = new ClasseGrid();

                classeGridAux.SerieAux = a.Serie.Nome;
                classeGridAux.TurmaAux = a.Turma.Nome;
                classeGridAux.TurnoAux = a.Turno.Nome;
                classeGridAux.ValorAux = Convert.ToDouble(a.Valor.ToString());
                classeGridAux.CicloAux = a.Ciclo;

                listaGrid.Add(classeGridAux);
            }

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaGrid;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            cmbCiclo.Text = listaGrid[linhaSelecionadaGrid].CicloAux;
            txtValor.Text = listaGrid[linhaSelecionadaGrid].ValorAux.ToString();
            cmbSerie.Text = listaGrid[linhaSelecionadaGrid].SerieAux;
            cmbTurma.Text = listaGrid[linhaSelecionadaGrid].TurmaAux;
            cmbTurno.Text = listaGrid[linhaSelecionadaGrid].TurnoAux;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            cmbCiclo.Text = listaGrid[linhaSelecionadaGrid].CicloAux;
            txtValor.Text = listaGrid[linhaSelecionadaGrid].ValorAux.ToString();
            cmbSerie.Text = listaGrid[linhaSelecionadaGrid].SerieAux;
            cmbTurma.Text = listaGrid[linhaSelecionadaGrid].TurmaAux;
            cmbTurno.Text = listaGrid[linhaSelecionadaGrid].TurnoAux;
        }
    }

    public class ClasseGrid
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
        string cicloAux;

        public string CicloAux
        {
            get { return cicloAux; }
            set { cicloAux = value; }
        }
        double valorAux;

        public double ValorAux
        {
            get { return valorAux; }
            set { valorAux = value; }
        }
    }


}
