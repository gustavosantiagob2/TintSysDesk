using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace TintSysClass
{
    public class Nivel // (Abstração)
    {
        // Atributos da classe
        private int id;
        private string nome;
        private string sigla;

        //Propriedades  (Encapsulamento)
        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Sigla { get { return sigla; } set { sigla = value; } }

        //Metodos contrutores - int x = new int ();
        public Nivel() { } // construtor vazio
        public Nivel(string _nome, string _sigla)
        {
            Nome = _nome;
            Sigla = _sigla;
        }
        public Nivel(int _id, string _nome, string _sigla)
        {
            Id = _id;
            Nome = _nome;
            Sigla = _sigla;
        }

        // Metodos da classe ( Inseriri, Alterar , Consultar, Por Id, Nome, etc...)
        public void Inserir()
        {
            // cria uma variavel com conexão de banco aberta
            var cmd = Banco.Abir();
            // define o tipo de instrução MySQL a ser processada pelo serv banco dados
            cmd.CommandType = System.Data.CommandType.Text;
            // define a query sql especificada com parametros (@nome..)
            cmd.CommandText = "insert niveis (nome, sigla) values (@nome, @sigla)";
            // cria o parametro e associa ao valor 
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
            cmd.Parameters.AddWithValue("@sigla", Sigla);
            //executa a instrução SQL na conexão aberta 
            cmd.ExecuteNonQuery();
            // obtendo o id do nivel recém inserido
            cmd.CommandText = "select @@identity";
            // recupera o id na Propriedade
            id = Convert.ToInt32(cmd.ExecuteScalar());
            // fecha a conexão
            Banco.Fechar(cmd);
        }
        public static Nivel ObterPorID(int _id)
        {
            var cmd = Banco.Abir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from niveis where id = @id";
            cmd.Parameters.AddWithValue("@id", _id);
            var dr = cmd.ExecuteReader();
            Nivel nivel = null;
            while (dr.Read())
            {
                nivel = new Nivel(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2)
                    );
            }
            Banco.Fechar(cmd);
            return nivel;
        }
        public static List <Nivel> Listar() 
        {
           List<Nivel> lista = new List<Nivel>();
            var cmd = Banco.Abir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from niveis";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Nivel(dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2)));
            }
            Banco.Fechar(cmd);
            return lista;
        }
        public void Atualizar()
        {
            var cmd = Banco.Abir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update niveis set nome = @nome, sigla = @sigla where id = @id ";
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@nome",nome);
            cmd.Parameters.AddWithValue("@sigla",sigla);
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
        public int Excluir (int _id)
        {
            bool confirma = false;
            var cmd = Banco.Abir();
            cmd.CommandText = "delete from niveis where id = "+_id;
            if (cmd.ExecuteNonQuery() > 0)
            {
                msg = 0;
            }
            Banco.Fechar(cmd);
            return msg;
        }
        
    }

}
