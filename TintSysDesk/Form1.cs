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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var n = Nivel.ObterPorID(1);
            label1.Text = n.Id.ToString();
            label2.Text = n.Nome;
            label3.Text = n.Sigla;

            comboBox1.DataSource = Nivel.Listar();
            comboBox1.DisplayMember = "Nome";
            comboBox1.ValueMember = "id";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Text = comboBox1.SelectedIndex.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nivel nivel = new Nivel(1, "Estoquista", "EST");
            nivel.Atualizar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Nivel nivel = new Nivel();
            //int msg = nivel.Excluir(2);
            //if (msg ==1)
            //    MessageBox.Show("Nível excluido com sucesso!");
            //else if (msg ==2)
            //    MessageBox.Show("Falha ao excluir um nivel");
            //else (msg ==0)
            //        MessageBox.Show("Falha ao excluir");
        }
    }
}
