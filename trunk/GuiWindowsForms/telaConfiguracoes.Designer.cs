namespace GuiWindowsForms
{
    partial class gpbControleDeAcesso
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
            this.btnControledeAcesso = new System.Windows.Forms.Button();
            this.lblHelloUsuario = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSerie = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.lblDesconto = new System.Windows.Forms.Button();
            this.btnAtividades = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnControledeAcesso
            // 
            this.btnControledeAcesso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControledeAcesso.Location = new System.Drawing.Point(12, 191);
            this.btnControledeAcesso.Name = "btnControledeAcesso";
            this.btnControledeAcesso.Size = new System.Drawing.Size(135, 23);
            this.btnControledeAcesso.TabIndex = 0;
            this.btnControledeAcesso.Text = "Controle de Acesso";
            this.btnControledeAcesso.UseVisualStyleBackColor = true;
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
            this.lblHelloUsuario.TabIndex = 48;
            this.lblHelloUsuario.Text = "Hello Usuário!";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.voltar_final_32x32;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(27, 677);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(28, 34);
            this.btnVoltar.TabIndex = 50;
            this.btnVoltar.Tag = "";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // btnSerie
            // 
            this.btnSerie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSerie.Location = new System.Drawing.Point(847, 190);
            this.btnSerie.Name = "btnSerie";
            this.btnSerie.Size = new System.Drawing.Size(135, 23);
            this.btnSerie.TabIndex = 54;
            this.btnSerie.Text = "Série";
            this.btnSerie.UseVisualStyleBackColor = true;
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
            this.btnDesconectar.TabIndex = 55;
            this.btnDesconectar.Tag = "";
            this.btnDesconectar.UseVisualStyleBackColor = false;
            // 
            // lblDesconto
            // 
            this.lblDesconto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDesconto.Location = new System.Drawing.Point(847, 266);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(135, 23);
            this.lblDesconto.TabIndex = 65;
            this.lblDesconto.Text = "Desconto de Matrículas";
            this.lblDesconto.UseVisualStyleBackColor = true;
            // 
            // btnAtividades
            // 
            this.btnAtividades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtividades.Location = new System.Drawing.Point(847, 343);
            this.btnAtividades.Name = "btnAtividades";
            this.btnAtividades.Size = new System.Drawing.Size(135, 23);
            this.btnAtividades.TabIndex = 86;
            this.btnAtividades.Text = "Atividades";
            this.btnAtividades.UseVisualStyleBackColor = true;
            // 
            // gpbControleDeAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GuiWindowsForms.Properties.Resources.modelo_tela_iconemenor1;
            this.ClientSize = new System.Drawing.Size(1000, 722);
            this.Controls.Add(this.btnAtividades);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnSerie);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblHelloUsuario);
            this.Controls.Add(this.btnControledeAcesso);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "gpbControleDeAcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnControledeAcesso;
        private System.Windows.Forms.Label lblHelloUsuario;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSerie;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button lblDesconto;
        private System.Windows.Forms.Button btnAtividades;
    }
}