using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TintSysClass
{
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
        /// <param name="nome"></param>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <param name="nivel"></param>
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
        /// <param name="nome"></param>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <param name="nivel"></param>
        /// <param name="ativo"></param>
        public Usuario(string nome, string email, string senha, Nivel nivel, bool ativo)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }
        public static Usuario EfetuarLogin(string _email, string _senha)
        {
            //Usuario usuario = new Usuario();
            Usuario usuario = null;
            //
            return usuario;
        }
        public void inserir() 
        {
            //
        }
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
        public void Atualizar ()
        {
           

        }
        public void Arquivar(int _id)
        { 
        
        }
        public void Restaurar(int _id)
        {

        }
        public void Excluir(int _id)
        {

        }
    }
}
