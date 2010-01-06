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
            this.lblHelloUsuario = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.gpbFinanceiro = new System.Windows.Forms.GroupBox();
            this.tabFinanceiro = new System.Windows.Forms.TabControl();
            this.tabPagamentoMensalidade = new System.Windows.Forms.TabPage();
            this.tabHistoricoMensalidades = new System.Windows.Forms.TabPage();
            this.dtgHistoricoMensalidade = new System.Windows.Forms.DataGridView();
            this.tabPagamentoAtividade = new System.Windows.Forms.TabPage();
            this.tabHistoricoAtividade = new System.Windows.Forms.TabPage();
            this.dtgHistoricoAtividade = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblAtivo = new System.Windows.Forms.Label();
            this.lblFoneEmerg = new System.Windows.Forms.Label();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.pctImagem = new System.Windows.Forms.PictureBox();
            this.uMenuLateral1 = new GuiWindowsForms.User_Control.uMenuLateral();
            this.ucMenuInferior1 = new GuiWindowsForms.ucMenuInferior();
            this.gpbFinanceiro.SuspendLayout();
            this.tabFinanceiro.SuspendLayout();
            this.tabHistoricoMensalidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistoricoMensalidade)).BeginInit();
            this.tabHistoricoAtividade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistoricoAtividade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHelloUsuario
            // 
            this.lblHelloUsuario.AutoSize = true;
            this.lblHelloUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblHelloUsuario.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblHelloUsuario.ForeColor = System.Drawing.Color.Yellow;
            this.lblHelloUsuario.Location = new System.Drawing.Point(794, 5);
            this.lblHelloUsuario.Name = "lblHelloUsuario";
            this.lblHelloUsuario.Size = new System.Drawing.Size(133, 23);
            this.lblHelloUsuario.TabIndex = 47;
            this.lblHelloUsuario.Text = "Hello Usuário!";
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.BackColor = System.Drawing.Color.Transparent;
            this.btnDesconectar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.icone_desconectar;
            this.btnDesconectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesconectar.FlatAppearance.BorderSize = 0;
            this.btnDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconectar.Location = new System.Drawing.Point(933, 5);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(30, 30);
            this.btnDesconectar.TabIndex = 48;
            this.btnDesconectar.Tag = "";
            this.btnDesconectar.UseVisualStyleBackColor = false;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // gpbFinanceiro
            // 
            this.gpbFinanceiro.BackColor = System.Drawing.Color.Transparent;
            this.gpbFinanceiro.Controls.Add(this.tabFinanceiro);
            this.gpbFinanceiro.Controls.Add(this.btnImprimir);
            this.gpbFinanceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbFinanceiro.Location = new System.Drawing.Point(39, 191);
            this.gpbFinanceiro.Name = "gpbFinanceiro";
            this.gpbFinanceiro.Size = new System.Drawing.Size(820, 475);
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
            this.tabFinanceiro.Location = new System.Drawing.Point(47, 35);
            this.tabFinanceiro.Name = "tabFinanceiro";
            this.tabFinanceiro.SelectedIndex = 0;
            this.tabFinanceiro.Size = new System.Drawing.Size(745, 384);
            this.tabFinanceiro.TabIndex = 87;
            this.tabFinanceiro.Tag = "";
            // 
            // tabPagamentoMensalidade
            // 
            this.tabPagamentoMensalidade.Location = new System.Drawing.Point(4, 22);
            this.tabPagamentoMensalidade.Name = "tabPagamentoMensalidade";
            this.tabPagamentoMensalidade.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagamentoMensalidade.Size = new System.Drawing.Size(737, 358);
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
            this.tabHistoricoMensalidades.Size = new System.Drawing.Size(737, 358);
            this.tabHistoricoMensalidades.TabIndex = 1;
            this.tabHistoricoMensalidades.Text = "HISTÓRICO MENSALIDADE";
            this.tabHistoricoMensalidades.UseVisualStyleBackColor = true;
            // 
            // dtgHistoricoMensalidade
            // 
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
            this.tabPagamentoAtividade.Size = new System.Drawing.Size(737, 358);
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
            this.tabHistoricoAtividade.Size = new System.Drawing.Size(737, 358);
            this.tabHistoricoAtividade.TabIndex = 2;
            this.tabHistoricoAtividade.Text = "HISTÓRICO ATIVIDADE";
            this.tabHistoricoAtividade.UseVisualStyleBackColor = true;
            // 
            // dtgHistoricoAtividade
            // 
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
            this.btnImprimir.Location = new System.Drawing.Point(743, 422);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(49, 50);
            this.btnImprimir.TabIndex = 86;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.MouseLeave += new System.EventHandler(this.btnImprimir_MouseLeave);
            this.btnImprimir.MouseEnter += new System.EventHandler(this.btnImprimir_MouseEnter);
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.BackColor = System.Drawing.Color.Transparent;
            this.lblAtivo.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblAtivo.ForeColor = System.Drawing.Color.Green;
            this.lblAtivo.Location = new System.Drawing.Point(394, 166);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(49, 19);
            this.lblAtivo.TabIndex = 94;
            this.lblAtivo.Text = "Ativo";
            // 
            // lblFoneEmerg
            // 
            this.lblFoneEmerg.AutoSize = true;
            this.lblFoneEmerg.BackColor = System.Drawing.Color.Transparent;
            this.lblFoneEmerg.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblFoneEmerg.ForeColor = System.Drawing.Color.Yellow;
            this.lblFoneEmerg.Location = new System.Drawing.Point(394, 133);
            this.lblFoneEmerg.Name = "lblFoneEmerg";
            this.lblFoneEmerg.Size = new System.Drawing.Size(98, 19);
            this.lblFoneEmerg.TabIndex = 93;
            this.lblFoneEmerg.Text = "Fone Emerg";
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.BackColor = System.Drawing.Color.Transparent;
            this.lblResponsavel.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblResponsavel.ForeColor = System.Drawing.Color.Yellow;
            this.lblResponsavel.Location = new System.Drawing.Point(394, 104);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(155, 19);
            this.lblResponsavel.TabIndex = 92;
            this.lblResponsavel.Text = "Nome Responsável";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.BackColor = System.Drawing.Color.Transparent;
            this.lblSerie.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblSerie.ForeColor = System.Drawing.Color.Yellow;
            this.lblSerie.Location = new System.Drawing.Point(394, 74);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(48, 19);
            this.lblSerie.TabIndex = 91;
            this.lblSerie.Text = "Série";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.BackColor = System.Drawing.Color.Transparent;
            this.lblMatricula.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblMatricula.ForeColor = System.Drawing.Color.Yellow;
            this.lblMatricula.Location = new System.Drawing.Point(394, 45);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(80, 19);
            this.lblMatricula.TabIndex = 90;
            this.lblMatricula.Text = "Matricula";
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeAluno.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblNomeAluno.ForeColor = System.Drawing.Color.Yellow;
            this.lblNomeAluno.Location = new System.Drawing.Point(394, 12);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(124, 19);
            this.lblNomeAluno.TabIndex = 89;
            this.lblNomeAluno.Text = "Nome do Aluno";
            // 
            // pctImagem
            // 
            this.pctImagem.BackColor = System.Drawing.Color.Transparent;
            this.pctImagem.Location = new System.Drawing.Point(248, 12);
            this.pctImagem.Name = "pctImagem";
            this.pctImagem.Size = new System.Drawing.Size(127, 134);
            this.pctImagem.TabIndex = 88;
            this.pctImagem.TabStop = false;
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
            this.ucMenuInferior1.Location = new System.Drawing.Point(39, 667);
            this.ucMenuInferior1.Name = "ucMenuInferior1";
            this.ucMenuInferior1.Size = new System.Drawing.Size(404, 43);
            this.ucMenuInferior1.TabIndex = 96;
            this.ucMenuInferior1.EventoVoltar += new GuiWindowsForms.ucMenuInferior.delegateVoltar(this.ucAluno1_EventoVoltar);
            // 
            // telaAlunoFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GuiWindowsForms.Properties.Resources.modelo_tela_iconemenor1;
            this.ClientSize = new System.Drawing.Size(1000, 722);
            this.Controls.Add(this.ucMenuInferior1);
            this.Controls.Add(this.lblAtivo);
            this.Controls.Add(this.gpbFinanceiro);
            this.Controls.Add(this.lblFoneEmerg);
            this.Controls.Add(this.lblResponsavel);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblNomeAluno);
            this.Controls.Add(this.pctImagem);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.lblHelloUsuario);
            this.Controls.Add(this.uMenuLateral1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaAlunoFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaAlunoFinanceiro_FormClosing);
            this.gpbFinanceiro.ResumeLayout(false);
            this.tabFinanceiro.ResumeLayout(false);
            this.tabHistoricoMensalidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistoricoMensalidade)).EndInit();
            this.tabHistoricoAtividade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistoricoAtividade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloUsuario;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.GroupBox gpbFinanceiro;
        private System.Windows.Forms.DataGridView dtgHistoricoMensalidade;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TabControl tabFinanceiro;
        private System.Windows.Forms.TabPage tabPagamentoMensalidade;
        private System.Windows.Forms.TabPage tabHistoricoMensalidades;
        private System.Windows.Forms.TabPage tabHistoricoAtividade;
        private System.Windows.Forms.TabPage tabPagamentoAtividade;
        private System.Windows.Forms.DataGridView dtgHistoricoAtividade;
        private System.Windows.Forms.Label lblAtivo;
        private System.Windows.Forms.Label lblFoneEmerg;
        private System.Windows.Forms.Label lblResponsavel;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.PictureBox pctImagem;
        private GuiWindowsForms.User_Control.uMenuLateral uMenuLateral1;
        private ucMenuInferior ucMenuInferior1;
    }
}