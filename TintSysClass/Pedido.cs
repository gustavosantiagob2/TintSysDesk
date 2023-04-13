﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TintSysClass
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }
        public double Desconto { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario Usuario { get;set; }
        public DateTime Arquivado { get; set; }
        public  string Hashcode { get; set; }
        public List<ItemPedido> Itens { get; set; }
            
        public Pedido () { }

        public Pedido(int id, DateTime data, string status, double desconto, Cliente cliente, Usuario usuario, DateTime arquivado, string hashcode)
        {
            Id = id;
            Data = data;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            Arquivado = arquivado;
            Hashcode = hashcode;
        }

        public Pedido(DateTime data, string status, double desconto, Cliente cliente, Usuario usuario, DateTime arquivado, string hashcode)
        {
            Data = data;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            Arquivado = arquivado;
            Hashcode = hashcode;
        }

        public Pedido(DateTime data, string status, double desconto, Cliente cliente, Usuario usuario, DateTime arquivado)
        {
            Data = data;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            Arquivado = arquivado;
        }
        public Pedido(Cliente cliente, Usuario usuario)
        {
            Cliente = cliente;
            Usuario = usuario;
        }
        public void Inserir ()
        {
            var cmd = Banco.Abir();
            cmd.CommandText = "insert pedidos (data, status, desconto, cliente_id, usuario_id,hashcode)" +
                "values (default, Default,0, @cliente, @usuario, @hash)";
            cmd.Parameters.Add("@cliente", MySqlDbType.Int32).Value = Cliente.Id;
            cmd.Parameters.Add("@usuario", MySqlDbType.Int32).Value = Usuario.Id;
            cmd.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = ObterHashCode(Cliente.Id, Usuario.Id);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }
        public static Pedido ObterPorId(int id)
        {
            Pedido pedido = null;
            var cmd = Banco.Abir();
            cmd.CommandText = "select * from pedido where id =" +id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedido = new Pedido(
                   dr.GetInt32(0),
                   dr.GetDateTime(1),
                   dr.GetString(2),
                   dr.GetDouble(3),
                   Cliente.ObterPorId(dr.GetInt32(4)),
                   Usuario.ObterPorId(dr.GetInt32(5)),
                   dr.GetDateTime(6),
                   dr.GetString(7));
            }
            Banco.Fechar(cmd);
            return pedido;
        }
        public static List<Pedido> ObterPorCLiente (int id)
        {
             List<Pedido> Pedidos = null;
            var cmd = Banco.Abir();
            cmd.CommandText = "select * from pedido where cliente_id =" + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               Pedidos.Add(new Pedido(
                   dr.GetInt32(0),
                   dr.GetDateTime(1),
                   dr.GetString(2),
                   dr.GetDouble(3),
                   Cliente.ObterPorId(dr.GetInt32(4)),
                   Usuario.ObterPorId(dr.GetInt32(5)),
                   dr.GetDateTime(6),
                   dr.GetString(7)));
            }
            Banco.Fechar(cmd);
            return Pedidos;
        }
        public static List<Pedido> ListarPorId(int Id )
        {
            List<Pedido> lista = new List<Pedido>();
            var cmd = Banco.Abir();
            cmd.CommandText = "select * from pedidos where id ="+Id;
            var dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                lista.Add(new Pedido(
                    dr.GetInt32(0),
                    dr.GetDateTime(1),
                    dr.GetString(2),
                    dr.GetDouble(3),
                    Cliente.ObterPorId(dr.GetInt32(4)),
                    Usuario.ObterPorId(dr.GetInt32(5)),
                    dr.GetDateTime(6),
                    dr.GetString(7)));
            }
            Banco.Fechar(cmd);
            return lista;
        }
        public void Atualizar (int id)
        {
            var cmd = Banco.Abir();
            cmd.CommandText = "update pedidos set status = @status, desconto = @desconto,arquivado = @arquivado where id ="+id;
            cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = Status;
            cmd.Parameters.Add("@desconto", MySqlDbType.Double).Value = Desconto;
            cmd.Parameters.Add("@arquivo", MySqlDbType.Date).Value = Arquivado;
            cmd.ExecuteNonQuery();
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }
        public void Arquivar ()
        {

        }
        public void Restaura ()
        {

        }
        private string ObterHashCode(int Cliente, int Usuario) 
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("PD-");
            Random rd = new Random();
            sb.Append(rd.Next(123450,543210));
            sb.Append("");
            sb.Append(Cliente);
            sb.Append("-");
            sb.Append(Usuario);
            return sb.ToString();
        }
    }
}
