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
                dgvInformacoes.Columns["cln1"].HeaderText = "Nome";
                dgvInformacoes.Rows[linha].Cells["cln1"].Value = info.Nome;

                dgvInformacoes.Columns["cln2"].HeaderText = "E-mail";
                dgvInformacoes.Rows[linha].Cells["cln2"].Value = info.Email;

                dgvInformacoes.Columns["cln3"].HeaderText = "Senha";
                dgvInformacoes.Rows[linha].Cells["cln3"].Value = info.Senha;

                dgvInformacoes.Columns["cln4"].HeaderText = "Nivel";
                dgvInformacoes.Rows[linha].Cells["cln4"].Value = info.Nivel.Nome;
                dgvInformacoes.Columns["cln5"].HeaderText = "Ativo";
                dgvInformacoes.Rows[linha].Cells["cln5"].Value = info.Ativo;
                dgvInformacoes.Columns["cln6"].Visible = false;
                dgvInformacoes.Columns["cln7"].Visible = false;
                linha++;
            }
        }

        private void btnVizuInformacoes_Click(object sender, EventArgs e)
        {
            btnEnderecoPessoais.Enabled = true;
        }

        private void btnEnderecoPessoais_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Clicks >= 2)
            {
                dgvInformacoes.Rows.Clear();
                dgvInformacoes.Columns.Clear();
            }
        }
    }
}
