namespace GuiWindowsForms
{
    partial class telaFinanceiro
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
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.lblHelloUsuario = new System.Windows.Forms.Label();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.lblTipo = new System.Windows.Forms.Label();
            this.ckbAtivo = new System.Windows.Forms.CheckBox();
            this.ckbPendente = new System.Windows.Forms.CheckBox();
            this.lbSituacaoAlunos = new System.Windows.Forms.Label();
            this.dtgResultado = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbAtividade = new System.Windows.Forms.CheckBox();
            this.ckbMatricula = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbSim = new System.Windows.Forms.RadioButton();
            this.rdbNao = new System.Windows.Forms.RadioButton();
            this.lblSerie = new System.Windows.Forms.Label();
            this.cmbSerie = new System.Windows.Forms.ComboBox();
            this.pnlFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.BackColor = System.Drawing.Color.Transparent;
            this.btnDesconectar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.icone_desconectar;
            this.btnDesconectar.FlatAppearance.BorderSize = 0;
            this.btnDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconectar.Location = new System.Drawing.Point(950, 9);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(30, 30);
            this.btnDesconectar.TabIndex = 9;
            this.btnDesconectar.UseVisualStyleBackColor = false;
            // 
            // lblHelloUsuario
            // 
            this.lblHelloUsuario.AutoSize = true;
            this.lblHelloUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblHelloUsuario.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblHelloUsuario.ForeColor = System.Drawing.Color.Yellow;
            this.lblHelloUsuario.Location = new System.Drawing.Point(802, 9);
            this.lblHelloUsuario.Name = "lblHelloUsuario";
            this.lblHelloUsuario.Size = new System.Drawing.Size(133, 23);
            this.lblHelloUsuario.TabIndex = 8;
            this.lblHelloUsuario.Text = "Hello Usuário!";
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.BackColor = System.Drawing.Color.Transparent;
            this.pnlFiltro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFiltro.Controls.Add(this.cmbSerie);
            this.pnlFiltro.Controls.Add(this.lblSerie);
            this.pnlFiltro.Controls.Add(this.rdbNao);
            this.pnlFiltro.Controls.Add(this.rdbSim);
            this.pnlFiltro.Controls.Add(this.label1);
            this.pnlFiltro.Controls.Add(this.ckbMatricula);
            this.pnlFiltro.Controls.Add(this.ckbAtividade);
            this.pnlFiltro.Controls.Add(this.label2);
            this.pnlFiltro.Controls.Add(this.lblInicio);
            this.pnlFiltro.Controls.Add(this.lblPeriodo);
            this.pnlFiltro.Controls.Add(this.dateTimePicker2);
            this.pnlFiltro.Controls.Add(this.dateTimePicker1);
            this.pnlFiltro.Controls.Add(this.lblTipo);
            this.pnlFiltro.Controls.Add(this.ckbAtivo);
            this.pnlFiltro.Controls.Add(this.ckbPendente);
            this.pnlFiltro.Controls.Add(this.lbSituacaoAlunos);
            this.pnlFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlFiltro.Location = new System.Drawing.Point(12, 145);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(231, 474);
            this.pnlFiltro.TabIndex = 10;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(-2, 114);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(236, 20);
            this.lblTipo.TabIndex = 21;
            this.lblTipo.Text = "    TIPO DE PAGAMENTOS  ";
            // 
            // ckbAtivo
            // 
            this.ckbAtivo.AutoSize = true;
            this.ckbAtivo.Location = new System.Drawing.Point(21, 316);
            this.ckbAtivo.Name = "ckbAtivo";
            this.ckbAtivo.Size = new System.Drawing.Size(63, 17);
            this.ckbAtivo.TabIndex = 20;
            this.ckbAtivo.Text = "Regular";
            this.ckbAtivo.UseVisualStyleBackColor = true;
            // 
            // ckbPendente
            // 
            this.ckbPendente.AutoSize = true;
            this.ckbPendente.Location = new System.Drawing.Point(96, 316);
            this.ckbPendente.Name = "ckbPendente";
            this.ckbPendente.Size = new System.Drawing.Size(72, 17);
            this.ckbPendente.TabIndex = 18;
            this.ckbPendente.Text = "Pendente";
            this.ckbPendente.UseVisualStyleBackColor = true;
            // 
            // lbSituacaoAlunos
            // 
            this.lbSituacaoAlunos.AutoSize = true;
            this.lbSituacaoAlunos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbSituacaoAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSituacaoAlunos.ForeColor = System.Drawing.Color.White;
            this.lbSituacaoAlunos.Location = new System.Drawing.Point(0, 274);
            this.lbSituacaoAlunos.Name = "lbSituacaoAlunos";
            this.lbSituacaoAlunos.Size = new System.Drawing.Size(229, 20);
            this.lbSituacaoAlunos.TabIndex = 0;
            this.lbSituacaoAlunos.Text = "  SITUAÇÃO DOS ALUNOS";
            // 
            // dtgResultado
            // 
            this.dtgResultado.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResultado.Location = new System.Drawing.Point(249, 250);
            this.dtgResultado.Name = "dtgResultado";
            this.dtgResultado.Size = new System.Drawing.Size(701, 369);
            this.dtgResultado.TabIndex = 11;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(249, 663);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(104, 31);
            this.btnImprimir.TabIndex = 12;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoEllipsis = true;
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.Search_76x76;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Location = new System.Drawing.Point(832, 148);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(74, 75);
            this.btnPesquisar.TabIndex = 14;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtBusca.Location = new System.Drawing.Point(380, 171);
            this.txtBusca.MaxLength = 60;
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(415, 26);
            this.txtBusca.TabIndex = 13;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.voltar_final_32x32;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(39, 681);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(33, 34);
            this.btnVoltar.TabIndex = 16;
            this.btnVoltar.Tag = "Voltar para tela anterior";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(54, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(54, 76);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker2.TabIndex = 23;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.ForeColor = System.Drawing.Color.White;
            this.lblPeriodo.Location = new System.Drawing.Point(-1, 0);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(230, 20);
            this.lblPeriodo.TabIndex = 24;
            this.lblPeriodo.Text = "            PERIODO                ";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(22, 40);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(24, 13);
            this.lblInicio.TabIndex = 25;
            this.lblInicio.Text = "De:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Até:";
            // 
            // ckbAtividade
            // 
            this.ckbAtividade.AutoSize = true;
            this.ckbAtividade.Location = new System.Drawing.Point(20, 151);
            this.ckbAtividade.Name = "ckbAtividade";
            this.ckbAtividade.Size = new System.Drawing.Size(70, 17);
            this.ckbAtividade.TabIndex = 27;
            this.ckbAtividade.Text = "Atividade";
            this.ckbAtividade.UseVisualStyleBackColor = true;
            // 
            // ckbMatricula
            // 
            this.ckbMatricula.AutoSize = true;
            this.ckbMatricula.Location = new System.Drawing.Point(96, 151);
            this.ckbMatricula.Name = "ckbMatricula";
            this.ckbMatricula.Size = new System.Drawing.Size(71, 17);
            this.ckbMatricula.TabIndex = 28;
            this.ckbMatricula.Text = "Matrícula";
            this.ckbMatricula.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "            DESCONTO              ";
            // 
            // rdbSim
            // 
            this.rdbSim.AutoSize = true;
            this.rdbSim.Location = new System.Drawing.Point(17, 383);
            this.rdbSim.Name = "rdbSim";
            this.rdbSim.Size = new System.Drawing.Size(42, 17);
            this.rdbSim.TabIndex = 30;
            this.rdbSim.TabStop = true;
            this.rdbSim.Text = "Sim";
            this.rdbSim.UseVisualStyleBackColor = true;
            // 
            // rdbNao
            // 
            this.rdbNao.AutoSize = true;
            this.rdbNao.Location = new System.Drawing.Point(97, 383);
            this.rdbNao.Name = "rdbNao";
            this.rdbNao.Size = new System.Drawing.Size(45, 17);
            this.rdbNao.TabIndex = 31;
            this.rdbNao.TabStop = true;
            this.rdbNao.Text = "Não";
            this.rdbNao.UseVisualStyleBackColor = true;
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.ForeColor = System.Drawing.Color.White;
            this.lblSerie.Location = new System.Drawing.Point(-2, 182);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(239, 20);
            this.lblSerie.TabIndex = 32;
            this.lblSerie.Text = "               SÉRIE                    ";
            // 
            // cmbSerie
            // 
            this.cmbSerie.FormattingEnabled = true;
            this.cmbSerie.Location = new System.Drawing.Point(21, 230);
            this.cmbSerie.Name = "cmbSerie";
            this.cmbSerie.Size = new System.Drawing.Size(161, 21);
            this.cmbSerie.TabIndex = 33;
            // 
            // telaFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GuiWindowsForms.Properties.Resources.modelo_tela_iconemenor1;
            this.ClientSize = new System.Drawing.Size(994, 716);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dtgResultado);
            this.Controls.Add(this.pnlFiltro);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.lblHelloUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaFinanceiro";
            this.Opacity = 0.8;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Label lblHelloUsuario;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.Label lbSituacaoAlunos;
        private System.Windows.Forms.DataGridView dtgResultado;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.CheckBox ckbAtivo;
        private System.Windows.Forms.CheckBox ckbPendente;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.CheckBox ckbAtividade;
        private System.Windows.Forms.CheckBox ckbMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbNao;
        private System.Windows.Forms.RadioButton rdbSim;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.ComboBox cmbSerie;
    }
}