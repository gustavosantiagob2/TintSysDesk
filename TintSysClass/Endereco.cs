using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TintSysClass
{
    public class Endereco
    {
        //Atributos da classe
        private int id;
        private char cep;
        private string logradouro;
        private string numero;
        private string complemento;
        private string bairro;
        private string cidade;
        private string estado;
        private char uf;
        private string tipo;
        private Cliente cliente;

        //Propriedades da classe
        public int Id { get => id; set => id = value; }
        public char Cep { get => cep; set => cep = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public char Uf { get => uf; set => uf = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }

        //Metodos construtores 
        public Endereco() { }
        public Endereco(int id, char cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, char uf, string tipo ,Cliente cliente)
        {
            Id = id;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Uf = uf;
            Tipo = tipo;
            Cliente = cliente;
        }
        public Endereco( char cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, char uf, string tipo, Cliente cliente)
        {
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Uf = uf;
            Tipo = tipo;
            Cliente = cliente;
        }
        public Endereco(char cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, char uf, string tipo)
        { 
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Uf = uf;
            Tipo = tipo;
        }
        //Metodos da classe
        public void Inserir()
        {
            var cmd = Banco.Abir();
            cmd.CommandText = "insert enderecos (cep, logradouro, numero, complemento, bairro, cidade, estado, uf, tipo)" +
                " values (@cep, @logradouro, @numero, @complemento, @bairro, @cidade, @estado, @uf, @tipo)";
            cmd.Parameters.AddWithValue("@cep", Cep);
            cmd.Parameters.AddWithValue("@logradouro", Logradouro);
            cmd.Parameters.AddWithValue("@numero",Numero);
            cmd.Parameters.AddWithValue("@complemento", Complemento);
            cmd.Parameters.AddWithValue("@bairro", Bairro);
            cmd.Parameters.AddWithValue("@cidade", Cidade);
            cmd.Parameters.AddWithValue("@estado", Estado);
            cmd.Parameters.AddWithValue("@uf", Uf);
            cmd.Parameters.AddWithValue("@tipo", Tipo);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@indentity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }
        public static Endereco ObterPorId(int id)
        {
            Endereco endereco = null;
            var cmd = Banco.Abir();
            cmd.CommandText = "select * from endereco where id =" + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                endereco = new Endereco(
                       dr.GetInt32(0),
                       dr.GetChar(1),
                       dr.GetString(2),
                       dr.GetString(3),
                       dr.GetString(4),
                       dr.GetString(5),
                       dr.GetString(6),
                       dr.GetString(7),
                       dr.GetChar(8),
                       dr.GetString(9),
                       Cliente.ObterPorId(dr.GetInt32(10))
                    );
            }
            Banco.Fechar(cmd);
            return endereco;
        }
        public static List<Endereco> Listar (string cep = "")
        {
            var cmd = Banco.Abir();
            List<Endereco> Lista = new List<Endereco>();
            if (cep != string.Empty)
                cmd.CommandText = "select * from enderecos where like '%" + cep + "%'";
            else
                cmd.CommandText = "select * from endereco";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Lista.Add(new Endereco(
                      dr.GetInt32(0),
                      dr.GetChar(1),
                      dr.GetString(2),
                      dr.GetString(3),
                      dr.GetString(4),
                      dr.GetString(5),
                      dr.GetString(6),
                      dr.GetString(7),
                      dr.GetChar(8),
                      dr.GetString(9),
                      Cliente.ObterPorId(dr.GetInt32(10))
                   ));
            }
            Banco.Fechar(cmd);
            return Lista;
        }
        public void Atualizar()
        {
            var cmd = Banco.Abir();
            cmd.CommandText = "update enderecos set cep = @cep, logradouro = @logradouro, numero = @numero, complemento = @complemento, bairro = @bairro, cidade = @cidade, estado = @estado,uf = @uf, tipo = @tipo where id ="+Id;
            cmd.Parameters.AddWithValue("@cep", Cep);
            cmd.Parameters.AddWithValue("@logradouro", Logradouro);
            cmd.Parameters.AddWithValue("@numero", Numero);
            cmd.Parameters.AddWithValue("@complemento", Complemento);
            cmd.Parameters.AddWithValue("@bairro", Bairro);
            cmd.Parameters.AddWithValue("@cidade", Cidade);
            cmd.Parameters.AddWithValue("@estado", Estado);
            cmd.Parameters.AddWithValue("@uf", Uf);
            cmd.Parameters.AddWithValue("@tipo", Tipo);
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }    

        public void Excluir(int id)
        {
            var cmd = Banco.Abir();
            cmd.CommandText = "delete from enderecos where id ="+id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
    }
}
