using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalasDAL
{
    public class SqlDb : IDB
    {
        //conexion pc
        //public string connectionString = @"Data Source=DESKTOP-BCE1OBQ\LOCALSERVER;Initial Catalog=SalasApp;Integrated Security=True";
        public string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["PentagramDB"].ConnectionString;
        //conexion note
        //public string connectionString = @"Data Source=DESKTOP-BRPFQKF;Initial Catalog=SalasApp;Integrated Security=True";

        SqlConnection conexion = new SqlConnection();

        private string ArmarConnectionString()
        {
            string apppath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string filepath = Path.Combine(apppath, "SalasApp");
            string fullfilename = Path.Combine(filepath, "SalasApp.mdf");
            /*
            var sb = new System.Text.StringBuilder();
            sb.Append(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFileName=");
            sb.Append(fullfilename);
            sb.Append("Initial Catalog=SalasApp;Integrated Security=True");

            return sb.ToString();*/


            return connectionString;
        }

        private void Conectar()
        {
            conexion.ConnectionString = connectionString;
            conexion.Open();
        }
        private void Desconectar()
        {
            conexion.Close();
            conexion.Dispose();
        }

        public bool Delete(string storedProcedure, List<SqlParameter> listaParams = null)
        {
            try
            {
                int rows = 0;
                DataTable dataTable = new DataTable();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = storedProcedure;
                    if (listaParams != null)
                        command.Parameters.AddRange(listaParams.ToArray());
                    Conectar();
                    rows = command.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        Desconectar();
                        return true;
                    }
                    else
                    {
                        Desconectar();
                        return false;
                    }
                }
            }
            catch (SqlException ex)
            {
                //throw new SalasExceptionMain("Err_BaseDeDatos", OrigenError.SQL, ex);
                throw;
            }

        }

        public int Insert(string storedProcedure, List<SqlParameter> listaParams = null)
        {
            try
            {
                int rows = 0;
                DataTable dataTable = new DataTable();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = storedProcedure;
                    if (listaParams != null)
                        command.Parameters.AddRange(listaParams.ToArray());
                    Conectar();
                    int obj = Convert.ToInt32(command.ExecuteScalar());
                    if (rows > 0)
                    {
                        Desconectar();
                        return obj;
                    }
                    else
                    {
                        Desconectar();
                        return obj;
                    }
                }
            }
            catch (SqlException ex)
            {
                //throw new SalasExceptionMain("Err_BaseDeDatos", OrigenError.SQL, ex);
                throw;
            }
        }

        public DataTable Select(string storedProcedure, List<SqlParameter> listaParams = null)
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = storedProcedure;
                    if (listaParams != null)
                        command.Parameters.AddRange(listaParams.ToArray());
                    Conectar();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                    Desconectar();
                    return dataTable;
                }
            }
            catch (SqlException ex)
            {
                //throw new SalasExceptionMain("Err_BaseDeDatos", OrigenError.SQL, ex);
                throw;
            }
        }

        public bool Update(string storedProcedure, List<SqlParameter> listaParams = null)
        {
            try
            {
                int rows = 0;
                DataTable dataTable = new DataTable();
                using (SqlConnection connection = new SqlConnection(ArmarConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = storedProcedure;
                        if (listaParams != null)
                            command.Parameters.AddRange(listaParams.ToArray());
                        connection.Open();
                        rows = command.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            connection.Close();
                            return true;
                        }
                        else
                        {
                            connection.Close();
                            return false;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                //throw new SalasExceptionMain("Err_BaseDeDatos", OrigenError.SQL, ex);
                throw;
            }
        }

        public string CreateBackup(string rutaDestino)
        {
            try
            {
                string nombreBak = string.Format("{0}-{1}.bak", "Pentagram", DateTime.Now.ToString("yyyy-MM-dd"));

                string rutaBak = Path.Combine(rutaDestino, nombreBak);


                int i = 0;
                while (File.Exists(rutaBak))
                {
                    if (i == 0)
                        rutaBak = rutaBak.Replace(".bak", "(" + ++i + ")" + ".bak");
                    else
                        rutaBak = rutaBak.Replace("(" + i + ")" + ".bak", "(" + ++i + ")" + ".bak");
                }

                var query = String.Format("BACKUP DATABASE [{0}] TO DISK='{1}'", "SalasApp", rutaBak);

                using (var command = new SqlCommand(query, conexion))
                {
                    Conectar();
                    command.ExecuteNonQuery();
                    Desconectar();
                }

                return rutaBak;
            }
            catch (Exception ex)
            {
                //throw new SalasExceptionMain("Err_CrearBackup", OrigenError.SQL, ex);
                throw;
            }
        }

        public void RestoreBackup(string rutaArchivo)
        {
            try
            {
                string connectionst = connectionString = @"Data Source=DESKTOP-BCE1OBQ\LOCALSERVER;Integrated Security=True";//@ArmarConnectionString();

                string sql = @"ALTER DATABASE Pentagram SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                sql += "RESTORE DATABASE Pentagram FROM DISK ='" + rutaArchivo + "' WITH REPLACE;";

                using (SqlCommand command = new SqlCommand(sql))
                {
                    command.Connection = conexion;
                    Conectar();
                    command.CommandType = CommandType.Text;
                    command.CommandTimeout = 7200;

                    command.ExecuteNonQuery();

                    Desconectar();
                }
            }
            catch (Exception ex)
            {
                //throw new SalasExceptionMain("Err_RestoreBackup", OrigenError.SQL, ex);
                throw;
            }
        }
    }
}
