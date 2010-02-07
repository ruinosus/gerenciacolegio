using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.ModuloResponsavelAluno.Processos;
using Negocios.ModuloBasico.VOs;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloMatriculaVinculo.Processos;
using Negocios.ModuloMatricula.Processos;
using Negocios.ModuloMatriculaVinculo.VOs;

namespace GuiWindowsForms
{
    public partial class telaAlunoMatriculaVinculo : Form
    {
        #region ATRIBUTOS
        List<MatriculaVinculo> matriculaVinculoListaAlunoAtualDependente;
        List<MatriculaVinculo> matriculaVinculoListaAlunoAtualMestre;
        List<MatriculaVinculoBoleto> matriculaVinculoBoletoLista;
        int linhaSelecionadaGrid = -1;
        List<Aluno> alunos;
        #endregion

        #region SINGLETON DA TELA
        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaAlunoMatriculaVinculo telaalunomatriculavinculo;

        private static bool IsShown = false;
        #endregion

        #region INSTANCIA TELA MATRICULA VINCULO
        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. Evita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>

        public static telaAlunoMatriculaVinculo getInstancia()
        {
            if (telaalunomatriculavinculo == null)
            {
                telaalunomatriculavinculo = new telaAlunoMatriculaVinculo();
            }
            return telaalunomatriculavinculo;
        }
        #endregion

        #region CONSTRUTOR
        /// <summary>
        /// Construtor da tela
        /// </summary>

        public telaAlunoMatriculaVinculo()
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

        private void telaAlunoMatriculaVinculo_FormClosing(object sender, FormClosingEventArgs e)
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

            Resetar();
            Memoria.Instance.StatusTelaAlunoMatriculaVinculo = OperacoesDaTela.Inativa;
        }
        #endregion

        #region ACTIVATED
        private void telaAlunoMatriculaVinculo_Activated(object sender, EventArgs e)
        {
            switch (Memoria.Instance.StatusTelaAlunoMatriculaVinculo)
            {
                case OperacoesDaTela.AbrirTela:
                    {
                        if (Memoria.Instance.Aluno != null)
                        {
                            Memoria.Instance.Matricula = CarregarMatricula(Memoria.Instance.Aluno);
                            matriculaVinculoListaAlunoAtualDependente = VerificarMatriculaDependente(Memoria.Instance.Aluno);
                            matriculaVinculoListaAlunoAtualMestre = VerificarMatriculaMestre(Memoria.Instance.Aluno);
                            if (matriculaVinculoListaAlunoAtualDependente.Count > 0)
                            {
                                Resetar();
                                Memoria.Instance.StatusTelaAlunoMatriculaVinculo = OperacoesDaTela.Bloquear;
                            }
                            else if (matriculaVinculoListaAlunoAtualMestre.Count >= 0)
                            {
                                linhaSelecionadaGrid = -1;
                                CarregarCombo(true);
                                CarregarGrid(matriculaVinculoListaAlunoAtualMestre);
                                Memoria.Instance.StatusTelaAlunoMatriculaVinculo = OperacoesDaTela.Navegar;
                            }

                            uMenuImagem1.carregaAluno(Memoria.Instance.Aluno);
                            AjustarBotoes();
                        }
                        break;


                    }
            }



        }     
        #endregion

        #region USER CONTROLS
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

        #region USER CONTROLS - Menu inferior

        private void ucMenuInferior1_EventoIncluir()
        {
            Memoria.Instance.StatusTelaAlunoMatriculaVinculo = OperacoesDaTela.Incluir;
            AjustarBotoes();
        }

