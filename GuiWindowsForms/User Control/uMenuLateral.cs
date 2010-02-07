using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.ModuloBasico.VOs;

namespace GuiWindowsForms.User_Control
{

    public partial class uMenuLateral : UserControl
    {
        public static Form formAux = null;

        public uMenuLateral()
        {
            InitializeComponent();
        }

        #region Botoes do menu de navegação

        /// <summary>
        /// Fecha a tela ativa e exibe a tela de dados gerais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        public delegate void delegateAbrirTelaDados();
        public event delegateAbrirTelaDados EventoAbrirTelaDados;

        private void btnDados_Click(object sender, EventArgs e)
        {
            if (EventoAbrirTelaDados != null)
                EventoAbrirTelaDados();
        }

        /// <summary>
        /// Fecha a tela ativa e exibe a tela de matricula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        public delegate void delegateAbrirTelaMatricula();
        public event delegateAbrirTelaMatricula EventoAbrirTelaMatricula;

        private void btnMatricula_Click(object sender, EventArgs e)
        {
            Memoria memoria = Memoria.Instance;
            if (memoria.Aluno != null)
            {
                if (EventoAbrirTelaMatricula != null)
                    EventoAbrirTelaMatricula();
            }
            else
            {
                MessageBox.Show("Só é possivel acessar matrícula com um aluno em uso a ser matriculado, cadastre ou selecione um aluno para então matriculá-lo.");
            }

        }

        /// <summary>
        /// Fecha a tela ativa e exibe a tela de dados médicos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        public delegate void delegateAbrirTelaMedica();
        public event delegateAbrirTelaMedica EventoAbrirTelaMedica;

        private void btnInfoMedica_Click(object sender, EventArgs e)
        {
            Memoria memoria = Memoria.Instance;
            if (memoria.Aluno != null)
            {
                if (EventoAbrirTelaMedica != null)
                    EventoAbrirTelaMedica();
            }
            else
            {
                MessageBox.Show("Só é possivel acessar informações médicas com um aluno cadastrado, cadastre ou selecione um aluno para modificar suas informações médicas.");
            }

        }

        /// <summary>
        /// Fecha a tela ativa e exibe a tela de dados financeiros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        public delegate void delegateAbrirTelaFinanceiro();
        public event delegateAbrirTelaFinanceiro EventoAbrirTelaFinanceiro;

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            if (EventoAbrirTelaFinanceiro != null)
                EventoAbrirTelaFinanceiro();
        }

        /// <summary>
        /// Fecha a tela ativa e exibe a tela de dados academicos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        public delegate void delegateAbrirTelaAcademico();
        public event delegateAbrirTelaAcademico EventoAbrirTelaAcademico;

        private void btnAcademico_Click(object sender, EventArgs e)
        {
            if (EventoAbrirTelaAcademico != null)
                EventoAbrirTelaAcademico();
        }

        /// <summary>
        /// Fecha a tela ativa e exibe a tela de dados academicos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        public delegate void delegateAbrirTelaResponsavel();
        public event delegateAbrirTelaResponsavel EventoAbrirTelaResponsavel;

        private void btnResponsaveis_Click(object sender, EventArgs e)
        {
            Memoria memoria = Memoria.Instance;
            if (memoria.Aluno != null)
            {
                if (EventoAbrirTelaResponsavel != null)
                    EventoAbrirTelaResponsavel();
            }
            else
            {
                MessageBox.Show("Só é possivel acessar informações dos responsáveis com um aluno cadastrado, cadastre ou selecione um aluno para modificar suas informações médicas.");
            }
        }

