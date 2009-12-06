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
            this.lblHelloUsuario = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnAluno = new System.Windows.Forms.Button();
            this.lblAlunoOculto = new System.Windows.Forms.Label();
            this.lblFuncionarioOculto = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
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
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtLogin.Location = new System.Drawing.Point(285, 248);
            this.txtLogin.MaxLength = 60;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(415, 26);
            this.txtLogin.TabIndex = 2;
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
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.AutoEllipsis = true;
            this.btnFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.btnFuncionario.BackgroundImage = global::GuiWindowsForms.Properties.Resources.icone_prof_142x113;
            this.btnFuncionario.FlatAppearance.BorderSize = 0;
            this.btnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionario.Location = new System.Drawing.Point(424, 9);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(142, 113);
            this.btnFuncionario.TabIndex = 5;
            this.btnFuncionario.UseVisualStyleBackColor = false;
            this.btnFuncionario.MouseLeave += new System.EventHandler(this.btnFuncionario_MouseLeave);
            this.btnFuncionario.MouseEnter += new System.EventHandler(this.btnFuncionario_MouseEnter);
            // 
            // btnAluno
            // 
            this.btnAluno.AutoEllipsis = true;
            this.btnAluno.BackColor = System.Drawing.Color.Transparent;
            this.btnAluno.BackgroundImage = global::GuiWindowsForms.Properties.Resources.icone_aluno_142x113;
            this.btnAluno.FlatAppearance.BorderSize = 0;
            this.btnAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAluno.Location = new System.Drawing.Point(276, 9);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(142, 113);
            this.btnAluno.TabIndex = 6;
            this.btnAluno.UseVisualStyleBackColor = false;
            this.btnAluno.MouseLeave += new System.EventHandler(this.btnAluno_MouseLeave);
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            this.btnAluno.MouseEnter += new System.EventHandler(this.btnAluno_MouseEnter);
            // 
            // lblAlunoOculto
            // 
            this.lblAlunoOculto.AutoSize = true;
            this.lblAlunoOculto.BackColor = System.Drawing.Color.Transparent;
            this.lblAlunoOculto.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblAlunoOculto.ForeColor = System.Drawing.Color.Yellow;
            this.lblAlunoOculto.Location = new System.Drawing.Point(308, 116);
            this.lblAlunoOculto.Name = "lblAlunoOculto";
            this.lblAlunoOculto.Size = new System.Drawing.Size(70, 23);
            this.lblAlunoOculto.TabIndex = 7;
            this.lblAlunoOculto.Text = "Alunos";
            this.lblAlunoOculto.Visible = false;
            // 
            // lblFuncionarioOculto
            // 
            this.lblFuncionarioOculto.AutoSize = true;
            this.lblFuncionarioOculto.BackColor = System.Drawing.Color.Transparent;
            this.lblFuncionarioOculto.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblFuncionarioOculto.ForeColor = System.Drawing.Color.Yellow;
            this.lblFuncionarioOculto.Location = new System.Drawing.Point(441, 116);
            this.lblFuncionarioOculto.Name = "lblFuncionarioOculto";
            this.lblFuncionarioOculto.Size = new System.Drawing.Size(125, 23);
            this.lblFuncionarioOculto.TabIndex = 8;
            this.lblFuncionarioOculto.Text = "Funcionários";
            this.lblFuncionarioOculto.Visible = false;
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.BackColor = System.Drawing.Color.Transparent;
            this.btnDesconectar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.icone_desconectar;
            this.btnDesconectar.FlatAppearance.BorderSize = 0;
            this.btnDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconectar.Location = new System.Drawing.Point(941, 9);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(30, 30);
            this.btnDesconectar.TabIndex = 9;
            this.btnDesconectar.UseVisualStyleBackColor = false;
            // 
            // telaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GuiWindowsForms.Properties.Resources.modelo_tela_iconemenor1;
            this.ClientSize = new System.Drawing.Size(1000, 722);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.lblFuncionarioOculto);
            this.Controls.Add(this.lblAlunoOculto);
            this.Controls.Add(this.btnAluno);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblHelloUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaPrincipal_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloUsuario;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Label lblAlunoOculto;
        private System.Windows.Forms.Label lblFuncionarioOculto;
        private System.Windows.Forms.Button btnDesconectar;
    }
}