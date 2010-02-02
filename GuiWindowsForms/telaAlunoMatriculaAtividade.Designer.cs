namespace GuiWindowsForms
{
    partial class telaAlunoMatriculaAtividade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaAlunoMatriculaAtividade));
            this.gpbMatricula = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtTotalValor = new System.Windows.Forms.TextBox();
            this.lblTotalValor = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblNumeroMatricula = new System.Windows.Forms.Label();
            this.lblAtividade = new System.Windows.Forms.Label();
            this.cmbAtividade = new System.Windows.Forms.ComboBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnMatriculaSerie = new System.Windows.Forms.Button();
            this.errorProviderTela = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ucDesconectarLogin1 = new GuiWindowsForms.User_Control.ucDesconectarLogin();
            this.ucMenuInferior1 = new GuiWindowsForms.ucMenuInferior();
            this.uMenuLateral1 = new GuiWindowsForms.User_Control.uMenuLateral();
            this.uMenuImagem1 = new GuiWindowsForms.uMenuImagem();
            this.gpbMatricula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbMatricula
            // 
            this.gpbMatricula.BackColor = System.Drawing.Color.Transparent;
            this.gpbMatricula.Controls.Add(this.txtDescricao);
            this.gpbMatricula.Controls.Add(this.lblDescricao);
            this.gpbMatricula.Controls.Add(this.txtDesconto);
            this.gpbMatricula.Controls.Add(this.txtTotalValor);
            this.gpbMatricula.Controls.Add(this.lblTotalValor);
            this.gpbMatricula.Controls.Add(this.lblDesconto);
            this.gpbMatricula.Controls.Add(this.txtValor);
            this.gpbMatricula.Controls.Add(this.lblNumeroMatricula);
            this.gpbMatricula.Controls.Add(this.lblAtividade);
            this.gpbMatricula.Controls.Add(this.cmbAtividade);
            this.gpbMatricula.Controls.Add(this.lblValor);
            this.gpbMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbMatricula.Location = new System.Drawing.Point(39, 191);
            this.gpbMatricula.Name = "gpbMatricula";
            this.gpbMatricula.Size = new System.Drawing.Size(820, 350);
            this.gpbMatricula.TabIndex = 103;
            this.gpbMatricula.TabStop = false;
            this.gpbMatricula.Text = "MATRÍCULA DE ATIVIDADE";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(104, 120);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(390, 77);
            this.txtDescricao.TabIndex = 111;
            this.txtDescricao.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(30, 123);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(68, 13);
            this.lblDescricao.TabIndex = 110;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(103, 261);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(123, 20);
            this.txtDesconto.TabIndex = 109;
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
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
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(29, 264);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(65, 13);
            this.lblDesconto.TabIndex = 44;
            this.lblDesconto.Text = "Desconto:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(103, 215);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(123, 20);
            this.txtValor.TabIndex = 42;
            this.txtValor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // lblAtividade
            // 
            this.lblAtividade.AutoSize = true;
            this.lblAtividade.Location = new System.Drawing.Point(34, 82);
            this.lblAtividade.Name = "lblAtividade";
            this.lblAtividade.Size = new System.Drawing.Size(64, 13);
            this.lblAtividade.TabIndex = 34;
            this.lblAtividade.Text = "Atividade:";
            // 
            // cmbAtividade
            // 
            this.cmbAtividade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAtividade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAtividade.FormattingEnabled = true;
            this.cmbAtividade.Location = new System.Drawing.Point(103, 79);
            this.cmbAtividade.Name = "cmbAtividade";
            this.cmbAtividade.Size = new System.Drawing.Size(250, 21);
            this.cmbAtividade.TabIndex = 33;
            this.cmbAtividade.SelectedIndexChanged += new System.EventHandler(this.cmbAtividade_SelectedIndexChanged);
            this.cmbAtividade.TextChanged += new System.EventHandler(this.cmbAtividade_TextChanged);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(29, 218);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(68, 13);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor (R$):";
            // 
            // btnMatriculaSerie
            // 
            this.btnMatriculaSerie.BackColor = System.Drawing.Color.Transparent;
            this.btnMatriculaSerie.BackgroundImage = global::GuiWindowsForms.Properties.Resources.add_matricula_47x49;
            this.btnMatriculaSerie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMatriculaSerie.FlatAppearance.BorderSize = 0;
            this.btnMatriculaSerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatriculaSerie.Location = new System.Drawing.Point(39, 560);
            this.btnMatriculaSerie.Margin = new System.Windows.Forms.Padding(0);
            this.btnMatriculaSerie.Name = "btnMatriculaSerie";
            this.btnMatriculaSerie.Size = new System.Drawing.Size(47, 49);
            this.btnMatriculaSerie.TabIndex = 104;
            this.btnMatriculaSerie.UseVisualStyleBackColor = false;
            this.btnMatriculaSerie.MouseLeave += new System.EventHandler(this.btnMatriculaSerie_MouseLeave);
            this.btnMatriculaSerie.Click += new System.EventHandler(this.btnMatriculaSerie_Click);
            this.btnMatriculaSerie.MouseEnter += new System.EventHandler(this.btnMatriculaSerie_MouseEnter);
            // 
            // errorProviderTela
            // 
            this.errorProviderTela.ContainerControl = this;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GuiWindowsForms.Properties.Resources.simbolo_colegio;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(235, 112);
            this.pictureBox2.TabIndex = 137;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            // ucMenuInferior1
            // 
            this.ucMenuInferior1.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuInferior1.Location = new System.Drawing.Point(39, 637);
            this.ucMenuInferior1.Name = "ucMenuInferior1";
            this.ucMenuInferior1.Size = new System.Drawing.Size(404, 43);
            this.ucMenuInferior1.TabIndex = 116;
            this.ucMenuInferior1.EventoCadastrar += new GuiWindowsForms.ucMenuInferior.delegateCadastrar(this.ucMenuInferior1_EventoCadastrar);
            this.ucMenuInferior1.EventoVoltar += new GuiWindowsForms.ucMenuInferior.delegateVoltar(this.ucAluno1_EventoVoltar);
            // 
            // uMenuLateral1
            // 
            this.uMenuLateral1.BackColor = System.Drawing.Color.Transparent;
            this.uMenuLateral1.Location = new System.Drawing.Point(875, 75);
            this.uMenuLateral1.Name = "uMenuLateral1";
            this.uMenuLateral1.Size = new System.Drawing.Size(130, 584);
            this.uMenuLateral1.TabIndex = 115;
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
            this.uMenuImagem1.Size = new System.Drawing.Size(546, 201);
            this.uMenuImagem1.TabIndex = 117;
            // 
            // telaAlunoMatriculaAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(179)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(990, 680);
            this.Controls.Add(this.ucDesconectarLogin1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ucMenuInferior1);
            this.Controls.Add(this.btnMatriculaSerie);
            this.Controls.Add(this.gpbMatricula);
            this.Controls.Add(this.uMenuLateral1);
            this.Controls.Add(this.uMenuImagem1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaAlunoMatriculaAtividade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            this.Load += new System.EventHandler(this.telaAlunoMatriculaAtividade_Load);
            this.Activated += new System.EventHandler(this.telaAlunoMatriculaAtividade_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaAlunoMatriculaAtividade_FormClosing);
            this.gpbMatricula.ResumeLayout(false);
            this.gpbMatricula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbMatricula;
        private System.Windows.Forms.TextBox txtTotalValor;
        private System.Windows.Forms.Label lblTotalValor;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblNumeroMatricula;
        private System.Windows.Forms.Label lblAtividade;
        private System.Windows.Forms.ComboBox cmbAtividade;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnMatriculaSerie;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private GuiWindowsForms.User_Control.uMenuLateral uMenuLateral1;
        private ucMenuInferior ucMenuInferior1;
        private uMenuImagem uMenuImagem1;
        private System.Windows.Forms.ErrorProvider errorProviderTela;
        private System.Windows.Forms.PictureBox pictureBox2;
        private GuiWindowsForms.User_Control.ucDesconectarLogin ucDesconectarLogin1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}