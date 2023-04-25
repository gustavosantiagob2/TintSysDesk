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
    public partial class FrmLoginUsuario : Form
    {
        public FrmLoginUsuario()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
   
            if (txtEmail.Text != string.Empty)
            {
                if (txtSenha.Text != string.Empty)
                {
                    
                    Usuario usuario = new Usuario(
                    txtEmail.Text, txtSenha.Text);
                    Usuario.EfetuarLogin(txtEmail.Text, txtSenha.Text);
                    FrmAreaDoUsuario frm = new FrmAreaDoUsuario();
                    frm.ShowDialog();
                    
                }
           
            }
            else
            {
                lblRecuperacao.ForeColor = Color.FromArgb(232,22,22);
                lblRecuperacao.Text = "clique aqui para se cadastrar";
                btnCadastro.Enabled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
