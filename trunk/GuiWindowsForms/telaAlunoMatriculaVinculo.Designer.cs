namespace GuiWindowsForms
{
    partial class telaAlunoMatriculaVinculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaAlunoMatriculaVinculo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProviderTela = new System.Windows.Forms.ErrorProvider(this.components);
            this.ucMenuInferior1 = new GuiWindowsForms.ucMenuInferior();
            this.uMenuImagem1 = new GuiWindowsForms.uMenuImagem();
            this.cmbAluno = new System.Windows.Forms.ComboBox();
            this.lblAluno = new System.Windows.Forms.Label();
            this.dgvAlunosVinculados = new System.Windows.Forms.DataGridView();
            this.ucDesconectarLogin1 = new GuiWindowsForms.User_Control.ucDesconectarLogin();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrauParentesco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosVinculados)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.errorProviderTela.SetIconAlignment(this.pictureBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox1.IconAlignment"))));
            this.pictureBox1.Image = global::GuiWindowsForms.Properties.Resources.simbolo_colegio;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // errorProviderTela
            // 
            this.errorProviderTela.ContainerControl = this;
            // 
            // ucMenuInferior1
            // 
            this.ucMenuInferior1.BackColor = System.Drawing.Color.Transparent;
            this.errorProviderTela.SetIconAlignment(this.ucMenuInferior1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ucMenuInferior1.IconAlignment"))));
            resources.ApplyResources(this.ucMenuInferior1, "ucMenuInferior1");
            this.ucMenuInferior1.Name = "ucMenuInferior1";
            this.ucMenuInferior1.EventoCadastrar += new GuiWindowsForms.ucMenuInferior.delegateCadastrar(this.ucMenuInferior1_EventoCadastrar);
            this.ucMenuInferior1.EventoVoltar += new GuiWindowsForms.ucMenuInferior.delegateVoltar(this.ucAluno1_EventoVoltar);
            this.ucMenuInferior1.EventoIncluir += new GuiWindowsForms.ucMenuInferior.delegateIncluir(this.ucMenuInferior1_EventoIncluir);
            this.ucMenuInferior1.EventoAlterar += new GuiWindowsForms.ucMenuInferior.delegateAlterar(this.ucMenuInferior1_EventoAlterar);
            this.ucMenuInferior1.EventoDeletar += new GuiWindowsForms.ucMenuInferior.delegateDeletar(this.ucMenuInferior1_EventoDeletar);
            // 
            // uMenuImagem1
            // 
            this.uMenuImagem1.BackColor = System.Drawing.Color.Transparent;
            this.errorProviderTela.SetIconAlignment(this.uMenuImagem1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("uMenuImagem1.IconAlignment"))));
            resources.ApplyResources(this.uMenuImagem1, "uMenuImagem1");
            this.uMenuImagem1.Name = "uMenuImagem1";
            // 
            // cmbAluno
            // 
            this.cmbAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAluno.DisplayMember = "se";
            this.cmbAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAluno.FormattingEnabled = true;
            resources.ApplyResources(this.cmbAluno, "cmbAluno");
            this.cmbAluno.Name = "cmbAluno";
            this.cmbAluno.ValueMember = "selecione";
            // 
            // lblAluno
            // 
            resources.ApplyResources(this.lblAluno, "lblAluno");
            this.lblAluno.BackColor = System.Drawing.Color.Transparent;
            this.lblAluno.Name = "lblAluno";
            // 
            // dgvAlunosVinculados
            // 
            this.dgvAlunosVinculados.AllowUserToAddRows = false;
            this.dgvAlunosVinculados.AllowUserToDeleteRows = false;
            this.dgvAlunosVinculados.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlunosVinculados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlunosVinculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunosVinculados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.GrauParentesco});
            this.dgvAlunosVinculados.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlunosVinculados.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dgvAlunosVinculados, "dgvAlunosVinculados");
            this.dgvAlunosVinculados.MultiSelect = false;
            this.dgvAlunosVinculados.Name = "dgvAlunosVinculados";
            this.dgvAlunosVinculados.ReadOnly = true;
            this.dgvAlunosVinculados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlunosVinculados.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunosVinculados_CellEnter);
            // 
            // ucDesconectarLogin1
            // 
            this.ucDesconectarLogin1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ucDesconectarLogin1, "ucDesconectarLogin1");
            this.ucDesconectarLogin1.Name = "ucDesconectarLogin1";
            this.ucDesconectarLogin1.EventoDesconectar += new GuiWindowsForms.User_Control.ucDesconectarLogin.delegateDesconectar(this.ucDesconectarLogin1_EventoDesconectar);
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NomeAluno1";
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.MaxInputLength = 30;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GrauParentesco
            // 
            this.GrauParentesco.DataPropertyName = "SerieAluno";
            resources.ApplyResources(this.GrauParentesco, "GrauParentesco");
            this.GrauParentesco.MaxInputLength = 30;
            this.GrauParentesco.Name = "GrauParentesco";
            this.GrauParentesco.ReadOnly = true;
            // 
            // telaAlunoMatriculaVinculo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(179)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.ucDesconectarLogin1);
            this.Controls.Add(this.cmbAluno);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.dgvAlunosVinculados);
            this.Controls.Add(this.ucMenuInferior1);
            this.Controls.Add(this.uMenuImagem1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaAlunoMatriculaVinculo";
            this.Activated += new System.EventHandler(this.telaAlunoMatriculaVinculo_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaAlunoMatriculaVinculo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosVinculados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProviderTela;
        private uMenuImagem uMenuImagem1;
        private ucMenuInferior ucMenuInferior1;
        private System.Windows.Forms.ComboBox cmbAluno;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.DataGridView dgvAlunosVinculados;
        private GuiWindowsForms.User_Control.ucDesconectarLogin ucDesconectarLogin1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrauParentesco;
    }
}