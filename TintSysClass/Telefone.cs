using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TintSysClass
{
    public class Telefone
    {
        // Atributos da classe
        private int id;
        private string numero;
        private string tipo;
        private Cliente idCliente;

        //Propriedades (encapsulamento) 
        public int Id { get => id; set => id = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public Cliente IdCliente { get => idCliente; set => idCliente = value; }


        //Metodos construtores
        public Telefone() { }
        public Telefone(int id, string numero, string tipo, Cliente idCliente)
        {
            Id = id;
            Numero = numero;
            Tipo = tipo;
            IdCliente = idCliente;
        }
        public Telefone(int id, string numero, string tipo)
        {
            Id = id;
            Numero = numero;
            Tipo = tipo;
        }
        public Telefone(string numero, string tipo)
        {
            Numero = numero;
            Tipo = tipo;
        }

        //Metodos da classe
        /// <summary>
        /// Insere no Banco usuários conforme a sequência de Valores
        /// </summary>
        public void Inserir(int cliente_id)
        {
            MySqlCommand cmd = Banco.Abir();
            cmd.CommandText = "insert telefones (cliente_di, numero, tipo) " +
                "values (" + cliente_id + ", '" + Numero + "', '" + Tipo + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@indentity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }
        public static List<Telefone> ListarPorCliente (int cliente_id)
        {
            List<Telefone> ListaTel = new List<Telefone>();
            var cmd = Banco.Abir();
                cmd.CommandText = "select numero, tipo, id  from telefones where cliente_id =" + cliente_id;
            var dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                ListaTel.Add(new Telefone(
                    dr.GetInt32(2),
                    dr.GetString(0),
                    dr.GetString(1)));
            }
            Banco.Fechar (cmd);
            return ListaTel;
        }
        /// <summary>
        /// Atualiza o campo de Numero e do Tipo
        /// </summary>
        public void Atualizar()
        {
            var cmd = Banco.Abir();
            cmd.CommandText = "update telefones set numero = @numero, tipo = @tipo where id ="+Id;
            cmd.Parameters.Add("@numero",MySqlDbType.VarChar).Value = Numero;
            cmd.Parameters.Add("@tipo", MySqlDbType.VarChar).Value = Tipo;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        public void Excluir (int id)
        {
            var cmd = Banco.Abir();
            cmd.CommandText = "delet from telefones where id ="+id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
      
    }
}
