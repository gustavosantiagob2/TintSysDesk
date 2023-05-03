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
using static System.Windows.Forms.LinkLabel;

namespace TintSysDesk
{
    public partial class FrmAreaDoUsuario : Form
    {
        public FrmAreaDoUsuario()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void brnEnderecoPessoais_Click(object sender, EventArgs e)
        {
            List<Usuario> lista = Usuario.Listar();
            int linha = 0;
            dgvInformacoes.Rows.Clear();
            foreach (Usuario info in lista)
            {
                dgvInformacoes.Rows.Add();
                dgvInformacoes.Columns["cln1"].HeaderText = "#";
                dgvInformacoes.Rows[linha].Cells["cln1"].Value = info.Id;

                dgvInformacoes.Columns["cln2"].HeaderText = "Nome";
                dgvInformacoes.Rows[linha].Cells["cln2"].Value = info.Nome;

                dgvInformacoes.Columns["cln3"].HeaderText = "E-mail";
                dgvInformacoes.Rows[linha].Cells["cln3"].Value = info.Email;

                dgvInformacoes.Columns["cln4"].Visible = true;
                dgvInformacoes.Columns["cln4"].HeaderText = "Senha";
                dgvInformacoes.Rows[linha].Cells["cln4"].Value = info.Senha;

                dgvInformacoes.Columns["cln5"].Visible = true;
                dgvInformacoes.Columns["cln5"].HeaderText = "Nivel";
                dgvInformacoes.Rows[linha].Cells["cln5"].Value = info.Nivel.Nome;

                
                dgvInformacoes.Columns["cln6"].HeaderText = "Ativo";
                dgvInformacoes.Rows[linha].Cells["cln6"].Value = info.Ativo;

                dgvInformacoes.Columns["cln7"].Visible = false;
                linha++;
            }
            EditarUSuario();

        }
        public void EditarUSuario(string texto = "")
        {
            Usuario u = new Usuario();
            if (txtPesquisa.Text.Length >1)
            {
                txt1.Text = u.Nome.ToString();
                txt2.Text = u.Email.ToString();
                txt3.Text = u.Senha.ToString();
                txt4.Text = u.Senha.ToString();
                txt6.Text = u.Nivel.ToString();
                txt5.Text = u.Ativo.ToString();
                
            }
        }

        private void btnVizuInformacoes_Click(object sender, EventArgs e)
        {
            btnInformacoesPessoais.Enabled = true;
        }
        public void btnVizuInformacoes_DoubleClick(object sender, System.EventArgs e)
        {
            MessageBox.Show("funcionoun", "yghuhh");
            btnInformacoesPessoais.Enabled = false;
        }
        

        private void btnEnderecoPessoais_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void FrmAreaDoUsuario_Load(object sender, EventArgs e)
        {

        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text.Length > 1)
            {
                List<Cliente> list = Cliente.ListarPorCpf(txtPesquisa.Text);
                foreach (Cliente cliente in list)
                {
                    txt1.Text = cliente.Nome;
                    lbl1.Text = "Nome do cliente";
                    txt2.Text = cliente.Cpf;
                    lbl2.Text = "Cpf do cliente";
                    txt3.Text = cliente.Email;
                    lbl3.Text = "E-mail do cliente";
                    maskedTextBox1.Text = Convert.ToString(cliente.Datacad);
                    lbl4.Text = "Data de cadastro";
                    checkBox1.Text = cliente.Ativo.ToString();
                    checkBox1.Text = "Ativo";
                    
                }

            }
            else if (txtPesquisa.Text.Length <= 0)
            {
                txt1.Text = null;
                txt2.Text = null;
                txt3.Text = null;
                maskedTextBox1.Text = null;
                checkBox1.Text = null;
                checkBox1.Text = null;
                lbl1.Text = null;
                lbl2.Text = null;
                lbl3.Text = null;
                lbl4.Text = null;
                checkBox1.Text = null;
            }
        }
        public void CarregaGridPorCpf(string cpf)
        {
            
        }

        private void btnEnderecoClientes_Click(object sender, EventArgs e)
        {
            List<Endereco> lista = Endereco.Listar();
            int linha = 0;
            dgvInformacoes.Rows.Clear();
            foreach (Endereco info in lista)
            {
                dgvInformacoes.Rows.Add();
                dgvInformacoes.Columns["cln1"].HeaderText = "Cep";
                dgvInformacoes.Rows[linha].Cells["cln1"].Value = info.Cep;

                dgvInformacoes.Columns["cln2"].HeaderText = "Logradouro";
                dgvInformacoes.Rows[linha].Cells["cln2"].Value = info.Logradouro;

                dgvInformacoes.Columns["cln3"].HeaderText = "Numero";
                dgvInformacoes.Rows[linha].Cells["cln3"].Value = info.Numero;

                dgvInformacoes.Columns["cln4"].Visible = true;
                dgvInformacoes.Columns["cln4"].HeaderText = "Complemento";
                dgvInformacoes.Rows[linha].Cells["cln4"].Value = info.Complemento;

                dgvInformacoes.Columns["cln5"].Visible = true;
                dgvInformacoes.Columns["cln5"].HeaderText = "Bairro";
                dgvInformacoes.Rows[linha].Cells["cln5"].Value = info.Bairro;

                dgvInformacoes.Columns["cln6"].Visible = true;
                dgvInformacoes.Columns["cln6"].HeaderText = "Cidade";
                dgvInformacoes.Rows[linha].Cells["cln6"].Value = info.Cidade;

                dgvInformacoes.Columns["cln7"].Visible = true;
                dgvInformacoes.Columns["cln7"].HeaderText = "Estado";
                dgvInformacoes.Rows[linha].Cells["cln7"].Value = info.Estado;

                
                linha++;
            }
        }

