namespace GuiWindowsForms
{
    partial class telaAlunoFinanceiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaAlunoFinanceiro));
            this.gpbFinanceiro = new System.Windows.Forms.GroupBox();
            this.tabFinanceiro = new System.Windows.Forms.TabControl();
            this.tabPagamentoMensalidade = new System.Windows.Forms.TabPage();
            this.tabHistoricoMensalidades = new System.Windows.Forms.TabPage();
            this.dtgHistoricoMensalidade = new System.Windows.Forms.DataGridView();
            this.tabPagamentoAtividade = new System.Windows.Forms.TabPage();
            this.tabHistoricoAtividade = new System.Windows.Forms.TabPage();
            this.dtgHistoricoAtividade = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.uMenuLateral1 = new GuiWindowsForms.User_Control.uMenuLateral();
            this.ucMenuInferior1 = new GuiWindowsForms.ucMenuInferior();
            this.uMenuImagem1 = new GuiWindowsForms.uMenuImagem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucDesconectarLogin1 = new GuiWindowsForms.User_Control.ucDesconectarLogin();
            this.gpbFinanceiro.SuspendLayout();
            this.tabFinanceiro.SuspendLayout();
            this.tabHistoricoMensalidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistoricoMensalidade)).BeginInit();
            this.tabHistoricoAtividade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistoricoAtividade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbFinanceiro
            // 
            this.gpbFinanceiro.BackColor = System.Drawing.Color.Transparent;
            this.gpbFinanceiro.Controls.Add(this.tabFinanceiro);
            this.gpbFinanceiro.Controls.Add(this.btnImprimir);
            this.gpbFinanceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbFinanceiro.Location = new System.Drawing.Point(39, 184);
            this.gpbFinanceiro.Name = "gpbFinanceiro";
            this.gpbFinanceiro.Size = new System.Drawing.Size(820, 450);
            this.gpbFinanceiro.TabIndex = 85;
            this.gpbFinanceiro.TabStop = false;
            this.gpbFinanceiro.Text = "FINANCEIRO ALUNO";
            // 
            // tabFinanceiro
            // 
            this.tabFinanceiro.Controls.Add(this.tabPagamentoMensalidade);
            this.tabFinanceiro.Controls.Add(this.tabHistoricoMensalidades);
            this.tabFinanceiro.Controls.Add(this.tabPagamentoAtividade);
            this.tabFinanceiro.Controls.Add(this.tabHistoricoAtividade);
            this.tabFinanceiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabFinanceiro.Location = new System.Drawing.Point(47, 22);
            this.tabFinanceiro.Name = "tabFinanceiro";
            this.tabFinanceiro.SelectedIndex = 0;
            this.tabFinanceiro.Size = new System.Drawing.Size(745, 369);
            this.tabFinanceiro.TabIndex = 87;
            this.tabFinanceiro.Tag = "";
            // 
            // tabPagamentoMensalidade
            // 
            this.tabPagamentoMensalidade.Location = new System.Drawing.Point(4, 22);
            this.tabPagamentoMensalidade.Name = "tabPagamentoMensalidade";
            this.tabPagamentoMensalidade.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagamentoMensalidade.Size = new System.Drawing.Size(737, 343);
            this.tabPagamentoMensalidade.TabIndex = 0;
            this.tabPagamentoMensalidade.Text = "PAGAMENTO MENSALIDADE";
            this.tabPagamentoMensalidade.UseVisualStyleBackColor = true;
            // 
            // tabHistoricoMensalidades
            // 
            this.tabHistoricoMensalidades.Controls.Add(this.dtgHistoricoMensalidade);
            this.tabHistoricoMensalidades.Location = new System.Drawing.Point(4, 22);
            this.tabHistoricoMensalidades.Name = "tabHistoricoMensalidades";
            this.tabHistoricoMensalidades.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistoricoMensalidades.Size = new System.Drawing.Size(737, 343);
            this.tabHistoricoMensalidades.TabIndex = 1;
            this.tabHistoricoMensalidades.Text = "HISTÓRICO MENSALIDADE";
            this.tabHistoricoMensalidades.UseVisualStyleBackColor = true;
            // 
            // dtgHistoricoMensalidade
            // 
            this.dtgHistoricoMensalidade.BackgroundColor = System.Drawing.Color.White;
            this.dtgHistoricoMensalidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHistoricoMensalidade.Location = new System.Drawing.Point(0, 0);
            this.dtgHistoricoMensalidade.Name = "dtgHistoricoMensalidade";
            this.dtgHistoricoMensalidade.Size = new System.Drawing.Size(748, 362);
            this.dtgHistoricoMensalidade.TabIndex = 0;
            // 
            // tabPagamentoAtividade
            // 
            this.tabPagamentoAtividade.Location = new System.Drawing.Point(4, 22);
            this.tabPagamentoAtividade.Name = "tabPagamentoAtividade";
            this.tabPagamentoAtividade.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagamentoAtividade.Size = new System.Drawing.Size(737, 343);
            this.tabPagamentoAtividade.TabIndex = 3;
            this.tabPagamentoAtividade.Text = "PAGAMENTO ATIVIDADE";
            this.tabPagamentoAtividade.UseVisualStyleBackColor = true;
            // 
            // tabHistoricoAtividade
            // 
            this.tabHistoricoAtividade.Controls.Add(this.dtgHistoricoAtividade);
            this.tabHistoricoAtividade.Location = new System.Drawing.Point(4, 22);
            this.tabHistoricoAtividade.Name = "tabHistoricoAtividade";
            this.tabHistoricoAtividade.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistoricoAtividade.Size = new System.Drawing.Size(737, 343);
            this.tabHistoricoAtividade.TabIndex = 2;
            this.tabHistoricoAtividade.Text = "HISTÓRICO ATIVIDADE";
            this.tabHistoricoAtividade.UseVisualStyleBackColor = true;
            // 
            // dtgHistoricoAtividade
            // 
            this.dtgHistoricoAtividade.BackgroundColor = System.Drawing.Color.White;
            this.dtgHistoricoAtividade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHistoricoAtividade.Location = new System.Drawing.Point(-6, 0);
            this.dtgHistoricoAtividade.Name = "dtgHistoricoAtividade";
            this.dtgHistoricoAtividade.Size = new System.Drawing.Size(748, 362);
            this.dtgHistoricoAtividade.TabIndex = 1;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = global::GuiWindowsForms.Properties.Resources.btn_imprimir_48x48;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Location = new System.Drawing.Point(743, 396);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(49, 50);
            this.btnImprimir.TabIndex = 86;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.MouseLeave += new System.EventHandler(this.btnImprimir_MouseLeave);
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            this.btnImprimir.MouseEnter += new System.EventHandler(this.btnImprimir_MouseEnter);
            // 
            // uMenuLateral1
            // 
            this.uMenuLateral1.BackColor = System.Drawing.Color.Transparent;
            this.uMenuLateral1.Location = new System.Drawing.Point(875, 75);
            this.uMenuLateral1.Name = "uMenuLateral1";
            this.uMenuLateral1.Size = new System.Drawing.Size(130, 584);
            this.uMenuLateral1.TabIndex = 95;
            this.uMenuLateral1.EventoAbrirTelaMedica += new GuiWindowsForms.User_Control.uMenuLateral.delegateAbrirTelaMedica(this.uMenuLateral1_EventoAbrirTelaMedica);
            this.uMenuLateral1.Load += new System.EventHandler(this.uMenuLateral1_Load);
            this.uMenuLateral1.EventoAbrirTelaResponsavel += new GuiWindowsForms.User_Control.uMenuLateral.delegateAbrirTelaResponsavel(this.uMenuLateral1_EventoAbrirTelaResponsavel);
            this.uMenuLateral1.EventoAbrirTelaMatricula += new GuiWindowsForms.User_Control.uMenuLateral.delegateAbrirTelaMatricula(this.uMenuLateral1_EventoAbrirTelaMatricula);
            this.uMenuLateral1.EventoAbrirTelaFinanceiro += new GuiWindowsForms.User_Control.uMenuLateral.delegateAbrirTelaFinanceiro(this.uMenuLateral1_EventoAbrirTelaFinanceiro);
            this.uMenuLateral1.EventoAbrirTelaAcademico += new GuiWindowsForms.User_Control.uMenuLateral.delegateAbrirTelaAcademico(this.uMenuLateral1_EventoAbrirTelaAcademico);
            this.uMenuLateral1.EventoAbrirTelaDados += new GuiWindowsForms.User_Control.uMenuLateral.delegateAbrirTelaDados(this.uMenuLateral1_EventoAbrirTelaDados);
            // 
            // ucMenuInferior1
            // 
            this.ucMenuInferior1.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuInferior1.Location = new System.Drawing.Point(39, 637);
            this.ucMenuInferior1.Name = "ucMenuInferior1";
            this.ucMenuInferior1.Size = new System.Drawing.Size(404, 43);
            this.ucMenuInferior1.TabIndex = 96;
            this.ucMenuInferior1.EventoVoltar += new GuiWindowsForms.ucMenuInferior.delegateVoltar(this.ucAluno1_EventoVoltar);
            // 
            // uMenuImagem1
            // 
            this.uMenuImagem1.BackColor = System.Drawing.Color.Transparent;
            this.uMenuImagem1.Location = new System.Drawing.Point(244, 0);
            this.uMenuImagem1.Name = "uMenuImagem1";
            this.uMenuImagem1.Size = new System.Drawing.Size(556, 201);
            this.uMenuImagem1.TabIndex = 97;
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
            // ucDesconectarLogin1
            // 
            this.ucDesconectarLogin1.BackColor = System.Drawing.Color.Transparent;
            this.ucDesconectarLogin1.Location = new System.Drawing.Point(738, 0);
            this.ucDesconectarLogin1.Name = "ucDesconectarLogin1";
            this.ucDesconectarLogin1.Size = new System.Drawing.Size(253, 39);
            this.ucDesconectarLogin1.TabIndex = 138;
            this.ucDesconectarLogin1.EventoDesconectar += new GuiWindowsForms.User_Control.ucDesconectarLogin.delegateDesconectar(this.ucDesconectarLogin1_EventoDesconectar);
            // 
            // telaAlunoFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(179)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(990, 680);
            this.Controls.Add(this.ucDesconectarLogin1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ucMenuInferior1);
            this.Controls.Add(this.gpbFinanceiro);
            this.Controls.Add(this.uMenuLateral1);
            this.Controls.Add(this.uMenuImagem1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaAlunoFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            this.Load += new System.EventHandler(this.telaAlunoFinanceiro_Load);
            this.Activated += new System.EventHandler(this.telaAlunoFinanceiro_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaAlunoFinanceiro_FormClosing);
            this.gpbFinanceiro.ResumeLayout(false);
            this.tabFinanceiro.ResumeLayout(false);
            this.tabHistoricoMensalidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistoricoMensalidade)).EndInit();
            this.tabHistoricoAtividade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistoricoAtividade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbFinanceiro;
        private System.Windows.Forms.DataGridView dtgHistoricoMensalidade;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TabControl tabFinanceiro;
        private System.Windows.Forms.TabPage tabPagamentoMensalidade;
        private System.Windows.Forms.TabPage tabHistoricoMensalidades;
        private System.Windows.Forms.TabPage tabHistoricoAtividade;
        private System.Windows.Forms.TabPage tabPagamentoAtividade;
        private System.Windows.Forms.DataGridView dtgHistoricoAtividade;
        private GuiWindowsForms.User_Control.uMenuLateral uMenuLateral1;
        private ucMenuInferior ucMenuInferior1;
        private uMenuImagem uMenuImagem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private GuiWindowsForms.User_Control.ucDesconectarLogin ucDesconectarLogin1;
    }
}