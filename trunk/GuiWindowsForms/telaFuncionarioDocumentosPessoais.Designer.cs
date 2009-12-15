namespace GuiWindowsForms
{
    partial class telaFuncionarioDocumentosPessoais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaFuncionarioDocumentosPessoais));
            this.pctImagem = new System.Windows.Forms.PictureBox();
            this.gpbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.lblUfIdentidade = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblEmissor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbNacionalidade = new System.Windows.Forms.ComboBox();
            this.lblNacionalidade = new System.Windows.Forms.Label();
            this.lblFiliacao = new System.Windows.Forms.Label();
            this.txtFiliacaoPai = new System.Windows.Forms.TextBox();
            this.lblPai = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtFiliacaoMae = new System.Windows.Forms.TextBox();
            this.lblMae = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblInfoControles = new System.Windows.Forms.Label();
            this.lblAcademico_menu = new System.Windows.Forms.Label();
            this.lblFinanceiro_menu = new System.Windows.Forms.Label();
            this.lblMedico_menu = new System.Windows.Forms.Label();
            this.lblDados_Menu = new System.Windows.Forms.Label();
            this.btnDadosProfissionais = new System.Windows.Forms.Button();
            this.btnBeneficiario = new System.Windows.Forms.Button();
            this.btnDocumentos = new System.Windows.Forms.Button();
            this.btnDadosPessoais = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.lblHelloUsuario = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).BeginInit();
            this.gpbDadosPessoais.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctImagem
            // 
            this.pctImagem.BackColor = System.Drawing.Color.Transparent;
            this.pctImagem.Location = new System.Drawing.Point(250, 12);
            this.pctImagem.Name = "pctImagem";
            this.pctImagem.Size = new System.Drawing.Size(127, 134);
            this.pctImagem.TabIndex = 38;
            this.pctImagem.TabStop = false;
            // 
            // gpbDadosPessoais
            // 
            this.gpbDadosPessoais.BackColor = System.Drawing.Color.Transparent;
            this.gpbDadosPessoais.Controls.Add(this.lblUfIdentidade);
            this.gpbDadosPessoais.Controls.Add(this.textBox2);
            this.gpbDadosPessoais.Controls.Add(this.lblEmissor);
            this.gpbDadosPessoais.Controls.Add(this.textBox1);
            this.gpbDadosPessoais.Controls.Add(this.lblEstadoCivil);
            this.gpbDadosPessoais.Controls.Add(this.comboBox1);
            this.gpbDadosPessoais.Controls.Add(this.cmbNacionalidade);
            this.gpbDadosPessoais.Controls.Add(this.lblNacionalidade);
            this.gpbDadosPessoais.Controls.Add(this.lblFiliacao);
            this.gpbDadosPessoais.Controls.Add(this.txtFiliacaoPai);
            this.gpbDadosPessoais.Controls.Add(this.lblPai);
            this.gpbDadosPessoais.Controls.Add(this.mskCpf);
            this.gpbDadosPessoais.Controls.Add(this.txtRg);
            this.gpbDadosPessoais.Controls.Add(this.txtFiliacaoMae);
            this.gpbDadosPessoais.Controls.Add(this.lblMae);
            this.gpbDadosPessoais.Controls.Add(this.lblCpf);
            this.gpbDadosPessoais.Controls.Add(this.lblRg);
            this.gpbDadosPessoais.Controls.Add(this.dtpNascimento);
            this.gpbDadosPessoais.Controls.Add(this.lblNascimento);
            this.gpbDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosPessoais.Location = new System.Drawing.Point(39, 191);
            this.gpbDadosPessoais.Name = "gpbDadosPessoais";
            this.gpbDadosPessoais.Size = new System.Drawing.Size(820, 487);
            this.gpbDadosPessoais.TabIndex = 40;
            this.gpbDadosPessoais.TabStop = false;
            this.gpbDadosPessoais.Text = "DOCUMENTOS PESSOAIS DO FUNCIONÁRIO";
            // 
            // lblUfIdentidade
            // 
            this.lblUfIdentidade.AutoSize = true;
            this.lblUfIdentidade.Location = new System.Drawing.Point(419, 114);
            this.lblUfIdentidade.Name = "lblUfIdentidade";
            this.lblUfIdentidade.Size = new System.Drawing.Size(27, 13);
            this.lblUfIdentidade.TabIndex = 49;
            this.lblUfIdentidade.Text = "UF:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox2.Location = new System.Drawing.Point(452, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(40, 23);
            this.textBox2.TabIndex = 48;
            // 
            // lblEmissor
            // 
            this.lblEmissor.AutoSize = true;
            this.lblEmissor.Location = new System.Drawing.Point(312, 114);
            this.lblEmissor.Name = "lblEmissor";
            this.lblEmissor.Size = new System.Drawing.Size(54, 13);
            this.lblEmissor.TabIndex = 47;
            this.lblEmissor.Text = "Emissor:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.Location = new System.Drawing.Point(368, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 23);
            this.textBox1.TabIndex = 46;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(33, 388);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(78, 13);
            this.lblEstadoCivil.TabIndex = 45;
            this.lblEstadoCivil.Text = "Estado Civil:";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(114, 385);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 21);
            this.comboBox1.TabIndex = 44;
            // 
            // cmbNacionalidade
            // 
            this.cmbNacionalidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbNacionalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNacionalidade.FormattingEnabled = true;
            this.cmbNacionalidade.Location = new System.Drawing.Point(134, 163);
            this.cmbNacionalidade.Name = "cmbNacionalidade";
            this.cmbNacionalidade.Size = new System.Drawing.Size(158, 21);
            this.cmbNacionalidade.TabIndex = 41;
            // 
            // lblNacionalidade
            // 
            this.lblNacionalidade.AutoSize = true;
            this.lblNacionalidade.Location = new System.Drawing.Point(36, 166);
            this.lblNacionalidade.Name = "lblNacionalidade";
            this.lblNacionalidade.Size = new System.Drawing.Size(92, 13);
            this.lblNacionalidade.TabIndex = 40;
            this.lblNacionalidade.Text = "Nacionalidade:";
            // 
            // lblFiliacao
            // 
            this.lblFiliacao.AutoSize = true;
            this.lblFiliacao.Location = new System.Drawing.Point(61, 299);
            this.lblFiliacao.Name = "lblFiliacao";
            this.lblFiliacao.Size = new System.Drawing.Size(62, 13);
            this.lblFiliacao.TabIndex = 39;
            this.lblFiliacao.Text = "FILIAÇÃO";
            // 
            // txtFiliacaoPai
            // 
            this.txtFiliacaoPai.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtFiliacaoPai.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtFiliacaoPai.Location = new System.Drawing.Point(159, 325);
            this.txtFiliacaoPai.MaxLength = 30;
            this.txtFiliacaoPai.Name = "txtFiliacaoPai";
            this.txtFiliacaoPai.Size = new System.Drawing.Size(222, 23);
            this.txtFiliacaoPai.TabIndex = 38;
            // 
            // lblPai
            // 
            this.lblPai.AutoSize = true;
            this.lblPai.Location = new System.Drawing.Point(124, 328);
            this.lblPai.Name = "lblPai";
            this.lblPai.Size = new System.Drawing.Size(29, 13);
            this.lblPai.TabIndex = 37;
            this.lblPai.Text = "Pai:";
            // 
            // mskCpf
            // 
            this.mskCpf.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.mskCpf.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mskCpf.Location = new System.Drawing.Point(315, 70);
            this.mskCpf.Mask = "000.000.000-99";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(100, 23);
            this.mskCpf.TabIndex = 36;
            // 
            // txtRg
            // 
            this.txtRg.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtRg.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtRg.Location = new System.Drawing.Point(127, 114);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(158, 23);
            this.txtRg.TabIndex = 35;
            // 
            // txtFiliacaoMae
            // 
            this.txtFiliacaoMae.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtFiliacaoMae.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtFiliacaoMae.Location = new System.Drawing.Point(445, 325);
            this.txtFiliacaoMae.MaxLength = 40;
            this.txtFiliacaoMae.Name = "txtFiliacaoMae";
            this.txtFiliacaoMae.Size = new System.Drawing.Size(220, 23);
            this.txtFiliacaoMae.TabIndex = 34;
            // 
            // lblMae
            // 
            this.lblMae.AutoSize = true;
            this.lblMae.Location = new System.Drawing.Point(404, 330);
            this.lblMae.Name = "lblMae";
            this.lblMae.Size = new System.Drawing.Size(35, 13);
            this.lblMae.TabIndex = 33;
            this.lblMae.Text = "Mãe:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(275, 70);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(34, 13);
            this.lblCpf.TabIndex = 9;
            this.lblCpf.Text = "CPF:";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(43, 114);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(71, 13);
            this.lblRg.TabIndex = 7;
            this.lblRg.Text = "Identidade:";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.CalendarForeColor = System.Drawing.Color.MidnightBlue;
            this.dtpNascimento.CalendarTitleForeColor = System.Drawing.Color.MidnightBlue;
            this.dtpNascimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNascimento.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(128, 70);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(110, 23);
            this.dtpNascimento.TabIndex = 2;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(46, 70);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(77, 13);
            this.lblNascimento.TabIndex = 1;
            this.lblNascimento.Text = "Nascimento:";
            // 
            // lblInfoControles
            // 
            this.lblInfoControles.AutoSize = true;
            this.lblInfoControles.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoControles.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblInfoControles.ForeColor = System.Drawing.Color.Yellow;
            this.lblInfoControles.Location = new System.Drawing.Point(130, 692);
            this.lblInfoControles.Name = "lblInfoControles";
            this.lblInfoControles.Size = new System.Drawing.Size(14, 19);
            this.lblInfoControles.TabIndex = 83;
            this.lblInfoControles.Text = "-";
            this.lblInfoControles.Visible = false;
            // 
            // lblAcademico_menu
            // 
            this.lblAcademico_menu.AutoSize = true;
            this.lblAcademico_menu.BackColor = System.Drawing.Color.Transparent;
            this.lblAcademico_menu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblAcademico_menu.ForeColor = System.Drawing.Color.Yellow;
            this.lblAcademico_menu.Location = new System.Drawing.Point(859, 564);
            this.lblAcademico_menu.Name = "lblAcademico_menu";
            this.lblAcademico_menu.Size = new System.Drawing.Size(136, 17);
            this.lblAcademico_menu.TabIndex = 82;
            this.lblAcademico_menu.Text = "Dados Profissionais";
            this.lblAcademico_menu.Visible = false;
            // 
            // lblFinanceiro_menu
            // 
            this.lblFinanceiro_menu.AutoSize = true;
            this.lblFinanceiro_menu.BackColor = System.Drawing.Color.Transparent;
            this.lblFinanceiro_menu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblFinanceiro_menu.ForeColor = System.Drawing.Color.Yellow;
            this.lblFinanceiro_menu.Location = new System.Drawing.Point(877, 466);
            this.lblFinanceiro_menu.Name = "lblFinanceiro_menu";
            this.lblFinanceiro_menu.Size = new System.Drawing.Size(94, 17);
            this.lblFinanceiro_menu.TabIndex = 81;
            this.lblFinanceiro_menu.Text = "Beneficiários";
            this.lblFinanceiro_menu.Visible = false;
            // 
            // lblMedico_menu
            // 
            this.lblMedico_menu.AutoSize = true;
            this.lblMedico_menu.BackColor = System.Drawing.Color.Transparent;
            this.lblMedico_menu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblMedico_menu.ForeColor = System.Drawing.Color.Yellow;
            this.lblMedico_menu.Location = new System.Drawing.Point(878, 373);
            this.lblMedico_menu.Name = "lblMedico_menu";
            this.lblMedico_menu.Size = new System.Drawing.Size(89, 17);
            this.lblMedico_menu.TabIndex = 80;
            this.lblMedico_menu.Text = "Documentos";
            this.lblMedico_menu.Visible = false;
            // 
            // lblDados_Menu
            // 
            this.lblDados_Menu.AutoSize = true;
            this.lblDados_Menu.BackColor = System.Drawing.Color.Transparent;
            this.lblDados_Menu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblDados_Menu.ForeColor = System.Drawing.Color.Yellow;
            this.lblDados_Menu.Location = new System.Drawing.Point(865, 272);
            this.lblDados_Menu.Name = "lblDados_Menu";
            this.lblDados_Menu.Size = new System.Drawing.Size(110, 17);
            this.lblDados_Menu.TabIndex = 78;
            this.lblDados_Menu.Text = "Dados Pessoais";
            this.lblDados_Menu.Visible = false;
            // 
            // btnDadosProfissionais
            // 
            this.btnDadosProfissionais.BackColor = System.Drawing.Color.Transparent;
            this.btnDadosProfissionais.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_profissional;
            this.btnDadosProfissionais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDadosProfissionais.FlatAppearance.BorderSize = 0;
            this.btnDadosProfissionais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDadosProfissionais.Location = new System.Drawing.Point(887, 492);
            this.btnDadosProfissionais.Margin = new System.Windows.Forms.Padding(0);
            this.btnDadosProfissionais.Name = "btnDadosProfissionais";
            this.btnDadosProfissionais.Size = new System.Drawing.Size(72, 72);
            this.btnDadosProfissionais.TabIndex = 77;
            this.btnDadosProfissionais.Tag = "";
            this.btnDadosProfissionais.UseVisualStyleBackColor = false;
            // 
            // btnBeneficiario
            // 
            this.btnBeneficiario.BackColor = System.Drawing.Color.Transparent;
            this.btnBeneficiario.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_dependentes;
            this.btnBeneficiario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBeneficiario.FlatAppearance.BorderSize = 0;
            this.btnBeneficiario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeneficiario.Location = new System.Drawing.Point(887, 396);
            this.btnBeneficiario.Margin = new System.Windows.Forms.Padding(0);
            this.btnBeneficiario.Name = "btnBeneficiario";
            this.btnBeneficiario.Size = new System.Drawing.Size(72, 72);
            this.btnBeneficiario.TabIndex = 76;
            this.btnBeneficiario.Tag = "";
            this.btnBeneficiario.UseVisualStyleBackColor = false;
            // 
            // btnDocumentos
            // 
            this.btnDocumentos.BackColor = System.Drawing.Color.Transparent;
            this.btnDocumentos.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_documentos;
            this.btnDocumentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDocumentos.FlatAppearance.BorderSize = 0;
            this.btnDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocumentos.Location = new System.Drawing.Point(887, 297);
            this.btnDocumentos.Margin = new System.Windows.Forms.Padding(0);
            this.btnDocumentos.Name = "btnDocumentos";
            this.btnDocumentos.Size = new System.Drawing.Size(72, 72);
            this.btnDocumentos.TabIndex = 75;
            this.btnDocumentos.Tag = "";
            this.btnDocumentos.UseVisualStyleBackColor = false;
            // 
            // btnDadosPessoais
            // 
            this.btnDadosPessoais.AccessibleDescription = "";
            this.btnDadosPessoais.BackColor = System.Drawing.Color.Transparent;
            this.btnDadosPessoais.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_dados;
            this.btnDadosPessoais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDadosPessoais.FlatAppearance.BorderSize = 0;
            this.btnDadosPessoais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDadosPessoais.Location = new System.Drawing.Point(887, 198);
            this.btnDadosPessoais.Margin = new System.Windows.Forms.Padding(0);
            this.btnDadosPessoais.Name = "btnDadosPessoais";
            this.btnDadosPessoais.Size = new System.Drawing.Size(72, 72);
            this.btnDadosPessoais.TabIndex = 73;
            this.btnDadosPessoais.Tag = "";
            this.btnDadosPessoais.UseVisualStyleBackColor = false;
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.BackColor = System.Drawing.Color.Transparent;
            this.btnDesconectar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.icone_desconectar;
            this.btnDesconectar.FlatAppearance.BorderSize = 0;
            this.btnDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconectar.Location = new System.Drawing.Point(922, 12);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(30, 30);
            this.btnDesconectar.TabIndex = 72;
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
            this.lblHelloUsuario.Location = new System.Drawing.Point(783, 12);
            this.lblHelloUsuario.Name = "lblHelloUsuario";
            this.lblHelloUsuario.Size = new System.Drawing.Size(133, 23);
            this.lblHelloUsuario.TabIndex = 71;
            this.lblHelloUsuario.Text = "Hello Usuário!";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.ok_32x32_tipo2_final;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(75, 684);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(36, 29);
            this.btnSalvar.TabIndex = 70;
            this.btnSalvar.Tag = "";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.MouseLeave += new System.EventHandler(this.btnSalvar_MouseLeave);
            this.btnSalvar.MouseEnter += new System.EventHandler(this.btnSalvar_MouseEnter);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.voltar_final_32x32;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(20, 684);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(33, 34);
            this.btnVoltar.TabIndex = 69;
            this.btnVoltar.Tag = "";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.MouseLeave += new System.EventHandler(this.btnVoltar_MouseLeave);
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            this.btnVoltar.MouseEnter += new System.EventHandler(this.btnVoltar_MouseEnter);
            // 
            // telaFuncionarioDocumentosPessoais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GuiWindowsForms.Properties.Resources.modelo_tela_iconemenor;
            this.ClientSize = new System.Drawing.Size(1000, 722);
            this.Controls.Add(this.lblInfoControles);
            this.Controls.Add(this.lblAcademico_menu);
            this.Controls.Add(this.lblFinanceiro_menu);
            this.Controls.Add(this.lblMedico_menu);
            this.Controls.Add(this.lblDados_Menu);
            this.Controls.Add(this.btnDadosProfissionais);
            this.Controls.Add(this.btnBeneficiario);
            this.Controls.Add(this.btnDocumentos);
            this.Controls.Add(this.btnDadosPessoais);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.lblHelloUsuario);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.gpbDadosPessoais);
            this.Controls.Add(this.pctImagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaFuncionarioDocumentosPessoais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaFuncionarioDocumentosPessoais_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).EndInit();
            this.gpbDadosPessoais.ResumeLayout(false);
            this.gpbDadosPessoais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctImagem;
        private System.Windows.Forms.GroupBox gpbDadosPessoais;
        private System.Windows.Forms.Label lblUfIdentidade;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblEmissor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmbNacionalidade;
        private System.Windows.Forms.Label lblNacionalidade;
        private System.Windows.Forms.Label lblFiliacao;
        private System.Windows.Forms.TextBox txtFiliacaoPai;
        private System.Windows.Forms.Label lblPai;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtFiliacaoMae;
        private System.Windows.Forms.Label lblMae;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblInfoControles;
        private System.Windows.Forms.Label lblAcademico_menu;
        private System.Windows.Forms.Label lblFinanceiro_menu;
        private System.Windows.Forms.Label lblMedico_menu;
        private System.Windows.Forms.Label lblDados_Menu;
        private System.Windows.Forms.Button btnDadosProfissionais;
        private System.Windows.Forms.Button btnBeneficiario;
        private System.Windows.Forms.Button btnDocumentos;
        private System.Windows.Forms.Button btnDadosPessoais;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Label lblHelloUsuario;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
    }
}