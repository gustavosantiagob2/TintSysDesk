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
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(
                txtDescricao.Text,cmbUnidade.Text,txtCodBar.Text,double.Parse(mskPreco.Text),double.Parse(txtDesconto.Text));
            produto.Inserir();
            if (produto.Id >0)
            {
                txtId.Text = produto.Id.ToString();
                MessageBox.Show("produto gravado com sucesso!!", "Gravado");
                CarregarGrid();
            }
            else 
            {
                MessageBox.Show("Falha ao gravar o produto!!", "Erro de Gravação");
            }
        }
        private void CarregarGrid()
        {
            var lista = Produto.Listar();
            int count = 0;
            dgvProduto.Rows.Clear();
            foreach (Produto item in lista) 
            {
                dgvProduto.Rows.Add();
                dgvProduto.Rows[count].Cells[0].Value = item.Id;
                dgvProduto.Rows[count].Cells[1].Value = item.Descricao;
                dgvProduto.Rows[count].Cells[2].Value = item.Unidade;
                dgvProduto.Rows[count].Cells[3].Value = item.CodBar;
                dgvProduto.Rows[count].Cells[4].Value = item.Preco.ToString("R$ ##0.00");
                dgvProduto.Rows[count].Cells[5].Value = item.Desconto.ToString("#.##%");
                dgvProduto.Rows[count].Cells[3].Value = item.Descontinuado;
                count++;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (btnBuscar.Text =="...")
            {
                txtId.ReadOnly = false;
                txtId.Focus();
                btnBuscar.Text = "Buscar";
            }
            else if(txtId.Text != String.Empty)
            {
                txtId.ReadOnly = true;
                btnBuscar.Text = "...";
                var produto = Produto.ObterPorId(int.Parse(txtId.Text));
                txtDescricao.Text = produto.Descricao;
                txtCodBar.Text = produto.CodBar;
                txtDesconto.Text = produto.Desconto.ToString("#,##%");
                mskPreco.Text = produto.Preco.ToString("R$ ##.00");
                //cmbUnidade.SelectedIndex = 0;

            }
        }
    }
}
