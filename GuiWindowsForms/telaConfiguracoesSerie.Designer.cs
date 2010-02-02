namespace GuiWindowsForms
{
    partial class telaConfiguracoesSerie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaConfiguracoesSerie));
            this.gpbSerie = new System.Windows.Forms.GroupBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAdicionarSerie = new System.Windows.Forms.Button();
            this.cmbCiclo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serieCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turmaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cicloCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbTurma = new System.Windows.Forms.ComboBox();
            this.cmbSerie = new System.Windows.Forms.ComboBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblCiclo = new System.Windows.Forms.Label();
            this.lblTurma = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.errorProviderTela = new System.Windows.Forms.ErrorProvider(this.components);
            this.ucMenuConfiguracoesEsquerda1 = new GuiWindowsForms.User_Control.ucMenuConfiguracoesEsquerda();
            this.ucMenuDireita1 = new GuiWindowsForms.User_Control.ucMenuDireita();
            this.ucMenuInferior1 = new GuiWindowsForms.ucMenuInferior();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucDesconectarLogin1 = new GuiWindowsForms.User_Control.ucDesconectarLogin();
            this.gpbSerie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbSerie
            // 
            this.gpbSerie.BackColor = System.Drawing.Color.Transparent;
            this.gpbSerie.Controls.Add(this.btnAlterar);
            this.gpbSerie.Controls.Add(this.btnAdicionarSerie);
            this.gpbSerie.Controls.Add(this.cmbCiclo);
            this.gpbSerie.Controls.Add(this.dataGridView1);
            this.gpbSerie.Controls.Add(this.cmbTurma);
            this.gpbSerie.Controls.Add(this.cmbSerie);
            this.gpbSerie.Controls.Add(this.btnExcluir);
            this.gpbSerie.Controls.Add(this.lblCiclo);
            this.gpbSerie.Controls.Add(this.lblTurma);
            this.gpbSerie.Controls.Add(this.cmbTurno);
            this.gpbSerie.Controls.Add(this.lblTurno);
            this.gpbSerie.Controls.Add(this.txtValor);
            this.gpbSerie.Controls.Add(this.lblValor);
            this.gpbSerie.Controls.Add(this.lblSerie);
            this.gpbSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSerie.Location = new System.Drawing.Point(153, 129);
            this.gpbSerie.Name = "gpbSerie";
            this.gpbSerie.Size = new System.Drawing.Size(688, 502);
            this.gpbSerie.TabIndex = 0;
            this.gpbSerie.TabStop = false;
            this.gpbSerie.Text = "CADASTRO DE SÉRIE";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.alterar_final;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Location = new System.Drawing.Point(556, 166);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(32, 32);
            this.btnAlterar.TabIndex = 71;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.MouseLeave += new System.EventHandler(this.btnAlterar_MouseLeave);
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            this.btnAlterar.MouseEnter += new System.EventHandler(this.btnAlterar_MouseEnter);
            // 
            // btnAdicionarSerie
            // 
            this.btnAdicionarSerie.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_mais;
            this.btnAdicionarSerie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarSerie.FlatAppearance.BorderSize = 0;
            this.btnAdicionarSerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarSerie.Location = new System.Drawing.Point(594, 166);
            this.btnAdicionarSerie.Name = "btnAdicionarSerie";
            this.btnAdicionarSerie.Size = new System.Drawing.Size(32, 32);
            this.btnAdicionarSerie.TabIndex = 3;
            this.btnAdicionarSerie.UseVisualStyleBackColor = true;
            this.btnAdicionarSerie.MouseLeave += new System.EventHandler(this.btnAdicionarSerie_MouseLeave);
            this.btnAdicionarSerie.Click += new System.EventHandler(this.btnAdicionarSerie_Click);
            this.btnAdicionarSerie.MouseEnter += new System.EventHandler(this.btnAdicionarSerie_MouseEnter);
            // 
            // cmbCiclo
            // 
            this.cmbCiclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiclo.Enabled = false;
            this.cmbCiclo.FormattingEnabled = true;
            this.cmbCiclo.Items.AddRange(new object[] {
            "selecione",
            "Educação Infantil",
            "Ensino Fundamental I",
            "Ensino Fundamental II",
            "Ensino Médio"});
            this.cmbCiclo.Location = new System.Drawing.Point(405, 69);
            this.cmbCiclo.Name = "cmbCiclo";
            this.cmbCiclo.Size = new System.Drawing.Size(259, 21);
            this.cmbCiclo.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serieCol,
            this.turmaCol,
            this.turnoCol,
            this.cicloCol,
            this.valorCol});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(24, 207);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(640, 284);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.MouseLeave += new System.EventHandler(this.dataGridView1_MouseLeave);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.MouseEnter += new System.EventHandler(this.dataGridView1_MouseEnter);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // serieCol
            // 
            this.serieCol.DataPropertyName = "SerieAux";
            this.serieCol.HeaderText = "Série";
            this.serieCol.Name = "serieCol";
            this.serieCol.ReadOnly = true;
            this.serieCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.serieCol.Width = 102;
            // 
            // turmaCol
            // 
            this.turmaCol.DataPropertyName = "TurmaAux";
            this.turmaCol.HeaderText = "Turma";
            this.turmaCol.Name = "turmaCol";
            this.turmaCol.ReadOnly = true;
            // 
            // turnoCol
            // 
            this.turnoCol.DataPropertyName = "TurnoAux";
            this.turnoCol.HeaderText = "Turno";
            this.turnoCol.Name = "turnoCol";
            this.turnoCol.ReadOnly = true;
            this.turnoCol.Width = 80;
            // 
            // cicloCol
            // 
            this.cicloCol.DataPropertyName = "CicloAux";
            this.cicloCol.HeaderText = "Ciclo";
            this.cicloCol.Name = "cicloCol";
            this.cicloCol.ReadOnly = true;
            this.cicloCol.Width = 175;
            // 
            // valorCol
            // 
            this.valorCol.DataPropertyName = "ValorAux";
            this.valorCol.HeaderText = "Valor";
            this.valorCol.Name = "valorCol";
            this.valorCol.ReadOnly = true;
            this.valorCol.Width = 120;
            // 
            // cmbTurma
            // 
            this.cmbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurma.Enabled = false;
            this.cmbTurma.FormattingEnabled = true;
            this.cmbTurma.Location = new System.Drawing.Point(319, 116);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(121, 21);
            this.cmbTurma.TabIndex = 3;
            this.cmbTurma.TextChanged += new System.EventHandler(this.cmbTurma_TextChanged);
            this.cmbTurma.Click += new System.EventHandler(this.cmbTurma_Click);
            // 
            // cmbSerie
            // 
            this.cmbSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSerie.Enabled = false;
            this.cmbSerie.FormattingEnabled = true;
            this.cmbSerie.Items.AddRange(new object[] {
            ""});
            this.cmbSerie.Location = new System.Drawing.Point(92, 69);
            this.cmbSerie.Name = "cmbSerie";
            this.cmbSerie.Size = new System.Drawing.Size(231, 21);
            this.cmbSerie.TabIndex = 0;
            this.cmbSerie.TextChanged += new System.EventHandler(this.cmbSerie_TextChanged);
            this.cmbSerie.Click += new System.EventHandler(this.cmbSerie_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_menos;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(632, 187);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(32, 11);
            this.btnExcluir.TabIndex = 70;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.MouseLeave += new System.EventHandler(this.btnExcluir_MouseLeave);
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            this.btnExcluir.MouseEnter += new System.EventHandler(this.btnExcluir_MouseEnter);
            // 
            // lblCiclo
            // 
            this.lblCiclo.AutoSize = true;
            this.lblCiclo.Location = new System.Drawing.Point(360, 72);
            this.lblCiclo.Name = "lblCiclo";
            this.lblCiclo.Size = new System.Drawing.Size(39, 13);
            this.lblCiclo.TabIndex = 1;
            this.lblCiclo.Text = "Ciclo:";
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(267, 119);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(46, 13);
            this.lblTurma.TabIndex = 3;
            this.lblTurma.Text = "Turma:";
            // 
            // cmbTurno
            // 
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.Enabled = false;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(92, 116);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(121, 21);
            this.cmbTurno.TabIndex = 2;
            this.cmbTurno.TextChanged += new System.EventHandler(this.cmbTurno_TextChanged);
            this.cmbTurno.Click += new System.EventHandler(this.cmbTurno_Click);
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(21, 119);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(44, 13);
            this.lblTurno.TabIndex = 2;
            this.lblTurno.Text = "Turno:";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(92, 162);
            this.txtValor.MaxLength = 10;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(112, 20);
            this.txtValor.TabIndex = 4;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            this.txtValor.Click += new System.EventHandler(this.txtValor_Click);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(21, 165);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(68, 13);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor (R$):";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(21, 72);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(40, 13);
            this.lblSerie.TabIndex = 0;
            this.lblSerie.Text = "Série:";
            // 
            // errorProviderTela
            // 
            this.errorProviderTela.ContainerControl = this;
            // 
            // ucMenuConfiguracoesEsquerda1
            // 
            this.ucMenuConfiguracoesEsquerda1.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuConfiguracoesEsquerda1.Location = new System.Drawing.Point(0, 177);
            this.ucMenuConfiguracoesEsquerda1.Name = "ucMenuConfiguracoesEsquerda1";
            this.ucMenuConfiguracoesEsquerda1.Size = new System.Drawing.Size(91, 443);
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
            this.ucMenuInferior1.Size = new System.Drawing.Size(915, 43);
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
            // ucDesconectarLogin1
            // 
            this.ucDesconectarLogin1.BackColor = System.Drawing.Color.Transparent;
            this.ucDesconectarLogin1.Location = new System.Drawing.Point(738, 0);
            this.ucDesconectarLogin1.Name = "ucDesconectarLogin1";
            this.ucDesconectarLogin1.Size = new System.Drawing.Size(253, 39);
            this.ucDesconectarLogin1.TabIndex = 136;
            this.ucDesconectarLogin1.EventoDesconectar += new GuiWindowsForms.User_Control.ucDesconectarLogin.delegateDesconectar(this.ucDesconectarLogin1_EventoDesconectar);
            // 
            // telaConfiguracoesSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(179)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(990, 680);
            this.Controls.Add(this.ucDesconectarLogin1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ucMenuConfiguracoesEsquerda1);
            this.Controls.Add(this.ucMenuDireita1);
            this.Controls.Add(this.gpbSerie);
            this.Controls.Add(this.ucMenuInferior1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaConfiguracoesSerie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            this.Load += new System.EventHandler(this.telaConfiguracoesSerie_Load);
            this.Activated += new System.EventHandler(this.telaConfiguracoesSerie_Activated);
            this.gpbSerie.ResumeLayout(false);
            this.gpbSerie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbSerie;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.Label lblCiclo;
        private System.Windows.Forms.Button btnExcluir;
        private GuiWindowsForms.User_Control.ucMenuDireita ucMenuDireita1;
        private GuiWindowsForms.User_Control.ucMenuConfiguracoesEsquerda ucMenuConfiguracoesEsquerda1;
        private ucMenuInferior ucMenuInferior1;
        private System.Windows.Forms.ComboBox cmbTurma;
        private System.Windows.Forms.ComboBox cmbSerie;
        private System.Windows.Forms.ErrorProvider errorProviderTela;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbCiclo;
        private System.Windows.Forms.Button btnAdicionarSerie;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn turmaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cicloCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorCol;
        private System.Windows.Forms.PictureBox pictureBox1;
        private GuiWindowsForms.User_Control.ucDesconectarLogin ucDesconectarLogin1;
    }
}