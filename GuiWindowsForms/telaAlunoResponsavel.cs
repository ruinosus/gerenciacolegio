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
        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaAlunoResponsavel telaalunoresponsavel;

        private static bool IsShown = false;

        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. Evita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>

        public static telaAlunoResponsavel getInstancia()
        {
            if (telaalunoresponsavel == null)
            {
                telaalunoresponsavel = new telaAlunoResponsavel();
            }
            return telaalunoresponsavel;
        }

        /// <summary>
        /// Construtor da tela
        /// </summary>

        public telaAlunoResponsavel()
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

        private Form SelecionaForm(int formId)
        {
            Form form = null;

            if (formId == 1)
            {
                telaAluno telaalunoaux = telaAluno.getInstancia();
                form = telaalunoaux;
            }
            else if (formId == 2)
            {
                telaAlunoAcademico telaalunoacademicoaux = telaAlunoAcademico.getInstancia();
                form = telaalunoacademicoaux;
            }
            else if (formId == 3)
            {
                telaAlunoMatricula telaalunomatriculaaux = telaAlunoMatricula.getInstancia();
                form = telaalunomatriculaaux;
            }
            else if (formId == 4)
            {
                telaAlunoMedicacao telaalunomedicacaoaux = telaAlunoMedicacao.getInstancia();
                form = telaalunomedicacaoaux;
            }
            else if (formId == 5)
            {
                telaAlunoPrincipal telaalunoprincipalaux = telaAlunoPrincipal.getInstancia();
                form = telaalunoprincipalaux;
            }
            else if (formId == 6)
            {
                telaAlunoResponsavel telaalunoresponsavelaux = telaAlunoResponsavel.getInstancia();
                form = telaalunoresponsavelaux;
            }
            else if (formId == 7)
            {
                telaAlunoResponsavelBusca telaalunoresponsavelbuscaaux = telaAlunoResponsavelBusca.getInstancia();
                form = telaalunoresponsavelbuscaaux;
            }
            else if (formId == 8)
            {
                telaLogin telaloginaux = telaLogin.getInstancia();
                form = telaloginaux;
            }

            return form;
        }

        /// <summary>
        /// Evento para o fechamento da tela, não fecha de verdade, só a esconde, garantindo a usabilidade da tela
        /// pelo singleton
        /// </summary>
        /// <param name="sender">Tela</param>
        /// <param name="e">Cancela seu fechamento, permite só que seja ocultada</param>

        private void telaAlunoResponsavel_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IsShown = false;
            this.Hide();

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

        /// <summary>
        /// Quando o mouse entra sobre a área da figura, sua imagem é substituida e a label é exibida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMatricula_MouseEnter(object sender, EventArgs e)
        {
            this.btnMatricula.BackgroundImage = global::GuiWindowsForms.Properties.Resources.matricula_68x69_hover;
            lblMatricula_menu.Visible = true;
        }

        /// <summary>
        /// Quando o mouse sai da área da figura, sua imagem é substituida pela original e a label é ocultada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMatricula_MouseLeave(object sender, EventArgs e)
        {
            this.btnMatricula.BackgroundImage = global::GuiWindowsForms.Properties.Resources.matricula_68x69;
            lblMatricula_menu.Visible = false;
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

        /// <summary>
        /// Fecha a tela ativa e exibe a tela de responsáveis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnDados_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaAluno telaaluno = telaAluno.getInstancia();
            telaaluno.Show();
        }

        private void btnMatricula_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaAlunoMatricula telaalunomatricula = telaAlunoMatricula.getInstancia();
            telaalunomatricula.Show();
        }

        private void btnInfoMedica_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaAlunoMedicacao telaalunomedicacao = telaAlunoMedicacao.getInstancia();
            telaalunomedicacao.Show();
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //telaAlunoMedicacao telaalunomedicacao = telaAlunoMedicacao.getInstancia();
            //telaalunomedicacao.Show();
        }

        private void btnAcademico_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaAlunoAcademico telaalunoacademico = telaAlunoAcademico.getInstancia();
            telaalunoacademico.Show();
        }
    }
}
