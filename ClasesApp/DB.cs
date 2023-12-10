using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesApp
{
    public class DB 
    {
        public static MySqlConnection mysqlConnection;
        public static MySqlCommand mysqlCommand;
        private string ruta = @"C:\Users\Juanma\Desktop\CONSORCIOFINAL\Consorcio_app\Datos.xml";

        public static string ConnectionString { get; } = @"Server=localhost;Database=appconsorcio;Uid=root;Pwd=;";

        static DB()
        {
            mysqlConnection = new MySqlConnection(ConnectionString);

            mysqlCommand = new MySqlCommand(ConnectionString);
            mysqlCommand.CommandType = System.Data.CommandType.Text; // el tipo de comando que envío (texto)
            mysqlCommand.Connection = mysqlConnection; // envío la consulta
        }
        public static async Task<List<Usuario>> SelectAsync()
        {
            try
            {
                mysqlConnection.Open();
                var query = "SELECT * FROM usuarios ";

                mysqlCommand.CommandText = query;
                List<Usuario> lista = new List<Usuario>();

                using (var reader = await mysqlCommand.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var usuario = new Usuario
                        {
                            Nombre = reader["Nombre"].ToString(),
                            Contraseña = reader["Contraseña"].ToString(),
                        };

                        lista.Add(usuario);
                    }
                }
                return lista;

            }
            catch (Exception)
            {

                throw;


            }
            finally
            {
                mysqlConnection.Close();
            }

        }

        public static void InsertUsuario(Usuario usuario)
        {
            try
            {
                mysqlConnection.Open();
                mysqlCommand.Parameters.Clear();
                var query = $"INSERT INTO usuarios  (Nombre, Contraseña) " +
                            $"VALUES (@Nombre, @Contraseña)";

                mysqlCommand.CommandText = query;

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {     
                    command.Parameters.Add(new MySqlParameter("Nombre", MySqlDbType.VarChar) { Value = usuario.Nombre });
                    command.Parameters.Add(new MySqlParameter("Contraseña", MySqlDbType.VarChar) { Value = usuario.Contraseña });

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                mysqlConnection.Close();
            }
        }

        public static void Delete(string Nombre)
        {

            try
            {
                mysqlConnection.Open();
                var query = $"DELETE FROM usuarios WHERE Nombre = '{Nombre}' ";

                mysqlCommand.CommandText = query;
                mysqlCommand.ExecuteNonQuery();


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                mysqlConnection.Close();
            }

        }

        public static void UpdateUsuarioYContraseña(string nuevoUsuarioIngresado, string nuevaContraseñaIngresada, string nombreUsuarioActual)
        {
            try
            {
                mysqlConnection.Open();
                var query = $"UPDATE usuarios SET Nombre ='{nuevoUsuarioIngresado}', Contraseña = '{nuevaContraseñaIngresada}' WHERE Nombre = '{nombreUsuarioActual}' ";

                mysqlCommand.CommandText = query;
                mysqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                mysqlConnection.Close();
            }


        }
        public static void OpenConection()
        {
            mysqlConnection.Open();

            mysqlConnection.Close();

        }

    }

}

