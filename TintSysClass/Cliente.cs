using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace TintSysClass
{
    /// <summary>
    /// Classe cliente
    /// </summary>
    public class Cliente
    {
        // Atributos da classe
        private int id;
        private string nome;
        private string cpf;
        private string email;
        private DateTime datacad;
        private bool ativo;


        //Propriedades  (Encapsulamento)
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Datacad { get => datacad; set => datacad = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        public List<Endereco> Enderecos { get; set; }
        public List<Telefone> Telefones { get; set; }

        //public List<Endereco> Enderecos { get; set; }
        //public List<Telefone> Telefone { get; set; }

        //Metodos contrutores
        /// <summary>
        /// Metodo contrutor que retorna vazio
        /// </summary>
        public Cliente() { }
        /// <summary>
        /// Metodo contrutor que retorna todos os campos da tabela cliente 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nome"></param>
        /// <param name="cpf"></param>
        /// <param name="email"></param>
        /// <param name="datacad"></param>
        /// <param name="ativo"></param>
        public Cliente (int id, string nome, string cpf, string email, DateTime datacad, bool ativo
            //List<Telefone> telefones, List<Endereco> Enderecos
            )
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Datacad = datacad;
            Ativo = ativo;
            //telefones = telefones;
            //Enderecos = Enderecos;
        }
        /// <summary>
        /// Metodo contrutor que retorna os campos da tabela sem o id e ativo
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="cpf"></param>
        /// <param name="email"></param>
        /// <param name="datacad"></param>
        public Cliente( string nome, string cpf, string email, DateTime datacad)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Datacad = datacad;
        }
        /// <summary>
        /// Metodo contrutor que retorna os campos da tabela menos o id
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="cpf"></param>
        /// <param name="email"></param>
        /// <param name="datacad"></param>
        /// <param name="ativo"></param>
        public Cliente(string nome, string cpf, string email, DateTime datacad, bool ativo, List<Telefone> telefones, List<Endereco> enderecos)
        { 
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Datacad = datacad;
            Ativo = ativo;
            Telefones = telefones;
            Enderecos = enderecos;
        }
        public Cliente(string nome, string cpf, string email, DateTime datacad, bool ativo)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Datacad = datacad;
            Ativo = ativo;
        }
        public Cliente(string nome, string cpf, string email)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
        }
        public Cliente(int id)
        {
            Telefones = Telefone.ListarPorCliente(Id);
            Enderecos = Endereco.ListarPorCliente(Id);
        }
        //Metodos da classe Cliente
        /// <summary>
        /// Insere no Banco clientes conforme a sequência de Valores
        /// </summary>
        public void Inserir ()
        {
            MySqlCommand comando = Banco.Abir();
            comando.CommandText = "insert clientes (nome, cpf, email, datacad, ativo)" +
                "values (@nome, @cpf, @email, default, default) ";
            comando.Parameters.AddWithValue("@nome", Nome);
            comando.Parameters.AddWithValue("@cpf", Cpf);
            comando.Parameters.AddWithValue("@email", email);
            comando.ExecuteNonQuery();
            comando.CommandText = "select @@identity";
            Id = Convert.ToInt32(comando.ExecuteScalar());
            
            Banco.Fechar(comando);
        }
        /// <summary>
        /// Faz uma pesquisa por id conforme está no banco começando de 1 até a quantidade de clientes no banco cadastrados 
        /// </summary>
        /// <param name="_id">Indetificador de cliente </param>
        /// <returns></returns>
        public static Cliente ObterPorId (int _id)
        {
            Cliente cliente = null;
            var cmd = Banco.Abir();
            cmd.CommandText = "select * from clientes where id = "+_id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cliente = new Cliente(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDateTime(4),
                    dr.GetBoolean(5)
                    );
            }
            Banco.Fechar(cmd);
            return cliente;
        }
        /// <summary>
        /// Faz uma lista de todos os clientes se não colocar nenhum valor (não escrever nada na pesquisa), se colocar um valor vai fazer um like no banco e pequisar
        /// pelo nome conforme as valores que você indicar 
        /// </summary>
        /// <param name="_nome">Nome do cliente que você deseja pesquisar</param>
        /// <returns></returns>
        public static List<Cliente> Listar()
        {
            List<Cliente> Lista = new List<Cliente>();
            var cmd = Banco.Abir();
                cmd.CommandText = "select * from clientes order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                Lista.Add (new Cliente(
                   dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDateTime(4),
                    dr.GetBoolean(5)
                    //Telefone.ObterPorId(dr.GetInt32(6)
                    //Endereco.ObterPorId(dr.GetInt32(7)
                    ));
            }
            Banco.Fechar(cmd);
            return Lista;
            
        }
        /// <summary>
        /// Atualiza o campo de Nome, datacad e se o cliente está ativo
        /// </summary>
        public void Atualizar()
        {
            var cmd = Banco.Abir();
            cmd.CommandText = "update clientes set nome = @nome, datacad = @datacad, ativo = @ativo where id = " +Id;
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.AddWithValue("@datacad",datacad);
            cmd.Parameters.AddWithValue("@ativo", Ativo);
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
        /// <summary>
        /// Restaura o cliente para ser "visto" novamente
        /// </summary>
        /// <param name="_id">Indentificador do cliente</param>
        public static void Restaurar(int _id)
        {
            var cmd = Banco.Abir();
            cmd.CommandText = "update clientes set ativo = 1 where id = " + _id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
        /// <summary>
        ///Arquiva o cliente  
        /// </summary>
        /// <param name="_id">Indentificador do cliente <param>
        public void Arquivar(int _id)
        {
            var cmd = Banco.Abir();
            cmd.CommandText = "update clientes set ativo = 0 where id = " + _id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
        /// <summary>
        /// Exclui o cliente
        /// </summary>
        /// <param name="_id">Indentificador do cliente</param>
        public void Excluir(int _id)
        {
            var cmd = Banco.Abir();
            cmd.CommandText = "delete from clientes where id = " + _id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
    }
}
