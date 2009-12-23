﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuiWindowsForms
{
    public partial class telaAlunoMatriculaAtividade : Form
    {

        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaAlunoMatriculaAtividade telaalunomatriculatividade;

        private static bool IsShown = false;

        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. Evita abertura de múltiplas instâncias
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

        /// <summary>
        /// Construtor da tela
        /// </summary>

        public telaAlunoMatriculaAtividade()
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

        /// <summary>
        /// Evento para o fechamento da tela, não fecha de verdade, só a esconde, garantindo a usabilidade da tela
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

        #region Controle de mudança das figuras e exibição dos textos das mesmas

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDados_MouseEnter(object sender, EventArgs e)
        {
            this.btnDados.BackgroundImage = global::GuiWindowsForms.Properties.Resources.dados_73x74_disabled_h;
            lblDados_Menu.Visible = true;
        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDados_MouseLeave(object sender, EventArgs e)
        {
            this.btnDados.BackgroundImage = global::GuiWindowsForms.Properties.Resources.dados_73x74_disabled;
            lblDados_Menu.Visible = false;
        }

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResponsaveis_MouseEnter(object sender, EventArgs e)
        {
            this.btnResponsaveis.BackgroundImage = global::GuiWindowsForms.Properties.Resources.responsavel_73x66_disabled_h;
            lblResponsavel_menu.Visible = true;
        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResponsaveis_MouseLeave(object sender, EventArgs e)
        {
            this.btnResponsaveis.BackgroundImage = global::GuiWindowsForms.Properties.Resources.responsavel_73x66_disabled;
            lblResponsavel_menu.Visible = false;
        }

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfoMedica_MouseEnter(object sender, EventArgs e)
        {
            this.btnInfoMedica.BackgroundImage = global::GuiWindowsForms.Properties.Resources.injecao_73x73_disabled_h;
            lblMedico_menu.Visible = true;
        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfoMedica_MouseLeave(object sender, EventArgs e)
        {
            this.btnInfoMedica.BackgroundImage = global::GuiWindowsForms.Properties.Resources.injecao_73x73_disabled;
            lblMedico_menu.Visible = false;
        }

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinanceiro_MouseEnter(object sender, EventArgs e)
        {
            this.btnFinanceiro.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_73x60_disabled_h;
            lblFinanceiro_menu.Visible = true;
        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinanceiro_MouseLeave(object sender, EventArgs e)
        {
            this.btnFinanceiro.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_73x60_disabled;
            lblFinanceiro_menu.Visible = false;
        }

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAcademico_MouseEnter(object sender, EventArgs e)
        {
            this.btnAcademico.BackgroundImage = global::GuiWindowsForms.Properties.Resources.academico_73x72_disabled_h;
            lblAcademico_menu.Visible = true;
        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAcademico_MouseLeave(object sender, EventArgs e)
        {
            this.btnAcademico.BackgroundImage = global::GuiWindowsForms.Properties.Resources.academico_73x72_disabled;
            lblAcademico_menu.Visible = false;
        }

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMatricula_MouseEnter(object sender, EventArgs e)
        {
            this.btnMatricula.BackgroundImage = global::GuiWindowsForms.Properties.Resources.matricula_68x69_disabled_h;
            lblMatricula_menu.Visible = true;
        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMatricula_MouseLeave(object sender, EventArgs e)
        {
            this.btnMatricula.BackgroundImage = global::GuiWindowsForms.Properties.Resources.matricula_68x69_disabled;
            lblMatricula_menu.Visible = false;
        }

        #endregion

        #region Botoes do menu de navegação

        /// <summary>
        /// Fecha a tela ativa e exibe a tela de dados gerais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnDados_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 4;
            telaAluno telaaluno = telaAluno.getInstancia();
            telaaluno.Show();
        }

        /// <summary>
        /// Fecha a tela ativa e exibe a tela de matricula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnMatricula_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 4;
            telaAlunoMatricula telaalunomatricula = telaAlunoMatricula.getInstancia();
            telaalunomatricula.Show();
        }

        /// <summary>
        /// Fecha a tela ativa e exibe a tela de matricula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnResponsaveis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 4;
            telaAlunoResponsavel telaalunoresponsavel = telaAlunoResponsavel.getInstancia();
            telaalunoresponsavel.Show();
        }

        /// <summary>
        /// Fecha a tela ativa e exibe a tela de dados médicos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnInfoMedica_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 4;
            telaAlunoMedicacao telaalunomedicacao = telaAlunoMedicacao.getInstancia();
            telaalunomedicacao.Show();
        }

        /// <summary>
        /// Fecha a tela ativa e exibe a tela de dados financeiros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 4;
            telaAlunoFinanceiro telaalunofinanceiro = telaAlunoFinanceiro.getInstancia();
            telaalunofinanceiro.Show();
        }

        /// <summary>
        /// Fecha a tela ativa e exibe a tela de dados academicos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAcademico_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 4;
            telaAlunoAcademico telaalunoacademico = telaAlunoAcademico.getInstancia();
            telaalunoacademico.Show();
        }

        #endregion

        #region Controle dos textos e das ações dos botões de ação inferiores

        /// <summary>
        /// Exibe o texto referente ao controle quando o mouse passa sobre ele
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnVoltar_MouseEnter(object sender, EventArgs e)
        {
            lblInfoControles.Visible = true;
            lblInfoControles.Text = "Voltar";
        }

        /// <summary>
        /// Oculta o texto referente ao controle quando o mouse passa sobre ele
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnVoltar_MouseLeave(object sender, EventArgs e)
        {
            lblInfoControles.Visible = false;
        }

        /// <summary>
        /// Oculta o texto referente ao controle quando o mouse passa sobre ele
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnSalvar_MouseLeave(object sender, EventArgs e)
        {
            lblInfoControles.Visible = false;
        }

        /// <summary>
        /// Exibe o texto referente ao controle quando o mouse passa sobre ele
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnSalvar_MouseEnter(object sender, EventArgs e)
        {
            lblInfoControles.Visible = true;
            lblInfoControles.Text = "Salvar Informações";
        }

        /// <summary>
        /// Retorna para tela anterior ocultando a atual e chamando a instância da última tela acessada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Program.ultimaTela = 4;
            Program.SelecionaForm(Program.ultimaTela);
        }

        #endregion

        private void btnMatriculaSerie_MouseEnter(object sender, EventArgs e)
        {
            this.btnMatriculaSerie.BackgroundImage = global::GuiWindowsForms.Properties.Resources.add_matricula_47x49_hover;
            lblInfoControles.Text = "Matricular um aluno.";
            lblInfoControles.Visible = true;
        }

        private void btnMatriculaSerie_MouseLeave(object sender, EventArgs e)
        {
            this.btnMatriculaSerie.BackgroundImage = global::GuiWindowsForms.Properties.Resources.add_matricula_47x49;
            lblInfoControles.Visible = false;
        }

        private void btnMatriculaSerie_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 6;
            telaAlunoMatricula telaalunomatricula = telaAlunoMatricula.getInstancia();
            telaalunomatricula.Show();

        }
    }
}
