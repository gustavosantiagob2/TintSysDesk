namespace TintSysDesk
{
    partial class FrmListaCliente
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
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.btnListarTelefone = new System.Windows.Forms.Button();
            this.btnListarEndereco = new System.Windows.Forms.Button();
            this.btnListarCliente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtListarPorCpf = new System.Windows.Forms.TextBox();
            this.grbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCliente
            // 
            this.grbCliente.Controls.Add(this.btnListarTelefone);
            this.grbCliente.Controls.Add(this.btnListarEndereco);
            this.grbCliente.Controls.Add(this.btnListarCliente);
            this.grbCliente.Controls.Add(this.dataGridView1);
            this.grbCliente.Controls.Add(this.label1);
            this.grbCliente.Controls.Add(this.txtListarPorCpf);
            this.grbCliente.Location = new System.Drawing.Point(9, 26);
            this.grbCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbCliente.Size = new System.Drawing.Size(647, 306);
            this.grbCliente.TabIndex = 0;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "Clientes";
            // 
            // btnListarTelefone
            // 
            this.btnListarTelefone.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarTelefone.Location = new System.Drawing.Point(309, 76);
            this.btnListarTelefone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListarTelefone.Name = "btnListarTelefone";
            this.btnListarTelefone.Size = new System.Drawing.Size(94, 28);
            this.btnListarTelefone.TabIndex = 3;
            this.btnListarTelefone.Text = "Telefone";
            this.btnListarTelefone.UseVisualStyleBackColor = true;
            // 
            // btnListarEndereco
            // 
            this.btnListarEndereco.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarEndereco.Location = new System.Drawing.Point(210, 76);
            this.btnListarEndereco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListarEndereco.Name = "btnListarEndereco";
            this.btnListarEndereco.Size = new System.Drawing.Size(94, 28);
            this.btnListarEndereco.TabIndex = 3;
            this.btnListarEndereco.Text = "Endereço";
            this.btnListarEndereco.UseVisualStyleBackColor = true;
            // 
            // btnListarCliente
            // 
            this.btnListarCliente.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarCliente.Location = new System.Drawing.Point(110, 76);
            this.btnListarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListarCliente.Name = "btnListarCliente";
            this.btnListarCliente.Size = new System.Drawing.Size(94, 28);
            this.btnListarCliente.TabIndex = 3;
            this.btnListarCliente.Text = "Cliente";
            this.btnListarCliente.UseVisualStyleBackColor = true;
            this.btnListarCliente.Click += new System.EventHandler(this.btnListarCliente_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 117);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(636, 168);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisar pro cliente por cpf";
            // 
            // txtListarPorCpf
            // 
            this.txtListarPorCpf.Enabled = false;
            this.txtListarPorCpf.Location = new System.Drawing.Point(4, 45);
            this.txtListarPorCpf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtListarPorCpf.Name = "txtListarPorCpf";
            this.txtListarPorCpf.Size = new System.Drawing.Size(619, 20);
            this.txtListarPorCpf.TabIndex = 0;
            // 
            // FrmListaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 460);
            this.Controls.Add(this.grbCliente);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmListaCliente";
            this.Text = "FrmListaCliente";
            this.grbCliente.ResumeLayout(false);
            this.grbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtListarPorCpf;
        private System.Windows.Forms.Button btnListarTelefone;
        private System.Windows.Forms.Button btnListarEndereco;
        private System.Windows.Forms.Button btnListarCliente;
    }
}