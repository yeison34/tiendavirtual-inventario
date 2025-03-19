using Npgsql;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
            var idhilo = Thread.CurrentThread.ManagedThreadId.ToString();
            try
            {
                if (!connection.ContainsKey(idhilo))
                {
                    var conexion = new NpgsqlConnection(connectionString);
                    connection[idhilo]=conexion;
                }
            } catch(Exception ex) {
                throw ex;
            }
            return connection[idhilo];
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
