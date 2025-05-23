using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SoftProgDBManager
{
    public class DBManager
    {
        private static DBManager dbManager;
        private string url;
        private string hostname;
        private string usuario;
        private string password;
        private string database;
        private string puerto;
        private string nombreArchivo = "properties.txt";
        private MySqlConnection con;
        private MySqlCommand cmd;
        private DBManager()
        {
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nombreArchivo);
            if (File.Exists(ruta))
            {
                foreach (string line in File.ReadAllLines(ruta))
                {
                    url += line;
                }
            }
            con = new MySqlConnection(url);
        }


        public static DBManager getInstance()
        {
            if (dbManager == null)
                dbManager = new DBManager();
            return dbManager;
        }

        public string Url
        {
            get => url;
        }
        
        public MySqlConnection Connection
        {
            get {
                AbrirConexion();
                return con;
            }
        }

        private void AbrirConexion()
        {
            if(con.State != ConnectionState.Open)
                con.Open();
        }

        public void CerrarConexion()
        {
            if(con.State != ConnectionState.Closed)
                con.Close();
        }

        //Métodos para llamadas a procedimientos almacenados
        public int EjecutarProcedimiento(string nombreProcedimiento,
            MySqlParameter[] parametros)
        {
            int resultado = 0;
            try
            {
                AbrirConexion();
                cmd = con.CreateCommand();
                cmd.CommandText = nombreProcedimiento;
                cmd.CommandType = CommandType.StoredProcedure;
                if(parametros != null)
                    cmd.Parameters.AddRange(parametros);
                resultado = cmd.ExecuteNonQuery();
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
            return resultado;
        }

        public MySqlDataReader EjecutarProcedimientoLectura(string nombreProcedimiento, MySqlParameter[] parametros)
        {
            MySqlDataReader lector = null;
            try
            {
                AbrirConexion();
                cmd = con.CreateCommand();
                cmd.CommandText = nombreProcedimiento;
                cmd.CommandType = CommandType.StoredProcedure;
                if (parametros != null)
                    cmd.Parameters.AddRange(parametros);
                lector = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return lector;
        }

    }
}
