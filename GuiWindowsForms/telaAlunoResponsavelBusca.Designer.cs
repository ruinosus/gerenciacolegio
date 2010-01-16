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
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrauParentesco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.lblHelloUsuario = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAdicionarSerie = new System.Windows.Forms.Button();
            this.cmbGrauParentesco = new System.Windows.Forms.ComboBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblCiclo = new System.Windows.Forms.Label();
            this.ckbResideCom = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRestricoes = new System.Windows.Forms.TextBox();
            this.comboResponsavel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.Column3,
            this.GrauParentesco,
            this.Column4,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResponsavelAluno.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResponsavelAluno.Location = new System.Drawing.Point(141, 362);
            this.dgvResponsavelAluno.Name = "dgvResponsavelAluno";
            this.dgvResponsavelAluno.Size = new System.Drawing.Size(769, 272);
            this.dgvResponsavelAluno.TabIndex = 36;
            this.dgvResponsavelAluno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResponsavelAluno_CellClick);
            this.dgvResponsavelAluno.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResponsavelAluno_CellEnter);
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Responsavel";
            this.Column3.HeaderText = "Nome do Responsável";
            this.Column3.MaxInputLength = 30;
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // GrauParentesco
            // 
            this.GrauParentesco.DataPropertyName = "GrauParentesco";
            this.GrauParentesco.HeaderText = "Grau de Parentesco";
            this.GrauParentesco.MaxInputLength = 30;
            this.GrauParentesco.Name = "GrauParentesco";
            this.GrauParentesco.Width = 130;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Restricoes";
            this.Column4.HeaderText = "Restrições";
            this.Column4.MaxInputLength = 60;
            this.Column4.Name = "Column4";
            this.Column4.Width = 220;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ResideCom";
            this.Column2.HeaderText = "Reside Com";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
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
            this.lblHelloUsuario.Location = new System.Drawing.Point(760, 7);
            this.lblHelloUsuario.Name = "lblHelloUsuario";
            this.lblHelloUsuario.Size = new System.Drawing.Size(133, 23);
            this.lblHelloUsuario.TabIndex = 71;
            this.lblHelloUsuario.Text = "Hello Usuário!";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.alterar_final;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Location = new System.Drawing.Point(802, 324);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(32, 32);
            this.btnAlterar.TabIndex = 71;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarSerie
            // 
            this.btnAdicionarSerie.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_mais;
            this.btnAdicionarSerie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarSerie.FlatAppearance.BorderSize = 0;
            this.btnAdicionarSerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarSerie.Location = new System.Drawing.Point(840, 324);
            this.btnAdicionarSerie.Name = "btnAdicionarSerie";
            this.btnAdicionarSerie.Size = new System.Drawing.Size(32, 32);
            this.btnAdicionarSerie.TabIndex = 3;
            this.btnAdicionarSerie.UseVisualStyleBackColor = true;
            // 
            // cmbGrauParentesco
            // 
            this.cmbGrauParentesco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrauParentesco.FormattingEnabled = true;
            this.cmbGrauParentesco.Items.AddRange(new object[] {
            "selecione",
            "Pai",
            "Mãe",
            "Tio(a)",
            "Avô(ó)",
            "Primo(a)",
            "Irmão(ã)"});
            this.cmbGrauParentesco.Location = new System.Drawing.Point(360, 217);
            this.cmbGrauParentesco.Name = "cmbGrauParentesco";
            this.cmbGrauParentesco.Size = new System.Drawing.Size(144, 21);
            this.cmbGrauParentesco.TabIndex = 1;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_menos;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(878, 345);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(32, 11);
            this.btnExcluir.TabIndex = 70;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblCiclo
            // 
            this.lblCiclo.AutoSize = true;
            this.lblCiclo.BackColor = System.Drawing.Color.Transparent;
            this.lblCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiclo.Location = new System.Drawing.Point(224, 217);
            this.lblCiclo.Name = "lblCiclo";
            this.lblCiclo.Size = new System.Drawing.Size(124, 13);
            this.lblCiclo.TabIndex = 4;
            this.lblCiclo.Text = "Grau de Parentesco:";
            // 
            // ckbResideCom
            // 
            this.ckbResideCom.AutoSize = true;
            this.ckbResideCom.BackColor = System.Drawing.Color.Transparent;
            this.ckbResideCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbResideCom.Location = new System.Drawing.Point(360, 254);
            this.ckbResideCom.Name = "ckbResideCom";
            this.ckbResideCom.Size = new System.Drawing.Size(15, 14);
            this.ckbResideCom.TabIndex = 77;
            this.ckbResideCom.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Reside Com:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Restrições:";
            // 
            // txtRestricoes
            // 
            this.txtRestricoes.Location = new System.Drawing.Point(357, 291);
            this.txtRestricoes.MaxLength = 300;
            this.txtRestricoes.Multiline = true;
            this.txtRestricoes.Name = "txtRestricoes";
            this.txtRestricoes.Size = new System.Drawing.Size(444, 65);
            this.txtRestricoes.TabIndex = 80;
            // 
            // comboResponsavel
            // 
            this.comboResponsavel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboResponsavel.FormattingEnabled = true;
            this.comboResponsavel.Items.AddRange(new object[] {
            "selecione",
            "Pai",
            "Mãe",
            "Tio(a)",
            "Avô(ó)",
            "Primo(a)",
            "Irmão(ã)"});
            this.comboResponsavel.Location = new System.Drawing.Point(611, 217);
            this.comboResponsavel.Name = "comboResponsavel";
            this.comboResponsavel.Size = new System.Drawing.Size(190, 21);
            this.comboResponsavel.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(521, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "Responsável:";
            // 
            // ucMenuInferior1
            // 
            this.ucMenuInferior1.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuInferior1.Location = new System.Drawing.Point(39, 667);
            this.ucMenuInferior1.Name = "ucMenuInferior1";
            this.ucMenuInferior1.Size = new System.Drawing.Size(346, 43);
            this.ucMenuInferior1.TabIndex = 76;
            this.ucMenuInferior1.EventoCadastrar += new GuiWindowsForms.ucMenuInferior.delegateCadastrar(this.ucMenuInferior1_EventoCadastrar);
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
            this.Controls.Add(this.comboResponsavel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRestricoes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckbResideCom);
            this.Controls.Add(this.cmbGrauParentesco);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionarSerie);
            this.Controls.Add(this.lblCiclo);
            this.Controls.Add(this.ucMenuInferior1);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.lblHelloUsuario);
            this.Controls.Add(this.dgvResponsavelAluno);
            this.Controls.Add(this.uMenuImagem1);
            this.Controls.Add(this.btnExcluir);
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
        private uMenuImagem uMenuImagem1;
        private ucMenuInferior ucMenuInferior1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnAdicionarSerie;
        private System.Windows.Forms.ComboBox cmbGrauParentesco;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblCiclo;
        private System.Windows.Forms.CheckBox ckbResideCom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRestricoes;
        private System.Windows.Forms.ComboBox comboResponsavel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrauParentesco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
    }
}