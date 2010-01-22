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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaFuncionario));
            this.gpbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.mskFoneResidencia = new System.Windows.Forms.MaskedTextBox();
            this.lblFoneResidencia = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.cmbNacionalidade = new System.Windows.Forms.ComboBox();
            this.lblNacionalidade = new System.Windows.Forms.Label();
            this.txtFiliacaoPai = new System.Windows.Forms.TextBox();
            this.lblPai = new System.Windows.Forms.Label();
            this.txtFiliacaoMae = new System.Windows.Forms.TextBox();
            this.lblMae = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.errorProviderTela = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucDesconectarLogin1 = new GuiWindowsForms.User_Control.ucDesconectarLogin();
            this.ucMenuImagemFunc1 = new GuiWindowsForms.User_Control.ucMenuImagemFunc();
            this.ucMenuInferior1 = new GuiWindowsForms.ucMenuInferior();
            this.ucMenuLateralFunc1 = new GuiWindowsForms.User_Control.ucMenuLateralFunc();
            this.lblEdificio = new System.Windows.Forms.Label();
            this.txtNomeEdificil = new System.Windows.Forms.TextBox();
            this.cmbUf = new System.Windows.Forms.ComboBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.rdbFem = new System.Windows.Forms.RadioButton();
            this.rdbMasc = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.mskFoneOpcional = new System.Windows.Forms.MaskedTextBox();
            this.lblFone2 = new System.Windows.Forms.Label();
            this.lblFiliação = new System.Windows.Forms.Label();
            this.gpbDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbDadosPessoais
            // 
            this.gpbDadosPessoais.BackColor = System.Drawing.Color.Transparent;
            this.gpbDadosPessoais.Controls.Add(this.lblFiliação);
            this.gpbDadosPessoais.Controls.Add(this.mskFoneOpcional);
            this.gpbDadosPessoais.Controls.Add(this.lblFone2);
            this.gpbDadosPessoais.Controls.Add(this.lblEdificio);
            this.gpbDadosPessoais.Controls.Add(this.txtNomeEdificil);
            this.gpbDadosPessoais.Controls.Add(this.cmbUf);
            this.gpbDadosPessoais.Controls.Add(this.txtComplemento);
            this.gpbDadosPessoais.Controls.Add(this.lblComplemento);
            this.gpbDadosPessoais.Controls.Add(this.lblUf);
            this.gpbDadosPessoais.Controls.Add(this.mskCep);
            this.gpbDadosPessoais.Controls.Add(this.label4);
            this.gpbDadosPessoais.Controls.Add(this.txtCidade);
            this.gpbDadosPessoais.Controls.Add(this.lblCidade);
            this.gpbDadosPessoais.Controls.Add(this.txtBairro);
            this.gpbDadosPessoais.Controls.Add(this.lblBairro);
            this.gpbDadosPessoais.Controls.Add(this.txtLogradouro);
            this.gpbDadosPessoais.Controls.Add(this.label3);
            this.gpbDadosPessoais.Controls.Add(this.mskCpf);
            this.gpbDadosPessoais.Controls.Add(this.txtRg);
            this.gpbDadosPessoais.Controls.Add(this.lblCpf);
            this.gpbDadosPessoais.Controls.Add(this.lblRg);
            this.gpbDadosPessoais.Controls.Add(this.rdbFem);
            this.gpbDadosPessoais.Controls.Add(this.rdbMasc);
            this.gpbDadosPessoais.Controls.Add(this.lblSexo);
            this.gpbDadosPessoais.Controls.Add(this.txtNome);
            this.gpbDadosPessoais.Controls.Add(this.dtpNascimento);
            this.gpbDadosPessoais.Controls.Add(this.lblNascimento);
            this.gpbDadosPessoais.Controls.Add(this.lblNome);
            this.gpbDadosPessoais.Controls.Add(this.mskFoneResidencia);
            this.gpbDadosPessoais.Controls.Add(this.lblFoneResidencia);
            this.gpbDadosPessoais.Controls.Add(this.lblEstadoCivil);
            this.gpbDadosPessoais.Controls.Add(this.cmbEstadoCivil);
            this.gpbDadosPessoais.Controls.Add(this.cmbNacionalidade);
            this.gpbDadosPessoais.Controls.Add(this.lblNacionalidade);
            this.gpbDadosPessoais.Controls.Add(this.txtFiliacaoPai);
            this.gpbDadosPessoais.Controls.Add(this.lblPai);
            this.gpbDadosPessoais.Controls.Add(this.txtFiliacaoMae);
            this.gpbDadosPessoais.Controls.Add(this.lblMae);
            this.gpbDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosPessoais.Location = new System.Drawing.Point(39, 191);
            this.gpbDadosPessoais.Name = "gpbDadosPessoais";
            this.gpbDadosPessoais.Size = new System.Drawing.Size(820, 431);
            this.gpbDadosPessoais.TabIndex = 39;
            this.gpbDadosPessoais.TabStop = false;
            this.gpbDadosPessoais.Text = "DADOS DO FUNCIONÁRIO";
            // 
            // mskFoneResidencia
            // 
            this.mskFoneResidencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.mskFoneResidencia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mskFoneResidencia.Location = new System.Drawing.Point(99, 317);
            this.mskFoneResidencia.Mask = "(99) 0000-0000";
            this.mskFoneResidencia.Name = "mskFoneResidencia";
            this.mskFoneResidencia.Size = new System.Drawing.Size(101, 20);
            this.mskFoneResidencia.TabIndex = 139;
            // 
            // lblFoneResidencia
            // 
            this.lblFoneResidencia.AutoSize = true;
            this.lblFoneResidencia.Location = new System.Drawing.Point(6, 319);
            this.lblFoneResidencia.Name = "lblFoneResidencia";
            this.lblFoneResidencia.Size = new System.Drawing.Size(43, 13);
            this.lblFoneResidencia.TabIndex = 138;
            this.lblFoneResidencia.Text = "Fone :";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(7, 138);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(78, 13);
            this.lblEstadoCivil.TabIndex = 45;
            this.lblEstadoCivil.Text = "Estado Civil:";
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Items.AddRange(new object[] {
            "",
            "Solteiro(a) ",
            "Casado(a)",
            "Separado(a)",
            "Divorciado(a) ",
            "Viúvo(a)"});
            this.cmbEstadoCivil.Location = new System.Drawing.Point(99, 135);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(124, 21);
            this.cmbEstadoCivil.TabIndex = 44;
            this.cmbEstadoCivil.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // cmbNacionalidade
            // 
            this.cmbNacionalidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbNacionalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNacionalidade.FormattingEnabled = true;
            this.cmbNacionalidade.Items.AddRange(new object[] {
            "",
            "Brasil",
            "Afeganistão",
            "África do Sul",
            "Akrotiri",
            "Albânia",
            "Alemanha",
            "Andorra",
            "Angola",
            "Anguila",
            "Antárctida",
            "Antígua e Barbuda",
            "Antilhas Neerlandesas",
            "Arábia Saudita",
            "Arctic Ocean",
            "Argélia",
            "Argentina",
            "Arménia",
            "Aruba",
            "Ashmore and Cartier Islands",
            "Atlantic Ocean",
            "Austrália",
            "Áustria",
            "Azerbaijão",
            "Baamas",
            "Bangladeche",
            "Barbados",
            "Barém",
            "Bélgica",
            "Belize",
            "Benim",
            "Bermudas",
            "Bielorrússia",
            "Birmânia",
            "Bolívia",
            "Bósnia e Herzegovina",
            "Botsuana",
            "Brunei",
            "Bulgária",
            "Burquina Faso",
            "Burúndi",
            "Butão",
            "Cabo Verde",
            "Camarões",
            "Camboja",
            "Canadá",
            "Catar",
            "Cazaquistão",
            "Chade",
            "Chile",
            "China",
            "Chipre",
            "Clipperton Island",
            "Colômbia",
            "Comores",
            "Congo-Brazzaville",
            "Congo-Kinshasa",
            "Coral Sea Islands",
            "Coreia do Norte",
            "Coreia do Sul",
            "Costa do Marfim",
            "Costa Rica",
            "Croácia",
            "Cuba",
            "Dhekelia",
            "Dinamarca",
            "Domínica",
            "Egipto",
            "Emiratos Árabes Unidos",
            "Equador",
            "Eritreia",
            "Eslováquia",
            "Eslovénia",
            "Espanha",
            "Estados Unidos",
            "Estónia",
            "Etiópia",
            "Faroé",
            "Fiji",
            "Filipinas",
            "Finlândia",
            "França",
            "Gabão",
            "Gâmbia",
            "Gana",
            "Gaza Strip",
            "Geórgia",
            "Geórgia do Sul e Sandwich do Sul",
            "Gibraltar",
            "Granada",
            "Grécia",
            "Gronelândia",
            "Guame",
            "Guatemala",
            "Guernsey",
            "Guiana",
            "Guiné",
            "Guiné Equatorial",
            "Guiné-Bissau",
            "Haiti",
            "Honduras",
            "Hong Kong",
            "Hungria",
            "Iémen",
            "Ilha Bouvet",
            "Ilha do Natal",
            "Ilha Norfolk",
            "Ilhas Caimão",
            "Ilhas Cook",
            "Ilhas dos Cocos",
            "Ilhas Falkland",
            "Ilhas Heard e McDonald",
            "Ilhas Marshall",
            "Ilhas Salomão",
            "Ilhas Turcas e Caicos",
            "Ilhas Virgens Americanas",
            "Ilhas Virgens Britânicas",
            "Índia",
            "Indian Ocean",
            "Indonésia",
            "Irão",
            "Iraque",
            "Irlanda",
            "Islândia",
            "Israel",
            "Itália",
            "Jamaica",
            "Jan Mayen",
            "Japão",
            "Jersey",
            "Jibuti",
            "Jordânia",
            "Kuwait",
            "Laos",
            "Lesoto",
            "Letónia",
            "Líbano",
            "Libéria",
            "Líbia",
            "Listenstaine",
            "Lituânia",
            "Luxemburgo",
            "Macau",
            "Macedónia",
            "Madagáscar",
            "Malásia",
            "Malávi",
            "Maldivas",
            "Mali",
            "Malta",
            "Man, Isle of",
            "Marianas do Norte",
            "Marrocos",
            "Maurícia",
            "Mauritânia",
            "Mayotte",
            "México",
            "Micronésia",
            "Moçambique",
            "Moldávia",
            "Mónaco",
            "Mongólia",
            "Monserrate",
            "Montenegro",
            "Mundo",
            "Namíbia",
            "Nauru",
            "Navassa Island",
            "Nepal",
            "Nicarágua",
            "Níger",
            "Nigéria",
            "Niue",
            "Noruega",
            "Nova Caledónia",
            "Nova Zelândia",
            "Omã",
            "Pacific Ocean",
            "Países Baixos",
            "Palau",
            "Panamá",
            "Papua-Nova Guiné",
            "Paquistão",
            "Paracel Islands",
            "Paraguai",
            "Peru",
            "Pitcairn",
            "Polinésia Francesa",
            "Polónia",
            "Porto Rico",
            "Portugal",
            "Quénia",
            "Quirguizistão",
            "Quiribáti",
            "Reino Unido",
            "República Centro-Africana",
            "República Checa",
            "República Dominicana",
            "Roménia",
            "Ruanda",
            "Rússia",
            "Salvador",
            "Samoa",
            "Samoa Americana",
            "Santa Helena",
            "Santa Lúcia",
            "São Cristóvão e Neves",
            "São Marinho",
            "São Pedro e Miquelon",
            "São Tomé e Príncipe",
            "São Vicente e Granadinas",
            "Sara Ocidental",
            "Seicheles",
            "Senegal",
            "Serra Leoa",
            "Sérvia",
            "Singapura",
            "Síria",
            "Somália",
            "Southern Ocean",
            "Spratly Islands",
            "Sri Lanca",
            "Suazilândia",
            "Sudão",
            "Suécia",
            "Suíça",
            "Suriname",
            "Svalbard e Jan Mayen",
            "Tailândia",
            "Taiwan",
            "Tajiquistão",
            "Tanzânia",
            "Território Britânico do Oceano Índico",
            "Territórios Austrais Franceses",
            "Timor Leste",
            "Togo",
            "Tokelau",
            "Tonga",
            "Trindade e Tobago",
            "Tunísia",
            "Turquemenistão",
            "Turquia",
            "Tuvalu",
            "Ucrânia",
            "Uganda",
            "União Europeia",
            "Uruguai",
            "Usbequistão",
            "Vanuatu",
            "Vaticano",
            "Venezuela",
            "Vietname",
            "Wake Island",
            "Wallis e Futuna",
            "West Bank",
            "Zâmbia",
            "Zimbabué "});
            this.cmbNacionalidade.Location = new System.Drawing.Point(603, 130);
            this.cmbNacionalidade.Name = "cmbNacionalidade";
            this.cmbNacionalidade.Size = new System.Drawing.Size(200, 21);
            this.cmbNacionalidade.TabIndex = 41;
            this.cmbNacionalidade.TextChanged += new System.EventHandler(this.cmbNacionalidade_TextChanged);
            // 
            // lblNacionalidade
            // 
            this.lblNacionalidade.AutoSize = true;
            this.lblNacionalidade.Location = new System.Drawing.Point(480, 133);
            this.lblNacionalidade.Name = "lblNacionalidade";
            this.lblNacionalidade.Size = new System.Drawing.Size(92, 13);
            this.lblNacionalidade.TabIndex = 40;
            this.lblNacionalidade.Text = "Nacionalidade:";
            // 
            // txtFiliacaoPai
            // 
            this.txtFiliacaoPai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtFiliacaoPai.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFiliacaoPai.Location = new System.Drawing.Point(133, 368);
            this.txtFiliacaoPai.MaxLength = 30;
            this.txtFiliacaoPai.Name = "txtFiliacaoPai";
            this.txtFiliacaoPai.Size = new System.Drawing.Size(320, 20);
            this.txtFiliacaoPai.TabIndex = 38;
            this.txtFiliacaoPai.TextChanged += new System.EventHandler(this.txtFiliacaoPai_TextChanged);
            // 
            // lblPai
            // 
            this.lblPai.AutoSize = true;
            this.lblPai.Location = new System.Drawing.Point(98, 371);
            this.lblPai.Name = "lblPai";
            this.lblPai.Size = new System.Drawing.Size(29, 13);
            this.lblPai.TabIndex = 37;
            this.lblPai.Text = "Pai:";
            // 
            // txtFiliacaoMae
            // 
            this.txtFiliacaoMae.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtFiliacaoMae.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFiliacaoMae.Location = new System.Drawing.Point(133, 398);
            this.txtFiliacaoMae.MaxLength = 40;
            this.txtFiliacaoMae.Name = "txtFiliacaoMae";
            this.txtFiliacaoMae.Size = new System.Drawing.Size(320, 20);
            this.txtFiliacaoMae.TabIndex = 34;
            this.txtFiliacaoMae.TextChanged += new System.EventHandler(this.txtFiliacaoMae_TextChanged);
            // 
            // lblMae
            // 
            this.lblMae.AutoSize = true;
            this.lblMae.Location = new System.Drawing.Point(97, 401);
            this.lblMae.Name = "lblMae";
            this.lblMae.Size = new System.Drawing.Size(35, 13);
            this.lblMae.TabIndex = 33;
            this.lblMae.Text = "Mãe:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_imprimir_50x50;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Location = new System.Drawing.Point(896, 609);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(50, 50);
            this.btnImprimir.TabIndex = 97;
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // errorProviderTela
            // 
            this.errorProviderTela.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GuiWindowsForms.Properties.Resources.simbolo_colegio;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 112);
            this.pictureBox1.TabIndex = 136;
            this.pictureBox1.TabStop = false;
            // 
            // ucDesconectarLogin1
            // 
            this.ucDesconectarLogin1.BackColor = System.Drawing.Color.Transparent;
            this.ucDesconectarLogin1.Location = new System.Drawing.Point(738, 0);
            this.ucDesconectarLogin1.Name = "ucDesconectarLogin1";
            this.ucDesconectarLogin1.Size = new System.Drawing.Size(253, 39);
            this.ucDesconectarLogin1.TabIndex = 137;
            this.ucDesconectarLogin1.EventoDesconectar += new GuiWindowsForms.User_Control.ucDesconectarLogin.delegateDesconectar(this.ucDesconectarLogin1_EventoDesconectar);
            // 
            // ucMenuImagemFunc1
            // 
            this.ucMenuImagemFunc1.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuImagemFunc1.Location = new System.Drawing.Point(262, 7);
            this.ucMenuImagemFunc1.Name = "ucMenuImagemFunc1";
            this.ucMenuImagemFunc1.Size = new System.Drawing.Size(380, 178);
            this.ucMenuImagemFunc1.TabIndex = 98;
            // 
            // ucMenuInferior1
            // 
            this.ucMenuInferior1.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuInferior1.Location = new System.Drawing.Point(39, 637);
            this.ucMenuInferior1.Name = "ucMenuInferior1";
            this.ucMenuInferior1.Size = new System.Drawing.Size(779, 41);
            this.ucMenuInferior1.TabIndex = 99;
            this.ucMenuInferior1.EventoCadastrar += new GuiWindowsForms.ucMenuInferior.delegateCadastrar(this.ucMenuInferior1_EventoCadastrar);
            this.ucMenuInferior1.EventoVoltar += new GuiWindowsForms.ucMenuInferior.delegateVoltar(this.ucMenuInferior1_EventoVoltar);
            // 
            // ucMenuLateralFunc1
            // 
            this.ucMenuLateralFunc1.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuLateralFunc1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucMenuLateralFunc1.Location = new System.Drawing.Point(853, 194);
            this.ucMenuLateralFunc1.Name = "ucMenuLateralFunc1";
            this.ucMenuLateralFunc1.Size = new System.Drawing.Size(150, 378);
            this.ucMenuLateralFunc1.TabIndex = 100;
            this.ucMenuLateralFunc1.EventoAbrirDadosPessoais += new GuiWindowsForms.User_Control.ucMenuLateralFunc.delegateAbrirTelaDadosPessoais(this.ucMenuLateralFunc1_EventoAbrirDadosPessoais);
            this.ucMenuLateralFunc1.Load += new System.EventHandler(this.ucMenuLateralFunc1_Load);
            this.ucMenuLateralFunc1.EventoAbrirDadosProfissionais += new GuiWindowsForms.User_Control.ucMenuLateralFunc.delegateAbrirTelaDadosProfissionais(this.ucMenuLateralFunc1_EventoAbrirDadosProfissionais);
            // 
            // lblEdificio
            // 
            this.lblEdificio.AutoSize = true;
            this.lblEdificio.Location = new System.Drawing.Point(6, 234);
            this.lblEdificio.Name = "lblEdificio";
            this.lblEdificio.Size = new System.Drawing.Size(55, 13);
            this.lblEdificio.TabIndex = 155;
            this.lblEdificio.Text = "Edifício:";
            // 
            // txtNomeEdificil
            // 
            this.txtNomeEdificil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtNomeEdificil.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomeEdificil.Location = new System.Drawing.Point(99, 232);
            this.txtNomeEdificil.MaxLength = 30;
            this.txtNomeEdificil.Name = "txtNomeEdificil";
            this.txtNomeEdificil.Size = new System.Drawing.Size(200, 20);
            this.txtNomeEdificil.TabIndex = 156;
            // 
            // cmbUf
            // 
            this.cmbUf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmbUf.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbUf.FormattingEnabled = true;
            this.cmbUf.Location = new System.Drawing.Point(394, 276);
            this.cmbUf.MaxLength = 2;
            this.cmbUf.Name = "cmbUf";
            this.cmbUf.Size = new System.Drawing.Size(58, 21);
            this.cmbUf.TabIndex = 162;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtComplemento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtComplemento.Location = new System.Drawing.Point(602, 186);
            this.txtComplemento.MaxLength = 30;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(200, 20);
            this.txtComplemento.TabIndex = 154;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(482, 189);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(86, 13);
            this.lblComplemento.TabIndex = 153;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(361, 278);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(27, 13);
            this.lblUf.TabIndex = 161;
            this.lblUf.Text = "UF:";
            // 
            // mskCep
            // 
            this.mskCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.mskCep.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mskCep.Location = new System.Drawing.Point(99, 276);
            this.mskCep.Mask = "00000-999";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(72, 20);
            this.mskCep.TabIndex = 160;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 159;
            this.label4.Text = "Cep:";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtCidade.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCidade.Location = new System.Drawing.Point(602, 276);
            this.txtCidade.MaxLength = 30;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(200, 20);
            this.txtCidade.TabIndex = 164;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(482, 279);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(50, 13);
            this.lblCidade.TabIndex = 163;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtBairro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBairro.Location = new System.Drawing.Point(602, 232);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(200, 20);
            this.txtBairro.TabIndex = 158;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(482, 235);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(44, 13);
            this.lblBairro.TabIndex = 157;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtLogradouro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLogradouro.Location = new System.Drawing.Point(99, 186);
            this.txtLogradouro.MaxLength = 60;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(353, 20);
            this.txtLogradouro.TabIndex = 152;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 151;
            this.label3.Text = "Endereço:";
            // 
            // mskCpf
            // 
            this.mskCpf.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.mskCpf.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mskCpf.Location = new System.Drawing.Point(602, 83);
            this.mskCpf.Mask = "000,000,000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(100, 20);
            this.mskCpf.TabIndex = 150;
            // 
            // txtRg
            // 
            this.txtRg.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtRg.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRg.Location = new System.Drawing.Point(294, 83);
            this.txtRg.MaxLength = 15;
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(158, 20);
            this.txtRg.TabIndex = 148;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(482, 86);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(34, 13);
            this.lblCpf.TabIndex = 149;
            this.lblCpf.Text = "CPF:";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(219, 85);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(71, 13);
            this.lblRg.TabIndex = 147;
            this.lblRg.Text = "Identidade:";
            // 
            // rdbFem
            // 
            this.rdbFem.AutoSize = true;
            this.rdbFem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbFem.Location = new System.Drawing.Point(588, 41);
            this.rdbFem.Name = "rdbFem";
            this.rdbFem.Size = new System.Drawing.Size(48, 17);
            this.rdbFem.TabIndex = 144;
            this.rdbFem.TabStop = true;
            this.rdbFem.Text = "Fem";
            this.rdbFem.UseVisualStyleBackColor = true;
            // 
            // rdbMasc
            // 
            this.rdbMasc.AutoSize = true;
            this.rdbMasc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbMasc.Location = new System.Drawing.Point(527, 41);
            this.rdbMasc.Name = "rdbMasc";
            this.rdbMasc.Size = new System.Drawing.Size(55, 17);
            this.rdbMasc.TabIndex = 143;
            this.rdbMasc.TabStop = true;
            this.rdbMasc.Text = "Masc";
            this.rdbMasc.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(482, 43);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(39, 13);
            this.lblSexo.TabIndex = 142;
            this.lblSexo.Text = "Sexo:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtNome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNome.Location = new System.Drawing.Point(100, 41);
            this.txtNome.MaxLength = 40;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(353, 20);
            this.txtNome.TabIndex = 141;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.CalendarForeColor = System.Drawing.Color.MidnightBlue;
            this.dtpNascimento.CalendarTitleForeColor = System.Drawing.Color.MidnightBlue;
            this.dtpNascimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(99, 83);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(97, 20);
            this.dtpNascimento.TabIndex = 146;
            this.dtpNascimento.Value = new System.DateTime(2010, 1, 16, 0, 0, 0, 0);
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(6, 85);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(77, 13);
            this.lblNascimento.TabIndex = 145;
            this.lblNascimento.Text = "Nascimento:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(7, 43);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 13);
            this.lblNome.TabIndex = 140;
            this.lblNome.Text = "Nome:";
            // 
            // mskFoneOpcional
            // 
            this.mskFoneOpcional.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.mskFoneOpcional.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mskFoneOpcional.Location = new System.Drawing.Point(351, 317);
            this.mskFoneOpcional.Mask = "(99) 0000-0000";
            this.mskFoneOpcional.Name = "mskFoneOpcional";
            this.mskFoneOpcional.Size = new System.Drawing.Size(101, 20);
            this.mskFoneOpcional.TabIndex = 166;
            // 
            // lblFone2
            // 
            this.lblFone2.AutoSize = true;
            this.lblFone2.Location = new System.Drawing.Point(246, 319);
            this.lblFone2.Name = "lblFone2";
            this.lblFone2.Size = new System.Drawing.Size(99, 13);
            this.lblFone2.TabIndex = 165;
            this.lblFone2.Text = "Fone (opcional):";
            // 
            // lblFiliação
            // 
            this.lblFiliação.AutoSize = true;
            this.lblFiliação.Location = new System.Drawing.Point(8, 368);
            this.lblFiliação.Name = "lblFiliação";
            this.lblFiliação.Size = new System.Drawing.Size(59, 13);
            this.lblFiliação.TabIndex = 167;
            this.lblFiliação.Text = "Filiação :";
            // 
            // telaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(179)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(990, 680);
            this.Controls.Add(this.ucDesconectarLogin1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ucMenuImagemFunc1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.gpbDadosPessoais);
            this.Controls.Add(this.ucMenuInferior1);
            this.Controls.Add(this.ucMenuLateralFunc1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            this.Load += new System.EventHandler(this.telaFuncionario_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaFuncionario_FormClosing);
            this.gpbDadosPessoais.ResumeLayout(false);
            this.gpbDadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDadosPessoais;
        private System.Windows.Forms.TextBox txtFiliacaoPai;
        private System.Windows.Forms.Label lblPai;
        private System.Windows.Forms.TextBox txtFiliacaoMae;
        private System.Windows.Forms.Label lblMae;
        private System.Windows.Forms.ComboBox cmbNacionalidade;
        private System.Windows.Forms.Label lblNacionalidade;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.Button btnImprimir;
        private GuiWindowsForms.User_Control.ucMenuImagemFunc ucMenuImagemFunc1;
        private ucMenuInferior ucMenuInferior1;
        private GuiWindowsForms.User_Control.ucMenuLateralFunc ucMenuLateralFunc1;
        private System.Windows.Forms.ErrorProvider errorProviderTela;
        private System.Windows.Forms.PictureBox pictureBox1;
        private GuiWindowsForms.User_Control.ucDesconectarLogin ucDesconectarLogin1;
        private System.Windows.Forms.MaskedTextBox mskFoneResidencia;
        private System.Windows.Forms.Label lblFoneResidencia;
        private System.Windows.Forms.Label lblEdificio;
        private System.Windows.Forms.TextBox txtNomeEdificil;
        private System.Windows.Forms.ComboBox cmbUf;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.RadioButton rdbFem;
        private System.Windows.Forms.RadioButton rdbMasc;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.MaskedTextBox mskFoneOpcional;
        private System.Windows.Forms.Label lblFone2;
        private System.Windows.Forms.Label lblFiliação;

    }
}