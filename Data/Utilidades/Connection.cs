using Npgsql;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Data.Utilidades
{
    public partial class Connection
    {

        private static ConcurrentDictionary<string, NpgsqlConnection> connection =new ConcurrentDictionary<string, NpgsqlConnection>();
        private static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public static void openConection()
        {
            try
            {
                var idhilo = Thread.CurrentThread.ManagedThreadId.ToString();
                if (!connection.ContainsKey(idhilo)) {
                    var conexion = new NpgsqlConnection(connectionString);
                    conexion.Open();
                    connection[idhilo] = conexion;
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public static NpgsqlConnection getConnection()
        {
            NpgsqlConnection conexion= null;
            try
            {
                var idhilo = Thread.CurrentThread.ManagedThreadId.ToString();
                if (connection.TryGetValue(idhilo, out NpgsqlConnection conn))
                {
                    conexion = conn;
                }
            } catch(Exception ex) {
                throw ex;
            }
            return conexion;
        }

        public static void closeConnection()
        {
            try { 
                var idhilo=Thread.CurrentThread.ManagedThreadId.ToString();
                if (connection.TryRemove(idhilo,out NpgsqlConnection conn)) {
                    conn.Close();
                    conn.Dispose();
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
