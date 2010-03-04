using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.ModuloAluno.Processos;
using Negocios.ModuloFuncionario.Processos;
using Negocios.ModuloMatricula.Processos;
using Negocios.ModuloBasico.VOs;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloSerie.Processos;
using Negocios.ModuloDesconto.Processos;
using Negocios.ModuloSala.Processos;

namespace GuiWindowsForms
{
    public partial class telaPrincipal : Form
    {
        enum TelaSelecionada
        {
            Aluno,
            Funcionario
        }
        List<Aluno> alunosAxiliarLista;
        int linhaSelecionadaGrid = -1;

        List<Funcionario> funcinariosAuxiliarLista;

        TelaSelecionada tela = TelaSelecionada.Aluno;


        ISerieProcesso serieControlador = SerieProcesso.Instance;

        #region SINGLETON DA TELA
        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */


        private static telaPrincipal telaalunoprincipal;

        private static bool IsShown = false;

        #endregion

        #region INSTANCIA TELA ALUNO RESPONSAVEL
        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. 
        /// Evita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>

        public static telaPrincipal getInstancia()
        {
            if (telaalunoprincipal == null)
            {
                telaalunoprincipal = new telaPrincipal();
            }
            return telaalunoprincipal;


        }
        #endregion

        #region CONSTRUTOR
        /// <summary>
        /// Construtor da tela
        /// </summary>

        public telaPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region INSTANCIA TELA ALUNO PRINCIPAL
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

        private void telaAlunoPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IsShown = false;
            this.Hide();

            Program.ultimaTela = 9;
            Program.SelecionaForm(Program.ultimaTela);

        }
        #endregion

        #region Mudança de cores das textboxes e outros controles

        /// <summary>
        /// Altera a cor do controle ao ser ativado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            txtBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Retorna a cor do controle para a original ao perder o foco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            txtBusca.BackColor = System.Drawing.Color.White;
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

        #region Controle de mudança das figuras e exibição dos textos das mesmas

        /// <summary>
        /// Exibe o nome do botão relacionado, só sendo escondido ao se clicar em outro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAluno_Enter(object sender, EventArgs e)
        {
            lblAlunoOculto.Visible = true;
            this.btnAluno.BackgroundImage = global::GuiWindowsForms.Properties.Resources.icone_aluno_142x113_hover;
        }

        /// <summary>
        /// Esconde o texto do botão selecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAluno_Leave(object sender, EventArgs e)
        {
            lblAlunoOculto.Visible = false;
            this.btnAluno.BackgroundImage = global::GuiWindowsForms.Properties.Resources.icone_aluno_142x113;
        }

        /// <summary>
        /// Exibe o nome do botão relacionado, só sendo escondido ao se clicar em outro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnFuncionario_Enter(object sender, EventArgs e)
        {
            lblAlunoOculto.Visible = false;
            lblFuncOculto.Visible = true;
            this.btnFuncionario.BackgroundImage = global::GuiWindowsForms.Properties.Resources.icone_prof_142x113_hover;
        }

        /// <summary>
        /// Esconde o texto do botão selecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnFuncionario_Leave(object sender, EventArgs e)
        {
            lblFuncOculto.Visible = false;
            this.btnFuncionario.BackgroundImage = global::GuiWindowsForms.Properties.Resources.icone_prof_142x113;

        }

        /// <summary>
        /// Exibe o nome do botão relacionado, só sendo escondido ao se clicar em outro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnConfiguracoes_Enter(object sender, EventArgs e)
        {
            lblAlunoOculto.Visible = false;
            lblConfOculto.Visible = true;
            this.btnConfiguracoes.BackgroundImage = global::GuiWindowsForms.Properties.Resources.configuracoes_137x101_hover;
        }

        /// <summary>
        /// Esconde o texto do botão selecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnConfiguracoes_Leave(object sender, EventArgs e)
        {
            lblConfOculto.Visible = false;
            this.btnConfiguracoes.BackgroundImage = global::GuiWindowsForms.Properties.Resources.configuracoes_137x101;
        }

