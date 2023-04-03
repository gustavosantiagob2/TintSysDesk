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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmOutrosEnderecos frmOutrosEnderecos = new FrmOutrosEnderecos();
            frmOutrosEnderecos.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            CarregaGridCliente();
        }
        private void CarregaGridCliente()
        {
            List<Cliente> lista = Cliente.Listar();
            int linha = 0;
            dgvClientes.Rows.Clear();
            foreach(Cliente cli in lista)
            {
                dgvClientes.Rows.Add();
                dgvClientes.Rows[linha].Cells[0].Value = cli.Id.ToString();
                dgvClientes.Rows[linha].Cells[1].Value = cli.Nome;
                linha++;
            }
        }
        private void InserirCliente()
        {
            Cliente cliente = new Cliente(txtNomeCliente.Text, mskCpfCliente.Text,
                txtEmailCliente.Text, Convert.ToDateTime(dtmDataCadCliente.Text));
            cliente.Inserir();
            txtidCliente.Text = cliente.Id.ToString();
        }
        private void InserirEndereco(int cliente_id)
        {
            Endereco endereco = new Endereco(Convert.ToString(mskCepCliente.Text), txtlogradouroCliente.Text, txtNomeCliente.Text, txtComplementoCliente.Text, 
                txtBairroCliente.Text, txtCidadeCliente.Text, txtEstadoCliente.Text, txtUfCliente.Text,cmbTipoEndereco.Text,
                Cliente.ObterPorId(Convert.ToInt32(txtidCliente.Text)));
            txtidCliente.Text = cliente_id.ToString();
            endereco.Inserir(cliente_id);
            CarregaGridCliente();
        }
        private void InserirTelefone(int cliente_id)
        {

            Telefone telefone = new Telefone(cmbTipoTelefone.Text,txtNumeroTelefone.Text);
            txtidCliente.Text = cliente_id.ToString();
            telefone.Inserir(cliente_id);

        }

        private void btninserirCliente_Click(object sender, EventArgs e)
        {
            InserirCliente();
            var clientee_id = Cliente.ObterPorId(Convert.ToInt32(txtidCliente.Text));
            int cliente_id = Convert.ToInt32(clientee_id);
            
            while(clientee_id != null)
            {
                InserirTelefone(cliente_id);
                InserirEndereco(cliente_id);
                CarregaGridCliente();
            }
            
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
