using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TintSysClass
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public Pedido IdPedido { get; set; }
        public Produto IdProduto { get; set; }
        public double Preco { get; set; }
        public double Quantidade { get; set; }
        public double Desconto { get; set; }

        public ItemPedido(){}

        public ItemPedido(int id, Pedido idPedido, Produto idProduto, double preco, double quantidade, double desconto)
        {
            Id = id;
            IdPedido = idPedido;
            IdProduto = idProduto;
            Preco = preco;
            Quantidade = quantidade;
            Desconto = desconto;
        }
        public ItemPedido(double preco, double quantidade, double desconto)
        {
            Preco = preco;
            Quantidade = quantidade;
            Desconto = desconto;
        }

        public ItemPedido(int id, double preco, double quantidade, double desconto)
        {
            Id = id;
            Preco = preco;
            Quantidade = quantidade;
            Desconto = desconto;
        }
        public void Inserir()
        {
            var cmd = Banco.Abir();
            cmd.CommandText = "insert itempedido (id, pedido_id, produto_id, preco, quantidade,desconto) " +
                "value (@id, @pedido_id, @produto_id, @preco, @quantidade, @desconto)";
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@pedido_id", IdPedido);
            cmd.Parameters.AddWithValue("@produto_id", IdProduto);
            cmd.Parameters.AddWithValue("@preco", Preco);
            cmd.Parameters.AddWithValue("@quantidade", Quantidade);
            cmd.Parameters.AddWithValue("@desconto", Desconto);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }
        public static ItemPedido ObterPorId (int id)
        {
            ItemPedido itempedido = null;
            var cmd = Banco.Abir();
            cmd.CommandText = "select * from itempedido where id ="+id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                itempedido = new ItemPedido(
                    dr.GetInt32(0),
                    Pedido.ObterPorId(dr.GetInt32(1)),
                    Produto.ObterPorId(dr.GetInt32(2)),
                    dr.GetDouble(3),
                    dr.GetDouble(4),
                    dr.GetDouble(5));
            }
            Banco.Fechar(cmd);
            return itempedido;
        }
    }
}
