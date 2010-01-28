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

        private void ucDesconectarLogin1_EventoDesconectar()
        {
            Program.ultimaTela = 9;
            this.Close();
            telaLogin telalogin = telaLogin.getInstancia();
            telalogin.Show();
        }

        private void CarregarCombo()
        {
            Memoria memoria = Memoria.Instance;
            if (memoria.Aluno != null)
            {

                IResponsavelAlunoProcesso processo = ResponsavelAlunoProcesso.Instance;
                ResponsavelAluno responsavelAluno = new ResponsavelAluno();
                responsavelAluno.AlunoID = memoria.Aluno.ID;
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
                    return ra.AlunoID == memoria.Aluno.ID;
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
                cmbAluno.DataSource = alunos;
                cmbAluno.DisplayMember = "Nome";
                cmbAluno.ValueMember = "ID";

            }


        }

        ///Metodo responsável por verificar se o Aluno atual está com vinculo dependente com outro aluno.
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

        ///Metodo responsável por verificar se o aluno atual está com vinculo mestre com outros alunos.
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


        ///Carrega a matricula atual do aluno.
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


        private void telaAlunoMatriculaVinculo_Activated(object sender, EventArgs e)
        {
            CarregarCombo();
        }

        /*
         List<MatriculaVinculo> matriculaVinculoListaAlunoAtualDependente = VerificarMatriculaDependente(memoria.Aluno); 
if(matriculaVinculoListaAlunoAtualDependente.Count > 0)
{	
	//o aluno atual é dependente de outro aluno, logo a tela deverá ser bloqueada.
}	

List<MatriculaVinculo> matriculaVinculoListaAlunoAtualMestre = VerificarMatriculaMestre(memoria.Aluno);
if(matriculaVinculoListaAlunoAtualMestre.Count > 0)
{	
	//o aluno atual é Mestre de outro(s) aluno(s), logo deverá ser retirado do cmbAluno os alunos já vinculados ao aluno atual
}
//AlunosLista é a lista que vai contar os alunos possiveis para vinculação.(lista que será exibida pelo cmbAluno)
List<MatriculaVinculo> mvlDependente;
List<MatriculaVinculo> mvlMestre;
for(int i = 0; i < AlunosLista.Count;i++;)
{
	RF003 - Boleto Bancário - Emissão Inválida Cód. Ref. BG-0911.03s
}
         
         
         */


    }
}
