using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TintSysClass
{
    /// <summary>
    ///  classe de Usuario coms os metodos EfetuarLogin, Inserir, ObterPorId, Listar, Atualizar
    /// </summary>
    public class Usuario
    {
        private int id;
        private string nome;
        private string email;
        private string senha;
        private Nivel nivel;
        private bool ativo;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public Nivel Nivel { get => nivel; set => nivel = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        /// <summary>
        /// Retona os campos e os parametros vazio
        /// </summary>
        public Usuario() { }
        /// <summary>
        /// Retorna todos os campos e parametros 
        /// </summary>
        /// <param name="id">Indentificador conforme está no banco</param>
        /// <param name="nome">Nome do usuario conforme está no banco</param>
        /// <param name="email">Email do usuario conforme está no banco</param>
        /// <param name="senha">Senha do usuario conforme está no banco</param>
        /// <param name="nivel">Nivel do usuario conforme está no banco</param>
        /// <param name="ativo">Ver se o usuario está ativo conforme está no banco</param>
        public Usuario(int id, string nome, string email, string senha, Nivel nivel, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }
        /// <summary>
        /// Retorna os parametros e campos sem o Id e o Ativo
        /// </summary>
        /// <param name="nome">Nome do usuario conforme está no banco</param>
        /// <param name="email">Email do usuario conforme está no banco</param>
        /// <param name="senha">Senha do usuario conforme está no banco</param>
        /// <param name="nivel">Nivel do usuario conforme está no banco</param>
        public Usuario (string nome, string email, string senha, Nivel nivel)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
        }
        /// <summary>
        /// Retorna os campos e parametros sem o Id
        /// </summary>
        /// <param name="nome">Nome do usuario conforme está no banco</param>
        /// <param name="email">Email do usuario conforme está no banco</param>
        /// <param name="senha">Senha do usuario conforme está no banco</param>
        /// <param name="nivel">Nivel do usuario conforme está no banco</param>
        /// <param name="ativo">Ver se o usuario está ativo conforme está no banco</param>
        public Usuario(string nome, string email, string senha, Nivel nivel, bool ativo)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }
        /// <summary>
        /// Metodo para efuetua o login se o usuário for ativo se não for ativo nem permite efetuar o login
        /// </summary>
        /// <param name="_email">Email cadastrado</param>
        /// <param name="_senha">Senha cadastrada</param>
        /// <returns></returns>
        public static Usuario EfetuarLogin(string _email, string _senha)
        {
                 
            Usuario usuario = null;
            MySqlCommand cmd = Banco.Abir();
            cmd.CommandText = "select id, nome, email, nivel from usuarios " +
                "where email = @email and senha = md5(@senha) and ativo = 1";
            cmd.Parameters.AddWithValue("@email", _email);
            cmd.Parameters.AddWithValue("@senha", _senha);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuario = new Usuario();
                usuario.Id = dr.GetInt32(0);
                usuario.Nome = dr.GetString(1);
                usuario.Email = dr.GetString(2);
                usuario.Nivel = Nivel.ObterPorID(dr.GetInt32(3));
            }
            Banco.Fechar(cmd);
            return usuario;

        }
        /// <summary>
        /// Insere no Banco usuários conforme a sequência de Valores
        /// </summary>
        public void Inserir() 
        {
            var cmd = Banco.Abir();
            cmd.CommandText = "insert usuarios (nome ,email, senha ,nivel_id ,ativo " +
                "values (@nome, @email, md5(@senha), @nivel, 1 )";
            cmd.Parameters.Add("@nome",MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
            cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = Senha;
            cmd.Parameters.Add("@nivel", MySqlDbType.VarChar).Value = Nivel.Id;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@indentity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }
        /// <summary>
        /// Faz uma pesquisa por id conforme está no banco começando de 1 até a quantidade de usuários no banco cadastrados 
        /// </summary>
        /// <param name="_id">Indetificador de usuário </param>
        /// <returns></returns>
        public static Usuario ObterPorId(int _id) 
        {
            Usuario usuario = null;
            var cmd = Banco.Abir();
            cmd.CommandText = "select * from usuarios where id = "+_id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuario = new Usuario(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    Nivel.ObterPorID(dr.GetInt32(4)),
                    dr.GetBoolean(5)                                                                                                                 
                    );
            }
            Banco.Fechar(cmd);
            return usuario;
        }
        /// <summary>
        /// Faz uma lista de todos os usuários se não colocar nenhum valor (não escrever nada na pesquisa), se colocar um valor vai fazer um like no banco e pequisar
        /// pelo nome conforme as valores que você indicar 
        /// </summary>
        /// <param name="_nome">Nome do usuário que você deseja pesquisar</param>
        /// <returns></returns>
        public static List<Usuario> Listar(string _nome = "")
        {
            List<Usuario> Lista = new List<Usuario>();
            
            var cmd = Banco.Abir();
            if (_nome != string.Empty)
                cmd.CommandText = "select * from usuarios where like '%" + _nome + "%'";
            else
                cmd.CommandText = "select * from usuario";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Lista.Add(new Usuario(
                dr.GetInt32(0),
                dr.GetString(1),
                dr.GetString(2),
                dr.GetString(3),
                Nivel.ObterPorID(dr.GetInt32(4)),
                dr.GetBoolean(5)
                ));
            }
            Banco.Fechar(cmd);
            return Lista;
        }
        /// <summary>
        /// Atualiza o campo de Nome, Senha e do nivel do usuário
        /// </summary>
        public void Atualizar ()
        {
            MySqlCommand comando = Banco.Abir();
            comando.CommandText = "update usuario set nome = @nome, senha = md5(@senha), " +
                "nivel_id = @nivel where id ="+Id;
            comando.Parameters.AddWithValue("@nome",Nome);
            comando.Parameters.AddWithValue("@senha", Senha);
            comando.Parameters.Add("@nivel", MySqlDbType.Int32).Value = nivel.Id;
            comando.ExecuteNonQuery();
            Banco.Fechar(comando);
        }
        /// <summary>
        ///Arquiva o o usuário  
        /// </summary>
        /// <param name="_id">Indentificador do usuário</param>
        public static void Arquivar(int _id)
        { 
            MySqlCommand cmd = Banco.Abir();
            cmd.CommandText = "update usuarios set ativo = 0 where id = " +_id;
            cmd.ExecuteNonQuery();

            Banco.Fechar(cmd);
        }
        /// <summary>
        /// Restaura o usário para ser "visto" novamente
        /// </summary>
        /// <param name="_id">Indentificador do usuário</param>
        public static void Restaurar(int _id)
        {
            MySqlCommand cmd = Banco.Abir();
            cmd.CommandText = "update usuarios set ativo = 1 where id = " + _id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);

        }
        /// <summary>
        /// Exclui o usuário
        /// </summary>
        /// <param name="_id">Indentificador do usuário</param>
        public void Excluir(int _id)
        {
            MySqlCommand cmd = Banco.Abir();
            cmd.CommandText = "delete from usuarios where id = " + _id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
    }
}
