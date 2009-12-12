using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuiWindowsForms
{
    public partial class telaAlunoAcademico : Form
    {

        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaAlunoAcademico telaalunoacademico;

        private static bool IsShown = false;

        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. Evita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>

        public static telaAlunoAcademico getInstancia()
        {
            if (telaalunoacademico == null)
            {
                telaalunoacademico = new telaAlunoAcademico();
            }
            return telaalunoacademico;
        }

        /// <summary>
        /// Construtor da tela
        /// </summary>
        
        public telaAlunoAcademico()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para verificar se a tela já esta sendo exibida ou não, avita que a tela seja descarregada da memória
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

        private Form SelecionaForm(int formId)
        {
            Form form = null;

            if (formId == 1)
            {
                telaAluno telaalunoaux = telaAluno.getInstancia();
                form = telaalunoaux;
            }
            else if (formId == 2)
            {
                telaAlunoAcademico telaalunoacademicoaux = telaAlunoAcademico.getInstancia();
                form = telaalunoacademicoaux;
            }
            else if (formId == 3)
            {
                telaAlunoMatricula telaalunomatriculaaux = telaAlunoMatricula.getInstancia();
                form = telaalunomatriculaaux;
            }
            else if (formId == 4)
            {
                telaAlunoMedicacao telaalunomedicacaoaux = telaAlunoMedicacao.getInstancia();
                form = telaalunomedicacaoaux;
            }
            else if (formId == 5)
            {
                telaAlunoPrincipal telaalunoprincipalaux = telaAlunoPrincipal.getInstancia();
                form = telaalunoprincipalaux;
            }
            else if (formId == 6)
            {
                telaAlunoResponsavel telaalunoresponsavelaux = telaAlunoResponsavel.getInstancia();
                form = telaalunoresponsavelaux;
            }
            else if (formId == 7)
            {
                telaAlunoResponsavelBusca telaalunoresponsavelbuscaaux = telaAlunoResponsavelBusca.getInstancia();
                form = telaalunoresponsavelbuscaaux;
            }
            else if (formId == 8)
            {
                telaLogin telaloginaux = telaLogin.getInstancia();
                form = telaloginaux;
            }

            return form;
        }

        /// <summary>
        /// Evento para o fechamento da tela, não fecha de verdade, só a esconde, garantindo a usabilidade da tela
        /// pelo singleton
        /// </summary>
        /// <param name="sender">Tela</param>
        /// <param name="e">Cancela seu fechamento, permite só que seja ocultada</param>

        private void telaAlunoAcademico_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IsShown = false;
            this.Hide();
        }

        #region Controle de mudança das figuras e exibição dos textos das mesmas

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void btnMatricula_MouseEnter(object sender, EventArgs e)
        {
            this.btnMatricula.BackgroundImage = global::GuiWindowsForms.Properties.Resources.matricula_68x69_hover;
            lblMatricula_menu.Visible = true;
        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void btnMatricula_MouseLeave(object sender, EventArgs e)
        {
            this.btnMatricula.BackgroundImage = global::GuiWindowsForms.Properties.Resources.matricula_68x69;
            lblMatricula_menu.Visible = false;
        }

        #endregion

    }
}
