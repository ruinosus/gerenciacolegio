using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.ModuloResponsavel.Processos;
using Negocios.ModuloResponsavel.Constantes;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;

namespace GuiWindowsForms
{
    public partial class telaAlunoResponsavel : Form
    {
        Responsavel responsavel = new Responsavel();
        IResponsavelProcesso responsavelControlador = ResponsavelProcesso.Instance;
        Memoria memoria = Memoria.Instance;

        #region SINGLETON DA TELA
        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaAlunoResponsavel telaalunoresponsavel;

        private static bool IsShown = false;

        #endregion

        #region INSTANCIA TELA ALUNO RESPONSAVEL

        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso.
        /// Evita abertura de múltiplas instâncias
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
        #endregion

        #region CONSTRUTOR 
        /// <summary>
        /// Construtor da tela
        /// </summary>

        public telaAlunoResponsavel()
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

        private void telaAlunoResponsavel_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IsShown = false;
            this.Hide();

            if (Program.ultimaTela != 8)
            {
                Program.SelecionaForm(Program.ultimaTela);
            }
            else
            {
                Program.ultimaTela = 1;
                Program.SelecionaForm(Program.ultimaTela);
            }
        }
        #endregion

        #region MUDANÇA DE CORES DAS TEXTBOXES E OUTROS CONTROLES

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

        #region USER CONTROLS - Controle Inferior - Botões de Navegação

        private void ucAluno1_EventoVoltar()
        {
            this.Hide();

            if (Program.ultimaTela != 8)
            {
                Program.SelecionaForm(Program.ultimaTela);
            }
            else
            {
                Program.ultimaTela = 8;
                Program.SelecionaForm(Program.ultimaTela);
            }
        }
        
        #endregion

        #region USER CONTROLS - Controle Lateral - Botões de Navegação

        private void uMenuLateral1_EventoAbrirTelaResponsavel()
        {
            this.Hide();
            Program.ultimaTela = 1;
            telaAlunoResponsavelVinculo tela = telaAlunoResponsavelVinculo.getInstancia();
            tela.Show();
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
            uMenuLateral1.verificaTela(telaalunoresponsavel);
        }
        #endregion

        #region EVENTO CADASTRAR

