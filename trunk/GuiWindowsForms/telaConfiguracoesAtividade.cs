using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloAtividade.Processos;
using Negocios.ModuloAtividade.Constantes;

namespace GuiWindowsForms
{
    public partial class telaConfiguracoesAtividade : Form
    {
        // Declarações em uso ao longo da tela

        #region DECLARAÇÕES, COLEÇÕES, VARIÁVEIS E CONSTANTES

        //Variável auxiliar para verificar a abertura da tela de seleção de foto
        int verificaTelaImagem = 0;

        //Variável para verificar qual o estado da tela para habilitação e seleção
        int verificaEstadoTela = 0;

        //Variável para identificar a linha selecionada no grid
        int linhaSelecionadaGrid = -1;

        /*
         * atividade - para cadastro, alteração e exclusão das atividades
         * atividadeAux - para uso em situações temporárias como carga da imagem da foto
         * */
         Atividade atividade = null;
         Atividade atividadeAux = new Atividade();

        //Controlador do repositório de atividades
        IAtividadeProcesso atividadeControlador = null;

        //Lista auxiliar para operar a alteração, exclusão e seleção das atividades no Grid
        List<Atividade> listaAtividade = new List<Atividade>();

        #endregion

        // Métodos de controle da tela, user controls e form load

        #region MÉTODOS INICIAS DA TELA

        #region SINGLETON DA TELA
        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaConfiguracoesAtividade telaConfiguracoesAtividades;

        private static bool IsShown = false;
        #endregion

        #region INSTANCIA TELA CONFIGURACOES ATIVIDADES
        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. 
        /// Evita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>

        public static telaConfiguracoesAtividade getInstancia()
        {
            if (telaConfiguracoesAtividades == null)
            {
                telaConfiguracoesAtividades = new telaConfiguracoesAtividade();
            }
            return telaConfiguracoesAtividades;
        }
        #endregion

        #region CONSTRUTOR
        /// <summary>
        /// Construtor da tela
        /// </summary>

        public telaConfiguracoesAtividade()
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

        private void ucDesconectarLogin1_EventoDesconectar()
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

        private void telaConfiguracoesAtividade_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IsShown = false;
            this.Hide();
            Program.SelecionaForm(Program.ultimaTela);
        }
        #endregion

        #endregion

        #region USER CONTROLS

        #region USER CONTROLS - MENU CONFIGURAÇÕES ESQUERDA
        private void ucMenuConfiguracoesEsquerda1_EventoAbrirControleDeAcesso()
        {
            this.Hide();
            Program.ultimaTela = 10;
            telaConfiguracoesControleDeAcesso telaconfacesso = telaConfiguracoesControleDeAcesso.getInstancia();
            telaconfacesso.Show();
        }

        #endregion

        #region USER CONTROLS - MENU CONFIGURAÇÕES DIREITA
        private void ucMenuDireita1_EventoAbrirSerie()
        {
            this.Hide();
            Program.ultimaTela = 10;
            telaConfiguracoesSerie telaconfserie = telaConfiguracoesSerie.getInstancia();
            telaconfserie.Show();
        }

        private void ucMenuDireita1_EventoAbrirAtividade()
        {
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
            ucMenuDireita1.verificaTela(telaConfiguracoesAtividade.getInstancia());
        }
        #endregion

        #region USER CONTROLS MENU CONTROLE INFERIOR

        private void ucMenuInferior1_EventoVoltar()
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

            verificaEstadoTela = (int)OperacoesDaTela.VoltarTela;

