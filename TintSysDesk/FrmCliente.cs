using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TintSysClass;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TintSysDesk
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            CarregarEndereco();


        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(
               mktCpf.Text,txtNomeCliente.Text, txtEmailCliente.Text
                );
            cliente.Inserir();
            txtidCliente.Text = cliente.Id.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Endereco endereco = new Endereco(
               mskCepCliente.Text,txtLogradouroCliente.Text,
                txtNumeroCliente.Text,txtComplementoCliente.Text,txtBairroCliente.Text,
                txtCidadeCliente.Text,txtEstadoCliente.Text,txtUfCliente.Text,cmbTipoEndereco.Text
                );
            endereco.Inserir(txtidCliente.TextLength);
            txtidCliente.Text = endereco.IdCliente.ToString();
        }

        private void btnInserirTelefone_Click(object sender, EventArgs e)
        {
            Telefone telefone = new Telefone(
                mskNumeroTelefone.Text,cmbTipoTelefone.Text
                );
            txtidCliente.Text= telefone.IdCliente.ToString();
        }
        public void CarregarEndereco()
        {
            List<Endereco> lista = Endereco.ListarPorCliente(Convert.ToInt32(txtidCliente.Text));
            int linha = 0;
            dgvEnderecos.Rows.Clear();
            foreach(Endereco endereco in lista)
            {
                dgvEnderecos.Rows.Add();
                dgvEnderecos.Rows[linha].Cells[0].Value = endereco.Cep;
                dgvEnderecos.Rows[linha].Cells[1].Value = endereco.Logradouro;
                dgvEnderecos.Rows[linha].Cells[2].Value = endereco.Numero;
                dgvEnderecos.Rows[linha].Cells[3].Value = endereco.Complemento;
                dgvEnderecos.Rows[linha].Cells[4].Value = endereco.Bairro;
                dgvEnderecos.Rows[linha].Cells[5].Value = endereco.Cidade;
                dgvEnderecos.Rows[linha].Cells[6].Value = endereco.Estado;
                dgvEnderecos.Rows[linha].Cells[7].Value = endereco.Uf;
                dgvEnderecos.Rows[linha].Cells[8].Value = endereco.Tipo;
                dgvEnderecos.Rows[linha].Cells[0].Value = endereco.IdCliente;
                linha++;
            }
        }
    }
}
