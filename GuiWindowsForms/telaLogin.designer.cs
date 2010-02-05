namespace GuiWindowsForms
{
    partial class telaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaLogin));
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblErro = new System.Windows.Forms.Label();
            this.errorProviderTela = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTela)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.SystemColors.Window;
            this.txtLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtLogin.Location = new System.Drawing.Point(118, 21);
            this.txtLogin.MaxLength = 30;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(229, 26);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged_1);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtSenha.Location = new System.Drawing.Point(118, 67);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(229, 26);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // btnLogar
            // 
            this.btnLogar.AutoEllipsis = true;
            this.btnLogar.BackColor = System.Drawing.Color.Transparent;
            this.btnLogar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.webdev_ok_76x761;
            this.btnLogar.FlatAppearance.BorderSize = 0;
            this.btnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogar.Location = new System.Drawing.Point(374, 17);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(76, 76);
            this.btnLogar.TabIndex = 2;
            this.btnLogar.UseVisualStyleBackColor = false;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            this.btnLogar.Enter += new System.EventHandler(this.btnLogar_Enter);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.Controls.Add(this.lblErro);
            this.pnlLogin.Controls.Add(this.btnLogar);
            this.pnlLogin.Controls.Add(this.txtSenha);
            this.pnlLogin.Controls.Add(this.txtLogin);
            this.pnlLogin.Location = new System.Drawing.Point(243, 379);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(745, 168);
            this.pnlLogin.TabIndex = 3;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.Yellow;
            this.lblErro.Location = new System.Drawing.Point(11, 115);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(133, 19);
            this.lblErro.TabIndex = 3;
            this.lblErro.Text = "Senha Incorreta!";
            this.lblErro.Visible = false;
            // 
            // errorProviderTela
            // 
            this.errorProviderTela.ContainerControl = this;
            // 
            // telaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(990, 690);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaLogin_FormClosing);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.ErrorProvider errorProviderTela;
    }
}

