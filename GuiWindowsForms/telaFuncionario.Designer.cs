namespace GuiWindowsForms
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
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.lblHelloUsuario = new System.Windows.Forms.Label();
            this.btnAdicionarImagem = new System.Windows.Forms.Button();
            this.pctImagem = new System.Windows.Forms.PictureBox();
            this.gpbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.txtFiliacaoPai = new System.Windows.Forms.TextBox();
            this.lblPai = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtFiliacaoMae = new System.Windows.Forms.TextBox();
            this.lblMae = new System.Windows.Forms.Label();
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
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.rdbFem = new System.Windows.Forms.RadioButton();
            this.rdbMasc = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnBeneficiario = new System.Windows.Forms.Button();
            this.btnDadosProfissionais = new System.Windows.Forms.Button();
            this.lblFiliacao = new System.Windows.Forms.Label();
            this.cmbNacionalidade = new System.Windows.Forms.ComboBox();
            this.lblNacionalidade = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.btnDadosPessoais = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblEmissor = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblUfIdentidade = new System.Windows.Forms.Label();
            this.btnDocumentosPessoais = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).BeginInit();
            this.gpbDadosPessoais.SuspendLayout();
            this.SuspendLayout();
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
            this.btnDesconectar.TabIndex = 36;
            this.btnDesconectar.Tag = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = false;
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
            this.lblHelloUsuario.TabIndex = 35;
            this.lblHelloUsuario.Text = "Hello Usuário!";
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
            // pctImagem
            // 
            this.pctImagem.BackColor = System.Drawing.Color.Transparent;
            this.pctImagem.Location = new System.Drawing.Point(250, 12);
            this.pctImagem.Name = "pctImagem";
            this.pctImagem.Size = new System.Drawing.Size(127, 134);
            this.pctImagem.TabIndex = 37;
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
            // mskFoneResidencia
            // 
            this.mskFoneResidencia.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.mskFoneResidencia.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mskFoneResidencia.Location = new System.Drawing.Point(335, 294);
            this.mskFoneResidencia.Mask = "(99) 0000-0000";
            this.mskFoneResidencia.Name = "mskFoneResidencia";
            this.mskFoneResidencia.Size = new System.Drawing.Size(111, 23);
            this.mskFoneResidencia.TabIndex = 24;
            // 
            // cmbUf
            // 
            this.cmbUf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUf.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.cmbUf.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmbUf.FormattingEnabled = true;
            this.cmbUf.Location = new System.Drawing.Point(406, 251);
            this.cmbUf.MaxLength = 2;
            this.cmbUf.Name = "cmbUf";
            this.cmbUf.Size = new System.Drawing.Size(40, 24);
            this.cmbUf.TabIndex = 23;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtComplemento.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtComplemento.Location = new System.Drawing.Point(610, 205);
            this.txtComplemento.MaxLength = 30;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(200, 23);
            this.txtComplemento.TabIndex = 22;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(511, 205);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(86, 13);
            this.lblComplemento.TabIndex = 21;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(373, 251);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(27, 13);
            this.lblUf.TabIndex = 20;
            this.lblUf.Text = "UF:";
            // 
            // lblFoneResidencia
            // 
            this.lblFoneResidencia.AutoSize = true;
            this.lblFoneResidencia.Location = new System.Drawing.Point(245, 297);
            this.lblFoneResidencia.Name = "lblFoneResidencia";
            this.lblFoneResidencia.Size = new System.Drawing.Size(75, 13);
            this.lblFoneResidencia.TabIndex = 19;
            this.lblFoneResidencia.Text = "Fone Resid:";
            // 
            // mskCep
            // 
            this.mskCep.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.mskCep.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mskCep.Location = new System.Drawing.Point(134, 294);
            this.mskCep.Mask = "00000-999";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(72, 23);
            this.mskCep.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cep:";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtCidade.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtCidade.Location = new System.Drawing.Point(610, 251);
            this.txtCidade.MaxLength = 30;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(200, 23);
            this.txtCidade.TabIndex = 16;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(511, 254);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(50, 13);
            this.lblCidade.TabIndex = 15;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtBairro.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtBairro.Location = new System.Drawing.Point(134, 251);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(200, 23);
            this.txtBairro.TabIndex = 14;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(54, 251);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(44, 13);
            this.lblBairro.TabIndex = 13;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtLogradouro.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtLogradouro.Location = new System.Drawing.Point(134, 205);
            this.txtLogradouro.MaxLength = 60;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(312, 23);
            this.txtLogradouro.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Endereço:";
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
            // btnBeneficiario
            // 
            this.btnBeneficiario.Location = new System.Drawing.Point(878, 457);
            this.btnBeneficiario.Name = "btnBeneficiario";
            this.btnBeneficiario.Size = new System.Drawing.Size(104, 78);
            this.btnBeneficiario.TabIndex = 40;
            this.btnBeneficiario.Text = "BENEFICIARIO";
            this.btnBeneficiario.UseVisualStyleBackColor = true;
            // 
            // btnDadosProfissionais
            // 
            this.btnDadosProfissionais.Location = new System.Drawing.Point(878, 577);
            this.btnDadosProfissionais.Name = "btnDadosProfissionais";
            this.btnDadosProfissionais.Size = new System.Drawing.Size(104, 78);
            this.btnDadosProfissionais.TabIndex = 41;
            this.btnDadosProfissionais.Text = "DADOS PROFISSIONAIS";
            this.btnDadosProfissionais.UseVisualStyleBackColor = true;
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
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(295, 438);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(78, 13);
            this.lblEstadoCivil.TabIndex = 45;
            this.lblEstadoCivil.Text = "Estado Civil:";
            // 
            // btnDadosPessoais
            // 
            this.btnDadosPessoais.Location = new System.Drawing.Point(878, 206);
            this.btnDadosPessoais.Name = "btnDadosPessoais";
            this.btnDadosPessoais.Size = new System.Drawing.Size(104, 78);
            this.btnDadosPessoais.TabIndex = 42;
            this.btnDadosPessoais.Text = "DADOS PESSOAIS";
            this.btnDadosPessoais.UseVisualStyleBackColor = true;
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
            // lblEmissor
            // 
            this.lblEmissor.AutoSize = true;
            this.lblEmissor.Location = new System.Drawing.Point(312, 114);
            this.lblEmissor.Name = "lblEmissor";
            this.lblEmissor.Size = new System.Drawing.Size(54, 13);
            this.lblEmissor.TabIndex = 47;
            this.lblEmissor.Text = "Emissor:";
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
            // lblUfIdentidade
            // 
            this.lblUfIdentidade.AutoSize = true;
            this.lblUfIdentidade.Location = new System.Drawing.Point(419, 114);
            this.lblUfIdentidade.Name = "lblUfIdentidade";
            this.lblUfIdentidade.Size = new System.Drawing.Size(27, 13);
            this.lblUfIdentidade.TabIndex = 49;
            this.lblUfIdentidade.Text = "UF:";
            // 
            // btnDocumentosPessoais
            // 
            this.btnDocumentosPessoais.Location = new System.Drawing.Point(878, 331);
            this.btnDocumentosPessoais.Name = "btnDocumentosPessoais";
            this.btnDocumentosPessoais.Size = new System.Drawing.Size(104, 78);
            this.btnDocumentosPessoais.TabIndex = 43;
            this.btnDocumentosPessoais.Text = "DOCUMENTOS PESSOAIS\r\n";
            this.btnDocumentosPessoais.UseVisualStyleBackColor = true;
            // 
            // telaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GuiWindowsForms.Properties.Resources.modelo_tela_iconemenor;
            this.ClientSize = new System.Drawing.Size(994, 716);
            this.Controls.Add(this.btnDocumentosPessoais);
            this.Controls.Add(this.btnDadosPessoais);
            this.Controls.Add(this.btnDadosProfissionais);
            this.Controls.Add(this.btnBeneficiario);
            this.Controls.Add(this.gpbDadosPessoais);
            this.Controls.Add(this.btnAdicionarImagem);
            this.Controls.Add(this.pctImagem);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.lblHelloUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).EndInit();
            this.gpbDadosPessoais.ResumeLayout(false);
            this.gpbDadosPessoais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Label lblHelloUsuario;
        private System.Windows.Forms.Button btnAdicionarImagem;
        private System.Windows.Forms.PictureBox pctImagem;
        private System.Windows.Forms.GroupBox gpbDadosPessoais;
        private System.Windows.Forms.TextBox txtFiliacaoPai;
        private System.Windows.Forms.Label lblPai;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtFiliacaoMae;
        private System.Windows.Forms.Label lblMae;
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
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.RadioButton rdbFem;
        private System.Windows.Forms.RadioButton rdbMasc;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnBeneficiario;
        private System.Windows.Forms.Button btnDadosProfissionais;
        private System.Windows.Forms.Label lblFiliacao;
        private System.Windows.Forms.ComboBox cmbNacionalidade;
        private System.Windows.Forms.Label lblNacionalidade;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnDadosPessoais;
        private System.Windows.Forms.Label lblEmissor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblUfIdentidade;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnDocumentosPessoais;

    }
}