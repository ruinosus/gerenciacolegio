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
            telaAlunoResponsavelBusca tela = telaAlunoResponsavelBusca.getInstancia();
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
            uMenuLateral1.verificaTela(telaalunomatriculavinculo);
        }
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

            if (matricula != null)
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

            if (matricula != null)
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
            List<MatriculaVinculoBoleto> matriculaVinculoBoletoLista = new List<MatriculaVinculoBoleto>();
            MatriculaVinculoBoleto matriculaVinculoBoleto;
            foreach (MatriculaVinculo mv in matriculaVinculoLista)
            {
                matriculaVinculoBoleto = new MatriculaVinculoBoleto();
                matriculaVinculoBoleto.NomeAluno = mv.MatriculaDependente.Aluno.Nome;
                matriculaVinculoBoleto.SerieAluno = mv.MatriculaDependente.Aluno.SerieAtual;
                matriculaVinculoBoleto.Ano = mv.MatriculaDependente.Ano.Value.ToString();
                matriculaVinculoBoletoLista.Add(matriculaVinculoBoleto);
            }
            dgvAlunosVinculados.AutoGenerateColumns = false;
            dgvAlunosVinculados.DataSource = matriculaVinculoBoletoLista;
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
                List<Aluno> alunos = new List<Aluno>();
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
                        }
                    }

                }
                foreach (ResponsavelAluno ra in listaCombo)
                {
                    alunos.Add(ra.Aluno);
                }
                if (removerAlunos)
                {
                    for (int i = 0; i < alunos.Count; i++)
                    {
                        if (VerificarMatriculaDependente(alunos[i]).Count > 0 || VerificarMatriculaMestre(alunos[i]).Count > 0)
                        {
                            alunos.RemoveAt(i);
                            i = -1;
                        }

                    }
                }

                cmbAluno.DataSource = alunos;
                cmbAluno.DisplayMember = "Nome";
                cmbAluno.ValueMember = "ID";
            }


        } 
        #endregion
 
        private void ucDesconectarLogin1_EventoDesconectar()
        {
            Program.ultimaTela = 9;
            this.Close();
            telaLogin telalogin = telaLogin.getInstancia();
            telalogin.Show();
        }

        private void telaAlunoMatriculaVinculo_Activated(object sender, EventArgs e)
        {
            List<MatriculaVinculo> matriculaVinculoListaAlunoAtualDependente = VerificarMatriculaDependente(Memoria.Instance.Aluno);
            List<MatriculaVinculo> matriculaVinculoListaAlunoAtualMestre = VerificarMatriculaMestre(Memoria.Instance.Aluno);
            if (matriculaVinculoListaAlunoAtualDependente.Count > 0)
            {
                //o aluno atual é dependente de outro aluno, logo a tela deverá ser bloqueada.
            }
            else if (matriculaVinculoListaAlunoAtualMestre.Count > 0)
            {
                CarregarCombo(true);
                //o aluno atual é Mestre de outro(s) aluno(s), logo deverá ser retirado do cmbAluno os alunos já vinculados ao aluno atual
            }
            else
            {
                CarregarCombo(false);
            }
            CarregarGrid(matriculaVinculoListaAlunoAtualMestre);

            //alunosLista é a lista que vai contar os alunos possiveis para vinculação.(lista que será exibida pelo cmbAluno)

        }

        private void ucMenuInferior1_EventoIncluir()
        {

        }

        private void ucMenuInferior1_EventoDeletar()
        {

        }

        private void ucMenuInferior1_EventoCadastrar()
        {

        }

        private void ucMenuInferior1_EventoAlterar()
        {

        }
    }
}