        public void verificaTela(Form form)
        {
            formAux = form;

            if (formAux.Equals(telaAluno.getInstancia()))
            {
                controlaBotoesMenu(telaAluno.getInstancia());
                this.btnDados.BackgroundImage = global::GuiWindowsForms.Properties.Resources.dados_73x74;
                this.btnDados.Enabled = false;
                lblDados_Menu.Visible = true;
                lblDados_Menu.ForeColor = System.Drawing.Color.Yellow;
            }
            else if (formAux.Equals(telaAlunoResponsavel.getInstancia()) || formAux.Equals(telaAlunoResponsavelVinculo.getInstancia()))
            {
                controlaBotoesMenu(telaAlunoResponsavel.getInstancia());
                this.btnResponsaveis.BackgroundImage = global::GuiWindowsForms.Properties.Resources.responsavel_73x66;
                this.btnResponsaveis.Enabled = false;
                lblResponsavel_menu.Visible = true;
                lblResponsavel_menu.ForeColor = System.Drawing.Color.Yellow;
            }
            else if (formAux.Equals(telaAlunoMedicacao.getInstancia()))
            {
                controlaBotoesMenu(telaAlunoMedicacao.getInstancia());
                this.btnInfoMedica.BackgroundImage = global::GuiWindowsForms.Properties.Resources.injecao_73x73;
                this.btnInfoMedica.Enabled = false;
                lblMedico_menu.Visible = true;
                lblMedico_menu.ForeColor = System.Drawing.Color.Yellow;
            }
            else if (formAux.Equals(telaAlunoFinanceiro.getInstancia()))
            {
                controlaBotoesMenu(telaAlunoFinanceiro.getInstancia());
                this.btnFinanceiro.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_73x60;
                this.btnFinanceiro.Enabled = false;
                lblFinanceiro_menu.Visible = true;
                lblFinanceiro_menu.ForeColor = System.Drawing.Color.Yellow;
            }
            else if (formAux.Equals(telaAlunoAcademico.getInstancia()))
            {
                controlaBotoesMenu(telaAlunoAcademico.getInstancia());
                this.btnAcademico.BackgroundImage = global::GuiWindowsForms.Properties.Resources.academico_73x72;
                this.btnAcademico.Enabled = false;
                lblAcademico_menu.Visible = true;
                lblAcademico_menu.ForeColor = System.Drawing.Color.Yellow;
            }
            else if (formAux.Equals(telaAlunoMatricula.getInstancia()) || formAux.Equals(telaAlunoMatriculaAtividade.getInstancia()))
            {
                controlaBotoesMenu(telaAlunoMatricula.getInstancia());
                this.btnMatricula.BackgroundImage = global::GuiWindowsForms.Properties.Resources.matricula_68x69;
                this.btnMatricula.Enabled = false;
                lblMatricula_menu.Visible = true;
                lblMatricula_menu.ForeColor = System.Drawing.Color.Yellow;
            }
        }

