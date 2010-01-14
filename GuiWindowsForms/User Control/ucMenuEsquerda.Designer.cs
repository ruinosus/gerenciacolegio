namespace GuiWindowsForms.User_Control
{
    partial class ucMenuConfiguracoesEsquerda
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
            this.lblControleAcesso_menu = new System.Windows.Forms.Label();
            this.btnControledeAcesso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblControleAcesso_menu
            // 
            this.lblControleAcesso_menu.AutoSize = true;
            this.lblControleAcesso_menu.BackColor = System.Drawing.Color.Transparent;
            this.lblControleAcesso_menu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblControleAcesso_menu.ForeColor = System.Drawing.Color.White;
            this.lblControleAcesso_menu.Location = new System.Drawing.Point(23, 92);
            this.lblControleAcesso_menu.Name = "lblControleAcesso_menu";
            this.lblControleAcesso_menu.Size = new System.Drawing.Size(46, 17);
            this.lblControleAcesso_menu.TabIndex = 92;
            this.lblControleAcesso_menu.Text = "Perfis";
            this.lblControleAcesso_menu.Visible = false;
            // 
            // btnControledeAcesso
            // 
            this.btnControledeAcesso.BackColor = System.Drawing.Color.Transparent;
            this.btnControledeAcesso.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_acesso_64x80;
            this.btnControledeAcesso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControledeAcesso.Enabled = false;
            this.btnControledeAcesso.FlatAppearance.BorderSize = 0;
            this.btnControledeAcesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControledeAcesso.Location = new System.Drawing.Point(16, 13);
            this.btnControledeAcesso.Margin = new System.Windows.Forms.Padding(0);
            this.btnControledeAcesso.Name = "btnControledeAcesso";
            this.btnControledeAcesso.Size = new System.Drawing.Size(64, 80);
            this.btnControledeAcesso.TabIndex = 91;
            this.btnControledeAcesso.UseVisualStyleBackColor = false;
            this.btnControledeAcesso.MouseLeave += new System.EventHandler(this.btnControledeAcesso_MouseLeave);
            this.btnControledeAcesso.Click += new System.EventHandler(this.btnControledeAcesso_Click);
            this.btnControledeAcesso.MouseEnter += new System.EventHandler(this.btnControledeAcesso_MouseEnter);
            // 
            // ucMenuConfiguracoesEsquerda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblControleAcesso_menu);
            this.Controls.Add(this.btnControledeAcesso);
            this.Name = "ucMenuConfiguracoesEsquerda";
            this.Size = new System.Drawing.Size(91, 493);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblControleAcesso_menu;
        private System.Windows.Forms.Button btnControledeAcesso;
    }
}