        /// <summary>
        /// Exibe o nome do botão relacionado, só sendo escondido ao se clicar em outro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnFinanceiro_Enter(object sender, EventArgs e)
        {
            lblAlunoOculto.Visible = false;
            lblFinanceiro.Visible = true;
            this.btnFinanceiro.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_gnd_120x110_png_hover;
        }

        /// <summary>
        /// Esconde o texto do botão selecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnFinanceiro_Leave(object sender, EventArgs e)
        {
            lblFinanceiro.Visible = false;
            this.btnFinanceiro.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_gnd_120x110;
        }

        #endregion

        #region BUTTON PESQUISAR
        /// <summary>
        /// Conforme o botão clidado, será realizada uma pesquisa específica a ser exibida em um datagrid
        /// algumas validações serão exigidas para tal
        /// O parâmetro de funcionamento são os dados para pesquisa preenchidos na textbox txtbusca
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                lblErro.Visible = false;
                #region Validações
                //if (String.IsNullOrEmpty(txtBusca.Text))
                //{
                //    txtBusca.BackColor = System.Drawing.Color.LawnGreen;
                //    throw new Exception("Digite algum critério para a pesquisa.");
                //}

                //if (txtBusca.Text.Length < 4)
                //{
                //    txtBusca.BackColor = System.Drawing.Color.LawnGreen;
                //    throw new Exception("Digite argumentos para pesquisa maiores que 3 caracteres.");
                //}
                #endregion
                CarregarGrid();


            }
            catch (Exception ex)
            {
                lblErro.Visible = true;
                lblErro.Text = ex.Message;
            }
        }
        #endregion

        #region BUTTON CONFIGURAÇÕES
        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            btnCadastrarAluno.Visible = false;
            btnCadastrarFuncionario.Visible = false;
            this.Hide();
            Program.ultimaTela = 6;
            telaConfiguracoes telaconfiguracoes = telaConfiguracoes.getInstancia();
            telaconfiguracoes.Show();
        }
        #endregion

        #region BUTTON ALUNO
        private void btnAluno_Click(object sender, EventArgs e)
        {
            tela = TelaSelecionada.Aluno;
            escondeGrid();
            exibeGrid("aluno");

            btnCadastrarFuncionario.Visible = false;
            btnCadastrarAluno.Visible = true;

        }
        #endregion

        #region BUTTON FUNCIONARIO
        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            tela = TelaSelecionada.Funcionario;
            escondeGrid();
            exibeGrid("funcionario");

            btnCadastrarAluno.Visible = false;
            btnCadastrarFuncionario.Visible = true;
        }
        #endregion

        #region BUTTON FINANCEIRO
        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            btnCadastrarAluno.Visible = false;
            btnCadastrarFuncionario.Visible = false;
            this.Hide();
            Program.ultimaTela = 6;
            telaFinanceiro telafinanceiro = telaFinanceiro.getInstancia();
            telafinanceiro.Show();
        }
        #endregion

        #region BUTTON CADASTRAR ALUNO
        /// <summary>
        /// Fecha a tela ativa e exibe a tela de Aluno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 6;

            # region Verifica a existência de uma sala cadastrada
            Sala salaVerifica = new Sala();
            ISalaProcesso salaControlador = SalaProcesso.Instance;

            List<Sala> listaSalaVerifica = new List<Sala>();

            salaVerifica.Status = (int)Status.Ativo;

            listaSalaVerifica = salaControlador.Consultar(salaVerifica, TipoPesquisa.E);

            int contaSala = listaSalaVerifica.Count;
            #endregion

            #region Verifica a existência de um desconto cadastrado

            Desconto descontoVerifica = new Desconto();
            IDescontoProcesso descontoControlador = DescontoProcesso.Instance;

            List<Desconto> listaDescontoVerifica = new List<Desconto>();

            descontoVerifica.Status = (int)Status.Ativo;

            listaDescontoVerifica = descontoControlador.Consultar(descontoVerifica, TipoPesquisa.E);

            int contaDesconto = listaDescontoVerifica.Count;

            #endregion


            //Quando abrir a telaAluno do clique do botao cadastrar
            // os campos "Alterar" e "Excluir" ficam inativos
            Program.ultimaTelaCadastrar = 1;

            Memoria memoria = Memoria.Instance;
            memoria.Aluno = null;
            memoria.Status = Negocios.ModuloBasico.Enums.StatusBanco.Inativo;

            telaAlunoResponsavel telaalunoresponsavel = telaAlunoResponsavel.getInstancia();
            telaalunoresponsavel.limparTela();

            if (contaDesconto != 0 && contaSala != 0)
            {
                telaAluno telaAlunoAuxiliar = telaAluno.getInstancia();
                telaAlunoAuxiliar.limparTelaAluno();
                telaAlunoAuxiliar.Show();
            }
            else
            {
                MessageBox.Show("Só é possível acessar o cadastro de aluno com uma sala cadastrada ao qual o aluno será matriculado e um desconto, mesmo que este seja não aplicável");
                telaAluno telaAlunoAuxiliar = telaAluno.getInstancia();
                telaalunoprincipal.Show();
            }
        }
        #endregion

        #region BUTTON CADASTRAR FUNCIONARIO
        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ultimaTela = 6;

            //Quando abrir a telaAluno do clique do botao cadastrar
            // os campos "Alterar" e "Excluir" ficam inativos
            Program.ultimaTelaCadastrar = 1;

            Memoria memoria = Memoria.Instance;
            memoria.Funcionario = null;
            memoria.Status = Negocios.ModuloBasico.Enums.StatusBanco.Inativo;

            telaFuncionario telafuncionario = telaFuncionario.getInstancia();
            telafuncionario.limparFuncionario();
            telafuncionario.Show();


        }
        #endregion

        #region LOAD
        private void telaAlunoPrincipal_Load(object sender, EventArgs e)
        {
            CarregarGrid();

        }
        #endregion

        #region EVENTOS DO GRID

        #region CARREGAR GRID ALUNO
        private void CarregarGrid()
        {
            dgvAluno.AutoGenerateColumns = false;
            switch (tela)
            {
                case TelaSelecionada.Aluno:
                    {

                        IAlunoProcesso processo = AlunoProcesso.Instance;
                        Aluno a = new Aluno();
                        a.Nome = txtBusca.Text;
                        a.PerfilID = 0;
                        a.Status = (int)Status.Ativo;
                        alunosAxiliarLista = processo.Consultar(a, Negocios.ModuloBasico.Enums.TipoPesquisa.E);

                        dgvAluno.DataSource = alunosAxiliarLista;
                        break;
                    }
                case TelaSelecionada.Funcionario:
                    {

                        IFuncionarioProcesso processo = FuncionarioProcesso.Instance;
                        Funcionario f = new Funcionario();

                        f.Status = (int)Status.Ativo;
                        funcinariosAuxiliarLista = processo.Consultar(f, Negocios.ModuloBasico.Enums.TipoPesquisa.E);

                        dgvFuncionario.DataSource = null;
                        dgvFuncionario.AutoGenerateColumns = false;
                        dgvFuncionario.DataSource = funcinariosAuxiliarLista;
                        break;
                    }
                default:
                    break;
            }
        }
        #endregion

        #region EVENTO DOUBLE CLICK GRID ALUNO
        private void dgvAluno_DoubleClick(object sender, EventArgs e)
        {

            if (linhaSelecionadaGrid != -1)
            {
                Aluno aluno = (alunosAxiliarLista[linhaSelecionadaGrid]);

                Memoria memoria = Memoria.Instance;
                memoria.Status = StatusBanco.Inativo;
                memoria.Aluno = aluno;


                this.Hide();
                Program.ultimaTela = 6;
                telaAluno tAluno = telaAluno.getInstancia();
                tAluno.Show();

                //Atribui "2" a variavel de Program para identificar
                // que veio do clique no Data Grid assim exibindo os
                //campos ALTERAR, EXCLUIR na telaAluno
                Program.ultimaTelaCadastrar = 2;
            }

        }
        #endregion

        #region EVENTO CELL CLICK GRID ALUNO
        private void dgvAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());

            if (linhaSelecionadaGrid != -1)
                dgvAluno.Rows[linhaSelecionadaGrid].Selected = true;
        }
        #endregion

        #region EVENTO CELL ENTER GRID ALUNO
        private void dgvAluno_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Atribui "2" a variavel de Program para identificar
            // que veio do clique no Data Grid assim exibindo os
            //campos ALTERAR, EXCLUIR na telaAluno
            Program.ultimaTelaCadastrar = 2;


            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());

            if (linhaSelecionadaGrid != -1)
                dgvAluno.Rows[linhaSelecionadaGrid].Selected = true;

        }
        #endregion

        #region EVENTO DOUBLE CLICK GRID FUNCIONARIO
        private void dgvFuncionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (linhaSelecionadaGrid != -1)
            {
                Funcionario funcionario = (funcinariosAuxiliarLista[linhaSelecionadaGrid]);

                Memoria memoria = Memoria.Instance;
                memoria.Status = StatusBanco.Inativo;
                memoria.Funcionario = funcionario;


                this.Hide();
                Program.ultimaTela = 6;
                telaFuncionario tFuncionario = telaFuncionario.getInstancia();
                tFuncionario.Show();

                //Atribui "2" a variavel de Program para identificar
                // que veio do clique no Data Grid assim exibindo os
                //campos ALTERAR, EXCLUIR na telaFuncionario
                Program.ultimaTelaCadastrar = 2;
            }

        }
        #endregion

        #region EVENTO CELL CLICK GRID FUNCIONARIO
        //private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        //{


        //    linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());
        //    if (linhaSelecionadaGrid != -1)
        //    {
        //        Funcionario funcionario = (funcinariosAuxiliarLista[linhaSelecionadaGrid]);

        //        Memoria memoria = Memoria.Instance;
        //        memoria.Status = StatusBanco.Inativo;
        //        memoria.Funcionario = funcionario;


        //        this.Hide();
        //        Program.ultimaTela = 6;
        //        telaFuncionario tFuncionario = telaFuncionario.getInstancia();
        //        tFuncionario.Show();


        //        //Atribui "2" a variavel de Program para identificar
        //        // que veio do clique no Data Grid assim exibindo os
        //        //campos ALTERAR, EXCLUIR na telaFuncionario
        //        Program.ultimaTelaCadastrar = 2;
        //    }
        //}
        #endregion

        #region EVENTO CELL CONTENT CLICK FUNCIONARIO
        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());


            //if (linhaSelecionadaGrid != -1)
            //{
            //    Funcionario funcionario = (funcinariosAuxiliarLista[linhaSelecionadaGrid]);

            //    Memoria memoria = Memoria.Instance;
            //    memoria.Status = StatusBanco.Inativo;
            //    memoria.Funcionario = funcionario;


            //    this.Hide();
            //    Program.ultimaTela = 6;
            //    telaFuncionario tFuncionario = telaFuncionario.getInstancia();
            //    tFuncionario.Show();

            //    //Atribui "2" a variavel de Program para identificar
            //    // que veio do clique no Data Grid assim exibindo os
            //    //campos ALTERAR, EXCLUIR na telaFuncionario
            //    Program.ultimaTelaCadastrar = 2;
            //}
        }
        #endregion

        #region EVENTO CELL CONTENT DOUBLE CLICK GRID FUNCIONARIO
        private void dgvFuncionario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());


            //if (linhaSelecionadaGrid != -1)
            //{
            //    Funcionario funcionario = (funcinariosAuxiliarLista[linhaSelecionadaGrid]);

            //    Memoria memoria = Memoria.Instance;
            //    memoria.Status = StatusBanco.Inativo;
            //    memoria.Funcionario = funcionario;


            //    this.Hide();
            //    Program.ultimaTela = 6;
            //    telaFuncionario tFuncionario = telaFuncionario.getInstancia();
            //    tFuncionario.Show();

            //    //Atribui "2" a variavel de Program para identificar
            //    // que veio do clique no Data Grid assim exibindo os
            //    //campos ALTERAR, EXCLUIR na telaFuncionario
            //    Program.ultimaTelaCadastrar = 2;
            //}
        }
        #endregion

        #region EVENTO CELL DOUBLE CLICK FUNCIONARIO
        private void dgvFuncionario_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {


            linhaSelecionadaGrid = int.Parse(e.RowIndex.ToString());


            if (linhaSelecionadaGrid != -1)
            {
                Funcionario funcionario = (funcinariosAuxiliarLista[linhaSelecionadaGrid]);

                Memoria memoria = Memoria.Instance;
                memoria.Status = StatusBanco.Inativo;
                memoria.Funcionario = funcionario;


                this.Hide();
                Program.ultimaTela = 6;
                telaFuncionario tFuncionario = telaFuncionario.getInstancia();

                //Atribui "2" a variavel de Program para identificar
                // que veio do clique no Data Grid assim exibindo os
                //campos ALTERAR, EXCLUIR na telaFuncionario
                Program.ultimaTelaCadastrar = 2;


                tFuncionario.Show();


            }
        }
        #endregion

        #endregion

        #region MÉTODO EXCLUIR
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (linhaSelecionadaGrid == -1)
                {
                    throw new Exception();
                }
                IAlunoProcesso processo = AlunoProcesso.Instance;
                Aluno aluno = (alunosAxiliarLista[linhaSelecionadaGrid]);
                processo.Excluir(aluno);
                processo.Confirmar();
            }
            catch (Exception)
            {

                //throw;
            }
        }
        #endregion

        #region MÉTODO ACTIVATED
        private void telaAlunoPrincipal_Activated(object sender, EventArgs e)
        {
            escondeGrid();
            if (Program.usuarioLogin != null)
            {
                ucDesconectarLogin1.alterarNomeUsuario(true, Program.usuarioLogin);
            }
            CarregarGrid();
        }
        #endregion

        #region BUTTON DESCONECTAR
        private void ucDesconectarLogin1_EventoDesconectar()
        {
            Program.ultimaTela = 9;
            this.Close();
            telaLogin telalogin = telaLogin.getInstancia();
            telalogin.Show();
        }
        #endregion

        #region METODO EXIBE GRID
        /// <summary>
        /// Método para exibir o Grid de acordo com
        /// o botao passando uma string com o nome 
        /// do botao
        /// </summary>
        /// <param name="tipoBotao"></param>
        public void exibeGrid(string nomebotao)
        {
            if (nomebotao == "aluno")
            {
                btnPesquisar.Enabled = true;
                txtBusca.Enabled = true;
                dgvAluno.Visible = true;
                btnCadastrarAluno.Visible = true;
                cmbSerie.Visible = true;
                lblSerie.Visible = true;
                cmbCiclo.Visible = true;
                lblCiclo.Visible = true;


                List<Serie> listaSerie = new List<Serie>();
                Serie serieInicio = new Serie();
                serieInicio.Nome = "selecione";
                serieInicio.ID = 0;
                listaSerie = serieControlador.Consultar();
                listaSerie.Insert(0, serieInicio);
                cmbSerie.DataSource = listaSerie;
                cmbSerie.DisplayMember = "Nome";

                CarregarGrid();
            }

            if (nomebotao == "funcionario")
            {
                btnPesquisar.Enabled = true;
                txtBusca.Enabled = true;
                dgvFuncionario.Visible = true;
                btnCadastrarFuncionario.Visible = true;
                cmbSerie.Visible = false;
                lblSerie.Visible = false;
                cmbCiclo.Visible = false;
                lblCiclo.Visible = false;
                CarregarGrid();
            }

        }
        #endregion

        #region METODO ESCONDE GRID

        /// <summary>
        /// Esconde o Grid e desabilita
        /// o botao Pesquisar e a barra de busca
        /// </summary>
        public void escondeGrid()
        {
            btnPesquisar.Enabled = false;
            txtBusca.Enabled = false;
            dgvAluno.Visible = false;
            dgvFuncionario.Visible = false;
            btnCadastrarFuncionario.Visible = false;
            btnCadastrarAluno.Visible = false;
            cmbSerie.Visible = false;
            lblSerie.Visible = false;
            cmbCiclo.Visible = false;
            lblCiclo.Visible = false;

        }
        #endregion






    }


}