        public void controlaBotoesMenu(Form form)
        {
            if (formAux.Equals(telaAluno.getInstancia()))
            {
                this.btnAcademico.Enabled = false;
                this.btnFinanceiro.Enabled = true;
                this.btnInfoMedica.Enabled = true;
                this.btnMatricula.Enabled = true;
                this.btnResponsaveis.Enabled = true;

                this.btnResponsaveis.BackgroundImage = global::GuiWindowsForms.Properties.Resources.responsavel_73x66_disabled;
                this.btnInfoMedica.BackgroundImage = global::GuiWindowsForms.Properties.Resources.injecao_73x73_disabled;
                this.btnFinanceiro.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_73x60_disabled;
                this.btnAcademico.BackgroundImage = global::GuiWindowsForms.Properties.Resources.academico_73x72_disabled;
                this.btnMatricula.BackgroundImage = global::GuiWindowsForms.Properties.Resources.matricula_68x69_disabled;
            }
            else if (formAux.Equals(telaAlunoResponsavel.getInstancia()))
            {
                this.btnAcademico.Enabled = false;
                this.btnFinanceiro.Enabled = true;
                this.btnInfoMedica.Enabled = true;
                this.btnMatricula.Enabled = true;
                this.btnDados.Enabled = true;

                this.btnDados.BackgroundImage = global::GuiWindowsForms.Properties.Resources.dados_73x74_disabled;
                this.btnInfoMedica.BackgroundImage = global::GuiWindowsForms.Properties.Resources.injecao_73x73_disabled;
                this.btnFinanceiro.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_73x60_disabled;
                this.btnAcademico.BackgroundImage = global::GuiWindowsForms.Properties.Resources.academico_73x72_disabled;
                this.btnMatricula.BackgroundImage = global::GuiWindowsForms.Properties.Resources.matricula_68x69_disabled;
            }
            else if (formAux.Equals(telaAlunoMedicacao.getInstancia()))
            {
                this.btnAcademico.Enabled = false;
                this.btnFinanceiro.Enabled = true;
                this.btnResponsaveis.Enabled = true;
                this.btnMatricula.Enabled = true;
                this.btnDados.Enabled = true;

                this.btnDados.BackgroundImage = global::GuiWindowsForms.Properties.Resources.dados_73x74_disabled;
                this.btnFinanceiro.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_73x60_disabled;
                this.btnResponsaveis.BackgroundImage = global::GuiWindowsForms.Properties.Resources.responsavel_73x66_disabled;
                this.btnAcademico.BackgroundImage = global::GuiWindowsForms.Properties.Resources.academico_73x72_disabled;
                this.btnMatricula.BackgroundImage = global::GuiWindowsForms.Properties.Resources.matricula_68x69_disabled;
            }
            else if (formAux.Equals(telaAlunoFinanceiro.getInstancia()))
            {
                this.btnAcademico.Enabled = false;
                this.btnMatricula.Enabled = true;
                this.btnResponsaveis.Enabled = true;
                this.btnMatricula.Enabled = true;
                this.btnDados.Enabled = true;

                this.btnDados.BackgroundImage = global::GuiWindowsForms.Properties.Resources.dados_73x74_disabled;
                this.btnResponsaveis.BackgroundImage = global::GuiWindowsForms.Properties.Resources.responsavel_73x66_disabled;
                this.btnInfoMedica.BackgroundImage = global::GuiWindowsForms.Properties.Resources.injecao_73x73_disabled;
                this.btnAcademico.BackgroundImage = global::GuiWindowsForms.Properties.Resources.academico_73x72_disabled;
                this.btnMatricula.BackgroundImage = global::GuiWindowsForms.Properties.Resources.matricula_68x69_disabled;
            }
            else if (formAux.Equals(telaAlunoAcademico.getInstancia()))
            {
                this.btnFinanceiro.Enabled = true;
                this.btnMatricula.Enabled = true;
                this.btnResponsaveis.Enabled = true;
                this.btnMatricula.Enabled = true;
                this.btnDados.Enabled = true;

                this.btnDados.BackgroundImage = global::GuiWindowsForms.Properties.Resources.dados_73x74_disabled;
                this.btnResponsaveis.BackgroundImage = global::GuiWindowsForms.Properties.Resources.responsavel_73x66_disabled;
                this.btnInfoMedica.BackgroundImage = global::GuiWindowsForms.Properties.Resources.injecao_73x73_disabled;
                this.btnFinanceiro.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_73x60_disabled;
                this.btnMatricula.BackgroundImage = global::GuiWindowsForms.Properties.Resources.matricula_68x69_disabled;
            }
            else if (formAux.Equals(telaAlunoMatricula.getInstancia()) || formAux.Equals(telaAlunoMatriculaAtividade.getInstancia()))
            {
                this.btnFinanceiro.Enabled = true;
                this.btnAcademico.Enabled = false;
                this.btnResponsaveis.Enabled = true;
                this.btnMatricula.Enabled = true;
                this.btnDados.Enabled = true;

                this.btnDados.BackgroundImage = global::GuiWindowsForms.Properties.Resources.dados_73x74_disabled;
                this.btnResponsaveis.BackgroundImage = global::GuiWindowsForms.Properties.Resources.responsavel_73x66_disabled;
                this.btnInfoMedica.BackgroundImage = global::GuiWindowsForms.Properties.Resources.injecao_73x73_disabled;
                this.btnFinanceiro.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_73x60_disabled;
                this.btnAcademico.BackgroundImage = global::GuiWindowsForms.Properties.Resources.academico_73x72_disabled;
            }

        }

