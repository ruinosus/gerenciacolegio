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
    public partial class telaLogin : Form
    {
        private static telaLogin telalogin;

        public static telaLogin getInstancia()
        {
            if (telalogin == null)
            {
                telalogin = new telaLogin();
            }
            return telalogin;
        }

        public telaLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            telaPrincipal telaPrincipal = telaPrincipal.getInstancia();
            telaPrincipal.Show();
        }

        #region Métodos que controlam a mudança de cor dos campos quando selecionados ou não

        /// <summary>
        /// Atualiza a cor da textbox ao ser ativada como controle principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLogin_Enter(object sender, EventArgs e)
        {
            txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Altera a cor para a cor original do controle ao perder a seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLogin_Leave(object sender, EventArgs e)
        {
            txtLogin.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// Atualiza a cor da textbox ao ser ativada como controle principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Altera a cor para a cor original do controle ao perder a seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSenha_Leave(object sender, EventArgs e)
        {
            txtSenha.BackColor = System.Drawing.Color.White;
        }

        #endregion
    }
}
