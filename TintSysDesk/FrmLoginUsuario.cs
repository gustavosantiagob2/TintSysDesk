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
                Usuario usuario = new Usuario(
                txtEmail.Text, txtSenha.Text
                 );
                string email = txtEmail.Text;
                string senha = txtSenha.Text;
                Usuario.EfetuarLogin(txtEmail.Text, txtSenha.Text);
            }
            else if (txtSenha.Text == string.Empty)
            {
                MessageBox.Show("Você não digitou sua senha","Erro");
            }
            else if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Você não digitou seu e-mail", "Erro");
                Enabled= false;
            }
            else
            {
       
            }
        }
    }
}
