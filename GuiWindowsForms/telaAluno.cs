using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.ModuloAluno;
using Negocios.ModuloAluno.Processos;
using Negocios.ModuloBasico.VOs;
using Negocios.ModuloAluno.Constantes;
using Negocios.ModuloBasico.Enums;

namespace GuiWindowsForms
{
    public partial class telaAluno : Form
    {

        Aluno aluno = new Aluno();
        IAlunoProcesso alunoControlador = AlunoProcesso.Instance;

        public static int verificaFoto = 0;

        //atributo para verificar se o button de Alterar foi clicado 
        int verificaButton = 0;

        #region SINGLETON DA TELA
        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaAluno telaaluno;

        private static bool IsShown = false;
        #endregion

        #region INSTANCIA TELA ALUNO
        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso.
        /// Evita abertura de múltiplas instâncias
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
        /// Método para verificar se a tela já esta sendo exibida ou não, 
        /// evita que a tela seja descarregada da memória
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
            Memoria memoria = Memoria.Instance;
            e.Cancel = true;
            IsShown = false;
            memoria.Aluno = null;
            this.Hide();

                Program.ultimaTela = 6;
                Program.SelecionaForm(Program.ultimaTela);
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
            txtNaturalidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Altera a cor para a cor original do controle ao perder a seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbNaturalidade_Leave(object sender, EventArgs e)
        {
            txtNaturalidade.BackColor = System.Drawing.Color.White;
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

        /// <summary>
        /// Atualiza a cor da textbox ao ser ativada como controle principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNomeEdificil_Enter(object sender, EventArgs e)
        {
            txtNomeEdificil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Altera a cor para a cor original do controle ao perder a seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNomeEdificil_Leave(object sender, EventArgs e)
        {
            txtNomeEdificil.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// Atualiza a cor da textbox ao ser ativada como controle principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbUf_MouseEnter(object sender, EventArgs e)
        {
            cmbUf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Altera a cor para a cor original do controle ao perder a seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbUf_MouseLeave(object sender, EventArgs e)
        {
            cmbUf.BackColor = System.Drawing.Color.White;
        }
        #endregion

        #region USER CONTROLS - Controle Inferior - Botões de Navegação

        #region EVENTO VOLTAR
        private void ucAluno1_EventoVoltar()
        {
            this.Hide();

            Program.ultimaTela = 6;
            Program.SelecionaForm(Program.ultimaTela);
        }
        #endregion

        #region ALTERAR
        private void ucMenuInferior1_EventoAlterar()
        {
            Enabled_True();
            verificaButton = 1;

        }
        #endregion

        #region EVENTO CADASTRAR

        private void ucAluno1_EventoCadastrar()
        {
            try
            {
                #region CADASTRAR ALUNO


                if (verificaButton == 0)
                {


                    aluno = new Aluno();
                    alunoControlador = AlunoProcesso.Instance;

                    #region VALIDA - NOME

                    if (String.IsNullOrEmpty(txtNome.Text))
                    {
                        errorProviderTela.SetError(txtNome, "Informe o nome");
                        txtNome.Clear();
                        return;
                    }
                    aluno.Nome = txtNome.Text;

                    #endregion

                    #region VALIDA - SEXO

                    if (rdbMasc.Checked == false && rdbFem.Checked == false)
                    {
                        errorProviderTela.SetError(rdbFem, "Informe o sexo");
                        return;
                    }
                    if (rdbMasc.Checked == true)
                    {
                        aluno.Sexo = 0;
                    }
                    else
                    {
                        aluno.Sexo = 1;
                    }

                    #endregion

                    #region VALIDA - EMAIL ALUNO

                    aluno.Email = txtEmail.Text;

                    #endregion

                    #region VALIDA - FONE DO ALUNO

                    //if (mskFoneAluno.MaskCompleted == false)
                    //{
                    //    errorProviderTela.SetError(mskFoneAluno, "Informe o fone do aluno");
                    //    mskFoneAluno.Clear();
                    //    return;
                    //}
                    aluno.FoneAluno = mskFoneAluno.Text;

                    #endregion

                    #region VALIDA - ENDEREÇO

                    //if (String.IsNullOrEmpty(txtLogradouro.Text))
                    //{
                    //    errorProviderTela.SetError(txtLogradouro, "Informe o endereço");
                    //    txtLogradouro.Clear();
                    //    return;
                    //}
                    aluno.Logradouro = txtLogradouro.Text;

                    #endregion

                    #region VALIDA - COMPLEMENTO

                    //if (String.IsNullOrEmpty(txtComplemento.Text))
                    //{
                    //    errorProviderTela.SetError(txtComplemento, "Informe o complemento");
                    //    txtComplemento.Clear();
                    //    return;
                    //}
                    aluno.ComplementoEndereco = txtComplemento.Text;

                    #endregion

                    #region VALIDA - NOME EDIFÍCIL

                    //if (String.IsNullOrEmpty(txtNomeEdificil.Text))
                    //{
                    //    errorProviderTela.SetError(txtNomeEdificil, "Informe o nome edifícil");
                    //    txtNomeEdificil.Clear();
                    //    return;
                    //}
                    aluno.Edificio = txtNomeEdificil.Text;
                    #endregion

                    #region VALIDA - BAIRRO

                    //if (String.IsNullOrEmpty(txtBairro.Text))
                    //{
                    //    errorProviderTela.SetError(txtBairro, "Informe o bairro");
                    //    txtBairro.Clear();
                    //    return;
                    //}
                    aluno.Bairro = txtBairro.Text;

                    #endregion

                    #region VALIDA - CIDADE

                    //if (String.IsNullOrEmpty(txtCidade.Text))
                    //{
                    //    errorProviderTela.SetError(txtCidade, "Informe a cidade");
                    //    txtCidade.Clear();
                    //    return;
                    //}
                    aluno.Cidade = txtCidade.Text;

                    #endregion

                    #region VALIDA - CEP

                    //if (mskCep.MaskCompleted == false)
                    //{
                    //    errorProviderTela.SetError(mskCep, "Informe o cep");
                    //    mskCep.Clear();
                    //    return;
                    //}
                    aluno.Cep = mskCep.Text;

                    #endregion

                    #region VALIDA - FONE RESIDENCIA

                    //if (mskFoneResidencia.MaskCompleted == false)
                    //{
                    //    errorProviderTela.SetError(mskFoneResidencia, "Informe o fone da residência");
                    //    mskFoneResidencia.Clear();
                    //    return;
                    //}
                    aluno.FoneResidencia = mskFoneResidencia.Text;

                    #endregion

                    #region VALIDA - RESIDE COM

                    //if (String.IsNullOrEmpty(cmbResidCom.Text))
                    //{
                    //    errorProviderTela.SetError(cmbResidCom, "Informe com quem o aluno reside");
                    //    return;
                    //}

                    #endregion

                    #region VALIDA - FONE EMERGENCIA

                    //if (mskFoneEmergencia.MaskCompleted == false)
                    //{
                    //    errorProviderTela.SetError(mskFoneEmergencia, "Informe o fone de emergência");
                    //    mskFoneEmergencia.Clear();
                    //    return;
                    //}
                    aluno.FoneEmergencia = mskFoneEmergencia.Text;

                    #endregion

                    aluno.Nascimento = dtpNascimento.Value;
                    aluno.Nacionalidade = cmbNacionalidade.Text;
                    aluno.Naturalidade = txtNaturalidade.Text;
                    aluno.Uf = cmbUf.Text;

                    /*
                     * Perfil temporário para testes, retirar quando for concluida a implementação do perfil
                     */

                    aluno.PerfilID = 1;
                    aluno.Status = (int)Status.Ativo;

                    aluno = uMenuImagem1.retornaAluno(aluno);
                    Memoria memoria = Memoria.Instance;
                    if (memoria.Aluno == null)
                    {
                        if (verificaSeJaCadastrado(aluno) == false)
                        {
                            aluno = uMenuImagem1.retornaAluno(aluno);
                            alunoControlador.Incluir(aluno);
                            alunoControlador.Confirmar();
                            uMenuImagem1.carregaAluno(aluno);

                            memoria.Aluno = aluno;
                        }

                        MessageBox.Show(AlunoConstantes.ALUNO_INCLUIDO, "Colégio Conhecer");
                    }
                    else
                    {
                        alunoControlador.Alterar(aluno);
                        uMenuImagem1.carregaAluno(aluno);

                        MessageBox.Show(AlunoConstantes.ALUNO_ALTERADO, "Colégio Conhecer");
                    }
                }
                #endregion

                #region ALTERAR ALUNO

                if (verificaButton == 1)
                {


                    alunoControlador = AlunoProcesso.Instance;

                    #region VALIDA - NOME

                    if (String.IsNullOrEmpty(txtNome.Text))
                    {
                        errorProviderTela.SetError(txtNome, "Informe o nome");
                        txtNome.Clear();
                        return;
                    }
                    aluno.Nome = txtNome.Text;

                    #endregion

                    #region VALIDA - SEXO

                    if (rdbMasc.Checked == false && rdbFem.Checked == false)
                    {
                        errorProviderTela.SetError(rdbFem, "Informe o sexo");
                        return;
                    }
                    if (rdbMasc.Checked == true)
                    {
                        aluno.Sexo = 0;
                    }
                    else
                    {
                        aluno.Sexo = 1;
                    }

                    #endregion

                    #region VALIDA - EMAIL ALUNO

                    aluno.Email = txtEmail.Text;

                    #endregion

                    #region VALIDA - FONE DO ALUNO

                    //if (mskFoneAluno.MaskCompleted == false)
                    //{
                    //    errorProviderTela.SetError(mskFoneAluno, "Informe o fone do aluno");
                    //    mskFoneAluno.Clear();
                    //    return;
                    //}
                    aluno.FoneAluno = mskFoneAluno.Text;

                    #endregion

                    #region VALIDA - ENDEREÇO

                    //if (String.IsNullOrEmpty(txtLogradouro.Text))
                    //{
                    //    errorProviderTela.SetError(txtLogradouro, "Informe o endereço");
                    //    txtLogradouro.Clear();
                    //    return;
                    //}
                    aluno.Logradouro = txtLogradouro.Text;

                    #endregion

                    #region VALIDA - COMPLEMENTO

                    //if (String.IsNullOrEmpty(txtComplemento.Text))
                    //{
                    //    errorProviderTela.SetError(txtComplemento, "Informe o complemento");
                    //    txtComplemento.Clear();
                    //    return;
                    //}
                    aluno.ComplementoEndereco = txtComplemento.Text;

                    #endregion

                    #region VALIDA - NOME EDIFÍCIL

                    //if (String.IsNullOrEmpty(txtNomeEdificil.Text))
                    //{
                    //    errorProviderTela.SetError(txtNomeEdificil, "Informe o nome edifícil");
                    //    txtNomeEdificil.Clear();
                    //    return;
                    //}
                    aluno.Edificio = txtNomeEdificil.Text;
                    #endregion

                    #region VALIDA - BAIRRO

                    //if (String.IsNullOrEmpty(txtBairro.Text))
                    //{
                    //    errorProviderTela.SetError(txtBairro, "Informe o bairro");
                    //    txtBairro.Clear();
                    //    return;
                    //}
                    aluno.Bairro = txtBairro.Text;

                    #endregion

                    #region VALIDA - CIDADE

                    //if (String.IsNullOrEmpty(txtCidade.Text))
                    //{
                    //    errorProviderTela.SetError(txtCidade, "Informe a cidade");
                    //    txtCidade.Clear();
                    //    return;
                    //}
                    aluno.Cidade = txtCidade.Text;

                    #endregion

                    #region VALIDA - CEP

                    //if (mskCep.MaskCompleted == false)
                    //{
                    //    errorProviderTela.SetError(mskCep, "Informe o cep");
                    //    mskCep.Clear();
                    //    return;
                    //}
                    aluno.Cep = mskCep.Text;

                    #endregion

                    #region VALIDA - FONE RESIDENCIA

                    //if (mskFoneResidencia.MaskCompleted == false)
                    //{
                    //    errorProviderTela.SetError(mskFoneResidencia, "Informe o fone da residência");
                    //    mskFoneResidencia.Clear();
                    //    return;
                    //}
                    aluno.FoneResidencia = mskFoneResidencia.Text;

                    #endregion

                    #region VALIDA - RESIDE COM

                    //if (String.IsNullOrEmpty(cmbResidCom.Text))
                    //{
                    //    errorProviderTela.SetError(cmbResidCom, "Informe com quem o aluno reside");
                    //    return;
                    //}

                    #endregion

                    #region VALIDA - FONE EMERGENCIA

                    //if (mskFoneEmergencia.MaskCompleted == false)
                    //{
                    //    errorProviderTela.SetError(mskFoneEmergencia, "Informe o fone de emergência");
                    //    mskFoneEmergencia.Clear();
                    //    return;
                    //}
                    aluno.FoneEmergencia = mskFoneEmergencia.Text;

                    #endregion

                    aluno.Nascimento = dtpNascimento.Value;
                    aluno.Nacionalidade = cmbNacionalidade.Text;
                    aluno.Naturalidade = txtNaturalidade.Text;
                    aluno.Uf = cmbUf.Text;

                    /*
                     * Perfil temporário para testes, retirar quando for concluida a implementação do perfil
                     */

                    aluno.PerfilID = 1;
                    aluno.Status = (int)Status.Ativo;

                    //aluno = uMenuImagem1.retornaAluno(aluno);
                    Memoria memoria = Memoria.Instance;
                    if (memoria.Aluno != null)
                    {
                        alunoControlador.Alterar(aluno);
                        MessageBox.Show(AlunoConstantes.ALUNO_ALTERADO, "Colégio Conhecer");
                        uMenuImagem1.carregaAluno(aluno);
                    }


                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Enabled_False();
            verificaButton = 0;

        }

        #endregion

        #region EVENTO EXCLUIR
        private void ucMenuInferior1_EventoDeletar()
        {
            try 
            {
                alunoControlador = AlunoProcesso.Instance;

                aluno.Status = (int)Status.Inativo;

               

                Memoria memoria = Memoria.Instance;
                if (memoria.Aluno != null)
                {
                    alunoControlador.Alterar(aluno);
                    MessageBox.Show(AlunoConstantes.ALUNO_EXCLUIDO, "Colégio Conhecer");
                }

                //Quando Excluir o aluno, a tela voltar para o menu principal
                this.Hide();

                Program.ultimaTela = 6;
                Program.SelecionaForm(Program.ultimaTela);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #endregion

        #region USER CONTROLS - Controle Lateral - Botões de Navegação

        private void uMenuLateral1_EventoAbrirTelaResponsavel()
        {
            // CHAMADA PARA TELA ALUNO RESPONSAVEL
            //this.Hide();
            //Program.ultimaTela = 7;
            //telaAlunoResponsavel telaalunoresponsavel = telaAlunoResponsavel.getInstancia();
            //telaalunoresponsavel.Show();

            this.Hide();
            Program.ultimaTela = 1;
            telaAlunoResponsavelVinculo telaalunoresponsavelbusca = telaAlunoResponsavelVinculo.getInstancia();
            Memoria.Instance.StatusTelaAlunoResponsavelBusca = OperacoesDaTela.AbrirTela;
            telaalunoresponsavelbusca.Show();

        }

        private void uMenuLateral1_EventoAbrirTelaMedica()
        {
            this.Hide();
            Program.ultimaTela = 1;
            telaAlunoMedicacao telaalunomedicacao = telaAlunoMedicacao.getInstancia();
            telaalunomedicacao.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaMatricula()
        {
            this.Hide();
            Program.ultimaTela = 1;
            telaAlunoMatricula telaalunomatricula = telaAlunoMatricula.getInstancia();
            telaalunomatricula.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaFinanceiro()
        {
            this.Hide();
            Program.ultimaTela = 1;
            telaAlunoFinanceiro telaalunofinanceiro = telaAlunoFinanceiro.getInstancia();
            telaalunofinanceiro.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaDados()
        {
            this.Hide();
            Program.ultimaTela = 1;
            telaAluno telaaluno = telaAluno.getInstancia();
            telaaluno.Show();
        }

        private void uMenuLateral1_EventoAbrirTelaAcademico()
        {
            this.Hide();
            Program.ultimaTela = 1;
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
            uMenuImagem1.limparFigura();

        }

        #endregion

        #region LIMPAR TELA
        /// <summary>
        /// Método para limpar a tela.
        /// </summary>
        public void limparTelaAluno()
        {
            txtBairro.Clear();
            txtCidade.Clear();
            txtComplemento.Clear();
            txtEmail.Clear();
            txtLogradouro.Clear();
            txtNome.Clear();
            txtNomeEdificil.Clear();
            cmbNacionalidade.SelectedIndex = 0;
            txtNaturalidade.Clear();
            cmbUf.Select();
            mskCep.Clear();
            mskCep.Text = "";
            mskFoneAluno.Clear();
            mskFoneAluno.Text = "";
            mskFoneEmergencia.Clear();
            mskFoneEmergencia.Text = "";
            mskFoneResidencia.Clear();
            mskFoneResidencia.Text = "";
            rdbFem.Checked = false;
            rdbMasc.Checked = false;
        }
        #endregion

        #region CARREGAR ALUNO NA TELA
        /// <summary>
        /// Método para carregar um aluno na tela.
        /// </summary>
        public void carregarAluno()
        {
            txtBairro.Text = aluno.Bairro;
            txtCidade.Text = aluno.Cidade;
            txtComplemento.Text = aluno.ComplementoEndereco;
            txtEmail.Text = aluno.Email;
            txtLogradouro.Text = aluno.Logradouro;
            txtNome.Text = aluno.Nome;
            cmbNacionalidade.Text = aluno.Nacionalidade;
            txtNaturalidade.Text = aluno.Naturalidade;
            cmbUf.Text = aluno.Uf;
            mskCep.Text = aluno.Cep;
            mskFoneAluno.Text = aluno.FoneAluno;
            mskFoneEmergencia.Text = aluno.FoneEmergencia;
            mskFoneResidencia.Text = aluno.FoneResidencia;
            //dtpNascimento.Value = aluno.Nascimento.Value;
            if (aluno.Sexo == 0)
            {
                rdbMasc.Select();
            }
            else
            {
                rdbFem.Select();
            }
        }
        #endregion

        #region LIMPAR ERRO PROVIDER
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void rdbMasc_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void rdbFem_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void cmbNacionalidade_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void cmbNaturalidade_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void mskFoneAluno_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtLogradouro_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtNomeEdificil_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void cmbUf_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void mskCep_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void mskFoneResidencia_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void cmbResidCom_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void mskFoneEmergencia_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }
        private void rdbFem_Click(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void rdbMasc_Click(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        #endregion

        #region METODO VERIFICA_SE_JA_CADASTRADO
        public Boolean verificaSeJaCadastrado(Aluno alunoAux)
        {
            bool testa = false;

            List<Aluno> listaAluno = new List<Aluno>();

            listaAluno = alunoControlador.Consultar();

            foreach (Aluno a in listaAluno)
            {
                if ((a.Nome == alunoAux.Nome) && (a.Nascimento == alunoAux.Nascimento))
                {
                    testa = true;
                }
            }
            return testa;
        }
        #endregion

        #region ACTIVATED
        private void telaAluno_Activated(object sender, EventArgs e)
        {
            uMenuLateral1.verificaTela(telaaluno);
            Memoria memoria = Memoria.Instance;

            if (memoria.Status == StatusBanco.Inativo)
            {
                ucMenuInferior1.apagarBotaoAlterar();
                ucMenuInferior1.apagarBotaoDeletar();
                ucMenuInferior1.apagarBotaoIncluir();

                memoria.Status = StatusBanco.Inclusao;
                if (verificaFoto == 0)
                {
                   
                    if (memoria.Aluno != null)
                    {
                        aluno = memoria.Aluno;
                        uMenuImagem1.carregaAluno(aluno);
                        carregarAluno();
                    }
                    else
                    {
                        limparTelaAluno();
                    }
                    txtNome.Focus();

                }
                else
                {
                    verificaFoto = 0;
                    uMenuImagem1.limparFigura();
                }

                //VALIDA EXIBICAO DOS BOTAO DO MENU_INFERIOR
                if (Program.ultimaTelaCadastrar == 2)
                {
                    Enabled_False();
                    ucMenuInferior1.exibirBotaoAlterar();
                    ucMenuInferior1.exibirBotaoDeletar();
                }

                if (Program.ultimaTelaCadastrar == 3)
                {
                    Enabled_False();
                    ucMenuInferior1.exibirBotaoAlterar();
                    ucMenuInferior1.exibirBotaoDeletar();
                }

                if (Program.ultimaTelaCadastrar == 1)
                {
                    Enabled_True();
                    uMenuImagem1.carregaAluno(null);
                }
                Program.ultimaTelaCadastrar = 0;
            }

        }
        #endregion

        #region SELECIONA CIDADE
        private void cmbUf_SelectedIndexChanged_1(object sender, EventArgs e)
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

        #region BUTTON VINCULAR RESPONSAVEL
        private void btnVincularResponsavel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 1;
            telaAlunoResponsavelVinculo tela = telaAlunoResponsavelVinculo.getInstancia();
            tela.Show();
        }
        #endregion 

        #region LOAD
        private void telaAluno_Load(object sender, EventArgs e)
        {
            limparTelaAluno();
            txtNome.Focus();
        }
        #endregion

        #region METODOS ENABLED

        /// <summary>
        ///  Método para Ativar a Alteração
        ///  de todos os campos de Aluno
        /// </summary>
        private void Enabled_True()
        {
            txtNome.Enabled = true;
            rdbFem.Enabled = true;
            rdbMasc.Enabled = true;
            dtpNascimento.Enabled = true;
            cmbNacionalidade.Enabled = true;
            txtNaturalidade.Enabled = true;
            txtLogradouro.Enabled = true;
            txtComplemento.Enabled = true;
            txtNomeEdificil.Enabled = true;
            txtBairro.Enabled = true;
            mskCep.Enabled = true;
            cmbUf.Enabled = true;
            txtCidade.Enabled = true;
            mskFoneAluno.Enabled = true;
            mskFoneEmergencia.Enabled = true;
            mskFoneResidencia.Enabled = true;
            txtEmail.Enabled = true;
            uMenuImagem1.Enabled = true;
        }

        /// <summary>
        ///  Método para Desativar a Alteração
        ///  de todos os campos de Aluno
        /// </summary>
        private void Enabled_False()
        {
            txtNome.Enabled = false;
            rdbFem.Enabled = false;
            rdbMasc.Enabled = false;
            dtpNascimento.Enabled = false;
            cmbNacionalidade.Enabled = false;
            txtNaturalidade.Enabled = false;
            txtLogradouro.Enabled = false;
            txtComplemento.Enabled = false;
            txtNomeEdificil.Enabled = false;
            txtBairro.Enabled = false;
            mskCep.Enabled = false;
            cmbUf.Enabled = false;
            txtCidade.Enabled = false;
            mskFoneAluno.Enabled = false;
            mskFoneEmergencia.Enabled = false;
            mskFoneResidencia.Enabled = false;
            txtEmail.Enabled = false;
            uMenuImagem1.Enabled = false;
        }

        #endregion

     
    }
}