        private void btnVizuClientes_Click(object sender, EventArgs e)
        {
            btnEnderecoClientes.Enabled = true;
            lblPesquisa.Text = "Pesquisar por cpf";
            btnTelefoneClientes.Enabled = true;
            btnInfoCliente.Enabled = true;
        }

        private void btnInfoCliente_Click(object sender, EventArgs e)
        {
            List<Cliente> lista = Cliente.Listar();
            int linha = 0;
            dgvInformacoes.Rows.Clear();
            foreach (Cliente info in lista)
            {
                dgvInformacoes.Rows.Add();
                dgvInformacoes.Columns["cln1"].HeaderText = "#";
                dgvInformacoes.Rows[linha].Cells["cln1"].Value = info.Id;

                dgvInformacoes.Columns["cln2"].HeaderText = "Nome";
                dgvInformacoes.Rows[linha].Cells["cln2"].Value = info.Nome;

                dgvInformacoes.Columns["cln3"].HeaderText = "Cpf";
                dgvInformacoes.Rows[linha].Cells["cln3"].Value = info.Cpf;

                dgvInformacoes.Columns["cln4"].Visible = true;
                dgvInformacoes.Columns["cln4"].HeaderText = "E-mail";
                dgvInformacoes.Rows[linha].Cells["cln4"].Value = info.Email;

                dgvInformacoes.Columns["cln5"].Visible = true;
                dgvInformacoes.Columns["cln5"].HeaderText = "Data de Cadastro";
                dgvInformacoes.Rows[linha].Cells["cln5"].Value = info.Datacad;

                dgvInformacoes.Columns["cln6"].Visible = true;
                dgvInformacoes.Columns["cln6"].HeaderText = "Ativo";
                dgvInformacoes.Rows[linha].Cells["cln6"].Value = info.Ativo;

                dgvInformacoes.Columns["cln7"].Visible = false;
                linha++;
            }
        }

        private void btnTelefoneClientes_Click(object sender, EventArgs e)
        {
            List<Telefone> lista = Telefone.Listar();
            int linha = 0;
            dgvInformacoes.Rows.Clear();
            foreach (Telefone info in lista)
            {
                dgvInformacoes.Rows.Add();
                dgvInformacoes.Columns["cln1"].HeaderText = "Tipo de Contato";
                dgvInformacoes.Rows[linha].Cells["cln1"].Value = info.Tipo;

                dgvInformacoes.Columns["cln2"].HeaderText = "Numero";
                dgvInformacoes.Rows[linha].Cells["cln2"].Value = info.Numero;

                dgvInformacoes.Columns["cln3"].HeaderText = "Nome do Cliente";
                dgvInformacoes.Rows[linha].Cells["cln3"].Value = info.Cliente.Nome;

                dgvInformacoes.Columns["cln4"].Visible= false;
                dgvInformacoes.Columns["cln5"].Visible = false;
                dgvInformacoes.Columns["cln6"].Visible = false;
                dgvInformacoes.Columns["cln7"].Visible = false;
                linha++;
            }
        }

        private void btnVizuProdutos_Click(object sender, EventArgs e)
        {
            btnEdiProdutos.Enabled = true;
            btnProdutosEstoque.Enabled = true;
            btnProdutos.Enabled = true;
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            List<Produto> lista = Produto.Listar();
            int linha = 0;
            dgvInformacoes.Rows.Clear();
            foreach (Produto info in lista)
            {

                dgvInformacoes.Rows.Add();
                dgvInformacoes.Columns["cln1"].HeaderText = "Nome";
                dgvInformacoes.Rows[linha].Cells["cln1"].Value = info.Descricao;

                dgvInformacoes.Columns["cln2"].HeaderText = "Tipo de unidade";
                dgvInformacoes.Rows[linha].Cells["cln2"].Value = info.Unidade;

                dgvInformacoes.Columns["cln3"].HeaderText = "Codigo de barra";
                dgvInformacoes.Rows[linha].Cells["cln3"].Value = info.CodBar;

                dgvInformacoes.Columns["cln4"].Visible = true;
                dgvInformacoes.Columns["cln4"].HeaderText = "Preço";
                dgvInformacoes.Rows[linha].Cells["cln4"].Value = info.Preco;

                dgvInformacoes.Columns["cln5"].Visible = true;
                dgvInformacoes.Columns["cln5"].HeaderText = "desconto";
                dgvInformacoes.Rows[linha].Cells["cln5"].Value = info.Desconto;

                dgvInformacoes.Columns["cln6"].Visible = true;
                dgvInformacoes.Columns["cln6"].HeaderText = "Descontinuado";
                dgvInformacoes.Rows[linha].Cells["cln6"].Value = info.Descontinuado;
                linha++;
            }
        }

        private void dgvInformacoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dgvInformacoes["#", e.RowIndex].Value);
            Cliente cliente = Cliente.ObterPorId(id);


        }

        private void grbEdicao_Enter(object sender, EventArgs e)
        {

        }

        private void btnEdiInformacoes_Click(object sender, EventArgs e)
        {

        }

        private void btnVizuInformacoes_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
