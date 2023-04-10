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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btnEdiatrCliente = new System.Windows.Forms.Button();
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.btnInserirCliente = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtidCliente = new System.Windows.Forms.TextBox();
            this.mktCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvEnderecos = new System.Windows.Forms.DataGridView();
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
            this.cmbTipoEndereco = new System.Windows.Forms.ComboBox();
            this.mskCepCliente = new System.Windows.Forms.MaskedTextBox();
            this.btnAdicionarOutrosEnderecos = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNumeroEndereco = new System.Windows.Forms.TextBox();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvTelefone = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditarTelefone = new System.Windows.Forms.Button();
            this.btnInserirTelefone = new System.Windows.Forms.Button();
            this.mskNumeroTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoTelefone = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clnIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEmialCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnInserirEndereco = new System.Windows.Forms.Button();
            this.btnEditarEndereco = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(25, 46);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1005, 701);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvCliente);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(997, 675);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Básicos";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnIdCliente,
            this.clnCpf,
            this.clnNomeCliente,
            this.clnEmialCliente});
            this.dgvCliente.Location = new System.Drawing.Point(13, 276);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.Size = new System.Drawing.Size(499, 150);
            this.dgvCliente.TabIndex = 34;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // btnEdiatrCliente
            // 
            this.btnEdiatrCliente.Location = new System.Drawing.Point(219, 229);
            this.btnEdiatrCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdiatrCliente.Name = "btnEdiatrCliente";
            this.btnEdiatrCliente.Size = new System.Drawing.Size(87, 26);
            this.btnEdiatrCliente.TabIndex = 33;
            this.btnEdiatrCliente.Text = "Editar";
            this.btnEdiatrCliente.UseVisualStyleBackColor = true;
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.Location = new System.Drawing.Point(118, 229);
            this.btnConsultarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(76, 24);
            this.btnConsultarCliente.TabIndex = 32;
            this.btnConsultarCliente.Text = "Consultar";
            this.btnConsultarCliente.UseVisualStyleBackColor = true;
            // 
            // btnInserirCliente
            // 
            this.btnInserirCliente.Location = new System.Drawing.Point(22, 228);
            this.btnInserirCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserirCliente.Name = "btnInserirCliente";
            this.btnInserirCliente.Size = new System.Drawing.Size(80, 27);
            this.btnInserirCliente.TabIndex = 31;
            this.btnInserirCliente.Text = "Inserir";
            this.btnInserirCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInserirCliente.UseVisualStyleBackColor = true;
            this.btnInserirCliente.Click += new System.EventHandler(this.button3_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(159, 30);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 17);
            this.label18.TabIndex = 28;
            this.label18.Text = "ID DO CLIENTE :";
            // 
            // txtidCliente
            // 
            this.txtidCliente.Location = new System.Drawing.Point(162, 49);
            this.txtidCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtidCliente.Name = "txtidCliente";
            this.txtidCliente.Size = new System.Drawing.Size(96, 20);
            this.txtidCliente.TabIndex = 29;
            // 
            // mktCpf
            // 
            this.mktCpf.Location = new System.Drawing.Point(14, 49);
            this.mktCpf.Margin = new System.Windows.Forms.Padding(2);
            this.mktCpf.Mask = "000.000.000--00";
            this.mktCpf.Name = "mktCpf";
            this.mktCpf.Size = new System.Drawing.Size(89, 20);
            this.mktCpf.TabIndex = 23;
            this.mktCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(13, 110);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(265, 20);
            this.txtNomeCliente.TabIndex = 26;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(13, 162);
            this.txtEmailCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(265, 20);
            this.txtEmailCliente.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nome do Cliente :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "E-mail :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "CPF :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEditarEndereco);
            this.tabPage2.Controls.Add(this.btnInserirEndereco);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.cmbTipoTelefone);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dgvTelefone);
            this.tabPage2.Controls.Add(this.btnEditarTelefone);
            this.tabPage2.Controls.Add(this.btnInserirTelefone);
            this.tabPage2.Controls.Add(this.mskNumeroTelefone);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dgvEnderecos);
            this.tabPage2.Controls.Add(this.cmbTipoEndereco);
            this.tabPage2.Controls.Add(this.mskCepCliente);
            this.tabPage2.Controls.Add(this.btnAdicionarOutrosEnderecos);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txtNumeroEndereco);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtComplementoCliente);
            this.tabPage2.Controls.Add(this.txtUfCliente);
            this.tabPage2.Controls.Add(this.txtEstadoCliente);
            this.tabPage2.Controls.Add(this.txtBairroCliente);
            this.tabPage2.Controls.Add(this.txtLogradouroCliente);
            this.tabPage2.Controls.Add(this.txtCidadeCliente);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(997, 675);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contato";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
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
            this.dgvEnderecos.Location = new System.Drawing.Point(8, 278);
            this.dgvEnderecos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEnderecos.Name = "dgvEnderecos";
            this.dgvEnderecos.ReadOnly = true;
            this.dgvEnderecos.RowHeadersVisible = false;
            this.dgvEnderecos.RowHeadersWidth = 51;
            this.dgvEnderecos.RowTemplate.Height = 24;
            this.dgvEnderecos.Size = new System.Drawing.Size(928, 128);
            this.dgvEnderecos.TabIndex = 47;
            this.dgvEnderecos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // cmbTipoEndereco
            // 
            this.cmbTipoEndereco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEndereco.FormattingEnabled = true;
            this.cmbTipoEndereco.Items.AddRange(new object[] {
            "Comercial",
            "Residêncial",
            "Entrega"});
            this.cmbTipoEndereco.Location = new System.Drawing.Point(8, 182);
            this.cmbTipoEndereco.Name = "cmbTipoEndereco";
            this.cmbTipoEndereco.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoEndereco.TabIndex = 46;
            // 
            // mskCepCliente
            // 
            this.mskCepCliente.Location = new System.Drawing.Point(4, 76);
            this.mskCepCliente.Margin = new System.Windows.Forms.Padding(2);
            this.mskCepCliente.Mask = "000.00-000";
            this.mskCepCliente.Name = "mskCepCliente";
            this.mskCepCliente.Size = new System.Drawing.Size(66, 20);
            this.mskCepCliente.TabIndex = 45;
            this.mskCepCliente.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnAdicionarOutrosEnderecos
            // 
            this.btnAdicionarOutrosEnderecos.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarOutrosEnderecos.Location = new System.Drawing.Point(141, 174);
            this.btnAdicionarOutrosEnderecos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionarOutrosEnderecos.Name = "btnAdicionarOutrosEnderecos";
            this.btnAdicionarOutrosEnderecos.Size = new System.Drawing.Size(196, 29);
            this.btnAdicionarOutrosEnderecos.TabIndex = 44;
            this.btnAdicionarOutrosEnderecos.Text = "ADICIONAR OUTROS ENDEREÇOS";
            this.btnAdicionarOutrosEnderecos.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(5, 160);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 17);
            this.label14.TabIndex = 30;
            this.label14.Text = "TIPO DE ENDEREÇO";
            // 
            // txtNumeroEndereco
            // 
            this.txtNumeroEndereco.Location = new System.Drawing.Point(430, 76);
            this.txtNumeroEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroEndereco.Name = "txtNumeroEndereco";
            this.txtNumeroEndereco.Size = new System.Drawing.Size(126, 20);
            this.txtNumeroEndereco.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(221, 103);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "CIDADE : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(488, 103);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "ESTADO : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 103);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "BAIRRO : ";
            // 
            // txtComplementoCliente
            // 
            this.txtComplementoCliente.Location = new System.Drawing.Point(570, 76);
            this.txtComplementoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtComplementoCliente.Name = "txtComplementoCliente";
            this.txtComplementoCliente.Size = new System.Drawing.Size(252, 20);
            this.txtComplementoCliente.TabIndex = 41;
            // 
            // txtUfCliente
            // 
            this.txtUfCliente.Location = new System.Drawing.Point(663, 123);
            this.txtUfCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtUfCliente.Name = "txtUfCliente";
            this.txtUfCliente.Size = new System.Drawing.Size(159, 20);
            this.txtUfCliente.TabIndex = 39;
            // 
            // txtEstadoCliente
            // 
            this.txtEstadoCliente.Location = new System.Drawing.Point(490, 123);
            this.txtEstadoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstadoCliente.Name = "txtEstadoCliente";
            this.txtEstadoCliente.Size = new System.Drawing.Size(159, 20);
            this.txtEstadoCliente.TabIndex = 43;
            // 
            // txtBairroCliente
            // 
            this.txtBairroCliente.Location = new System.Drawing.Point(8, 123);
            this.txtBairroCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtBairroCliente.Name = "txtBairroCliente";
            this.txtBairroCliente.Size = new System.Drawing.Size(209, 20);
            this.txtBairroCliente.TabIndex = 38;
            // 
            // txtLogradouroCliente
            // 
            this.txtLogradouroCliente.Location = new System.Drawing.Point(122, 76);
            this.txtLogradouroCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogradouroCliente.Name = "txtLogradouroCliente";
            this.txtLogradouroCliente.Size = new System.Drawing.Size(294, 20);
            this.txtLogradouroCliente.TabIndex = 37;
            // 
            // txtCidadeCliente
            // 
            this.txtCidadeCliente.Location = new System.Drawing.Point(224, 123);
            this.txtCidadeCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCidadeCliente.Name = "txtCidadeCliente";
            this.txtCidadeCliente.Size = new System.Drawing.Size(252, 20);
            this.txtCidadeCliente.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(426, 56);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "NÚMERO : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(660, 103);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "UF :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(568, 56);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "COMPLEMENTO :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(119, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "LOGRADOURO :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "CEP : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TintSysDesk.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(406, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // dgvTelefone
            // 
            this.dgvTelefone.AllowUserToAddRows = false;
            this.dgvTelefone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvTelefone.Location = new System.Drawing.Point(13, 489);
            this.dgvTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTelefone.Name = "dgvTelefone";
            this.dgvTelefone.ReadOnly = true;
            this.dgvTelefone.RowHeadersVisible = false;
            this.dgvTelefone.RowHeadersWidth = 51;
            this.dgvTelefone.RowTemplate.Height = 24;
            this.dgvTelefone.Size = new System.Drawing.Size(403, 93);
            this.dgvTelefone.TabIndex = 56;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 133;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Número";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 133;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 133;
            // 
            // btnEditarTelefone
            // 
            this.btnEditarTelefone.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTelefone.Location = new System.Drawing.Point(99, 602);
            this.btnEditarTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarTelefone.Name = "btnEditarTelefone";
            this.btnEditarTelefone.Size = new System.Drawing.Size(74, 28);
            this.btnEditarTelefone.TabIndex = 55;
            this.btnEditarTelefone.Text = "Editar";
            this.btnEditarTelefone.UseVisualStyleBackColor = true;
            // 
            // btnInserirTelefone
            // 
            this.btnInserirTelefone.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirTelefone.Location = new System.Drawing.Point(21, 602);
            this.btnInserirTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserirTelefone.Name = "btnInserirTelefone";
            this.btnInserirTelefone.Size = new System.Drawing.Size(74, 28);
            this.btnInserirTelefone.TabIndex = 54;
            this.btnInserirTelefone.Text = "Inserir";
            this.btnInserirTelefone.UseVisualStyleBackColor = true;
            this.btnInserirTelefone.Click += new System.EventHandler(this.button2_Click);
            // 
            // mskNumeroTelefone
            // 
            this.mskNumeroTelefone.Location = new System.Drawing.Point(22, 452);
            this.mskNumeroTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.mskNumeroTelefone.Mask = "(00) 00000-0000";
            this.mskNumeroTelefone.Name = "mskNumeroTelefone";
            this.mskNumeroTelefone.Size = new System.Drawing.Size(113, 20);
            this.mskNumeroTelefone.TabIndex = 53;
            this.mskNumeroTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 433);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "NÚMERO : ";
            // 
            // cmbTipoTelefone
            // 
            this.cmbTipoTelefone.FormattingEnabled = true;
            this.cmbTipoTelefone.Items.AddRange(new object[] {
            "Residência",
            "Comercial"});
            this.cmbTipoTelefone.Location = new System.Drawing.Point(176, 451);
            this.cmbTipoTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoTelefone.Name = "cmbTipoTelefone";
            this.cmbTipoTelefone.Size = new System.Drawing.Size(113, 21);
            this.cmbTipoTelefone.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(172, 433);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 57;
            this.label6.Text = "TIPO :";
            // 
            // clnIdCliente
            // 
            this.clnIdCliente.Frozen = true;
            this.clnIdCliente.HeaderText = "Id";
            this.clnIdCliente.Name = "clnIdCliente";
            this.clnIdCliente.ReadOnly = true;
            // 
            // clnCpf
            // 
            this.clnCpf.Frozen = true;
            this.clnCpf.HeaderText = "Cpf";
            this.clnCpf.Name = "clnCpf";
            this.clnCpf.ReadOnly = true;
            // 
            // clnNomeCliente
            // 
            this.clnNomeCliente.Frozen = true;
            this.clnNomeCliente.HeaderText = "Nome";
            this.clnNomeCliente.Name = "clnNomeCliente";
            this.clnNomeCliente.ReadOnly = true;
            // 
            // clnEmialCliente
            // 
            this.clnEmialCliente.Frozen = true;
            this.clnEmialCliente.HeaderText = "E-mail";
            this.clnEmialCliente.Name = "clnEmialCliente";
            this.clnEmialCliente.ReadOnly = true;
            this.clnEmialCliente.Width = 195;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(378, 160);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 19);
            this.label15.TabIndex = 31;
            this.label15.Text = "ID  :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(376, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 59;
            // 
            // btnInserirEndereco
            // 
            this.btnInserirEndereco.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirEndereco.Location = new System.Drawing.Point(13, 229);
            this.btnInserirEndereco.Name = "btnInserirEndereco";
            this.btnInserirEndereco.Size = new System.Drawing.Size(75, 28);
            this.btnInserirEndereco.TabIndex = 60;
            this.btnInserirEndereco.Text = "Inserir";
            this.btnInserirEndereco.UseVisualStyleBackColor = true;
            this.btnInserirEndereco.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnEditarEndereco
            // 
            this.btnEditarEndereco.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEndereco.Location = new System.Drawing.Point(99, 229);
            this.btnEditarEndereco.Name = "btnEditarEndereco";
            this.btnEditarEndereco.Size = new System.Drawing.Size(75, 28);
            this.btnEditarEndereco.TabIndex = 60;
            this.btnEditarEndereco.Text = "Editar";
            this.btnEditarEndereco.UseVisualStyleBackColor = true;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 801);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbTipoEndereco;
        private System.Windows.Forms.MaskedTextBox mskCepCliente;
        private System.Windows.Forms.Button btnAdicionarOutrosEnderecos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNumeroEndereco;
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
        private System.Windows.Forms.DataGridView dgvEnderecos;
        private System.Windows.Forms.Button btnEdiatrCliente;
        private System.Windows.Forms.Button btnConsultarCliente;
        private System.Windows.Forms.Button btnInserirCliente;
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
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.ComboBox cmbTipoTelefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnEditarTelefone;
        private System.Windows.Forms.Button btnInserirTelefone;
        private System.Windows.Forms.MaskedTextBox mskNumeroTelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEmialCliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnEditarEndereco;
        private System.Windows.Forms.Button btnInserirEndereco;
    }
}