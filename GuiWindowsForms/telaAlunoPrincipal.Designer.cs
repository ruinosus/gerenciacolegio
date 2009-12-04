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
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAluno = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.lblDesconectar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHelloUsuario
            // 
            this.lblHelloUsuario.AutoSize = true;
            this.lblHelloUsuario.Location = new System.Drawing.Point(802, 9);
            this.lblHelloUsuario.Name = "lblHelloUsuario";
            this.lblHelloUsuario.Size = new System.Drawing.Size(87, 13);
            this.lblHelloUsuario.TabIndex = 1;
            this.lblHelloUsuario.Text = "Hello Usuário!";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtLogin.Location = new System.Drawing.Point(326, 248);
            this.txtLogin.MaxLength = 60;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(433, 26);
            this.txtLogin.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(786, 248);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(112, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnAluno
            // 
            this.btnAluno.BackColor = System.Drawing.Color.Green;
            this.btnAluno.Location = new System.Drawing.Point(418, 70);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(87, 23);
            this.btnAluno.TabIndex = 4;
            this.btnAluno.Text = "ALUNO";
            this.btnAluno.UseVisualStyleBackColor = false;
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Location = new System.Drawing.Point(582, 70);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(87, 23);
            this.btnFuncionario.TabIndex = 5;
            this.btnFuncionario.Text = "Funcionário";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.Location = new System.Drawing.Point(326, 677);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(112, 23);
            this.btnCadastrarAluno.TabIndex = 6;
            this.btnCadastrarAluno.Text = "Cadastrar";
            this.btnCadastrarAluno.UseVisualStyleBackColor = true;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // lblDesconectar
            // 
            this.lblDesconectar.AutoSize = true;
            this.lblDesconectar.Location = new System.Drawing.Point(909, 9);
            this.lblDesconectar.Name = "lblDesconectar";
            this.lblDesconectar.Size = new System.Drawing.Size(79, 13);
            this.lblDesconectar.TabIndex = 7;
            this.lblDesconectar.Text = "Desconectar";
            // 
            // telaAlunoPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GuiWindowsForms.Properties.Resources.modelo_tela_iconemenor1;
            this.ClientSize = new System.Drawing.Size(1000, 722);
            this.Controls.Add(this.lblDesconectar);
            this.Controls.Add(this.btnCadastrarAluno);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.btnAluno);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblHelloUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaAlunoPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloUsuario;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.Label lblDesconectar;
    }
}