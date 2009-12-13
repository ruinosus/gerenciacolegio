namespace GuiWindowsForms
{
    partial class telaConfiguracoesDescontoMatricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaConfiguracoesDescontoMatricula));
            this.gpbSerie = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblDesconto_menu = new System.Windows.Forms.Label();
            this.lblAtividade_menu = new System.Windows.Forms.Label();
            this.lblSerie_menu = new System.Windows.Forms.Label();
            this.btnControledeAcesso = new System.Windows.Forms.Button();
            this.lblControleAcesso_menu = new System.Windows.Forms.Label();
            this.btnSerie = new System.Windows.Forms.Button();
            this.btnDesconto = new System.Windows.Forms.Button();
            this.btnAtividade = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblHelloUsuario = new System.Windows.Forms.Label();
            this.lblInfoControles = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.gpbSerie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbSerie
            // 
            this.gpbSerie.BackColor = System.Drawing.Color.Transparent;
            this.gpbSerie.Controls.Add(this.btnExcluir);
            this.gpbSerie.Controls.Add(this.textBox1);
            this.gpbSerie.Controls.Add(this.lblValor);
            this.gpbSerie.Controls.Add(this.txtDescricao);
            this.gpbSerie.Controls.Add(this.lblDescricao);
            this.gpbSerie.Controls.Add(this.dataGridView1);
            this.gpbSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSerie.Location = new System.Drawing.Point(153, 129);
            this.gpbSerie.Name = "gpbSerie";
            this.gpbSerie.Size = new System.Drawing.Size(688, 550);
            this.gpbSerie.TabIndex = 65;
            this.gpbSerie.TabStop = false;
            this.gpbSerie.Text = "DESCONTO MATRICULA";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Location = new System.Drawing.Point(483, 191);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 69;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 134);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 4;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(21, 137);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(68, 13);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor (R$):";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(92, 69);
            this.txtDescricao.MaxLength = 30;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(249, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(21, 72);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(68, 13);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblDesconto_menu
            // 
            this.lblDesconto_menu.AutoSize = true;
            this.lblDesconto_menu.BackColor = System.Drawing.Color.Transparent;
            this.lblDesconto_menu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblDesconto_menu.ForeColor = System.Drawing.Color.White;
            this.lblDesconto_menu.Location = new System.Drawing.Point(915, 466);
            this.lblDesconto_menu.Name = "lblDesconto_menu";
            this.lblDesconto_menu.Size = new System.Drawing.Size(76, 17);
            this.lblDesconto_menu.TabIndex = 140;
            this.lblDesconto_menu.Text = "Descontos";
            // 
            // lblAtividade_menu
            // 
            this.lblAtividade_menu.AutoSize = true;
            this.lblAtividade_menu.BackColor = System.Drawing.Color.Transparent;
            this.lblAtividade_menu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblAtividade_menu.ForeColor = System.Drawing.Color.Yellow;
            this.lblAtividade_menu.Location = new System.Drawing.Point(911, 364);
            this.lblAtividade_menu.Name = "lblAtividade_menu";
            this.lblAtividade_menu.Size = new System.Drawing.Size(76, 17);
            this.lblAtividade_menu.TabIndex = 139;
            this.lblAtividade_menu.Text = "Atividades";
            this.lblAtividade_menu.Visible = false;
            // 
            // lblSerie_menu
            // 
            this.lblSerie_menu.AutoSize = true;
            this.lblSerie_menu.BackColor = System.Drawing.Color.Transparent;
            this.lblSerie_menu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblSerie_menu.ForeColor = System.Drawing.Color.Yellow;
            this.lblSerie_menu.Location = new System.Drawing.Point(927, 269);
            this.lblSerie_menu.Name = "lblSerie_menu";
            this.lblSerie_menu.Size = new System.Drawing.Size(49, 17);
            this.lblSerie_menu.TabIndex = 138;
            this.lblSerie_menu.Text = "Séries";
            this.lblSerie_menu.Visible = false;
            // 
            // btnControledeAcesso
            // 
            this.btnControledeAcesso.BackColor = System.Drawing.Color.Transparent;
            this.btnControledeAcesso.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_acesso_64x80;
            this.btnControledeAcesso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControledeAcesso.FlatAppearance.BorderSize = 0;
            this.btnControledeAcesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControledeAcesso.Location = new System.Drawing.Point(15, 190);
            this.btnControledeAcesso.Margin = new System.Windows.Forms.Padding(0);
            this.btnControledeAcesso.Name = "btnControledeAcesso";
            this.btnControledeAcesso.Size = new System.Drawing.Size(64, 80);
            this.btnControledeAcesso.TabIndex = 133;
            this.btnControledeAcesso.UseVisualStyleBackColor = false;
            this.btnControledeAcesso.MouseLeave += new System.EventHandler(this.btnControledeAcesso_MouseLeave);
            this.btnControledeAcesso.Click += new System.EventHandler(this.btnControledeAcesso_Click);
            this.btnControledeAcesso.MouseEnter += new System.EventHandler(this.btnControledeAcesso_MouseEnter);
            // 
            // lblControleAcesso_menu
            // 
            this.lblControleAcesso_menu.AutoSize = true;
            this.lblControleAcesso_menu.BackColor = System.Drawing.Color.Transparent;
            this.lblControleAcesso_menu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblControleAcesso_menu.ForeColor = System.Drawing.Color.Yellow;
            this.lblControleAcesso_menu.Location = new System.Drawing.Point(25, 271);
            this.lblControleAcesso_menu.Name = "lblControleAcesso_menu";
            this.lblControleAcesso_menu.Size = new System.Drawing.Size(46, 17);
            this.lblControleAcesso_menu.TabIndex = 137;
            this.lblControleAcesso_menu.Text = "Perfis";
            this.lblControleAcesso_menu.Visible = false;
            // 
            // btnSerie
            // 
            this.btnSerie.BackColor = System.Drawing.Color.Transparent;
            this.btnSerie.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_serie_64x70;
            this.btnSerie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSerie.FlatAppearance.BorderSize = 0;
            this.btnSerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerie.Location = new System.Drawing.Point(920, 190);
            this.btnSerie.Margin = new System.Windows.Forms.Padding(0);
            this.btnSerie.Name = "btnSerie";
            this.btnSerie.Size = new System.Drawing.Size(60, 74);
            this.btnSerie.TabIndex = 134;
            this.btnSerie.UseVisualStyleBackColor = false;
            this.btnSerie.MouseLeave += new System.EventHandler(this.btnSerie_MouseLeave);
            this.btnSerie.Click += new System.EventHandler(this.btnSerie_Click);
            this.btnSerie.MouseEnter += new System.EventHandler(this.btnSerie_MouseEnter);
            // 
            // btnDesconto
            // 
            this.btnDesconto.BackColor = System.Drawing.Color.Transparent;
            this.btnDesconto.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_desconto_79x80_disabled;
            this.btnDesconto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesconto.Enabled = false;
            this.btnDesconto.FlatAppearance.BorderSize = 0;
            this.btnDesconto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconto.Location = new System.Drawing.Point(915, 390);
            this.btnDesconto.Margin = new System.Windows.Forms.Padding(0);
            this.btnDesconto.Name = "btnDesconto";
            this.btnDesconto.Size = new System.Drawing.Size(79, 80);
            this.btnDesconto.TabIndex = 136;
            this.btnDesconto.UseVisualStyleBackColor = false;
            // 
            // btnAtividade
            // 
            this.btnAtividade.BackColor = System.Drawing.Color.Transparent;
            this.btnAtividade.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_atividades_84x75;
            this.btnAtividade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtividade.FlatAppearance.BorderSize = 0;
            this.btnAtividade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtividade.Location = new System.Drawing.Point(907, 290);
            this.btnAtividade.Margin = new System.Windows.Forms.Padding(0);
            this.btnAtividade.Name = "btnAtividade";
            this.btnAtividade.Size = new System.Drawing.Size(84, 75);
            this.btnAtividade.TabIndex = 135;
            this.btnAtividade.UseVisualStyleBackColor = false;
            this.btnAtividade.MouseLeave += new System.EventHandler(this.btnAtividades_MouseLeave);
            this.btnAtividade.Click += new System.EventHandler(this.btnAtividades_Click);
            this.btnAtividade.MouseEnter += new System.EventHandler(this.btnAtividades_MouseEnter);
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
            this.btnSalvar.TabIndex = 132;
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
            this.btnVoltar.TabIndex = 130;
            this.btnVoltar.Tag = "";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.MouseLeave += new System.EventHandler(this.btnVoltar_MouseLeave);
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            this.btnVoltar.MouseEnter += new System.EventHandler(this.btnVoltar_MouseEnter);
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
            this.lblHelloUsuario.TabIndex = 128;
            this.lblHelloUsuario.Text = "Hello Usuário!";
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
            this.lblInfoControles.TabIndex = 131;
            this.lblInfoControles.Text = "-";
            this.lblInfoControles.Visible = false;
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
            this.btnDesconectar.TabIndex = 129;
            this.btnDesconectar.Tag = "";
            this.btnDesconectar.UseVisualStyleBackColor = false;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // telaConfiguracoesDescontoMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GuiWindowsForms.Properties.Resources.modelo_tela_iconemenor;
            this.ClientSize = new System.Drawing.Size(1000, 722);
            this.Controls.Add(this.lblDesconto_menu);
            this.Controls.Add(this.lblAtividade_menu);
            this.Controls.Add(this.lblSerie_menu);
            this.Controls.Add(this.btnControledeAcesso);
            this.Controls.Add(this.lblControleAcesso_menu);
            this.Controls.Add(this.btnSerie);
            this.Controls.Add(this.btnDesconto);
            this.Controls.Add(this.btnAtividade);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblHelloUsuario);
            this.Controls.Add(this.lblInfoControles);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.gpbSerie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaConfiguracoesDescontoMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaConfiguracoesDescontoMatricula_FormClosing);
            this.gpbSerie.ResumeLayout(false);
            this.gpbSerie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbSerie;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblDesconto_menu;
        private System.Windows.Forms.Label lblAtividade_menu;
        private System.Windows.Forms.Label lblSerie_menu;
        private System.Windows.Forms.Button btnControledeAcesso;
        private System.Windows.Forms.Label lblControleAcesso_menu;
        private System.Windows.Forms.Button btnSerie;
        private System.Windows.Forms.Button btnDesconto;
        private System.Windows.Forms.Button btnAtividade;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblHelloUsuario;
        private System.Windows.Forms.Label lblInfoControles;
        private System.Windows.Forms.Button btnDesconectar;
    }
}