        #endregion

        #region Controle de mudança das figuras e exibição dos textos das mesmas

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDados_MouseEnter(object sender, EventArgs e)
        {
            if (formAux.Equals(telaAluno.getInstancia()))
            {
                this.btnDados.BackgroundImage = global::GuiWindowsForms.Properties.Resources.dados_73x74;
                this.btnDados.Enabled = false;
                lblDados_Menu.Visible = true;
                lblDados_Menu.ForeColor = System.Drawing.Color.Yellow;
            }
            else
            {
                this.btnDados.BackgroundImage = global::GuiWindowsForms.Properties.Resources.dados_73x74_disabled_h;
                lblDados_Menu.Visible = true;

            }
        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDados_MouseLeave(object sender, EventArgs e)
        {
            if (formAux.Equals(telaAluno.getInstancia()))
            {
                this.btnDados.BackgroundImage = global::GuiWindowsForms.Properties.Resources.dados_73x74_hover;
                lblDados_Menu.Visible = false;
                this.btnDados.Enabled = true;
            }
            else
            {
                this.btnDados.BackgroundImage = global::GuiWindowsForms.Properties.Resources.dados_73x74_disabled;
                lblDados_Menu.Visible = false;
                this.btnDados.Enabled = true;
            }
        }

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResponsaveis_MouseEnter(object sender, EventArgs e)
        {
            if (formAux.Equals(telaAlunoResponsavel.getInstancia()))
            {
                this.btnResponsaveis.BackgroundImage = global::GuiWindowsForms.Properties.Resources.responsavel_73x66;
                this.btnResponsaveis.Enabled = false;
                lblResponsavel_menu.Visible = true;
                lblResponsavel_menu.ForeColor = System.Drawing.Color.Yellow;
            }
            else
            {
                this.btnResponsaveis.BackgroundImage = global::GuiWindowsForms.Properties.Resources.responsavel_73x66_disabled_h;
                lblResponsavel_menu.Visible = true;
            }
        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResponsaveis_MouseLeave(object sender, EventArgs e)
        {
            if (formAux.Equals(telaAlunoResponsavel.getInstancia()))
            {
                this.btnResponsaveis.BackgroundImage = global::GuiWindowsForms.Properties.Resources.responsavel_73x66_hover;
                this.btnResponsaveis.Enabled = true;
            }
            else
            {
                this.btnResponsaveis.BackgroundImage = global::GuiWindowsForms.Properties.Resources.responsavel_73x66_disabled;
                lblResponsavel_menu.Visible = false;
                this.btnResponsaveis.Enabled = true;
            }
        }

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfoMedica_MouseEnter(object sender, EventArgs e)
        {
            if (formAux.Equals(telaAlunoMedicacao.getInstancia()))
            {
                this.btnInfoMedica.BackgroundImage = global::GuiWindowsForms.Properties.Resources.injecao_73x73;
                this.btnInfoMedica.Enabled = false;
                lblMedico_menu.Visible = true;
                lblMedico_menu.ForeColor = System.Drawing.Color.Yellow;
            }
            else
            {
                this.btnInfoMedica.BackgroundImage = global::GuiWindowsForms.Properties.Resources.injecao_73x73_disabled_h;
                lblMedico_menu.Visible = true;
            }
        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfoMedica_MouseLeave(object sender, EventArgs e)
        {
            if (formAux.Equals(telaAlunoMedicacao.getInstancia()))
            {
                this.btnInfoMedica.BackgroundImage = global::GuiWindowsForms.Properties.Resources.injecao_73x73_hover;
                this.btnInfoMedica.Enabled = true;
            }
            else
            {
                this.btnInfoMedica.BackgroundImage = global::GuiWindowsForms.Properties.Resources.injecao_73x73_disabled;
                lblMedico_menu.Visible = false;
                this.btnInfoMedica.Enabled = true;
            }
        }

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinanceiro_MouseEnter(object sender, EventArgs e)
        {
            if (formAux.Equals(telaAlunoFinanceiro.getInstancia()))
            {
                this.btnFinanceiro.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_73x60;
                this.btnFinanceiro.Enabled = false;
                lblFinanceiro_menu.Visible = true;
                lblFinanceiro_menu.ForeColor = System.Drawing.Color.Yellow;
            }
            else
            {
                this.btnFinanceiro.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_73x60_disabled_h;
                lblFinanceiro_menu.Visible = true;
            }
        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinanceiro_MouseLeave(object sender, EventArgs e)
        {
            if (formAux.Equals(telaAlunoFinanceiro.getInstancia()))
            {
                this.btnFinanceiro.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_73x60_hover;
                this.btnFinanceiro.Enabled = true;
            }
            else
            {
                this.btnFinanceiro.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_73x60_disabled;
                lblFinanceiro_menu.Visible = false;
                this.btnFinanceiro.Enabled = true;
            }
        }

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAcademico_MouseEnter(object sender, EventArgs e)
        {
            if (formAux.Equals(telaAlunoAcademico.getInstancia()))
            {
                this.btnAcademico.BackgroundImage = global::GuiWindowsForms.Properties.Resources.academico_73x72;
                this.btnAcademico.Enabled = false;
                lblAcademico_menu.Visible = true;
                lblAcademico_menu.ForeColor = System.Drawing.Color.Yellow;
            }
            else
            {
                this.btnAcademico.BackgroundImage = global::GuiWindowsForms.Properties.Resources.academico_73x72_disabled_h;
                lblAcademico_menu.Visible = true;
            }
        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAcademico_MouseLeave(object sender, EventArgs e)
        {
            if (formAux.Equals(telaAlunoAcademico.getInstancia()))
            {
                this.btnAcademico.BackgroundImage = global::GuiWindowsForms.Properties.Resources.academico_73x72_hover;
                this.btnAcademico.Enabled = true;
            }
            else
            {
                this.btnAcademico.BackgroundImage = global::GuiWindowsForms.Properties.Resources.academico_73x72_disabled;
                lblAcademico_menu.Visible = false;
                this.btnAcademico.Enabled = true;
            }
        }

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMatricula_MouseEnter(object sender, EventArgs e)
        {
            if (formAux.Equals(telaAlunoMatricula.getInstancia()) || formAux.Equals(telaAlunoMatriculaAtividade.getInstancia()))
            {
                this.btnMatricula.BackgroundImage = global::GuiWindowsForms.Properties.Resources.matricula_68x69;
                this.btnMatricula.Enabled = false;
                lblMatricula_menu.Visible = true;
                lblMatricula_menu.ForeColor = System.Drawing.Color.Yellow;
            }
            else
            {
                this.btnMatricula.BackgroundImage = global::GuiWindowsForms.Properties.Resources.matricula_68x69_disabled_h;
                lblMatricula_menu.Visible = true;
            }
        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMatricula_MouseLeave(object sender, EventArgs e)
        {
            if (formAux.Equals(telaAlunoMatricula.getInstancia()) || formAux.Equals(telaAlunoMatriculaAtividade.getInstancia()))
            {
                this.btnMatricula.BackgroundImage = global::GuiWindowsForms.Properties.Resources.matricula_68x69_hover;
                this.btnMatricula.Enabled = true;
            }
            else
            {
                this.btnMatricula.BackgroundImage = global::GuiWindowsForms.Properties.Resources.matricula_68x69_disabled;
                lblMatricula_menu.Visible = false;
                this.btnMatricula.Enabled = true;
            }
        }

        #endregion

    }
}
