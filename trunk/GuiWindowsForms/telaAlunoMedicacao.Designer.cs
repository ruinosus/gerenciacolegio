namespace GuiWindowsForms
{
    partial class telaAlunoMedicacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaAlunoMedicacao));
            this.gpbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.lblSituacaoEspecial = new System.Windows.Forms.Label();
            this.txtSituacaoEspecial = new System.Windows.Forms.TextBox();
            this.lblDescricaoMedica = new System.Windows.Forms.Label();
            this.txtDescricaoMedica = new System.Windows.Forms.TextBox();
            this.txtPlanoSaude = new System.Windows.Forms.TextBox();
            this.lblPlanoSaude = new System.Windows.Forms.Label();
            this.lblHospital = new System.Windows.Forms.Label();
            this.txtHospital = new System.Windows.Forms.TextBox();
            this.rdbNegativo = new System.Windows.Forms.RadioButton();
            this.rdbPositivo = new System.Windows.Forms.RadioButton();
            this.cmbGrupoSanguineo = new System.Windows.Forms.ComboBox();
            this.txtNomeMedico = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.mskFone = new System.Windows.Forms.MaskedTextBox();
            this.lblFone = new System.Windows.Forms.Label();
            this.lblFatorRh = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblGrupoSanguineo = new System.Windows.Forms.Label();
            this.lblAlergico = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.lblHelloUsuario = new System.Windows.Forms.Label();
            this.errorProviderTela = new System.Windows.Forms.ErrorProvider(this.components);
            this.ucMenuInferior1 = new GuiWindowsForms.ucMenuInferior();
            this.uMenuLateral1 = new GuiWindowsForms.User_Control.uMenuLateral();
            this.uMenuImagem1 = new GuiWindowsForms.uMenuImagem();
            this.gpbDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTela)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbDadosPessoais
            // 
            this.gpbDadosPessoais.BackColor = System.Drawing.Color.Transparent;
            this.gpbDadosPessoais.Controls.Add(this.lblSituacaoEspecial);
            this.gpbDadosPessoais.Controls.Add(this.txtSituacaoEspecial);
            this.gpbDadosPessoais.Controls.Add(this.lblDescricaoMedica);
            this.gpbDadosPessoais.Controls.Add(this.txtDescricaoMedica);
            this.gpbDadosPessoais.Controls.Add(this.txtPlanoSaude);
            this.gpbDadosPessoais.Controls.Add(this.lblPlanoSaude);
            this.gpbDadosPessoais.Controls.Add(this.lblHospital);
            this.gpbDadosPessoais.Controls.Add(this.txtHospital);
            this.gpbDadosPessoais.Controls.Add(this.rdbNegativo);
            this.gpbDadosPessoais.Controls.Add(this.rdbPositivo);
            this.gpbDadosPessoais.Controls.Add(this.cmbGrupoSanguineo);
            this.gpbDadosPessoais.Controls.Add(this.txtNomeMedico);
            this.gpbDadosPessoais.Controls.Add(this.lblEmail);
            this.gpbDadosPessoais.Controls.Add(this.mskFone);
            this.gpbDadosPessoais.Controls.Add(this.lblFone);
            this.gpbDadosPessoais.Controls.Add(this.lblFatorRh);
            this.gpbDadosPessoais.Controls.Add(this.txtNome);
            this.gpbDadosPessoais.Controls.Add(this.lblGrupoSanguineo);
            this.gpbDadosPessoais.Controls.Add(this.lblAlergico);
            this.gpbDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosPessoais.Location = new System.Drawing.Point(39, 191);
            this.gpbDadosPessoais.Name = "gpbDadosPessoais";
            this.gpbDadosPessoais.Size = new System.Drawing.Size(820, 475);
            this.gpbDadosPessoais.TabIndex = 0;
            this.gpbDadosPessoais.TabStop = false;
            this.gpbDadosPessoais.Text = "DESCRIÇÕES MÉDICAS DO ALUNO";
            this.gpbDadosPessoais.Enter += new System.EventHandler(this.gpbDadosPessoais_Enter);
            // 
            // lblSituacaoEspecial
            // 
            this.lblSituacaoEspecial.AutoSize = true;
            this.lblSituacaoEspecial.Location = new System.Drawing.Point(46, 363);
            this.lblSituacaoEspecial.Name = "lblSituacaoEspecial";
            this.lblSituacaoEspecial.Size = new System.Drawing.Size(113, 13);
            this.lblSituacaoEspecial.TabIndex = 45;
            this.lblSituacaoEspecial.Text = "Situação Especial:";
            // 
            // txtSituacaoEspecial
            // 
            this.txtSituacaoEspecial.Location = new System.Drawing.Point(49, 379);
            this.txtSituacaoEspecial.MaxLength = 300;
            this.txtSituacaoEspecial.Multiline = true;
            this.txtSituacaoEspecial.Name = "txtSituacaoEspecial";
            this.txtSituacaoEspecial.Size = new System.Drawing.Size(716, 76);
            this.txtSituacaoEspecial.TabIndex = 9;
            this.txtSituacaoEspecial.TextChanged += new System.EventHandler(this.txtSituacaoEspecial_TextChanged);
            // 
            // lblDescricaoMedica
            // 
            this.lblDescricaoMedica.AutoSize = true;
            this.lblDescricaoMedica.Location = new System.Drawing.Point(46, 255);
            this.lblDescricaoMedica.Name = "lblDescricaoMedica";
            this.lblDescricaoMedica.Size = new System.Drawing.Size(436, 13);
            this.lblDescricaoMedica.TabIndex = 43;
            this.lblDescricaoMedica.Text = "Medicação a ser ministrada em caso de dor ou febre (especificar dosagem):";
            // 
            // txtDescricaoMedica
            // 
            this.txtDescricaoMedica.Location = new System.Drawing.Point(49, 271);
            this.txtDescricaoMedica.MaxLength = 300;
            this.txtDescricaoMedica.Multiline = true;
            this.txtDescricaoMedica.Name = "txtDescricaoMedica";
            this.txtDescricaoMedica.Size = new System.Drawing.Size(716, 76);
            this.txtDescricaoMedica.TabIndex = 8;
            this.txtDescricaoMedica.TextChanged += new System.EventHandler(this.txtDescricaoMedica_TextChanged);
            // 
            // txtPlanoSaude
            // 
            this.txtPlanoSaude.Location = new System.Drawing.Point(564, 205);
            this.txtPlanoSaude.MaxLength = 30;
            this.txtPlanoSaude.Name = "txtPlanoSaude";
            this.txtPlanoSaude.Size = new System.Drawing.Size(201, 20);
            this.txtPlanoSaude.TabIndex = 7;
            this.txtPlanoSaude.TextChanged += new System.EventHandler(this.txtPlanoSaude_TextChanged);
            // 
            // lblPlanoSaude
            // 
            this.lblPlanoSaude.AutoSize = true;
            this.lblPlanoSaude.Location = new System.Drawing.Point(446, 205);
            this.lblPlanoSaude.Name = "lblPlanoSaude";
            this.lblPlanoSaude.Size = new System.Drawing.Size(101, 13);
            this.lblPlanoSaude.TabIndex = 40;
            this.lblPlanoSaude.Text = "Plano de Saúde:";
            // 
            // lblHospital
            // 
            this.lblHospital.AutoSize = true;
            this.lblHospital.Location = new System.Drawing.Point(46, 208);
            this.lblHospital.Name = "lblHospital";
            this.lblHospital.Size = new System.Drawing.Size(57, 13);
            this.lblHospital.TabIndex = 39;
            this.lblHospital.Text = "Hospital:";
            // 
            // txtHospital
            // 
            this.txtHospital.Location = new System.Drawing.Point(163, 205);
            this.txtHospital.MaxLength = 30;
            this.txtHospital.Name = "txtHospital";
            this.txtHospital.Size = new System.Drawing.Size(201, 20);
            this.txtHospital.TabIndex = 6;
            this.txtHospital.TextChanged += new System.EventHandler(this.txtHospital_TextChanged);
            // 
            // rdbNegativo
            // 
            this.rdbNegativo.AutoSize = true;
            this.rdbNegativo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbNegativo.Location = new System.Drawing.Point(414, 122);
            this.rdbNegativo.Name = "rdbNegativo";
            this.rdbNegativo.Size = new System.Drawing.Size(76, 17);
            this.rdbNegativo.TabIndex = 3;
            this.rdbNegativo.TabStop = true;
            this.rdbNegativo.Text = "Negativo";
            this.rdbNegativo.UseVisualStyleBackColor = true;
            this.rdbNegativo.TextChanged += new System.EventHandler(this.rdbNegativo_TextChanged);
            // 
            // rdbPositivo
            // 
            this.rdbPositivo.AutoSize = true;
            this.rdbPositivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbPositivo.Location = new System.Drawing.Point(338, 122);
            this.rdbPositivo.Name = "rdbPositivo";
            this.rdbPositivo.Size = new System.Drawing.Size(70, 17);
            this.rdbPositivo.TabIndex = 2;
            this.rdbPositivo.TabStop = true;
            this.rdbPositivo.Text = "Positivo";
            this.rdbPositivo.UseVisualStyleBackColor = true;
            this.rdbPositivo.TextChanged += new System.EventHandler(this.rdbPositivo_TextChanged);
            // 
            // cmbGrupoSanguineo
            // 
            this.cmbGrupoSanguineo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbGrupoSanguineo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupoSanguineo.FormattingEnabled = true;
            this.cmbGrupoSanguineo.Location = new System.Drawing.Point(163, 119);
            this.cmbGrupoSanguineo.Name = "cmbGrupoSanguineo";
            this.cmbGrupoSanguineo.Size = new System.Drawing.Size(72, 21);
            this.cmbGrupoSanguineo.TabIndex = 1;
            this.cmbGrupoSanguineo.TextChanged += new System.EventHandler(this.cmbGrupoSanguineo_TextChanged);
            // 
            // txtNomeMedico
            // 
            this.txtNomeMedico.Location = new System.Drawing.Point(163, 165);
            this.txtNomeMedico.MaxLength = 50;
            this.txtNomeMedico.Name = "txtNomeMedico";
            this.txtNomeMedico.Size = new System.Drawing.Size(366, 20);
            this.txtNomeMedico.TabIndex = 4;
            this.txtNomeMedico.TextChanged += new System.EventHandler(this.txtNomeMedico_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(46, 165);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(106, 13);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "Nome do Médico:";
            // 
            // mskFone
            // 
            this.mskFone.Location = new System.Drawing.Point(654, 165);
            this.mskFone.Mask = "(99) 0000-0000";
            this.mskFone.Name = "mskFone";
            this.mskFone.Size = new System.Drawing.Size(111, 20);
            this.mskFone.TabIndex = 5;
            this.mskFone.TextChanged += new System.EventHandler(this.mskFone_TextChanged);
            // 
            // lblFone
            // 
            this.lblFone.AutoSize = true;
            this.lblFone.Location = new System.Drawing.Point(600, 165);
            this.lblFone.Name = "lblFone";
            this.lblFone.Size = new System.Drawing.Size(39, 13);
            this.lblFone.TabIndex = 25;
            this.lblFone.Text = "Fone:";
            // 
            // lblFatorRh
            // 
            this.lblFatorRh.AutoSize = true;
            this.lblFatorRh.Location = new System.Drawing.Point(272, 122);
            this.lblFatorRh.Name = "lblFatorRh";
            this.lblFatorRh.Size = new System.Drawing.Size(60, 13);
            this.lblFatorRh.TabIndex = 7;
            this.lblFatorRh.Text = "Fator Rh:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(49, 48);
            this.txtNome.MaxLength = 50;
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(716, 40);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblGrupoSanguineo
            // 
            this.lblGrupoSanguineo.AutoSize = true;
            this.lblGrupoSanguineo.Location = new System.Drawing.Point(46, 122);
            this.lblGrupoSanguineo.Name = "lblGrupoSanguineo";
            this.lblGrupoSanguineo.Size = new System.Drawing.Size(111, 13);
            this.lblGrupoSanguineo.TabIndex = 1;
            this.lblGrupoSanguineo.Text = "Grupo Sanguíneo:";
            // 
            // lblAlergico
            // 
            this.lblAlergico.AutoSize = true;
            this.lblAlergico.Location = new System.Drawing.Point(46, 32);
            this.lblAlergico.Name = "lblAlergico";
            this.lblAlergico.Size = new System.Drawing.Size(57, 13);
            this.lblAlergico.TabIndex = 0;
            this.lblAlergico.Text = "Alergico:";
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
            this.btnDesconectar.TabIndex = 38;
            this.btnDesconectar.Tag = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = false;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
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
            this.lblHelloUsuario.TabIndex = 37;
            this.lblHelloUsuario.Text = "Hello Usuário!";
            // 
            // errorProviderTela
            // 
            this.errorProviderTela.ContainerControl = this;
            // 
            // ucMenuInferior1
            // 
            this.ucMenuInferior1.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuInferior1.Location = new System.Drawing.Point(39, 667);
            this.ucMenuInferior1.Name = "ucMenuInferior1";
            this.ucMenuInferior1.Size = new System.Drawing.Size(404, 43);
            this.ucMenuInferior1.TabIndex = 1;
            this.ucMenuInferior1.EventoCadastrar += new GuiWindowsForms.ucMenuInferior.delegateCadastrar(this.ucMenuInferior1_EventoCadastrar);
            this.ucMenuInferior1.EventoVoltar += new GuiWindowsForms.ucMenuInferior.delegateVoltar(this.ucAluno1_EventoVoltar);
            // 
            // uMenuLateral1
            // 
            this.uMenuLateral1.BackColor = System.Drawing.Color.Transparent;
            this.uMenuLateral1.Location = new System.Drawing.Point(875, 75);
            this.uMenuLateral1.Name = "uMenuLateral1";
            this.uMenuLateral1.Size = new System.Drawing.Size(130, 584);
            this.uMenuLateral1.TabIndex = 122;
            this.uMenuLateral1.EventoAbrirTelaMedica += new GuiWindowsForms.User_Control.uMenuLateral.delegateAbrirTelaMedica(this.uMenuLateral1_EventoAbrirTelaMedica);
            this.uMenuLateral1.Load += new System.EventHandler(this.uMenuLateral1_Load);
            this.uMenuLateral1.EventoAbrirTelaResponsavel += new GuiWindowsForms.User_Control.uMenuLateral.delegateAbrirTelaResponsavel(this.uMenuLateral1_EventoAbrirTelaResponsavel);
            this.uMenuLateral1.EventoAbrirTelaMatricula += new GuiWindowsForms.User_Control.uMenuLateral.delegateAbrirTelaMatricula(this.uMenuLateral1_EventoAbrirTelaMatricula);
            this.uMenuLateral1.EventoAbrirTelaFinanceiro += new GuiWindowsForms.User_Control.uMenuLateral.delegateAbrirTelaFinanceiro(this.uMenuLateral1_EventoAbrirTelaFinanceiro);
            this.uMenuLateral1.EventoAbrirTelaAcademico += new GuiWindowsForms.User_Control.uMenuLateral.delegateAbrirTelaAcademico(this.uMenuLateral1_EventoAbrirTelaAcademico);
            this.uMenuLateral1.EventoAbrirTelaDados += new GuiWindowsForms.User_Control.uMenuLateral.delegateAbrirTelaDados(this.uMenuLateral1_EventoAbrirTelaDados);
            // 
            // uMenuImagem1
            // 
            this.uMenuImagem1.BackColor = System.Drawing.Color.Transparent;
            this.uMenuImagem1.Location = new System.Drawing.Point(244, 0);
            this.uMenuImagem1.Name = "uMenuImagem1";
            this.uMenuImagem1.Size = new System.Drawing.Size(438, 201);
            this.uMenuImagem1.TabIndex = 124;
            // 
            // telaAlunoMedicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GuiWindowsForms.Properties.Resources.modelo_tela_iconemenor1;
            this.ClientSize = new System.Drawing.Size(1000, 722);
            this.Controls.Add(this.ucMenuInferior1);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.lblHelloUsuario);
            this.Controls.Add(this.gpbDadosPessoais);
            this.Controls.Add(this.uMenuLateral1);
            this.Controls.Add(this.uMenuImagem1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaAlunoMedicacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaAlunoMedicacao_FormClosing);
            this.gpbDadosPessoais.ResumeLayout(false);
            this.gpbDadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDadosPessoais;
        private System.Windows.Forms.TextBox txtNomeMedico;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox mskFone;
        private System.Windows.Forms.Label lblFone;
        private System.Windows.Forms.Label lblFatorRh;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblGrupoSanguineo;
        private System.Windows.Forms.Label lblAlergico;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Label lblHelloUsuario;
        private System.Windows.Forms.ComboBox cmbGrupoSanguineo;
        private System.Windows.Forms.RadioButton rdbNegativo;
        private System.Windows.Forms.RadioButton rdbPositivo;
        private System.Windows.Forms.TextBox txtHospital;
        private System.Windows.Forms.Label lblHospital;
        private System.Windows.Forms.TextBox txtPlanoSaude;
        private System.Windows.Forms.Label lblPlanoSaude;
        private System.Windows.Forms.TextBox txtDescricaoMedica;
        private System.Windows.Forms.Label lblDescricaoMedica;
        private System.Windows.Forms.Label lblSituacaoEspecial;
        private System.Windows.Forms.TextBox txtSituacaoEspecial;
        private GuiWindowsForms.User_Control.uMenuLateral uMenuLateral1;
        private ucMenuInferior ucMenuInferior1;
        private System.Windows.Forms.ErrorProvider errorProviderTela;
        private uMenuImagem uMenuImagem1;
    }
}