        private void ucMenuInferior1_EventoDeletar()
        {
            try
            {

                if (MessageBox.Show("Tem certeza que deseja excluir o Vínculo?", "Colégio Conhecer - Excluir Vínculo", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    if (linhaSelecionadaGrid != -1)
                    {
                        IMatriculaVinculoProcesso processo = MatriculaVinculoProcesso.Instance;
                        processo.Excluir(matriculaVinculoListaAlunoAtualMestre[linhaSelecionadaGrid]);
                        processo.Confirmar();
                        MessageBox.Show("Regristo removido com sucesso.");
                        Memoria.Instance.StatusTelaAlunoMatriculaVinculo = OperacoesDaTela.Navegar;
                        Atualizar();
                        AjustarBotoes();

                    }
                }

            }
            catch (Exception)
            {

                //throw;
            }

        }

        private void ucMenuInferior1_EventoCadastrar()
        {

            try
            {
                if (cmbAluno.SelectedItem == null)
                {
                    errorProviderTela.SetError(cmbAluno, "Nenhum Aluno selecionado");
                    return;
                }
                Matricula matricula = CarregarMatricula((Aluno)cmbAluno.SelectedItem);
                var resultado = (from m in matriculaVinculoListaAlunoAtualMestre
                                 where m.MatriculaDependenteID == matricula.ID
                                 select m).ToList();
                if (resultado.Count > 0)
                {
                    errorProviderTela.SetError(cmbAluno, "Aluno já vinculado.");
                    return;
                }
                IMatriculaVinculoProcesso processo = MatriculaVinculoProcesso.Instance;
                MatriculaVinculo mv = new MatriculaVinculo();

                mv.MatriculaDependenteID = matricula.ID;
                mv.MatriculaMestreID = Memoria.Instance.Matricula.ID;
                mv.DataVinculo = DateTime.Now;
                mv.Status = (int)Status.Ativo;
                switch (Memoria.Instance.StatusTelaAlunoMatriculaVinculo)
                {
                    case OperacoesDaTela.Incluir:
                        {
                            processo.Incluir(mv);
                            processo.Confirmar();
                            break;
                        }
                    case OperacoesDaTela.Alterar:
                        {
                            processo.Alterar(mv);
                            processo.Confirmar();
                            break;
                        }

                }
                Memoria.Instance.StatusTelaAlunoMatriculaVinculo = OperacoesDaTela.Navegar;
                Atualizar();
                AjustarBotoes();

            }
            catch (Exception)
            {

            }


        }

        private void ucMenuInferior1_EventoAlterar()
        {
            Memoria.Instance.StatusTelaAlunoMatriculaVinculo = OperacoesDaTela.Alterar;
            AjustarBotoes();
        }

        private void ucDesconectarLogin1_EventoDesconectar()
        {
            Program.ultimaTela = 9;
            this.Close();
            telaLogin telalogin = telaLogin.getInstancia();
            telalogin.Show();
        }

        #endregion 
        #endregion

        #region MÉTODOS DE MANIPULAÇÃO DE INFORMAÇÃO
        /// <summary>
        /// Metodo responsável por verificar se o Aluno atual está com vinculo dependente com outro aluno.
        /// </summary>
        /// <param name="aluno"> Aluno que será utilizado como pesquisa</param>
        /// <returns>Lista contendo todos os vinculos do aluno informado.</returns>
        private List<MatriculaVinculo> VerificarMatriculaDependente(Aluno aluno)
        {
            Matricula matricula = CarregarMatricula(aluno);
            List<MatriculaVinculo> resultado = new List<MatriculaVinculo>();

            if (Memoria.Instance.Matricula != null)
            {
                IMatriculaVinculoProcesso processo = MatriculaVinculoProcesso.Instance;
                MatriculaVinculo matriculaVinculoPesquisa = new MatriculaVinculo();
                matriculaVinculoPesquisa.MatriculaDependenteID = matricula.ID;
                matriculaVinculoPesquisa.Status = (int)Status.Ativo;
                resultado = processo.Consultar(matriculaVinculoPesquisa, TipoPesquisa.E);
            }

            return resultado;

        }

        /// <summary>
        ///Metodo responsável por verificar se o aluno atual está com vinculo mestre com outros alunos.
        /// </summary>
        /// <param name="aluno"> Aluno que será utilizado como pesquisa</param>
        /// <returns>Lista contendo todos os vinculos do aluno informado.</returns>     
        private List<MatriculaVinculo> VerificarMatriculaMestre(Aluno aluno)
        {
            Matricula matricula = CarregarMatricula(aluno);
            List<MatriculaVinculo> resultado = new List<MatriculaVinculo>();

            if (Memoria.Instance.Matricula != null)
            {
                IMatriculaVinculoProcesso processo = MatriculaVinculoProcesso.Instance;
                MatriculaVinculo matriculaVinculoPesquisa = new MatriculaVinculo();
                matriculaVinculoPesquisa.MatriculaMestreID = matricula.ID;
                matriculaVinculoPesquisa.Status = (int)Status.Ativo;
                resultado = processo.Consultar(matriculaVinculoPesquisa, TipoPesquisa.E);
            }

            return resultado;

        }

        /// <summary>
        /// Carrega a matricula atual do aluno.
        /// </summary>
        /// <param name="aluno"> Aluno que será utilizado como pesquisa</param>
        /// <returns>Matricula atual do aluno informado.</returns>
        private Matricula CarregarMatricula(Aluno aluno)
        {
            Matricula resultado = new Matricula();

            if (aluno != null)
            {
                IMatriculaProcesso matriculaProcesso = MatriculaProcesso.Instance;
                Matricula matriculaPesquisa = new Matricula();
                matriculaPesquisa.AlunoID = aluno.ID;
                matriculaPesquisa.Ano = DateTime.Now.Year;
                matriculaPesquisa.Status = (int)Status.Ativo;

                List<Matricula> matriculaLista = matriculaProcesso.Consultar(matriculaPesquisa, TipoPesquisa.E);

                if (matriculaLista.Count == 1)
                    resultado = matriculaLista[0];
                else
                    resultado = null;
            }

            return resultado;
        }

        /// <summary>
        /// Método responsável por carregar o Grid.
        /// </summary>
        /// <param name="matriculaVinculoLista">Lista a ser carregada.</param>
        private void CarregarGrid(List<MatriculaVinculo> matriculaVinculoLista)
        {
            matriculaVinculoBoletoLista = new List<MatriculaVinculoBoleto>();
            ClasseGridAuxiliar classeAuxiliar;
            foreach (MatriculaVinculo mv in matriculaVinculoLista)
            {
                classeAuxiliar = new ClasseGridAuxiliar();
                classeAuxiliar.NomeAluno1 = mv.MatriculaDependente.Aluno.Nome;
                classeAuxiliar.ID = mv.MatriculaDependente.Aluno.ID;
                classeAuxiliar.SerieAluno = mv.MatriculaDependente.Aluno.SerieAtual;
                classeAuxiliar.Ano = mv.MatriculaDependente.Ano.Value.ToString();
                matriculaVinculoBoletoLista.Add(classeAuxiliar);
            }

            dgvAlunosVinculados.AutoGenerateColumns = false;
            dgvAlunosVinculados.DataSource = matriculaVinculoBoletoLista;

            if (matriculaVinculoBoletoLista.Count > 0)
            {
                dgvAlunosVinculados.Rows[0].Selected = true;
                linhaSelecionadaGrid = 0;
            }
        }

        /// <summary>
        /// Método responsável por carregar o Combo com os alunos disponíveis.
        /// </summary>
        /// <param name="removerAlunos">informa se é necessário remover os alunos</param>
        private void CarregarCombo(bool removerAlunos)
        {
            if (Memoria.Instance.Aluno != null)
            {

                IResponsavelAlunoProcesso processo = ResponsavelAlunoProcesso.Instance;
                ResponsavelAluno responsavelAluno = new ResponsavelAluno();
                responsavelAluno.AlunoID = Memoria.Instance.Aluno.ID;
                responsavelAluno.Status = (int)Status.Ativo;

                List<ResponsavelAluno> resultado = processo.Consultar(responsavelAluno, Negocios.ModuloBasico.Enums.TipoPesquisa.E);
                List<ResponsavelAluno> listaCombo = new List<ResponsavelAluno>();
                responsavelAluno.AlunoID = 0;
                alunos = new List<Aluno>();
                foreach (ResponsavelAluno ra in resultado)
                {
                    responsavelAluno.ResponsavelID = ra.ResponsavelID;
                    listaCombo.AddRange(processo.Consultar(responsavelAluno, TipoPesquisa.E));
                }

                listaCombo.RemoveAll(delegate(ResponsavelAluno ra)
                {
                    return ra.AlunoID == Memoria.Instance.Aluno.ID;
                });

                for (int i = 0; i < listaCombo.Count; i++)
                {
                    for (int j = i; j < listaCombo.Count; j++)
                    {
                        if (listaCombo[i].AlunoID == listaCombo[j].AlunoID && i != j)
                        {
                            listaCombo.RemoveAt(i);
                            i = 0;
                            j = 0;
                        }
                    }

                }
                foreach (ResponsavelAluno ra in listaCombo)
                {
                    alunos.Add(ra.Aluno);
                }
                List<MatriculaVinculo> mvm;
                List<MatriculaVinculo> mvd;
                if (removerAlunos)
                {
                    for (int i = 0; i < alunos.Count; i++)
                    {
                        mvm = VerificarMatriculaMestre(alunos[i]);
                        mvd = VerificarMatriculaDependente(alunos[i]);
                        mvd.RemoveAll(delegate(MatriculaVinculo mv)
                           {
                               return mv.MatriculaMestreID == Memoria.Instance.Matricula.ID;
                           });
                        if (mvd.Count > 0 || mvm.Count > 0)
                        {
                            alunos.RemoveAt(i);
                            i = -1;
                        }

                    }
                }
                var lista = from a in alunos
                            orderby a.Nome
                            select a;
                ExibirCombo(lista.ToList());
            }


        }

        private void ExibirCombo(List<Aluno> alunos)
        {
            cmbAluno.DataSource = alunos;
            cmbAluno.DisplayMember = "Nome";
            cmbAluno.ValueMember = "ID";
        }

        private void Atualizar()
        {
            matriculaVinculoListaAlunoAtualMestre = VerificarMatriculaMestre(Memoria.Instance.Aluno);
            CarregarGrid(matriculaVinculoListaAlunoAtualMestre);
        }

        private void AjustarBotoes()
        {
            switch (Memoria.Instance.StatusTelaAlunoMatriculaVinculo)
            {
                case OperacoesDaTela.Incluir:
                    {
                        ApagarBotoes();
                        break;
                    }
                case OperacoesDaTela.Alterar:
                    {
                        ApagarBotoes();
                        break;
                    }
                case OperacoesDaTela.Navegar:
                    {
                        ApagarBotoes();
                        if (matriculaVinculoListaAlunoAtualMestre.Count > 0)
                        {
                            //ucMenuInferior1.exibirBotaoAlterar();
                            ucMenuInferior1.exibirBotaoDeletar();
                        }
                        ucMenuInferior1.exibirBotaoIncluir();
                        break;
                    }
                case OperacoesDaTela.Bloquear:
                    {
                        ApagarBotoes();
                        break;
                    }
                default:
                    break;
            }
            AjustarEdits();
        }

        private void ApagarBotoes()
        {
            uMenuImagem1.ocultarBotaoAdicionarImagem();
            ucMenuInferior1.apagarBotaoAlterar();
            ucMenuInferior1.apagarBotaoDeletar();
            ucMenuInferior1.apagarBotaoIncluir();
        }

        private void AjustarEdits()
        {
            switch (Memoria.Instance.StatusTelaAlunoMatriculaVinculo)
            {
                case OperacoesDaTela.Incluir:
                    {
                        cmbAluno.Enabled = true;
                        dgvAlunosVinculados.Enabled = false;
                        break;
                    }
                case OperacoesDaTela.Alterar:
                    {
                        cmbAluno.Enabled = true;
                        dgvAlunosVinculados.Enabled = false;
                        break;
                    }
                case OperacoesDaTela.Navegar:
                    {
                        if (linhaSelecionadaGrid != -1)
                            cmbAluno.SelectedValue = matriculaVinculoListaAlunoAtualMestre[linhaSelecionadaGrid].MatriculaDependente.Aluno.ID;
                        cmbAluno.Enabled = false;
                        dgvAlunosVinculados.Enabled = true;
                        LimparErro();
                        break;
                    }
                case OperacoesDaTela.Bloquear:
                    {
                        cmbAluno.Enabled = false;
                        dgvAlunosVinculados.Enabled = false;
                        ucMenuInferior1.exibirMensagem("O Aluno atual é dependente de outro Aluno. ");
                        break;
                    }
                default:
                    break;
            }

        }

        private void Resetar()
        {
            matriculaVinculoListaAlunoAtualDependente = new List<MatriculaVinculo>();
            matriculaVinculoListaAlunoAtualMestre = new List<MatriculaVinculo>();
            matriculaVinculoBoletoLista = new List<MatriculaVinculoBoleto>();
            linhaSelecionadaGrid = -1;
            alunos = new List<Aluno>();
            ExibirCombo(alunos);
            CarregarGrid(matriculaVinculoListaAlunoAtualMestre);
        }
        #endregion        

        #region CLASSE AUXILIAR
        private class ClasseGridAuxiliar : MatriculaVinculoBoleto
        {
            public int ID { get; set; }

        }
        #endregion

        #region LIMPAR ERROPROVIDER
        private void LimparErro()
        {
            errorProviderTela.Clear();
        }
        #endregion

        #region MÉTODOS DO GRID
        private void dgvAlunosVinculados_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());

            AjustarBotoes();
        }
        #endregion
    }
}
