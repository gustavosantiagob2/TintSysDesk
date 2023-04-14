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
            cmbCliente.DisplayMember = "Nome";
            cmbCliente.ValueMember = "Id";

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
        }
    }
}
