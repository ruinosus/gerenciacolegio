namespace GuiWindowsForms
{
    partial class telaConfiguracoesAtividade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaConfiguracoesAtividade));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbSerie = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbrirAtividadeTurma = new System.Windows.Forms.Button();
            this.btnAdicionarImagem = new System.Windows.Forms.Button();
            this.pctImagemAtividade = new System.Windows.Forms.PictureBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProviderTela = new System.Windows.Forms.ErrorProvider(this.components);
            this.ucDesconectarLogin1 = new GuiWindowsForms.User_Control.ucDesconectarLogin();
            this.ucMenuConfiguracoesEsquerda1 = new GuiWindowsForms.User_Control.ucMenuConfiguracoesEsquerda();
            this.ucMenuDireita1 = new GuiWindowsForms.User_Control.ucMenuDireita();
            this.ucMenuInferior1 = new GuiWindowsForms.ucMenuInferior();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbSerie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagemAtividade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTela)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GuiWindowsForms.Properties.Resources.simbolo_colegio;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 112);
            this.pictureBox1.TabIndex = 140;
            this.pictureBox1.TabStop = false;
            // 
            // gpbSerie
            // 
            this.gpbSerie.BackColor = System.Drawing.Color.Transparent;
            this.gpbSerie.Controls.Add(this.label1);
            this.gpbSerie.Controls.Add(this.btnAbrirAtividadeTurma);
            this.gpbSerie.Controls.Add(this.btnAdicionarImagem);
            this.gpbSerie.Controls.Add(this.pctImagemAtividade);
            this.gpbSerie.Controls.Add(this.txtNome);
            this.gpbSerie.Controls.Add(this.btnAlterar);
            this.gpbSerie.Controls.Add(this.txtDescricao);
            this.gpbSerie.Controls.Add(this.btnAdicionar);
            this.gpbSerie.Controls.Add(this.btnExcluir);
            this.gpbSerie.Controls.Add(this.lblDescricao);
            this.gpbSerie.Controls.Add(this.lblNome);
            this.gpbSerie.Controls.Add(this.dataGridView1);
            this.gpbSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSerie.Location = new System.Drawing.Point(153, 129);
            this.gpbSerie.Name = "gpbSerie";
            this.gpbSerie.Size = new System.Drawing.Size(688, 502);
            this.gpbSerie.TabIndex = 142;
            this.gpbSerie.TabStop = false;
            this.gpbSerie.Text = "CADASTRAR ATIVIDADE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(96, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 148;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // btnAbrirAtividadeTurma
            // 
            this.btnAbrirAtividadeTurma.BackgroundImage = global::GuiWindowsForms.Properties.Resources.btn_add_atividade_48x48;
            this.btnAbrirAtividadeTurma.FlatAppearance.BorderSize = 0;
            this.btnAbrirAtividadeTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirAtividadeTurma.Location = new System.Drawing.Point(24, 450);
            this.btnAbrirAtividadeTurma.Name = "btnAbrirAtividadeTurma";
            this.btnAbrirAtividadeTurma.Size = new System.Drawing.Size(48, 48);
            this.btnAbrirAtividadeTurma.TabIndex = 147;
            this.btnAbrirAtividadeTurma.UseVisualStyleBackColor = true;
            this.btnAbrirAtividadeTurma.MouseLeave += new System.EventHandler(this.btnAbrirAtividadeTurma_MouseLeave);
            this.btnAbrirAtividadeTurma.Click += new System.EventHandler(this.btnAbrirAtividadeTurma_Click);
            this.btnAbrirAtividadeTurma.MouseEnter += new System.EventHandler(this.btnAbrirAtividadeTurma_MouseEnter);
            // 
            // btnAdicionarImagem
            // 
            this.btnAdicionarImagem.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_mais;
            this.btnAdicionarImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarImagem.Enabled = false;
            this.btnAdicionarImagem.FlatAppearance.BorderSize = 0;
            this.btnAdicionarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarImagem.Location = new System.Drawing.Point(490, 46);
            this.btnAdicionarImagem.Name = "btnAdicionarImagem";
            this.btnAdicionarImagem.Size = new System.Drawing.Size(32, 32);
            this.btnAdicionarImagem.TabIndex = 145;
            this.btnAdicionarImagem.UseVisualStyleBackColor = true;
            this.btnAdicionarImagem.MouseLeave += new System.EventHandler(this.btnAdicionarImagem_MouseLeave);
            this.btnAdicionarImagem.Click += new System.EventHandler(this.btnAdicionarImagem_Click);
            this.btnAdicionarImagem.MouseEnter += new System.EventHandler(this.btnAdicionarImagem_MouseEnter);
            // 
            // pctImagemAtividade
            // 
            this.pctImagemAtividade.Location = new System.Drawing.Point(538, 19);
            this.pctImagemAtividade.Name = "pctImagemAtividade";
            this.pctImagemAtividade.Size = new System.Drawing.Size(126, 80);
            this.pctImagemAtividade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctImagemAtividade.TabIndex = 146;
            this.pctImagemAtividade.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(99, 40);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(193, 20);
            this.txtNome.TabIndex = 143;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.alterar_final;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Location = new System.Drawing.Point(520, 112);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(32, 32);
            this.btnAlterar.TabIndex = 0;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.MouseLeave += new System.EventHandler(this.btnAlterar_MouseLeave);
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            this.btnAlterar.MouseEnter += new System.EventHandler(this.btnAlterar_MouseEnter);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(99, 97);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(330, 38);
            this.txtDescricao.TabIndex = 144;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_mais;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Location = new System.Drawing.Point(579, 112);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(32, 32);
            this.btnAdicionar.TabIndex = 70;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.MouseLeave += new System.EventHandler(this.btnAdicionarAtividade_MouseLeave);
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            this.btnAdicionar.MouseEnter += new System.EventHandler(this.btnAdicionarAtividade_MouseEnter);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_menos;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(632, 133);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(32, 11);
            this.btnExcluir.TabIndex = 69;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.MouseLeave += new System.EventHandler(this.btnExcluirAtividade_MouseLeave);
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            this.btnExcluir.MouseEnter += new System.EventHandler(this.btnExcluirAtividade_MouseEnter);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(21, 100);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(68, 13);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(21, 43);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Descricao});
            this.dataGridView1.Location = new System.Drawing.Point(24, 165);
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
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.MaxInputLength = 50;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 400;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.MaxInputLength = 30;
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 170;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.ucDesconectarLogin1.TabIndex = 141;
            this.ucDesconectarLogin1.EventoDesconectar += new GuiWindowsForms.User_Control.ucDesconectarLogin.delegateDesconectar(this.ucDesconectarLogin1_EventoDesconectar);
            // 
            // ucMenuConfiguracoesEsquerda1
            // 
            this.ucMenuConfiguracoesEsquerda1.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuConfiguracoesEsquerda1.Location = new System.Drawing.Point(0, 177);
            this.ucMenuConfiguracoesEsquerda1.Name = "ucMenuConfiguracoesEsquerda1";
            this.ucMenuConfiguracoesEsquerda1.Size = new System.Drawing.Size(91, 427);
            this.ucMenuConfiguracoesEsquerda1.TabIndex = 139;
            // 
            // ucMenuDireita1
            // 
            this.ucMenuDireita1.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuDireita1.Location = new System.Drawing.Point(880, 175);
            this.ucMenuDireita1.Name = "ucMenuDireita1";
            this.ucMenuDireita1.Size = new System.Drawing.Size(120, 493);
            this.ucMenuDireita1.TabIndex = 138;
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
            this.ucMenuInferior1.Size = new System.Drawing.Size(760, 43);
            this.ucMenuInferior1.TabIndex = 137;
            this.ucMenuInferior1.EventoCadastrar += new GuiWindowsForms.ucMenuInferior.delegateCadastrar(this.ucMenuInferior1_EventoCadastrar);
            this.ucMenuInferior1.EventoVoltar += new GuiWindowsForms.ucMenuInferior.delegateVoltar(this.ucMenuInferior1_EventoVoltar);
            // 
            // telaConfiguracoesAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(179)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(990, 680);
            this.Controls.Add(this.gpbSerie);
            this.Controls.Add(this.ucDesconectarLogin1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ucMenuConfiguracoesEsquerda1);
            this.Controls.Add(this.ucMenuDireita1);
            this.Controls.Add(this.ucMenuInferior1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaConfiguracoesAtividade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            this.Activated += new System.EventHandler(this.telaConfiguracoesAtividade_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbSerie.ResumeLayout(false);
            this.gpbSerie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagemAtividade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GuiWindowsForms.User_Control.ucDesconectarLogin ucDesconectarLogin1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private GuiWindowsForms.User_Control.ucMenuConfiguracoesEsquerda ucMenuConfiguracoesEsquerda1;
        private GuiWindowsForms.User_Control.ucMenuDireita ucMenuDireita1;
        private ucMenuInferior ucMenuInferior1;
        private System.Windows.Forms.GroupBox gpbSerie;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdicionarImagem;
        private System.Windows.Forms.PictureBox pctImagemAtividade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProviderTela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbrirAtividadeTurma;
    }
}