namespace GuiWindowsForms
{
    partial class telaConfiguracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaConfiguracoes));
            this.lblInfoControles = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.ucMenuDireita1 = new GuiWindowsForms.User_Control.ucMenuDireita();
            this.ucMenuConfiguracoesEsquerda1 = new GuiWindowsForms.User_Control.ucMenuConfiguracoesEsquerda();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucDesconectarLogin1 = new GuiWindowsForms.User_Control.ucDesconectarLogin();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfoControles
            // 
            this.lblInfoControles.AutoSize = true;
            this.lblInfoControles.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoControles.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblInfoControles.ForeColor = System.Drawing.Color.Yellow;
            this.lblInfoControles.Location = new System.Drawing.Point(141, 685);
            this.lblInfoControles.Name = "lblInfoControles";
            this.lblInfoControles.Size = new System.Drawing.Size(14, 19);
            this.lblInfoControles.TabIndex = 89;
            this.lblInfoControles.Text = "-";
            this.lblInfoControles.Visible = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.voltar_final_32x32;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(31, 637);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(33, 34);
            this.btnVoltar.TabIndex = 87;
            this.btnVoltar.Tag = "";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.MouseLeave += new System.EventHandler(this.btnVoltar_MouseLeave);
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            this.btnVoltar.MouseEnter += new System.EventHandler(this.btnVoltar_MouseEnter);
            // 
            // ucMenuDireita1
            // 
            this.ucMenuDireita1.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuDireita1.Location = new System.Drawing.Point(880, 175);
            this.ucMenuDireita1.Name = "ucMenuDireita1";
            this.ucMenuDireita1.Size = new System.Drawing.Size(120, 493);
            this.ucMenuDireita1.TabIndex = 94;
            this.ucMenuDireita1.EventoAbrirAtividade += new GuiWindowsForms.User_Control.ucMenuDireita.delegateAbrirTelaAtividade(this.ucMenuDireita1_EventoAbrirAtividade);
            this.ucMenuDireita1.EventoAbrirDesconto += new GuiWindowsForms.User_Control.ucMenuDireita.delegateAbrirTelaDesconto(this.ucMenuDireita1_EventoAbrirDesconto);
            this.ucMenuDireita1.EventoAbrirSerie += new GuiWindowsForms.User_Control.ucMenuDireita.delegateAbrirTelaSerie(this.ucMenuDireita1_EventoAbrirSerie);
            // 
            // ucMenuConfiguracoesEsquerda1
            // 
            this.ucMenuConfiguracoesEsquerda1.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuConfiguracoesEsquerda1.Location = new System.Drawing.Point(0, 177);
            this.ucMenuConfiguracoesEsquerda1.Name = "ucMenuConfiguracoesEsquerda1";
            this.ucMenuConfiguracoesEsquerda1.Size = new System.Drawing.Size(120, 432);
            this.ucMenuConfiguracoesEsquerda1.TabIndex = 95;
            this.ucMenuConfiguracoesEsquerda1.Load += new System.EventHandler(this.ucMenuConfiguracoesEsquerda1_Load);
            this.ucMenuConfiguracoesEsquerda1.EventoAbrirControleDeAcesso += new GuiWindowsForms.User_Control.ucMenuConfiguracoesEsquerda.delegateAbrirTelaControleDeAcesso(this.ucMenuConfiguracoesEsquerda1_EventoAbrirControleDeAcesso);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GuiWindowsForms.Properties.Resources.simbolo_colegio;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 112);
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // ucDesconectarLogin1
            // 
            this.ucDesconectarLogin1.BackColor = System.Drawing.Color.Transparent;
            this.ucDesconectarLogin1.Location = new System.Drawing.Point(738, 0);
            this.ucDesconectarLogin1.Name = "ucDesconectarLogin1";
            this.ucDesconectarLogin1.Size = new System.Drawing.Size(253, 39);
            this.ucDesconectarLogin1.TabIndex = 97;
            this.ucDesconectarLogin1.EventoDesconectar += new GuiWindowsForms.User_Control.ucDesconectarLogin.delegateDesconectar(this.ucDesconectarLogin1_EventoDesconectar);
            // 
            // telaConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(179)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(990, 680);
            this.Controls.Add(this.ucDesconectarLogin1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblInfoControles);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.ucMenuDireita1);
            this.Controls.Add(this.ucMenuConfiguracoesEsquerda1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaConfiguracoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            this.Activated += new System.EventHandler(this.telaConfiguracoes_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaConfiguracoes_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfoControles;
        private System.Windows.Forms.Button btnVoltar;
        private GuiWindowsForms.User_Control.ucMenuDireita ucMenuDireita1;
        private GuiWindowsForms.User_Control.ucMenuConfiguracoesEsquerda ucMenuConfiguracoesEsquerda1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private GuiWindowsForms.User_Control.ucDesconectarLogin ucDesconectarLogin1;
    }
}