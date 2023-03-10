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
                SqlCommand command = new SqlCommand($"SELECT idEmpleado,idAgencia,nombreEmp,apellidoEmp,direcciónEmp,fechadeingreso,título,tipo,salario FROM {Nombre}", connection);
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

        // ############################# OPERACIONES DE ELIMINACION ##########################

        public void eliminar_Agencia(string Nombre, int idAgencia)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SET XACT_ABORT ON; DELETE FROM {Nombre} WHERE idAgencia = {idAgencia}", connection);
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
                SqlCommand command = new SqlCommand($"SET XACT_ABORT ON; DELETE FROM {Nombre} WHERE IDCLIENTE = @idCliente", connection);
                command.Parameters.AddWithValue("@idCliente", idCliente);
                command.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message);
            }
            finally
            {
                connection.Close();
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
                SqlCommand command = new SqlCommand($"SET XACT_ABORT ON; DELETE FROM {Nombre} WHERE idContrato = {idContrato}", connection);
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
                SqlCommand command = new SqlCommand($"SET XACT_ABORT ON; DELETE FROM {Nombre} WHERE idEmpleado = {idEmpleado}", connection);
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
                                   string salario)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"set XACT_ABORT ON; INSERT INTO V_Empleado(idEmpleado,idAgencia,nombreEmp,apellidoEmp,direcciónEmp,título,tipo,salario,fechadeingreso) " +
                                                    $"VALUES ({idempleado},{idAgencia},'{nombreEmp}','{apellidoEmp}','{DireccionEmp}','{título}','{tipo}','{salario}',getdate())",connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }
        //Agregar Plan
        public void AgregarPlan(int idPlan,
                                   string nombrePlan,                                
                                   int cantMegas,
                                   string precio)
        {
            
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"set XACT_ABORT ON;insert into Plan_M(idPlan,nombrePlan,cantMegas,precio)" +
                                                    $"VALUES ({idPlan},'{nombrePlan}',{cantMegas},'{precio}')",connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }
        // Agregar contrato
        public void AgregarContrato(string idContrato,
                                   string idCliente,
                                   string idPlan,
                                   string minPermanencia,
                                   string idAgencia)
        {

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"set XACT_ABORT ON;insert into V_Contrato(idContrato,idCliente,idPlan,fechaEmisión,minPermanencia,idAgencia)" +
                                                    $"VALUES ({idContrato},{idCliente},{idPlan},getdate(),{minPermanencia},{idAgencia})", connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error de conexión: " + ex.Message,"Intente nuevamente");
            }
        }

        // ############################# OPERACIONES DE EDICION ##########################

        // $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$ CLIENTE INFO $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
        public string[] hallar_Cliente_info(string Nombre, int idCliente)
        {
            string[] datosCliente = null;

            try
            {
                connection.Open();

                // Realizar la consulta SELECT
                SqlCommand command = new SqlCommand($"SELECT * FROM {Nombre} WHERE idCliente = {idCliente}", connection);
                SqlDataReader reader = command.ExecuteReader();

                // Verificar si se encontraron resultados
                if (reader.HasRows)
                {
                    // Obtener los nombres de las columnas
                    List<string> nombresColumnas = new List<string>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        nombresColumnas.Add(reader.GetName(i));
                    }

                    // Crear un array para almacenar los datos del cliente
                    datosCliente = new string[reader.FieldCount];

                    // Leer los valores de la fila encontrada
                    reader.Read();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        // Convertir el valor a string y almacenarlo en el array
                        object valor = reader.GetValue(i);
                        datosCliente[i] = (valor != DBNull.Value) ? valor.ToString() : "";
                    }
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message);
            }

            return datosCliente;
        }

        public string[] hallar_Cliente_estad(string Nombre, int idCliente)
        {
            string[] datosCliente = null;

            try
            {
                connection.Open();

                // Realizar la consulta SELECT
                SqlCommand command = new SqlCommand($"SELECT * FROM {Nombre} WHERE idCliente = {idCliente}", connection);
                SqlDataReader reader = command.ExecuteReader();

                // Verificar si se encontraron resultados
                if (reader.HasRows)
                {
                    // Obtener los nombres de las columnas
                    List<string> nombresColumnas = new List<string>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        nombresColumnas.Add(reader.GetName(i));
                    }

                    // Crear un array para almacenar los datos del cliente
                    datosCliente = new string[reader.FieldCount];

                    // Leer los valores de la fila encontrada
                    reader.Read();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        // Convertir el valor a string y almacenarlo en el array
                        object valor = reader.GetValue(i);
                        datosCliente[i] = (valor != DBNull.Value) ? valor.ToString() : "";
                    }
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message);
            }

            return datosCliente;
        }

        public bool actualizar_Cliente_info(string IDCLIENTE, string IDAGENCIA, string CC, string NOMBRECLI, 
                                       string APELLIDOCLI, string CELULAR, string EMAIL)
        {
            bool se_actualiza = false;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"set XACT_ABORT ON; UPDATE V_Cliente_info SET " +
                    $"IDCLIENTE = '{IDCLIENTE}', IDAGENCIA = '{IDAGENCIA}', CC = '{CC}', NOMBRECLI = '{NOMBRECLI}', " +
                    $"APELLIDOCLI = '{APELLIDOCLI}', CELULAR = '{CELULAR}', EMAIL = '{EMAIL}' WHERE IDCLIENTE = '{IDCLIENTE}'", connection);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0) // Si se han actualizado filas
                {
                    se_actualiza = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return se_actualiza;
        }

        public bool actualizar_Cliente_estad(string IDCLIENTE, string DIRECCION)
        {
            bool se_actualiza = false;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"UPDATE Cliente_estadisticas SET " +
                    $"IDCLIENTE = '{IDCLIENTE}', DIRECCION = '{DIRECCION}'", connection);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0) // Si se han actualizado filas
                {
                    se_actualiza = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return se_actualiza;
        }


        // ##################### OPERACIONES DE FILTRADO DE TABLAS #####################

        public DataTable Buscar_Agencia(string key)
        {
            DataTable dt = new DataTable();
            try
            {

                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT * FROM V_Agencia WHERE ciudad like '%{key}%'", connection);
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

        public DataTable Buscar_Plan(string key)
        {
            DataTable dt = new DataTable();
            try
            {

                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT * FROM Plan_M where nombrePlan like '%{key}%'", connection);
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

        public DataTable Buscar_Cliente(string key)
        {
            DataTable dt = new DataTable();
            try
            {

                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT * FROM V_Cliente_info where CC like '%{key}%'", connection);
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

        public DataTable Buscar_Contrato(string key)
        {

            DataTable dt = new DataTable();
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"SELECT * FROM V_Contrato where idContrato like '%{key}%'", connection);
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

        public DataTable Buscar_Empleado(string key)
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT * FROM V_Empleado where nombreEmp like '%{key}%'", connection);
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

        public DataTable Buscar_Cliente_estad(string key)
        {
            DataTable dt = new DataTable();
            try
            {

                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT * FROM Cliente_estadisticas where idCliente like '%{key}%'", connection);
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

    }
}
