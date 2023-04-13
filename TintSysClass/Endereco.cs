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
        public int Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Uf { get; set; }
        public string Tipo { get; set; }
        public Cliente Cliente { get; set; }
        //Metodos construtores 
        public Endereco() { }

        public Endereco(int id, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uf, string tipo, Cliente cliente)
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

        public Endereco(string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uf, string tipo, Cliente cliente)
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


        //Metodos da classe
        public void Inserir(int Cliente)
        {
            var cmd = Banco.Abir();
            cmd.CommandText = "insert enderecos ( cep, logradouro, numero, complemento, bairro, cidade, estado, uf, tipo, cliente_id)" +
                " values (@cep, @logradouro, @numero, @complemento, @bairro, @cidade, @estado, @uf, @tipo,"+Cliente+")";
            cmd.Parameters.AddWithValue("@cep", Cep);
            cmd.Parameters.AddWithValue("@logradouro", Logradouro);
            cmd.Parameters.AddWithValue("@numero",Numero);
            cmd.Parameters.AddWithValue("@complemento", Complemento);
            cmd.Parameters.AddWithValue("@bairro", Bairro);
            cmd.Parameters.AddWithValue("@cidade", Cidade);
            cmd.Parameters.AddWithValue("@estado", Estado);
            cmd.Parameters.AddWithValue("@uf", Uf);
            cmd.Parameters.AddWithValue("@tipo", Tipo);
            cmd.Parameters.Add("@cliente_id", MySqlDbType.Int32).Value =Cliente;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }
        public static Endereco ObterPorId(int id)
        {
            Endereco endereco = null;
            var cmd = Banco.Abir();
            cmd.CommandText = "select * from enderecos where id =" + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                endereco = new Endereco(
                       dr.GetInt32(0),
                       dr.GetString(1),
                       dr.GetString(2),
                       dr.GetString(3),
                       dr.GetString(4),
                       dr.GetString(5),
                       dr.GetString(6),
                       dr.GetString(7),
                       dr.GetString(8),
                       dr.GetString(9),
                       Cliente.ObterPorId(dr.GetInt32(10)));
            }
            Banco.Fechar(cmd);
            return endereco;
        }
        public static List<Endereco> Listar()
        {
            var cmd = Banco.Abir();
            List<Endereco> Lista = new List<Endereco>();
            cmd.CommandText = "select * from enderecos";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Lista.Add(new Endereco(
                      dr.GetInt32(0),
                      dr.GetString(1),
                      dr.GetString(2),
                      dr.GetString(3),
                      dr.GetString(4),
                      dr.GetString(5),
                      dr.GetString(6),
                      dr.GetString(7),
                      dr.GetString(8),
                      dr.GetString(9),
                      Cliente.ObterPorId(dr.GetInt32(10))));
            }
            Banco.Fechar(cmd);
            return Lista;
        }
        public static List<Endereco> ListarPorCliente (int cliente_id )
        {
            var cmd = Banco.Abir();
            List<Endereco> Lista = new List<Endereco>();
            cmd.CommandText = "select * from enderecos where cliente_id="+cliente_id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Lista.Add(new Endereco(
                      dr.GetInt32(0),
                      dr.GetString(1),
                      dr.GetString(2),
                      dr.GetString(3),
                      dr.GetString(4),
                      dr.GetString(5),
                      dr.GetString(6),
                      dr.GetString(7),
                      dr.GetString(8),
                      dr.GetString(9),
                      Cliente.ObterPorId(dr.GetInt32(10))));
            }
            Banco.Fechar(cmd);
            return Lista;
        }
        public void Atualizar(int id)
        {
            var cmd = Banco.Abir();
            cmd.CommandText = "update enderecos set cep = @cep, logradouro = @logradouro, numero = @numero, complemento = @complemento, bairro = @bairro, cidade = @cidade, estado = @estado,uf = @uf, tipo = @tipo where id ="+id;
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
