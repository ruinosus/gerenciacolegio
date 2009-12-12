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
            this.lblDesconto = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.Button();
            this.btnControledeAcesso = new System.Windows.Forms.Button();
            this.gpbSerie = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gpbSerie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDesconto
            // 
            this.lblDesconto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDesconto.Location = new System.Drawing.Point(847, 266);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(135, 23);
            this.lblDesconto.TabIndex = 64;
            this.lblDesconto.Text = "Desconto de Matrículas";
            this.lblDesconto.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtValor.Location = new System.Drawing.Point(847, 190);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(135, 23);
            this.txtValor.TabIndex = 63;
            this.txtValor.Text = "Série";
            this.txtValor.UseVisualStyleBackColor = true;
            // 
            // btnControledeAcesso
            // 
            this.btnControledeAcesso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControledeAcesso.Location = new System.Drawing.Point(12, 191);
            this.btnControledeAcesso.Name = "btnControledeAcesso";
            this.btnControledeAcesso.Size = new System.Drawing.Size(135, 23);
            this.btnControledeAcesso.TabIndex = 62;
            this.btnControledeAcesso.Text = "Controle de Acesso";
            this.btnControledeAcesso.UseVisualStyleBackColor = true;
            // 
            // gpbSerie
            // 
            this.gpbSerie.BackColor = System.Drawing.Color.Transparent;
            this.gpbSerie.Controls.Add(this.textBox1);
            this.gpbSerie.Controls.Add(this.lblValor);
            this.gpbSerie.Controls.Add(this.txtNome);
            this.gpbSerie.Controls.Add(this.lblNome);
            this.gpbSerie.Controls.Add(this.dataGridView1);
            this.gpbSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSerie.Location = new System.Drawing.Point(153, 129);
            this.gpbSerie.Name = "gpbSerie";
            this.gpbSerie.Size = new System.Drawing.Size(688, 550);
            this.gpbSerie.TabIndex = 65;
            this.gpbSerie.TabStop = false;
            this.gpbSerie.Text = "CADASTRO DE SÉRIE";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 134);
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
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(92, 69);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(249, 20);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(21, 72);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Série:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // telaConfiguracoesDescontoMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GuiWindowsForms.Properties.Resources.modelo_tela_iconemenor;
            this.ClientSize = new System.Drawing.Size(994, 716);
            this.Controls.Add(this.gpbSerie);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnControledeAcesso);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaConfiguracoesDescontoMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            this.gpbSerie.ResumeLayout(false);
            this.gpbSerie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lblDesconto;
        private System.Windows.Forms.Button txtValor;
        private System.Windows.Forms.Button btnControledeAcesso;
        private System.Windows.Forms.GroupBox gpbSerie;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}