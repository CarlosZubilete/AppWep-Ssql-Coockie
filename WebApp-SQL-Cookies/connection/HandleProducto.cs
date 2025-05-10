using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApp_SQL_Cookies.connection
{
  public class HandleProducto
  {
    //private string _query = "SELECT * FROM Productos";
    public HandleProducto() { }

    public DataTable GetAllProducts()
    {
      return GetDataTable("Productos", "SELECT * FROM Productos");
    }
    public bool DeleteProducto(Producto producto)
    {
      SqlCommand command = new SqlCommand();
      ParameterDeleteProducto(ref command, producto);
      DataAccess dataAccess = new DataAccess();
      int filasAfectadas = dataAccess.ExecuteNoQuery(command, "spEliminarProducto");
      return filasAfectadas == 1;
    }
    public bool UpdateProducto(Producto producto)
    {
      SqlCommand command = new SqlCommand();
      ParameterUpdateProducto(ref command, producto);
      DataAccess dataAccess = new DataAccess();
      int filasAfectadas = dataAccess.ExecuteNoQuery(command, "spActualizarProducto");
      return filasAfectadas == 1;
    }
    // PRIVATE
    private DataTable GetDataTable(string nombreTabla, string querySql)
    {
      DataAccess dataAccess = new DataAccess();
      using (SqlDataAdapter adapter = dataAccess.GetDataAdapter(querySql))
      {
        if (adapter == null)
          throw new Exception("Error al obtener el adaptador de datos.");

        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet, nombreTabla);
        return dataSet.Tables[nombreTabla];
      }
    }
    private void ParameterDeleteProducto(ref SqlCommand command, Producto producto)
    {
      SqlParameter parameter = new SqlParameter();
      parameter = command.Parameters.Add("@IDPRODUCTO", SqlDbType.Int);
      parameter.Value = producto.Id;
    }
    private void ParameterUpdateProducto(ref SqlCommand command , Producto producto)
    {
      SqlParameter parameter = new SqlParameter();
      parameter = command.Parameters.Add("@IDPRODUCTO", SqlDbType.Int);
      parameter.Value = producto.Id;
      parameter = command.Parameters.Add("@NOMBREPRODUCTO", SqlDbType.NVarChar, 40);
      parameter.Value = producto.Name;
      parameter = command.Parameters.Add("@CANTIDADPORUNIDAD", SqlDbType.NVarChar, 20);
      parameter.Value = producto.CantXUnidad;
      parameter = command.Parameters.Add("@PRECIOUNIDAD", SqlDbType.Money);
      parameter.Value = producto.PrecioUnidad;
    }
  }
}

/*
  CREATE PROCEDURE spActualizarProducto
  (
  @IDPRODUCTO INT,
  @NOMBREPRODUCTO NVARCHAR(40),
  @CANTIDADPORUNIDAD NVARCHAR(20),
  @PRECIOUNIDAD MONEY
  )
  AS
  UPDATE Productos
  SET
  NombreProducto=@NOMBREPRODUCTO,
  CantidadPorUnidad=@CANTIDADPORUNIDAD,
  PrecioUnidad=@PRECIOUNIDAD
  WHERE IdProducto=@IDPRODUCTO
  RETURN
*/