        private void ucAluno1_EventoCadastrar()
        {
            try
            {
                responsavel = new Responsavel();
                responsavelControlador = ResponsavelProcesso.Instance;

                #region VALIDA - NOME

                if (String.IsNullOrEmpty(txtNome.Text))
                {
                    errorProviderTela.SetError(txtNome, "Informe o nome");
                    txtNome.Clear();
                    return;
                }
                responsavel.Nome = txtNome.Text;
              
            
                #endregion

                #region VALIDA - SEXO  

                if (rdbMasc.Checked==false && rdbFem.Checked==false)
                {
                    errorProviderTela.SetError(rdbFem, "Informe o sexo");
                    return;
                }
                if (rdbFem.Checked == true)
                {
                    responsavel.Sexo = 0;
                }
                else
                {
                    responsavel.Sexo = 1;
                }

                #endregion

                #region VALIDA - IDENTIDADE

                //if (String.IsNullOrEmpty(txtRg.Text))
                //{
                //    errorProviderTela.SetError(txtRg, "Informe a Identidade");
                //    return;
                //}
                responsavel.Rg = txtRg.Text;
              

                #endregion

                #region VALIDA - CPF

                //if (mskCpf.MaskCompleted == false)
                //{
                //    errorProviderTela.SetError(mskCpf, "Informe o cpf");
                //    return;
                //}
                responsavel.Cpf = mskCpf.Text;

                #endregion

                #region VALIDA - PROFISSÃO

                //if (String.IsNullOrEmpty(txtProfissao.Text))
                //{
                //    errorProviderTela.SetError(txtProfissao, "Informe a profissão");
                //    return;
                //}
                responsavel.Profissao = txtProfissao.Text;

                #endregion

                #region VALIDA - LOCAL DE TRABALHO

                //if (String.IsNullOrEmpty(txtLocalTrabalho.Text))
                //{
                //    errorProviderTela.SetError(txtLocalTrabalho, "Informe o local de trabalho");
                //    return;
                //}
                responsavel.LocalTrabalho = txtLocalTrabalho.Text;

                #endregion

                #region VALIDA - EMAIL

                //if (String.IsNullOrEmpty(txtEmail.Text))
                //{
                //    errorProviderTela.SetError(txtEmail, "Informe o email");
                //    return;
                //}

                //int validaArroba = 0;
                ///*O FOR pecorre todo o textBox email para validação do campo,
                // *dentro tem vários IF se o campo possuir as obrigatoriedades
                // *é incrementado, se não possuir é decrementado ao final a uma
                // *verificação se o campo for vazio ou não possuir a soma correspondedente
                // *a todos os campos que deveria incrementar é lançado o exception
                // */
                //for (int i = 0; i < txtEmail.Text.Length; i++)
                //{
                //    if (txtEmail.Text.Substring(i, 1).Equals("@"))
                //    {
                //        validaArroba++;
                //    }
                //    if (txtEmail.Text.Substring(i, 1).Equals(" "))
                //    {
                //        validaArroba--;
                //    }
                //}

                //if (validaArroba != 1 || txtEmail.Text.Equals(""))
                //{

                //    errorProviderTela.SetError(txtEmail, "Informe o email corretamente");
                //    return;

                //}
                responsavel.Email = txtEmail.Text;

                #endregion

                #region VALIDA - FONE DO TRABALHO

                //if (String.IsNullOrEmpty(mskFoneTrabalho.Text)) 
                //{
                //    errorProviderTela.SetError(mskFoneTrabalho, "Informe o fone do trabalho");
                //    return;
                //}
                responsavel.Fone = mskFoneTrabalho.Text;

                #endregion

                #region VALIDA - ENDEREÇO

                //if (String.IsNullOrEmpty(txtLogradouro.Text))
                //{
                //    errorProviderTela.SetError(txtLogradouro, "Informe o endereço");
                //    return;
                //}
                responsavel.Logradouro = txtLogradouro.Text;

                #endregion

                #region VALIDA - COMPLEMENTO

                //if (String.IsNullOrEmpty(txtComplemento.Text))
                //{
                //    errorProviderTela.SetError(txtComplemento, "Informe o endereço");
                //    return;
                //}
                responsavel.ComplementoEndereco = txtComplemento.Text;

                #endregion

                #region VALIDA - EDIFÍCIO

                //if (String.IsNullOrEmpty(txtNomeEdificil.Text))
                //{
                //    errorProviderTela.SetError(txtNomeEdificil, "Informe o edifício");
                //    return;
                //}

                #endregion

                #region VALIDA - BAIRRO

                //if (String.IsNullOrEmpty(txtBairro.Text))
                //{
                //    errorProviderTela.SetError(txtBairro, "Informe o bairro");
                //    return;
                //}
                responsavel.Bairro = txtBairro.Text;

                #endregion

                #region VALIDA - CIDADE

                //if (String.IsNullOrEmpty(txtCidade.Text))
                //{
                //    errorProviderTela.SetError(txtCidade, "Informe a cidade");
                //    return;
                //}
                responsavel.Cidade = txtCidade.Text;

                #endregion

                #region VALIDA - CEP

                //if (mskCep.MaskCompleted == false)
                //{
                //    errorProviderTela.SetError(mskCep, "Informe a cep");
                //    return;
                //}
                responsavel.Cep = mskCep.Text;

                #endregion

                #region VALIDA - FONE RESIDÊNCIA

                //if (mskFoneResidencia.MaskCompleted == false)
                //{
                //    errorProviderTela.SetError(mskFoneResidencia, "Informe o fone");
                //    return;
                //}
                responsavel.Fone = mskFoneResidencia.Text;

                #endregion

                responsavel.FoneOpcional = mskFoneOpcional.Text;
                responsavel.Uf = cmbUf.Text;
                responsavel.Nascimento = dtpNascimento.Value;
                responsavel.Edificio = txtNomeEdificil.Text;

                responsavel.PerfilID = 2;
                responsavel.Status = (int)Status.Ativo;

                //responsavel = ucMenuSuper.retornaResponsavel(responsavel);
                switch (memoria.Status)
                {
                    case StatusBanco.Inativo:
                        break;
                    case StatusBanco.Inclusao:
                        {
                            if (verificaSeJaCadastrado(responsavel) == false)
                            {
                                responsavelControlador.Incluir(responsavel);
                                responsavelControlador.Confirmar();

                                limparTela();

                                MessageBox.Show(ResponsavelConstantes.RESPONSAVEL_INCLUIDO, "Colégio Conhecer");
                                this.Hide();
                                telaAlunoResponsavelVinculo.getInstancia().Show();
                            }
                            else
                            {
                                MessageBox.Show("O Responsável já existe na base de dados", "Colégio Conhecer");
                            }
                            break;
                        }
                    case StatusBanco.Alteracao:
                        {
                            int id = memoria.Responsavel.ID;
                            memoria.Responsavel = responsavel;
                            memoria.Responsavel.ID = id;
                            responsavelControlador.Alterar(responsavel);
                            responsavelControlador.Confirmar();

                            MessageBox.Show("Responsável inserido com sucesso.", "Colégio Conhecer"); telaAlunoResponsavelVinculo.getInstancia().Show(); 
                            break;

                        }
                    case StatusBanco.Navegacao:
                        break;
                    default:
                        break;
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

        string[] estados = { "","AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" };

        #endregion

        #region LOAD
        private void telaAlunoResponsavel_Load(object sender, EventArgs e)
        {
            cmbUf.DataSource = estados;
            ucMenuSuper.ocultarBotaoAdicionarImagem();
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

        private void txtRg_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void mskCpf_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtProfissao_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtLocalTrabalho_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void mskFoneTrabalho_TextChanged(object sender, EventArgs e)
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
        #endregion

        #region LIMPAR CAMPOS

        /// <summary>
        /// Método para limpar a tela.
        /// </summary>
        public void limparTela()
        {
            txtBairro.Clear();
            txtCidade.Clear();
            txtComplemento.Clear();
            txtEmail.Clear();
            txtLocalTrabalho.Clear();
            txtLogradouro.Clear();
            txtNome.Clear();
            txtNomeEdificil.Clear();
            txtProfissao.Clear();
            txtRg.Clear();
            mskCep.Clear();
            mskCpf.Clear();
            mskFoneResidencia.Clear();
            mskFoneOpcional.Clear();
            mskFoneTrabalho.Clear();
            cmbUf.Text = "";
            rdbFem.Checked = false;
            rdbMasc.Checked = false;
            dtpNascimento.Value = DateTime.Now;
            
            ucMenuSuper.limparFigura();
        }
        #endregion

        /// <summary>
        /// Método para carregar os dados do aluno na tela
        /// </summary>
        public void carregarAlunoResponsavel()
        {
            txtNome.ReadOnly = true;
            mskCpf.ReadOnly = true;
            txtBairro.Text = responsavel.Bairro;
            txtCidade.Text = responsavel.Cidade;
            txtComplemento.Text = responsavel.ComplementoEndereco;
            txtEmail.Text = responsavel.Email;
            txtLocalTrabalho.Text = responsavel.LocalTrabalho;
            txtLogradouro.Text = responsavel.Logradouro;
            txtNome.Text = responsavel.Nome;
            txtProfissao.Text = responsavel.Profissao;
            txtRg.Text = responsavel.Rg;
            mskCep.Text = responsavel.Cep;
            mskCpf.Text = responsavel.Cpf;
            mskFoneResidencia.Text = responsavel.Fone;
            mskFoneTrabalho.Text = responsavel.FoneTrabalho;
            cmbUf.Text = responsavel.Uf;
            dtpNascimento.Text = responsavel.Nascimento.ToString();
            if (responsavel.Sexo == 0)
            {
                rdbFem.Select();
            }
            else
            {
                rdbMasc.Select();
            }
        }

        public Boolean verificaSeJaCadastrado(Responsavel responsavelAux)
        {
            bool testa = false;

            List<Responsavel> listaResponsavel = new List<Responsavel>();

            listaResponsavel = responsavelControlador.Consultar();

            foreach (Responsavel r in listaResponsavel)
            {
                if ((r.Cpf == responsavelAux.Cpf) || (r.Rg == responsavelAux.Rg))
                {
                    testa = true;
                }
            }
            return testa;
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

        private void cmbUf_MouseLeave(object sender, EventArgs e)
        {
            cmbUf.BackColor = System.Drawing.Color.White;
        }

        private void cmbUf_MouseEnter(object sender, EventArgs e)
        {
            cmbUf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        private void cmbUf_TextChanged_1(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void ucDesconectarLogin1_EventoDesconectar()
        {
            Program.ultimaTela = 9;
            this.Close();
            telaLogin telalogin = telaLogin.getInstancia();
            telalogin.Show();
        }

        private void telaAlunoResponsavel_Activated(object sender, EventArgs e)
        {
            uMenuLateral1.verificaTela(telaalunoresponsavel);
            if (memoria.Aluno != null && memoria.Responsavel != null)
            {

                cmbUf.DataSource = estados;
                ucMenuSuper.ocultarBotaoAdicionarImagem();

                ucMenuSuper.carregaAluno(memoria.Aluno);
                responsavel = memoria.Responsavel;
                carregarAlunoResponsavel();

            }
            else
            {
                limparTela();
            }
        }



    }
}
