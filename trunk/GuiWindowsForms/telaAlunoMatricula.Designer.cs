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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaAlunoMatricula));
            this.gpbMatricula = new System.Windows.Forms.GroupBox();
            this.cmbVencimento = new System.Windows.Forms.ComboBox();
            this.lblVencimento = new System.Windows.Forms.Label();
            this.txtTotalValor = new System.Windows.Forms.TextBox();
            this.lblTotalValor = new System.Windows.Forms.Label();
            this.cmbDesconto = new System.Windows.Forms.ComboBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
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
            this.lblHelloUsuario = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnMatriculaAtividade = new System.Windows.Forms.Button();
            this.errorProviderTela = new System.Windows.Forms.ErrorProvider(this.components);
            this.ucMenuInferior1 = new GuiWindowsForms.ucMenuInferior();
            this.uMenuLateral1 = new GuiWindowsForms.User_Control.uMenuLateral();
            this.uMenuImagem1 = new GuiWindowsForms.uMenuImagem();
            this.gpbMatricula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTela)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbMatricula
            // 
            this.gpbMatricula.BackColor = System.Drawing.Color.Transparent;
            this.gpbMatricula.Controls.Add(this.cmbVencimento);
            this.gpbMatricula.Controls.Add(this.lblVencimento);
            this.gpbMatricula.Controls.Add(this.txtTotalValor);
            this.gpbMatricula.Controls.Add(this.lblTotalValor);
            this.gpbMatricula.Controls.Add(this.cmbDesconto);
            this.gpbMatricula.Controls.Add(this.lblDesconto);
            this.gpbMatricula.Controls.Add(this.txtValor);
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
            this.gpbMatricula.TabIndex = 0;
            this.gpbMatricula.TabStop = false;
            this.gpbMatricula.Text = "MATRÍCULA DO ALUNO";
            // 
            // cmbVencimento
            // 
            this.cmbVencimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbVencimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVencimento.FormattingEnabled = true;
            this.cmbVencimento.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbVencimento.Location = new System.Drawing.Point(171, 280);
            this.cmbVencimento.Name = "cmbVencimento";
            this.cmbVencimento.Size = new System.Drawing.Size(62, 21);
            this.cmbVencimento.TabIndex = 6;
            this.cmbVencimento.TextChanged += new System.EventHandler(this.cmbVencimento_TextChanged);
            // 
            // lblVencimento
            // 
            this.lblVencimento.AutoSize = true;
            this.lblVencimento.Location = new System.Drawing.Point(42, 283);
            this.lblVencimento.Name = "lblVencimento";
            this.lblVencimento.Size = new System.Drawing.Size(118, 13);
            this.lblVencimento.TabIndex = 49;
            this.lblVencimento.Text = "Dia do Vencimento:";
            // 
            // txtTotalValor
            // 
            this.txtTotalValor.Location = new System.Drawing.Point(668, 306);
            this.txtTotalValor.Name = "txtTotalValor";
            this.txtTotalValor.ReadOnly = true;
            this.txtTotalValor.Size = new System.Drawing.Size(123, 20);
            this.txtTotalValor.TabIndex = 7;
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
            // cmbDesconto
            // 
            this.cmbDesconto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbDesconto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesconto.FormattingEnabled = true;
            this.cmbDesconto.Location = new System.Drawing.Point(171, 226);
            this.cmbDesconto.Name = "cmbDesconto";
            this.cmbDesconto.Size = new System.Drawing.Size(163, 21);
            this.cmbDesconto.TabIndex = 5;
            this.cmbDesconto.TextChanged += new System.EventHandler(this.cmbDesconto_TextChanged);
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(42, 229);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(65, 13);
            this.lblDesconto.TabIndex = 44;
            this.lblDesconto.Text = "Desconto:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(171, 180);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(123, 20);
            this.txtValor.TabIndex = 4;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
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
            this.dtpNascimento.TabIndex = 0;
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
            this.lblTurma.Location = new System.Drawing.Point(372, 119);
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
            this.cmbTurma.Location = new System.Drawing.Point(422, 116);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(101, 21);
            this.cmbTurma.TabIndex = 3;
            this.cmbTurma.TextChanged += new System.EventHandler(this.cmbTurma_TextChanged);
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(42, 119);
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
            this.cmbTurno.Location = new System.Drawing.Point(171, 116);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(101, 21);
            this.cmbTurno.TabIndex = 2;
            this.cmbTurno.TextChanged += new System.EventHandler(this.cmbTurno_TextChanged);
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(42, 83);
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
            this.cmbSerie.Location = new System.Drawing.Point(171, 80);
            this.cmbSerie.Name = "cmbSerie";
            this.cmbSerie.Size = new System.Drawing.Size(163, 21);
            this.cmbSerie.TabIndex = 1;
            this.cmbSerie.TextChanged += new System.EventHandler(this.cmbSerie_TextChanged);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(42, 183);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(68, 13);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor (R$):";
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
            this.btnDesconectar.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // btnMatriculaAtividade
            // 
            this.btnMatriculaAtividade.BackColor = System.Drawing.Color.Transparent;
            this.btnMatriculaAtividade.BackgroundImage = global::GuiWindowsForms.Properties.Resources.btn_add_atividade_48x48;
            this.btnMatriculaAtividade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMatriculaAtividade.FlatAppearance.BorderSize = 0;
            this.btnMatriculaAtividade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatriculaAtividade.Location = new System.Drawing.Point(39, 560);
            this.btnMatriculaAtividade.Margin = new System.Windows.Forms.Padding(0);
            this.btnMatriculaAtividade.Name = "btnMatriculaAtividade";
            this.btnMatriculaAtividade.Size = new System.Drawing.Size(48, 48);
            this.btnMatriculaAtividade.TabIndex = 6;
            this.btnMatriculaAtividade.UseVisualStyleBackColor = false;
            this.btnMatriculaAtividade.MouseLeave += new System.EventHandler(this.btnMatriculaAtividade_MouseLeave);
            this.btnMatriculaAtividade.Click += new System.EventHandler(this.btnMatriculaAtividade_Click);
            this.btnMatriculaAtividade.MouseEnter += new System.EventHandler(this.btnMatriculaAtividade_MouseEnter);
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
            this.ucMenuInferior1.TabIndex = 2;
            this.ucMenuInferior1.EventoCadastrar += new GuiWindowsForms.ucMenuInferior.delegateCadastrar(this.ucMenuInferior1_EventoCadastrar);
            this.ucMenuInferior1.EventoVoltar += new GuiWindowsForms.ucMenuInferior.delegateVoltar(this.ucAluno1_EventoVoltar);
            // 
            // uMenuLateral1
            // 
            this.uMenuLateral1.BackColor = System.Drawing.Color.Transparent;
            this.uMenuLateral1.Location = new System.Drawing.Point(875, 75);
            this.uMenuLateral1.Name = "uMenuLateral1";
            this.uMenuLateral1.Size = new System.Drawing.Size(130, 584);
            this.uMenuLateral1.TabIndex = 5;
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
            this.uMenuImagem1.TabIndex = 109;
            // 
            // telaAlunoMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GuiWindowsForms.Properties.Resources.modelo_tela_iconemenor;
            this.ClientSize = new System.Drawing.Size(1000, 722);
            this.Controls.Add(this.ucMenuInferior1);
            this.Controls.Add(this.btnMatriculaAtividade);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.lblHelloUsuario);
            this.Controls.Add(this.gpbMatricula);
            this.Controls.Add(this.uMenuLateral1);
            this.Controls.Add(this.uMenuImagem1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaAlunoMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            this.Load += new System.EventHandler(this.telaAlunoMatricula_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaAlunoMatricula_FormClosing);
            this.gpbMatricula.ResumeLayout(false);
            this.gpbMatricula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbMatricula;
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
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.ComboBox cmbDesconto;
        private System.Windows.Forms.Label lblTotalValor;
        private System.Windows.Forms.TextBox txtTotalValor;
        private System.Windows.Forms.Button btnMatriculaAtividade;
        private System.Windows.Forms.Label lblVencimento;
        private System.Windows.Forms.ComboBox cmbVencimento;
        private GuiWindowsForms.User_Control.uMenuLateral uMenuLateral1;
        private ucMenuInferior ucMenuInferior1;
        private uMenuImagem uMenuImagem1;
        private System.Windows.Forms.ErrorProvider errorProviderTela;
    }
}