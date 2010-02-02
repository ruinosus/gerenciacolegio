namespace GuiWindowsForms
{
    partial class telaConfiguracoesDescontoMatricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaConfiguracoesDescontoMatricula));
            this.gpbSerie = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAdicionarDesconto = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percentual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProviderTela = new System.Windows.Forms.ErrorProvider(this.components);
            this.ucDesconectarLogin1 = new GuiWindowsForms.User_Control.ucDesconectarLogin();
            this.ucMenuConfiguracoesEsquerda1 = new GuiWindowsForms.User_Control.ucMenuConfiguracoesEsquerda();
            this.ucMenuDireita1 = new GuiWindowsForms.User_Control.ucMenuDireita();
            this.ucMenuInferior1 = new GuiWindowsForms.ucMenuInferior();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbSerie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbSerie
            // 
            this.gpbSerie.BackColor = System.Drawing.Color.Transparent;
            this.gpbSerie.Controls.Add(this.txtValor);
            this.gpbSerie.Controls.Add(this.btnAlterar);
            this.gpbSerie.Controls.Add(this.btnAdicionarDesconto);
            this.gpbSerie.Controls.Add(this.btnExcluir);
            this.gpbSerie.Controls.Add(this.lblValor);
            this.gpbSerie.Controls.Add(this.txtDescricao);
            this.gpbSerie.Controls.Add(this.lblDescricao);
            this.gpbSerie.Controls.Add(this.dataGridView1);
            this.gpbSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSerie.Location = new System.Drawing.Point(153, 129);
            this.gpbSerie.Name = "gpbSerie";
            this.gpbSerie.Size = new System.Drawing.Size(688, 484);
            this.gpbSerie.TabIndex = 0;
            this.gpbSerie.TabStop = false;
            this.gpbSerie.Text = "DESCONTO MATRICULA";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(92, 134);
            this.txtValor.MaxLength = 3;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 71;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.alterar_final;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Location = new System.Drawing.Point(520, 152);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(32, 32);
            this.btnAlterar.TabIndex = 0;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.MouseLeave += new System.EventHandler(this.btnAlterar_MouseLeave);
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            this.btnAlterar.MouseEnter += new System.EventHandler(this.btnAlterar_MouseEnter);
            // 
            // btnAdicionarDesconto
            // 
            this.btnAdicionarDesconto.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_mais;
            this.btnAdicionarDesconto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarDesconto.FlatAppearance.BorderSize = 0;
            this.btnAdicionarDesconto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarDesconto.Location = new System.Drawing.Point(579, 152);
            this.btnAdicionarDesconto.Name = "btnAdicionarDesconto";
            this.btnAdicionarDesconto.Size = new System.Drawing.Size(32, 32);
            this.btnAdicionarDesconto.TabIndex = 70;
            this.btnAdicionarDesconto.UseVisualStyleBackColor = true;
            this.btnAdicionarDesconto.MouseLeave += new System.EventHandler(this.btnAdicionarDesconto_MouseLeave);
            this.btnAdicionarDesconto.Click += new System.EventHandler(this.btnAdicionarDesconto_Click);
            this.btnAdicionarDesconto.MouseEnter += new System.EventHandler(this.btnAdicionarDesconto_MouseEnter);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_menos;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(632, 173);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(32, 11);
            this.btnExcluir.TabIndex = 69;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.MouseLeave += new System.EventHandler(this.btnExcluir_MouseLeave);
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            this.btnExcluir.MouseEnter += new System.EventHandler(this.btnExcluir_MouseEnter);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(21, 137);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(61, 13);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor (%):";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(92, 69);
            this.txtDescricao.MaxLength = 30;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(249, 20);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(21, 72);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(68, 13);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descricao,
            this.Percentual});
            this.dataGridView1.Location = new System.Drawing.Point(24, 190);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(640, 285);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.MouseLeave += new System.EventHandler(this.dataGridView1_MouseLeave);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.MouseEnter += new System.EventHandler(this.dataGridView1_MouseEnter);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.MaxInputLength = 50;
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 400;
            // 
            // Percentual
            // 
            this.Percentual.DataPropertyName = "Percentual";
            this.Percentual.HeaderText = "Percentual";
            this.Percentual.MaxInputLength = 30;
            this.Percentual.Name = "Percentual";
            this.Percentual.ReadOnly = true;
            this.Percentual.Width = 170;
            // 
            // errorProviderTela
            // 
            this.errorProviderTela.ContainerControl = this;
            // 
            // ucDesconectarLogin1
            // 
            this.ucDesconectarLogin1.BackColor = System.Drawing.Color.Transparent;
            this.ucDesconectarLogin1.Location = new System.Drawing.Point(738, 0);
            this.ucDesconectarLogin1.Name = "ucDesconectarLogin1";
            this.ucDesconectarLogin1.Size = new System.Drawing.Size(253, 39);
            this.ucDesconectarLogin1.TabIndex = 136;
            this.ucDesconectarLogin1.EventoDesconectar += new GuiWindowsForms.User_Control.ucDesconectarLogin.delegateDesconectar(this.ucDesconectarLogin1_EventoDesconectar);
            // 
            // ucMenuConfiguracoesEsquerda1
            // 
            this.ucMenuConfiguracoesEsquerda1.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuConfiguracoesEsquerda1.Location = new System.Drawing.Point(0, 177);
            this.ucMenuConfiguracoesEsquerda1.Name = "ucMenuConfiguracoesEsquerda1";
            this.ucMenuConfiguracoesEsquerda1.Size = new System.Drawing.Size(91, 427);
            this.ucMenuConfiguracoesEsquerda1.TabIndex = 134;
            this.ucMenuConfiguracoesEsquerda1.Load += new System.EventHandler(this.ucMenuConfiguracoesEsquerda1_Load);
            this.ucMenuConfiguracoesEsquerda1.EventoAbrirControleDeAcesso += new GuiWindowsForms.User_Control.ucMenuConfiguracoesEsquerda.delegateAbrirTelaControleDeAcesso(this.ucMenuConfiguracoesEsquerda1_EventoAbrirControleDeAcesso);
            // 
            // ucMenuDireita1
            // 
            this.ucMenuDireita1.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuDireita1.Location = new System.Drawing.Point(880, 175);
            this.ucMenuDireita1.Name = "ucMenuDireita1";
            this.ucMenuDireita1.Size = new System.Drawing.Size(120, 493);
            this.ucMenuDireita1.TabIndex = 133;
            this.ucMenuDireita1.Load += new System.EventHandler(this.ucMenuDireita1_Load);
            this.ucMenuDireita1.EventoAbrirAtividade += new GuiWindowsForms.User_Control.ucMenuDireita.delegateAbrirTelaAtividade(this.ucMenuDireita1_EventoAbrirAtividade);
            this.ucMenuDireita1.EventoAbrirDesconto += new GuiWindowsForms.User_Control.ucMenuDireita.delegateAbrirTelaDesconto(this.ucMenuDireita1_EventoAbrirDesconto);
            this.ucMenuDireita1.EventoAbrirSerie += new GuiWindowsForms.User_Control.ucMenuDireita.delegateAbrirTelaSerie(this.ucMenuDireita1_EventoAbrirSerie);
            // 
            // ucMenuInferior1
            // 
            this.ucMenuInferior1.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuInferior1.Location = new System.Drawing.Point(39, 637);
            this.ucMenuInferior1.Name = "ucMenuInferior1";
            this.ucMenuInferior1.Size = new System.Drawing.Size(499, 43);
            this.ucMenuInferior1.TabIndex = 1;
            this.ucMenuInferior1.EventoCadastrar += new GuiWindowsForms.ucMenuInferior.delegateCadastrar(this.ucMenuInferior1_EventoCadastrar);
            this.ucMenuInferior1.EventoVoltar += new GuiWindowsForms.ucMenuInferior.delegateVoltar(this.ucAluno1_EventoVoltar);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GuiWindowsForms.Properties.Resources.simbolo_colegio;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 112);
            this.pictureBox1.TabIndex = 135;
            this.pictureBox1.TabStop = false;
            // 
            // telaConfiguracoesDescontoMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(179)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(990, 680);
            this.Controls.Add(this.ucDesconectarLogin1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ucMenuConfiguracoesEsquerda1);
            this.Controls.Add(this.ucMenuDireita1);
            this.Controls.Add(this.ucMenuInferior1);
            this.Controls.Add(this.gpbSerie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaConfiguracoesDescontoMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            this.Load += new System.EventHandler(this.telaConfiguracoesDescontoMatricula_Load);
            this.Activated += new System.EventHandler(this.telaConfiguracoesDescontoMatricula_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaConfiguracoesDescontoMatricula_FormClosing);
            this.gpbSerie.ResumeLayout(false);
            this.gpbSerie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbSerie;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExcluir;
        private GuiWindowsForms.User_Control.ucMenuDireita ucMenuDireita1;
        private GuiWindowsForms.User_Control.ucMenuConfiguracoesEsquerda ucMenuConfiguracoesEsquerda1;
        private ucMenuInferior ucMenuInferior1;
        private System.Windows.Forms.ErrorProvider errorProviderTela;
        private System.Windows.Forms.Button btnAdicionarDesconto;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percentual;
        private System.Windows.Forms.PictureBox pictureBox1;
        private GuiWindowsForms.User_Control.ucDesconectarLogin ucDesconectarLogin1;
        private System.Windows.Forms.TextBox txtValor;
    }
}