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
        public ucMenuLateralFunc()
        {
            InitializeComponent();
        }

        #region BUTTON DADOS PESSOAIS

        private void btnDadosPessoais_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 17;
            telaFuncionario telaafuncdados = telaFuncionario.getInstancia();
            telaafuncdados.Show();
        }

        private void btnDadosPessoais_MouseEnter(object sender, EventArgs e)
        {
            this.btnDadosPessoais.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_dados_71x62_hover;
            lblDados_Menu.Visible = true;
        }

        private void btnDadosPessoais_MouseLeave(object sender, EventArgs e)
        {
            this.btnDadosPessoais.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_dados_71x62;
            lblDados_Menu.Visible = false;
        }

        #endregion

        private void btnDadosProfissionais_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 17;
            telaFuncionarioDadosProfissionais telaafuncprofissionais = telaFuncionarioDadosProfissionais.getInstancia();
            telaafuncprofissionais.Show();
        }

        private void btnDadosProfissionais_MouseEnter(object sender, EventArgs e)
        {
            this.btnDadosProfissionais.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_profissional_64x71_disabled_h;
            lblProfissionais_menu.Visible = true;
        }

        private void btnDadosProfissionais_MouseLeave(object sender, EventArgs e)
        {
            this.btnDadosProfissionais.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_profissional_64x71_disabled;
            lblProfissionais_menu.Visible = false;
        }
    }
}
