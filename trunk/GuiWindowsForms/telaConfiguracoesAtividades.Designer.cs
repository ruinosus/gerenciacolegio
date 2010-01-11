namespace GuiWindowsForms
{
    partial class telaConfiguracoesAtividade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaConfiguracoesAtividade));
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.lblHelloUsuario = new System.Windows.Forms.Label();
            this.errorProviderTela = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbcAtividade = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdicionarImagem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.ckbSabado = new System.Windows.Forms.CheckBox();
            this.cmbFuncionario = new System.Windows.Forms.ComboBox();
            this.ckbSexta = new System.Windows.Forms.CheckBox();
            this.ckbQuinta = new System.Windows.Forms.CheckBox();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.ckbTerca = new System.Windows.Forms.CheckBox();
            this.ckbSegunda = new System.Windows.Forms.CheckBox();
            this.ckbQuarta = new System.Windows.Forms.CheckBox();
            this.ckbDomingo = new System.Windows.Forms.CheckBox();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.lblTurma = new System.Windows.Forms.Label();
            this.dtpHorarioFim = new System.Windows.Forms.DateTimePicker();
            this.lblHorarioFim = new System.Windows.Forms.Label();
            this.dtpHorarioInicio = new System.Windows.Forms.DateTimePicker();
            this.lblHorarioInicio = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.ucMenuConfiguracoesEsquerda1 = new GuiWindowsForms.User_Control.ucMenuConfiguracoesEsquerda();
            this.ucMenuDireita1 = new GuiWindowsForms.User_Control.ucMenuDireita();
            this.ucMenuInferior1 = new GuiWindowsForms.ucMenuInferior();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTela)).BeginInit();
            this.tbcAtividade.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.BackColor = System.Drawing.Color.Transparent;
            this.btnDesconectar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.icone_desconectar;
            this.btnDesconectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesconectar.FlatAppearance.BorderSize = 0;
            this.btnDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconectar.Location = new System.Drawing.Point(933, 5);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(30, 30);
            this.btnDesconectar.TabIndex = 97;
            this.btnDesconectar.Tag = "";
            this.btnDesconectar.UseVisualStyleBackColor = false;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // lblHelloUsuario
            // 
            this.lblHelloUsuario.AutoSize = true;
            this.lblHelloUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblHelloUsuario.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblHelloUsuario.ForeColor = System.Drawing.Color.Yellow;
            this.lblHelloUsuario.Location = new System.Drawing.Point(794, 5);
            this.lblHelloUsuario.Name = "lblHelloUsuario";
            this.lblHelloUsuario.Size = new System.Drawing.Size(133, 23);
            this.lblHelloUsuario.TabIndex = 95;
            this.lblHelloUsuario.Text = "Hello Usuário!";
            // 
            // errorProviderTela
            // 
            this.errorProviderTela.ContainerControl = this;
            // 
            // tbcAtividade
            // 
            this.tbcAtividade.Controls.Add(this.tabPage2);
            this.tbcAtividade.Controls.Add(this.tabPage1);
            this.tbcAtividade.Location = new System.Drawing.Point(153, 129);
            this.tbcAtividade.Name = "tbcAtividade";
            this.tbcAtividade.SelectedIndex = 0;
            this.tbcAtividade.Size = new System.Drawing.Size(688, 550);
            this.tbcAtividade.TabIndex = 112;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.btnAdicionar);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.lblNome);
            this.tabPage2.Controls.Add(this.txtDescricao);
            this.tabPage2.Controls.Add(this.lblDescricao);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.btnAdicionarImagem);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.btnExcluir);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(680, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastrar  Atividade";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_mais;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Location = new System.Drawing.Point(564, 245);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(32, 32);
            this.btnAdicionar.TabIndex = 113;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 112);
            this.textBox1.MaxLength = 30;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 20);
            this.textBox1.TabIndex = 73;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(18, 112);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 72;
            this.lblNome.Text = "Nome:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(93, 162);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(330, 38);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.ForeColor = System.Drawing.Color.Black;
            this.lblDescricao.Location = new System.Drawing.Point(18, 162);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(514, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 80);
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdicionarImagem
            // 
            this.btnAdicionarImagem.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_mais;
            this.btnAdicionarImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarImagem.FlatAppearance.BorderSize = 0;
            this.btnAdicionarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarImagem.Location = new System.Drawing.Point(564, 121);
            this.btnAdicionarImagem.Name = "btnAdicionarImagem";
            this.btnAdicionarImagem.Size = new System.Drawing.Size(32, 32);
            this.btnAdicionarImagem.TabIndex = 70;
            this.btnAdicionarImagem.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_menos;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(631, 256);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(31, 11);
            this.btnExcluir.TabIndex = 69;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.lblNomeFuncionario);
            this.tabPage1.Controls.Add(this.ckbSabado);
            this.tabPage1.Controls.Add(this.cmbFuncionario);
            this.tabPage1.Controls.Add(this.ckbSexta);
            this.tabPage1.Controls.Add(this.ckbQuinta);
            this.tabPage1.Controls.Add(this.lblDiaSemana);
            this.tabPage1.Controls.Add(this.ckbTerca);
            this.tabPage1.Controls.Add(this.ckbSegunda);
            this.tabPage1.Controls.Add(this.ckbQuarta);
            this.tabPage1.Controls.Add(this.ckbDomingo);
            this.tabPage1.Controls.Add(this.txtTurma);
            this.tabPage1.Controls.Add(this.lblTurma);
            this.tabPage1.Controls.Add(this.dtpHorarioFim);
            this.tabPage1.Controls.Add(this.lblHorarioFim);
            this.tabPage1.Controls.Add(this.dtpHorarioInicio);
            this.tabPage1.Controls.Add(this.lblHorarioInicio);
            this.tabPage1.Controls.Add(this.txtValor);
            this.tabPage1.Controls.Add(this.lblValor);
            this.tabPage1.ForeColor = System.Drawing.Color.Transparent;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(680, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Turma";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_mais;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(572, 252);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 32);
            this.button5.TabIndex = 131;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_menos;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(631, 263);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 11);
            this.button1.TabIndex = 130;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(22, 290);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(640, 207);
            this.dataGridView2.TabIndex = 113;
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.ForeColor = System.Drawing.Color.Black;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(20, 26);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(54, 13);
            this.lblNomeFuncionario.TabIndex = 129;
            this.lblNomeFuncionario.Text = "Professor:";
            // 
            // ckbSabado
            // 
            this.ckbSabado.AutoSize = true;
            this.ckbSabado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbSabado.ForeColor = System.Drawing.Color.Black;
            this.ckbSabado.Location = new System.Drawing.Point(572, 211);
            this.ckbSabado.Name = "ckbSabado";
            this.ckbSabado.Size = new System.Drawing.Size(63, 17);
            this.ckbSabado.TabIndex = 127;
            this.ckbSabado.Text = "Sábado";
            this.ckbSabado.UseVisualStyleBackColor = true;
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncionario.FormattingEnabled = true;
            this.cmbFuncionario.Location = new System.Drawing.Point(137, 26);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(300, 21);
            this.cmbFuncionario.TabIndex = 128;
            // 
            // ckbSexta
            // 
            this.ckbSexta.AutoSize = true;
            this.ckbSexta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbSexta.ForeColor = System.Drawing.Color.Black;
            this.ckbSexta.Location = new System.Drawing.Point(508, 211);
            this.ckbSexta.Name = "ckbSexta";
            this.ckbSexta.Size = new System.Drawing.Size(53, 17);
            this.ckbSexta.TabIndex = 126;
            this.ckbSexta.Text = "Sexta";
            this.ckbSexta.UseVisualStyleBackColor = true;
            // 
            // ckbQuinta
            // 
            this.ckbQuinta.AutoSize = true;
            this.ckbQuinta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbQuinta.ForeColor = System.Drawing.Color.Black;
            this.ckbQuinta.Location = new System.Drawing.Point(442, 211);
            this.ckbQuinta.Name = "ckbQuinta";
            this.ckbQuinta.Size = new System.Drawing.Size(54, 17);
            this.ckbQuinta.TabIndex = 125;
            this.ckbQuinta.Text = "Quirta";
            this.ckbQuinta.UseVisualStyleBackColor = true;
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.BackColor = System.Drawing.Color.Transparent;
            this.lblDiaSemana.ForeColor = System.Drawing.Color.Black;
            this.lblDiaSemana.Location = new System.Drawing.Point(19, 210);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(83, 13);
            this.lblDiaSemana.TabIndex = 124;
            this.lblDiaSemana.Text = "Dia da Semana:";
            // 
            // ckbTerca
            // 
            this.ckbTerca.AutoSize = true;
            this.ckbTerca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTerca.ForeColor = System.Drawing.Color.Black;
            this.ckbTerca.Location = new System.Drawing.Point(300, 211);
            this.ckbTerca.Name = "ckbTerca";
            this.ckbTerca.Size = new System.Drawing.Size(54, 17);
            this.ckbTerca.TabIndex = 123;
            this.ckbTerca.Text = "Terça";
            this.ckbTerca.UseVisualStyleBackColor = true;
            // 
            // ckbSegunda
            // 
            this.ckbSegunda.AutoSize = true;
            this.ckbSegunda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbSegunda.ForeColor = System.Drawing.Color.Black;
            this.ckbSegunda.Location = new System.Drawing.Point(218, 210);
            this.ckbSegunda.Name = "ckbSegunda";
            this.ckbSegunda.Size = new System.Drawing.Size(69, 17);
            this.ckbSegunda.TabIndex = 122;
            this.ckbSegunda.Text = "Segunda";
            this.ckbSegunda.UseVisualStyleBackColor = true;
            // 
            // ckbQuarta
            // 
            this.ckbQuarta.AutoSize = true;
            this.ckbQuarta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbQuarta.ForeColor = System.Drawing.Color.Black;
            this.ckbQuarta.Location = new System.Drawing.Point(372, 211);
            this.ckbQuarta.Name = "ckbQuarta";
            this.ckbQuarta.Size = new System.Drawing.Size(58, 17);
            this.ckbQuarta.TabIndex = 121;
            this.ckbQuarta.Text = "Quarta";
            this.ckbQuarta.UseVisualStyleBackColor = true;
            // 
            // ckbDomingo
            // 
            this.ckbDomingo.AutoSize = true;
            this.ckbDomingo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbDomingo.ForeColor = System.Drawing.Color.Black;
            this.ckbDomingo.Location = new System.Drawing.Point(137, 210);
            this.ckbDomingo.Name = "ckbDomingo";
            this.ckbDomingo.Size = new System.Drawing.Size(68, 17);
            this.ckbDomingo.TabIndex = 120;
            this.ckbDomingo.Text = "Domingo";
            this.ckbDomingo.UseVisualStyleBackColor = true;
            // 
            // txtTurma
            // 
            this.txtTurma.Location = new System.Drawing.Point(137, 86);
            this.txtTurma.MaxLength = 10;
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(112, 20);
            this.txtTurma.TabIndex = 119;
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.BackColor = System.Drawing.Color.Transparent;
            this.lblTurma.ForeColor = System.Drawing.Color.Black;
            this.lblTurma.Location = new System.Drawing.Point(19, 83);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(40, 13);
            this.lblTurma.TabIndex = 118;
            this.lblTurma.Text = "Turma:";
            // 
            // dtpHorarioFim
            // 
            this.dtpHorarioFim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpHorarioFim.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioFim.Location = new System.Drawing.Point(355, 125);
            this.dtpHorarioFim.Name = "dtpHorarioFim";
            this.dtpHorarioFim.Size = new System.Drawing.Size(82, 20);
            this.dtpHorarioFim.TabIndex = 117;
            // 
            // lblHorarioFim
            // 
            this.lblHorarioFim.AutoSize = true;
            this.lblHorarioFim.ForeColor = System.Drawing.Color.Black;
            this.lblHorarioFim.Location = new System.Drawing.Point(274, 125);
            this.lblHorarioFim.Name = "lblHorarioFim";
            this.lblHorarioFim.Size = new System.Drawing.Size(63, 13);
            this.lblHorarioFim.TabIndex = 116;
            this.lblHorarioFim.Text = "Horário Fim:";
            // 
            // dtpHorarioInicio
            // 
            this.dtpHorarioInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpHorarioInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioInicio.Location = new System.Drawing.Point(137, 125);
            this.dtpHorarioInicio.Name = "dtpHorarioInicio";
            this.dtpHorarioInicio.Size = new System.Drawing.Size(82, 20);
            this.dtpHorarioInicio.TabIndex = 115;
            // 
            // lblHorarioInicio
            // 
            this.lblHorarioInicio.AutoSize = true;
            this.lblHorarioInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblHorarioInicio.ForeColor = System.Drawing.Color.Black;
            this.lblHorarioInicio.Location = new System.Drawing.Point(19, 122);
            this.lblHorarioInicio.Name = "lblHorarioInicio";
            this.lblHorarioInicio.Size = new System.Drawing.Size(74, 13);
            this.lblHorarioInicio.TabIndex = 114;
            this.lblHorarioInicio.Text = "Horário Início:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(137, 165);
            this.txtValor.MaxLength = 10;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(112, 20);
            this.txtValor.TabIndex = 113;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.ForeColor = System.Drawing.Color.Black;
            this.lblValor.Location = new System.Drawing.Point(19, 165);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(57, 13);
            this.lblValor.TabIndex = 112;
            this.lblValor.Text = "Valor (R$):";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 112);
            this.textBox2.MaxLength = 30;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(330, 20);
            this.textBox2.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Nome:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(93, 162);
            this.textBox3.MaxLength = 100;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(330, 91);
            this.textBox3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(514, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 80);
            this.pictureBox2.TabIndex = 71;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_mais;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(564, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 70;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(22, 289);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(640, 207);
            this.dataGridView3.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_menos;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(631, 256);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 11);
            this.button3.TabIndex = 69;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ucMenuConfiguracoesEsquerda1
            // 
            this.ucMenuConfiguracoesEsquerda1.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuConfiguracoesEsquerda1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucMenuConfiguracoesEsquerda1.Location = new System.Drawing.Point(0, 177);
            this.ucMenuConfiguracoesEsquerda1.Name = "ucMenuConfiguracoesEsquerda1";
            this.ucMenuConfiguracoesEsquerda1.Size = new System.Drawing.Size(91, 493);
            this.ucMenuConfiguracoesEsquerda1.TabIndex = 108;
            this.ucMenuConfiguracoesEsquerda1.Load += new System.EventHandler(this.ucMenuConfiguracoesEsquerda1_Load);
            this.ucMenuConfiguracoesEsquerda1.EventoAbrirControleDeAcesso += new GuiWindowsForms.User_Control.ucMenuConfiguracoesEsquerda.delegateAbrirTelaControleDeAcesso(this.ucMenuConfiguracoesEsquerda1_EventoAbrirControleDeAcesso);
            // 
            // ucMenuDireita1
            // 
            this.ucMenuDireita1.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuDireita1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucMenuDireita1.Location = new System.Drawing.Point(893, 175);
            this.ucMenuDireita1.Name = "ucMenuDireita1";
            this.ucMenuDireita1.Size = new System.Drawing.Size(120, 493);
            this.ucMenuDireita1.TabIndex = 107;
            this.ucMenuDireita1.Load += new System.EventHandler(this.ucMenuDireita1_Load);
            this.ucMenuDireita1.EventoAbrirAtividade += new GuiWindowsForms.User_Control.ucMenuDireita.delegateAbrirTelaAtividade(this.ucMenuDireita1_EventoAbrirAtividade);
            this.ucMenuDireita1.EventoAbrirDesconto += new GuiWindowsForms.User_Control.ucMenuDireita.delegateAbrirTelaDesconto(this.ucMenuDireita1_EventoAbrirDesconto);
            this.ucMenuDireita1.EventoAbrirSerie += new GuiWindowsForms.User_Control.ucMenuDireita.delegateAbrirTelaSerie(this.ucMenuDireita1_EventoAbrirSerie);
            // 
            // ucMenuInferior1
            // 
            this.ucMenuInferior1.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuInferior1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucMenuInferior1.Location = new System.Drawing.Point(39, 667);
            this.ucMenuInferior1.Name = "ucMenuInferior1";
            this.ucMenuInferior1.Size = new System.Drawing.Size(404, 43);
            this.ucMenuInferior1.TabIndex = 109;
            this.ucMenuInferior1.EventoCadastrar += new GuiWindowsForms.ucMenuInferior.delegateCadastrar(this.ucMenuInferior1_EventoCadastrar);
            this.ucMenuInferior1.EventoVoltar += new GuiWindowsForms.ucMenuInferior.delegateVoltar(this.ucAluno1_EventoVoltar);
            // 
            // telaConfiguracoesAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GuiWindowsForms.Properties.Resources.modelo_tela_iconemenor;
            this.ClientSize = new System.Drawing.Size(1000, 722);
            this.Controls.Add(this.tbcAtividade);
            this.Controls.Add(this.ucMenuConfiguracoesEsquerda1);
            this.Controls.Add(this.ucMenuDireita1);
            this.Controls.Add(this.lblHelloUsuario);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.ucMenuInferior1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaConfiguracoesAtividade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            this.Load += new System.EventHandler(this.ckbTerca_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaConfiguracoesAtividades_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTela)).EndInit();
            this.tbcAtividade.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Label lblHelloUsuario;
        private GuiWindowsForms.User_Control.ucMenuDireita ucMenuDireita1;
        private GuiWindowsForms.User_Control.ucMenuConfiguracoesEsquerda ucMenuConfiguracoesEsquerda1;
        private ucMenuInferior ucMenuInferior1;
        private System.Windows.Forms.ErrorProvider errorProviderTela;
        private System.Windows.Forms.TabControl tbcAtividade;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.CheckBox ckbSabado;
        private System.Windows.Forms.ComboBox cmbFuncionario;
        private System.Windows.Forms.CheckBox ckbSexta;
        private System.Windows.Forms.CheckBox ckbQuinta;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.CheckBox ckbTerca;
        private System.Windows.Forms.CheckBox ckbSegunda;
        private System.Windows.Forms.CheckBox ckbQuarta;
        private System.Windows.Forms.CheckBox ckbDomingo;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.DateTimePicker dtpHorarioFim;
        private System.Windows.Forms.Label lblHorarioFim;
        private System.Windows.Forms.DateTimePicker dtpHorarioInicio;
        private System.Windows.Forms.Label lblHorarioInicio;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdicionarImagem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button button5;
    }
}