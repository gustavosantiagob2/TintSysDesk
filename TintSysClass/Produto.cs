using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TintSysClass
{
    public class Produto
    {
        public Produto() { }
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Unidade { get; set; }
        public string CodBar { get; set; }
        public double Preco { get; set; }
        public double Desconto { get; set; }
        public bool Descontinuado { get; set; }
        public Produto(int id, string descricao, string unidade, string codBar, double preco, double desconto, bool descontinuado)
        {
            Id = id;
            Descricao = descricao;
            Unidade = unidade;
            CodBar = codBar;
            Preco = preco;
            Desconto = desconto;
            Descontinuado = descontinuado;
        }
        public Produto(string descricao, string unidade, string codBar, double preco, double desconto, bool descontinuado)
        {
            Descricao = descricao;
            Unidade = unidade;
            CodBar = codBar;
            Preco = preco;
            Desconto = desconto;
            Descontinuado = descontinuado;
        }
        public Produto(string descricao, string unidade, string codBar, double preco, double desconto)
        {
            Descricao = descricao;
            Unidade = unidade;
            CodBar = codBar;
            Preco = preco;
            Desconto = desconto;
        }

        public void Inserir()
        {
            var cmd = Banco.Abir();
            cmd.CommandText = "insert produtos (descricao, unidade , codbar, preco, desconto, descontinuado) " +
                "value (@descricao, @unidade, @codbar, @preco, @desconto,0 )";
            cmd.Parameters.AddWithValue("@descricao", Descricao);
            cmd.Parameters.AddWithValue("@unidade", Unidade);
            cmd.Parameters.AddWithValue("@codbar", CodBar);
            cmd.Parameters.AddWithValue("@preco", Preco);
            cmd.Parameters.AddWithValue("@desconto", Desconto);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }
        public static List<Produto> Listar(string descricao = "") 
        {
            List<Produto> lista = new List<Produto>();  
            var cmd = Banco.Abir();
            if (descricao.Length > 0)
            {
                cmd.CommandText = "select * from produtos where descricao like '%"+descricao+"%'";
            }
            else
            {
                cmd.CommandText = "select * from produtos";
            }
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Produto(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDouble(4),
                    dr.GetDouble(5),
                    dr.GetBoolean(6)));
            }
            Banco.Fechar(cmd);
            return lista;
        }
        public static Produto ObterPorId (int id)
        { 
            Produto produto = null;
            var cmd = Banco.Abir();
            cmd.CommandText = "select * from produtos where id ="+id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               produto = new Produto(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDouble(4),
                    dr.GetDouble(5),
                    dr.GetBoolean(6));
            }
            Banco.Fechar(cmd);
            return produto;
        }
        public void Atualizar ()
        {
            var cmd = Banco.Abir();
            cmd.CommandText = "update produtos set descricao = @descricao, unidade = @unidade, codbar = @codbar, preco = @preco, desconto = @desconto, descontinuado = @descontinuado where id = @id ";
            cmd.Parameters.AddWithValue("@id",Id);
            cmd.Parameters.AddWithValue("@descricao", Descricao);
            cmd.Parameters.AddWithValue("@unidade", Unidade);
            cmd.Parameters.AddWithValue("@codbar", CodBar);
            cmd.Parameters.AddWithValue("@preco", Preco);
            cmd.Parameters.AddWithValue("@desconto", Desconto);
            cmd.Parameters.AddWithValue("@descontinuado", Descontinuado);
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
        public  static void Arquivar(int id)
        {
            var cmd = Banco.Abir();
            cmd.CommandText = "update produtos set descontinuado = 1 where id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
        public static void Restaurar(int id)
        {
            var cmd = Banco.Abir();
            cmd.CommandText = "update produtos set descontinuado = 0 where id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
    }
}
