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

namespace TintSysDesk
{
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            grbDados.Enabled = true;
            
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            cmbCliente.DataSource = Cliente.Listar();
            cmbCliente.DisplayMember= "Nome";
            cmbCliente.ValueMember= "Id";

            cmbAtendente.DataSource = Usuario.Listar();
            cmbAtendente.DisplayMember = "Nome";
            cmbAtendente.ValueMember = "Id";
        }

        private void btnInserirProduto_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido(
                Cliente.ObterPorId(Convert.ToInt32(cmbCliente.SelectedValue)),
               Usuario.ObterPorId(Convert.ToInt32(cmbAtendente.SelectedValue)));
            pedido.Inserir();
            Pedido newped = Pedido.ObterPorId(pedido.Id);
            lblpedido.Text = newped.Status + " - "+newped.Hashcode;
            txtId.Text = newped.Id.ToString();

            grbDados.Enabled= false;
            grbProdutos.Enabled= true;
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ItemPedido item = new ItemPedido(
                Convert.ToInt32(txtId.Text), Produto.ObterPorId(Convert.ToInt32(txtIdProd.Text)),
                Convert.ToDouble(txtPreco.Text), Convert.ToDouble(txtQuantidade.Text), Convert.ToDouble(txtDesconto.Text)
                );
            item.Inserir();
            CarregaGrid();
        }
        public void CarregaGrid() 
        {
            List<ItemPedido> items = ItemPedido.ListarPorPedido(Convert.ToInt32(txtId.Text));
            dgvItens.Rows.Clear();
            double subTotal = 0;
            int count = 0;
            foreach (var item in items)
            {
                dgvItens.Rows.Add();
                dgvItens.Rows[count].Cells[0].Value = count + 1;
                dgvItens.Rows[count].Cells[1].Value = item.Produto.Id;
                dgvItens.Rows[count].Cells[2].Value = item.Produto.Descricao;
                dgvItens.Rows[count].Cells[3].Value = item.Produto.Unidade;
                dgvItens.Rows[count].Cells[4].Value = item.Preco;
                dgvItens.Rows[count].Cells[5].Value = item.Quantidade;
                dgvItens.Rows[count].Cells[6].Value = item.Desconto;
                double valorItem = item.Preco * item.Quantidade-item.Desconto;
                dgvItens.Rows[count].Cells[7].Value = valorItem;
                subTotal += valorItem;
                count++;
            }
            txtTotal.Text = subTotal.ToString();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (txtIdProd.Text.Length > 0)
            {
                Produto produto = Produto.ObterPorId(Convert.ToInt32(txtIdProd.Text));
                if (produto != null) 
                { 
                    txtDescricao.Text = produto.Descricao;
                    txtPreco.Text = produto.Preco.ToString();
                    txtUnidade.Text = produto.Unidade.ToString();
                }
            }

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
