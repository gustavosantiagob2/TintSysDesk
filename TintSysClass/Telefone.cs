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
        private Cliente cliente;

        //Propriedades (encapsulamento) 
        public int Id { get => id; set => id = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }

        //Metodos construtores
        public Telefone() { }
        public Telefone(int id, string numero, string tipo, Cliente cliente)
        {
            Id = id;
            Numero = numero;
            Tipo = tipo;
            Cliente = cliente;
        }
        public Telefone(string numero, string tipo, Cliente cliente)
        {
           Numero = numero;
           Tipo = tipo;   
           Cliente = cliente;
        }
        public Telefone (string numero, string tipo)
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
            cmd.CommandText = "insert telefones (cliente_id, numero, tipo) values (@numero, @tipo)";
            cmd.Parameters.AddWithValue("@cliente_id", Cliente);
            cmd.Parameters.AddWithValue("@numero", Numero);
            cmd.Parameters.AddWithValue("@tipo", Tipo);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@indentity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }
        public static Telefone ObterPorId(int id)
        {
            Telefone telefone = null;
            var cmd = Banco.Abir();
            cmd.CommandText = "select * from telefones where id ="+id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                telefone = new Telefone(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    Cliente.ObterPorId(dr.GetInt32(3))
                    );
            }
            Banco.Fechar(cmd);
            return telefone;    
        }
        /// <summary>
        /// Faz uma lista de todos os numeros de telefones se não colocar nenhum valor (não escrever nada na pesquisa), se colocar um valor vai fazer um like no banco e pequisar
        /// pelo numero conforme as valores que você indicar
        /// </summary>
        /// <param name="numero">Indetificador do número do cliente </param>
        /// <returns></returns>
        public static List<Telefone> Listar (string numero = "")
        {
            List<Telefone> Lista = new List<Telefone>();
            var cmd = Banco.Abir();
            if (numero != string.Empty)
                cmd.CommandText = "select * from telefones where like '%" + numero + "%'";
            else
                cmd.CommandText = "select * from telefones";
            var dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                Lista.Add(new Telefone(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    Cliente.ObterPorId(dr.GetInt32(3))                    
                    ));
            }
            Banco.Fechar (cmd);
            return Lista;
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
