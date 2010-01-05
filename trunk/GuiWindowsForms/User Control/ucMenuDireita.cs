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
        public ucMenuDireita()
        {
            InitializeComponent();
        }

        #region BUTTON SERIE
        private void btnSerie_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 10;
            telaConfiguracoesSerie telaconfserie = telaConfiguracoesSerie.getInstancia();
            telaconfserie.Show();
        }

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSerie_MouseEnter(object sender, EventArgs e)
        {
            this.btnSerie.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_serie_64x70_hover;
            lblSerie_menu.Visible = true;
        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSerie_MouseLeave(object sender, EventArgs e)
        {
            this.btnSerie.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_serie_64x70;
            lblSerie_menu.Visible = false;
        }

        #endregion

        #region BUTTON ATIVIDADE

        private void btnAtividade_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 10;
            ckbTerca telaconfatv = ckbTerca.getInstancia();
            telaconfatv.Show();
        }

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtividade_MouseEnter(object sender, EventArgs e)
        {
            this.btnAtividade.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_atividades_84x75_hover;
            lblAtividade_menu.Visible = true;

        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtividade_MouseLeave(object sender, EventArgs e)
        {
            this.btnAtividade.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_atividades_84x75;
            lblAtividade_menu.Visible = false;
        }

        #endregion

        #region BUTTON DESCONTO

        private void btnDesconto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 10;
            telaConfiguracoesDescontoMatricula telaconfdesconto = telaConfiguracoesDescontoMatricula.getInstancia();
            telaconfdesconto.Show();
        }

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesconto_MouseEnter(object sender, EventArgs e)
        {
            this.btnDesconto.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_desconto_79x80_hover;
            lblDesconto_menu.Visible = true;
        
        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesconto_MouseLeave(object sender, EventArgs e)
        {
            this.btnDesconto.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_desconto_79x80;
            lblDesconto_menu.Visible = false;
        }

        #endregion
    }
}
