﻿using System;
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

namespace GuiWindowsForms
{
    public partial class telaAluno : Form
    {

        public static Aluno aluno = new Aluno();
        IAlunoProcesso alunoControlador = AlunoProcesso.Instance;

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
            Memoria memoria = Memoria.Instance;
            e.Cancel = true;
            IsShown = false;
            memoria.Aluno = null;
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
                aluno.Naturalidade = cmbNaturalidade.Text;
                aluno.Uf = cmbUf.Text;
                
                /*
                 * Perfil temporário para testes, retirar quando for concluida a implementação do perfil
                 */

                aluno.PerfilID = 1;

                aluno = uMenuImagem1.retornaAluno(aluno);
                Memoria memoria = Memoria.Instance;
                if (memoria.Aluno == null)
                {
                    alunoControlador.Incluir(aluno);
                    alunoControlador.Confirmar();

                    MessageBox.Show(AlunoConstantes.ALUNO_INCLUIDO, "Colégio Conhecer - Cadastrar Aluno");
                }
                else
                {
                    alunoControlador.Alterar(aluno);

                    MessageBox.Show(AlunoConstantes.ALUNO_ALTERADO, "Colégio Conhecer - Alterar Aluno");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            limparTela();
            cmbUf.DataSource = estados;
            //aluno.ID = 7;
            //aluno = alunoControlador.Consultar(aluno, Negocios.ModuloBasico.Enums.TipoPesquisa.E)[0];
            //uMenuImagem1.carregaAluno(aluno);
            //carregarAluno();
        }

        #endregion

        #region LIMPAR TELA
        /// <summary>
        /// Método para limpar a tela.
        /// </summary>
        private void limparTela()
        {
            txtBairro.Clear();
            txtCidade.Clear();
            txtComplemento.Clear();
            txtEmail.Clear();
            txtLogradouro.Clear();
            txtNome.Clear();
            txtNomeEdificil.Clear();
            cmbNacionalidade.Select();
            cmbNaturalidade.Select();
            cmbSelecionarAluno.Select();
            cmbUf.Select();
            mskCep.Clear();
            mskFoneAluno.Clear();
            mskFoneEmergencia.Clear();
            mskFoneResidencia.Clear();
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
            cmbNaturalidade.Text = aluno.Naturalidade;
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

        private void telaAluno_Activated(object sender, EventArgs e)
        {
            Memoria memoria = Memoria.Instance;
            if (memoria.Aluno != null)
            {
                aluno = memoria.Aluno;
                uMenuImagem1.carregaAluno(aluno);
                carregarAluno();
            }
        }

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






    }
}
