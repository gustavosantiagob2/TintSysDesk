﻿using System;
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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(
                txtNome.Text, txtEmail.Text, txtSenha.Text, 
                Nivel.ObterPorID(Convert.ToInt32(comboBox1.SelectedValue))
                );
            usuario.Inserir();
            txtId.Text = usuario.Id.ToString();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Nivel.Listar();
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Nome";

           List<Usuario> lista = Usuario.Listar();
            foreach (Usuario usuario in lista)
            {
                dgvUsuarios.Rows.Add();
            }
        }
    }
}
