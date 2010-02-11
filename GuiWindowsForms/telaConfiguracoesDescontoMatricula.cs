using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.ModuloDesconto.Processos;
using Negocios.ModuloDesconto.Constantes;
using Negocios.ModuloBasico.Enums;

namespace GuiWindowsForms
{
    public partial class telaConfiguracoesDescontoMatricula : Form
    {
        int verificaButton = 0;
        int linhaSelecionadaGrid = -1;
        Desconto desconto = null;

        List<Desconto> listaDesconto = null;

        IDescontoProcesso descontoControlador = null;

        #region SINGLETON DA TELA
        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaConfiguracoesDescontoMatricula telaconfiguracoesdesconto;

        private static bool IsShown = false;
        #endregion

        #region INSTANCIA TELA CONFIGURAÇÕES MATRICULA
        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. Evita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>

        public static telaConfiguracoesDescontoMatricula getInstancia()
        {
            if (telaconfiguracoesdesconto == null)
            {
                telaconfiguracoesdesconto = new telaConfiguracoesDescontoMatricula();
            }
            return telaconfiguracoesdesconto;
        }
        #endregion

        #region CONSTRUTOR
        /// <summary>
        /// Construtor da tela
        /// </summary>
        /// 
        public telaConfiguracoesDescontoMatricula()
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

        #region  BUTTON DESCONECTAR
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
        /// Evento para o fechamento da tela, não fecha de verdade, 
        /// só a esconde, garantindo a usabilidade da tela
        /// pelo singleton
        /// </summary>
        /// <param name="sender">Tela</param>
        /// <param name="e">Cancela seu fechamento, permite só que seja ocultada</param>

        private void telaConfiguracoesDescontoMatricula_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IsShown = false;
            this.Hide();

            Program.SelecionaForm(Program.ultimaTela);
        }
        #endregion

        #region USER CONTROLS - MENU ESQUERDA
        private void ucMenuConfiguracoesEsquerda1_EventoAbrirControleDeAcesso()
        {
            this.Hide();
            Program.ultimaTela = 10;
            telaConfiguracoesControleDeAcesso telaconfacesso = telaConfiguracoesControleDeAcesso.getInstancia();
            telaconfacesso.Show();
        }

        private void ucMenuConfiguracoesEsquerda1_Load(object sender, EventArgs e)
        {
            ucMenuConfiguracoesEsquerda1.verificaTela(telaconfiguracoesdesconto);
        }
        #endregion

        #region USER CONTROLS - MENU DIREITA
        private void ucMenuDireita1_EventoAbrirSerie()
        {

        }

        private void ucMenuDireita1_EventoAbrirAtividade()
        {
            this.Hide();
            Program.ultimaTela = 10;
            telaConfiguracoesAtividade telaconfatv = telaConfiguracoesAtividade.getInstancia();
            telaconfatv.Show();
        }

        private void ucMenuDireita1_EventoAbrirDesconto()
        {
            this.Hide();
            Program.ultimaTela = 10;
            telaConfiguracoesDescontoMatricula telaconfdesconto = telaConfiguracoesDescontoMatricula.getInstancia();
            telaconfdesconto.Show();
        }

        private void ucMenuDireita1_Load(object sender, EventArgs e)
        {
            ucMenuDireita1.verificaTela(telaconfiguracoesdesconto);
        }
        #endregion

        #region USER CONTROLS - Controle Inferior - Botões de Navegação

        private void ucAluno1_EventoVoltar()
        {
            this.Hide();

            if (Program.ultimaTela == 10)
            {
                Program.SelecionaForm(Program.ultimaTela);
            }
            else
            {
                Program.ultimaTela = 6;
                Program.SelecionaForm(Program.ultimaTela);
            }

            txtDescricao.Enabled = false;
            txtValor.Enabled = false;
            dataGridView1.Enabled = true;
            btnExcluir.Enabled = true;
            btnAlterar.Enabled = true;
            btnAdicionarDesconto.Enabled = true;

            verificaButton = 0;
        }

        #endregion

        #region LOAD
        private void telaConfiguracoesDescontoMatricula_Load(object sender, EventArgs e)
        {
            txtValor.Clear();
            txtDescricao.Clear();

            carregaForm();
            limparTela();
        }
        #endregion

