﻿namespace TintSysDesk
{
    partial class FrmCliente
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtidCliente = new System.Windows.Forms.TextBox();
            this.mktCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbTipoEndereco = new System.Windows.Forms.ComboBox();
            this.mskCepCliente = new System.Windows.Forms.MaskedTextBox();
            this.btnAdicionarOutrosEnderecos = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNumeroCliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtComplementoCliente = new System.Windows.Forms.TextBox();
            this.txtUfCliente = new System.Windows.Forms.TextBox();
            this.txtEstadoCliente = new System.Windows.Forms.TextBox();
            this.txtBairroCliente = new System.Windows.Forms.TextBox();
            this.txtLogradouroCliente = new System.Windows.Forms.TextBox();
            this.txtCidadeCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tpgTelefones = new System.Windows.Forms.TabPage();
            this.cmbTipoTelefone = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.mskNumeroTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dgvEnderecos = new System.Windows.Forms.DataGridView();
            this.btnInserirEndereco = new System.Windows.Forms.Button();
            this.btnEditarEndereco = new System.Windows.Forms.Button();
            this.btnInserirCliente = new System.Windows.Forms.Button();
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.btnEdiatrCliente = new System.Windows.Forms.Button();
            this.btnInserirTelefone = new System.Windows.Forms.Button();
            this.btnEditarTelefone = new System.Windows.Forms.Button();
            this.dgvTelefone = new System.Windows.Forms.DataGridView();
            this.clnTipoDeTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLLNumeroTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnclientetelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cluNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTiipoEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tpgTelefones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tpgTelefones);
            this.tabControl1.Location = new System.Drawing.Point(33, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1340, 592);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEdiatrCliente);
            this.tabPage1.Controls.Add(this.btnConsultarCliente);
            this.tabPage1.Controls.Add(this.btnInserirCliente);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.txtidCliente);
            this.tabPage1.Controls.Add(this.mktCpf);
            this.tabPage1.Controls.Add(this.txtNomeCliente);
            this.tabPage1.Controls.Add(this.txtEmailCliente);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1332, 563);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Básicos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TintSysDesk.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(541, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(212, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 21);
            this.label18.TabIndex = 28;
            this.label18.Text = "ID DO CLIENTE :";
            // 
            // txtidCliente
            // 
            this.txtidCliente.Location = new System.Drawing.Point(216, 60);
            this.txtidCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtidCliente.Name = "txtidCliente";
            this.txtidCliente.Size = new System.Drawing.Size(127, 22);
            this.txtidCliente.TabIndex = 29;
            // 
            // mktCpf
            // 
            this.mktCpf.Location = new System.Drawing.Point(19, 60);
            this.mktCpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mktCpf.Mask = "000.000.000--00";
            this.mktCpf.Name = "mktCpf";
            this.mktCpf.Size = new System.Drawing.Size(117, 22);
            this.mktCpf.TabIndex = 23;
            this.mktCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(17, 135);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(352, 22);
            this.txtNomeCliente.TabIndex = 26;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(17, 199);
            this.txtEmailCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(352, 22);
            this.txtEmailCliente.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nome do Cliente :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "E-mail :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "CPF :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEditarEndereco);
            this.tabPage2.Controls.Add(this.btnInserirEndereco);
            this.tabPage2.Controls.Add(this.dgvEnderecos);
            this.tabPage2.Controls.Add(this.cmbTipoEndereco);
            this.tabPage2.Controls.Add(this.mskCepCliente);
            this.tabPage2.Controls.Add(this.btnAdicionarOutrosEnderecos);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txtNumeroCliente);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtComplementoCliente);
            this.tabPage2.Controls.Add(this.txtUfCliente);
            this.tabPage2.Controls.Add(this.txtEstadoCliente);
            this.tabPage2.Controls.Add(this.txtBairroCliente);
            this.tabPage2.Controls.Add(this.txtLogradouroCliente);
            this.tabPage2.Controls.Add(this.txtCidadeCliente);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1332, 563);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Endereço";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbTipoEndereco
            // 
            this.cmbTipoEndereco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEndereco.FormattingEnabled = true;
            this.cmbTipoEndereco.Items.AddRange(new object[] {
            "Comercial",
            "Residêncial"});
            this.cmbTipoEndereco.Location = new System.Drawing.Point(10, 224);
            this.cmbTipoEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoEndereco.Name = "cmbTipoEndereco";
            this.cmbTipoEndereco.Size = new System.Drawing.Size(160, 24);
            this.cmbTipoEndereco.TabIndex = 46;
            // 
            // mskCepCliente
            // 
            this.mskCepCliente.Location = new System.Drawing.Point(6, 93);
            this.mskCepCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskCepCliente.Mask = "000.00-000";
            this.mskCepCliente.Name = "mskCepCliente";
            this.mskCepCliente.Size = new System.Drawing.Size(87, 22);
            this.mskCepCliente.TabIndex = 45;
            this.mskCepCliente.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnAdicionarOutrosEnderecos
            // 
            this.btnAdicionarOutrosEnderecos.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarOutrosEnderecos.Location = new System.Drawing.Point(192, 212);
            this.btnAdicionarOutrosEnderecos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdicionarOutrosEnderecos.Name = "btnAdicionarOutrosEnderecos";
            this.btnAdicionarOutrosEnderecos.Size = new System.Drawing.Size(261, 36);
            this.btnAdicionarOutrosEnderecos.TabIndex = 44;
            this.btnAdicionarOutrosEnderecos.Text = "ADICIONAR OUTROS ENDEREÇOS";
            this.btnAdicionarOutrosEnderecos.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 21);
            this.label14.TabIndex = 30;
            this.label14.Text = "TIPO DE ENDEREÇO";
            // 
            // txtNumeroCliente
            // 
            this.txtNumeroCliente.Location = new System.Drawing.Point(574, 93);
            this.txtNumeroCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroCliente.Name = "txtNumeroCliente";
            this.txtNumeroCliente.Size = new System.Drawing.Size(167, 22);
            this.txtNumeroCliente.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(295, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 21);
            this.label11.TabIndex = 32;
            this.label11.Text = "CIDADE : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(650, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 21);
            this.label12.TabIndex = 33;
            this.label12.Text = "ESTADO : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 21);
            this.label10.TabIndex = 34;
            this.label10.Text = "BAIRRO : ";
            // 
            // txtComplementoCliente
            // 
            this.txtComplementoCliente.Location = new System.Drawing.Point(760, 93);
            this.txtComplementoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComplementoCliente.Name = "txtComplementoCliente";
            this.txtComplementoCliente.Size = new System.Drawing.Size(335, 22);
            this.txtComplementoCliente.TabIndex = 41;
            // 
            // txtUfCliente
            // 
            this.txtUfCliente.Location = new System.Drawing.Point(884, 151);
            this.txtUfCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUfCliente.Name = "txtUfCliente";
            this.txtUfCliente.Size = new System.Drawing.Size(211, 22);
            this.txtUfCliente.TabIndex = 39;
            // 
            // txtEstadoCliente
            // 
            this.txtEstadoCliente.Location = new System.Drawing.Point(654, 151);
            this.txtEstadoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEstadoCliente.Name = "txtEstadoCliente";
            this.txtEstadoCliente.Size = new System.Drawing.Size(211, 22);
            this.txtEstadoCliente.TabIndex = 43;
            // 
            // txtBairroCliente
            // 
            this.txtBairroCliente.Location = new System.Drawing.Point(10, 151);
            this.txtBairroCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBairroCliente.Name = "txtBairroCliente";
            this.txtBairroCliente.Size = new System.Drawing.Size(277, 22);
            this.txtBairroCliente.TabIndex = 38;
            // 
            // txtLogradouroCliente
            // 
            this.txtLogradouroCliente.Location = new System.Drawing.Point(163, 93);
            this.txtLogradouroCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLogradouroCliente.Name = "txtLogradouroCliente";
            this.txtLogradouroCliente.Size = new System.Drawing.Size(391, 22);
            this.txtLogradouroCliente.TabIndex = 37;
            // 
            // txtCidadeCliente
            // 
            this.txtCidadeCliente.Location = new System.Drawing.Point(299, 151);
            this.txtCidadeCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCidadeCliente.Name = "txtCidadeCliente";
            this.txtCidadeCliente.Size = new System.Drawing.Size(335, 22);
            this.txtCidadeCliente.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(568, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 21);
            this.label8.TabIndex = 31;
            this.label8.Text = "NÚMERO : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(880, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 21);
            this.label13.TabIndex = 28;
            this.label13.Text = "UF :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(758, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 21);
            this.label9.TabIndex = 27;
            this.label9.Text = "COMPLEMENTO :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(159, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 21);
            this.label7.TabIndex = 35;
            this.label7.Text = "LOGRADOURO :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "CEP : ";
            // 
            // tpgTelefones
            // 
            this.tpgTelefones.Controls.Add(this.dgvTelefone);
            this.tpgTelefones.Controls.Add(this.btnEditarTelefone);
            this.tpgTelefones.Controls.Add(this.btnInserirTelefone);
            this.tpgTelefones.Controls.Add(this.mskNumeroTelefone);
            this.tpgTelefones.Controls.Add(this.cmbTipoTelefone);
            this.tpgTelefones.Controls.Add(this.label17);
            this.tpgTelefones.Controls.Add(this.label16);
            this.tpgTelefones.Location = new System.Drawing.Point(4, 25);
            this.tpgTelefones.Margin = new System.Windows.Forms.Padding(4);
            this.tpgTelefones.Name = "tpgTelefones";
            this.tpgTelefones.Padding = new System.Windows.Forms.Padding(4);
            this.tpgTelefones.Size = new System.Drawing.Size(1332, 563);
            this.tpgTelefones.TabIndex = 3;
            this.tpgTelefones.Text = "Telefone";
            this.tpgTelefones.UseVisualStyleBackColor = true;
            // 
            // cmbTipoTelefone
            // 
            this.cmbTipoTelefone.FormattingEnabled = true;
            this.cmbTipoTelefone.Items.AddRange(new object[] {
            "Residência",
            "Comercial"});
            this.cmbTipoTelefone.Location = new System.Drawing.Point(26, 79);
            this.cmbTipoTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipoTelefone.Name = "cmbTipoTelefone";
            this.cmbTipoTelefone.Size = new System.Drawing.Size(149, 24);
            this.cmbTipoTelefone.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(22, 56);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 21);
            this.label17.TabIndex = 3;
            this.label17.Text = "TIPO :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(22, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 21);
            this.label16.TabIndex = 4;
            this.label16.Text = "NÚMERO : ";
            // 
            // mskNumeroTelefone
            // 
            this.mskNumeroTelefone.Location = new System.Drawing.Point(26, 166);
            this.mskNumeroTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskNumeroTelefone.Mask = "(00) 00000-0000";
            this.mskNumeroTelefone.Name = "mskNumeroTelefone";
            this.mskNumeroTelefone.Size = new System.Drawing.Size(149, 22);
            this.mskNumeroTelefone.TabIndex = 46;
            this.mskNumeroTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskNumeroTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // dgvEnderecos
            // 
            this.dgvEnderecos.AllowUserToAddRows = false;
            this.dgvEnderecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnderecos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCep,
            this.clnEndereco,
            this.cluNumero,
            this.clnComplemento,
            this.clnBairro,
            this.clnCidade,
            this.clnEstado,
            this.clnUf,
            this.clnTiipoEndereco,
            this.clnNome});
            this.dgvEnderecos.Location = new System.Drawing.Point(8, 385);
            this.dgvEnderecos.Name = "dgvEnderecos";
            this.dgvEnderecos.ReadOnly = true;
            this.dgvEnderecos.RowHeadersVisible = false;
            this.dgvEnderecos.RowHeadersWidth = 51;
            this.dgvEnderecos.RowTemplate.Height = 24;
            this.dgvEnderecos.Size = new System.Drawing.Size(1050, 158);
            this.dgvEnderecos.TabIndex = 47;
            this.dgvEnderecos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnInserirEndereco
            // 
            this.btnInserirEndereco.Location = new System.Drawing.Point(31, 334);
            this.btnInserirEndereco.Name = "btnInserirEndereco";
            this.btnInserirEndereco.Size = new System.Drawing.Size(115, 30);
            this.btnInserirEndereco.TabIndex = 48;
            this.btnInserirEndereco.Text = "Inserir";
            this.btnInserirEndereco.UseVisualStyleBackColor = true;
            this.btnInserirEndereco.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditarEndereco
            // 
            this.btnEditarEndereco.Location = new System.Drawing.Point(182, 335);
            this.btnEditarEndereco.Name = "btnEditarEndereco";
            this.btnEditarEndereco.Size = new System.Drawing.Size(102, 28);
            this.btnEditarEndereco.TabIndex = 49;
            this.btnEditarEndereco.Text = "Editar";
            this.btnEditarEndereco.UseVisualStyleBackColor = true;
            // 
            // btnInserirCliente
            // 
            this.btnInserirCliente.Location = new System.Drawing.Point(29, 281);
            this.btnInserirCliente.Name = "btnInserirCliente";
            this.btnInserirCliente.Size = new System.Drawing.Size(107, 33);
            this.btnInserirCliente.TabIndex = 31;
            this.btnInserirCliente.Text = "Inserir";
            this.btnInserirCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInserirCliente.UseVisualStyleBackColor = true;
            this.btnInserirCliente.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.Location = new System.Drawing.Point(157, 282);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(101, 30);
            this.btnConsultarCliente.TabIndex = 32;
            this.btnConsultarCliente.Text = "Consultar";
            this.btnConsultarCliente.UseVisualStyleBackColor = true;
            // 
            // btnEdiatrCliente
            // 
            this.btnEdiatrCliente.Location = new System.Drawing.Point(292, 282);
            this.btnEdiatrCliente.Name = "btnEdiatrCliente";
            this.btnEdiatrCliente.Size = new System.Drawing.Size(116, 32);
            this.btnEdiatrCliente.TabIndex = 33;
            this.btnEdiatrCliente.Text = "Editar";
            this.btnEdiatrCliente.UseVisualStyleBackColor = true;
            // 
            // btnInserirTelefone
            // 
            this.btnInserirTelefone.Location = new System.Drawing.Point(26, 232);
            this.btnInserirTelefone.Name = "btnInserirTelefone";
            this.btnInserirTelefone.Size = new System.Drawing.Size(98, 24);
            this.btnInserirTelefone.TabIndex = 47;
            this.btnInserirTelefone.Text = "Inserir";
            this.btnInserirTelefone.UseVisualStyleBackColor = true;
            this.btnInserirTelefone.Click += new System.EventHandler(this.btnInserirTelefone_Click);
            // 
            // btnEditarTelefone
            // 
            this.btnEditarTelefone.Location = new System.Drawing.Point(130, 232);
            this.btnEditarTelefone.Name = "btnEditarTelefone";
            this.btnEditarTelefone.Size = new System.Drawing.Size(98, 24);
            this.btnEditarTelefone.TabIndex = 49;
            this.btnEditarTelefone.Text = "Editar";
            this.btnEditarTelefone.UseVisualStyleBackColor = true;
            // 
            // dgvTelefone
            // 
            this.dgvTelefone.AllowUserToAddRows = false;
            this.dgvTelefone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnTipoDeTelefone,
            this.CLLNumeroTelefone,
            this.clnclientetelefone});
            this.dgvTelefone.Location = new System.Drawing.Point(26, 313);
            this.dgvTelefone.Name = "dgvTelefone";
            this.dgvTelefone.ReadOnly = true;
            this.dgvTelefone.RowHeadersVisible = false;
            this.dgvTelefone.RowHeadersWidth = 51;
            this.dgvTelefone.RowTemplate.Height = 24;
            this.dgvTelefone.Size = new System.Drawing.Size(404, 114);
            this.dgvTelefone.TabIndex = 50;
            // 
            // clnTipoDeTelefone
            // 
            this.clnTipoDeTelefone.Frozen = true;
            this.clnTipoDeTelefone.HeaderText = "Tipo";
            this.clnTipoDeTelefone.MinimumWidth = 6;
            this.clnTipoDeTelefone.Name = "clnTipoDeTelefone";
            this.clnTipoDeTelefone.ReadOnly = true;
            this.clnTipoDeTelefone.Width = 133;
            // 
            // CLLNumeroTelefone
            // 
            this.CLLNumeroTelefone.Frozen = true;
            this.CLLNumeroTelefone.HeaderText = "Número";
            this.CLLNumeroTelefone.MinimumWidth = 6;
            this.CLLNumeroTelefone.Name = "CLLNumeroTelefone";
            this.CLLNumeroTelefone.ReadOnly = true;
            this.CLLNumeroTelefone.Width = 133;
            // 
            // clnclientetelefone
            // 
            this.clnclientetelefone.Frozen = true;
            this.clnclientetelefone.HeaderText = "Cliente";
            this.clnclientetelefone.MinimumWidth = 6;
            this.clnclientetelefone.Name = "clnclientetelefone";
            this.clnclientetelefone.ReadOnly = true;
            this.clnclientetelefone.Width = 133;
            // 
            // clnCep
            // 
            this.clnCep.Frozen = true;
            this.clnCep.HeaderText = "Cep";
            this.clnCep.MinimumWidth = 6;
            this.clnCep.Name = "clnCep";
            this.clnCep.ReadOnly = true;
            this.clnCep.Width = 75;
            // 
            // clnEndereco
            // 
            this.clnEndereco.Frozen = true;
            this.clnEndereco.HeaderText = "Logradouro";
            this.clnEndereco.MinimumWidth = 6;
            this.clnEndereco.Name = "clnEndereco";
            this.clnEndereco.ReadOnly = true;
            this.clnEndereco.Width = 130;
            // 
            // cluNumero
            // 
            this.cluNumero.Frozen = true;
            this.cluNumero.HeaderText = "Número";
            this.cluNumero.MinimumWidth = 6;
            this.cluNumero.Name = "cluNumero";
            this.cluNumero.ReadOnly = true;
            this.cluNumero.Width = 75;
            // 
            // clnComplemento
            // 
            this.clnComplemento.Frozen = true;
            this.clnComplemento.HeaderText = "Complemento";
            this.clnComplemento.MinimumWidth = 6;
            this.clnComplemento.Name = "clnComplemento";
            this.clnComplemento.ReadOnly = true;
            this.clnComplemento.Width = 120;
            // 
            // clnBairro
            // 
            this.clnBairro.Frozen = true;
            this.clnBairro.HeaderText = "Bairro";
            this.clnBairro.MinimumWidth = 6;
            this.clnBairro.Name = "clnBairro";
            this.clnBairro.ReadOnly = true;
            this.clnBairro.Width = 65;
            // 
            // clnCidade
            // 
            this.clnCidade.Frozen = true;
            this.clnCidade.HeaderText = "Cidade";
            this.clnCidade.MinimumWidth = 6;
            this.clnCidade.Name = "clnCidade";
            this.clnCidade.ReadOnly = true;
            this.clnCidade.Width = 90;
            // 
            // clnEstado
            // 
            this.clnEstado.Frozen = true;
            this.clnEstado.HeaderText = "Estado";
            this.clnEstado.MinimumWidth = 6;
            this.clnEstado.Name = "clnEstado";
            this.clnEstado.ReadOnly = true;
            // 
            // clnUf
            // 
            this.clnUf.Frozen = true;
            this.clnUf.HeaderText = "Uf";
            this.clnUf.MinimumWidth = 6;
            this.clnUf.Name = "clnUf";
            this.clnUf.ReadOnly = true;
            this.clnUf.Width = 65;
            // 
            // clnTiipoEndereco
            // 
            this.clnTiipoEndereco.Frozen = true;
            this.clnTiipoEndereco.HeaderText = "Tipo";
            this.clnTiipoEndereco.MinimumWidth = 6;
            this.clnTiipoEndereco.Name = "clnTiipoEndereco";
            this.clnTiipoEndereco.ReadOnly = true;
            this.clnTiipoEndereco.Width = 80;
            // 
            // clnNome
            // 
            this.clnNome.HeaderText = "Cliente";
            this.clnNome.MinimumWidth = 6;
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            this.clnNome.Width = 125;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1817, 697);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tpgTelefones.ResumeLayout(false);
            this.tpgTelefones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tpgTelefones;
        private System.Windows.Forms.ComboBox cmbTipoTelefone;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbTipoEndereco;
        private System.Windows.Forms.MaskedTextBox mskCepCliente;
        private System.Windows.Forms.Button btnAdicionarOutrosEnderecos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNumeroCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtComplementoCliente;
        private System.Windows.Forms.TextBox txtUfCliente;
        private System.Windows.Forms.TextBox txtEstadoCliente;
        private System.Windows.Forms.TextBox txtBairroCliente;
        private System.Windows.Forms.TextBox txtLogradouroCliente;
        private System.Windows.Forms.TextBox txtCidadeCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mktCpf;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtidCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox mskNumeroTelefone;
        private System.Windows.Forms.Button btnEditarEndereco;
        private System.Windows.Forms.Button btnInserirEndereco;
        private System.Windows.Forms.DataGridView dgvEnderecos;
        private System.Windows.Forms.Button btnEdiatrCliente;
        private System.Windows.Forms.Button btnConsultarCliente;
        private System.Windows.Forms.Button btnInserirCliente;
        private System.Windows.Forms.Button btnInserirTelefone;
        private System.Windows.Forms.DataGridView dgvTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTipoDeTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLLNumeroTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnclientetelefone;
        private System.Windows.Forms.Button btnEditarTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn cluNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnComplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTiipoEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
    }
}