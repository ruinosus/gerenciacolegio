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
    public partial class telaAluno : Form
    {
        #region SINGLETON DA TELA
        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaAluno telaaluno;

        private static bool IsShown = false;
        #endregion

        #region INSTANCIA TELA ALUNO RESPONSAVEL
        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. Evita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>
        
        public static telaAluno getInstancia()
        {
            if (telaaluno == null)
            {
                telaaluno = new telaAluno();
            }
            return telaaluno;
        }
        #endregion

        #region CONSTRUTOR
        /// <summary>
        /// Construtor da tela
        /// </summary>
        
        public telaAluno()
        {
            InitializeComponent();
        }
        #endregion

        #region MÉTODO PARA VERIFICAR USO DA TELA
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
        #endregion

        #region BUTTON DESCONECTAR
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
        #endregion

        #region MÉTODO PARA FECHAR A TELA
        /// <summary>
        /// Evento para o fechamento da tela, não fecha de verdade, só a esconde, 
        /// garantindo a usabilidade da tela
        /// pelo singleton
        /// </summary>
        /// <param name="sender">Tela</param>
        /// <param name="e">Cancela seu fechamento, permite só que seja ocultada</param>

        private void telaAluno_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IsShown = false;
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


        /// <summary>
        /// Atualiza a cor da textbox ao ser ativada como controle principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbNacionalidade_Enter(object sender, EventArgs e)
        {
            cmbNacionalidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Altera a cor para a cor original do controle ao perder a seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbNacionalidade_Leave(object sender, EventArgs e)
        {
            cmbNacionalidade.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// Atualiza a cor da textbox ao ser ativada como controle principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbNaturalidade_Enter(object sender, EventArgs e)
        {
            cmbNaturalidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Altera a cor para a cor original do controle ao perder a seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbNaturalidade_Leave(object sender, EventArgs e)
        {
            cmbNaturalidade.BackColor = System.Drawing.Color.White;
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
        private void mskFoneAluno_Enter(object sender, EventArgs e)
        {
            mskFoneAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Altera a cor para a cor original do controle ao perder a seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mskFoneAluno_Leave(object sender, EventArgs e)
        {
            mskFoneAluno.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// Atualiza a cor da textbox ao ser ativada como controle principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbUf_Enter(object sender, EventArgs e)
        {
            cmbUf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Altera a cor para a cor original do controle ao perder a seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbUf_Leave(object sender, EventArgs e)
        {
            cmbUf.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// Atualiza a cor da textbox ao ser ativada como controle principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbResidCom_Enter(object sender, EventArgs e)
        {
            cmbResidCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Altera a cor para a cor original do controle ao perder a seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbResidCom_Leave(object sender, EventArgs e)
        {
            cmbResidCom.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// Atualiza a cor da textbox ao ser ativada como controle principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mskFoneEmergencia_Enter(object sender, EventArgs e)
        {
            mskFoneEmergencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Altera a cor para a cor original do controle ao perder a seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mskFoneEmergencia_Leave(object sender, EventArgs e)
        {
            mskFoneEmergencia.BackColor = System.Drawing.Color.White;
        }
        #endregion

        //private void btnVincularResponsavel_MouseEnter(object sender, EventArgs e)
        //{
        //    lblInfoControles.Visible = true;
        //    lblInfoControles.Text = "Vincular responsáveis ao aluno";
        //}

        //private void btnVincularResponsavel_MouseLeave(object sender, EventArgs e)
        //{
        //    lblInfoControles.Visible = false;
        //}

        #region USER CONTROLS - Controle Inferior - Botões de Navegação

        private void ucAluno1_EventoVoltar()
        {
            this.Hide();

            if (Program.ultimaTela == 7)
            {
                Program.SelecionaForm(Program.ultimaTela);
            }
            else
            {
                Program.ultimaTela = 6;
                Program.SelecionaForm(Program.ultimaTela);
            }
        }

        #endregion

        #region USER CONTROLS - Controle Lateral - Botões de Navegação

        private void uMenuLateral1_EventoAbrirTelaResponsavel()
        {
            this.Hide();
            Program.ultimaTela = 7;
            telaAlunoResponsavel telaalunoresponsavel = telaAlunoResponsavel.getInstancia();
            telaalunoresponsavel.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaMedica()
        {
            this.Hide();
            Program.ultimaTela = 7;
            telaAlunoMedicacao telaalunomedicacao = telaAlunoMedicacao.getInstancia();
            telaalunomedicacao.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaMatricula()
        {
            this.Hide();
            Program.ultimaTela = 7;
            telaAlunoMatricula telaalunomatricula = telaAlunoMatricula.getInstancia();
            telaalunomatricula.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaFinanceiro()
        {
            this.Hide();
            Program.ultimaTela = 7;
            telaAlunoFinanceiro telaalunofinanceiro = telaAlunoFinanceiro.getInstancia();
            telaalunofinanceiro.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaDados()
        {
            this.Hide();
            Program.ultimaTela = 7;
            telaAluno telaaluno = telaAluno.getInstancia();
            telaaluno.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaAcademico()
        {
            this.Hide();
            Program.ultimaTela = 7;
            telaAlunoAcademico telaalunoacademico = telaAlunoAcademico.getInstancia();
            telaalunoacademico.Show();
        }

        #endregion

        #region USER CONTROLS - Menu Lateral
        private void uMenuLateral1_Load(object sender, EventArgs e)
        {
            uMenuLateral1.verificaTela(telaaluno);
        }
        #endregion

        #region EVENTO CADASTRAR

        private void ucAluno1_EventoCadastrar()
        {
            try
            {
                #region VALIDA - NOME

                if (String.IsNullOrEmpty(txtNome.Text))
                {
                    errorProviderTela.SetError(txtNome, "Informe o nome");
                    txtNome.Clear();
                    return;
                }

                #endregion

                #region VALIDA - SEXO

                if (rdbMasc.Checked == false && rdbFem.Checked == false)
                {
                    errorProviderTela.SetError(rdbFem, "Informe o sexo");
                    return;
                }

                #endregion

                #region VALIDA - EMAIL ALUNO

                if (String.IsNullOrEmpty(txtEmail.Text))
                {
                    errorProviderTela.SetError(txtEmail, "Informe o email");
                    return;
                }

                int validaArroba = 0;
                /*O FOR pecorre todo o textBox email para validação do campo,
                 *dentro tem vários IF se o campo possuir as obrigatoriedades
                 *é incrementado, se não possuir é decrementado ao final a uma
                 *verificação se o campo for vazio ou não possuir a soma correspondedente
                 *a todos os campos que deveria incrementar é lançado o exception
                 */
                for (int i = 0; i < txtEmail.Text.Length; i++)
                {
                    if (txtEmail.Text.Substring(i, 1).Equals("@"))
                    {
                        validaArroba++;
                    }
                    if (txtEmail.Text.Substring(i, 1).Equals(" "))
                    {
                        validaArroba--;
                    }
                }

                if (validaArroba != 1 || txtEmail.Text.Equals(""))
                {

                    errorProviderTela.SetError(txtEmail, "Informe o email corretamente");
                    return;

                }

                #endregion

                #region VALIDA - FONE DO ALUNO

                if (mskFoneAluno.MaskCompleted == false)
                {
                    errorProviderTela.SetError(mskFoneAluno, "Informe o fone do aluno");
                    mskFoneAluno.Clear();
                    return;
                }

                #endregion

                #region VALIDA - ENDEREÇO

                if (String.IsNullOrEmpty(txtLogradouro.Text))
                {
                    errorProviderTela.SetError(txtLogradouro, "Informe o endereço");
                    txtLogradouro.Clear();
                    return;
                }

                #endregion

                #region VALIDA - COMPLEMENTO

                if (String.IsNullOrEmpty(txtComplemento.Text))
                {
                    errorProviderTela.SetError(txtComplemento, "Informe o complemento");
                    txtComplemento.Clear();
                    return;
                }

                #endregion

                #region VALIDA - NOME EDIFÍCIL

                if (String.IsNullOrEmpty(txtNomeEdificil.Text))
                {
                    errorProviderTela.SetError(txtNomeEdificil, "Informe o nome edifícil");
                    txtNomeEdificil.Clear();
                    return;
                }

                #endregion 

                #region VALIDA - BAIRRO

                if (String.IsNullOrEmpty(txtBairro.Text))
                {
                    errorProviderTela.SetError(txtBairro, "Informe o bairro");
                    txtBairro.Clear();
                    return;
                }

                #endregion 

                #region VALIDA - CIDADE

                if (String.IsNullOrEmpty(txtCidade.Text))
                {
                    errorProviderTela.SetError(txtCidade, "Informe a cidade");
                    txtCidade.Clear();
                    return;
                }

                #endregion

                #region VALIDA - CEP

                if (mskCep.MaskCompleted == false)
                {
                    errorProviderTela.SetError(mskCep, "Informe o cep");
                    mskCep.Clear();
                    return;
                }

                #endregion
        
                #region VALIDA - FONE RESIDENCIA

                if (mskFoneResidencia.MaskCompleted == false)
                {
                    errorProviderTela.SetError(mskFoneResidencia, "Informe o fone da residência");
                    mskFoneResidencia.Clear();
                    return;
                }

                #endregion

                #region VALIDA - RESIDE COM

                if (String.IsNullOrEmpty(cmbResidCom.Text))
                {
                    errorProviderTela.SetError(cmbResidCom, "Informe com quem o aluno reside");
                    return;
                }

                #endregion

                #region VALIDA - FONE EMERGENCIA

                if (mskFoneEmergencia.MaskCompleted == false)
                {
                    errorProviderTela.SetError(mskFoneEmergencia, "Informe o fone de emergência");
                    mskFoneEmergencia.Clear();
                    return;
                }

                #endregion
            }
            catch (Exception ex)
            { 
            
            }
        }

        #endregion

        #region TEXTBOX UF EVENTO SELECTED
        // Quando selecionar a UF o campo CIDADE é selecionado a capital correspondente
        private void cmbUf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUf.Text == "") { txtCidade.Text = ""; }
            if (cmbUf.Text == "AC") { txtCidade.Text = "RIO BRANCO"; }
            if (cmbUf.Text == "AL") { txtCidade.Text = "MACEIO"; }
            if (cmbUf.Text == "AM") { txtCidade.Text = "MANAUS"; }
            if (cmbUf.Text == "AP") { txtCidade.Text = "MACAPÁ"; }
            if (cmbUf.Text == "BA") { txtCidade.Text = "SALVADOR"; }
            if (cmbUf.Text == "CE") { txtCidade.Text = "FORTALEZA"; }
            if (cmbUf.Text == "DF") { txtCidade.Text = "BRASÍLIA"; }
            if (cmbUf.Text == "ES") { txtCidade.Text = "VITÓRIA"; }
            if (cmbUf.Text == "GO") { txtCidade.Text = "GOIÂNIA"; }
            if (cmbUf.Text == "MA") { txtCidade.Text = "SÃO LUIZ"; }
            if (cmbUf.Text == "MG") { txtCidade.Text = "BELO HORIZONTE"; }
            if (cmbUf.Text == "MS") { txtCidade.Text = "CAMPO GRANDE"; }
            if (cmbUf.Text == "MT") { txtCidade.Text = "CUIABÁ"; }
            if (cmbUf.Text == "PA") { txtCidade.Text = "BELÉM"; }
            if (cmbUf.Text == "PB") { txtCidade.Text = "JOÃO PESSOA"; }
            if (cmbUf.Text == "PE") { txtCidade.Text = "RECIFE"; }
            if (cmbUf.Text == "PI") { txtCidade.Text = "TEREZINA"; }
            if (cmbUf.Text == "PR") { txtCidade.Text = "PARANÁ"; }
            if (cmbUf.Text == "RJ") { txtCidade.Text = "RIO DE JANEIRO"; }
            if (cmbUf.Text == "RN") { txtCidade.Text = "NATAL"; }
            if (cmbUf.Text == "RO") { txtCidade.Text = "PORTO VELHO"; }
            if (cmbUf.Text == "RR") { txtCidade.Text = "BOA VISTA"; }
            if (cmbUf.Text == "RS") { txtCidade.Text = "PORTO ALEFRE"; }
            if (cmbUf.Text == "SC") { txtCidade.Text = "FLORIANÓPOLIS"; }
            if (cmbUf.Text == "SE") { txtCidade.Text = "ARACAJÚ"; }
            if (cmbUf.Text == "SP") { txtCidade.Text = "SÃO PAULO"; }
            if (cmbUf.Text == "TO") { txtCidade.Text = "PALMAS"; }
        }

        #endregion

        #region STRING PARA ALIMENTAR COMBOBOX

        string[] estados = { "", "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" };

        #endregion

        #region LOAD
        private void uMenuImagem1_Load(object sender, EventArgs e)
        {
            cmbUf.DataSource = estados;
        }

        #endregion

    }
}
