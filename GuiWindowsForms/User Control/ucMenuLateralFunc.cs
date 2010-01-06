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
    public partial class ucMenuLateralFunc : UserControl
    {

        public static Form formAux4 = null;

        public ucMenuLateralFunc()
        {
            InitializeComponent();
        }

        public void verificaTela(Form form)
        {
            formAux4 = form;

            if (formAux4.Equals(telaFuncionario.getInstancia()))
            {
                this.btnDadosPessoais.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_dados_71x62;
                this.btnDadosPessoais.Enabled = false;
                lblDados_Menu.Visible = true;
                lblDados_Menu.ForeColor = System.Drawing.Color.Yellow;

                this.btnDadosProfissionais.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_profissional_64x71_disabled;
                this.btnDadosProfissionais.Enabled = true;
                lblProfissionais_menu.Visible = false;
                lblProfissionais_menu.ForeColor = System.Drawing.Color.White;

            }
            else if (formAux4.Equals(telaFuncionarioDadosProfissionais.getInstancia()))
            {

                this.btnDadosProfissionais.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_profissional_64x71;
                this.btnDadosProfissionais.Enabled = false;
                lblProfissionais_menu.Visible = true;
                lblProfissionais_menu.ForeColor = System.Drawing.Color.Yellow;

                this.btnDadosPessoais.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_dados_71x62_disabled;
                this.btnDadosPessoais.Enabled = true;
                lblDados_Menu.Visible = false;
                lblDados_Menu.ForeColor = System.Drawing.Color.White;

            }
        }

        #region BUTTON DADOS PESSOAIS

        public delegate void delegateAbrirTelaDadosPessoais();
        public event delegateAbrirTelaDadosPessoais EventoAbrirDadosPessoais;

        private void btnDadosPessoais_Click(object sender, EventArgs e)
        {
            if (EventoAbrirDadosPessoais != null)
                EventoAbrirDadosPessoais(); 
        }

        private void btnDadosPessoais_MouseEnter(object sender, EventArgs e)
        {
            if (formAux4.Equals(telaFuncionario.getInstancia()))
            {
                this.btnDadosPessoais.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_dados_71x62_hover;
                lblDados_Menu.Visible = true;
            }
            else
            {
                this.btnDadosPessoais.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_dados_71x62_disabled_h;
                lblDados_Menu.Visible = true;
            }
        }

        private void btnDadosPessoais_MouseLeave(object sender, EventArgs e)
        {
            if (formAux4.Equals(telaFuncionario.getInstancia()))
            {
                this.btnDadosPessoais.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_dados_71x62;
                lblDados_Menu.Visible = false;
            }
            else
            {
                this.btnDadosPessoais.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_dados_71x62_disabled;
                lblDados_Menu.Visible = false;
            }
        }

        #endregion

        public delegate void delegateAbrirTelaDadosProfissionais();
        public event delegateAbrirTelaDadosProfissionais EventoAbrirDadosProfissionais;

        private void btnDadosProfissionais_Click(object sender, EventArgs e)
        {
            if (EventoAbrirDadosProfissionais != null)
                EventoAbrirDadosProfissionais(); 
        }

        private void btnDadosProfissionais_MouseEnter(object sender, EventArgs e)
        {
            if (formAux4.Equals(telaFuncionarioDadosProfissionais.getInstancia()))
            {
                this.btnDadosProfissionais.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_profissional_64x71_hover;
                lblProfissionais_menu.Visible = true;
            }
            else
            {
                this.btnDadosProfissionais.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_profissional_64x71_disabled_h;
                lblProfissionais_menu.Visible = true;
            }
        }

        private void btnDadosProfissionais_MouseLeave(object sender, EventArgs e)
        {
            if (formAux4.Equals(telaFuncionarioDadosProfissionais.getInstancia()))
            {
                this.btnDadosProfissionais.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_profissional_64x71;
                lblProfissionais_menu.Visible = false;
            }
            else
            {
                this.btnDadosProfissionais.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_profissional_64x71_disabled;
                lblProfissionais_menu.Visible = false;
            }
        }
    }
}
