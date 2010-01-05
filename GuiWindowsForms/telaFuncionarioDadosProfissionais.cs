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
    public partial class telaFuncionarioDadosProfissionais : Form
    {

        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaFuncionarioDadosProfissionais teladfuncProfissional;

        private static bool IsShown = false;

        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. Evita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>

        public static telaFuncionarioDadosProfissionais getInstancia()
        {
            if (teladfuncProfissional == null)
            {
                teladfuncProfissional = new telaFuncionarioDadosProfissionais();
            }
            return teladfuncProfissional;
        }

        /// <summary>
        /// Construtor da tela
        /// </summary>

        public telaFuncionarioDadosProfissionais()
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

        private void telaFuncionarioDadosProfissionais_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IsShown = false;
            this.Hide();

            Program.ultimaTela = 17;
            Program.SelecionaForm(Program.ultimaTela);
        }

        #region Controle dos textos e das ações dos botões de ação inferiores



        ///// <summary>
        ///// Retorna para tela anterior ocultando a atual e chamando a instância da última tela acessada
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>

        //private void btnVoltar_Click(object sender, EventArgs e)
        //{
        //    this.Hide();

        //    Program.ultimaTela = 17;
        //    Program.SelecionaForm(Program.ultimaTela);
        //}

        #endregion

        #region Controle das ações dos botões de navegação

        private void btnDadosPessoais_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 17;
            telaFuncionario telaafuncdados = telaFuncionario.getInstancia();
            telaafuncdados.Show();
        }

        private void btnDadosProfissionais_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 17;
            telaFuncionarioDadosProfissionais telaafuncprofissionais = telaFuncionarioDadosProfissionais.getInstancia();
            telaafuncprofissionais.Show();
        }

        #endregion

        //private void btnImprimir_MouseEnter(object sender, EventArgs e)
        //{
        //    lblInfoControles.Text = "Abrir impressões.";
        //    lblInfoControles.Visible = true;
        //    this.btnImprimir.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_imprimir_50x50_hover;
        //}

        private void btnImprimir_MouseLeave(object sender, EventArgs e)
        {
            //lblInfoControles.Visible = false;
            this.btnImprimir.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_imprimir_50x50;
        }

        private void ucMenuInferior1_EventoVoltar()
        {
            this.Hide();

            if (Program.ultimaTela != 7)
            {
                Program.SelecionaForm(Program.ultimaTela);
            }
            else
            {
                Program.ultimaTela = 6;
                Program.SelecionaForm(Program.ultimaTela);
            }
        }
    }
}
