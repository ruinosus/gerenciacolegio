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
        public static Form formAux2 = null;

        public ucMenuConfiguracoesEsquerda()
        {
            InitializeComponent();
        }

        public void verificaTela(Form form)
        {
            formAux2 = form;

            if (formAux2.Equals(telaConfiguracoes.getInstancia()))
            {
                this.btnControledeAcesso.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_acesso_64x80;
                this.btnControledeAcesso.Enabled = false; //mudar para true após (botão começa true também
                lblControleAcesso_menu.Visible = true;
                lblControleAcesso_menu.ForeColor = System.Drawing.Color.Yellow;
            }
            else if (formAux2.Equals(telaConfiguracoesControleDeAcesso.getInstancia()))
            {
                this.btnControledeAcesso.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_acesso_64x80_disabled;
                this.btnControledeAcesso.Enabled = false;
                lblControleAcesso_menu.Visible = true;
                lblControleAcesso_menu.ForeColor = System.Drawing.Color.Yellow;
            }
        }

        #region BUTTON PERFIS

        public delegate void delegateAbrirTelaControleDeAcesso();
        public event delegateAbrirTelaControleDeAcesso EventoAbrirControleDeAcesso;

        private void btnControledeAcesso_Click(object sender, EventArgs e)
        {
            if (EventoAbrirControleDeAcesso != null)
                EventoAbrirControleDeAcesso(); 
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
