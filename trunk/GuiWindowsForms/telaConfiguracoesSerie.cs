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
using Negocios.ModuloSerie.Constantes;
using Negocios.ModuloSalaPeriodo.Processos;

namespace GuiWindowsForms
{
    public partial class telaConfiguracoesSerie : Form
    {
        int linhaSelecionadaGrid = -1;

        List<ClasseGrid> listaGrid = null;
        List<Sala> listaSala = null;

        Serie serie = null;
        Turno turno = null;
        Turma turma = null;
        Sala sala = null;
        SalaPeriodo salaPeriodo = null;

        ISerieProcesso serieControlador = SerieProcesso.Instance;
        ITurnoProcesso turnoControlador = TurnoProcesso.Instance;
        ITurmaProcesso turmaControlador = TurmaProcesso.Instance;
        ISalaProcesso salaControlador = SalaProcesso.Instance;
        ISalaPeriodoProcesso salaPeriodoControlador = SalaPeriodoProcesso.Instance;

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
                sala = new Sala();
                serie = new Serie();
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

                if (linhaSelecionadaGrid != -1)
                {
                    sala.ID = listaSala[linhaSelecionadaGrid].ID;
                    salaControlador.Alterar(sala);
                    carregaForm();
                    linhaSelecionadaGrid = -1;

                    MessageBox.Show(SerieConstantes.SERIE_ALTERADA,"Colégio Conhecer - Alterar Série");
                }
                else
                {
                    MessageBox.Show("Selecione um registro para alterar, caso queira inserir use o botão +","Colégio Conhecer - Alterar Série");
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

        private void txtValor_Click(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
            txtValor.SelectionStart = txtValor.Text.Length + 1;
        }
        #endregion

        #region BUTTON EXCLUIR
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir a série ?", "Colégio Conhecer - Excluir Série", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                if (linhaSelecionadaGrid != -1)
                {
                    salaControlador.Excluir(listaSala[linhaSelecionadaGrid]);
                    salaControlador.Confirmar();
                    carregaForm();
                    linhaSelecionadaGrid = -1;
                }
                else
                {
                    MessageBox.Show("Selecione uma opção na tabela abaixo para exclusão, então pressione excluir.", "Colégio Conhecer - Excluir Série");
                }
            }
        }
        #endregion

