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
        public Produto Produto { get; set; }
        public double Preco { get; set; }
        public double Quantidade { get; set; }
        public double Desconto { get; set; }

        public ItemPedido(){}
        public ItemPedido(int id,Produto produto, double preco, double quantidade, double desconto)
        {
            Id = id;
            Produto = produto;
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
            cmd.CommandText = "insert itempedido (pedido_id,produto_id, preco, quantidade,desconto) " +
                "value (@pedido_id, @produto_id, @preco, @quantidade, @desconto/100)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@peido_id", Id);
            cmd.Parameters.AddWithValue("@produto_id", Produto.Id);
            cmd.Parameters.AddWithValue("@preco", Produto.Preco);
            cmd.Parameters.AddWithValue("@quantidade", Quantidade);
            cmd.Parameters.AddWithValue("@desconto", Desconto);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }
        public static ItemPedido BuscarPorProdutoPedido(int pedido, int produto)
        {
            ItemPedido iten = new ItemPedido();
            var cmd = Banco.Abir();
            cmd.CommandText = "select * from itempedido where pedido_id ="+pedido;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                iten.Id = dr.GetInt32(0);
                iten.Produto = Produto.ObterPorId(dr.GetInt32(2));
                iten.Preco = dr.GetDouble(3);
                iten.Quantidade = dr.GetDouble(4);
                iten.Desconto = dr.GetDouble(5);
            }
            Banco.Fechar(cmd);
            return iten;
        }
    }
}
