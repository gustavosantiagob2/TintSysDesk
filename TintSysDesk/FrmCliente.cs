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
            CarregarGrid();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            InserirCLiente();
        }
        private void InserirCLiente()
        {
            Cliente cliente = new Cliente(
               mktCpf.Text, txtNomeCliente.Text, txtEmailCliente.Text
                );
            cliente.Inserir();
            txtidCliente.Text = cliente.Id.ToString();
            CarregarGrid();
        }
        public void CarregarGrid()
        {
            List<Cliente> lista = Cliente.Listar();
            int count = 0;
            dgvCliente.Rows.Clear();
            foreach(Cliente cli in lista)
            {
                dgvCliente.Rows.Add();
                dgvCliente.Rows[count].Cells[0].Value = cli.Id.ToString();
                dgvCliente.Rows[count].Cells[1].Value = cli.Nome;
                dgvCliente.Rows[count].Cells[2].Value = cli.Cpf;
                dgvCliente.Rows[count].Cells[3].Value = cli.Email;
                count++;

            }
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Endereco endereco = new Endereco(
               mskCepCliente.Text, txtLogradouroCliente.Text, txtNumeroEndereco.Text,
                txtComplementoCliente.Text, txtBairroCliente.Text, txtCidadeCliente.Text,
                txtEstadoCliente.Text, txtUfCliente.Text,
                cmbTipoEndereco.Text, Cliente.ObterPorId(Convert.ToInt32((txtidCliente.Text))));
            endereco.Inserir(Convert.ToInt32(txtidCliente.TextLength));
            CarregarEndereco();
           
        }
        public void CarregarEndereco()
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Endereco> lista = Endereco.ListarPorCliente(Convert.ToInt32(txtidCliente.TextLength));
            int count = 0;
            dgvEnderecos.Rows.Clear();
            foreach (Endereco ende in lista)
            {
                dgvEnderecos.Rows.Add();
                dgvEnderecos.Rows[count].Cells[0].Value = ende.Cep;
                dgvEnderecos.Rows[count].Cells[0].Value = ende.Logradouro;
                dgvEnderecos.Rows[count].Cells[0].Value = ende.Numero;
                dgvEnderecos.Rows[count].Cells[0].Value = ende.Complemento;
                dgvEnderecos.Rows[count].Cells[0].Value = ende.Bairro;
                dgvEnderecos.Rows[count].Cells[0].Value = ende.Cidade;
                dgvEnderecos.Rows[count].Cells[0].Value = ende.Estado;
                dgvEnderecos.Rows[count].Cells[0].Value = ende.Uf;
                dgvEnderecos.Rows[count].Cells[0].Value = ende.Tipo;
                dgvEnderecos.Rows[count].Cells[0].Value = ende.Cliente;
                count++;
            }
        }
    }
}
