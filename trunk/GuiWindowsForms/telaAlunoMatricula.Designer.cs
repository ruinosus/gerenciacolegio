namespace GuiWindowsForms
{
    partial class telaAlunoMatricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaAlunoMatricula));
            this.gpbMatricula = new System.Windows.Forms.GroupBox();
            this.txtTotalValor = new System.Windows.Forms.TextBox();
            this.lblTotalValor = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNumeroMatricula = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblDataMatricula = new System.Windows.Forms.Label();
            this.lblTurma = new System.Windows.Forms.Label();
            this.cmbTurma = new System.Windows.Forms.ComboBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.cmbSerie = new System.Windows.Forms.ComboBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblHelloUsuario = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.lblFoneEmerg = new System.Windows.Forms.Label();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.pctImagem = new System.Windows.Forms.PictureBox();
            this.btnMatricula = new System.Windows.Forms.Button();
            this.lblMatricula_menu = new System.Windows.Forms.Label();
            this.btnDados = new System.Windows.Forms.Button();
            this.lblDados_Menu = new System.Windows.Forms.Label();
            this.btnResponsaveis = new System.Windows.Forms.Button();
            this.lblResponsavel_menu = new System.Windows.Forms.Label();
            this.btnInfoMedica = new System.Windows.Forms.Button();
            this.lblMedico_menu = new System.Windows.Forms.Label();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.lblFinanceiro_menu = new System.Windows.Forms.Label();
            this.btnAcademico = new System.Windows.Forms.Button();
            this.lblAcademico_menu = new System.Windows.Forms.Label();
            this.lblInfoControles = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnMatriculaAtividade = new System.Windows.Forms.Button();
            this.gpbMatricula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbMatricula
            // 
            this.gpbMatricula.BackColor = System.Drawing.Color.Transparent;
            this.gpbMatricula.Controls.Add(this.txtTotalValor);
            this.gpbMatricula.Controls.Add(this.lblTotalValor);
            this.gpbMatricula.Controls.Add(this.comboBox1);
            this.gpbMatricula.Controls.Add(this.lblDesconto);
            this.gpbMatricula.Controls.Add(this.textBox1);
            this.gpbMatricula.Controls.Add(this.lblNumeroMatricula);
            this.gpbMatricula.Controls.Add(this.dtpNascimento);
            this.gpbMatricula.Controls.Add(this.lblDataMatricula);
            this.gpbMatricula.Controls.Add(this.lblTurma);
            this.gpbMatricula.Controls.Add(this.cmbTurma);
            this.gpbMatricula.Controls.Add(this.lblTurno);
            this.gpbMatricula.Controls.Add(this.cmbTurno);
            this.gpbMatricula.Controls.Add(this.lblSerie);
            this.gpbMatricula.Controls.Add(this.cmbSerie);
            this.gpbMatricula.Controls.Add(this.lblValor);
            this.gpbMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbMatricula.Location = new System.Drawing.Point(39, 191);
            this.gpbMatricula.Name = "gpbMatricula";
            this.gpbMatricula.Size = new System.Drawing.Size(820, 350);
            this.gpbMatricula.TabIndex = 78;
            this.gpbMatricula.TabStop = false;
            this.gpbMatricula.Text = "MATRÍCULA DO ALUNO";
            // 
            // txtTotalValor
            // 
            this.txtTotalValor.Location = new System.Drawing.Point(668, 306);
            this.txtTotalValor.Name = "txtTotalValor";
            this.txtTotalValor.ReadOnly = true;
            this.txtTotalValor.Size = new System.Drawing.Size(123, 20);
            this.txtTotalValor.TabIndex = 47;
            // 
            // lblTotalValor
            // 
            this.lblTotalValor.AutoSize = true;
            this.lblTotalValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValor.ForeColor = System.Drawing.Color.Red;
            this.lblTotalValor.Location = new System.Drawing.Point(496, 304);
            this.lblTotalValor.Name = "lblTotalValor";
            this.lblTotalValor.Size = new System.Drawing.Size(160, 20);
            this.lblTotalValor.TabIndex = 46;
            this.lblTotalValor.Text = "Total à pagar (R$):";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(103, 225);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 45;
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(29, 228);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(65, 13);
            this.lblDesconto.TabIndex = 44;
            this.lblDesconto.Text = "Desconto:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 42;
            // 
            // lblNumeroMatricula
            // 
            this.lblNumeroMatricula.AutoSize = true;
            this.lblNumeroMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroMatricula.Location = new System.Drawing.Point(665, 27);
            this.lblNumeroMatricula.Name = "lblNumeroMatricula";
            this.lblNumeroMatricula.Size = new System.Drawing.Size(126, 13);
            this.lblNumeroMatricula.TabIndex = 41;
            this.lblNumeroMatricula.Text = "Número da Matrícula";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(500, 21);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(110, 20);
            this.dtpNascimento.TabIndex = 40;
            // 
            // lblDataMatricula
            // 
            this.lblDataMatricula.AutoSize = true;
            this.lblDataMatricula.Location = new System.Drawing.Point(380, 27);
            this.lblDataMatricula.Name = "lblDataMatricula";
            this.lblDataMatricula.Size = new System.Drawing.Size(114, 13);
            this.lblDataMatricula.TabIndex = 39;
            this.lblDataMatricula.Text = "Data da Matrícula:";
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(241, 118);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(46, 13);
            this.lblTurma.TabIndex = 38;
            this.lblTurma.Text = "Turma:";
            // 
            // cmbTurma
            // 
            this.cmbTurma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurma.FormattingEnabled = true;
            this.cmbTurma.Location = new System.Drawing.Point(291, 115);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(101, 21);
            this.cmbTurma.TabIndex = 37;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(50, 118);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(44, 13);
            this.lblTurno.TabIndex = 36;
            this.lblTurno.Text = "Turno:";
            // 
            // cmbTurno
            // 
            this.cmbTurno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(103, 115);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(101, 21);
            this.cmbTurno.TabIndex = 35;
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(54, 82);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(40, 13);
            this.lblSerie.TabIndex = 34;
            this.lblSerie.Text = "Série:";
            // 
            // cmbSerie
            // 
            this.cmbSerie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSerie.FormattingEnabled = true;
            this.cmbSerie.Location = new System.Drawing.Point(103, 79);
            this.cmbSerie.Name = "cmbSerie";
            this.cmbSerie.Size = new System.Drawing.Size(163, 21);
            this.cmbSerie.TabIndex = 33;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(29, 182);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(68, 13);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor (R$):";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.ok_32x32_tipo2_final;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(86, 677);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(36, 29);
            this.btnSalvar.TabIndex = 79;
            this.btnSalvar.Tag = "Gravar Dados";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.MouseLeave += new System.EventHandler(this.btnSalvar_MouseLeave);
            this.btnSalvar.MouseEnter += new System.EventHandler(this.btnSalvar_MouseEnter);
            // 
            // lblHelloUsuario
            // 
            this.lblHelloUsuario.AutoSize = true;
            this.lblHelloUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblHelloUsuario.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblHelloUsuario.ForeColor = System.Drawing.Color.Yellow;
            this.lblHelloUsuario.Location = new System.Drawing.Point(802, 9);
            this.lblHelloUsuario.Name = "lblHelloUsuario";
            this.lblHelloUsuario.Size = new System.Drawing.Size(133, 23);
            this.lblHelloUsuario.TabIndex = 80;
            this.lblHelloUsuario.Text = "Hello Usuário!";
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.BackColor = System.Drawing.Color.Transparent;
            this.btnDesconectar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.icone_desconectar;
            this.btnDesconectar.FlatAppearance.BorderSize = 0;
            this.btnDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconectar.Location = new System.Drawing.Point(941, 9);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(30, 30);
            this.btnDesconectar.TabIndex = 81;
            this.btnDesconectar.Tag = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = false;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // lblFoneEmerg
            // 
            this.lblFoneEmerg.AutoSize = true;
            this.lblFoneEmerg.BackColor = System.Drawing.Color.Transparent;
            this.lblFoneEmerg.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblFoneEmerg.ForeColor = System.Drawing.Color.Yellow;
            this.lblFoneEmerg.Location = new System.Drawing.Point(394, 133);
            this.lblFoneEmerg.Name = "lblFoneEmerg";
            this.lblFoneEmerg.Size = new System.Drawing.Size(98, 19);
            this.lblFoneEmerg.TabIndex = 87;
            this.lblFoneEmerg.Text = "Fone Emerg";
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.BackColor = System.Drawing.Color.Transparent;
            this.lblResponsavel.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblResponsavel.ForeColor = System.Drawing.Color.Yellow;
            this.lblResponsavel.Location = new System.Drawing.Point(394, 104);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(155, 19);
            this.lblResponsavel.TabIndex = 86;
            this.lblResponsavel.Text = "Nome Responsável";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(394, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 85;
            this.label1.Text = "Série";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.BackColor = System.Drawing.Color.Transparent;
            this.lblMatricula.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblMatricula.ForeColor = System.Drawing.Color.Yellow;
            this.lblMatricula.Location = new System.Drawing.Point(394, 45);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(80, 19);
            this.lblMatricula.TabIndex = 84;
            this.lblMatricula.Text = "Matricula";
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeAluno.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblNomeAluno.ForeColor = System.Drawing.Color.Yellow;
            this.lblNomeAluno.Location = new System.Drawing.Point(394, 12);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(124, 19);
            this.lblNomeAluno.TabIndex = 83;
            this.lblNomeAluno.Text = "Nome do Aluno";
            // 
            // pctImagem
            // 
            this.pctImagem.BackColor = System.Drawing.Color.Transparent;
            this.pctImagem.Location = new System.Drawing.Point(248, 12);
            this.pctImagem.Name = "pctImagem";
            this.pctImagem.Size = new System.Drawing.Size(127, 134);
            this.pctImagem.TabIndex = 82;
            this.pctImagem.TabStop = false;
            // 
            // btnMatricula
            // 
            this.btnMatricula.BackColor = System.Drawing.Color.Transparent;
            this.btnMatricula.BackgroundImage = global::GuiWindowsForms.Properties.Resources.matricula_68x69_disabled;
            this.btnMatricula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMatricula.Enabled = false;
            this.btnMatricula.FlatAppearance.BorderSize = 0;
            this.btnMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatricula.Location = new System.Drawing.Point(898, 88);
            this.btnMatricula.Margin = new System.Windows.Forms.Padding(0);
            this.btnMatricula.Name = "btnMatricula";
            this.btnMatricula.Size = new System.Drawing.Size(68, 69);
            this.btnMatricula.TabIndex = 88;
            this.btnMatricula.Tag = "Dados Pessoais";
            this.btnMatricula.UseVisualStyleBackColor = false;
            // 
            // lblMatricula_menu
            // 
            this.lblMatricula_menu.AutoSize = true;
            this.lblMatricula_menu.BackColor = System.Drawing.Color.Transparent;
            this.lblMatricula_menu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblMatricula_menu.ForeColor = System.Drawing.Color.White;
            this.lblMatricula_menu.Location = new System.Drawing.Point(900, 166);
            this.lblMatricula_menu.Name = "lblMatricula_menu";
            this.lblMatricula_menu.Size = new System.Drawing.Size(69, 17);
            this.lblMatricula_menu.TabIndex = 66;
            this.lblMatricula_menu.Text = "Matrícula";
            this.lblMatricula_menu.Visible = false;
            // 
            // btnDados
            // 
            this.btnDados.AccessibleDescription = "";
            this.btnDados.BackColor = System.Drawing.Color.Transparent;
            this.btnDados.BackgroundImage = global::GuiWindowsForms.Properties.Resources.dados_73x74;
            this.btnDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDados.FlatAppearance.BorderSize = 0;
            this.btnDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDados.Location = new System.Drawing.Point(898, 191);
            this.btnDados.Margin = new System.Windows.Forms.Padding(0);
            this.btnDados.Name = "btnDados";
            this.btnDados.Size = new System.Drawing.Size(73, 74);
            this.btnDados.TabIndex = 89;
            this.btnDados.Tag = "";
            this.btnDados.UseVisualStyleBackColor = false;
            this.btnDados.MouseLeave += new System.EventHandler(this.btnDados_MouseLeave);
            this.btnDados.Click += new System.EventHandler(this.btnDados_Click);
            this.btnDados.MouseEnter += new System.EventHandler(this.btnDados_MouseEnter);
            // 
            // lblDados_Menu
            // 
            this.lblDados_Menu.AutoSize = true;
            this.lblDados_Menu.BackColor = System.Drawing.Color.Transparent;
            this.lblDados_Menu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblDados_Menu.ForeColor = System.Drawing.Color.Yellow;
            this.lblDados_Menu.Location = new System.Drawing.Point(876, 265);
            this.lblDados_Menu.Name = "lblDados_Menu";
            this.lblDados_Menu.Size = new System.Drawing.Size(110, 17);
            this.lblDados_Menu.TabIndex = 90;
            this.lblDados_Menu.Text = "Dados Pessoais";
            this.lblDados_Menu.Visible = false;
            // 
            // btnResponsaveis
            // 
            this.btnResponsaveis.BackColor = System.Drawing.Color.Transparent;
            this.btnResponsaveis.BackgroundImage = global::GuiWindowsForms.Properties.Resources.responsavel_73x66;
            this.btnResponsaveis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResponsaveis.FlatAppearance.BorderSize = 0;
            this.btnResponsaveis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResponsaveis.Location = new System.Drawing.Point(898, 283);
            this.btnResponsaveis.Margin = new System.Windows.Forms.Padding(0);
            this.btnResponsaveis.Name = "btnResponsaveis";
            this.btnResponsaveis.Size = new System.Drawing.Size(73, 66);
            this.btnResponsaveis.TabIndex = 91;
            this.btnResponsaveis.Tag = "Responsáveis";
            this.btnResponsaveis.UseVisualStyleBackColor = false;
            this.btnResponsaveis.MouseLeave += new System.EventHandler(this.btnResponsaveis_MouseLeave);
            this.btnResponsaveis.Click += new System.EventHandler(this.btnResponsavel_Click);
            this.btnResponsaveis.MouseEnter += new System.EventHandler(this.btnResponsaveis_MouseEnter);
            // 
            // lblResponsavel_menu
            // 
            this.lblResponsavel_menu.AutoSize = true;
            this.lblResponsavel_menu.BackColor = System.Drawing.Color.Transparent;
            this.lblResponsavel_menu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblResponsavel_menu.ForeColor = System.Drawing.Color.Yellow;
            this.lblResponsavel_menu.Location = new System.Drawing.Point(885, 353);
            this.lblResponsavel_menu.Name = "lblResponsavel_menu";
            this.lblResponsavel_menu.Size = new System.Drawing.Size(97, 17);
            this.lblResponsavel_menu.TabIndex = 92;
            this.lblResponsavel_menu.Text = "Responsáveis";
            this.lblResponsavel_menu.Visible = false;
            // 
            // btnInfoMedica
            // 
            this.btnInfoMedica.BackColor = System.Drawing.Color.Transparent;
            this.btnInfoMedica.BackgroundImage = global::GuiWindowsForms.Properties.Resources.injecao_73x73;
            this.btnInfoMedica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfoMedica.FlatAppearance.BorderSize = 0;
            this.btnInfoMedica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoMedica.Location = new System.Drawing.Point(898, 379);
            this.btnInfoMedica.Margin = new System.Windows.Forms.Padding(0);
            this.btnInfoMedica.Name = "btnInfoMedica";
            this.btnInfoMedica.Size = new System.Drawing.Size(73, 73);
            this.btnInfoMedica.TabIndex = 93;
            this.btnInfoMedica.Tag = "Informações Médicas";
            this.btnInfoMedica.UseVisualStyleBackColor = false;
            this.btnInfoMedica.MouseLeave += new System.EventHandler(this.btnInfoMedica_MouseLeave);
            this.btnInfoMedica.Click += new System.EventHandler(this.btnInfoMedica_Click);
            this.btnInfoMedica.MouseEnter += new System.EventHandler(this.btnInfoMedica_MouseEnter);
            // 
            // lblMedico_menu
            // 
            this.lblMedico_menu.AutoSize = true;
            this.lblMedico_menu.BackColor = System.Drawing.Color.Transparent;
            this.lblMedico_menu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblMedico_menu.ForeColor = System.Drawing.Color.Yellow;
            this.lblMedico_menu.Location = new System.Drawing.Point(889, 455);
            this.lblMedico_menu.Name = "lblMedico_menu";
            this.lblMedico_menu.Size = new System.Drawing.Size(88, 17);
            this.lblMedico_menu.TabIndex = 94;
            this.lblMedico_menu.Text = "Inf. Médicas";
            this.lblMedico_menu.Visible = false;
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.BackColor = System.Drawing.Color.Transparent;
            this.btnFinanceiro.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_73x60;
            this.btnFinanceiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinanceiro.FlatAppearance.BorderSize = 0;
            this.btnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanceiro.Location = new System.Drawing.Point(898, 478);
            this.btnFinanceiro.Margin = new System.Windows.Forms.Padding(0);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(73, 60);
            this.btnFinanceiro.TabIndex = 48;
            this.btnFinanceiro.Tag = "Informações Financeiras";
            this.btnFinanceiro.UseVisualStyleBackColor = false;
            this.btnFinanceiro.MouseLeave += new System.EventHandler(this.btnFinanceiro_MouseLeave);
            this.btnFinanceiro.Click += new System.EventHandler(this.btnFinanceiro_Click);
            this.btnFinanceiro.MouseEnter += new System.EventHandler(this.btnFinanceiro_MouseEnter);
            // 
            // lblFinanceiro_menu
            // 
            this.lblFinanceiro_menu.AutoSize = true;
            this.lblFinanceiro_menu.BackColor = System.Drawing.Color.Transparent;
            this.lblFinanceiro_menu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblFinanceiro_menu.ForeColor = System.Drawing.Color.Yellow;
            this.lblFinanceiro_menu.Location = new System.Drawing.Point(895, 548);
            this.lblFinanceiro_menu.Name = "lblFinanceiro_menu";
            this.lblFinanceiro_menu.Size = new System.Drawing.Size(77, 17);
            this.lblFinanceiro_menu.TabIndex = 95;
            this.lblFinanceiro_menu.Text = "Financeiro";
            this.lblFinanceiro_menu.Visible = false;
            // 
            // btnAcademico
            // 
            this.btnAcademico.BackColor = System.Drawing.Color.Transparent;
            this.btnAcademico.BackgroundImage = global::GuiWindowsForms.Properties.Resources.academico_73x72;
            this.btnAcademico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcademico.FlatAppearance.BorderSize = 0;
            this.btnAcademico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcademico.Location = new System.Drawing.Point(898, 574);
            this.btnAcademico.Margin = new System.Windows.Forms.Padding(0);
            this.btnAcademico.Name = "btnAcademico";
            this.btnAcademico.Size = new System.Drawing.Size(73, 72);
            this.btnAcademico.TabIndex = 96;
            this.btnAcademico.Tag = "Dados Acadêmicos";
            this.btnAcademico.UseVisualStyleBackColor = false;
            this.btnAcademico.MouseLeave += new System.EventHandler(this.btnAcademico_MouseLeave);
            this.btnAcademico.Click += new System.EventHandler(this.btnAcademico_Click);
            this.btnAcademico.MouseEnter += new System.EventHandler(this.btnAcademico_MouseEnter);
            // 
            // lblAcademico_menu
            // 
            this.lblAcademico_menu.AutoSize = true;
            this.lblAcademico_menu.BackColor = System.Drawing.Color.Transparent;
            this.lblAcademico_menu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblAcademico_menu.ForeColor = System.Drawing.Color.Yellow;
            this.lblAcademico_menu.Location = new System.Drawing.Point(895, 646);
            this.lblAcademico_menu.Name = "lblAcademico_menu";
            this.lblAcademico_menu.Size = new System.Drawing.Size(81, 17);
            this.lblAcademico_menu.TabIndex = 63;
            this.lblAcademico_menu.Text = "Acadêmico";
            this.lblAcademico_menu.Visible = false;
            // 
            // lblInfoControles
            // 
            this.lblInfoControles.AutoSize = true;
            this.lblInfoControles.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoControles.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblInfoControles.ForeColor = System.Drawing.Color.Yellow;
            this.lblInfoControles.Location = new System.Drawing.Point(141, 685);
            this.lblInfoControles.Name = "lblInfoControles";
            this.lblInfoControles.Size = new System.Drawing.Size(14, 19);
            this.lblInfoControles.TabIndex = 99;
            this.lblInfoControles.Text = "-";
            this.lblInfoControles.Visible = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.voltar_final_32x32;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(31, 677);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(33, 34);
            this.btnVoltar.TabIndex = 98;
            this.btnVoltar.Tag = "";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.MouseLeave += new System.EventHandler(this.btnVoltar_MouseLeave);
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            this.btnVoltar.MouseEnter += new System.EventHandler(this.btnVoltar_MouseEnter);
            // 
            // btnMatriculaAtividade
            // 
            this.btnMatriculaAtividade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMatriculaAtividade.Location = new System.Drawing.Point(39, 574);
            this.btnMatriculaAtividade.Name = "btnMatriculaAtividade";
            this.btnMatriculaAtividade.Size = new System.Drawing.Size(176, 23);
            this.btnMatriculaAtividade.TabIndex = 48;
            this.btnMatriculaAtividade.Text = "Matrícula de Atividade";
            this.btnMatriculaAtividade.UseVisualStyleBackColor = true;
            // 
            // telaAlunoMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GuiWindowsForms.Properties.Resources.modelo_tela_iconemenor;
            this.ClientSize = new System.Drawing.Size(1000, 722);
            this.Controls.Add(this.btnMatriculaAtividade);
            this.Controls.Add(this.lblInfoControles);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblAcademico_menu);
            this.Controls.Add(this.btnAcademico);
            this.Controls.Add(this.lblFinanceiro_menu);
            this.Controls.Add(this.btnFinanceiro);
            this.Controls.Add(this.lblMedico_menu);
            this.Controls.Add(this.btnInfoMedica);
            this.Controls.Add(this.lblResponsavel_menu);
            this.Controls.Add(this.btnResponsaveis);
            this.Controls.Add(this.lblDados_Menu);
            this.Controls.Add(this.btnDados);
            this.Controls.Add(this.lblMatricula_menu);
            this.Controls.Add(this.btnMatricula);
            this.Controls.Add(this.lblFoneEmerg);
            this.Controls.Add(this.lblResponsavel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblNomeAluno);
            this.Controls.Add(this.pctImagem);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.lblHelloUsuario);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gpbMatricula);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaAlunoMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaAlunoMatricula_FormClosing);
            this.gpbMatricula.ResumeLayout(false);
            this.gpbMatricula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbMatricula;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblHelloUsuario;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ComboBox cmbSerie;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.ComboBox cmbTurma;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label lblDataMatricula;
        private System.Windows.Forms.Label lblNumeroMatricula;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblTotalValor;
        private System.Windows.Forms.TextBox txtTotalValor;
        private System.Windows.Forms.Label lblFoneEmerg;
        private System.Windows.Forms.Label lblResponsavel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.PictureBox pctImagem;
        private System.Windows.Forms.Button btnMatricula;
        private System.Windows.Forms.Label lblMatricula_menu;
        private System.Windows.Forms.Button btnDados;
        private System.Windows.Forms.Label lblDados_Menu;
        private System.Windows.Forms.Button btnResponsaveis;
        private System.Windows.Forms.Label lblResponsavel_menu;
        private System.Windows.Forms.Button btnInfoMedica;
        private System.Windows.Forms.Label lblMedico_menu;
        private System.Windows.Forms.Button btnFinanceiro;
        private System.Windows.Forms.Label lblFinanceiro_menu;
        private System.Windows.Forms.Button btnAcademico;
        private System.Windows.Forms.Label lblAcademico_menu;
        private System.Windows.Forms.Label lblInfoControles;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnMatriculaAtividade;
    }
}