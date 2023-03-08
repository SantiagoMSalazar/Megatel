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

        static string myServerAddress = "localhost";
        static string myDataBase = "DBMegatel";
        static string myUsername = "sa";
        static string myPassword = "P@ssw0rd";
        static string connectionString = $"Server={myServerAddress};Database={myDataBase};User Id={myUsername};Password={myPassword};";
        SqlConnection connection = new SqlConnection(connectionString);

        public Conection()
        {
        }

        // ############################# OPERACIONES DE CONSULTA ##########################

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
                    dt.Rows.Add(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3)
                        , reader.GetString(4), reader.GetString(5), reader.GetString(6));
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

        public DataTable consultar_Contrato(string Nombre)
        {

            DataTable dt = new DataTable();
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"SELECT * FROM {Nombre}", connection);
                SqlDataReader reader = command.ExecuteReader();

                dt.Columns.Add("Column_idContrato", typeof(int));
                dt.Columns.Add("Column_idCliente_Contrato", typeof(int));
                dt.Columns.Add("Column_idPLan_Contrato", typeof(int));
                dt.Columns.Add("Column_fechaEmision", typeof(SqlDateTime));
                dt.Columns.Add("Column_MinPermanencia", typeof(int));
                dt.Columns.Add("Column_idAgenciaContrato", typeof(int));

                while (reader.Read())
                {
                    dt.Rows.Add(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetSqlDateTime(3)
                        , reader.GetInt32(4), reader.GetInt32(5));

                }
                // Cerrar la conexión
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Funcaa");
                Console.WriteLine("Error de conexión: " + ex.Message);
            }

            return dt;
        }

        public DataTable consultar_Empleado(string Nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT * FROM {Nombre}", connection);
                SqlDataReader reader = command.ExecuteReader();
                dt.Columns.Add("Column_idEmpleado", typeof(int));
                dt.Columns.Add("Column_idAgencia_Empleado", typeof(int));
                dt.Columns.Add("Column_Nombre_Empleado", typeof(string));
                dt.Columns.Add("Column_Apellido_Empleado", typeof(string));
                dt.Columns.Add("Column_Direccion_Empleado", typeof(string));
                dt.Columns.Add("Column_FechaIngreso_Empleado", typeof(DateTime));
                dt.Columns.Add("Column_Titulo_Empleado", typeof(string));
                dt.Columns.Add("Column_Tipo_Empleado", typeof(string));
                dt.Columns.Add("Column_Salario_Empleado", typeof(SqlMoney));

                while (reader.Read())
                {
                    dt.Rows.Add(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3)
                        , reader.GetString(4), reader.GetDateTime(5), reader.GetString(6), reader.GetString(7)
                        , reader.GetSqlMoney(8));


                }
                // Cerrar la conexión
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("----");
                Console.WriteLine("Error de conexión: " + ex.Message);
            }

            return dt;
        }

        public DataTable consultar_Cliente_estad(string Nombre)
        {
            DataTable dt = new DataTable();
            try
            {

                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT * FROM {Nombre}", connection);
                SqlDataReader reader = command.ExecuteReader();

                dt.Columns.Add("Column_idCliente", typeof(int));
                dt.Columns.Add("Column_direccion", typeof(string));

                while (reader.Read())
                {
                    dt.Rows.Add(reader.GetInt32(0), reader.GetString(1));
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

        // ############################# OPERACIONES DE INSERCION ##########################


        // ############################# OPERACIONES DE ELIMINACION ##########################

        public void eliminar_Agencia(string Nombre, int idAgencia)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"DELETE FROM {Nombre} WHERE idAgencia = {idAgencia}", connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message);
            }
        }

        public bool agencia_existe(string Nombre, int idAgencia)
        {
            bool existe = false;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM {Nombre} WHERE idAgencia = {idAgencia}", connection);
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    existe = true;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message);
            }

            return existe;
        }

        public void eliminar_Plan(string Nombre, int idPlan)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"DELETE FROM {Nombre} WHERE idPlan = {idPlan}", connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message);
            }
        }

        public bool plan_existe(string Nombre, int idPlan)
        {
            bool existe = false;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM {Nombre} WHERE idPlan = {idPlan}", connection);
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    existe = true;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message);
            }

            return existe;
        }
        public void eliminar_Cliente(string Nombre, int idCliente)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"DELETE FROM {Nombre} WHERE IDCLIENTE = {idCliente}", connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message);
            }
        }

        public bool cliente_existe(string Nombre, int idCliente)
        {
            bool existe = false;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM {Nombre} WHERE idCliente = {idCliente}", connection);
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    existe = true;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message);
            }

            return existe;
        }

        public void eliminar_Contrato(string Nombre, int idContrato)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"DELETE FROM {Nombre} WHERE idContrato = {idContrato}", connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message);
            }
        }

        public bool contrato_existe(string Nombre, int idContrato)
        {
            bool existe = false;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM {Nombre} WHERE idContrato = {idContrato}", connection);
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    existe = true;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message);
            }

            return existe;
        }

        public void eliminar_Empleado(string Nombre, int idEmpleado)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"DELETE FROM {Nombre} WHERE idEmpleado = {idEmpleado}", connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message);
            }
        }

        public bool empleado_existe(string Nombre, int idEmpleado)
        {
            bool existe = false;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM {Nombre} WHERE idEmpleado = {idEmpleado}", connection);
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    existe = true;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message);
            }

            return existe;
        }

        // ############################# OPERACIONES DE Agregar ##########################
        public void AgregarCliente(int idCliente,
                                   int idAgencia,
                                   string cc,
                                   string nombrecli,
                                   string apellidocli,
                                   string celular,
                                   string email)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"set XACT_ABORT ON; INSERT INTO V_Cliente_info(IDCLIENTE,IDAGENCIA,CC,NOMBRECLI,APELLIDOCLI,CELULAR,EMAIL) " +
                                                    $"VALUES ({idCliente},{idAgencia},'{cc}','{nombrecli}','{apellidocli}','{celular}','{email}')", connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }
        public void AgregarEmpleado(int idempleado,
                                   int idAgencia,
                                   string nombreEmp,
                                   string apellidoEmp,
                                   string DireccionEmp,
                                   string título,
                                   string tipo,
                                   SqlMoney salario)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"set XACT_ABORT ON; INSERT INTO V_Cliente_info(IDCLIENTE,IDAGENCIA,CC,NOMBRECLI,APELLIDOCLI,CELULAR,EMAIL) " +
                                                    $"VALUES ({idCliente},{idAgencia},'{cc}','{nombrecli}','{apellidocli}','{celular}','{email}')", connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }
    }
}
