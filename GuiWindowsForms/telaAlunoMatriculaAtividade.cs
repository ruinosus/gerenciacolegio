using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Negocios.ModuloBasico.VOs;
using Negocios.ModuloMatricula.Processos;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloAtividadeTurma.Processos;
using Negocios.ModuloAlunoAtividadeTurma.Classes_Auxiliares;
using System.Drawing;
using System.IO;
using Negocios.ModuloAlunoAtividadeTurma.Processos;
using Negocios.ModuloAlunoAtividadeTurma.Constantes;
using Negocios.ModuloBoletoAtividade.Processos;

namespace GuiWindowsForms
{
    public partial class telaAlunoMatriculaAtividade : Form
    {
        Memoria memoria = Memoria.Instance;

        AlunoAtividadeTurma alunoAtividadeTurma = new AlunoAtividadeTurma();
        BoletoAtividade boletoAtividade = new BoletoAtividade();

        IAlunoAtividadeTurmaProcesso alunoAtvTurmaControlador = AlunoAtividadeTurmaProcesso.Instance;
        IBoletoAtividadeProcesso boletoAtividadeControlador = null;
        IAtividadeTurmaProcesso atividadeTurmaControlador = null;

        String[] meses = new String[] { "-", "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };


        #region SINGLETON DA TELA
        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaAlunoMatriculaAtividade telaalunomatriculatividade;

        private static bool IsShown = false;
        #endregion
       
        #region INSTANCIA TELA MATRICULA
        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. E
        /// vita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>

        public static telaAlunoMatriculaAtividade getInstancia()
        {
            if (telaalunomatriculatividade == null)
            {
                telaalunomatriculatividade = new telaAlunoMatriculaAtividade();
            }
            return telaalunomatriculatividade;
        }
        #endregion

        #region CONSTRUTOR
        /// <summary>
        /// Construtor da tela
        /// </summary>

        public telaAlunoMatriculaAtividade()
        {
            InitializeComponent();
        }
        #endregion

        #region MÉTODO PARA VERIFICAR USO DA TELA
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
        /// Evento para o fechamento da tela, não fecha de verdade, só a esconde, 
        /// garantindo a usabilidade da tela
        /// pelo singleton
        /// </summary>
        /// <param name="sender">Tela</param>
        /// <param name="e">Cancela seu fechamento, permite só que seja ocultada</param>

        private void telaAlunoMatriculaAtividade_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IsShown = false;
            this.Hide();

            Program.ultimaTela = 4;
            Program.SelecionaForm(Program.ultimaTela);
        }
        #endregion
        
        #region BUTTON MATRICULA ATIVIDADE
 
        private void btnMatriculaSerie_MouseEnter(object sender, EventArgs e)
        {
            this.btnMatriculaSerie.BackgroundImage = global::GuiWindowsForms.Properties.Resources.add_matricula_47x49_hover;
            //lblInfoControles.Text = "Matricular um aluno.";
            //lblInfoControles.Visible = true;
        }

        private void btnMatriculaSerie_MouseLeave(object sender, EventArgs e)
        {
            this.btnMatriculaSerie.BackgroundImage = global::GuiWindowsForms.Properties.Resources.add_matricula_47x49;
            //lblInfoControles.Visible = false;
        }

        private void btnMatriculaSerie_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 6;
            telaAlunoMatricula telaalunomatricula = telaAlunoMatricula.getInstancia();
            telaalunomatricula.Show();

        }

        #endregion

        #region USER CONTROLS - Controle Inferior - Botões de Navegação

        private void ucAluno1_EventoVoltar()
        {
            this.Hide();

            if (Program.ultimaTela == 4)
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
            uMenuLateral1.verificaTela(telaalunomatriculatividade);
        }

        #endregion

        #region LOAD
        private void telaAlunoMatriculaAtividade_Load(object sender, EventArgs e)
        {
            uMenuImagem1.ocultarBotaoAdicionarImagem();
        }
        #endregion

        #region EVENTO CADASTRAR