        #region ERROR PROVIDER
        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }
        #endregion

        #region EVENTO INSERIR
        private void btnAdicionarDesconto_Click(object sender, EventArgs e)
        {
            txtDescricao.Focus();

            ucMenuDireita1.travaBotao(telaConfiguracoesDescontoMatricula.getInstancia(), false);
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            dataGridView1.Enabled = false;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnAdicionarDesconto.Enabled = false;
            txtDescricao.Focus();

            verificaButton = 1;

            txtDescricao.Clear();
            txtValor.Clear();

        }
        #endregion

        #region EVENTO ALTERAR ou ADICIONAR
        private void ucMenuInferior1_EventoCadastrar()
        {
            if (verificaButton == 1)
            {
                #region ADICIONAR
                desconto = new Desconto();

                try
                {
                    descontoControlador = DescontoProcesso.Instance;

                    #region VALIDA - DESCRIÇÃO

                    if (String.IsNullOrEmpty(txtDescricao.Text))
                    {
                        errorProviderTela.SetError(txtDescricao, "Informe a descrição");
                        txtDescricao.Clear();
                        return;
                    }
                    desconto.Descricao = txtDescricao.Text;

                    #endregion

                    #region VALIDA - VALOR

                    if (String.IsNullOrEmpty(txtValor.Text))
                    {
                        errorProviderTela.SetError(txtValor, "Informe o valor");
                        txtValor.Clear();
                        txtValor.Text = "";
                        return;
                    }
                    desconto.Percentual = Convert.ToDouble(txtValor.Text);

                    #endregion


                    if (verificaSeJaInserido(desconto) == false)
                    {
                        desconto.Status = 1;
                        descontoControlador.Incluir(desconto);
                        descontoControlador.Confirmar();
                        linhaSelecionadaGrid = -1;

                        MessageBox.Show(DescontoConstantes.DESCONTO_INCLUIDO, "Colégio Conhecer");
                    }
                    else
                    {
                        MessageBox.Show("O Desconto já existe na base de dados", "Colégio Conhecer");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                carregaForm();
                limparTela();

                #endregion
            }
            if (verificaButton == 2)
            {
                #region ALTERAR

                try
                {
                    desconto = new Desconto();
                    descontoControlador = DescontoProcesso.Instance;

                    #region VALIDA - DESCRIÇÃO

                    if (String.IsNullOrEmpty(txtDescricao.Text))
                    {
                        errorProviderTela.SetError(txtDescricao, "Informe a descrição");
                        txtDescricao.Clear();
                        return;
                    }
                    desconto.Descricao = txtDescricao.Text;

                    #endregion

                    #region VALIDA - VALOR

                    if (String.IsNullOrEmpty(txtValor.Text))
                    {
                        errorProviderTela.SetError(txtValor, "Informe o valor");
                        txtValor.Clear();
                        txtValor.Text = "";
                        return;
                    }
                    desconto.Percentual = Convert.ToDouble(txtValor.Text);

                    #endregion

                    desconto.Status = 1;

                    if (linhaSelecionadaGrid != -1)
                    {
                        //descontoControlador.Alterar(desconto);
                        //descontoControlador.Confirmar();
                        //carregaForm();
                        //linhaSelecionadaGrid = -1;

                        desconto.ID = listaDesconto[linhaSelecionadaGrid].ID;
                        descontoControlador.Alterar(desconto);
                        carregaForm();
                        linhaSelecionadaGrid = -1;

                        MessageBox.Show(DescontoConstantes.DESCONTO_ALTERADO, "Colégio Conhecer");
                    }
                    else
                    {
                        MessageBox.Show("Selecione um registro para alterar, caso queira inserir use o botão +", "Colégio Conhecer");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                carregaForm();
                limparTela();
                #endregion
            }

            ucMenuDireita1.travaBotao(telaConfiguracoesDescontoMatricula.getInstancia(), true);
            txtDescricao.Enabled = false;
            txtValor.Enabled = false;
            dataGridView1.Enabled = true;
            btnExcluir.Enabled = true;
            btnAlterar.Enabled = true;
            btnAdicionarDesconto.Enabled = true;

            verificaButton = 0;
        }
        #endregion

        #region EVENTO EXCLUIR
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o desconto ?", "Colégio Conhecer - Excluir Desconto", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                if (linhaSelecionadaGrid != -1)
                {
                    descontoControlador.Excluir(listaDesconto[linhaSelecionadaGrid]);
                    descontoControlador.Confirmar();
                    carregaForm();
                    linhaSelecionadaGrid = -1;
                }
                else
                {
                    MessageBox.Show("Selecione uma opção na tabela abaixo para exclusão, então pressione excluir.", "Colégio Conhecer");
                }
            }
        }
        #endregion

        #region Função para verificar se o desconto já esta cadastrado
        public bool verificaSeJaInserido(Desconto desconto)
        {
            descontoControlador = DescontoProcesso.Instance;

            List<Desconto> listaAuxiliar = new List<Desconto>();
            listaAuxiliar = descontoControlador.Consultar();

            bool testa = false;

            foreach (Desconto b in listaAuxiliar)
            {
                if ((b.Descricao == desconto.Descricao) && (b.Percentual == desconto.Percentual))
                {
                    testa = true;
                }
            }
            return testa;
        }
        #endregion

        #region Evento para limpar os campos da tela
        public void limparTela()
        {
            txtDescricao.Clear();
            txtValor.Clear();
            txtValor.Text = "";
        }
        #endregion

        #region EVENTO PARA ALIMENTAR E ATUALIZAR O DATAGRID
        private void carregaForm()
        {
            descontoControlador = DescontoProcesso.Instance;

            listaDesconto = new List<Desconto>();

            Desconto d = new Desconto();
            d.Status = (int)Status.Ativo;

            listaDesconto = descontoControlador.Consultar(d, TipoPesquisa.E);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaDesconto;
        }
        #endregion

        #region EVENTOS DO GRID

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            if (linhaSelecionadaGrid >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;

                txtDescricao.Text = listaDesconto[linhaSelecionadaGrid].Descricao;
                txtValor.Text = listaDesconto[linhaSelecionadaGrid].Percentual.ToString();
            }
            else
            {
                linhaSelecionadaGrid = -1;
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            if (linhaSelecionadaGrid >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;

                txtDescricao.Text = listaDesconto[linhaSelecionadaGrid].Descricao;
                txtValor.Text = listaDesconto[linhaSelecionadaGrid].Percentual.ToString();
            }
            else
            {
                linhaSelecionadaGrid = -1;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            if (linhaSelecionadaGrid >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;

                txtDescricao.Text = listaDesconto[linhaSelecionadaGrid].Descricao;
                txtValor.Text = listaDesconto[linhaSelecionadaGrid].Percentual.ToString();
            }
            else
            {
                linhaSelecionadaGrid = -1;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            if (linhaSelecionadaGrid >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;

                txtDescricao.Text = listaDesconto[linhaSelecionadaGrid].Descricao;
                txtValor.Text = listaDesconto[linhaSelecionadaGrid].Percentual.ToString();
            }
            else
            {
                linhaSelecionadaGrid = -1;
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            if (linhaSelecionadaGrid >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;

                txtDescricao.Text = listaDesconto[linhaSelecionadaGrid].Descricao;
                txtValor.Text = listaDesconto[linhaSelecionadaGrid].Percentual.ToString();
            }
            else
            {
                linhaSelecionadaGrid = -1;
            }
        }

        #endregion

        #region Mensagens dos botões
        private void btnExcluir_MouseEnter(object sender, EventArgs e)
        {
            ucMenuInferior1.exibirMensagem("Excluir um desconto");
        }

        private void btnExcluir_MouseLeave(object sender, EventArgs e)
        {
            ucMenuInferior1.ocultarMensagem();
        }

        private void btnAdicionarDesconto_MouseEnter(object sender, EventArgs e)
        {
            ucMenuInferior1.exibirMensagem("Adicionar um desconto");
        }

        private void btnAdicionarDesconto_MouseLeave(object sender, EventArgs e)
        {
            ucMenuInferior1.ocultarMensagem();
        }

        private void dataGridView1_MouseEnter(object sender, EventArgs e)
        {
            ucMenuInferior1.exibirMensagem("Selecione um registro para alterar ou excluir");
        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {
            ucMenuInferior1.ocultarMensagem();
        }

        private void btnAlterar_MouseEnter(object sender, EventArgs e)
        {
            ucMenuInferior1.exibirMensagem("Altera um registro já cadastrado na base de dados");
        }

        private void btnAlterar_MouseLeave(object sender, EventArgs e)
        {
            ucMenuInferior1.ocultarMensagem();
        }

        #endregion

        #region EVENTO ALTERAR
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtDescricao.Focus();

            ucMenuDireita1.travaBotao(telaConfiguracoesDescontoMatricula.getInstancia(), false);
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            dataGridView1.Enabled = false;
            btnExcluir.Enabled = false;
            btnAdicionarDesconto.Enabled = false;
            txtDescricao.Focus();
            

            verificaButton = 2;
        }
        #endregion

        private void ucDesconectarLogin1_EventoDesconectar()
        {
            Program.ultimaTela = 9;
            this.Close();
            telaLogin telalogin = telaLogin.getInstancia();
            telalogin.Show();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void telaConfiguracoesDescontoMatricula_Activated(object sender, EventArgs e)
        {
            ucMenuDireita1.verificaTela(telaConfiguracoesDescontoMatricula.getInstancia());
        }
    }        
}
