﻿using System;
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
        public ItemPedido(int pedido_id,Produto produto, double preco, double quantidade, double desconto)
        {
            Id = pedido_id;
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
        public ItemPedido(double preco, double quantidade, double desconto)
        {
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
            cmd.Parameters.AddWithValue("@pedido_id", Id);
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
            cmd.CommandText = "select * from itempedido where pedido_id =@pedido and produdo_id = @produto";
            cmd.Parameters.AddWithValue("@pedido", pedido);
            cmd.Parameters.AddWithValue("@produto",produto);
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
        public static List<ItemPedido> ListarPorPedido(int pedido)
        {
            ItemPedido item = null;
            List<ItemPedido> itens = new List<ItemPedido>();
            var cmd = Banco.Abir();
            cmd.CommandText = "select * from itempedido where pedido_id =@pedido";
            cmd.Parameters.AddWithValue("@pedido", pedido);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                item = new ItemPedido();
                item.Id = dr.GetInt32(0);
                item.Produto = Produto.ObterPorId(dr.GetInt32(2));
                item.Preco = dr.GetDouble(3);
                item.Quantidade = dr.GetDouble(4);
                item.Desconto = dr.GetDouble(5);
                itens.Add(item);
            }
            Banco.Fechar(cmd);
            return itens;
        }
        public void Alterar(int pedido_id)
        {
            var cmd = Banco.Abir();
            cmd.CommandText = "update itempedido set quantidade = @quantidade, desconto = @desconto where pedido_id= @pedido_id and produto_id = @produto_id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@peido_id", pedido_id);
            cmd.Parameters.AddWithValue("@produto_id", Produto.Id);
            cmd.Parameters.AddWithValue("@quantidade", Quantidade);
            cmd.Parameters.AddWithValue("@desconto", Desconto);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }
        public void Excluir(int pedido_id, int produto_id)
        {
            var cmd = Banco.Abir();
            cmd.CommandText = "delete itempedido where pedido_id= @pedido_id and produto_id = @produto_id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@peido_id", pedido_id);
            cmd.Parameters.AddWithValue("@produto_id",produto_id);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }

    }
}