        #region EVENTOS DO GRID

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            if (linhaSelecionadaGrid >= 0)
            {
                cmbCiclo.Text = listaGrid[linhaSelecionadaGrid].CicloAux;
                txtValor.Text = listaGrid[linhaSelecionadaGrid].ValorAux.ToString();
                cmbSerie.Text = listaGrid[linhaSelecionadaGrid].SerieAux;
                cmbTurma.Text = listaGrid[linhaSelecionadaGrid].TurmaAux;
                cmbTurno.Text = listaGrid[linhaSelecionadaGrid].TurnoAux;
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

                cmbCiclo.Text = listaGrid[linhaSelecionadaGrid].CicloAux;
                txtValor.Text = listaGrid[linhaSelecionadaGrid].ValorAux.ToString();
                cmbSerie.Text = listaGrid[linhaSelecionadaGrid].SerieAux;
                cmbTurma.Text = listaGrid[linhaSelecionadaGrid].TurmaAux;
                cmbTurno.Text = listaGrid[linhaSelecionadaGrid].TurnoAux;
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

                cmbCiclo.Text = listaGrid[linhaSelecionadaGrid].CicloAux;
                txtValor.Text = listaGrid[linhaSelecionadaGrid].ValorAux.ToString();
                cmbSerie.Text = listaGrid[linhaSelecionadaGrid].SerieAux;
                cmbTurma.Text = listaGrid[linhaSelecionadaGrid].TurmaAux;
                cmbTurno.Text = listaGrid[linhaSelecionadaGrid].TurnoAux;
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

                cmbCiclo.Text = listaGrid[linhaSelecionadaGrid].CicloAux;
                txtValor.Text = listaGrid[linhaSelecionadaGrid].ValorAux.ToString();
                cmbSerie.Text = listaGrid[linhaSelecionadaGrid].SerieAux;
                cmbTurma.Text = listaGrid[linhaSelecionadaGrid].TurmaAux;
                cmbTurno.Text = listaGrid[linhaSelecionadaGrid].TurnoAux;
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
                
                cmbCiclo.Text = listaGrid[linhaSelecionadaGrid].CicloAux;
                txtValor.Text = listaGrid[linhaSelecionadaGrid].ValorAux.ToString();
                cmbSerie.Text = listaGrid[linhaSelecionadaGrid].SerieAux;
                cmbTurma.Text = listaGrid[linhaSelecionadaGrid].TurmaAux;
                cmbTurno.Text = listaGrid[linhaSelecionadaGrid].TurnoAux;
            }
            else
            {
                linhaSelecionadaGrid = -1;
            }
        }

        #endregion

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

        #region EVENTOS PARA EXIBIÇÃO DE MENSAGENS DA TELA

        private void btnExcluir_MouseEnter(object sender, EventArgs e)
        {
            ucMenuInferior1.exibirMensagem("Excluir uma sala/série do registro");
        }

        private void btnExcluir_MouseLeave(object sender, EventArgs e)
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

        private void btnAdicionarSerie_MouseEnter(object sender, EventArgs e)
        {
            ucMenuInferior1.exibirMensagem("Incluir uma nova sala ao registro");
        }

        private void btnAdicionarSerie_MouseLeave(object sender, EventArgs e)
        {
            ucMenuInferior1.ocultarMensagem();
        }

        #endregion

        #region BUTTON ADICIONAR SERIE

        private void btnAdicionarSerie_Click(object sender, EventArgs e)
        {

            try
            {
                sala = new Sala();
                serie = new Serie();
                salaPeriodo = new SalaPeriodo();

                salaControlador = SalaProcesso.Instance;
                salaPeriodoControlador = SalaPeriodoProcesso.Instance;

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

                
                if (verificaSeJaInserido(sala)==false)
                {
                        sala.Status = 0;
                        salaControlador.Incluir(sala);
                        salaControlador.Confirmar();

                        salaPeriodo.Ano = DateTime.Now.Year;
                        salaPeriodo.SalaID = sala.ID;
                        salaPeriodo.Status = 1;

                        salaPeriodoControlador.Incluir(salaPeriodo);
                        salaPeriodoControlador.Confirmar();
                        
                        linhaSelecionadaGrid = -1;

                        MessageBox.Show(SerieConstantes.SERIE_INCLUIDA, "Colégio Conhecer - Inserir Série");
                }
                else
                {
                    MessageBox.Show("A Série já existe na base de dados", "Colégio Conhecer - Inserir Série");
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

        public void limparTela()
        {
            txtValor.Clear();
            cmbCiclo.SelectedIndex = 0;
            cmbSerie.SelectedIndex = 0;
            cmbTurma.SelectedIndex = 0;
            cmbTurno.SelectedIndex = 0;
        }

        public bool verificaSeJaInserido(Sala sala)
        {
            salaControlador = SalaProcesso.Instance;

            List<Sala> listaAuxiliar = new List<Sala>();
            listaAuxiliar = salaControlador.Consultar();

            bool testa = false;

            foreach (Sala b in listaAuxiliar)
            {
                if ((b.TurmaID == sala.TurmaID) && (b.TurnoID == sala.TurnoID) && (b.SerieID == sala.SerieID) && (b.Ciclo == sala.Ciclo) && (b.Valor == sala.Valor))
                {
                    testa = true;
                }
            }
            return testa;
        }

    }

    #region CLASSE AUXILIAR PARA USO NO DATAGRID

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

    #endregion


}
