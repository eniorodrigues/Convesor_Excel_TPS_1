﻿namespace Convesor_Excel_TPS
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCriar = new System.Windows.Forms.Button();
            this.txtCriar = new System.Windows.Forms.TextBox();
            this.chbNova = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxBase = new System.Windows.Forms.ComboBox();
            this.comboBoxServidor = new System.Windows.Forms.ComboBox();
            this.lblTabela = new System.Windows.Forms.Label();
            this.comboBoxTabela = new System.Windows.Forms.ComboBox();
            this.lblPlanilha = new System.Windows.Forms.Label();
            this.cmbPlanilha = new System.Windows.Forms.ComboBox();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.buttonAbrir = new System.Windows.Forms.Button();
            this.tabNova = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.ltbArquivosNova = new System.Windows.Forms.ListBox();
            this.btnImportarSQL = new System.Windows.Forms.Button();
            this.ltbColunas = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabTP = new System.Windows.Forms.TabPage();
            this.dataGridSQL = new System.Windows.Forms.DataGridView();
            this.dataGridExcel = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.lblCarregada = new System.Windows.Forms.Label();
            this.lblPendencia = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblRepetido = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tab = new System.Windows.Forms.TabControl();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabNova.SuspendLayout();
            this.tabTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExcel)).BeginInit();
            this.tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCriar
            // 
            this.btnCriar.Enabled = false;
            this.btnCriar.Location = new System.Drawing.Point(10, 180);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(86, 23);
            this.btnCriar.TabIndex = 4;
            this.btnCriar.Text = "Criar Tabela";
            this.btnCriar.UseVisualStyleBackColor = true;
            // 
            // txtCriar
            // 
            this.txtCriar.Enabled = false;
            this.txtCriar.Location = new System.Drawing.Point(101, 183);
            this.txtCriar.Name = "txtCriar";
            this.txtCriar.Size = new System.Drawing.Size(285, 20);
            this.txtCriar.TabIndex = 76;
            // 
            // chbNova
            // 
            this.chbNova.AutoSize = true;
            this.chbNova.Enabled = false;
            this.chbNova.Location = new System.Drawing.Point(399, 184);
            this.chbNova.Name = "chbNova";
            this.chbNova.Size = new System.Drawing.Size(88, 17);
            this.chbNova.TabIndex = 75;
            this.chbNova.Text = "Nova Tabela";
            this.chbNova.UseVisualStyleBackColor = true;
            this.chbNova.CheckedChanged += new System.EventHandler(this.chbNova_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(524, 22);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(140, 24);
            this.label13.TabIndex = 73;
            this.label13.Text = "CONVERSOR";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Chartreuse;
            this.label12.Location = new System.Drawing.Point(399, 22);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(123, 24);
            this.label12.TabIndex = 71;
            this.label12.Text = "EXCEL/TPS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(791, 54);
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(399, 71);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(389, 18);
            this.label9.TabIndex = 69;
            this.label9.Text = "Origem: Excel ______________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 18);
            this.label3.TabIndex = 68;
            this.label3.Text = "Destino: Base SQL Server _____________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(635, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Total de Linhas:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(715, 136);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 66;
            this.lblTotal.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Base de dados:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Servidor:";
            // 
            // comboBoxBase
            // 
            this.comboBoxBase.Enabled = false;
            this.comboBoxBase.FormattingEnabled = true;
            this.comboBoxBase.Location = new System.Drawing.Point(100, 127);
            this.comboBoxBase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxBase.Name = "comboBoxBase";
            this.comboBoxBase.Size = new System.Drawing.Size(285, 21);
            this.comboBoxBase.Sorted = true;
            this.comboBoxBase.TabIndex = 2;
            this.comboBoxBase.SelectedIndexChanged += new System.EventHandler(this.comboBoxBase_SelectedIndexChanged);
            // 
            // comboBoxServidor
            // 
            this.comboBoxServidor.FormattingEnabled = true;
            this.comboBoxServidor.Location = new System.Drawing.Point(100, 100);
            this.comboBoxServidor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxServidor.Name = "comboBoxServidor";
            this.comboBoxServidor.Size = new System.Drawing.Size(285, 21);
            this.comboBoxServidor.TabIndex = 1;
            this.comboBoxServidor.SelectedIndexChanged += new System.EventHandler(this.comboBoxServidor_SelectedIndexChanged);
            this.comboBoxServidor.Enter += new System.EventHandler(this.comboBoxServidor_Enter);
            // 
            // lblTabela
            // 
            this.lblTabela.AutoSize = true;
            this.lblTabela.Location = new System.Drawing.Point(15, 154);
            this.lblTabela.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(67, 13);
            this.lblTabela.TabIndex = 63;
            this.lblTabela.Text = "Tabela SQL:";
            // 
            // comboBoxTabela
            // 
            this.comboBoxTabela.Enabled = false;
            this.comboBoxTabela.FormattingEnabled = true;
            this.comboBoxTabela.Items.AddRange(new object[] {
            "D_Clientes",
            "D_Compras",
            "D_Custo_Medio",
            "D_Fornecedores",
            "D_Insumo_Produto",
            "D_Inventario_Carga",
            "D_Produtos",
            "D_Relacao_Carga",
            "D_Vendas_Itens",
            "D_PIC"});
            this.comboBoxTabela.Location = new System.Drawing.Point(100, 154);
            this.comboBoxTabela.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTabela.Name = "comboBoxTabela";
            this.comboBoxTabela.Size = new System.Drawing.Size(285, 21);
            this.comboBoxTabela.TabIndex = 6;
            this.comboBoxTabela.SelectedIndexChanged += new System.EventHandler(this.cmbTabela_SelectedIndexChanged);
            // 
            // lblPlanilha
            // 
            this.lblPlanilha.AutoSize = true;
            this.lblPlanilha.Location = new System.Drawing.Point(400, 136);
            this.lblPlanilha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlanilha.Name = "lblPlanilha";
            this.lblPlanilha.Size = new System.Drawing.Size(76, 13);
            this.lblPlanilha.TabIndex = 61;
            this.lblPlanilha.Text = "Planilha Excel:";
            // 
            // cmbPlanilha
            // 
            this.cmbPlanilha.Enabled = false;
            this.cmbPlanilha.FormattingEnabled = true;
            this.cmbPlanilha.Location = new System.Drawing.Point(399, 154);
            this.cmbPlanilha.Name = "cmbPlanilha";
            this.cmbPlanilha.Size = new System.Drawing.Size(361, 21);
            this.cmbPlanilha.TabIndex = 60;
            this.cmbPlanilha.SelectedIndexChanged += new System.EventHandler(this.cmbPlanilha_SelectedIndexChanged);
            // 
            // lblEndereço
            // 
            this.lblEndereço.AutoSize = true;
            this.lblEndereço.Location = new System.Drawing.Point(15, 402);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(0, 13);
            this.lblEndereço.TabIndex = 59;
            // 
            // buttonAbrir
            // 
            this.buttonAbrir.Location = new System.Drawing.Point(399, 100);
            this.buttonAbrir.Name = "buttonAbrir";
            this.buttonAbrir.Size = new System.Drawing.Size(360, 32);
            this.buttonAbrir.TabIndex = 3;
            this.buttonAbrir.Text = "Abrir Excel";
            this.buttonAbrir.UseVisualStyleBackColor = true;
            this.buttonAbrir.Click += new System.EventHandler(this.buttonAbrir_Click);
            // 
            // tabNova
            // 
            this.tabNova.Controls.Add(this.label15);
            this.tabNova.Controls.Add(this.ltbArquivosNova);
            this.tabNova.Controls.Add(this.btnImportarSQL);
            this.tabNova.Controls.Add(this.ltbColunas);
            this.tabNova.Controls.Add(this.label14);
            this.tabNova.Location = new System.Drawing.Point(4, 22);
            this.tabNova.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabNova.Name = "tabNova";
            this.tabNova.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabNova.Size = new System.Drawing.Size(1151, 367);
            this.tabNova.TabIndex = 1;
            this.tabNova.Text = "Nova Tabela";
            this.tabNova.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 59;
            this.label15.Text = "Arquivos";
            // 
            // ltbArquivosNova
            // 
            this.ltbArquivosNova.Enabled = false;
            this.ltbArquivosNova.FormattingEnabled = true;
            this.ltbArquivosNova.Location = new System.Drawing.Point(8, 20);
            this.ltbArquivosNova.Name = "ltbArquivosNova";
            this.ltbArquivosNova.Size = new System.Drawing.Size(272, 147);
            this.ltbArquivosNova.TabIndex = 58;
            // 
            // btnImportarSQL
            // 
            this.btnImportarSQL.Location = new System.Drawing.Point(11, 175);
            this.btnImportarSQL.Name = "btnImportarSQL";
            this.btnImportarSQL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnImportarSQL.Size = new System.Drawing.Size(269, 23);
            this.btnImportarSQL.TabIndex = 55;
            this.btnImportarSQL.Text = "Importar para SQL";
            this.btnImportarSQL.UseVisualStyleBackColor = true;
            // 
            // ltbColunas
            // 
            this.ltbColunas.Enabled = false;
            this.ltbColunas.FormattingEnabled = true;
            this.ltbColunas.Location = new System.Drawing.Point(382, 20);
            this.ltbColunas.Name = "ltbColunas";
            this.ltbColunas.Size = new System.Drawing.Size(298, 147);
            this.ltbColunas.TabIndex = 56;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(380, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 57;
            this.label14.Text = "Colunas";
            // 
            // tabTP
            // 
            this.tabTP.Controls.Add(this.dataGridSQL);
            this.tabTP.Controls.Add(this.dataGridExcel);
            this.tabTP.Controls.Add(this.label10);
            this.tabTP.Controls.Add(this.label1);
            this.tabTP.Controls.Add(this.btnCarregar);
            this.tabTP.Controls.Add(this.lblCarregada);
            this.tabTP.Controls.Add(this.lblPendencia);
            this.tabTP.Controls.Add(this.button1);
            this.tabTP.Controls.Add(this.lblRepetido);
            this.tabTP.Controls.Add(this.progressBar1);
            this.tabTP.Controls.Add(this.label5);
            this.tabTP.Controls.Add(this.label11);
            this.tabTP.Controls.Add(this.label2);
            this.tabTP.Controls.Add(this.label8);
            this.tabTP.Location = new System.Drawing.Point(4, 22);
            this.tabTP.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabTP.Name = "tabTP";
            this.tabTP.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabTP.Size = new System.Drawing.Size(869, 367);
            this.tabTP.TabIndex = 0;
            this.tabTP.Text = "Carregar TP";
            this.tabTP.UseVisualStyleBackColor = true;
            // 
            // dataGridSQL
            // 
            this.dataGridSQL.AllowDrop = true;
            this.dataGridSQL.AllowUserToAddRows = false;
            this.dataGridSQL.AllowUserToDeleteRows = false;
            this.dataGridSQL.AllowUserToResizeColumns = false;
            this.dataGridSQL.AllowUserToResizeRows = false;
            this.dataGridSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSQL.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridSQL.Location = new System.Drawing.Point(615, 12);
            this.dataGridSQL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridSQL.MultiSelect = false;
            this.dataGridSQL.Name = "dataGridSQL";
            this.dataGridSQL.RowHeadersVisible = false;
            this.dataGridSQL.RowHeadersWidth = 51;
            this.dataGridSQL.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridSQL.RowTemplate.Height = 24;
            this.dataGridSQL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridSQL.Size = new System.Drawing.Size(240, 326);
            this.dataGridSQL.TabIndex = 45;
            this.dataGridSQL.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridSQL_DragDrop);
            this.dataGridSQL.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridSQL_DragEnter);
            this.dataGridSQL.DragOver += new System.Windows.Forms.DragEventHandler(this.dataGridSQL_DragOver);
            // 
            // dataGridExcel
            // 
            this.dataGridExcel.AllowDrop = true;
            this.dataGridExcel.AllowUserToAddRows = false;
            this.dataGridExcel.AllowUserToDeleteRows = false;
            this.dataGridExcel.AllowUserToResizeColumns = false;
            this.dataGridExcel.AllowUserToResizeRows = false;
            this.dataGridExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridExcel.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridExcel.Location = new System.Drawing.Point(386, 12);
            this.dataGridExcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridExcel.MultiSelect = false;
            this.dataGridExcel.Name = "dataGridExcel";
            this.dataGridExcel.RowHeadersVisible = false;
            this.dataGridExcel.RowHeadersWidth = 51;
            this.dataGridExcel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridExcel.RowTemplate.Height = 24;
            this.dataGridExcel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridExcel.Size = new System.Drawing.Size(214, 326);
            this.dataGridExcel.TabIndex = 45;
            this.dataGridExcel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridExcel_MouseDown);
            this.dataGridExcel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridExcel_MouseMove);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 12);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(390, 18);
            this.label10.TabIndex = 40;
            this.label10.Text = "Carregamento ______________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 23;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Enabled = false;
            this.btnCarregar.Location = new System.Drawing.Point(3, 39);
            this.btnCarregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(179, 35);
            this.btnCarregar.TabIndex = 27;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // lblCarregada
            // 
            this.lblCarregada.AutoSize = true;
            this.lblCarregada.Location = new System.Drawing.Point(311, 145);
            this.lblCarregada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarregada.Name = "lblCarregada";
            this.lblCarregada.Size = new System.Drawing.Size(13, 13);
            this.lblCarregada.TabIndex = 37;
            this.lblCarregada.Text = "0";
            // 
            // lblPendencia
            // 
            this.lblPendencia.AutoSize = true;
            this.lblPendencia.Location = new System.Drawing.Point(311, 167);
            this.lblPendencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPendencia.Name = "lblPendencia";
            this.lblPendencia.Size = new System.Drawing.Size(13, 13);
            this.lblPendencia.TabIndex = 37;
            this.lblPendencia.Text = "0";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(188, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 36);
            this.button1.TabIndex = 44;
            this.button1.Text = "Gerar Modelo Excel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblRepetido
            // 
            this.lblRepetido.AutoSize = true;
            this.lblRepetido.Location = new System.Drawing.Point(311, 189);
            this.lblRepetido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRepetido.Name = "lblRepetido";
            this.lblRepetido.Size = new System.Drawing.Size(13, 13);
            this.lblRepetido.TabIndex = 37;
            this.lblRepetido.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 80);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(337, 23);
            this.progressBar1.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Linhas Carregadas:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 122);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(394, 18);
            this.label11.TabIndex = 40;
            this.label11.Text = "Status _____________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Pendência de Layout e Conteúdo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 189);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Repetidos:";
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabTP);
            this.tab.Controls.Add(this.tabNova);
            this.tab.Location = new System.Drawing.Point(19, 229);
            this.tab.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(877, 393);
            this.tab.TabIndex = 74;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(682, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 34);
            this.button2.TabIndex = 77;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(528, 202);
            this.button3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 34);
            this.button3.TabIndex = 78;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 620);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.txtCriar);
            this.Controls.Add(this.chbNova);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxBase);
            this.Controls.Add(this.comboBoxServidor);
            this.Controls.Add(this.lblTabela);
            this.Controls.Add(this.comboBoxTabela);
            this.Controls.Add(this.lblPlanilha);
            this.Controls.Add(this.cmbPlanilha);
            this.Controls.Add(this.lblEndereço);
            this.Controls.Add(this.buttonAbrir);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Excel para TPS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabNova.ResumeLayout(false);
            this.tabNova.PerformLayout();
            this.tabTP.ResumeLayout(false);
            this.tabTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExcel)).EndInit();
            this.tab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.TextBox txtCriar;
        private System.Windows.Forms.CheckBox chbNova;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxBase;
        private System.Windows.Forms.ComboBox comboBoxServidor;
        private System.Windows.Forms.Label lblTabela;
        private System.Windows.Forms.ComboBox comboBoxTabela;
        private System.Windows.Forms.Label lblPlanilha;
        private System.Windows.Forms.ComboBox cmbPlanilha;
        private System.Windows.Forms.Label lblEndereço;
        private System.Windows.Forms.Button buttonAbrir;
        private System.Windows.Forms.TabPage tabNova;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox ltbArquivosNova;
        private System.Windows.Forms.Button btnImportarSQL;
        private System.Windows.Forms.ListBox ltbColunas;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabTP;
        private System.Windows.Forms.DataGridView dataGridExcel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Label lblCarregada;
        private System.Windows.Forms.Label lblPendencia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRepetido;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.DataGridView dataGridSQL;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

