namespace GuiWindowsForms.User_Control
{
    partial class ucMenuDireita
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
            this.lblDesconto_menu = new System.Windows.Forms.Label();
            this.lblAtividade_menu = new System.Windows.Forms.Label();
            this.lblSerie_menu = new System.Windows.Forms.Label();
            this.btnDesconto = new System.Windows.Forms.Button();
            this.btnAtividade = new System.Windows.Forms.Button();
            this.btnSerie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDesconto_menu
            // 
            this.lblDesconto_menu.AutoSize = true;
            this.lblDesconto_menu.BackColor = System.Drawing.Color.Transparent;
            this.lblDesconto_menu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblDesconto_menu.ForeColor = System.Drawing.Color.White;
            this.lblDesconto_menu.Location = new System.Drawing.Point(22, 289);
            this.lblDesconto_menu.Name = "lblDesconto_menu";
            this.lblDesconto_menu.Size = new System.Drawing.Size(76, 17);
            this.lblDesconto_menu.TabIndex = 99;
            this.lblDesconto_menu.Text = "Descontos";
            this.lblDesconto_menu.Visible = false;
            // 
            // lblAtividade_menu
            // 
            this.lblAtividade_menu.AutoSize = true;
            this.lblAtividade_menu.BackColor = System.Drawing.Color.Transparent;
            this.lblAtividade_menu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblAtividade_menu.ForeColor = System.Drawing.Color.White;
            this.lblAtividade_menu.Location = new System.Drawing.Point(18, 187);
            this.lblAtividade_menu.Name = "lblAtividade_menu";
            this.lblAtividade_menu.Size = new System.Drawing.Size(76, 17);
            this.lblAtividade_menu.TabIndex = 98;
            this.lblAtividade_menu.Text = "Atividades";
            this.lblAtividade_menu.Visible = false;
            // 
            // lblSerie_menu
            // 
            this.lblSerie_menu.AutoSize = true;
            this.lblSerie_menu.BackColor = System.Drawing.Color.Transparent;
            this.lblSerie_menu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblSerie_menu.ForeColor = System.Drawing.Color.White;
            this.lblSerie_menu.Location = new System.Drawing.Point(34, 92);
            this.lblSerie_menu.Name = "lblSerie_menu";
            this.lblSerie_menu.Size = new System.Drawing.Size(49, 17);
            this.lblSerie_menu.TabIndex = 97;
            this.lblSerie_menu.Text = "Séries";
            this.lblSerie_menu.Visible = false;
            // 
            // btnDesconto
            // 
            this.btnDesconto.BackColor = System.Drawing.Color.Transparent;
            this.btnDesconto.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_desconto_79x80_disabled;
            this.btnDesconto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesconto.FlatAppearance.BorderSize = 0;
            this.btnDesconto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconto.Location = new System.Drawing.Point(22, 213);
            this.btnDesconto.Margin = new System.Windows.Forms.Padding(0);
            this.btnDesconto.Name = "btnDesconto";
            this.btnDesconto.Size = new System.Drawing.Size(79, 80);
            this.btnDesconto.TabIndex = 96;
            this.btnDesconto.UseVisualStyleBackColor = false;
            this.btnDesconto.MouseLeave += new System.EventHandler(this.btnDesconto_MouseLeave);
            this.btnDesconto.Click += new System.EventHandler(this.btnDesconto_Click);
            this.btnDesconto.MouseEnter += new System.EventHandler(this.btnDesconto_MouseEnter);
            // 
            // btnAtividade
            // 
            this.btnAtividade.BackColor = System.Drawing.Color.Transparent;
            this.btnAtividade.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_atividades_84x75_disabled;
            this.btnAtividade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtividade.FlatAppearance.BorderSize = 0;
            this.btnAtividade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtividade.Location = new System.Drawing.Point(14, 113);
            this.btnAtividade.Margin = new System.Windows.Forms.Padding(0);
            this.btnAtividade.Name = "btnAtividade";
            this.btnAtividade.Size = new System.Drawing.Size(84, 75);
            this.btnAtividade.TabIndex = 95;
            this.btnAtividade.UseVisualStyleBackColor = false;
            this.btnAtividade.MouseLeave += new System.EventHandler(this.btnAtividade_MouseLeave);
            this.btnAtividade.Click += new System.EventHandler(this.btnAtividade_Click);
            this.btnAtividade.MouseEnter += new System.EventHandler(this.btnAtividade_MouseEnter);
            // 
            // btnSerie
            // 
            this.btnSerie.BackColor = System.Drawing.Color.Transparent;
            this.btnSerie.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_serie_64x70_disabled;
            this.btnSerie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSerie.FlatAppearance.BorderSize = 0;
            this.btnSerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerie.Location = new System.Drawing.Point(27, 13);
            this.btnSerie.Margin = new System.Windows.Forms.Padding(0);
            this.btnSerie.Name = "btnSerie";
            this.btnSerie.Size = new System.Drawing.Size(60, 74);
            this.btnSerie.TabIndex = 94;
            this.btnSerie.UseVisualStyleBackColor = false;
            this.btnSerie.MouseLeave += new System.EventHandler(this.btnSerie_MouseLeave);
            this.btnSerie.Click += new System.EventHandler(this.btnSerie_Click);
            this.btnSerie.MouseEnter += new System.EventHandler(this.btnSerie_MouseEnter);
            // 
            // ucMenuDireita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblDesconto_menu);
            this.Controls.Add(this.lblAtividade_menu);
            this.Controls.Add(this.lblSerie_menu);
            this.Controls.Add(this.btnDesconto);
            this.Controls.Add(this.btnAtividade);
            this.Controls.Add(this.btnSerie);
            this.Name = "ucMenuDireita";
            this.Size = new System.Drawing.Size(120, 493);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesconto_menu;
        private System.Windows.Forms.Label lblAtividade_menu;
        private System.Windows.Forms.Label lblSerie_menu;
        private System.Windows.Forms.Button btnDesconto;
        private System.Windows.Forms.Button btnAtividade;
        private System.Windows.Forms.Button btnSerie;
    }
}
