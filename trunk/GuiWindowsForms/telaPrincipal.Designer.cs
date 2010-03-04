namespace GuiWindowsForms
{
    partial class telaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaPrincipal));
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lblAlunoOculto = new System.Windows.Forms.Label();
            this.lblFuncOculto = new System.Windows.Forms.Label();
            this.lblConfOculto = new System.Windows.Forms.Label();
            this.lblErro = new System.Windows.Forms.Label();
            this.lblFinanceiro = new System.Windows.Forms.Label();
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnAluno = new System.Windows.Forms.Button();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaNomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoneAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCiclo = new System.Windows.Forms.ComboBox();
            this.cmbSerie = new System.Windows.Forms.ComboBox();
            this.lblCiclo = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.ucDesconectarLogin1 = new GuiWindowsForms.User_Control.ucDesconectarLogin();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusca
            // 
            this.txtBusca.Enabled = false;
            this.txtBusca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtBusca.Location = new System.Drawing.Point(365, 205);
            this.txtBusca.MaxLength = 60;
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(415, 26);
            this.txtBusca.TabIndex = 0;
            this.txtBusca.Leave += new System.EventHandler(this.txtLogin_Leave);
            this.txtBusca.Enter += new System.EventHandler(this.txtLogin_Enter);
            // 
            // lblAlunoOculto
            // 
            this.lblAlunoOculto.AutoSize = true;
            this.lblAlunoOculto.BackColor = System.Drawing.Color.Transparent;
            this.lblAlunoOculto.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblAlunoOculto.ForeColor = System.Drawing.Color.Yellow;
            this.lblAlunoOculto.Location = new System.Drawing.Point(275, 119);
            this.lblAlunoOculto.Name = "lblAlunoOculto";
            this.lblAlunoOculto.Size = new System.Drawing.Size(70, 23);
            this.lblAlunoOculto.TabIndex = 8;
            this.lblAlunoOculto.Text = "Alunos";
            // 
            // lblFuncOculto
            // 
            this.lblFuncOculto.AutoSize = true;
            this.lblFuncOculto.BackColor = System.Drawing.Color.Transparent;
            this.lblFuncOculto.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblFuncOculto.ForeColor = System.Drawing.Color.Yellow;
            this.lblFuncOculto.Location = new System.Drawing.Point(386, 119);
            this.lblFuncOculto.Name = "lblFuncOculto";
            this.lblFuncOculto.Size = new System.Drawing.Size(125, 23);
            this.lblFuncOculto.TabIndex = 10;
            this.lblFuncOculto.Text = "Funcionários";
            this.lblFuncOculto.Visible = false;
            // 
            // lblConfOculto
            // 
            this.lblConfOculto.AutoSize = true;
            this.lblConfOculto.BackColor = System.Drawing.Color.Transparent;
            this.lblConfOculto.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblConfOculto.ForeColor = System.Drawing.Color.Yellow;
            this.lblConfOculto.Location = new System.Drawing.Point(532, 119);
            this.lblConfOculto.Name = "lblConfOculto";
            this.lblConfOculto.Size = new System.Drawing.Size(138, 23);
            this.lblConfOculto.TabIndex = 12;
            this.lblConfOculto.Text = "Configurações";
            this.lblConfOculto.Visible = false;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.BackColor = System.Drawing.Color.Transparent;
            this.lblErro.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.Yellow;
            this.lblErro.Location = new System.Drawing.Point(281, 680);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(158, 23);
            this.lblErro.TabIndex = 13;
            this.lblErro.Text = "Senha Incorreta!";
            this.lblErro.Visible = false;
            // 
            // lblFinanceiro
            // 
            this.lblFinanceiro.AutoSize = true;
            this.lblFinanceiro.BackColor = System.Drawing.Color.Transparent;
            this.lblFinanceiro.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblFinanceiro.ForeColor = System.Drawing.Color.Yellow;
            this.lblFinanceiro.Location = new System.Drawing.Point(690, 122);
            this.lblFinanceiro.Name = "lblFinanceiro";
            this.lblFinanceiro.Size = new System.Drawing.Size(104, 23);
            this.lblFinanceiro.TabIndex = 15;
            this.lblFinanceiro.Text = "Financeiro";
            this.lblFinanceiro.Visible = false;
            // 
            // dgvAluno
            // 
            this.dgvAluno.AllowUserToAddRows = false;
            this.dgvAluno.AllowUserToDeleteRows = false;
            this.dgvAluno.BackgroundColor = System.Drawing.Color.White;
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaNomeAluno,
            this.Serie,
            this.FoneAluno,
            this.EmailAluno});
            this.dgvAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvAluno.Location = new System.Drawing.Point(203, 262);
            this.dgvAluno.MultiSelect = false;
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.ReadOnly = true;
            this.dgvAluno.Size = new System.Drawing.Size(750, 344);
            this.dgvAluno.TabIndex = 17;
            this.dgvAluno.Visible = false;
            this.dgvAluno.DoubleClick += new System.EventHandler(this.dgvAluno_DoubleClick);
            this.dgvAluno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAluno_CellClick);
            this.dgvAluno.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAluno_CellEnter);
            // 
            // Column3
            // 
            this.Column3.Name = "Column3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GuiWindowsForms.Properties.Resources.simbolo_colegio;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 112);
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarFuncionario.BackgroundImage = global::GuiWindowsForms.Properties.Resources.btn_ok_cadastrar_145x52;
            this.btnCadastrarFuncionario.FlatAppearance.BorderSize = 0;
            this.btnCadastrarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(203, 628);
            this.btnCadastrarFuncionario.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(145, 52);
            this.btnCadastrarFuncionario.TabIndex = 16;
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = false;
            this.btnCadastrarFuncionario.Visible = false;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.BackColor = System.Drawing.Color.Transparent;
            this.btnFinanceiro.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_gnd_120x110;
            this.btnFinanceiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinanceiro.Enabled = false;
            this.btnFinanceiro.FlatAppearance.BorderSize = 0;
            this.btnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanceiro.Location = new System.Drawing.Point(674, 15);
            this.btnFinanceiro.Margin = new System.Windows.Forms.Padding(0);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(120, 110);
            this.btnFinanceiro.TabIndex = 5;
            this.btnFinanceiro.UseVisualStyleBackColor = false;
            this.btnFinanceiro.Click += new System.EventHandler(this.btnFinanceiro_Click);
            this.btnFinanceiro.Leave += new System.EventHandler(this.btnFinanceiro_Leave);
            this.btnFinanceiro.Enter += new System.EventHandler(this.btnFinanceiro_Enter);
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracoes.BackgroundImage = global::GuiWindowsForms.Properties.Resources.configuracoes_137x101;
            this.btnConfiguracoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.btnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracoes.Location = new System.Drawing.Point(526, 12);
            this.btnConfiguracoes.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(137, 101);
            this.btnConfiguracoes.TabIndex = 4;
            this.btnConfiguracoes.UseVisualStyleBackColor = false;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            this.btnConfiguracoes.Leave += new System.EventHandler(this.btnConfiguracoes_Leave);
            this.btnConfiguracoes.Enter += new System.EventHandler(this.btnConfiguracoes_Enter);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoEllipsis = true;
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.Search_76x76;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Enabled = false;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Location = new System.Drawing.Point(801, 181);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(74, 75);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarAluno.BackgroundImage = global::GuiWindowsForms.Properties.Resources.btn_ok_cadastrar_110x52;
            this.btnCadastrarAluno.FlatAppearance.BorderSize = 0;
            this.btnCadastrarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarAluno.Location = new System.Drawing.Point(203, 628);
            this.btnCadastrarAluno.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(110, 52);
            this.btnCadastrarAluno.TabIndex = 6;
            this.btnCadastrarAluno.UseVisualStyleBackColor = false;
            this.btnCadastrarAluno.Visible = false;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.btnFuncionario.BackgroundImage = global::GuiWindowsForms.Properties.Resources.icone_prof_142x113;
            this.btnFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFuncionario.FlatAppearance.BorderSize = 0;
            this.btnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionario.Location = new System.Drawing.Point(365, 9);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(142, 113);
            this.btnFuncionario.TabIndex = 3;
            this.btnFuncionario.UseVisualStyleBackColor = false;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            this.btnFuncionario.Leave += new System.EventHandler(this.btnFuncionario_Leave);
            this.btnFuncionario.Enter += new System.EventHandler(this.btnFuncionario_Enter);
            // 
            // btnAluno
            // 
            this.btnAluno.BackColor = System.Drawing.Color.Transparent;
            this.btnAluno.BackgroundImage = global::GuiWindowsForms.Properties.Resources.icone_aluno_142x113;
            this.btnAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAluno.FlatAppearance.BorderSize = 0;
            this.btnAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAluno.Location = new System.Drawing.Point(240, 9);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(142, 113);
            this.btnAluno.TabIndex = 2;
            this.btnAluno.UseVisualStyleBackColor = false;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            this.btnAluno.Leave += new System.EventHandler(this.btnAluno_Leave);
            this.btnAluno.Enter += new System.EventHandler(this.btnAluno_Enter);
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.AllowUserToAddRows = false;
            this.dgvFuncionario.AllowUserToDeleteRows = false;
            this.dgvFuncionario.BackgroundColor = System.Drawing.Color.White;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Cargo});
            this.dgvFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvFuncionario.Location = new System.Drawing.Point(203, 262);
            this.dgvFuncionario.MultiSelect = false;
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.ReadOnly = true;
            this.dgvFuncionario.Size = new System.Drawing.Size(750, 344);
            this.dgvFuncionario.TabIndex = 72;
            this.dgvFuncionario.Visible = false;
            this.dgvFuncionario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellDoubleClick_1);
            this.dgvFuncionario.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellContentDoubleClick);
            this.dgvFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do Funcionário";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 60;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // Cargo
            // 
            this.Cargo.DataPropertyName = "Cargo";
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            // 
            // colunaNomeAluno
            // 
            this.colunaNomeAluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colunaNomeAluno.DataPropertyName = "Nome";
            this.colunaNomeAluno.HeaderText = "Nome do Aluno";
            this.colunaNomeAluno.MaxInputLength = 40;
            this.colunaNomeAluno.Name = "colunaNomeAluno";
            this.colunaNomeAluno.ReadOnly = true;
            this.colunaNomeAluno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colunaNomeAluno.Width = 300;
            // 
            // Serie
            // 
            this.Serie.DataPropertyName = "SerieAtual";
            this.Serie.HeaderText = "Série";
            this.Serie.Name = "Serie";
            this.Serie.ReadOnly = true;
            // 
            // FoneAluno
            // 
            this.FoneAluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FoneAluno.DataPropertyName = "FoneResidencia";
            this.FoneAluno.HeaderText = "Fone Resid.";
            this.FoneAluno.MaxInputLength = 15;
            this.FoneAluno.Name = "FoneAluno";
            this.FoneAluno.ReadOnly = true;
            this.FoneAluno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EmailAluno
            // 
            this.EmailAluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EmailAluno.DataPropertyName = "Email";
            this.EmailAluno.HeaderText = "Email do Aluno";
            this.EmailAluno.MaxInputLength = 20;
            this.EmailAluno.Name = "EmailAluno";
            this.EmailAluno.ReadOnly = true;
            this.EmailAluno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.EmailAluno.Width = 180;
            // 
            // cmbCiclo
            // 
            this.cmbCiclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiclo.FormattingEnabled = true;
            this.cmbCiclo.Items.AddRange(new object[] {
            "selecione",
            "Educação Infantil",
            "Ensino Fundamental I",
            "Ensino Fundamental II",
            "Ensino Médio"});
            this.cmbCiclo.Location = new System.Drawing.Point(0, 317);
            this.cmbCiclo.Name = "cmbCiclo";
            this.cmbCiclo.Size = new System.Drawing.Size(186, 21);
            this.cmbCiclo.TabIndex = 75;
            // 
            // cmbSerie
            // 
            this.cmbSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSerie.FormattingEnabled = true;
            this.cmbSerie.Items.AddRange(new object[] {
            ""});
            this.cmbSerie.Location = new System.Drawing.Point(0, 262);
            this.cmbSerie.Name = "cmbSerie";
            this.cmbSerie.Size = new System.Drawing.Size(186, 21);
            this.cmbSerie.TabIndex = 74;
            // 
            // lblCiclo
            // 
            this.lblCiclo.AutoSize = true;
            this.lblCiclo.Location = new System.Drawing.Point(-2, 303);
            this.lblCiclo.Name = "lblCiclo";
            this.lblCiclo.Size = new System.Drawing.Size(39, 13);
            this.lblCiclo.TabIndex = 76;
            this.lblCiclo.Text = "Ciclo:";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(-3, 248);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(40, 13);
            this.lblSerie.TabIndex = 73;
            this.lblSerie.Text = "Série:";
            // 
            // ucDesconectarLogin1
            // 
            this.ucDesconectarLogin1.BackColor = System.Drawing.Color.Transparent;
            this.ucDesconectarLogin1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucDesconectarLogin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucDesconectarLogin1.Location = new System.Drawing.Point(768, 0);
            this.ucDesconectarLogin1.Name = "ucDesconectarLogin1";
            this.ucDesconectarLogin1.Size = new System.Drawing.Size(220, 39);
            this.ucDesconectarLogin1.TabIndex = 6;
            this.ucDesconectarLogin1.EventoDesconectar += new GuiWindowsForms.User_Control.ucDesconectarLogin.delegateDesconectar(this.ucDesconectarLogin1_EventoDesconectar);
            // 
            // telaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(179)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(990, 680);
            this.Controls.Add(this.cmbCiclo);
            this.Controls.Add(this.cmbSerie);
            this.Controls.Add(this.lblCiclo);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.dgvFuncionario);
            this.Controls.Add(this.ucDesconectarLogin1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvAluno);
            this.Controls.Add(this.btnCadastrarFuncionario);
            this.Controls.Add(this.lblFinanceiro);
            this.Controls.Add(this.btnFinanceiro);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.lblConfOculto);
            this.Controls.Add(this.btnConfiguracoes);
            this.Controls.Add(this.lblFuncOculto);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblAlunoOculto);
            this.Controls.Add(this.btnCadastrarAluno);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.btnAluno);
            this.Controls.Add(this.txtBusca);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            this.Load += new System.EventHandler(this.telaAlunoPrincipal_Load);
            this.Activated += new System.EventHandler(this.telaAlunoPrincipal_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaAlunoPrincipal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Label lblAlunoOculto;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.Label lblFuncOculto;
        private System.Windows.Forms.Label lblConfOculto;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Label lblFinanceiro;
        private System.Windows.Forms.Button btnFinanceiro;
        private System.Windows.Forms.Button btnCadastrarFuncionario;
        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private GuiWindowsForms.User_Control.ucDesconectarLogin ucDesconectarLogin1;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoneAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAluno;
        private System.Windows.Forms.ComboBox cmbCiclo;
        private System.Windows.Forms.ComboBox cmbSerie;
        private System.Windows.Forms.Label lblCiclo;
        private System.Windows.Forms.Label lblSerie;
    }
}