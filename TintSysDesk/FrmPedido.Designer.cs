namespace TintSysDesk
{
    partial class FrmPedido
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.cmbAtendente = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.btnInserirProduto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grbProdutos = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblpedido = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDados.SuspendLayout();
            this.grbProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(539, 665);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL R$";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(630, 674);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(169, 20);
            this.txtTotal.TabIndex = 1;
            // 
            // grbDados
            // 
            this.grbDados.Controls.Add(this.cmbAtendente);
            this.grbDados.Controls.Add(this.cmbCliente);
            this.grbDados.Controls.Add(this.btnInserirProduto);
            this.grbDados.Controls.Add(this.label2);
            this.grbDados.Controls.Add(this.label3);
            this.grbDados.Enabled = false;
            this.grbDados.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDados.Location = new System.Drawing.Point(12, 135);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(902, 125);
            this.grbDados.TabIndex = 2;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados";
            // 
            // cmbAtendente
            // 
            this.cmbAtendente.FormattingEnabled = true;
            this.cmbAtendente.Location = new System.Drawing.Point(482, 53);
            this.cmbAtendente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbAtendente.Name = "cmbAtendente";
            this.cmbAtendente.Size = new System.Drawing.Size(304, 27);
            this.cmbAtendente.TabIndex = 6;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(86, 51);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(304, 27);
            this.cmbCliente.TabIndex = 6;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // btnInserirProduto
            // 
            this.btnInserirProduto.Location = new System.Drawing.Point(809, 55);
            this.btnInserirProduto.Name = "btnInserirProduto";
            this.btnInserirProduto.Size = new System.Drawing.Size(75, 28);
            this.btnInserirProduto.TabIndex = 5;
            this.btnInserirProduto.Text = "Inserir";
            this.btnInserirProduto.UseVisualStyleBackColor = true;
            this.btnInserirProduto.Click += new System.EventHandler(this.btnInserirProduto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 3;
            this.label2.Tag = "";
            this.label2.Text = "CLIENTE :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(410, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 3;
            this.label3.Tag = "";
            this.label3.Text = "ATENDENTE :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 3;
            this.label5.Tag = "";
            this.label5.Text = "CODIGO :";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(126, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 3;
            this.label6.Tag = "";
            this.label6.Text = "DESCRIÇÃO :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(405, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 3;
            this.label4.Tag = "";
            this.label4.Text = "PREÇO :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(289, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 19);
            this.label7.TabIndex = 3;
            this.label7.Tag = "";
            this.label7.Text = "UND :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(528, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 19);
            this.label8.TabIndex = 3;
            this.label8.Tag = "";
            this.label8.Text = "QTD :";
            this.label8.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(647, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 19);
            this.label9.TabIndex = 3;
            this.label9.Tag = "";
            this.label9.Text = "DESCONTO :";
            this.label9.Click += new System.EventHandler(this.label7_Click);
            // 
            // grbProdutos
            // 
            this.grbProdutos.Controls.Add(this.btnAdicionar);
            this.grbProdutos.Controls.Add(this.txtDesconto);
            this.grbProdutos.Controls.Add(this.txtQuantidade);
            this.grbProdutos.Controls.Add(this.txtPreco);
            this.grbProdutos.Controls.Add(this.txtUnidade);
            this.grbProdutos.Controls.Add(this.txtDescricao);
            this.grbProdutos.Controls.Add(this.txtIdProd);
            this.grbProdutos.Controls.Add(this.label5);
            this.grbProdutos.Controls.Add(this.label9);
            this.grbProdutos.Controls.Add(this.label6);
            this.grbProdutos.Controls.Add(this.label8);
            this.grbProdutos.Controls.Add(this.label7);
            this.grbProdutos.Controls.Add(this.label4);
            this.grbProdutos.Enabled = false;
            this.grbProdutos.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProdutos.Location = new System.Drawing.Point(12, 282);
            this.grbProdutos.Name = "grbProdutos";
            this.grbProdutos.Size = new System.Drawing.Size(902, 133);
            this.grbProdutos.TabIndex = 4;
            this.grbProdutos.TabStop = false;
            this.grbProdutos.Text = "Produtos";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(767, 58);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 28);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(651, 60);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 27);
            this.txtDesconto.TabIndex = 4;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(532, 60);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 27);
            this.txtQuantidade.TabIndex = 4;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(409, 60);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 27);
            this.txtPreco.TabIndex = 4;
            // 
            // txtUnidade
            // 
            this.txtUnidade.Location = new System.Drawing.Point(290, 60);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(100, 27);
            this.txtUnidade.TabIndex = 4;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(130, 60);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(138, 27);
            this.txtDescricao.TabIndex = 4;
            // 
            // txtIdProd
            // 
            this.txtIdProd.Location = new System.Drawing.Point(10, 60);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Size = new System.Drawing.Size(100, 27);
            this.txtIdProd.TabIndex = 4;
            this.txtIdProd.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvItens.Location = new System.Drawing.Point(12, 446);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.RowHeadersWidth = 51;
            this.dgvItens.Size = new System.Drawing.Size(902, 190);
            this.dgvItens.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "#";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "descrição";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 195;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Un";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Preço R$";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Qtd";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "Desconto";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 195;
            // 
            // Column7
            // 
            this.Column7.Frozen = true;
            this.Column7.HeaderText = "Total";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(534, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "PEDIDO N°";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(625, 73);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(132, 20);
            this.txtId.TabIndex = 1;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(638, 106);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(103, 23);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "+ NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblpedido
            // 
            this.lblpedido.AutoSize = true;
            this.lblpedido.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpedido.ForeColor = System.Drawing.Color.Red;
            this.lblpedido.Location = new System.Drawing.Point(785, 73);
            this.lblpedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpedido.Name = "lblpedido";
            this.lblpedido.Size = new System.Drawing.Size(0, 17);
            this.lblpedido.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Location = new System.Drawing.Point(1211, 446);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 95);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(902, 95);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "descrição";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 195;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Un";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Preço R$";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.Frozen = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "Qtd";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.Frozen = true;
            this.dataGridViewTextBoxColumn6.HeaderText = "Desconto";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 195;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.Frozen = true;
            this.dataGridViewTextBoxColumn7.HeaderText = "Total";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 746);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblpedido);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.grbProdutos);
            this.Controls.Add(this.grbDados);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Name = "FrmPedido";
            this.Text = "FrmPedido";
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            this.grbProdutos.ResumeLayout(false);
            this.grbProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox grbDados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnInserirProduto;
        private System.Windows.Forms.GroupBox grbProdutos;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtUnidade;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtIdProd;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblpedido;
        private System.Windows.Forms.ComboBox cmbAtendente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}