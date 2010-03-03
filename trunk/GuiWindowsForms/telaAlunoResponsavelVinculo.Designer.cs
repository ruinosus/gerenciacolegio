namespace GuiWindowsForms
{
    partial class telaAlunoResponsavelVinculo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaAlunoResponsavelVinculo));
            this.dgvResponsavelAluno = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrauParentesco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmbGrauParentesco = new System.Windows.Forms.ComboBox();
            this.lblGrauParentesco = new System.Windows.Forms.Label();
            this.ckbResideCom = new System.Windows.Forms.CheckBox();
            this.lblResideCom = new System.Windows.Forms.Label();
            this.lblRestricoes = new System.Windows.Forms.Label();
            this.txtRestricoes = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProviderTela = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCadastrarResponsavel = new System.Windows.Forms.Button();
            this.ucDesconectarLogin1 = new GuiWindowsForms.User_Control.ucDesconectarLogin();
            this.ucMenuInferior1 = new GuiWindowsForms.ucMenuInferior();
            this.uMenuImagem1 = new GuiWindowsForms.uMenuImagem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsavelAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTela)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResponsavelAluno
            // 
            this.dgvResponsavelAluno.AllowUserToAddRows = false;
            this.dgvResponsavelAluno.AllowUserToDeleteRows = false;
            this.dgvResponsavelAluno.BackgroundColor = System.Drawing.Color.White;
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
            this.dgvResponsavelAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResponsavelAluno.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResponsavelAluno.Location = new System.Drawing.Point(141, 362);
            this.dgvResponsavelAluno.MultiSelect = false;
            this.dgvResponsavelAluno.Name = "dgvResponsavelAluno";
            this.dgvResponsavelAluno.ReadOnly = true;
            this.dgvResponsavelAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResponsavelAluno.Size = new System.Drawing.Size(769, 272);
            this.dgvResponsavelAluno.TabIndex = 36;
            this.dgvResponsavelAluno.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResponsavelAluno_CellDoubleClick);
            this.dgvResponsavelAluno.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResponsavelAluno_CellEnter);
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Responsavel";
            this.Column3.HeaderText = "Nome do Responsável";
            this.Column3.MaxInputLength = 30;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 250;
            // 
            // GrauParentesco
            // 
            this.GrauParentesco.DataPropertyName = "GrauParentesco";
            this.GrauParentesco.HeaderText = "Grau de Parentesco";
            this.GrauParentesco.MaxInputLength = 30;
            this.GrauParentesco.Name = "GrauParentesco";
            this.GrauParentesco.ReadOnly = true;
            this.GrauParentesco.Width = 130;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Restricoes";
            this.Column4.HeaderText = "Restrições";
            this.Column4.MaxInputLength = 60;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 220;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ResideCom";
            this.Column2.HeaderText = "Reside Com";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // cmbGrauParentesco
            // 
            this.cmbGrauParentesco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbGrauParentesco.DisplayMember = "se";
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
            this.cmbGrauParentesco.Location = new System.Drawing.Point(273, 256);
            this.cmbGrauParentesco.Name = "cmbGrauParentesco";
            this.cmbGrauParentesco.Size = new System.Drawing.Size(144, 21);
            this.cmbGrauParentesco.TabIndex = 1;
            this.cmbGrauParentesco.ValueMember = "selecione";
            // 
            // lblGrauParentesco
            // 
            this.lblGrauParentesco.AutoSize = true;
            this.lblGrauParentesco.BackColor = System.Drawing.Color.Transparent;
            this.lblGrauParentesco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrauParentesco.Location = new System.Drawing.Point(140, 264);
            this.lblGrauParentesco.Name = "lblGrauParentesco";
            this.lblGrauParentesco.Size = new System.Drawing.Size(124, 13);
            this.lblGrauParentesco.TabIndex = 4;
            this.lblGrauParentesco.Text = "Grau de Parentesco:";
            // 
            // ckbResideCom
            // 
            this.ckbResideCom.AutoSize = true;
            this.ckbResideCom.BackColor = System.Drawing.Color.Transparent;
            this.ckbResideCom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbResideCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbResideCom.Location = new System.Drawing.Point(527, 264);
            this.ckbResideCom.Name = "ckbResideCom";
            this.ckbResideCom.Size = new System.Drawing.Size(15, 14);
            this.ckbResideCom.TabIndex = 77;
            this.ckbResideCom.UseVisualStyleBackColor = false;
            // 
            // lblResideCom
            // 
            this.lblResideCom.AutoSize = true;
            this.lblResideCom.BackColor = System.Drawing.Color.Transparent;
            this.lblResideCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResideCom.Location = new System.Drawing.Point(433, 264);
            this.lblResideCom.Name = "lblResideCom";
            this.lblResideCom.Size = new System.Drawing.Size(78, 13);
            this.lblResideCom.TabIndex = 78;
            this.lblResideCom.Text = "Reside Com:";
            // 
            // lblRestricoes
            // 
            this.lblRestricoes.AutoSize = true;
            this.lblRestricoes.BackColor = System.Drawing.Color.Transparent;
            this.lblRestricoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestricoes.Location = new System.Drawing.Point(140, 291);
            this.lblRestricoes.Name = "lblRestricoes";
            this.lblRestricoes.Size = new System.Drawing.Size(71, 13);
            this.lblRestricoes.TabIndex = 79;
            this.lblRestricoes.Text = "Restrições:";
            // 
            // txtRestricoes
            // 
            this.txtRestricoes.Location = new System.Drawing.Point(273, 291);
            this.txtRestricoes.MaxLength = 300;
            this.txtRestricoes.Multiline = true;
            this.txtRestricoes.Name = "txtRestricoes";
            this.txtRestricoes.Size = new System.Drawing.Size(637, 65);
            this.txtRestricoes.TabIndex = 80;
            this.txtRestricoes.Leave += new System.EventHandler(this.txtRestricoes_Leave);
            this.txtRestricoes.Enter += new System.EventHandler(this.txtRestricoes_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GuiWindowsForms.Properties.Resources.simbolo_colegio;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 112);
            this.pictureBox1.TabIndex = 138;
            this.pictureBox1.TabStop = false;
            // 
            // errorProviderTela
            // 
            this.errorProviderTela.ContainerControl = this;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(140, 224);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 13);
            this.lblNome.TabIndex = 140;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtNome.Location = new System.Drawing.Point(273, 217);
            this.txtNome.MaxLength = 40;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(330, 20);
            this.txtNome.TabIndex = 141;
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            // 
            // mskCpf
            // 
            this.mskCpf.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.mskCpf.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mskCpf.Location = new System.Drawing.Point(660, 217);
            this.mskCpf.Mask = "000.000.000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(100, 20);
            this.mskCpf.TabIndex = 143;
            this.mskCpf.Leave += new System.EventHandler(this.mskCpf_Leave);
            this.mskCpf.Enter += new System.EventHandler(this.mskCpf_Enter);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(620, 224);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(34, 13);
            this.lblCpf.TabIndex = 142;
            this.lblCpf.Text = "CPF:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.Search_32x32_final;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Location = new System.Drawing.Point(780, 214);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(32, 32);
            this.btnPesquisar.TabIndex = 144;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCadastrarResponsavel
            // 
            this.btnCadastrarResponsavel.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarResponsavel.BackgroundImage = global::GuiWindowsForms.Properties.Resources.ok_32x32_tipo2_final;
            this.btnCadastrarResponsavel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarResponsavel.Enabled = false;
            this.btnCadastrarResponsavel.FlatAppearance.BorderSize = 0;
            this.btnCadastrarResponsavel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarResponsavel.Location = new System.Drawing.Point(871, 214);
            this.btnCadastrarResponsavel.Name = "btnCadastrarResponsavel";
            this.btnCadastrarResponsavel.Size = new System.Drawing.Size(34, 32);
            this.btnCadastrarResponsavel.TabIndex = 145;
            this.btnCadastrarResponsavel.UseVisualStyleBackColor = false;
            this.btnCadastrarResponsavel.Click += new System.EventHandler(this.btnCadastrarResponsavel_Click);
            // 
            // ucDesconectarLogin1
            // 
            this.ucDesconectarLogin1.BackColor = System.Drawing.Color.Transparent;
            this.ucDesconectarLogin1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucDesconectarLogin1.Location = new System.Drawing.Point(738, 0);
            this.ucDesconectarLogin1.Name = "ucDesconectarLogin1";
            this.ucDesconectarLogin1.Size = new System.Drawing.Size(253, 39);
            this.ucDesconectarLogin1.TabIndex = 139;
            this.ucDesconectarLogin1.EventoDesconectar += new GuiWindowsForms.User_Control.ucDesconectarLogin.delegateDesconectar(this.ucDesconectarLogin1_EventoDesconectar);
            // 
            // ucMenuInferior1
            // 
            this.ucMenuInferior1.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuInferior1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucMenuInferior1.Location = new System.Drawing.Point(39, 637);
            this.ucMenuInferior1.Name = "ucMenuInferior1";
            this.ucMenuInferior1.Size = new System.Drawing.Size(598, 43);
            this.ucMenuInferior1.TabIndex = 76;
            this.ucMenuInferior1.EventoCadastrar += new GuiWindowsForms.ucMenuInferior.delegateCadastrar(this.ucMenuInferior1_EventoCadastrar);
            this.ucMenuInferior1.EventoVoltar += new GuiWindowsForms.ucMenuInferior.delegateVoltar(this.ucAluno1_EventoVoltar);
            this.ucMenuInferior1.EventoIncluir += new GuiWindowsForms.ucMenuInferior.delegateIncluir(this.ucMenuInferior1_EventoIncluir);
            this.ucMenuInferior1.EventoAlterar += new GuiWindowsForms.ucMenuInferior.delegateAlterar(this.ucMenuInferior1_EventoAlterar);
            this.ucMenuInferior1.EventoDeletar += new GuiWindowsForms.ucMenuInferior.delegateDeletar(this.ucMenuInferior1_EventoDeletar);
            // 
            // uMenuImagem1
            // 
            this.uMenuImagem1.BackColor = System.Drawing.Color.Transparent;
            this.uMenuImagem1.Location = new System.Drawing.Point(244, 0);
            this.uMenuImagem1.Name = "uMenuImagem1";
            this.uMenuImagem1.Size = new System.Drawing.Size(533, 201);
            this.uMenuImagem1.TabIndex = 75;
            // 
            // telaAlunoResponsavelVinculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(179)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(990, 680);
            this.Controls.Add(this.btnCadastrarResponsavel);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.ucDesconectarLogin1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtRestricoes);
            this.Controls.Add(this.lblRestricoes);
            this.Controls.Add(this.lblResideCom);
            this.Controls.Add(this.ckbResideCom);
            this.Controls.Add(this.cmbGrauParentesco);
            this.Controls.Add(this.lblGrauParentesco);
            this.Controls.Add(this.ucMenuInferior1);
            this.Controls.Add(this.dgvResponsavelAluno);
            this.Controls.Add(this.uMenuImagem1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaAlunoResponsavelVinculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            this.Activated += new System.EventHandler(this.telaAlunoResponsavelBusca_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaAlunoResponsavelBusca_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsavelAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResponsavelAluno;
        private uMenuImagem uMenuImagem1;
        private ucMenuInferior ucMenuInferior1;
        private System.Windows.Forms.ComboBox cmbGrauParentesco;
        private System.Windows.Forms.Label lblGrauParentesco;
        private System.Windows.Forms.CheckBox ckbResideCom;
        private System.Windows.Forms.Label lblResideCom;
        private System.Windows.Forms.Label lblRestricoes;
        private System.Windows.Forms.TextBox txtRestricoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrauParentesco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private GuiWindowsForms.User_Control.ucDesconectarLogin ucDesconectarLogin1;
        private System.Windows.Forms.ErrorProvider errorProviderTela;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCadastrarResponsavel;
    }
}