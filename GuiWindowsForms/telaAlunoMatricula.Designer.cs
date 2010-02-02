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
            this.lblSerie = new System.Windows.Forms.Label();
            this.cmbSerie = new System.Windows.Forms.ComboBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnMatriculaAtividade = new System.Windows.Forms.Button();
            this.errorProviderTela = new System.Windows.Forms.ErrorProvider(this.components);
            this.ucMenuInferior1 = new GuiWindowsForms.ucMenuInferior();
            this.uMenuLateral1 = new GuiWindowsForms.User_Control.uMenuLateral();
            this.uMenuImagem1 = new GuiWindowsForms.uMenuImagem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucDesconectarLogin1 = new GuiWindowsForms.User_Control.ucDesconectarLogin();
            this.btnVincularAluno = new System.Windows.Forms.Button();
            this.gpbMatricula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.gpbMatricula.Controls.Add(this.lblSerie);
            this.gpbMatricula.Controls.Add(this.cmbSerie);
            this.gpbMatricula.Controls.Add(this.lblValor);
            this.gpbMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbMatricula.Location = new System.Drawing.Point(39, 191);
            this.gpbMatricula.Name = "gpbMatricula";
            this.gpbMatricula.Size = new System.Drawing.Size(820, 228);
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
            "28"});
            this.cmbVencimento.Location = new System.Drawing.Point(161, 176);
            this.cmbVencimento.Name = "cmbVencimento";
            this.cmbVencimento.Size = new System.Drawing.Size(62, 21);
            this.cmbVencimento.TabIndex = 6;
            this.cmbVencimento.TextChanged += new System.EventHandler(this.cmbVencimento_TextChanged);
            // 
            // lblVencimento
            // 
            this.lblVencimento.AutoSize = true;
            this.lblVencimento.Location = new System.Drawing.Point(32, 179);
            this.lblVencimento.Name = "lblVencimento";
            this.lblVencimento.Size = new System.Drawing.Size(118, 13);
            this.lblVencimento.TabIndex = 49;
            this.lblVencimento.Text = "Dia do Vencimento:";
            // 
            // txtTotalValor
            // 
            this.txtTotalValor.Location = new System.Drawing.Point(668, 184);
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
            this.lblTotalValor.Location = new System.Drawing.Point(496, 182);
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
            this.cmbDesconto.Location = new System.Drawing.Point(161, 130);
            this.cmbDesconto.Name = "cmbDesconto";
            this.cmbDesconto.Size = new System.Drawing.Size(163, 21);
            this.cmbDesconto.TabIndex = 5;
            this.cmbDesconto.SelectedIndexChanged += new System.EventHandler(this.cmbDesconto_SelectedIndexChanged);
            this.cmbDesconto.TextChanged += new System.EventHandler(this.cmbDesconto_TextChanged);
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(32, 133);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(65, 13);
            this.lblDesconto.TabIndex = 44;
            this.lblDesconto.Text = "Desconto:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(161, 84);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(123, 20);
            this.txtValor.TabIndex = 4;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // lblNumeroMatricula
            // 
            this.lblNumeroMatricula.AutoSize = true;
            this.lblNumeroMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroMatricula.Location = new System.Drawing.Point(665, 42);
            this.lblNumeroMatricula.Name = "lblNumeroMatricula";
            this.lblNumeroMatricula.Size = new System.Drawing.Size(126, 13);
            this.lblNumeroMatricula.TabIndex = 41;
            this.lblNumeroMatricula.Text = "Número da Matrícula";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(32, 42);
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
            this.cmbSerie.Location = new System.Drawing.Point(161, 39);
            this.cmbSerie.Name = "cmbSerie";
            this.cmbSerie.Size = new System.Drawing.Size(163, 21);
            this.cmbSerie.TabIndex = 1;
            this.cmbSerie.SelectedIndexChanged += new System.EventHandler(this.cmbSerie_SelectedIndexChanged);
            this.cmbSerie.TextChanged += new System.EventHandler(this.cmbSerie_TextChanged);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(32, 87);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(68, 13);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor (R$):";
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
            this.ucMenuInferior1.Location = new System.Drawing.Point(39, 637);
            this.ucMenuInferior1.Name = "ucMenuInferior1";
            this.ucMenuInferior1.Size = new System.Drawing.Size(696, 43);
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
            this.uMenuImagem1.Size = new System.Drawing.Size(560, 201);
            this.uMenuImagem1.TabIndex = 109;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GuiWindowsForms.Properties.Resources.simbolo_colegio;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 112);
            this.pictureBox1.TabIndex = 137;
            this.pictureBox1.TabStop = false;
            // 
            // ucDesconectarLogin1
            // 
            this.ucDesconectarLogin1.BackColor = System.Drawing.Color.Transparent;
            this.ucDesconectarLogin1.Location = new System.Drawing.Point(738, 0);
            this.ucDesconectarLogin1.Name = "ucDesconectarLogin1";
            this.ucDesconectarLogin1.Size = new System.Drawing.Size(253, 39);
            this.ucDesconectarLogin1.TabIndex = 138;
            this.ucDesconectarLogin1.EventoDesconectar += new GuiWindowsForms.User_Control.ucDesconectarLogin.delegateDesconectar(this.ucDesconectarLogin1_EventoDesconectar);
            // 
            // btnVincularAluno
            // 
            this.btnVincularAluno.BackgroundImage = global::GuiWindowsForms.Properties.Resources.atividade_mais;
            this.btnVincularAluno.FlatAppearance.BorderSize = 0;
            this.btnVincularAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVincularAluno.Location = new System.Drawing.Point(44, 505);
            this.btnVincularAluno.Name = "btnVincularAluno";
            this.btnVincularAluno.Size = new System.Drawing.Size(34, 33);
            this.btnVincularAluno.TabIndex = 139;
            this.btnVincularAluno.UseVisualStyleBackColor = true;
            this.btnVincularAluno.MouseLeave += new System.EventHandler(this.btnVincularAluno_MouseLeave);
            this.btnVincularAluno.Click += new System.EventHandler(this.btnVincularAluno_Click);
            this.btnVincularAluno.MouseEnter += new System.EventHandler(this.btnVincularAluno_MouseEnter);
            // 
            // telaAlunoMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(179)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(990, 680);
            this.Controls.Add(this.btnVincularAluno);
            this.Controls.Add(this.ucDesconectarLogin1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ucMenuInferior1);
            this.Controls.Add(this.btnMatriculaAtividade);
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
            this.Activated += new System.EventHandler(this.telaAlunoMatricula_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaAlunoMatricula_FormClosing);
            this.gpbMatricula.ResumeLayout(false);
            this.gpbMatricula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbMatricula;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ComboBox cmbSerie;
        private System.Windows.Forms.Label lblSerie;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private GuiWindowsForms.User_Control.ucDesconectarLogin ucDesconectarLogin1;
        private System.Windows.Forms.Button btnVincularAluno;
    }
}