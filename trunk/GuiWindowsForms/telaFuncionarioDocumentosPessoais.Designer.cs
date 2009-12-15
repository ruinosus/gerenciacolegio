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
            // telaFuncionarioDocumentosPessoais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GuiWindowsForms.Properties.Resources.modelo_tela_iconemenor;
            this.ClientSize = new System.Drawing.Size(994, 722);
            this.Controls.Add(this.gpbDadosPessoais);
            this.Controls.Add(this.pctImagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaFuncionarioDocumentosPessoais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).EndInit();
            this.gpbDadosPessoais.ResumeLayout(false);
            this.gpbDadosPessoais.PerformLayout();
            this.ResumeLayout(false);

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
    }
}