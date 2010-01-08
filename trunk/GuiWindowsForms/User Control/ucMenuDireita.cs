using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuiWindowsForms.User_Control
{
    public partial class ucMenuDireita : UserControl
    {
        public static Form formAux3 = null;

        public ucMenuDireita()
        {
            InitializeComponent();
        }

        public void verificaTela(Form form)
        {
            formAux3 = form;

            if (formAux3.Equals(telaConfiguracoes.getInstancia()))
            {
                this.btnAtividade.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_atividades_84x75;
                this.btnAtividade.Enabled = true;
                lblAtividade_menu.Visible = true;
                lblAtividade_menu.ForeColor = System.Drawing.Color.Yellow;

                this.btnDesconto.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_desconto_79x80;
                this.btnDesconto.Enabled = true;
                lblDesconto_menu.Visible = true;
                lblDesconto_menu.ForeColor = System.Drawing.Color.Yellow;

                this.btnSerie.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_serie_64x70;
                this.btnSerie.Enabled = true;
                lblSerie_menu.Visible = true;
                lblSerie_menu.ForeColor = System.Drawing.Color.Yellow;
            }
            else if (formAux3.Equals(telaConfiguracoesControleDeAcesso.getInstancia()))
            {
                this.btnAtividade.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_atividades_84x75_disabled;
                this.btnAtividade.Enabled = true;
                lblAtividade_menu.Visible = false;
                lblAtividade_menu.ForeColor = System.Drawing.Color.White;

                this.btnDesconto.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_desconto_79x80_disabled;
                this.btnDesconto.Enabled = true;
                lblDesconto_menu.Visible = false;
                lblDesconto_menu.ForeColor = System.Drawing.Color.White;

                this.btnSerie.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_serie_64x70_disabled;
                this.btnSerie.Enabled = true;
                lblSerie_menu.Visible = false;
                lblSerie_menu.ForeColor = System.Drawing.Color.White;
            }
            else if (formAux3.Equals(telaConfiguracoesDescontoMatricula.getInstancia()))
            {
                this.btnAtividade.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_atividades_84x75_disabled;
                this.btnAtividade.Enabled = true;
                lblAtividade_menu.Visible = false;
                lblAtividade_menu.ForeColor = System.Drawing.Color.White;

                this.btnDesconto.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_desconto_79x80;
                this.btnDesconto.Enabled = false;
                lblDesconto_menu.Visible = true;
                lblDesconto_menu.ForeColor = System.Drawing.Color.Yellow;

                this.btnSerie.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_serie_64x70_disabled;
                this.btnSerie.Enabled = true;
                lblSerie_menu.Visible = false;
                lblSerie_menu.ForeColor = System.Drawing.Color.White;
            }
            else if (formAux3.Equals(telaConfiguracoesSerie.getInstancia()))
            {
                this.btnAtividade.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_atividades_84x75_disabled;
                this.btnAtividade.Enabled = true;
                lblAtividade_menu.Visible = false;
                lblAtividade_menu.ForeColor = System.Drawing.Color.White;

                this.btnDesconto.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_desconto_79x80_disabled;
                this.btnDesconto.Enabled = true;
                lblDesconto_menu.Visible = false;
                lblDesconto_menu.ForeColor = System.Drawing.Color.White;

                this.btnSerie.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_serie_64x70;
                this.btnSerie.Enabled = false;
                lblSerie_menu.Visible = true;
                lblSerie_menu.ForeColor = System.Drawing.Color.Yellow;
            }
            else if (formAux3.Equals(telaConfiguracoesAtividade.getInstancia()))
            {
                this.btnAtividade.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_atividades_84x75;
                this.btnAtividade.Enabled = false;
                lblAtividade_menu.Visible = true;
                lblAtividade_menu.ForeColor = System.Drawing.Color.Yellow;

                this.btnDesconto.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_desconto_79x80_disabled;
                this.btnDesconto.Enabled = true;
                lblDesconto_menu.Visible = false;
                lblDesconto_menu.ForeColor = System.Drawing.Color.White;

                this.btnSerie.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_serie_64x70_disabled;
                this.btnSerie.Enabled = true;
                lblSerie_menu.Visible = false;
                lblSerie_menu.ForeColor = System.Drawing.Color.White;
            }
        }

        #region BUTTON SERIE

        public delegate void delegateAbrirTelaSerie();
        public event delegateAbrirTelaSerie EventoAbrirSerie;

        private void btnSerie_Click(object sender, EventArgs e)
        {
            if (EventoAbrirSerie != null)
                EventoAbrirSerie(); 
        }

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSerie_MouseEnter(object sender, EventArgs e)
        {
            if (formAux3.Equals(telaConfiguracoes.getInstancia()))
            {
                this.btnSerie.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_serie_64x70_hover;
                this.btnSerie.Enabled = true;
                lblSerie_menu.Visible = true;
                lblSerie_menu.ForeColor = System.Drawing.Color.Yellow;
            }
            else
            {
                this.btnSerie.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_serie_64x70_disabled_h;
                lblSerie_menu.Visible = true;
            }
        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSerie_MouseLeave(object sender, EventArgs e)
        {
            if (formAux3.Equals(telaConfiguracoes.getInstancia()))
            {
                this.btnSerie.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_serie_64x70;
                lblSerie_menu.Visible = false;
            }
            else
            {
                this.btnSerie.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_serie_64x70_disabled;
                lblSerie_menu.Visible = false;
            }
        }

        #endregion

        #region BUTTON ATIVIDADE

        public delegate void delegateAbrirTelaAtividade();
        public event delegateAbrirTelaAtividade EventoAbrirAtividade;

        private void btnAtividade_Click(object sender, EventArgs e)
        {
            if (EventoAbrirAtividade != null)
                EventoAbrirAtividade();
        }

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtividade_MouseEnter(object sender, EventArgs e)
        {
            if (formAux3.Equals(telaConfiguracoes.getInstancia()))
            {
                this.btnAtividade.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_atividades_84x75_hover;
                this.btnAtividade.Enabled = true;
                lblAtividade_menu.Visible = true;
                lblAtividade_menu.ForeColor = System.Drawing.Color.Yellow;
            }
            else
            {
                this.btnAtividade.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_atividades_84x75_disabled_h;
                lblAtividade_menu.Visible = true;
            }

        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtividade_MouseLeave(object sender, EventArgs e)
        {
            if (formAux3.Equals(telaConfiguracoes.getInstancia()))
            {
                this.btnAtividade.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_atividades_84x75;
                lblAtividade_menu.Visible = false;
            }
            else
            {
                this.btnAtividade.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_atividades_84x75_disabled;
                lblAtividade_menu.Visible = false;
            }
        }

        #endregion

        #region BUTTON DESCONTO

        public delegate void delegateAbrirTelaDesconto();
        public event delegateAbrirTelaDesconto EventoAbrirDesconto;

        private void btnDesconto_Click(object sender, EventArgs e)
        {
            if (EventoAbrirDesconto != null)
                EventoAbrirDesconto(); 
        }

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesconto_MouseEnter(object sender, EventArgs e)
        {
            if (formAux3.Equals(telaConfiguracoes.getInstancia()))
            {
                this.btnDesconto.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_desconto_79x80_hover;
                this.btnDesconto.Enabled = true;
                lblDesconto_menu.Visible = true;
                lblDesconto_menu.ForeColor = System.Drawing.Color.Yellow;
            }
            else
            {
                this.btnDesconto.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_desconto_79x80_disabled_h;
                lblDesconto_menu.Visible = true;
            }
        
        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesconto_MouseLeave(object sender, EventArgs e)
        {
            if (formAux3.Equals(telaConfiguracoes.getInstancia()))
            {
                this.btnDesconto.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_desconto_79x80;
                lblDesconto_menu.Visible = false;
            }
            else
            {
                this.btnDesconto.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_desconto_79x80_disabled;
                lblDesconto_menu.Visible = false;
            }
        }

        #endregion
    }
}
