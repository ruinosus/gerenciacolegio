namespace GuiWindowsForms
{
    partial class telaAlunoAcademico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaAlunoAcademico));
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.lblHelloUsuario = new System.Windows.Forms.Label();
            this.gpbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.uMenuImagem1 = new GuiWindowsForms.uMenuImagem();
            this.ucMenuInferior1 = new GuiWindowsForms.ucMenuInferior();
            this.uMenuLateral1 = new GuiWindowsForms.User_Control.uMenuLateral();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btnDesconectar.TabIndex = 49;
            this.btnDesconectar.Tag = "";
            this.btnDesconectar.UseVisualStyleBackColor = false;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // lblHelloUsuario
            // 
            this.lblHelloUsuario.AutoSize = true;
            this.lblHelloUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblHelloUsuario.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblHelloUsuario.ForeColor = System.Drawing.Color.Yellow;
            this.lblHelloUsuario.Location = new System.Drawing.Point(780, 9);
            this.lblHelloUsuario.Name = "lblHelloUsuario";
            this.lblHelloUsuario.Size = new System.Drawing.Size(133, 23);
            this.lblHelloUsuario.TabIndex = 48;
            this.lblHelloUsuario.Text = "Hello Usuário!";
            // 
            // gpbDadosPessoais
            // 
            this.gpbDadosPessoais.BackColor = System.Drawing.Color.Transparent;
            this.gpbDadosPessoais.Controls.Add(this.btnImprimir);
            this.gpbDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosPessoais.Location = new System.Drawing.Point(33, 191);
            this.gpbDadosPessoais.Name = "gpbDadosPessoais";
            this.gpbDadosPessoais.Size = new System.Drawing.Size(820, 439);
            this.gpbDadosPessoais.TabIndex = 68;
            this.gpbDadosPessoais.TabStop = false;
            this.gpbDadosPessoais.Text = "DADOS ACADÊMICOS DO ALUNO";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = global::GuiWindowsForms.Properties.Resources.btn_imprimir_48x48;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Location = new System.Drawing.Point(751, 375);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(49, 50);
            this.btnImprimir.TabIndex = 87;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // uMenuImagem1
            // 
            this.uMenuImagem1.BackColor = System.Drawing.Color.Transparent;
            this.uMenuImagem1.Location = new System.Drawing.Point(244, 0);
            this.uMenuImagem1.Name = "uMenuImagem1";
            this.uMenuImagem1.Size = new System.Drawing.Size(375, 201);
            this.uMenuImagem1.TabIndex = 69;
            // 
            // ucMenuInferior1
            // 
            this.ucMenuInferior1.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuInferior1.Location = new System.Drawing.Point(39, 637);
            this.ucMenuInferior1.Name = "ucMenuInferior1";
            this.ucMenuInferior1.Size = new System.Drawing.Size(346, 43);
            this.ucMenuInferior1.TabIndex = 70;
            this.ucMenuInferior1.EventoVoltar += new GuiWindowsForms.ucMenuInferior.delegateVoltar(this.ucAluno1_EventoVoltar);
            // 
            // uMenuLateral1
            // 
            this.uMenuLateral1.BackColor = System.Drawing.Color.Transparent;
            this.uMenuLateral1.Location = new System.Drawing.Point(875, 75);
            this.uMenuLateral1.Name = "uMenuLateral1";
            this.uMenuLateral1.Size = new System.Drawing.Size(130, 584);
            this.uMenuLateral1.TabIndex = 71;
            this.uMenuLateral1.EventoAbrirTelaMedica += new GuiWindowsForms.User_Control.uMenuLateral.delegateAbrirTelaMedica(this.uMenuLateral1_EventoAbrirTelaMedica);
            this.uMenuLateral1.Load += new System.EventHandler(this.uMenuLateral1_Load);
            this.uMenuLateral1.EventoAbrirTelaResponsavel += new GuiWindowsForms.User_Control.uMenuLateral.delegateAbrirTelaResponsavel(this.uMenuLateral1_EventoAbrirTelaResponsavel);
            this.uMenuLateral1.EventoAbrirTelaMatricula += new GuiWindowsForms.User_Control.uMenuLateral.delegateAbrirTelaMatricula(this.uMenuLateral1_EventoAbrirTelaMatricula);
            this.uMenuLateral1.EventoAbrirTelaFinanceiro += new GuiWindowsForms.User_Control.uMenuLateral.delegateAbrirTelaFinanceiro(this.uMenuLateral1_EventoAbrirTelaFinanceiro);
            this.uMenuLateral1.EventoAbrirTelaAcademico += new GuiWindowsForms.User_Control.uMenuLateral.delegateAbrirTelaAcademico(this.uMenuLateral1_EventoAbrirTelaAcademico);
            this.uMenuLateral1.EventoAbrirTelaDados += new GuiWindowsForms.User_Control.uMenuLateral.delegateAbrirTelaDados(this.uMenuLateral1_EventoAbrirTelaDados);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GuiWindowsForms.Properties.Resources.simbolo_colegio;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 112);
            this.pictureBox1.TabIndex = 137;
            this.pictureBox1.TabStop = false;
            // 
            // telaAlunoAcademico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(179)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(990, 680);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uMenuLateral1);
            this.Controls.Add(this.gpbDadosPessoais);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.lblHelloUsuario);
            this.Controls.Add(this.uMenuImagem1);
            this.Controls.Add(this.ucMenuInferior1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaAlunoAcademico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            this.Load += new System.EventHandler(this.telaAlunoAcademico_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaAlunoAcademico_FormClosing);
            this.gpbDadosPessoais.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Label lblHelloUsuario;
        private System.Windows.Forms.GroupBox gpbDadosPessoais;
        private System.Windows.Forms.Button btnImprimir;
        private uMenuImagem uMenuImagem1;
        private ucMenuInferior ucMenuInferior1;
        private GuiWindowsForms.User_Control.uMenuLateral uMenuLateral1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}