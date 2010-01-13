namespace GuiWindowsForms
{
    partial class telaAlunoPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaAlunoPrincipal));
            this.lblHelloUsuario = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnAluno = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.lblAlunoOculto = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.lblFuncOculto = new System.Windows.Forms.Label();
            this.lblConfOculto = new System.Windows.Forms.Label();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.lblErro = new System.Windows.Forms.Label();
            this.lblFinanceiro = new System.Windows.Forms.Label();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.colunaNomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefoneAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerieAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            this.SuspendLayout();
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
            this.lblHelloUsuario.TabIndex = 1;
            this.lblHelloUsuario.Text = "Hello Usuário!";
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtBusca.Location = new System.Drawing.Point(285, 248);
            this.txtBusca.MaxLength = 60;
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(415, 26);
            this.txtBusca.TabIndex = 2;
            this.txtBusca.Leave += new System.EventHandler(this.txtLogin_Leave);
            this.txtBusca.Enter += new System.EventHandler(this.txtLogin_Enter);
            // 
            // btnAluno
            // 
            this.btnAluno.BackColor = System.Drawing.Color.Transparent;
            this.btnAluno.BackgroundImage = global::GuiWindowsForms.Properties.Resources.icone_aluno_142x113;
            this.btnAluno.FlatAppearance.BorderSize = 0;
            this.btnAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAluno.Location = new System.Drawing.Point(240, 9);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(142, 113);
            this.btnAluno.TabIndex = 4;
            this.btnAluno.UseVisualStyleBackColor = false;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            this.btnAluno.Leave += new System.EventHandler(this.btnAluno_Leave);
            this.btnAluno.Enter += new System.EventHandler(this.btnAluno_Enter);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.btnFuncionario.BackgroundImage = global::GuiWindowsForms.Properties.Resources.icone_prof_142x113;
            this.btnFuncionario.FlatAppearance.BorderSize = 0;
            this.btnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionario.Location = new System.Drawing.Point(365, 9);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(142, 113);
            this.btnFuncionario.TabIndex = 5;
            this.btnFuncionario.UseVisualStyleBackColor = false;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            this.btnFuncionario.Leave += new System.EventHandler(this.btnFuncionario_Leave);
            this.btnFuncionario.Enter += new System.EventHandler(this.btnFuncionario_Enter);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.BackColor = System.Drawing.Color.Transparent;
            this.btnDesconectar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.icone_desconectar;
            this.btnDesconectar.FlatAppearance.BorderSize = 0;
            this.btnDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconectar.Location = new System.Drawing.Point(950, 9);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(30, 30);
            this.btnDesconectar.TabIndex = 7;
            this.btnDesconectar.UseVisualStyleBackColor = false;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
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
            // btnPesquisar
            // 
            this.btnPesquisar.AutoEllipsis = true;
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.Search_76x76;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Location = new System.Drawing.Point(737, 225);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(74, 75);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarAluno.BackgroundImage = global::GuiWindowsForms.Properties.Resources.btn_ok_cadastrar_110x52;
            this.btnCadastrarAluno.FlatAppearance.BorderSize = 0;
            this.btnCadastrarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarAluno.Location = new System.Drawing.Point(31, 667);
            this.btnCadastrarAluno.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(110, 52);
            this.btnCadastrarAluno.TabIndex = 6;
            this.btnCadastrarAluno.UseVisualStyleBackColor = false;
            this.btnCadastrarAluno.Visible = false;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
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
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracoes.BackgroundImage = global::GuiWindowsForms.Properties.Resources.configuracoes_137x101;
            this.btnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.btnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracoes.Location = new System.Drawing.Point(526, 12);
            this.btnConfiguracoes.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(137, 101);
            this.btnConfiguracoes.TabIndex = 11;
            this.btnConfiguracoes.UseVisualStyleBackColor = false;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            this.btnConfiguracoes.Leave += new System.EventHandler(this.btnConfiguracoes_Leave);
            this.btnConfiguracoes.Enter += new System.EventHandler(this.btnConfiguracoes_Enter);
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
            // btnFinanceiro
            // 
            this.btnFinanceiro.BackColor = System.Drawing.Color.Transparent;
            this.btnFinanceiro.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_gnd_120x110;
            this.btnFinanceiro.FlatAppearance.BorderSize = 0;
            this.btnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanceiro.Location = new System.Drawing.Point(674, 15);
            this.btnFinanceiro.Margin = new System.Windows.Forms.Padding(0);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(120, 110);
            this.btnFinanceiro.TabIndex = 14;
            this.btnFinanceiro.UseVisualStyleBackColor = false;
            this.btnFinanceiro.Click += new System.EventHandler(this.btnFinanceiro_Click);
            this.btnFinanceiro.Leave += new System.EventHandler(this.btnFinanceiro_Leave);
            this.btnFinanceiro.Enter += new System.EventHandler(this.btnFinanceiro_Enter);
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarFuncionario.BackgroundImage = global::GuiWindowsForms.Properties.Resources.btn_ok_cadastrar_145x52;
            this.btnCadastrarFuncionario.FlatAppearance.BorderSize = 0;
            this.btnCadastrarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(31, 667);
            this.btnCadastrarFuncionario.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(145, 52);
            this.btnCadastrarFuncionario.TabIndex = 16;
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = false;
            this.btnCadastrarFuncionario.Visible = false;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
            // 
            // dgvAluno
            // 
            this.dgvAluno.AllowUserToAddRows = false;
            this.dgvAluno.AllowUserToDeleteRows = false;
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaNomeAluno,
            this.TelefoneAluno,
            this.SerieAluno,
            this.ValorMatricula});
            this.dgvAluno.Location = new System.Drawing.Point(163, 365);
            this.dgvAluno.MultiSelect = false;
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.ReadOnly = true;
            this.dgvAluno.Size = new System.Drawing.Size(648, 266);
            this.dgvAluno.TabIndex = 17;
            this.dgvAluno.DoubleClick += new System.EventHandler(this.dgvAluno_DoubleClick);
            this.dgvAluno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAluno_CellClick);
            this.dgvAluno.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAluno_CellEnter);
            // 
            // colunaNomeAluno
            // 
            this.colunaNomeAluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colunaNomeAluno.DataPropertyName = "NomeAluno";
            this.colunaNomeAluno.HeaderText = "Nome do Aluno";
            this.colunaNomeAluno.MaxInputLength = 40;
            this.colunaNomeAluno.Name = "colunaNomeAluno";
            this.colunaNomeAluno.ReadOnly = true;
            this.colunaNomeAluno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colunaNomeAluno.Width = 233;
            // 
            // TelefoneAluno
            // 
            this.TelefoneAluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TelefoneAluno.DataPropertyName = "TelefoneAluno";
            this.TelefoneAluno.HeaderText = "Telefone do Aluno";
            this.TelefoneAluno.MaxInputLength = 15;
            this.TelefoneAluno.Name = "TelefoneAluno";
            this.TelefoneAluno.ReadOnly = true;
            this.TelefoneAluno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TelefoneAluno.Width = 130;
            // 
            // SerieAluno
            // 
            this.SerieAluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SerieAluno.DataPropertyName = "SerieAluno";
            this.SerieAluno.HeaderText = "Ano do Aluno";
            this.SerieAluno.MaxInputLength = 20;
            this.SerieAluno.Name = "SerieAluno";
            this.SerieAluno.ReadOnly = true;
            this.SerieAluno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SerieAluno.Width = 116;
            // 
            // ValorMatricula
            // 
            this.ValorMatricula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ValorMatricula.DataPropertyName = "Valor";
            this.ValorMatricula.HeaderText = "Valor da Matrícula";
            this.ValorMatricula.MaxInputLength = 10;
            this.ValorMatricula.Name = "ValorMatricula";
            this.ValorMatricula.ReadOnly = true;
            this.ValorMatricula.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ValorMatricula.Width = 126;
            // 
            // Column3
            // 
            this.Column3.Name = "Column3";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_menos;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(779, 348);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(32, 11);
            this.btnExcluir.TabIndex = 70;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // telaAlunoPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GuiWindowsForms.Properties.Resources.modelo_tela_iconemenor1;
            this.ClientSize = new System.Drawing.Size(1000, 722);
            this.Controls.Add(this.btnExcluir);
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
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnCadastrarAluno);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.btnAluno);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.lblHelloUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaAlunoPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            this.Load += new System.EventHandler(this.telaAlunoPrincipal_Load);
            this.Activated += new System.EventHandler(this.telaAlunoPrincipal_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaAlunoPrincipal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloUsuario;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnDesconectar;
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
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefoneAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerieAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorMatricula;
    }
}