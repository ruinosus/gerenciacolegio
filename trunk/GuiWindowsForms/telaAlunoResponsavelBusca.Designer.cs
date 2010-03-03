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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dgvResponsavel = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelecionarResponsavel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsavel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoEllipsis = true;
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.Search_76x76;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Location = new System.Drawing.Point(553, 11);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(74, 75);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtBusca.Location = new System.Drawing.Point(101, 34);
            this.txtBusca.MaxLength = 60;
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(415, 26);
            this.txtBusca.TabIndex = 2;
            // 
            // dgvResponsavel
            // 
            this.dgvResponsavel.AllowUserToAddRows = false;
            this.dgvResponsavel.AllowUserToDeleteRows = false;
            this.dgvResponsavel.BackgroundColor = System.Drawing.Color.White;
            this.dgvResponsavel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResponsavel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Cargo});
            this.dgvResponsavel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvResponsavel.Location = new System.Drawing.Point(45, 92);
            this.dgvResponsavel.MultiSelect = false;
            this.dgvResponsavel.Name = "dgvResponsavel";
            this.dgvResponsavel.ReadOnly = true;
            this.dgvResponsavel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResponsavel.Size = new System.Drawing.Size(638, 249);
            this.dgvResponsavel.TabIndex = 73;
            this.dgvResponsavel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResponsavel_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do Responsável";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 60;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 400;
            // 
            // Cargo
            // 
            this.Cargo.DataPropertyName = "Cpf";
            this.Cargo.HeaderText = "Cpf";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            this.Cargo.Width = 190;
            // 
            // btnSelecionarResponsavel
            // 
            this.btnSelecionarResponsavel.BackColor = System.Drawing.Color.Transparent;
            this.btnSelecionarResponsavel.BackgroundImage = global::GuiWindowsForms.Properties.Resources.ok_32x32_tipo2_final;
            this.btnSelecionarResponsavel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarResponsavel.FlatAppearance.BorderSize = 0;
            this.btnSelecionarResponsavel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarResponsavel.Location = new System.Drawing.Point(649, 347);
            this.btnSelecionarResponsavel.Name = "btnSelecionarResponsavel";
            this.btnSelecionarResponsavel.Size = new System.Drawing.Size(34, 33);
            this.btnSelecionarResponsavel.TabIndex = 74;
            this.btnSelecionarResponsavel.UseVisualStyleBackColor = false;
            this.btnSelecionarResponsavel.Click += new System.EventHandler(this.btnSelecionarResponsavel_Click);
            // 
            // telaAlunoResponsavelBusca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(179)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(729, 384);
            this.Controls.Add(this.btnSelecionarResponsavel);
            this.Controls.Add(this.dgvResponsavel);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtBusca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaAlunoResponsavelBusca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsavel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.DataGridView dgvResponsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.Button btnSelecionarResponsavel;
    }
}