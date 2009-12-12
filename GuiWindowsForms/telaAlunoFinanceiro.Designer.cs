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
            this.lblFoneEmerg = new System.Windows.Forms.Label();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.pctImagem = new System.Windows.Forms.PictureBox();
            this.lblInfoControles = new System.Windows.Forms.Label();
            this.lblMatricula_menu = new System.Windows.Forms.Label();
            this.btnMatricula = new System.Windows.Forms.Button();
            this.lblAcademico_menu = new System.Windows.Forms.Label();
            this.lblFinanceiro_menu = new System.Windows.Forms.Label();
            this.lblMedico_menu = new System.Windows.Forms.Label();
            this.lblResponsavel_menu = new System.Windows.Forms.Label();
            this.lblDados_Menu = new System.Windows.Forms.Label();
            this.btnAcademico = new System.Windows.Forms.Button();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.btnInfoMedica = new System.Windows.Forms.Button();
            this.btnResponsaveis = new System.Windows.Forms.Button();
            this.btnDados = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAdicionarImagem = new System.Windows.Forms.Button();
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
            // lblFoneEmerg
            // 
            this.lblFoneEmerg.AutoSize = true;
            this.lblFoneEmerg.BackColor = System.Drawing.Color.Transparent;
            this.lblFoneEmerg.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblFoneEmerg.ForeColor = System.Drawing.Color.Yellow;
            this.lblFoneEmerg.Location = new System.Drawing.Point(394, 133);
            this.lblFoneEmerg.Name = "lblFoneEmerg";
            this.lblFoneEmerg.Size = new System.Drawing.Size(98, 19);
            this.lblFoneEmerg.TabIndex = 54;
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
            this.lblResponsavel.TabIndex = 53;
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
            this.lblSerie.TabIndex = 52;
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
            this.lblMatricula.TabIndex = 51;
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
            this.lblNomeAluno.TabIndex = 50;
            this.lblNomeAluno.Text = "Nome do Aluno";
            // 
            // pctImagem
            // 
            this.pctImagem.BackColor = System.Drawing.Color.Transparent;
            this.pctImagem.Location = new System.Drawing.Point(248, 12);
            this.pctImagem.Name = "pctImagem";
            this.pctImagem.Size = new System.Drawing.Size(127, 134);
            this.pctImagem.TabIndex = 49;
            this.pctImagem.TabStop = false;
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
            this.lblInfoControles.TabIndex = 84;
            this.lblInfoControles.Text = "-";
            this.lblInfoControles.Visible = false;
            // 
            // lblMatricula_menu
            // 
            this.lblMatricula_menu.AutoSize = true;
            this.lblMatricula_menu.BackColor = System.Drawing.Color.Transparent;
            this.lblMatricula_menu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblMatricula_menu.ForeColor = System.Drawing.Color.Yellow;
            this.lblMatricula_menu.Location = new System.Drawing.Point(900, 166);
            this.lblMatricula_menu.Name = "lblMatricula_menu";
            this.lblMatricula_menu.Size = new System.Drawing.Size(69, 17);
            this.lblMatricula_menu.TabIndex = 83;
            this.lblMatricula_menu.Text = "Matrícula";
            this.lblMatricula_menu.Visible = false;
            // 
            // btnMatricula
            // 
            this.btnMatricula.BackColor = System.Drawing.Color.Transparent;
            this.btnMatricula.BackgroundImage = global::GuiWindowsForms.Properties.Resources.matricula_68x69;
            this.btnMatricula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMatricula.FlatAppearance.BorderSize = 0;
            this.btnMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatricula.Location = new System.Drawing.Point(898, 88);
            this.btnMatricula.Margin = new System.Windows.Forms.Padding(0);
            this.btnMatricula.Name = "btnMatricula";
            this.btnMatricula.Size = new System.Drawing.Size(68, 69);
            this.btnMatricula.TabIndex = 82;
            this.btnMatricula.Tag = "Dados Pessoais";
            this.btnMatricula.UseVisualStyleBackColor = false;
            this.btnMatricula.MouseLeave += new System.EventHandler(this.btnMatricula_MouseLeave);
            this.btnMatricula.Click += new System.EventHandler(this.btnMatricula_Click);
            this.btnMatricula.MouseEnter += new System.EventHandler(this.btnMatricula_MouseEnter);
            // 
            // lblAcademico_menu
            // 
            this.lblAcademico_menu.AutoSize = true;
            this.lblAcademico_menu.BackColor = System.Drawing.Color.Transparent;
            this.lblAcademico_menu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblAcademico_menu.ForeColor = System.Drawing.Color.Yellow;
            this.lblAcademico_menu.Location = new System.Drawing.Point(895, 646);
            this.lblAcademico_menu.Name = "lblAcademico_menu";
            this.lblAcademico_menu.Size = new System.Drawing.Size(81, 17);
            this.lblAcademico_menu.TabIndex = 81;
            this.lblAcademico_menu.Text = "Acadêmico";
            // 
            // lblFinanceiro_menu
            // 
            this.lblFinanceiro_menu.AutoSize = true;
            this.lblFinanceiro_menu.BackColor = System.Drawing.Color.Transparent;
            this.lblFinanceiro_menu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblFinanceiro_menu.ForeColor = System.Drawing.Color.White;
            this.lblFinanceiro_menu.Location = new System.Drawing.Point(895, 548);
            this.lblFinanceiro_menu.Name = "lblFinanceiro_menu";
            this.lblFinanceiro_menu.Size = new System.Drawing.Size(77, 17);
            this.lblFinanceiro_menu.TabIndex = 80;
            this.lblFinanceiro_menu.Text = "Financeiro";
            this.lblFinanceiro_menu.Visible = false;
            // 
            // lblMedico_menu
            // 
            this.lblMedico_menu.AutoSize = true;
            this.lblMedico_menu.BackColor = System.Drawing.Color.Transparent;
            this.lblMedico_menu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblMedico_menu.ForeColor = System.Drawing.Color.Yellow;
            this.lblMedico_menu.Location = new System.Drawing.Point(889, 455);
            this.lblMedico_menu.Name = "lblMedico_menu";
            this.lblMedico_menu.Size = new System.Drawing.Size(88, 17);
            this.lblMedico_menu.TabIndex = 79;
            this.lblMedico_menu.Text = "Inf. Médicas";
            this.lblMedico_menu.Visible = false;
            // 
            // lblResponsavel_menu
            // 
            this.lblResponsavel_menu.AutoSize = true;
            this.lblResponsavel_menu.BackColor = System.Drawing.Color.Transparent;
            this.lblResponsavel_menu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblResponsavel_menu.ForeColor = System.Drawing.Color.Yellow;
            this.lblResponsavel_menu.Location = new System.Drawing.Point(885, 353);
            this.lblResponsavel_menu.Name = "lblResponsavel_menu";
            this.lblResponsavel_menu.Size = new System.Drawing.Size(97, 17);
            this.lblResponsavel_menu.TabIndex = 78;
            this.lblResponsavel_menu.Text = "Responsáveis";
            // 
            // lblDados_Menu
            // 
            this.lblDados_Menu.AutoSize = true;
            this.lblDados_Menu.BackColor = System.Drawing.Color.Transparent;
            this.lblDados_Menu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblDados_Menu.ForeColor = System.Drawing.Color.Yellow;
            this.lblDados_Menu.Location = new System.Drawing.Point(876, 265);
            this.lblDados_Menu.Name = "lblDados_Menu";
            this.lblDados_Menu.Size = new System.Drawing.Size(110, 17);
            this.lblDados_Menu.TabIndex = 77;
            this.lblDados_Menu.Text = "Dados Pessoais";
            // 
            // btnAcademico
            // 
            this.btnAcademico.BackColor = System.Drawing.Color.Transparent;
            this.btnAcademico.BackgroundImage = global::GuiWindowsForms.Properties.Resources.academico_73x72;
            this.btnAcademico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcademico.FlatAppearance.BorderSize = 0;
            this.btnAcademico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcademico.Location = new System.Drawing.Point(898, 574);
            this.btnAcademico.Margin = new System.Windows.Forms.Padding(0);
            this.btnAcademico.Name = "btnAcademico";
            this.btnAcademico.Size = new System.Drawing.Size(73, 72);
            this.btnAcademico.TabIndex = 76;
            this.btnAcademico.Tag = "";
            this.btnAcademico.UseVisualStyleBackColor = false;
            this.btnAcademico.MouseLeave += new System.EventHandler(this.btnAcademico_MouseLeave);
            this.btnAcademico.Click += new System.EventHandler(this.btnAcademico_Click);
            this.btnAcademico.MouseEnter += new System.EventHandler(this.btnAcademico_MouseEnter);
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.BackColor = System.Drawing.Color.Transparent;
            this.btnFinanceiro.BackgroundImage = global::GuiWindowsForms.Properties.Resources.financeiro_73x60_disabled;
            this.btnFinanceiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinanceiro.Enabled = false;
            this.btnFinanceiro.FlatAppearance.BorderSize = 0;
            this.btnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanceiro.Location = new System.Drawing.Point(898, 478);
            this.btnFinanceiro.Margin = new System.Windows.Forms.Padding(0);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(73, 60);
            this.btnFinanceiro.TabIndex = 75;
            this.btnFinanceiro.Tag = "";
            this.btnFinanceiro.UseVisualStyleBackColor = false;
            // 
            // btnInfoMedica
            // 
            this.btnInfoMedica.BackColor = System.Drawing.Color.Transparent;
            this.btnInfoMedica.BackgroundImage = global::GuiWindowsForms.Properties.Resources.injecao_73x73;
            this.btnInfoMedica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfoMedica.FlatAppearance.BorderSize = 0;
            this.btnInfoMedica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoMedica.Location = new System.Drawing.Point(898, 379);
            this.btnInfoMedica.Margin = new System.Windows.Forms.Padding(0);
            this.btnInfoMedica.Name = "btnInfoMedica";
            this.btnInfoMedica.Size = new System.Drawing.Size(73, 73);
            this.btnInfoMedica.TabIndex = 74;
            this.btnInfoMedica.Tag = "";
            this.btnInfoMedica.UseVisualStyleBackColor = false;
            this.btnInfoMedica.MouseLeave += new System.EventHandler(this.btnInfoMedica_MouseLeave);
            this.btnInfoMedica.Click += new System.EventHandler(this.btnInfoMedica_Click);
            this.btnInfoMedica.MouseEnter += new System.EventHandler(this.btnInfoMedica_MouseEnter);
            // 
            // btnResponsaveis
            // 
            this.btnResponsaveis.BackColor = System.Drawing.Color.Transparent;
            this.btnResponsaveis.BackgroundImage = global::GuiWindowsForms.Properties.Resources.responsavel_73x66;
            this.btnResponsaveis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResponsaveis.FlatAppearance.BorderSize = 0;
            this.btnResponsaveis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResponsaveis.Location = new System.Drawing.Point(898, 283);
            this.btnResponsaveis.Margin = new System.Windows.Forms.Padding(0);
            this.btnResponsaveis.Name = "btnResponsaveis";
            this.btnResponsaveis.Size = new System.Drawing.Size(73, 66);
            this.btnResponsaveis.TabIndex = 73;
            this.btnResponsaveis.Tag = "";
            this.btnResponsaveis.UseVisualStyleBackColor = false;
            this.btnResponsaveis.MouseLeave += new System.EventHandler(this.btnResponsaveis_MouseLeave);
            this.btnResponsaveis.Click += new System.EventHandler(this.btnResponsavel_Click);
            this.btnResponsaveis.MouseEnter += new System.EventHandler(this.btnResponsaveis_MouseEnter);
            // 
            // btnDados
            // 
            this.btnDados.AccessibleDescription = "";
            this.btnDados.BackColor = System.Drawing.Color.Transparent;
            this.btnDados.BackgroundImage = global::GuiWindowsForms.Properties.Resources.dados_73x74;
            this.btnDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDados.FlatAppearance.BorderSize = 0;
            this.btnDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDados.Location = new System.Drawing.Point(898, 191);
            this.btnDados.Margin = new System.Windows.Forms.Padding(0);
            this.btnDados.Name = "btnDados";
            this.btnDados.Size = new System.Drawing.Size(73, 74);
            this.btnDados.TabIndex = 72;
            this.btnDados.Tag = "";
            this.btnDados.UseVisualStyleBackColor = false;
            this.btnDados.MouseLeave += new System.EventHandler(this.btnDados_MouseLeave);
            this.btnDados.Click += new System.EventHandler(this.btnDados_Click);
            this.btnDados.MouseEnter += new System.EventHandler(this.btnDados_MouseEnter);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.ok_32x32_tipo2_final;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(86, 677);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(36, 29);
            this.btnSalvar.TabIndex = 71;
            this.btnSalvar.Tag = "";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.MouseLeave += new System.EventHandler(this.btnSalvar_MouseLeave);
            this.btnSalvar.MouseEnter += new System.EventHandler(this.btnSalvar_MouseEnter);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.voltar_final_32x32;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(31, 677);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(33, 34);
            this.btnVoltar.TabIndex = 70;
            this.btnVoltar.Tag = "";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.MouseLeave += new System.EventHandler(this.btnVoltar_MouseLeave);
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            this.btnVoltar.MouseEnter += new System.EventHandler(this.btnVoltar_MouseEnter);
            // 
            // btnAdicionarImagem
            // 
            this.btnAdicionarImagem.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarImagem.BackgroundImage = global::GuiWindowsForms.Properties.Resources.adicionar_final_32x32;
            this.btnAdicionarImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarImagem.FlatAppearance.BorderSize = 0;
            this.btnAdicionarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarImagem.Location = new System.Drawing.Point(290, 152);
            this.btnAdicionarImagem.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdicionarImagem.Name = "btnAdicionarImagem";
            this.btnAdicionarImagem.Size = new System.Drawing.Size(34, 34);
            this.btnAdicionarImagem.TabIndex = 69;
            this.btnAdicionarImagem.Tag = "";
            this.btnAdicionarImagem.UseVisualStyleBackColor = false;
            // 
            // telaAlunoFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GuiWindowsForms.Properties.Resources.modelo_tela_iconemenor1;
            this.ClientSize = new System.Drawing.Size(1000, 722);
            this.Controls.Add(this.lblInfoControles);
            this.Controls.Add(this.lblMatricula_menu);
            this.Controls.Add(this.btnMatricula);
            this.Controls.Add(this.lblAcademico_menu);
            this.Controls.Add(this.lblFinanceiro_menu);
            this.Controls.Add(this.lblMedico_menu);
            this.Controls.Add(this.lblResponsavel_menu);
            this.Controls.Add(this.lblDados_Menu);
            this.Controls.Add(this.btnAcademico);
            this.Controls.Add(this.btnFinanceiro);
            this.Controls.Add(this.btnInfoMedica);
            this.Controls.Add(this.btnResponsaveis);
            this.Controls.Add(this.btnDados);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAdicionarImagem);
            this.Controls.Add(this.lblFoneEmerg);
            this.Controls.Add(this.lblResponsavel);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblNomeAluno);
            this.Controls.Add(this.pctImagem);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.lblHelloUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaAlunoFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloUsuario;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Label lblFoneEmerg;
        private System.Windows.Forms.Label lblResponsavel;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.PictureBox pctImagem;
        private System.Windows.Forms.Label lblInfoControles;
        private System.Windows.Forms.Label lblMatricula_menu;
        private System.Windows.Forms.Button btnMatricula;
        private System.Windows.Forms.Label lblAcademico_menu;
        private System.Windows.Forms.Label lblFinanceiro_menu;
        private System.Windows.Forms.Label lblMedico_menu;
        private System.Windows.Forms.Label lblResponsavel_menu;
        private System.Windows.Forms.Label lblDados_Menu;
        private System.Windows.Forms.Button btnAcademico;
        private System.Windows.Forms.Button btnFinanceiro;
        private System.Windows.Forms.Button btnInfoMedica;
        private System.Windows.Forms.Button btnResponsaveis;
        private System.Windows.Forms.Button btnDados;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAdicionarImagem;
    }
}