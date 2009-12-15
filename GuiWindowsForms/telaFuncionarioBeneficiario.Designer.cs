namespace GuiWindowsForms
{
    partial class telaFuncionarioBeneficiario
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
            this.btnDocumentosPessoais = new System.Windows.Forms.Button();
            this.btnDadosPessoais = new System.Windows.Forms.Button();
            this.btnBeneficiario = new System.Windows.Forms.Button();
            this.lblHelloUsuario = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.pctImagem = new System.Windows.Forms.PictureBox();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.lblFuncao = new System.Windows.Forms.Label();
            this.lblFone = new System.Windows.Forms.Label();
            this.gpbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.cmbNacionalidade = new System.Windows.Forms.ComboBox();
            this.lblGrauInstrucao = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dtgListadeProfissionais = new System.Windows.Forms.DataGridView();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblDataAdmissao = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).BeginInit();
            this.gpbDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListadeProfissionais)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDocumentosPessoais
            // 
            this.btnDocumentosPessoais.Location = new System.Drawing.Point(884, 284);
            this.btnDocumentosPessoais.Name = "btnDocumentosPessoais";
            this.btnDocumentosPessoais.Size = new System.Drawing.Size(104, 78);
            this.btnDocumentosPessoais.TabIndex = 46;
            this.btnDocumentosPessoais.Text = "DADOS PROFISSIONAIS";
            this.btnDocumentosPessoais.UseVisualStyleBackColor = true;
            // 
            // btnDadosPessoais
            // 
            this.btnDadosPessoais.Location = new System.Drawing.Point(884, 191);
            this.btnDadosPessoais.Name = "btnDadosPessoais";
            this.btnDadosPessoais.Size = new System.Drawing.Size(104, 78);
            this.btnDadosPessoais.TabIndex = 45;
            this.btnDadosPessoais.Text = "DADOS PESSOAIS";
            this.btnDadosPessoais.UseVisualStyleBackColor = true;
            // 
            // btnBeneficiario
            // 
            this.btnBeneficiario.Location = new System.Drawing.Point(884, 379);
            this.btnBeneficiario.Name = "btnBeneficiario";
            this.btnBeneficiario.Size = new System.Drawing.Size(104, 78);
            this.btnBeneficiario.TabIndex = 44;
            this.btnBeneficiario.Text = "BENEFICIARIO";
            this.btnBeneficiario.UseVisualStyleBackColor = true;
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
            this.lblHelloUsuario.TabIndex = 75;
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
            this.btnDesconectar.TabIndex = 76;
            this.btnDesconectar.Tag = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = false;
            // 
            // pctImagem
            // 
            this.pctImagem.BackColor = System.Drawing.Color.Transparent;
            this.pctImagem.Location = new System.Drawing.Point(250, 12);
            this.pctImagem.Name = "pctImagem";
            this.pctImagem.Size = new System.Drawing.Size(127, 134);
            this.pctImagem.TabIndex = 77;
            this.pctImagem.TabStop = false;
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
            this.lblNomeFuncionario.TabIndex = 78;
            this.lblNomeFuncionario.Text = "Nome do Funcionário";
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
            this.lblFuncao.TabIndex = 79;
            this.lblFuncao.Text = "Função";
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
            this.lblFone.TabIndex = 80;
            this.lblFone.Text = "Fone ";
            // 
            // gpbDadosPessoais
            // 
            this.gpbDadosPessoais.BackColor = System.Drawing.Color.Transparent;
            this.gpbDadosPessoais.Controls.Add(this.btnExcluir);
            this.gpbDadosPessoais.Controls.Add(this.dtpNascimento);
            this.gpbDadosPessoais.Controls.Add(this.lblDataAdmissao);
            this.gpbDadosPessoais.Controls.Add(this.dtgListadeProfissionais);
            this.gpbDadosPessoais.Controls.Add(this.cmbNacionalidade);
            this.gpbDadosPessoais.Controls.Add(this.lblGrauInstrucao);
            this.gpbDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosPessoais.Location = new System.Drawing.Point(39, 191);
            this.gpbDadosPessoais.Name = "gpbDadosPessoais";
            this.gpbDadosPessoais.Size = new System.Drawing.Size(820, 487);
            this.gpbDadosPessoais.TabIndex = 81;
            this.gpbDadosPessoais.TabStop = false;
            this.gpbDadosPessoais.Text = "DOCUMENTOS PESSOAIS DO FUNCIONÁRIO";
            // 
            // cmbNacionalidade
            // 
            this.cmbNacionalidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbNacionalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbNacionalidade.FormattingEnabled = true;
            this.cmbNacionalidade.Location = new System.Drawing.Point(188, 60);
            this.cmbNacionalidade.Name = "cmbNacionalidade";
            this.cmbNacionalidade.Size = new System.Drawing.Size(336, 21);
            this.cmbNacionalidade.TabIndex = 76;
            // 
            // lblGrauInstrucao
            // 
            this.lblGrauInstrucao.AutoSize = true;
            this.lblGrauInstrucao.Location = new System.Drawing.Point(40, 60);
            this.lblGrauInstrucao.Name = "lblGrauInstrucao";
            this.lblGrauInstrucao.Size = new System.Drawing.Size(92, 13);
            this.lblGrauInstrucao.TabIndex = 75;
            this.lblGrauInstrucao.Text = "Nome do Filho:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.ok_32x32_tipo2_final;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(89, 684);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(36, 29);
            this.btnSalvar.TabIndex = 83;
            this.btnSalvar.Tag = "Gravar Dados";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.voltar_final_32x32;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(39, 681);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(33, 34);
            this.btnVoltar.TabIndex = 82;
            this.btnVoltar.Tag = "Voltar para tela anterior";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // dtgListadeProfissionais
            // 
            this.dtgListadeProfissionais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListadeProfissionais.Location = new System.Drawing.Point(43, 272);
            this.dtgListadeProfissionais.Name = "dtgListadeProfissionais";
            this.dtgListadeProfissionais.Size = new System.Drawing.Size(747, 198);
            this.dtgListadeProfissionais.TabIndex = 77;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.CalendarForeColor = System.Drawing.Color.MidnightBlue;
            this.dtpNascimento.CalendarTitleForeColor = System.Drawing.Color.MidnightBlue;
            this.dtpNascimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNascimento.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(188, 131);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(110, 23);
            this.dtpNascimento.TabIndex = 85;
            // 
            // lblDataAdmissao
            // 
            this.lblDataAdmissao.AutoSize = true;
            this.lblDataAdmissao.Location = new System.Drawing.Point(39, 131);
            this.lblDataAdmissao.Name = "lblDataAdmissao";
            this.lblDataAdmissao.Size = new System.Drawing.Size(108, 13);
            this.lblDataAdmissao.TabIndex = 84;
            this.lblDataAdmissao.Text = "Data Nascimento:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Location = new System.Drawing.Point(715, 243);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 86;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // telaFuncionarioBeneficiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GuiWindowsForms.Properties.Resources.modelo_tela_iconemenor;
            this.ClientSize = new System.Drawing.Size(994, 716);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.gpbDadosPessoais);
            this.Controls.Add(this.lblFone);
            this.Controls.Add(this.lblFuncao);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Controls.Add(this.pctImagem);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.lblHelloUsuario);
            this.Controls.Add(this.btnDocumentosPessoais);
            this.Controls.Add(this.btnDadosPessoais);
            this.Controls.Add(this.btnBeneficiario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaFuncionarioBeneficiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).EndInit();
            this.gpbDadosPessoais.ResumeLayout(false);
            this.gpbDadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListadeProfissionais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDocumentosPessoais;
        private System.Windows.Forms.Button btnDadosPessoais;
        private System.Windows.Forms.Button btnBeneficiario;
        private System.Windows.Forms.Label lblHelloUsuario;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.PictureBox pctImagem;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Label lblFuncao;
        private System.Windows.Forms.Label lblFone;
        private System.Windows.Forms.GroupBox gpbDadosPessoais;
        private System.Windows.Forms.ComboBox cmbNacionalidade;
        private System.Windows.Forms.Label lblGrauInstrucao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dtgListadeProfissionais;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label lblDataAdmissao;
        private System.Windows.Forms.Button btnExcluir;
    }
}