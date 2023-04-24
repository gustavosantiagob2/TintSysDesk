using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TintSysDesk
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        } 
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.MdiParent = this;
            //frmUsuarios.ShowDialog();
            frmUsuarios.Show();
        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.MdiParent = this;
            frmCliente.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmListaCliente frmlistacliente = new FrmListaCliente();
            frmlistacliente.MdiParent = this;
            frmlistacliente.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos frmprdutos = new FrmProdutos();
            frmprdutos.MdiParent = this;
            frmprdutos.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedido frmpedido = new FrmPedido();
            frmpedido.MdiParent = this;
            frmpedido.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoginUsuario frmLoginUsuario = new FrmLoginUsuario();
            frmLoginUsuario.MdiParent = this;
            frmLoginUsuario.Show();
        }
    }
}