        private void ucMenuInferior1_EventoCadastrar()
        {
            alunoAtividadeTurma = new AlunoAtividadeTurma();
            alunoAtvTurmaControlador = AlunoAtividadeTurmaProcesso.Instance;

            try
            {
                #region VALIDA - ATIVIDADE

                if (String.IsNullOrEmpty(cmbAtividade.Text))
                {
                    errorProviderTela.SetError(cmbAtividade, "Informe a atividade");
                    return;
                }
                alunoAtividadeTurma.AtividadeTurmaID = ((AuxiliarAlunoAtvTurma)cmbAtividade.SelectedItem).Id;


                #endregion

                #region VALIDA - DESCRIÇÃO

                if (String.IsNullOrEmpty(txtDescricao.Text))
                {
                    errorProviderTela.SetError(txtDescricao, "Informe a descrição");
                    txtDescricao.Clear();
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

                #region VALIDA - DESCONTO

                if (String.IsNullOrEmpty(txtDesconto.Text))
                {
                    errorProviderTela.SetError(txtDesconto, "Informe o valor");
                    txtDesconto.Clear();
                    return;
                }
                alunoAtividadeTurma.Desconto = Convert.ToDouble(txtDesconto.Text);
                #endregion

                #region VALIDA - VALOR TOTAL

                if (String.IsNullOrEmpty(txtTotalValor.Text))
                {
                    errorProviderTela.SetError(txtValor, "Informe o valor total");
                    txtTotalValor.Clear();
                    return;
                }
                alunoAtividadeTurma.Valor = Convert.ToDouble(txtTotalValor.Text);

                #endregion

                alunoAtividadeTurma.AlunoID = memoria.Aluno.ID;
                alunoAtividadeTurma.Ano = DateTime.Now.Year;
                alunoAtividadeTurma.DataMatricula = DateTime.Now;
                alunoAtividadeTurma.Status = (int)Status.Ativo;

                int matriculaAux = -1;

                if (retornaIdMatricula(memoria) != -1)
                {
                    matriculaAux = retornaIdMatricula(memoria);
                }

                if (verificaSeJaInserido(alunoAtividadeTurma) == false)
                {
                    alunoAtvTurmaControlador.Incluir(alunoAtividadeTurma);
                    alunoAtvTurmaControlador.Confirmar();

                    for (int i = 0; i < 12; i++)
                    {
                        boletoAtividadeControlador = BoletoAtividadeProcesso.Instance;
                        boletoAtividade = new BoletoAtividade();

                        boletoAtividade.Descricao = "BOLETO";

                        DateTime novoDtParcela = new DateTime(DateTime.Now.Year, 1, 1);

                        boletoAtividade.DataVencimento = novoDtParcela.AddMonths(i); ;

                        boletoAtividade.Status = (int)Status.Ativo;
                        boletoAtividade.Desconto = Convert.ToDouble(txtDesconto.Text);

                        boletoAtividade.Parcela = meses[novoDtParcela.AddMonths(i).Month];

                        boletoAtividade.MatriculaID = matriculaAux;
                        boletoAtividade.DataEmissao = DateTime.Now;
                        boletoAtividade.Valor = alunoAtividadeTurma.Valor;
                        boletoAtividade.AlunoAtividadeTurmaID = alunoAtividadeTurma.ID;

                        boletoAtividadeControlador.Incluir(boletoAtividade);
                        boletoAtividadeControlador.Confirmar();

                    }

                    MessageBox.Show(AlunoAtividadeTurmaConstantes.ALUNOATIVIDADETURMA_INCLUIDO, "Colégio Conhecer - Inserir Matrícula da Atividade");
                }
                else
                {
                    MessageBox.Show("A Matrícula já existe na base de dados", "Colégio Conhecer - Inserir Matrícula da Atividade");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region LIMPAR ERRO PROVIDER
        private void cmbAtividade_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
            double valorAux = Convert.ToDouble(txtValor.Text); 
            double descontoAux = Convert.ToDouble(txtDesconto.Text);
            double resultadoAux = valorAux - descontoAux;
            txtTotalValor.Text = resultadoAux.ToString();
        }

        private void btnAdicionarImagem_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }
        #endregion

        private void ucDesconectarLogin1_EventoDesconectar()
        {
            Program.ultimaTela = 9;
            this.Close();
            telaLogin telalogin = telaLogin.getInstancia();
            telalogin.Show();
        }

        private void telaAlunoMatriculaAtividade_Activated(object sender, EventArgs e)
        {
            carregarComboAtividade();
            uMenuLateral1.verificaTela(telaalunomatriculatividade);
            uMenuImagem1.ocultarBotaoAdicionarImagem();

            if (memoria.Aluno != null)
            {
                uMenuImagem1.carregaAluno(memoria.Aluno);
                lblNumeroMatricula.Text = retornaMatricula(memoria);
                alunoAtividadeTurma.Aluno = memoria.Aluno;
                alunoAtividadeTurma.AlunoID = memoria.Aluno.ID;
                alunoAtividadeTurma.Ano = DateTime.Now.Year;
            }
        }


        #region MÉTODOS AUXILIARES

        /// <summary>
        /// Verifica se a matricula já existe no cadastro
        /// </summary>
        /// <param name="matricula"></param>
        /// <returns></returns>
        public bool verificaSeJaInserido(AlunoAtividadeTurma matricula)
        {
            alunoAtvTurmaControlador = AlunoAtividadeTurmaProcesso.Instance;

            List<AlunoAtividadeTurma> listaAuxiliar = new List<AlunoAtividadeTurma>();
            listaAuxiliar = alunoAtvTurmaControlador.Consultar();

            bool testa = false;

            foreach (AlunoAtividadeTurma b in listaAuxiliar)
            {
                if ((b.AlunoID == matricula.AlunoID) && (b.Ano == matricula.Ano))
                {
                    testa = true;
                }
            }
            return testa;
        }


        /// <summary>
        /// Método para verificar a matricula e retornar para a tela
        /// </summary>
        /// <param name="memoria">Recebe um objeto tipo memoria (Memoria.Aluno)</param>
        /// <returns>retorna uma string com a matrícula</returns>
        private String retornaMatricula(Memoria memoria)
        {
            string numMatricula = null;
            Matricula matricula = new Matricula();
            IMatriculaProcesso matriculaControlador = MatriculaProcesso.Instance;

            List<Matricula> matriculaAuxiliar = new List<Matricula>();

            matricula.Status = (int)Status.Ativo;
            matriculaAuxiliar = matriculaControlador.Consultar(matricula, TipoPesquisa.E);

            foreach (Matricula m in matriculaAuxiliar)
            {
                if (m.AlunoID == memoria.Aluno.ID)
                {
                    numMatricula = m.NumMatricula;
                }
            }

            return numMatricula;
        }

        /// <summary>
        /// Retorna todas as atividades cadastradas ativas
        /// </summary>
        private void carregarComboAtividade()
        {
            AtividadeTurma atvTurmaAux = new AtividadeTurma();
            atividadeTurmaControlador = AtividadeTurmaProcesso.Instance;

            atvTurmaAux.Status = (int)Status.Ativo;

            List<AtividadeTurma> listaAtividadeCmb = new List<AtividadeTurma>();
            listaAtividadeCmb = atividadeTurmaControlador.Consultar(atvTurmaAux, TipoPesquisa.E);

            List<AuxiliarAlunoAtvTurma> listaAtividadeComboAuxiliar = new List<AuxiliarAlunoAtvTurma>();

            foreach (AtividadeTurma at in listaAtividadeCmb)
            {
                AuxiliarAlunoAtvTurma atvCmbAuxiliar = new AuxiliarAlunoAtvTurma();

                atvCmbAuxiliar.Id = at.ID;
                atvCmbAuxiliar.Nome = at.Atividade.Nome;
                atvCmbAuxiliar.Turma = at.Turma;
                atvCmbAuxiliar.Mensagem = at.Atividade.Nome + " - " + at.Turma;

                listaAtividadeComboAuxiliar.Add(atvCmbAuxiliar);
            }

            cmbAtividade.DataSource = null;
            cmbAtividade.DataSource = listaAtividadeComboAuxiliar;
            cmbAtividade.DisplayMember = "Mensagem";
        }

        /// <summary>
        /// Evento para variar os valores de acordo com o desconto digitado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbAtividade_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtividadeTurma atvTurmaCmbAuxiliar = new AtividadeTurma();

            if ((AuxiliarAlunoAtvTurma)cmbAtividade.SelectedItem != null)
            {
                int IdAux = ((AuxiliarAlunoAtvTurma)cmbAtividade.SelectedItem).Id;
                atvTurmaCmbAuxiliar.ID = IdAux;
                atvTurmaCmbAuxiliar = atividadeTurmaControlador.Consultar(atvTurmaCmbAuxiliar, Negocios.ModuloBasico.Enums.TipoPesquisa.E)[0];
                txtValor.Text = Convert.ToString(atvTurmaCmbAuxiliar.Valor);
                txtDescricao.Text = atvTurmaCmbAuxiliar.Atividade.Descricao;
            }
        }

        /// <summary>
        /// Método para retornar o número da matrícula do aluno em questão
        /// </summary>
        /// <param name="memoria"></param>
        /// <returns></returns>
        private int retornaIdMatricula(Memoria memoria)
        {
            int matriculaAux = -1;

            IMatriculaProcesso matriculaProcesso = MatriculaProcesso.Instance;
            Matricula matriculaAuxObj = new Matricula();

            List<Matricula> listaAlunoAux = new List<Matricula>();
            matriculaAuxObj.AlunoID = memoria.Aluno.ID;
            matriculaAuxObj.Ano = DateTime.Now.Year;
            listaAlunoAux = matriculaProcesso.Consultar(matriculaAuxObj, TipoPesquisa.E);
            if (listaAlunoAux.Count > 0)
            {
                matriculaAux = listaAlunoAux[0].ID;
            }
            return matriculaAux;

        }

        #endregion

    }
}

