namespace TintSysDesk
{
    partial class FrmUsuarios
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNível = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInserirNivel = new System.Windows.Forms.Button();
            this.btnConsultarNivel = new System.Windows.Forms.Button();
            this.btnEditarNivel = new System.Windows.Forms.Button();
            this.txtIdNivel = new System.Windows.Forms.TextBox();
            this.txtNomeNivel = new System.Windows.Forms.TextBox();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvNiveis = new System.Windows.Forms.DataGridView();
            this.clnIdNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNomeNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDeleteNivel = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 288);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(312, 251);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(70, 321);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(100, 28);
            this.btnInserir.TabIndex = 2;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 321);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(335, 321);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(143, 182);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(275, 22);
            this.txtNome.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(143, 214);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(275, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(143, 150);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(135, 22);
            this.txtId.TabIndex = 8;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(143, 251);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(87, 22);
            this.txtSenha.TabIndex = 9;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(352, 150);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 20);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Ativo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 255);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nivel";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnNome,
            this.clnEmail,
            this.clnNível,
            this.clnAtivo});
            this.dgvUsuarios.Location = new System.Drawing.Point(35, 375);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(650, 200);
            this.dgvUsuarios.TabIndex = 16;
            // 
            // clnId
            // 
            this.clnId.Frozen = true;
            this.clnId.HeaderText = "ID";
            this.clnId.MinimumWidth = 6;
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Width = 40;
            // 
            // clnNome
            // 
            this.clnNome.Frozen = true;
            this.clnNome.HeaderText = "Nome";
            this.clnNome.MinimumWidth = 6;
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            this.clnNome.Width = 174;
            // 
            // clnEmail
            // 
            this.clnEmail.Frozen = true;
            this.clnEmail.HeaderText = "Email";
            this.clnEmail.MinimumWidth = 6;
            this.clnEmail.Name = "clnEmail";
            this.clnEmail.ReadOnly = true;
            this.clnEmail.Width = 174;
            // 
            // clnNível
            // 
            this.clnNível.Frozen = true;
            this.clnNível.HeaderText = "Nível";
            this.clnNível.MinimumWidth = 6;
            this.clnNível.Name = "clnNível";
            this.clnNível.ReadOnly = true;
            this.clnNível.Width = 125;
            // 
            // clnAtivo
            // 
            this.clnAtivo.Frozen = true;
            this.clnAtivo.HeaderText = "Ativo";
            this.clnAtivo.MinimumWidth = 6;
            this.clnAtivo.Name = "clnAtivo";
            this.clnAtivo.ReadOnly = true;
            this.clnAtivo.Width = 60;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNiveis);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSigla);
            this.groupBox1.Controls.Add(this.btnEditarNivel);
            this.groupBox1.Controls.Add(this.txtNomeNivel);
            this.groupBox1.Controls.Add(this.btnConsultarNivel);
            this.groupBox1.Controls.Add(this.txtIdNivel);
            this.groupBox1.Controls.Add(this.btnInserirNivel);
            this.groupBox1.Location = new System.Drawing.Point(636, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 337);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Níveis";
            // 
            // btnInserirNivel
            // 
            this.btnInserirNivel.FlatAppearance.BorderSize = 0;
            this.btnInserirNivel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
            this.btnInserirNivel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnInserirNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirNivel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirNivel.Image = global::TintSysDesk.Properties.Resources.Add;
            this.btnInserirNivel.Location = new System.Drawing.Point(54, 138);
            this.btnInserirNivel.Name = "btnInserirNivel";
            this.btnInserirNivel.Size = new System.Drawing.Size(84, 69);
            this.btnInserirNivel.TabIndex = 0;
            this.btnInserirNivel.Text = "Inserir";
            this.btnInserirNivel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInserirNivel.UseVisualStyleBackColor = true;
            this.btnInserirNivel.Click += new System.EventHandler(this.btnInserirNivel_Click);
            // 
            // btnConsultarNivel
            // 
            this.btnConsultarNivel.FlatAppearance.BorderSize = 0;
            this.btnConsultarNivel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
            this.btnConsultarNivel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnConsultarNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarNivel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarNivel.Image = global::TintSysDesk.Properties.Resources.Search;
            this.btnConsultarNivel.Location = new System.Drawing.Point(144, 137);
            this.btnConsultarNivel.Name = "btnConsultarNivel";
            this.btnConsultarNivel.Size = new System.Drawing.Size(100, 70);
            this.btnConsultarNivel.TabIndex = 1;
            this.btnConsultarNivel.Text = "Consultar";
            this.btnConsultarNivel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarNivel.UseVisualStyleBackColor = true;
            this.btnConsultarNivel.Click += new System.EventHandler(this.btnConsultarNivel_Click);
            // 
            // btnEditarNivel
            // 
            this.btnEditarNivel.FlatAppearance.BorderSize = 0;
            this.btnEditarNivel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
            this.btnEditarNivel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEditarNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarNivel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarNivel.Image = global::TintSysDesk.Properties.Resources.Edit;
            this.btnEditarNivel.Location = new System.Drawing.Point(241, 138);
            this.btnEditarNivel.Name = "btnEditarNivel";
            this.btnEditarNivel.Size = new System.Drawing.Size(103, 69);
            this.btnEditarNivel.TabIndex = 2;
            this.btnEditarNivel.Text = "Editar";
            this.btnEditarNivel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditarNivel.UseVisualStyleBackColor = true;
            this.btnEditarNivel.Click += new System.EventHandler(this.btnEditarNivel_Click);
            // 
            // txtIdNivel
            // 
            this.txtIdNivel.Location = new System.Drawing.Point(121, 41);
            this.txtIdNivel.Name = "txtIdNivel";
            this.txtIdNivel.Size = new System.Drawing.Size(50, 22);
            this.txtIdNivel.TabIndex = 18;
            // 
            // txtNomeNivel
            // 
            this.txtNomeNivel.Location = new System.Drawing.Point(121, 69);
            this.txtNomeNivel.Name = "txtNomeNivel";
            this.txtNomeNivel.Size = new System.Drawing.Size(223, 22);
            this.txtNomeNivel.TabIndex = 19;
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(121, 97);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(162, 22);
            this.txtSigla.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Nome";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Sigla";
            // 
            // dgvNiveis
            // 
            this.dgvNiveis.AllowUserToAddRows = false;
            this.dgvNiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNiveis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnIdNivel,
            this.clnNomeNivel,
            this.clnSigla,
            this.clnDeleteNivel});
            this.dgvNiveis.Location = new System.Drawing.Point(56, 230);
            this.dgvNiveis.Name = "dgvNiveis";
            this.dgvNiveis.ReadOnly = true;
            this.dgvNiveis.RowHeadersVisible = false;
            this.dgvNiveis.RowHeadersWidth = 51;
            this.dgvNiveis.RowTemplate.Height = 24;
            this.dgvNiveis.Size = new System.Drawing.Size(320, 101);
            this.dgvNiveis.TabIndex = 24;
            // 
            // clnIdNivel
            // 
            this.clnIdNivel.Frozen = true;
            this.clnIdNivel.HeaderText = "ID";
            this.clnIdNivel.MinimumWidth = 6;
            this.clnIdNivel.Name = "clnIdNivel";
            this.clnIdNivel.ReadOnly = true;
            this.clnIdNivel.Width = 40;
            // 
            // clnNomeNivel
            // 
            this.clnNomeNivel.Frozen = true;
            this.clnNomeNivel.HeaderText = "Nome";
            this.clnNomeNivel.MinimumWidth = 6;
            this.clnNomeNivel.Name = "clnNomeNivel";
            this.clnNomeNivel.ReadOnly = true;
            this.clnNomeNivel.Width = 120;
            // 
            // clnSigla
            // 
            this.clnSigla.Frozen = true;
            this.clnSigla.HeaderText = "Sigla";
            this.clnSigla.MinimumWidth = 6;
            this.clnSigla.Name = "clnSigla";
            this.clnSigla.ReadOnly = true;
            this.clnSigla.Width = 80;
            // 
            // clnDeleteNivel
            // 
            this.clnDeleteNivel.Frozen = true;
            this.clnDeleteNivel.HeaderText = "Ação";
            this.clnDeleteNivel.MinimumWidth = 6;
            this.clnDeleteNivel.Name = "clnDeleteNivel";
            this.clnDeleteNivel.ReadOnly = true;
            this.clnDeleteNivel.Text = "Excluir";
            this.clnDeleteNivel.Width = 80;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 611);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUsuarios";
            this.Text = "Adminstração de Usuários";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNível;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnAtivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Button btnEditarNivel;
        private System.Windows.Forms.TextBox txtNomeNivel;
        private System.Windows.Forms.Button btnConsultarNivel;
        private System.Windows.Forms.TextBox txtIdNivel;
        private System.Windows.Forms.Button btnInserirNivel;
        private System.Windows.Forms.DataGridView dgvNiveis;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdNivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNomeNivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSigla;
        private System.Windows.Forms.DataGridViewButtonColumn clnDeleteNivel;
    }
}