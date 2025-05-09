using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/// Todo: Later this won´t be here
using System.Data.SqlClient;
using System.Data;

namespace WebApp_SQL_Cookies
{
  public partial class Web_products : System.Web.UI.Page
  {
    private const string _connectingString = @"Data Source=DESKTOP-LFTFVP5\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True";
    private string _query = "SELECT * FROM Productos";
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        SqlConnection connection = new SqlConnection(_connectingString);
        connection.Open();
        
        SqlDataAdapter adapter = new SqlDataAdapter(_query, connection);

        DataSet dataSet = new DataSet();

        adapter.Fill(dataSet, "Productos");

        gridProducts.DataSource = dataSet.Tables["Productos"];

        gridProducts.DataBind();

        connection.Close();
      }
    }
    // TODO: Crear HandleProductos.cs and Producto
  }
}