            controladorPaisagemTela(verificaEstadoTela, verificaTelaImagem);
        }

        #endregion

        #endregion
        
        #region LOAD DA TELA
        private void telaConfiguracoesAtividade_Activated(object sender, EventArgs e)
        {
            ucMenuDireita1.verificaTela(telaConfiguracoesAtividade.getInstancia());
            carregaDataGrid1();

            if (verificaTelaImagem == 0)
            {
                verificaEstadoTela = (int)OperacoesDaTela.AbrirTela;

                controladorPaisagemTela(verificaEstadoTela, verificaTelaImagem);
            }
        }
        #endregion

        /* Métodos operacionais de seleção dos botões, atribuição, cadastro e afins
         * bem como métodos complementares operacionais para o controle das atividades
         * da tela
         * */

        #region ADICIONAR IMAGEM

        /// <summary>
        /// Função que converte de um array de byte para uma imagem
        /// </summary>
        /// <param name="imagem"></param>
        /// <returns></returns>
        private Image arrayParaImagem(Byte[] imagem)
        {
            MemoryStream ms = new MemoryStream(imagem, 0, imagem.Length);

            if (imagem.Length > 0)
                ms.Write(imagem, 0, imagem.Length);
            return Image.FromStream(ms, true);
        }

        /// <summary>
        /// Função que converte de uma imagem para um array de byte
        /// </summary>
        /// <param name="imagem"></param>
        /// <returns></returns>
        private byte[] imagemParaArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();

            if (imageIn != null)
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        /// <summary>
        /// Função que retorna a imagem e chama a caixa de diálogo para associação.
        /// </summary>
        /// <returns></returns>
        private Image retornarImagem()
        {
            Bitmap imagem = null;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (openFileDialog1.OpenFile() != null)
                    {
                        imagem = new Bitmap(new Bitmap(openFileDialog1.OpenFile()));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                openFileDialog1.Dispose();
            }
            else
            {
                openFileDialog1.Dispose();
            }

            return imagem;
        }

        /// <summary>
        /// Ação para adicionar a imagem ao controle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdicionarImagem_Click(object sender, EventArgs e)
        {
            verificaTelaImagem = 1;
            pctImagemAtividade.SizeMode = PictureBoxSizeMode.StretchImage;

            pctImagemAtividade.Image = retornarImagem();

            if (pctImagemAtividade.Image != null)
            {
                atividadeAux.Imagem = imagemParaArray(pctImagemAtividade.Image);
            }
        }

        #endregion

        #region BOTÕES DE OPERAÇÃO PARA CADASTRO, ALTERAÇÃO, EXCLUSÃO E CONFIRMAR TRANSAÇÕES

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir a atividade ?", "Colégio Conhecer - Excluir Atividade", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                if (linhaSelecionadaGrid != -1)
                {
                    atividadeControlador.Excluir(listaAtividade[linhaSelecionadaGrid]);
                    atividadeControlador.Confirmar();
                    carregaDataGrid1();
                    linhaSelecionadaGrid = -1;
                }
                else
                {
                    MessageBox.Show("Selecione uma opção na tabela abaixo para exclusão, então pressione excluir.", "Colégio Conhecer - Excluir Atividade");
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            verificaEstadoTela = (int)OperacoesDaTela.Incluir;

            verificaTelaImagem = 1;
            controladorPaisagemTela(verificaEstadoTela, verificaTelaImagem);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            verificaEstadoTela = (int)OperacoesDaTela.Alterar;

            controladorPaisagemTela(verificaEstadoTela, verificaTelaImagem);
        }

        private void ucMenuInferior1_EventoCadastrar()
        {
            if (verificaEstadoTela == (int)OperacoesDaTela.Alterar)
            {
                #region ALTERAR ATIVIDADE

                //Controlador e objeto para operação da alteração
                atividadeControlador = AtividadeProcesso.Instance;
                atividade = new Atividade();

                try
                {
                    #region VALIDA - NOME

                    if (String.IsNullOrEmpty(txtNome.Text))
                    {
                        errorProviderTela.SetError(txtNome, "Informe o nome");
                        txtNome.Clear();
                        return;
                    }
                    atividade.Nome = txtNome.Text;

                    #endregion

                    #region VALIDA - DESCRIÇÃO

                    //if (String.IsNullOrEmpty(txtDescricao.Text))
                    //{
                    //    errorProviderTela.SetError(txtDescricao, "Informe a descrição");
                    //    txtDescricao.Clear();
                    //    return;
                    //}
                    atividade.Descricao = txtDescricao.Text;

                    #endregion

                    #region VALIDA - IMAGEM

                    if (pctImagemAtividade.Image != null)
                    {
                        atividade.Imagem = atividadeAux.Imagem;
                    }

                    #endregion

                    if (linhaSelecionadaGrid != -1)
                    {
                        atividade.ID = listaAtividade[linhaSelecionadaGrid].ID;
                        atividade.Status = (int)Status.Ativo;
                        atividadeControlador.Alterar(atividade);
                        atividadeControlador.Confirmar();
                        linhaSelecionadaGrid = -1;

                        MessageBox.Show(AtividadeConstantes.ATIVIDADE_ALTERADA, "Colégio Conhecer");
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
                carregaDataGrid1();
                verificaEstadoTela = (int)OperacoesDaTela.AbrirTela;

                controladorPaisagemTela(verificaEstadoTela, verificaTelaImagem);

                #endregion
            }
            else if (verificaEstadoTela == (int)OperacoesDaTela.Incluir)
            {
                #region ADICIONAR ATIVIDADE

                //Controlador e objeto para operação da alteração
                atividadeControlador = AtividadeProcesso.Instance;
                atividade = new Atividade();

                try
                {

                    #region VALIDA - NOME

                    if (String.IsNullOrEmpty(txtNome.Text))
                    {
                        errorProviderTela.SetError(txtNome, "Informe o nome");
                        txtNome.Clear();
                        return;
                    }
                    atividade.Nome = txtNome.Text;

                    #endregion

                    #region VALIDA - DESCRIÇÃO

                    //if (String.IsNullOrEmpty(txtDescricao.Text))
                    //{
                    //    errorProviderTela.SetError(txtDescricao, "Informe a descrição");
                    //    txtDescricao.Clear();
                    //    return;
                    //}
                    atividade.Descricao = txtDescricao.Text;

                    #endregion

                    #region VALIDA - IMAGEM

                    if (pctImagemAtividade.Image != null)
                    {
                        atividade.Imagem = atividadeAux.Imagem;
                    }

                    #endregion

                    if (verificaSeJaExistenteBD(atividade) == false)
                    {
                        atividade.Status = (int)Status.Ativo;
                        atividadeControlador.Incluir(atividade);
                        atividadeControlador.Confirmar();
                        linhaSelecionadaGrid = -1;

                        MessageBox.Show(AtividadeConstantes.ATIVIDADE_INCLUIDA, "Colégio Conhecer - Inserir Atividade");
                    }
                    else
                    {
                        MessageBox.Show("A atividade já existe na base de dados", "Colégio Conhecer - Inserir Atividade");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                carregaDataGrid1();
                verificaEstadoTela = (int)OperacoesDaTela.AbrirTela;

                controladorPaisagemTela(verificaEstadoTela, verificaTelaImagem);

                #endregion
            }
        }

        #endregion

        #region MÉTODOS AUXILIARES

        /// <summary>
        /// Método para controle de operação na tela
        /// </summary>
        /// <param name="operacao">operacao (Enum que identifica de onde vem o chamado)</param>
        /// <param name="opcao">Opção que identifica se a tela de imagem foi chamada</param>
        private void controladorPaisagemTela(int operacao, int opcao)
        {
            if (operacao == (int)OperacoesDaTela.AbrirTela)
            {
                limparTela(opcao);


                txtNome.Enabled = false;
                txtDescricao.Enabled = false;

                ucMenuDireita1.travaBotao(telaConfiguracoesAtividade.getInstancia(), true);
                ucMenuInferior1.BotaoCadastrar.Enabled = false;
                btnAdicionarImagem.Enabled = false;
                btnAdicionar.Enabled = true;
                btnExcluir.Enabled = true;
                btnAlterar.Enabled = true;
                dataGridView1.Enabled = true;
                btnAbrirAtividadeTurma.Enabled = true;
            }
            else if (operacao == (int)OperacoesDaTela.Incluir)
            {
                limparTela(opcao);

                txtNome.Focus();

                ucMenuDireita1.travaBotao(telaConfiguracoesAtividade.getInstancia(), false);
                txtNome.Enabled = true;
                txtDescricao.Enabled = true;
                btnAdicionarImagem.Enabled = true;
                ucMenuInferior1.BotaoCadastrar.Enabled = true;
                dataGridView1.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnAbrirAtividadeTurma.Enabled = false;
            }
            else if (operacao == (int)OperacoesDaTela.Alterar)
            {
                txtNome.Focus();

                ucMenuDireita1.travaBotao(telaConfiguracoesAtividade.getInstancia(), false);
                txtNome.Enabled = true;
                txtDescricao.Enabled = true;
                btnAdicionarImagem.Enabled = true;
                ucMenuInferior1.BotaoCadastrar.Enabled = true;
                dataGridView1.Enabled = false;
                btnAdicionar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            else if (operacao == (int)OperacoesDaTela.Excluir)
            {

            }
            else if (operacao == (int)OperacoesDaTela.VoltarTela)
            {
                txtNome.Enabled = false;
                txtDescricao.Enabled = false;
                btnAdicionarImagem.Enabled = false;
                ucMenuInferior1.BotaoCadastrar.Enabled = false;
                dataGridView1.Enabled = false;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnAdicionar.Enabled = true;
                verificaTelaImagem = 0;
            }

        }

        /// <summary>
        /// Método para limpeza da tela identificando se a tela de Imagem foi chamada
        /// </summary>
        /// <param name="opcao">opcao (variável verificaTelaImagem para identificação</param>
        private void limparTela(int opcao)
        {
            if (opcao == 0)
            {
                txtNome.Clear();
                txtDescricao.Clear();
            }
            else
            {
                txtNome.Clear();
                txtDescricao.Clear();
                pctImagemAtividade.Image = null;
                btnAdicionarImagem.Enabled = false;
            }
        }

        /// <summary>
        /// Método que recebe uma atividade e verifica se esta já esta cadastrada na base de dados
        /// </summary>
        /// <param name="atividade">Objeto do tipo Atividade</param>
        /// <returns>Booleano onde se verdadeiro já existe cadastro e se falso não</returns>
        public bool verificaSeJaExistenteBD(Atividade atividade)
        {
            atividadeControlador = AtividadeProcesso.Instance;

            List<Atividade> listaAuxiliar = new List<Atividade>();
            listaAuxiliar = atividadeControlador.Consultar();

            bool testa = false;

            foreach (Atividade b in listaAuxiliar)
            {
                if ((b.Descricao == atividade.Descricao) && (b.Nome == atividade.Nome))
                {
                    testa = true;
                }
            }
            return testa;
        }

        /// <summary>
        /// Método para alimentar o grid com todas as atividades ativas cadastradas no banco de dados
        /// </summary>
        private void carregaDataGrid1()
        {
            Atividade atividadeAux = new Atividade();
            atividadeAux.Status = (int)Status.Ativo;

            atividadeControlador = AtividadeProcesso.Instance;

            listaAtividade = atividadeControlador.Consultar(atividadeAux, TipoPesquisa.E);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaAtividade;
        }

        #region Eventos de Operação do Grid

        /// <summary>
        /// Evento para operar os datagrids com a seleção e alimentação dos dados na tela
        /// </summary>
        /// <param name="sender">Form que envia (DataGrid)</param>
        /// <param name="e">Evento em uso (Seleção da linha do grid)</param>
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            if (linhaSelecionadaGrid >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;

                txtDescricao.Text = listaAtividade[linhaSelecionadaGrid].Descricao;
                txtNome.Text = listaAtividade[linhaSelecionadaGrid].Nome;
                Byte[] imagemAux = listaAtividade[linhaSelecionadaGrid].Imagem;
                if (imagemAux.Length > 0)
                {
                    pctImagemAtividade.Image = arrayParaImagem(imagemAux);
                }
                else
                {
                    pctImagemAtividade.Image = null;
                }
            }
            else
            {
                linhaSelecionadaGrid = -1;
            }
        }

        /// <summary>
        /// Evento para operar os datagrids com a seleção e alimentação dos dados na tela
        /// </summary>
        /// <param name="sender">Form que envia (DataGrid)</param>
        /// <param name="e">Evento em uso (Seleção da linha do grid)</param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            if (linhaSelecionadaGrid >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;

                txtDescricao.Text = listaAtividade[linhaSelecionadaGrid].Descricao;
                txtNome.Text = listaAtividade[linhaSelecionadaGrid].Nome;
                Byte[] imagemAux = listaAtividade[linhaSelecionadaGrid].Imagem;
                if (imagemAux.Length > 0)
                {
                    pctImagemAtividade.Image = arrayParaImagem(imagemAux);
                }
                else
                {
                    pctImagemAtividade.Image = null;
                }
            }
            else
            {
                linhaSelecionadaGrid = -1;
            }
        }

        /// <summary>
        /// Evento para operar os datagrids com a seleção e alimentação dos dados na tela
        /// </summary>
        /// <param name="sender">Form que envia (DataGrid)</param>
        /// <param name="e">Evento em uso (Seleção da linha do grid)</param>
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            if (linhaSelecionadaGrid >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;

                txtDescricao.Text = listaAtividade[linhaSelecionadaGrid].Descricao;
                txtNome.Text = listaAtividade[linhaSelecionadaGrid].Nome;
                Byte[] imagemAux = listaAtividade[linhaSelecionadaGrid].Imagem;
                if (imagemAux.Length > 0)
                {
                    pctImagemAtividade.Image = arrayParaImagem(imagemAux);
                }
                else
                {
                    pctImagemAtividade.Image = null;
                }
            }
            else
            {
                linhaSelecionadaGrid = -1;
            }
        }

        /// <summary>
        /// Evento para operar os datagrids com a seleção e alimentação dos dados na tela
        /// </summary>
        /// <param name="sender">Form que envia (DataGrid)</param>
        /// <param name="e">Evento em uso (Seleção da linha do grid)</param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            if (linhaSelecionadaGrid >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;

                txtDescricao.Text = listaAtividade[linhaSelecionadaGrid].Descricao;
                txtNome.Text = listaAtividade[linhaSelecionadaGrid].Nome;
                Byte[] imagemAux = listaAtividade[linhaSelecionadaGrid].Imagem;
                if (imagemAux.Length > 0)
                {
                    pctImagemAtividade.Image = arrayParaImagem(imagemAux);
                }
                else
                {
                    pctImagemAtividade.Image = null;
                }
            }
            else
            {
                linhaSelecionadaGrid = -1;
            }
        }

        /// <summary>
        /// Evento para operar os datagrids com a seleção e alimentação dos dados na tela
        /// </summary>
        /// <param name="sender">Form que envia (DataGrid)</param>
        /// <param name="e">Evento em uso (Seleção da linha do grid)</param>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
            if (linhaSelecionadaGrid >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;

                txtDescricao.Text = listaAtividade[linhaSelecionadaGrid].Descricao;
                txtNome.Text = listaAtividade[linhaSelecionadaGrid].Nome;
                Byte[] imagemAux = listaAtividade[linhaSelecionadaGrid].Imagem;
                if (imagemAux.Length > 0)
                {
                    pctImagemAtividade.Image = arrayParaImagem(imagemAux);
                }
                else
                {
                    pctImagemAtividade.Image = null;
                }
            }
            else
            {
                linhaSelecionadaGrid = -1;
            }
        }

        #endregion

        #endregion

        // Tratamentos de erros na tela de campos obrigatórios e hints

        #region MENSAGENS
        private void btnExcluirAtividade_MouseEnter(object sender, EventArgs e)
        {
            ucMenuInferior1.exibirMensagem("Excluir uma atividade");
        }

        private void btnExcluirAtividade_MouseLeave(object sender, EventArgs e)
        {
            ucMenuInferior1.ocultarMensagem();
        }

        private void btnAdicionarAtividade_MouseEnter(object sender, EventArgs e)
        {
            ucMenuInferior1.exibirMensagem("Adicionar uma atividade");
        }

        private void btnAdicionarAtividade_MouseLeave(object sender, EventArgs e)
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
            ucMenuInferior1.exibirMensagem("Alterar uma atividade");
        }

        private void btnAlterar_MouseLeave(object sender, EventArgs e)
        {
            ucMenuInferior1.ocultarMensagem();
        }

        private void btnAdicionarImagem_MouseEnter(object sender, EventArgs e)
        {
            ucMenuInferior1.exibirMensagem("Inserir uma imagem para a atividade");
        }

        private void btnAdicionarImagem_MouseLeave(object sender, EventArgs e)
        {
            ucMenuInferior1.ocultarMensagem();
        }

        #endregion

        #region LIMPAR ERRO PROVIDER

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        #endregion

        #region Botão Abrir Tela Atividade Turma

        private void btnAbrirAtividadeTurma_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Cadastrar turma das atividades";
            label1.Visible = true;
            this.btnAbrirAtividadeTurma.BackgroundImage = global::GuiWindowsForms.Properties.Resources.btn_add_atividade_48x48_hover;
        }

        private void btnAbrirAtividadeTurma_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Visible = false;
            this.btnAbrirAtividadeTurma.BackgroundImage = global::GuiWindowsForms.Properties.Resources.btn_add_atividade_48x48;
        }

        private void btnAbrirAtividadeTurma_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 11;
            telaConfiguracoesAtividadeTurma telaconfAtvTurma = telaConfiguracoesAtividadeTurma.getInstancia();
            telaconfAtvTurma.Show();
        }

        #endregion
    }
}
