namespace GuiWindowsForms.User_Control
{
    partial class ucMenuLateralFunc
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
            this.lblProfissionais_menu = new System.Windows.Forms.Label();
            this.lblDados_Menu = new System.Windows.Forms.Label();
            this.btnDadosProfissionais = new System.Windows.Forms.Button();
            this.btnDadosPessoais = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProfissionais_menu
            // 
            this.lblProfissionais_menu.AutoSize = true;
            this.lblProfissionais_menu.BackColor = System.Drawing.Color.Transparent;
            this.lblProfissionais_menu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblProfissionais_menu.ForeColor = System.Drawing.Color.White;
            this.lblProfissionais_menu.Location = new System.Drawing.Point(9, 185);
            this.lblProfissionais_menu.Name = "lblProfissionais_menu";
            this.lblProfissionais_menu.Size = new System.Drawing.Size(136, 17);
            this.lblProfissionais_menu.TabIndex = 99;
            this.lblProfissionais_menu.Text = "Dados Profissionais";
            this.lblProfissionais_menu.Visible = false;
            // 
            // lblDados_Menu
            // 
            this.lblDados_Menu.AutoSize = true;
            this.lblDados_Menu.BackColor = System.Drawing.Color.Transparent;
            this.lblDados_Menu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblDados_Menu.ForeColor = System.Drawing.Color.White;
            this.lblDados_Menu.Location = new System.Drawing.Point(24, 78);
            this.lblDados_Menu.Name = "lblDados_Menu";
            this.lblDados_Menu.Size = new System.Drawing.Size(110, 17);
            this.lblDados_Menu.TabIndex = 98;
            this.lblDados_Menu.Text = "Dados Pessoais";
            this.lblDados_Menu.Visible = false;
            // 
            // btnDadosProfissionais
            // 
            this.btnDadosProfissionais.BackColor = System.Drawing.Color.Transparent;
            this.btnDadosProfissionais.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_profissional_64x71_disabled;
            this.btnDadosProfissionais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDadosProfissionais.FlatAppearance.BorderSize = 0;
            this.btnDadosProfissionais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDadosProfissionais.Location = new System.Drawing.Point(41, 105);
            this.btnDadosProfissionais.Margin = new System.Windows.Forms.Padding(0);
            this.btnDadosProfissionais.Name = "btnDadosProfissionais";
            this.btnDadosProfissionais.Size = new System.Drawing.Size(64, 71);
            this.btnDadosProfissionais.TabIndex = 97;
            this.btnDadosProfissionais.Tag = "";
            this.btnDadosProfissionais.UseVisualStyleBackColor = false;
            this.btnDadosProfissionais.MouseLeave += new System.EventHandler(this.btnDadosProfissionais_MouseLeave);
            this.btnDadosProfissionais.Click += new System.EventHandler(this.btnDadosProfissionais_Click);
            this.btnDadosProfissionais.MouseEnter += new System.EventHandler(this.btnDadosProfissionais_MouseEnter);
            // 
            // btnDadosPessoais
            // 
            this.btnDadosPessoais.AccessibleDescription = "";
            this.btnDadosPessoais.BackColor = System.Drawing.Color.Transparent;
            this.btnDadosPessoais.BackgroundImage = global::GuiWindowsForms.Properties.Resources.func_dados_71x62;
            this.btnDadosPessoais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDadosPessoais.FlatAppearance.BorderSize = 0;
            this.btnDadosPessoais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDadosPessoais.Location = new System.Drawing.Point(34, 9);
            this.btnDadosPessoais.Margin = new System.Windows.Forms.Padding(0);
            this.btnDadosPessoais.Name = "btnDadosPessoais";
            this.btnDadosPessoais.Size = new System.Drawing.Size(71, 62);
            this.btnDadosPessoais.TabIndex = 96;
            this.btnDadosPessoais.Tag = "";
            this.btnDadosPessoais.UseVisualStyleBackColor = false;
            this.btnDadosPessoais.MouseLeave += new System.EventHandler(this.btnDadosPessoais_MouseLeave);
            this.btnDadosPessoais.Click += new System.EventHandler(this.btnDadosPessoais_Click);
            this.btnDadosPessoais.MouseEnter += new System.EventHandler(this.btnDadosPessoais_MouseEnter);
            // 
            // ucMenuLateralFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblProfissionais_menu);
            this.Controls.Add(this.lblDados_Menu);
            this.Controls.Add(this.btnDadosProfissionais);
            this.Controls.Add(this.btnDadosPessoais);
            this.Name = "ucMenuLateralFunc";
            this.Size = new System.Drawing.Size(150, 378);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfissionais_menu;
        private System.Windows.Forms.Label lblDados_Menu;
        private System.Windows.Forms.Button btnDadosProfissionais;
        private System.Windows.Forms.Button btnDadosPessoais;
    }
}
