namespace GuiWindowsForms
{
    partial class telaConfiguracoesAtividadeTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaConfiguracoesAtividadeTurma));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbSerie = new System.Windows.Forms.GroupBox();
            this.lblAtividadeTurma = new System.Windows.Forms.Label();
            this.cmbAtividadeTurma = new System.Windows.Forms.ComboBox();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.ckbSabado = new System.Windows.Forms.CheckBox();
            this.cmbFuncionario = new System.Windows.Forms.ComboBox();
            this.ckbSexta = new System.Windows.Forms.CheckBox();
            this.ckbQuinta = new System.Windows.Forms.CheckBox();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.ckbTerca = new System.Windows.Forms.CheckBox();
            this.ckbSegunda = new System.Windows.Forms.CheckBox();
            this.ckbQuarta = new System.Windows.Forms.CheckBox();
            this.ckbDomingo = new System.Windows.Forms.CheckBox();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.lblTurma = new System.Windows.Forms.Label();
            this.dtpHorarioFim = new System.Windows.Forms.DateTimePicker();
            this.lblHorarioFim = new System.Windows.Forms.Label();
            this.dtpHorarioInicio = new System.Windows.Forms.DateTimePicker();
            this.lblHorarioInicio = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProviderTela = new System.Windows.Forms.ErrorProvider(this.components);
            this.ucDesconectarLogin1 = new GuiWindowsForms.User_Control.ucDesconectarLogin();
            this.ucMenuInferior1 = new GuiWindowsForms.ucMenuInferior();
            this.Atividade_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionario_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFim_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turma_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundaAuxTurma2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TercaAuxTurma2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QuartaAuxTurma2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QuintaAuxTurma2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SextaAuxTurma2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SabadoAuxTurma2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DomingoAuxTurma2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbSerie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTela)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GuiWindowsForms.Properties.Resources.simbolo_colegio;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 112);
            this.pictureBox1.TabIndex = 145;
            this.pictureBox1.TabStop = false;
            // 
            // gpbSerie
            // 
            this.gpbSerie.BackColor = System.Drawing.Color.Transparent;
            this.gpbSerie.Controls.Add(this.lblAtividadeTurma);
            this.gpbSerie.Controls.Add(this.cmbAtividadeTurma);
            this.gpbSerie.Controls.Add(this.lblNomeFuncionario);
            this.gpbSerie.Controls.Add(this.ckbSabado);
            this.gpbSerie.Controls.Add(this.cmbFuncionario);
            this.gpbSerie.Controls.Add(this.ckbSexta);
            this.gpbSerie.Controls.Add(this.ckbQuinta);
            this.gpbSerie.Controls.Add(this.lblDiaSemana);
            this.gpbSerie.Controls.Add(this.ckbTerca);
            this.gpbSerie.Controls.Add(this.ckbSegunda);
            this.gpbSerie.Controls.Add(this.ckbQuarta);
            this.gpbSerie.Controls.Add(this.ckbDomingo);
            this.gpbSerie.Controls.Add(this.txtTurma);
            this.gpbSerie.Controls.Add(this.lblTurma);
            this.gpbSerie.Controls.Add(this.dtpHorarioFim);
            this.gpbSerie.Controls.Add(this.lblHorarioFim);
            this.gpbSerie.Controls.Add(this.dtpHorarioInicio);
            this.gpbSerie.Controls.Add(this.lblHorarioInicio);
            this.gpbSerie.Controls.Add(this.txtValor);
            this.gpbSerie.Controls.Add(this.lblValor);
            this.gpbSerie.Controls.Add(this.btnAlterar);
            this.gpbSerie.Controls.Add(this.btnAdicionar);
            this.gpbSerie.Controls.Add(this.btnExcluir);
            this.gpbSerie.Controls.Add(this.dataGridView1);
            this.gpbSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSerie.Location = new System.Drawing.Point(39, 129);
            this.gpbSerie.Name = "gpbSerie";
            this.gpbSerie.Size = new System.Drawing.Size(915, 502);
            this.gpbSerie.TabIndex = 147;
            this.gpbSerie.TabStop = false;
            this.gpbSerie.Text = "CADASTRAR TURMA - ATIVIDADE";
            // 
            // lblAtividadeTurma
            // 
            this.lblAtividadeTurma.AutoSize = true;
            this.lblAtividadeTurma.ForeColor = System.Drawing.Color.Black;
            this.lblAtividadeTurma.Location = new System.Drawing.Point(30, 63);
            this.lblAtividadeTurma.Name = "lblAtividadeTurma";
            this.lblAtividadeTurma.Size = new System.Drawing.Size(64, 13);
            this.lblAtividadeTurma.TabIndex = 153;
            this.lblAtividadeTurma.Text = "Atividade:";
            // 
            // cmbAtividadeTurma
            // 
            this.cmbAtividadeTurma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAtividadeTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAtividadeTurma.Enabled = false;
            this.cmbAtividadeTurma.FormattingEnabled = true;
            this.cmbAtividadeTurma.Location = new System.Drawing.Point(147, 63);
            this.cmbAtividadeTurma.Name = "cmbAtividadeTurma";
            this.cmbAtividadeTurma.Size = new System.Drawing.Size(300, 21);
            this.cmbAtividadeTurma.TabIndex = 135;
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.ForeColor = System.Drawing.Color.Black;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(30, 30);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(64, 13);
            this.lblNomeFuncionario.TabIndex = 152;
            this.lblNomeFuncionario.Text = "Professor:";
            // 
            // ckbSabado
            // 
            this.ckbSabado.AutoSize = true;
            this.ckbSabado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbSabado.Enabled = false;
            this.ckbSabado.ForeColor = System.Drawing.Color.Black;
            this.ckbSabado.Location = new System.Drawing.Point(582, 97);
            this.ckbSabado.Name = "ckbSabado";
            this.ckbSabado.Size = new System.Drawing.Size(69, 17);
            this.ckbSabado.TabIndex = 146;
            this.ckbSabado.Text = "Sábado";
            this.ckbSabado.UseVisualStyleBackColor = true;
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncionario.Enabled = false;
            this.cmbFuncionario.FormattingEnabled = true;
            this.cmbFuncionario.Location = new System.Drawing.Point(147, 30);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(300, 21);
            this.cmbFuncionario.TabIndex = 134;
            // 
            // ckbSexta
            // 
            this.ckbSexta.AutoSize = true;
            this.ckbSexta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbSexta.Enabled = false;
            this.ckbSexta.ForeColor = System.Drawing.Color.Black;
            this.ckbSexta.Location = new System.Drawing.Point(745, 67);
            this.ckbSexta.Name = "ckbSexta";
            this.ckbSexta.Size = new System.Drawing.Size(58, 17);
            this.ckbSexta.TabIndex = 145;
            this.ckbSexta.Text = "Sexta";
            this.ckbSexta.UseVisualStyleBackColor = true;
            // 
            // ckbQuinta
            // 
            this.ckbQuinta.AutoSize = true;
            this.ckbQuinta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbQuinta.Enabled = false;
            this.ckbQuinta.ForeColor = System.Drawing.Color.Black;
            this.ckbQuinta.Location = new System.Drawing.Point(663, 67);
            this.ckbQuinta.Name = "ckbQuinta";
            this.ckbQuinta.Size = new System.Drawing.Size(60, 17);
            this.ckbQuinta.TabIndex = 144;
            this.ckbQuinta.Text = "Quirta";
            this.ckbQuinta.UseVisualStyleBackColor = true;
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.BackColor = System.Drawing.Color.Transparent;
            this.lblDiaSemana.ForeColor = System.Drawing.Color.Black;
            this.lblDiaSemana.Location = new System.Drawing.Point(472, 30);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(97, 13);
            this.lblDiaSemana.TabIndex = 151;
            this.lblDiaSemana.Text = "Dia da Semana:";
            // 
            // ckbTerca
            // 
            this.ckbTerca.AutoSize = true;
            this.ckbTerca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTerca.Enabled = false;
            this.ckbTerca.ForeColor = System.Drawing.Color.Black;
            this.ckbTerca.Location = new System.Drawing.Point(745, 34);
            this.ckbTerca.Name = "ckbTerca";
            this.ckbTerca.Size = new System.Drawing.Size(59, 17);
            this.ckbTerca.TabIndex = 142;
            this.ckbTerca.Text = "Terça";
            this.ckbTerca.UseVisualStyleBackColor = true;
            // 
            // ckbSegunda
            // 
            this.ckbSegunda.AutoSize = true;
            this.ckbSegunda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbSegunda.Enabled = false;
            this.ckbSegunda.ForeColor = System.Drawing.Color.Black;
            this.ckbSegunda.Location = new System.Drawing.Point(663, 33);
            this.ckbSegunda.Name = "ckbSegunda";
            this.ckbSegunda.Size = new System.Drawing.Size(76, 17);
            this.ckbSegunda.TabIndex = 141;
            this.ckbSegunda.Text = "Segunda";
            this.ckbSegunda.UseVisualStyleBackColor = true;
            // 
            // ckbQuarta
            // 
            this.ckbQuarta.AutoSize = true;
            this.ckbQuarta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbQuarta.Enabled = false;
            this.ckbQuarta.ForeColor = System.Drawing.Color.Black;
            this.ckbQuarta.Location = new System.Drawing.Point(582, 65);
            this.ckbQuarta.Name = "ckbQuarta";
            this.ckbQuarta.Size = new System.Drawing.Size(64, 17);
            this.ckbQuarta.TabIndex = 143;
            this.ckbQuarta.Text = "Quarta";
            this.ckbQuarta.UseVisualStyleBackColor = true;
            // 
            // ckbDomingo
            // 
            this.ckbDomingo.AutoSize = true;
            this.ckbDomingo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbDomingo.Enabled = false;
            this.ckbDomingo.ForeColor = System.Drawing.Color.Black;
            this.ckbDomingo.Location = new System.Drawing.Point(582, 33);
            this.ckbDomingo.Name = "ckbDomingo";
            this.ckbDomingo.Size = new System.Drawing.Size(75, 17);
            this.ckbDomingo.TabIndex = 140;
            this.ckbDomingo.Text = "Domingo";
            this.ckbDomingo.UseVisualStyleBackColor = true;
            // 
            // txtTurma
            // 
            this.txtTurma.Enabled = false;
            this.txtTurma.Location = new System.Drawing.Point(147, 97);
            this.txtTurma.MaxLength = 10;
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(112, 20);
            this.txtTurma.TabIndex = 136;
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.BackColor = System.Drawing.Color.Transparent;
            this.lblTurma.ForeColor = System.Drawing.Color.Black;
            this.lblTurma.Location = new System.Drawing.Point(30, 97);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(46, 13);
            this.lblTurma.TabIndex = 150;
            this.lblTurma.Text = "Turma:";
            // 
            // dtpHorarioFim
            // 
            this.dtpHorarioFim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpHorarioFim.Enabled = false;
            this.dtpHorarioFim.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioFim.Location = new System.Drawing.Point(365, 134);
            this.dtpHorarioFim.Name = "dtpHorarioFim";
            this.dtpHorarioFim.ShowUpDown = true;
            this.dtpHorarioFim.Size = new System.Drawing.Size(82, 20);
            this.dtpHorarioFim.TabIndex = 138;
            // 
            // lblHorarioFim
            // 
            this.lblHorarioFim.AutoSize = true;
            this.lblHorarioFim.ForeColor = System.Drawing.Color.Black;
            this.lblHorarioFim.Location = new System.Drawing.Point(283, 134);
            this.lblHorarioFim.Name = "lblHorarioFim";
            this.lblHorarioFim.Size = new System.Drawing.Size(75, 13);
            this.lblHorarioFim.TabIndex = 149;
            this.lblHorarioFim.Text = "Horário Fim:";
            // 
            // dtpHorarioInicio
            // 
            this.dtpHorarioInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpHorarioInicio.Enabled = false;
            this.dtpHorarioInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioInicio.Location = new System.Drawing.Point(147, 134);
            this.dtpHorarioInicio.Name = "dtpHorarioInicio";
            this.dtpHorarioInicio.ShowUpDown = true;
            this.dtpHorarioInicio.Size = new System.Drawing.Size(82, 20);
            this.dtpHorarioInicio.TabIndex = 137;
            // 
            // lblHorarioInicio
            // 
            this.lblHorarioInicio.AutoSize = true;
            this.lblHorarioInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblHorarioInicio.ForeColor = System.Drawing.Color.Black;
            this.lblHorarioInicio.Location = new System.Drawing.Point(29, 134);
            this.lblHorarioInicio.Name = "lblHorarioInicio";
            this.lblHorarioInicio.Size = new System.Drawing.Size(89, 13);
            this.lblHorarioInicio.TabIndex = 148;
            this.lblHorarioInicio.Text = "Horário Início:";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(147, 169);
            this.txtValor.MaxLength = 10;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(112, 20);
            this.txtValor.TabIndex = 139;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.ForeColor = System.Drawing.Color.Black;
            this.lblValor.Location = new System.Drawing.Point(29, 169);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(68, 13);
            this.lblValor.TabIndex = 147;
            this.lblValor.Text = "Valor (R$):";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.alterar_final;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Location = new System.Drawing.Point(749, 162);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(32, 32);
            this.btnAlterar.TabIndex = 0;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.MouseLeave += new System.EventHandler(this.btnAlterar_MouseLeave);
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            this.btnAlterar.MouseEnter += new System.EventHandler(this.btnAlterar_MouseEnter);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_mais;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Location = new System.Drawing.Point(808, 162);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(32, 32);
            this.btnAdicionar.TabIndex = 70;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.MouseLeave += new System.EventHandler(this.btnAdicionarAtividade_MouseLeave);
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            this.btnAdicionar.MouseEnter += new System.EventHandler(this.btnAdicionarAtividade_MouseEnter);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::GuiWindowsForms.Properties.Resources.conf_menos;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(861, 183);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(32, 11);
            this.btnExcluir.TabIndex = 69;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.MouseLeave += new System.EventHandler(this.btnExcluirAtividade_MouseLeave);
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            this.btnExcluir.MouseEnter += new System.EventHandler(this.btnExcluirAtividade_MouseEnter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Atividade_grid,
            this.Funcionario_grid,
            this.HoraInicio_grid,
            this.HoraFim_grid,
            this.Valor_grid,
            this.Turma_grid,
            this.SegundaAuxTurma2,
            this.TercaAuxTurma2,
            this.QuartaAuxTurma2,
            this.QuintaAuxTurma2,
            this.SextaAuxTurma2,
            this.SabadoAuxTurma2,
            this.DomingoAuxTurma2});
            this.dataGridView1.Location = new System.Drawing.Point(24, 200);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(869, 285);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.MouseLeave += new System.EventHandler(this.dataGridView1_MouseLeave);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.MouseEnter += new System.EventHandler(this.dataGridView1_MouseEnter);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // errorProviderTela
            // 
            this.errorProviderTela.ContainerControl = this;
            // 
            // ucDesconectarLogin1
            // 
            this.ucDesconectarLogin1.BackColor = System.Drawing.Color.Transparent;
            this.ucDesconectarLogin1.Location = new System.Drawing.Point(738, 0);
            this.ucDesconectarLogin1.Name = "ucDesconectarLogin1";
            this.ucDesconectarLogin1.Size = new System.Drawing.Size(253, 39);
            this.ucDesconectarLogin1.TabIndex = 146;
            this.ucDesconectarLogin1.EventoDesconectar += new GuiWindowsForms.User_Control.ucDesconectarLogin.delegateDesconectar(this.ucDesconectarLogin1_EventoDesconectar);
            // 
            // ucMenuInferior1
            // 
            this.ucMenuInferior1.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuInferior1.Location = new System.Drawing.Point(39, 637);
            this.ucMenuInferior1.Name = "ucMenuInferior1";
            this.ucMenuInferior1.Size = new System.Drawing.Size(760, 43);
            this.ucMenuInferior1.TabIndex = 142;
            this.ucMenuInferior1.EventoCadastrar += new GuiWindowsForms.ucMenuInferior.delegateCadastrar(this.ucMenuInferior1_EventoCadastrar);
            this.ucMenuInferior1.EventoVoltar += new GuiWindowsForms.ucMenuInferior.delegateVoltar(this.ucMenuInferior1_EventoVoltar);
            // 
            // Atividade_grid
            // 
            this.Atividade_grid.DataPropertyName = "AtividadeAuxTurma2";
            this.Atividade_grid.HeaderText = "Atividade";
            this.Atividade_grid.MaxInputLength = 30;
            this.Atividade_grid.Name = "Atividade_grid";
            this.Atividade_grid.ReadOnly = true;
            this.Atividade_grid.Width = 250;
            // 
            // Funcionario_grid
            // 
            this.Funcionario_grid.DataPropertyName = "FuncionarioAuxTurma2";
            this.Funcionario_grid.HeaderText = "Funcionário";
            this.Funcionario_grid.MaxInputLength = 40;
            this.Funcionario_grid.Name = "Funcionario_grid";
            this.Funcionario_grid.ReadOnly = true;
            this.Funcionario_grid.Width = 200;
            // 
            // HoraInicio_grid
            // 
            this.HoraInicio_grid.DataPropertyName = "HoraInicioAuxTurma2";
            this.HoraInicio_grid.HeaderText = "Hora Inicio";
            this.HoraInicio_grid.Name = "HoraInicio_grid";
            this.HoraInicio_grid.ReadOnly = true;
            // 
            // HoraFim_grid
            // 
            this.HoraFim_grid.DataPropertyName = "HoraFimAuxTurma2";
            this.HoraFim_grid.HeaderText = "Hora Fim";
            this.HoraFim_grid.Name = "HoraFim_grid";
            this.HoraFim_grid.ReadOnly = true;
            // 
            // Valor_grid
            // 
            this.Valor_grid.DataPropertyName = "ValorAuxTurma2";
            this.Valor_grid.HeaderText = "Valor";
            this.Valor_grid.Name = "Valor_grid";
            this.Valor_grid.ReadOnly = true;
            // 
            // Turma_grid
            // 
            this.Turma_grid.DataPropertyName = "TurmaAuxTurma2";
            this.Turma_grid.HeaderText = "Turma";
            this.Turma_grid.Name = "Turma_grid";
            this.Turma_grid.ReadOnly = true;
            // 
            // SegundaAuxTurma2
            // 
            this.SegundaAuxTurma2.DataPropertyName = "SegundaAuxTurma2";
            this.SegundaAuxTurma2.HeaderText = "Seg";
            this.SegundaAuxTurma2.Name = "SegundaAuxTurma2";
            this.SegundaAuxTurma2.ValueType = System.Type.GetType("System.Boolean"); 
            this.SegundaAuxTurma2.ReadOnly = true;
            // 
            // TercaAuxTurma2
            // 
            this.TercaAuxTurma2.DataPropertyName = "TercaAuxTurma2";
            this.TercaAuxTurma2.HeaderText = "Ter";
            this.TercaAuxTurma2.Name = "TercaAuxTurma2";
            this.TercaAuxTurma2.ValueType = System.Type.GetType("System.Boolean"); 
            this.TercaAuxTurma2.ReadOnly = true;
            // 
            // QuartaAuxTurma2
            // 
            this.QuartaAuxTurma2.DataPropertyName = "QuartaAuxTurma2";
            this.QuartaAuxTurma2.HeaderText = "Qua";
            this.QuartaAuxTurma2.Name = "QuartaAuxTurma2";
            this.QuartaAuxTurma2.ValueType = System.Type.GetType("System.Boolean"); 
            this.QuartaAuxTurma2.ReadOnly = true;
            // 
            // QuintaAuxTurma2
            // 
            this.QuintaAuxTurma2.DataPropertyName = "QuintaAuxTurma2";
            this.QuintaAuxTurma2.HeaderText = "Qui";
            this.QuintaAuxTurma2.Name = "QuintaAuxTurma2";
            this.QuintaAuxTurma2.ValueType = System.Type.GetType("System.Boolean"); 
            this.QuintaAuxTurma2.ReadOnly = true;
            // 
            // SextaAuxTurma2
            // 
            this.SextaAuxTurma2.DataPropertyName = "SextaAuxTurma2";
            this.SextaAuxTurma2.HeaderText = "Sex";
            this.SextaAuxTurma2.Name = "SextaAuxTurma2";
            this.SextaAuxTurma2.ValueType = System.Type.GetType("System.Boolean"); 
            this.SextaAuxTurma2.ReadOnly = true;
            // 
            // SabadoAuxTurma2
            // 
            this.SabadoAuxTurma2.DataPropertyName = "SabadoAuxTurma2";
            this.SabadoAuxTurma2.HeaderText = "Sab";
            this.SabadoAuxTurma2.Name = "SabadoAuxTurma2";
            this.SabadoAuxTurma2.ValueType = System.Type.GetType("System.Boolean"); 
            this.SabadoAuxTurma2.ReadOnly = true;
            // 
            // DomingoAuxTurma2
            // 
            this.DomingoAuxTurma2.DataPropertyName = "DomingoAuxTurma2";
            this.DomingoAuxTurma2.HeaderText = "Dom";
            this.DomingoAuxTurma2.Name = "DomingoAuxTurma2";
            this.DomingoAuxTurma2.ValueType = System.Type.GetType("System.Boolean"); 
            this.DomingoAuxTurma2.ReadOnly = true;
            // 
            // telaConfiguracoesAtividadeTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(179)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(990, 680);
            this.Controls.Add(this.gpbSerie);
            this.Controls.Add(this.ucDesconectarLogin1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ucMenuInferior1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaConfiguracoesAtividadeTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colégio Conhecer - Educação Infantil ao Ensino Médio";
            this.Activated += new System.EventHandler(this.telaConfiguracoesAtividadeTurma_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbSerie.ResumeLayout(false);
            this.gpbSerie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GuiWindowsForms.User_Control.ucDesconectarLogin ucDesconectarLogin1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ucMenuInferior ucMenuInferior1;
        private System.Windows.Forms.GroupBox gpbSerie;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAtividadeTurma;
        private System.Windows.Forms.ComboBox cmbAtividadeTurma;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.CheckBox ckbSabado;
        private System.Windows.Forms.ComboBox cmbFuncionario;
        private System.Windows.Forms.CheckBox ckbSexta;
        private System.Windows.Forms.CheckBox ckbQuinta;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.CheckBox ckbTerca;
        private System.Windows.Forms.CheckBox ckbSegunda;
        private System.Windows.Forms.CheckBox ckbQuarta;
        private System.Windows.Forms.CheckBox ckbDomingo;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.DateTimePicker dtpHorarioFim;
        private System.Windows.Forms.Label lblHorarioFim;
        private System.Windows.Forms.DateTimePicker dtpHorarioInicio;
        private System.Windows.Forms.Label lblHorarioInicio;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ErrorProvider errorProviderTela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atividade_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionario_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFim_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turma_grid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SegundaAuxTurma2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TercaAuxTurma2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn QuartaAuxTurma2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn QuintaAuxTurma2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SextaAuxTurma2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SabadoAuxTurma2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DomingoAuxTurma2;
    }
}