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
 
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }
        public Cliente Cliente { get; set; }

        //Metodos construtores
        public Telefone() { }
        public Telefone(int id, string numero, string tipo, Cliente cliente)
        {
            Id = id;
            Numero = numero;
            Tipo = tipo;
            Cliente = cliente;
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
        public void Inserir(int cliente)
        {
            var cmd = Banco.Abir();
            cmd.CommandText = "insert telefones (numero, tipo, cliente_id) value (@numero, @tipo,"+cliente+")";
            cmd.Parameters.Add("@numero", MySqlDbType.VarChar).Value = Numero;
            cmd.Parameters.Add("Tipo", MySqlDbType.VarChar).Value = Tipo;
            cmd.Parameters.Add("@cliente", MySqlDbType.Int32).Value = cliente;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }
        public static List<Telefone> Listar()
        {
            List<Telefone> ListaTel = new List<Telefone>();
            var cmd = Banco.Abir();
            cmd.CommandText = "select * from telefones";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListaTel.Add(new Telefone(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    Cliente.ObterPorId(dr.GetInt32(3))));
            }
            Banco.Fechar(cmd);
            return ListaTel;
        }
        public static List<Telefone> ListarPorCliente (int Cliente)
        {
            List<Telefone> ListaTel = new List<Telefone>();
            var cmd = Banco.Abir();
                cmd.CommandText = "select * from telefones where cliente_id =" + Cliente;
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
        public void Atualizar(int id)
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
