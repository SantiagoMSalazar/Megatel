using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megatel
{
    using System.Data;
    using System.Data.SqlClient;
    using System.Data.SqlTypes;
    using System.Windows.Forms;

    public class Conection
    {

        static string myServerAddress = "127.0.0.1";
        static string myDataBase = "DBMegatel";
        static string myUsername = "sa";
        static string myPassword = "P@ssw0rd";
        static string connectionString = $"Server={myServerAddress};Database={myDataBase};User Id={myUsername};Password={myPassword};";
        SqlConnection connection = new SqlConnection(connectionString);

        public Conection()
        {
        }

        public DataTable consultar_Agencia(string Nombre)
        {
            DataTable dt = new DataTable();
            try
            {

                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT * FROM {Nombre}", connection);
                SqlDataReader reader = command.ExecuteReader();

                dt.Columns.Add("Column_idAgencia", typeof(int));
                dt.Columns.Add("Column_Direccion", typeof(string));
                dt.Columns.Add("Column_Ciudad", typeof(string));

                while (reader.Read())
                {
                    dt.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                }
                // Cerrar la conexión
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message);
            }

            return dt;
        }

        public DataTable consultar_Plan(string Nombre)
        {
            DataTable dt = new DataTable();
            try
            {

                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT * FROM {Nombre}", connection);
                SqlDataReader reader = command.ExecuteReader();

                dt.Columns.Add("Column_idPlan", typeof(int));
                dt.Columns.Add("Column_nombrePlan", typeof(string));
                dt.Columns.Add("Column_cantMegas", typeof(int));
                dt.Columns.Add("Column_Precio", typeof(SqlMoney));

                while (reader.Read())
                {
                    dt.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2),
                        reader.GetSqlMoney(3));
                }
                // Cerrar la conexión
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message);
            }

            return dt;
        }

        public DataTable consultar_Cliente(string Nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT * FROM {Nombre}", connection);
                SqlDataReader reader = command.ExecuteReader();

                dt.Columns.Add("Column_idCliente", typeof(int));
                dt.Columns.Add("Column_idAgenciaCliente", typeof(int));
                dt.Columns.Add("Column_CC", typeof(string));
                dt.Columns.Add("Column_NombreCliente", typeof(string));
                dt.Columns.Add("Column_ApellidoCliente", typeof(string));
                dt.Columns.Add("Column_Celular", typeof(string));
                dt.Columns.Add("Column_email", typeof(string));

                while (reader.Read())
                {
                    dt.Rows.Add( reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3)
                        ,reader.GetString(4) , reader.GetString(5) , reader.GetString(6));
                }
                // Cerrar la conexión
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message);
            }

            

            return dt;
        }


    }
}
