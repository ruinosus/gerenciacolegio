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
    public partial class ucMenuConfiguracoesEsquerda : UserControl
    {
        public ucMenuConfiguracoesEsquerda()
        {
            InitializeComponent();
        }

        #region BUTTON PERFIS

        private void btnControledeAcesso_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 10;
            telaConfiguracoesControleDeAcesso telaconfacesso = telaConfiguracoesControleDeAcesso.getInstancia();
            telaconfacesso.Show();
        }

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnControledeAcesso_MouseEnter(object sender, EventArgs e)
        {
            this.btnControledeAcesso.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_acesso_64x80_hover;
            lblControleAcesso_menu.Visible = true;
        }


        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnControledeAcesso_MouseLeave(object sender, EventArgs e)
        {
            this.btnControledeAcesso.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_acesso_64x80;
            lblControleAcesso_menu.Visible = false;
        }

        #endregion

    }
}
