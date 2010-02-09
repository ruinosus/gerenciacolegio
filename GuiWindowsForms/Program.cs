using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace GuiWindowsForms
{
    static class Program
    {
        public static int ultimaTela = 9;
        public static int ultimaTelaCadastrar = 0;
        public static string usuarioLogin = null;
        public static Funcionario funcionarioAux = new Funcionario();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            VerificaExecucao();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new telaLogin());
        }

        public static void VerificaExecucao()
        {
            Process[] processos = Process.GetProcessesByName("GuiWindowsForms");

            DateTime maisNovo = DateTime.Today;

            if (processos.Length > 0)
            {
                maisNovo = processos[0].StartTime;
            }

            if (processos.Length > 1)
            {
                foreach (Process p in processos)
                {
                    if (p.StartTime > maisNovo)
                    {
                        maisNovo = p.StartTime;
                    }
                }

                foreach (Process p in processos)
                {
                    if (p.StartTime != maisNovo)
                    {
                        p.Kill();
                    }
                }
            }
        }

        public static void SelecionaForm(int formId)
        {
            if (formId == 1)
            {
                telaAluno telaalunoaux = telaAluno.getInstancia();
                telaalunoaux.Show();
            }
            else if (formId == 2)
            {
                telaAlunoAcademico telaalunoacademicoaux = telaAlunoAcademico.getInstancia();
                telaalunoacademicoaux.Show();
            }
            else if (formId == 4)
            {
                telaAlunoMatricula telaalunomatriculaaux = telaAlunoMatricula.getInstancia();
                telaalunomatriculaaux.Show();
            }
            else if (formId == 5)
            {
                telaAlunoMedicacao telaalunomedicacaoaux = telaAlunoMedicacao.getInstancia();
                telaalunomedicacaoaux.Show();
            }
            else if (formId == 6)
            {
                telaPrincipal telaalunoprincipalaux = telaPrincipal.getInstancia();
                telaalunoprincipalaux.Show();
            }
            else if (formId == 7)
            {
                telaAlunoResponsavel telaalunoresponsavelaux = telaAlunoResponsavel.getInstancia();
                telaalunoresponsavelaux.Show();
            }
            else if (formId == 8)
            {
                telaAlunoResponsavelVinculo telaalunoresponsavelbuscaaux = telaAlunoResponsavelVinculo.getInstancia();
                telaalunoresponsavelbuscaaux.Show();
            }
            else if (formId == 9)
            {
                telaLogin telaloginaux = telaLogin.getInstancia();
                telaloginaux.Show();
            }
            else if (formId == 10)
            {
                telaConfiguracoes telaconfiguracoesaux = telaConfiguracoes.getInstancia();
                telaconfiguracoesaux.Show();
            }
            else if (formId == 11)
            {
                telaConfiguracoesAtividade telaconfatividadesaux = telaConfiguracoesAtividade.getInstancia();
                telaconfatividadesaux.Show();
            }
            else if (formId == 12)
            {
                telaConfiguracoesControleDeAcesso telaconfacessoaux = telaConfiguracoesControleDeAcesso.getInstancia();
                telaconfacessoaux.Show();
            }
            else if (formId == 13)
            {
                telaConfiguracoesDescontoMatricula telaconfdescaux = telaConfiguracoesDescontoMatricula.getInstancia();
                telaconfdescaux.Show();
            }
            else if (formId == 14)
            {
                telaConfiguracoesSerie telaconfserieaux = telaConfiguracoesSerie.getInstancia();
                telaconfserieaux.Show();
            }
            else if (formId == 15)
            {
                telaAlunoMatriculaAtividade telaalunomatatvaux = telaAlunoMatriculaAtividade.getInstancia();
                telaalunomatatvaux.Show();
            }
            else if (formId == 16)
            {
                telaFinanceiro telafinanceiroaux = telaFinanceiro.getInstancia();
                telafinanceiroaux.Show();
            }
            else if (formId == 17)
            {
                telaFuncionario telafuncionarioaux = telaFuncionario.getInstancia();
                telafuncionarioaux.Show();
            }
            else if (formId == 19)
            {
                telaFuncionarioDadosProfissionais telafuncprofissionaisaux = telaFuncionarioDadosProfissionais.getInstancia();
                telafuncprofissionaisaux.Show();
            }
        }
    }
}
