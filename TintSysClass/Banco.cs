using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;

namespace TintSysClass
{
    internal static class Banco
    {
        private static string strConn; // atributo

        public static MySqlCommand Abir()
        {
            strConn = @"server =127.0.0.1;database =ti93sysdb; port =3306; user id =root; passowrd =usbw";
            MySqlCommand cmd = new MySqlCommand();

            try // Fluxo alternativos ( Esp Uc Doc) documento de espeficação de caso de uso  
            {
                MySqlConnection cn = new MySqlConnection(strConn);
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                }
                cmd.Connection = cn;
            }
            catch (Exception)
            {

                throw;
            }


            return cmd;
        }
        public static void Fechar(MySqlCommand cmd)
        {
            if (cmd.Connection.State == System.Data.ConnectionState.Open)
            {
              cmd.Connection.Close();
            }
        }
	}
}