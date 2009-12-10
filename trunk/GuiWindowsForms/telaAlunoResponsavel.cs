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
    public partial class telaAlunoResponsavel : Form
    {

        private static telaAlunoResponsavel telaalunoresponsavel;

        public static telaAlunoResponsavel getInstancia()
        {
            if (telaalunoresponsavel == null)
            {
                telaalunoresponsavel = new telaAlunoResponsavel();
            }
            return telaalunoresponsavel;
        }

        public telaAlunoResponsavel()
        {
            InitializeComponent();
            telaAlunoPrincipal.ActiveForm.Hide();
        } 

        private void telaAlunoResponsavel_FormClosing(object sender, FormClosingEventArgs e)
        {
            telaAlunoPrincipal telaalunoprincipal = telaAlunoPrincipal.getInstancia();
            telaalunoprincipal.Show();
        }

        #region Controle de mudança das figuras e exibição dos textos das mesmas

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDados_MouseEnter(object sender, EventArgs e)
        {
            this.btnDados.BackgroundImage = global::GuiWindowsForms.Properties.Resources.dados_73x74_hover;
            lblDados_Menu.Visible = true;
        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDados_MouseLeave(object sender, EventArgs e)
        {
            this.btnDados.BackgroundImage = global::GuiWindowsForms.Properties.Resources.dados_73x74;
            lblDados_Menu.Visible = false;
        }

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResponsaveis_MouseEnter(object sender, EventArgs e)
        {
            this.btnResponsaveis.BackgroundImage = global::GuiWindowsForms.Properties.Resources.responsavel_73x66_hover;
            lblResponsavel_menu.Visible = true;
        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResponsaveis_MouseLeave(object sender, EventArgs e)
        {
            this.btnResponsaveis.BackgroundImage = global::GuiWindowsForms.Properties.Resources.responsavel_73x66;
            lblResponsavel_menu.Visible = false;
        }

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfoMedica_MouseEnter(object sender, EventArgs e)
        {
            this.btnInfoMedica.BackgroundImage = global::GuiWindowsForms.Properties.Resources.injecao_73x73_hover;
            lblMedico_menu.Visible = true;
        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfoMedica_MouseLeave(object sender, EventArgs e)
        {
            this.btnInfoMedica.BackgroundImage = global::GuiWindowsForms.Properties.Resources.injecao_73x73;
            lblMedico_menu.Visible = false;
        }

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinanceiro_MouseEnter(object sender, EventArgs e)
        {
            this.btnFinanceiro.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_73x60_hover;
            lblFinanceiro_menu.Visible = true;
        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinanceiro_MouseLeave(object sender, EventArgs e)
        {
            this.btnFinanceiro.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_73x60;
            lblFinanceiro_menu.Visible = false;
        }

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAcademico_MouseEnter(object sender, EventArgs e)
        {
            this.btnAcademico.BackgroundImage = global::GuiWindowsForms.Properties.Resources.academico_73x72_hover;
            lblAcademico_menu.Visible = true;
        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAcademico_MouseLeave(object sender, EventArgs e)
        {
            this.btnAcademico.BackgroundImage = global::GuiWindowsForms.Properties.Resources.academico_73x72;
            lblAcademico_menu.Visible = false;
        }

        #endregion

        #region Mudança de cores das textboxes e outros controles

        /// <summary>
        /// Atualiza a cor da textbox ao ser ativada como controle principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNome_Enter(object sender, EventArgs e)
        {
            txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Altera a cor para a cor original do controle ao perder a seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNome_Leave(object sender, EventArgs e)
        {
            txtNome.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// Atualiza a cor da textbox ao ser ativada como controle principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRg_Enter(object sender, EventArgs e)
        {
            txtRg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Altera a cor para a cor original do controle ao perder a seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRg_Leave(object sender, EventArgs e)
        {
            txtRg.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// Atualiza a cor da textbox ao ser ativada como controle principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProfissao_Enter(object sender, EventArgs e)
        {
            txtProfissao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Altera a cor para a cor original do controle ao perder a seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProfissao_Leave(object sender, EventArgs e)
        {
            txtProfissao.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// Atualiza a cor da textbox ao ser ativada como controle principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Altera a cor para a cor original do controle ao perder a seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            txtEmail.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// Atualiza a cor da textbox ao ser ativada como controle principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLogradouro_Enter(object sender, EventArgs e)
        {
            txtLogradouro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Altera a cor para a cor original do controle ao perder a seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLogradouro_Leave(object sender, EventArgs e)
        {
            txtLogradouro.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// Atualiza a cor da textbox ao ser ativada como controle principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mskCpf_Enter(object sender, EventArgs e)
        {
            mskCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Altera a cor para a cor original do controle ao perder a seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mskCpf_Leave(object sender, EventArgs e)
        {
            mskCpf.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// Atualiza a cor da textbox ao ser ativada como controle principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLocalTrabalho_Enter(object sender, EventArgs e)
        {
            txtLocalTrabalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Altera a cor para a cor original do controle ao perder a seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLocalTrabalho_Leave(object sender, EventArgs e)
        {
            txtLocalTrabalho.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// Atualiza a cor da textbox ao ser ativada como controle principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mskFoneTrabalho_Enter(object sender, EventArgs e)
        {
            mskFoneTrabalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Altera a cor para a cor original do controle ao perder a seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mskFoneTrabalho_Leave(object sender, EventArgs e)
        {
            mskFoneTrabalho.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// Atualiza a cor da textbox ao ser ativada como controle principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtComplemento_Enter(object sender, EventArgs e)
        {
            txtComplemento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Altera a cor para a cor original do controle ao perder a seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtComplemento_Leave(object sender, EventArgs e)
        {
            txtComplemento.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// Atualiza a cor da textbox ao ser ativada como controle principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBairro_Enter(object sender, EventArgs e)
        {
            txtBairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Altera a cor para a cor original do controle ao perder a seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBairro_Leave(object sender, EventArgs e)
        {
            txtBairro.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// Atualiza a cor da textbox ao ser ativada como controle principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCidade_Enter(object sender, EventArgs e)
        {
            txtCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Altera a cor para a cor original do controle ao perder a seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCidade_Leave(object sender, EventArgs e)
        {
            txtCidade.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// Atualiza a cor da textbox ao ser ativada como controle principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mskCep_Enter(object sender, EventArgs e)
        {
            mskCep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Altera a cor para a cor original do controle ao perder a seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mskCep_Leave(object sender, EventArgs e)
        {
            mskCep.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// Atualiza a cor da textbox ao ser ativada como controle principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mskFoneResidencia_Enter(object sender, EventArgs e)
        {
            mskFoneResidencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Altera a cor para a cor original do controle ao perder a seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mskFoneResidencia_Leave(object sender, EventArgs e)
        {
            mskFoneResidencia.BackColor = System.Drawing.Color.White;
        }
        #endregion

  

    }
}
