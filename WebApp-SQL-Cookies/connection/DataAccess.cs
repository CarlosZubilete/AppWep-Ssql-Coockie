using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApp_SQL_Cookies.connection
{
  public class DataAccess
  {
    private const string _connectingString = @"Data Source=DESKTOP-LFTFVP5\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True";
    public DataAccess() { }
    public SqlConnection GetConnection()
    {
      try
      {
        SqlConnection connection = new SqlConnection(_connectingString); 
        connection.Open();
        return connection;
      }
      catch (SqlException ex)
      {
        Console.WriteLine("ERROR! AL CONNECTARSE CON LA BASE DE DATOS " + ex.Message);
        return null;
      }
    }
    public SqlDataAdapter GetDataAdapter(string querySql)
    {
      try
      {
        SqlConnection connection = GetConnection();
        if(connection != null)
        {
          return new SqlDataAdapter(querySql, GetConnection());
        }
        else
        {
          Console.WriteLine("No se pudo crear el adaptador de datos.");
          return null;
        }
      }
      catch (SqlException ex)
      {
        Console.WriteLine("ERRO! al crear el adaptardod de datos " + ex.Message);
        return null;
      }
    }
    public int ExecuteNoQuery(SqlCommand command, string querySql)
    {
      try
      {
        using (SqlConnection connection = GetConnection())
        {
          if(connection != null)
          {
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = querySql;
            return command.ExecuteNonQuery();
          }
          else
          {
            Console.WriteLine("No se pudo ejecutar el comando.");
            return -1;
          }
        }
      }
      catch(SqlException ex)
      {
        Console.WriteLine("Error al ejecutar el comando: " + ex.Message);
        return -1;
      }
    }
  }
}


/*
1. Manejo Básico de Errores:
  Ahora se imprimen mensajes de error más claros en la consola, en lugar de devolver null silenciosamente.

2. Verificación de Conexión:
  GetAdapter ahora verifica si GetConnection devolvió null antes de crear el adaptador.

3.Mejor Uso de using:
  El método ExecuteNonQuery ahora asegura que la conexión se cierre correctamente después de usarla. 
*/