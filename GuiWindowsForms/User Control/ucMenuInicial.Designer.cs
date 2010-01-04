namespace GuiWindowsForms.User_Control
{
    partial class ucMenuInicial
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFinanceiro = new System.Windows.Forms.Label();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.lblConfOculto = new System.Windows.Forms.Label();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.lblFuncOculto = new System.Windows.Forms.Label();
            this.lblAlunoOculto = new System.Windows.Forms.Label();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnAluno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFinanceiro
            // 
            this.lblFinanceiro.AutoSize = true;
            this.lblFinanceiro.BackColor = System.Drawing.Color.Transparent;
            this.lblFinanceiro.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblFinanceiro.ForeColor = System.Drawing.Color.Yellow;
            this.lblFinanceiro.Location = new System.Drawing.Point(485, 150);
            this.lblFinanceiro.Name = "lblFinanceiro";
            this.lblFinanceiro.Size = new System.Drawing.Size(104, 23);
            this.lblFinanceiro.TabIndex = 23;
            this.lblFinanceiro.Text = "Financeiro";
            this.lblFinanceiro.Visible = false;
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.BackColor = System.Drawing.Color.Transparent;
            this.btnFinanceiro.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_gnd_120x110;
            this.btnFinanceiro.FlatAppearance.BorderSize = 0;
            this.btnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanceiro.Location = new System.Drawing.Point(469, 43);
            this.btnFinanceiro.Margin = new System.Windows.Forms.Padding(0);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(120, 110);
            this.btnFinanceiro.TabIndex = 22;
            this.btnFinanceiro.UseVisualStyleBackColor = false;
            this.btnFinanceiro.Click += new System.EventHandler(this.btnFinanceiro_Click);
            this.btnFinanceiro.Leave += new System.EventHandler(this.btnFinanceiro_Leave);
            this.btnFinanceiro.Enter += new System.EventHandler(this.btnFinanceiro_Enter);
            // 
            // lblConfOculto
            // 
            this.lblConfOculto.AutoSize = true;
            this.lblConfOculto.BackColor = System.Drawing.Color.Transparent;
            this.lblConfOculto.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblConfOculto.ForeColor = System.Drawing.Color.Yellow;
            this.lblConfOculto.Location = new System.Drawing.Point(327, 147);
            this.lblConfOculto.Name = "lblConfOculto";
            this.lblConfOculto.Size = new System.Drawing.Size(138, 23);
            this.lblConfOculto.TabIndex = 21;
            this.lblConfOculto.Text = "Configurações";
            this.lblConfOculto.Visible = false;
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracoes.BackgroundImage = global::GuiWindowsForms.Properties.Resources.configuracoes_137x101;
            this.btnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.btnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracoes.Location = new System.Drawing.Point(321, 40);
            this.btnConfiguracoes.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(137, 101);
            this.btnConfiguracoes.TabIndex = 20;
            this.btnConfiguracoes.UseVisualStyleBackColor = false;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            this.btnConfiguracoes.Enter += new System.EventHandler(this.btnConfiguracoes_Enter);
            // 
            // lblFuncOculto
            // 
            this.lblFuncOculto.AutoSize = true;
            this.lblFuncOculto.BackColor = System.Drawing.Color.Transparent;
            this.lblFuncOculto.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblFuncOculto.ForeColor = System.Drawing.Color.Yellow;
            this.lblFuncOculto.Location = new System.Drawing.Point(181, 147);
            this.lblFuncOculto.Name = "lblFuncOculto";
            this.lblFuncOculto.Size = new System.Drawing.Size(125, 23);
            this.lblFuncOculto.TabIndex = 19;
            this.lblFuncOculto.Text = "Funcionários";
            this.lblFuncOculto.Visible = false;
            // 
            // lblAlunoOculto
            // 
            this.lblAlunoOculto.AutoSize = true;
            this.lblAlunoOculto.BackColor = System.Drawing.Color.Transparent;
            this.lblAlunoOculto.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblAlunoOculto.ForeColor = System.Drawing.Color.Yellow;
            this.lblAlunoOculto.Location = new System.Drawing.Point(70, 147);
            this.lblAlunoOculto.Name = "lblAlunoOculto";
            this.lblAlunoOculto.Size = new System.Drawing.Size(70, 23);
            this.lblAlunoOculto.TabIndex = 18;
            this.lblAlunoOculto.Text = "Alunos";
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.btnFuncionario.BackgroundImage = global::GuiWindowsForms.Properties.Resources.icone_prof_142x113;
            this.btnFuncionario.FlatAppearance.BorderSize = 0;
            this.btnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionario.Location = new System.Drawing.Point(160, 37);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(142, 113);
            this.btnFuncionario.TabIndex = 17;
            this.btnFuncionario.UseVisualStyleBackColor = false;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            this.btnFuncionario.Leave += new System.EventHandler(this.btnFuncionario_Leave);
            this.btnFuncionario.Enter += new System.EventHandler(this.btnFuncionario_Enter);
            // 
            // btnAluno
            // 
            this.btnAluno.BackColor = System.Drawing.Color.Transparent;
            this.btnAluno.BackgroundImage = global::GuiWindowsForms.Properties.Resources.icone_aluno_142x113;
            this.btnAluno.FlatAppearance.BorderSize = 0;
            this.btnAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAluno.Location = new System.Drawing.Point(35, 37);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(142, 113);
            this.btnAluno.TabIndex = 16;
            this.btnAluno.UseVisualStyleBackColor = false;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            this.btnAluno.Enter += new System.EventHandler(this.btnAluno_Enter);
            // 
            // ucMenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblFinanceiro);
            this.Controls.Add(this.btnFinanceiro);
            this.Controls.Add(this.lblConfOculto);
            this.Controls.Add(this.btnConfiguracoes);
            this.Controls.Add(this.lblFuncOculto);
            this.Controls.Add(this.lblAlunoOculto);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.btnAluno);
            this.Name = "ucMenuInicial";
            this.Size = new System.Drawing.Size(636, 205);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFinanceiro;
        private System.Windows.Forms.Button btnFinanceiro;
        private System.Windows.Forms.Label lblConfOculto;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.Label lblFuncOculto;
        private System.Windows.Forms.Label lblAlunoOculto;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnAluno;
    }
}
