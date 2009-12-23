﻿namespace GuiWindowsForms
{
    partial class telaFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaFuncionario));
            this.btnAdicionarImagem = new System.Windows.Forms.Button();
            this.gpbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.lblEdificio = new System.Windows.Forms.Label();
            this.txtNomeEdificil = new System.Windows.Forms.TextBox();
            this.mskFoneResidencia = new System.Windows.Forms.MaskedTextBox();
            this.cmbUf = new System.Windows.Forms.ComboBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.lblFoneResidencia = new System.Windows.Forms.Label();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.rdbFem = new System.Windows.Forms.RadioButton();
            this.rdbMasc = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblInfoControles = new System.Windows.Forms.Label();
            this.lblProfissionais_menu = new System.Windows.Forms.Label();
            this.lblDados_Menu = new System.Windows.Forms.Label();
            this.btnDadosProfissionais = new System.Windows.Forms.Button();
            this.btnDadosPessoais = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.lblHelloUsuario = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblAtivo = new System.Windows.Forms.Label();
            this.lblFone = new System.Windows.Forms.Label();
            this.lblFuncao = new System.Windows.Forms.Label();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.pctImagem = new System.Windows.Forms.PictureBox();
            this.gpbDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionarImagem
            // 
            this.btnAdicionarImagem.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarImagem.BackgroundImage = global::GuiWindowsForms.Properties.Resources.adicionar_final_32x32;
            this.btnAdicionarImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarImagem.FlatAppearance.BorderSize = 0;
            this.btnAdicionarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarImagem.Location = new System.Drawing.Point(290, 152);
            this.btnAdicionarImagem.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdicionarImagem.Name = "btnAdicionarImagem";
            this.btnAdicionarImagem.Size = new System.Drawing.Size(34, 34);
            this.btnAdicionarImagem.TabIndex = 38;
            this.btnAdicionarImagem.Tag = "Adicionar Foto";
            this.btnAdicionarImagem.UseVisualStyleBackColor = false;
            // 
            // gpbDadosPessoais
            // 
            this.gpbDadosPessoais.BackColor = System.Drawing.Color.Transparent;
            this.gpbDadosPessoais.Controls.Add(this.lblEdificio);
            this.gpbDadosPessoais.Controls.Add(this.txtNomeEdificil);
            this.gpbDadosPessoais.Controls.Add(this.mskFoneResidencia);
            this.gpbDadosPessoais.Controls.Add(this.cmbUf);
            this.gpbDadosPessoais.Controls.Add(this.txtComplemento);
            this.gpbDadosPessoais.Controls.Add(this.lblComplemento);
            this.gpbDadosPessoais.Controls.Add(this.lblUf);
            this.gpbDadosPessoais.Controls.Add(this.lblFoneResidencia);
            this.gpbDadosPessoais.Controls.Add(this.mskCep);
            this.gpbDadosPessoais.Controls.Add(this.label4);
            this.gpbDadosPessoais.Controls.Add(this.txtCidade);
            this.gpbDadosPessoais.Controls.Add(this.lblCidade);
            this.gpbDadosPessoais.Controls.Add(this.txtBairro);
            this.gpbDadosPessoais.Controls.Add(this.lblBairro);
            this.gpbDadosPessoais.Controls.Add(this.txtLogradouro);
            this.gpbDadosPessoais.Controls.Add(this.label3);
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
            this.gpbDadosPessoais.Controls.Add(this.rdbFem);
            this.gpbDadosPessoais.Controls.Add(this.rdbMasc);
            this.gpbDadosPessoais.Controls.Add(this.lblSexo);
            this.gpbDadosPessoais.Controls.Add(this.txtNome);
            this.gpbDadosPessoais.Controls.Add(this.dtpNascimento);
            this.gpbDadosPessoais.Controls.Add(this.lblNascimento);
            this.gpbDadosPessoais.Controls.Add(this.lblNome);
            this.gpbDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosPessoais.Location = new System.Drawing.Point(39, 191);
            this.gpbDadosPessoais.Name = "gpbDadosPessoais";
            this.gpbDadosPessoais.Size = new System.Drawing.Size(820, 487);
            this.gpbDadosPessoais.TabIndex = 39;
            this.gpbDadosPessoais.TabStop = false;
            this.gpbDadosPessoais.Text = "DADOS DO FUNCIONÁRIO";
            // 
            // lblEdificio
            // 
            this.lblEdificio.AutoSize = true;
            this.lblEdificio.Location = new System.Drawing.Point(47, 213);
            this.lblEdificio.Name = "lblEdificio";
            this.lblEdificio.Size = new System.Drawing.Size(55, 13);
            this.lblEdificio.TabIndex = 76;
            this.lblEdificio.Text = "Edifício:";
            // 
            // txtNomeEdificil
            // 
            this.txtNomeEdificil.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtNomeEdificil.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtNomeEdificil.Location = new System.Drawing.Point(127, 213);
            this.txtNomeEdificil.MaxLength = 30;
            this.txtNomeEdificil.Name = "txtNomeEdificil";
            this.txtNomeEdificil.Size = new System.Drawing.Size(200, 23);
            this.txtNomeEdificil.TabIndex = 75;
            // 
            // mskFoneResidencia
            // 
            this.mskFoneResidencia.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.mskFoneResidencia.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mskFoneResidencia.Location = new System.Drawing.Point(328, 301);
            this.mskFoneResidencia.Mask = "(99) 0000-0000";
            this.mskFoneResidencia.Name = "mskFoneResidencia";
            this.mskFoneResidencia.Size = new System.Drawing.Size(111, 23);
            this.mskFoneResidencia.TabIndex = 74;
            // 
            // cmbUf
            // 
            this.cmbUf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUf.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.cmbUf.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmbUf.FormattingEnabled = true;
            this.cmbUf.Location = new System.Drawing.Point(399, 258);
            this.cmbUf.MaxLength = 2;
            this.cmbUf.Name = "cmbUf";
            this.cmbUf.Size = new System.Drawing.Size(40, 24);
            this.cmbUf.TabIndex = 73;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtComplemento.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtComplemento.Location = new System.Drawing.Point(605, 166);
            this.txtComplemento.MaxLength = 30;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(200, 23);
            this.txtComplemento.TabIndex = 72;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(506, 166);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(86, 13);
            this.lblComplemento.TabIndex = 71;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(366, 258);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(27, 13);
            this.lblUf.TabIndex = 70;
            this.lblUf.Text = "UF:";
            // 
            // lblFoneResidencia
            // 
            this.lblFoneResidencia.AutoSize = true;
            this.lblFoneResidencia.Location = new System.Drawing.Point(238, 304);
            this.lblFoneResidencia.Name = "lblFoneResidencia";
            this.lblFoneResidencia.Size = new System.Drawing.Size(75, 13);
            this.lblFoneResidencia.TabIndex = 69;
            this.lblFoneResidencia.Text = "Fone Resid:";
            // 
            // mskCep
            // 
            this.mskCep.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.mskCep.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mskCep.Location = new System.Drawing.Point(127, 301);
            this.mskCep.Mask = "00000-999";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(72, 23);
            this.mskCep.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Cep:";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtCidade.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtCidade.Location = new System.Drawing.Point(603, 258);
            this.txtCidade.MaxLength = 30;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(200, 23);
            this.txtCidade.TabIndex = 66;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(504, 261);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(50, 13);
            this.lblCidade.TabIndex = 65;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtBairro.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtBairro.Location = new System.Drawing.Point(127, 258);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(200, 23);
            this.txtBairro.TabIndex = 64;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(47, 258);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(44, 13);
            this.lblBairro.TabIndex = 63;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtLogradouro.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtLogradouro.Location = new System.Drawing.Point(127, 165);
            this.txtLogradouro.MaxLength = 60;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(312, 23);
            this.txtLogradouro.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Endereço:";
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
            this.lblEstadoCivil.Location = new System.Drawing.Point(295, 438);
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
            this.comboBox1.Location = new System.Drawing.Point(376, 435);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 21);
            this.comboBox1.TabIndex = 44;
            // 
            // cmbNacionalidade
            // 
            this.cmbNacionalidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbNacionalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNacionalidade.FormattingEnabled = true;
            this.cmbNacionalidade.Location = new System.Drawing.Point(618, 435);
            this.cmbNacionalidade.Name = "cmbNacionalidade";
            this.cmbNacionalidade.Size = new System.Drawing.Size(158, 21);
            this.cmbNacionalidade.TabIndex = 41;
            // 
            // lblNacionalidade
            // 
            this.lblNacionalidade.AutoSize = true;
            this.lblNacionalidade.Location = new System.Drawing.Point(520, 438);
            this.lblNacionalidade.Name = "lblNacionalidade";
            this.lblNacionalidade.Size = new System.Drawing.Size(92, 13);
            this.lblNacionalidade.TabIndex = 40;
            this.lblNacionalidade.Text = "Nacionalidade:";
            // 
            // lblFiliacao
            // 
            this.lblFiliacao.AutoSize = true;
            this.lblFiliacao.Location = new System.Drawing.Point(48, 356);
            this.lblFiliacao.Name = "lblFiliacao";
            this.lblFiliacao.Size = new System.Drawing.Size(62, 13);
            this.lblFiliacao.TabIndex = 39;
            this.lblFiliacao.Text = "FILIAÇÃO";
            // 
            // txtFiliacaoPai
            // 
            this.txtFiliacaoPai.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtFiliacaoPai.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtFiliacaoPai.Location = new System.Drawing.Point(166, 382);
            this.txtFiliacaoPai.MaxLength = 30;
            this.txtFiliacaoPai.Name = "txtFiliacaoPai";
            this.txtFiliacaoPai.Size = new System.Drawing.Size(222, 23);
            this.txtFiliacaoPai.TabIndex = 38;
            // 
            // lblPai
            // 
            this.lblPai.AutoSize = true;
            this.lblPai.Location = new System.Drawing.Point(131, 385);
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
            this.txtFiliacaoMae.Location = new System.Drawing.Point(452, 382);
            this.txtFiliacaoMae.MaxLength = 40;
            this.txtFiliacaoMae.Name = "txtFiliacaoMae";
            this.txtFiliacaoMae.Size = new System.Drawing.Size(220, 23);
            this.txtFiliacaoMae.TabIndex = 34;
            // 
            // lblMae
            // 
            this.lblMae.AutoSize = true;
            this.lblMae.Location = new System.Drawing.Point(411, 387);
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
            // rdbFem
            // 
            this.rdbFem.AutoSize = true;
            this.rdbFem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbFem.Location = new System.Drawing.Point(569, 32);
            this.rdbFem.Name = "rdbFem";
            this.rdbFem.Size = new System.Drawing.Size(48, 17);
            this.rdbFem.TabIndex = 6;
            this.rdbFem.TabStop = true;
            this.rdbFem.Text = "Fem";
            this.rdbFem.UseVisualStyleBackColor = true;
            // 
            // rdbMasc
            // 
            this.rdbMasc.AutoSize = true;
            this.rdbMasc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbMasc.Location = new System.Drawing.Point(508, 32);
            this.rdbMasc.Name = "rdbMasc";
            this.rdbMasc.Size = new System.Drawing.Size(55, 17);
            this.rdbMasc.TabIndex = 5;
            this.rdbMasc.TabStop = true;
            this.rdbMasc.Text = "Masc";
            this.rdbMasc.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(463, 32);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(39, 13);
            this.lblSexo.TabIndex = 4;
            this.lblSexo.Text = "Sexo:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtNome.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtNome.Location = new System.Drawing.Point(128, 32);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(312, 23);
            this.txtNome.TabIndex = 3;
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
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(46, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
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
            this.lblInfoControles.TabIndex = 96;
            this.lblInfoControles.Text = "-";
            this.lblInfoControles.Visible = false;
            // 
            // lblProfissionais_menu
            // 
            this.lblProfissionais_menu.AutoSize = true;
            this.lblProfissionais_menu.BackColor = System.Drawing.Color.Transparent;
            this.lblProfissionais_menu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblProfissionais_menu.ForeColor = System.Drawing.Color.White;
            this.lblProfissionais_menu.Location = new System.Drawing.Point(862, 379);
            this.lblProfissionais_menu.Name = "lblProfissionais_menu";
            this.lblProfissionais_menu.Size = new System.Drawing.Size(136, 17);
            this.lblProfissionais_menu.TabIndex = 95;
            this.lblProfissionais_menu.Text = "Dados Profissionais";
            this.lblProfissionais_menu.Visible = false;
            // 
            // lblDados_Menu
            // 
            this.lblDados_Menu.AutoSize = true;
            this.lblDados_Menu.BackColor = System.Drawing.Color.Transparent;
            this.lblDados_Menu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblDados_Menu.ForeColor = System.Drawing.Color.Yellow;
            this.lblDados_Menu.Location = new System.Drawing.Point(877, 272);
            this.lblDados_Menu.Name = "lblDados_Menu";
            this.lblDados_Menu.Size = new System.Drawing.Size(110, 17);
            this.lblDados_Menu.TabIndex = 92;
            this.lblDados_Menu.Text = "Dados Pessoais";
            // 
            // btnDadosProfissionais
            // 
            this.btnDadosProfissionais.BackColor = System.Drawing.Color.Transparent;
            this.btnDadosProfissionais.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_profissional_64x71_disabled;
            this.btnDadosProfissionais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDadosProfissionais.FlatAppearance.BorderSize = 0;
            this.btnDadosProfissionais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDadosProfissionais.Location = new System.Drawing.Point(894, 299);
            this.btnDadosProfissionais.Margin = new System.Windows.Forms.Padding(0);
            this.btnDadosProfissionais.Name = "btnDadosProfissionais";
            this.btnDadosProfissionais.Size = new System.Drawing.Size(64, 71);
            this.btnDadosProfissionais.TabIndex = 91;
            this.btnDadosProfissionais.Tag = "";
            this.btnDadosProfissionais.UseVisualStyleBackColor = false;
            this.btnDadosProfissionais.MouseLeave += new System.EventHandler(this.btnDadosProfissionais_MouseLeave);
            this.btnDadosProfissionais.Click += new System.EventHandler(this.btnDadosProfissionais_Click);
            this.btnDadosProfissionais.MouseEnter += new System.EventHandler(this.btnDadosProfissionais_MouseEnter);
            // 
            // btnDadosPessoais
            // 
            this.btnDadosPessoais.AccessibleDescription = "";
            this.btnDadosPessoais.BackColor = System.Drawing.Color.Transparent;
            this.btnDadosPessoais.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_dados_71x62;
            this.btnDadosPessoais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDadosPessoais.Enabled = false;
            this.btnDadosPessoais.FlatAppearance.BorderSize = 0;
            this.btnDadosPessoais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDadosPessoais.Location = new System.Drawing.Point(887, 203);
            this.btnDadosPessoais.Margin = new System.Windows.Forms.Padding(0);
            this.btnDadosPessoais.Name = "btnDadosPessoais";
            this.btnDadosPessoais.Size = new System.Drawing.Size(71, 62);
            this.btnDadosPessoais.TabIndex = 88;
            this.btnDadosPessoais.Tag = "";
            this.btnDadosPessoais.UseVisualStyleBackColor = false;
            this.btnDadosPessoais.MouseLeave += new System.EventHandler(this.btnDadosPessoais_MouseLeave);
            this.btnDadosPessoais.Click += new System.EventHandler(this.btnDadosPessoais_Click);
            this.btnDadosPessoais.MouseEnter += new System.EventHandler(this.btnDadosPessoais_MouseEnter);
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
            this.btnDesconectar.TabIndex = 87;
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
            this.lblHelloUsuario.TabIndex = 86;
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
            this.btnSalvar.TabIndex = 85;
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
            this.btnVoltar.TabIndex = 84;
            this.btnVoltar.Tag = "";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.MouseLeave += new System.EventHandler(this.btnVoltar_MouseLeave);
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            this.btnVoltar.MouseEnter += new System.EventHandler(this.btnVoltar_MouseEnter);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_imprimir_50x50;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Location = new System.Drawing.Point(910, 630);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(50, 50);
            this.btnImprimir.TabIndex = 97;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.MouseLeave += new System.EventHandler(this.btnImprimir_MouseLeave);
            this.btnImprimir.MouseEnter += new System.EventHandler(this.btnImprimir_MouseEnter);
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.BackColor = System.Drawing.Color.Transparent;
            this.lblAtivo.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblAtivo.ForeColor = System.Drawing.Color.Green;
            this.lblAtivo.Location = new System.Drawing.Point(394, 106);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(49, 19);
            this.lblAtivo.TabIndex = 134;
            this.lblAtivo.Text = "Ativo";
            // 
            // lblFone
            // 
            this.lblFone.AutoSize = true;
            this.lblFone.BackColor = System.Drawing.Color.Transparent;
            this.lblFone.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblFone.ForeColor = System.Drawing.Color.Yellow;
            this.lblFone.Location = new System.Drawing.Point(394, 74);
            this.lblFone.Name = "lblFone";
            this.lblFone.Size = new System.Drawing.Size(50, 19);
            this.lblFone.TabIndex = 133;
            this.lblFone.Text = "Fone ";
            // 
            // lblFuncao
            // 
            this.lblFuncao.AutoSize = true;
            this.lblFuncao.BackColor = System.Drawing.Color.Transparent;
            this.lblFuncao.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblFuncao.ForeColor = System.Drawing.Color.Yellow;
            this.lblFuncao.Location = new System.Drawing.Point(394, 45);
            this.lblFuncao.Name = "lblFuncao";
            this.lblFuncao.Size = new System.Drawing.Size(63, 19);
            this.lblFuncao.TabIndex = 132;
            this.lblFuncao.Text = "Função";
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblNomeFuncionario.ForeColor = System.Drawing.Color.Yellow;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(394, 12);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(169, 19);
            this.lblNomeFuncionario.TabIndex = 131;
            this.lblNomeFuncionario.Text = "Nome do Funcionário";
            // 
            // pctImagem
            // 
            this.pctImagem.BackColor = System.Drawing.Color.Transparent;
            this.pctImagem.Location = new System.Drawing.Point(250, 12);
            this.pctImagem.Name = "pctImagem";
            this.pctImagem.Size = new System.Drawing.Size(127, 134);
            this.pctImagem.TabIndex = 130;
            this.pctImagem.TabStop = false;
            // 
            // telaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GuiWindowsForms.Properties.Resources.modelo_tela_iconemenor;
            this.ClientSize = new System.Drawing.Size(1000, 722);
            this.Controls.Add(this.lblAtivo);
            this.Controls.Add(this.lblFone);
            this.Controls.Add(this.lblFuncao);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Controls.Add(this.pctImagem);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblInfoControles);
            this.Controls.Add(this.gpbDadosPessoais);
            this.Controls.Add(this.lblProfissionais_menu);
            this.Controls.Add(this.btnAdicionarImagem);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblDados_Menu);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnDadosProfissionais);
            this.Controls.Add(this.lblHelloUsuario);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnDadosPessoais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaFuncionario_FormClosing);
            this.gpbDadosPessoais.ResumeLayout(false);
            this.gpbDadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarImagem;
        private System.Windows.Forms.GroupBox gpbDadosPessoais;
        private System.Windows.Forms.TextBox txtFiliacaoPai;
        private System.Windows.Forms.Label lblPai;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtFiliacaoMae;
        private System.Windows.Forms.Label lblMae;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.RadioButton rdbFem;
        private System.Windows.Forms.RadioButton rdbMasc;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblFiliacao;
        private System.Windows.Forms.ComboBox cmbNacionalidade;
        private System.Windows.Forms.Label lblNacionalidade;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblEmissor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblUfIdentidade;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblInfoControles;
        private System.Windows.Forms.Label lblProfissionais_menu;
        private System.Windows.Forms.Label lblDados_Menu;
        private System.Windows.Forms.Button btnDadosProfissionais;
        private System.Windows.Forms.Button btnDadosPessoais;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Label lblHelloUsuario;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblEdificio;
        private System.Windows.Forms.TextBox txtNomeEdificil;
        private System.Windows.Forms.MaskedTextBox mskFoneResidencia;
        private System.Windows.Forms.ComboBox cmbUf;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.Label lblFoneResidencia;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAtivo;
        private System.Windows.Forms.Label lblFone;
        private System.Windows.Forms.Label lblFuncao;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.PictureBox pctImagem;

    }
}