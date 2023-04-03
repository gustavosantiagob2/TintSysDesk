namespace TintSysDesk
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEnderecoCliente = new System.Windows.Forms.TextBox();
            this.txtComplementoCliente = new System.Windows.Forms.TextBox();
            this.txtNumeroCliente = new System.Windows.Forms.TextBox();
            this.txtCidadeCliente = new System.Windows.Forms.TextBox();
            this.txtEstadoCliente = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.txtBairroCliente = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.txtUfCliente = new System.Windows.Forms.TextBox();
            this.txtlogradouroCliente = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtidCliente = new System.Windows.Forms.TextBox();
            this.btnAdicionarOutrosEnderecos = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbTipoTelefone = new System.Windows.Forms.ComboBox();
            this.txtNumeroTelefone = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbTipoEndereco = new System.Windows.Forms.ComboBox();
            this.mskCepCliente = new System.Windows.Forms.MaskedTextBox();
            this.dtmDataCadCliente = new System.Windows.Forms.DateTimePicker();
            this.mskCpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.btninserirCliente = new System.Windows.Forms.Button();
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.clnIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.mskCpfCliente);
            this.groupBox1.Controls.Add(this.dtmDataCadCliente);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtNomeCliente);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtEmailCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtidCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1122, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Básicos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-mail :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome do Cliente :";
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(23, 117);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(352, 22);
            this.txtEmailCliente.TabIndex = 5;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(23, 170);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(352, 22);
            this.txtNomeCliente.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "DATA DE CADASTRO :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mskCepCliente);
            this.groupBox2.Controls.Add(this.btnAdicionarOutrosEnderecos);
            this.groupBox2.Controls.Add(this.cmbTipoEndereco);
            this.groupBox2.Controls.Add(this.textBox17);
            this.groupBox2.Controls.Add(this.textBox12);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtNumeroCliente);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox16);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.txtComplementoCliente);
            this.groupBox2.Controls.Add(this.txtUfCliente);
            this.groupBox2.Controls.Add(this.txtlogradouroCliente);
            this.groupBox2.Controls.Add(this.txtEstadoCliente);
            this.groupBox2.Controls.Add(this.txtBairroCliente);
            this.groupBox2.Controls.Add(this.txtEnderecoCliente);
            this.groupBox2.Controls.Add(this.txtCidadeCliente);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1122, 247);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "CEP : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "LOGRADOURO : ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(172, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "ENDEREÇO :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(582, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "NÚMERO : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(770, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "COMPLEMENTO :";
            this.label9.Click += new System.EventHandler(this.label7_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "BAIRRO : ";
            this.label10.Click += new System.EventHandler(this.label7_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(308, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "CIDADE : ";
            this.label11.Click += new System.EventHandler(this.label7_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(663, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "ESTADO : ";
            this.label12.Click += new System.EventHandler(this.label7_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(893, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "UF :";
            this.label13.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtEnderecoCliente
            // 
            this.txtEnderecoCliente.Location = new System.Drawing.Point(176, 55);
            this.txtEnderecoCliente.Name = "txtEnderecoCliente";
            this.txtEnderecoCliente.Size = new System.Drawing.Size(391, 22);
            this.txtEnderecoCliente.TabIndex = 1;
            // 
            // txtComplementoCliente
            // 
            this.txtComplementoCliente.Location = new System.Drawing.Point(774, 55);
            this.txtComplementoCliente.Name = "txtComplementoCliente";
            this.txtComplementoCliente.Size = new System.Drawing.Size(334, 22);
            this.txtComplementoCliente.TabIndex = 1;
            // 
            // txtNumeroCliente
            // 
            this.txtNumeroCliente.Location = new System.Drawing.Point(586, 55);
            this.txtNumeroCliente.Name = "txtNumeroCliente";
            this.txtNumeroCliente.Size = new System.Drawing.Size(167, 22);
            this.txtNumeroCliente.TabIndex = 1;
            // 
            // txtCidadeCliente
            // 
            this.txtCidadeCliente.Location = new System.Drawing.Point(312, 113);
            this.txtCidadeCliente.Name = "txtCidadeCliente";
            this.txtCidadeCliente.Size = new System.Drawing.Size(335, 22);
            this.txtCidadeCliente.TabIndex = 1;
            // 
            // txtEstadoCliente
            // 
            this.txtEstadoCliente.Location = new System.Drawing.Point(667, 113);
            this.txtEstadoCliente.Name = "txtEstadoCliente";
            this.txtEstadoCliente.Size = new System.Drawing.Size(211, 22);
            this.txtEstadoCliente.TabIndex = 1;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(1197, 128);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(126, 22);
            this.textBox11.TabIndex = 1;
            // 
            // txtBairroCliente
            // 
            this.txtBairroCliente.Location = new System.Drawing.Point(23, 113);
            this.txtBairroCliente.Name = "txtBairroCliente";
            this.txtBairroCliente.Size = new System.Drawing.Size(277, 22);
            this.txtBairroCliente.TabIndex = 1;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(1160, 178);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(126, 22);
            this.textBox16.TabIndex = 1;
            // 
            // txtUfCliente
            // 
            this.txtUfCliente.Location = new System.Drawing.Point(897, 113);
            this.txtUfCliente.Name = "txtUfCliente";
            this.txtUfCliente.Size = new System.Drawing.Size(211, 22);
            this.txtUfCliente.TabIndex = 1;
            // 
            // txtlogradouroCliente
            // 
            this.txtlogradouroCliente.Location = new System.Drawing.Point(22, 182);
            this.txtlogradouroCliente.Name = "txtlogradouroCliente";
            this.txtlogradouroCliente.Size = new System.Drawing.Size(277, 22);
            this.txtlogradouroCliente.TabIndex = 1;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(1345, 128);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(126, 22);
            this.textBox12.TabIndex = 1;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(1308, 178);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(126, 22);
            this.textBox17.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(308, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 21);
            this.label14.TabIndex = 0;
            this.label14.Text = "TIPO DE ENDEREÇO";
            this.label14.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtidCliente
            // 
            this.txtidCliente.Location = new System.Drawing.Point(441, 117);
            this.txtidCliente.Name = "txtidCliente";
            this.txtidCliente.Size = new System.Drawing.Size(126, 22);
            this.txtidCliente.TabIndex = 1;
            this.txtidCliente.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            // 
            // btnAdicionarOutrosEnderecos
            // 
            this.btnAdicionarOutrosEnderecos.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarOutrosEnderecos.Location = new System.Drawing.Point(556, 173);
            this.btnAdicionarOutrosEnderecos.Name = "btnAdicionarOutrosEnderecos";
            this.btnAdicionarOutrosEnderecos.Size = new System.Drawing.Size(261, 36);
            this.btnAdicionarOutrosEnderecos.TabIndex = 2;
            this.btnAdicionarOutrosEnderecos.Text = "ADICIONAR OUTROS ENDEREÇOS";
            this.btnAdicionarOutrosEnderecos.UseVisualStyleBackColor = true;
            this.btnAdicionarOutrosEnderecos.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNumeroTelefone);
            this.groupBox3.Controls.Add(this.cmbTipoTelefone);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(12, 472);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(654, 128);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TELEFONE";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(193, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 21);
            this.label16.TabIndex = 0;
            this.label16.Text = "NÚMERO : ";
            this.label16.Click += new System.EventHandler(this.label6_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(20, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 21);
            this.label17.TabIndex = 0;
            this.label17.Text = "TIPO :";
            this.label17.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmbTipoTelefone
            // 
            this.cmbTipoTelefone.FormattingEnabled = true;
            this.cmbTipoTelefone.Location = new System.Drawing.Point(19, 61);
            this.cmbTipoTelefone.Name = "cmbTipoTelefone";
            this.cmbTipoTelefone.Size = new System.Drawing.Size(149, 24);
            this.cmbTipoTelefone.TabIndex = 1;
            // 
            // txtNumeroTelefone
            // 
            this.txtNumeroTelefone.Location = new System.Drawing.Point(197, 61);
            this.txtNumeroTelefone.Name = "txtNumeroTelefone";
            this.txtNumeroTelefone.Size = new System.Drawing.Size(189, 22);
            this.txtNumeroTelefone.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TintSysDesk.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(729, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // cmbTipoEndereco
            // 
            this.cmbTipoEndereco.FormattingEnabled = true;
            this.cmbTipoEndereco.Location = new System.Drawing.Point(312, 185);
            this.cmbTipoEndereco.Name = "cmbTipoEndereco";
            this.cmbTipoEndereco.Size = new System.Drawing.Size(207, 24);
            this.cmbTipoEndereco.TabIndex = 1;
            // 
            // mskCepCliente
            // 
            this.mskCepCliente.Location = new System.Drawing.Point(19, 55);
            this.mskCepCliente.Mask = "000.00-000";
            this.mskCepCliente.Name = "mskCepCliente";
            this.mskCepCliente.Size = new System.Drawing.Size(86, 22);
            this.mskCepCliente.TabIndex = 3;
            this.mskCepCliente.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // dtmDataCadCliente
            // 
            this.dtmDataCadCliente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmDataCadCliente.Location = new System.Drawing.Point(253, 54);
            this.dtmDataCadCliente.Name = "dtmDataCadCliente";
            this.dtmDataCadCliente.Size = new System.Drawing.Size(112, 22);
            this.dtmDataCadCliente.TabIndex = 3;
            // 
            // mskCpfCliente
            // 
            this.mskCpfCliente.Location = new System.Drawing.Point(19, 54);
            this.mskCpfCliente.Mask = "000.000.000--00";
            this.mskCpfCliente.Name = "mskCpfCliente";
            this.mskCpfCliente.Size = new System.Drawing.Size(117, 22);
            this.mskCpfCliente.TabIndex = 3;
            this.mskCpfCliente.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btninserirCliente
            // 
            this.btninserirCliente.Location = new System.Drawing.Point(34, 629);
            this.btninserirCliente.Name = "btninserirCliente";
            this.btninserirCliente.Size = new System.Drawing.Size(109, 37);
            this.btninserirCliente.TabIndex = 3;
            this.btninserirCliente.Text = "Inserir";
            this.btninserirCliente.UseVisualStyleBackColor = true;
            this.btninserirCliente.Click += new System.EventHandler(this.btninserirCliente_Click);
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.Location = new System.Drawing.Point(149, 629);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(133, 37);
            this.btnConsultarCliente.TabIndex = 4;
            this.btnConsultarCliente.Text = "Consultar";
            this.btnConsultarCliente.UseVisualStyleBackColor = true;
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Location = new System.Drawing.Point(288, 629);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(127, 37);
            this.btnEditarCliente.TabIndex = 5;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnIdCliente,
            this.clnNomeCliente});
            this.dgvClientes.Location = new System.Drawing.Point(69, 40);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(258, 139);
            this.dgvClientes.TabIndex = 6;
            // 
            // clnIdCliente
            // 
            this.clnIdCliente.Frozen = true;
            this.clnIdCliente.HeaderText = "ID";
            this.clnIdCliente.MinimumWidth = 6;
            this.clnIdCliente.Name = "clnIdCliente";
            this.clnIdCliente.ReadOnly = true;
            this.clnIdCliente.Width = 50;
            // 
            // clnNomeCliente
            // 
            this.clnNomeCliente.Frozen = true;
            this.clnNomeCliente.HeaderText = "Nome";
            this.clnNomeCliente.MinimumWidth = 6;
            this.clnNomeCliente.Name = "clnNomeCliente";
            this.clnNomeCliente.ReadOnly = true;
            this.clnNomeCliente.Width = 200;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvClientes);
            this.groupBox4.Location = new System.Drawing.Point(1140, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(443, 201);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Clientes Cadastrados";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(487, 30);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(60, 25);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Ativo";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(437, 93);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 21);
            this.label18.TabIndex = 0;
            this.label18.Text = "ID DO CLIENTE :";
            this.label18.Click += new System.EventHandler(this.label7_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1817, 696);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnConsultarCliente);
            this.Controls.Add(this.btninserirCliente);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumeroCliente;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox txtComplementoCliente;
        private System.Windows.Forms.TextBox txtUfCliente;
        private System.Windows.Forms.TextBox txtlogradouroCliente;
        private System.Windows.Forms.TextBox txtEstadoCliente;
        private System.Windows.Forms.TextBox txtBairroCliente;
        private System.Windows.Forms.TextBox txtEnderecoCliente;
        private System.Windows.Forms.TextBox txtCidadeCliente;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAdicionarOutrosEnderecos;
        private System.Windows.Forms.TextBox txtidCliente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbTipoTelefone;
        private System.Windows.Forms.TextBox txtNumeroTelefone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbTipoEndereco;
        private System.Windows.Forms.DateTimePicker dtmDataCadCliente;
        private System.Windows.Forms.MaskedTextBox mskCepCliente;
        private System.Windows.Forms.MaskedTextBox mskCpfCliente;
        private System.Windows.Forms.Button btninserirCliente;
        private System.Windows.Forms.Button btnConsultarCliente;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNomeCliente;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label18;
    }
}