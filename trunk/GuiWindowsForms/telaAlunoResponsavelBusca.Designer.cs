namespace GuiWindowsForms
{
    partial class telaAlunoResponsavelBusca
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaAlunoResponsavelBusca));
            this.dgvResponsavelAluno = new System.Windows.Forms.DataGridView();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.lblHelloUsuario = new System.Windows.Forms.Label();
            this.btnPesquisarResponsaveis = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ucMenuInferior1 = new GuiWindowsForms.ucMenuInferior();
            this.uMenuImagem1 = new GuiWindowsForms.uMenuImagem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsavelAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResponsavelAluno
            // 
            this.dgvResponsavelAluno.AllowUserToAddRows = false;
            this.dgvResponsavelAluno.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResponsavelAluno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResponsavelAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResponsavelAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResponsavelAluno.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResponsavelAluno.Location = new System.Drawing.Point(133, 266);
            this.dgvResponsavelAluno.Name = "dgvResponsavelAluno";
            this.dgvResponsavelAluno.ReadOnly = true;
            this.dgvResponsavelAluno.Size = new System.Drawing.Size(769, 272);
            this.dgvResponsavelAluno.TabIndex = 36;
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
            this.btnDesconectar.TabIndex = 72;
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
            this.lblHelloUsuario.Location = new System.Drawing.Point(794, 5);
            this.lblHelloUsuario.Name = "lblHelloUsuario";
            this.lblHelloUsuario.Size = new System.Drawing.Size(133, 23);
            this.lblHelloUsuario.TabIndex = 71;
            this.lblHelloUsuario.Text = "Hello Usuário!";
            // 
            // btnPesquisarResponsaveis
            // 
            this.btnPesquisarResponsaveis.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisarResponsaveis.BackgroundImage = global::GuiWindowsForms.Properties.Resources.Search_32x32_final;
            this.btnPesquisarResponsaveis.FlatAppearance.BorderSize = 0;
            this.btnPesquisarResponsaveis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarResponsaveis.Location = new System.Drawing.Point(870, 231);
            this.btnPesquisarResponsaveis.Margin = new System.Windows.Forms.Padding(0);
            this.btnPesquisarResponsaveis.Name = "btnPesquisarResponsaveis";
            this.btnPesquisarResponsaveis.Size = new System.Drawing.Size(32, 32);
            this.btnPesquisarResponsaveis.TabIndex = 74;
            this.btnPesquisarResponsaveis.UseVisualStyleBackColor = false;
            this.btnPesquisarResponsaveis.Click += new System.EventHandler(this.btnPesquisarResponsaveis_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Aluno.Nome";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ResideCom";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // ucMenuInferior1
            // 
            this.ucMenuInferior1.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuInferior1.Location = new System.Drawing.Point(39, 667);
            this.ucMenuInferior1.Name = "ucMenuInferior1";
            this.ucMenuInferior1.Size = new System.Drawing.Size(346, 43);
            this.ucMenuInferior1.TabIndex = 76;
            this.ucMenuInferior1.EventoVoltar += new GuiWindowsForms.ucMenuInferior.delegateVoltar(this.ucAluno1_EventoVoltar);
            // 
            // uMenuImagem1
            // 
            this.uMenuImagem1.BackColor = System.Drawing.Color.Transparent;
            this.uMenuImagem1.Location = new System.Drawing.Point(244, 0);
            this.uMenuImagem1.Name = "uMenuImagem1";
            this.uMenuImagem1.Size = new System.Drawing.Size(375, 201);
            this.uMenuImagem1.TabIndex = 75;
            // 
            // telaAlunoResponsavelBusca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GuiWindowsForms.Properties.Resources.modelo_tela_iconemenor1;
            this.ClientSize = new System.Drawing.Size(1000, 722);
            this.Controls.Add(this.ucMenuInferior1);
            this.Controls.Add(this.btnPesquisarResponsaveis);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.lblHelloUsuario);
            this.Controls.Add(this.dgvResponsavelAluno);
            this.Controls.Add(this.uMenuImagem1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaAlunoResponsavelBusca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            this.Load += new System.EventHandler(this.telaAlunoResponsavelBusca_Load);
            this.Activated += new System.EventHandler(this.telaAlunoResponsavelBusca_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaAlunoResponsavelBusca_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsavelAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResponsavelAluno;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Label lblHelloUsuario;
        private System.Windows.Forms.Button btnPesquisarResponsaveis;
        private uMenuImagem uMenuImagem1;
        private ucMenuInferior ucMenuInferior1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
    }
}