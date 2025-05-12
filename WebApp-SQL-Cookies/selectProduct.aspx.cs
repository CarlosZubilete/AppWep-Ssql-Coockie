using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// Added a carpet connection
using WebApp_SQL_Cookies.connection;
using System.Data;

namespace WebApp_SQL_Cookies
{
  public partial class select : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        this.LoadGridView();
      }
    }
    private void LoadGridView()
    {
      HandleProducto handleProducto = new HandleProducto();
      gridProducts.DataSource = handleProducto.GetAllProducts();
      gridProducts.DataBind();
    }
    protected void gridProducts_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
      gridProducts.PageIndex = e.NewPageIndex;
      this.LoadGridView();
    }

    protected void gridProducts_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
      // Show in the same page 
      string nameProduct = ((Label)gridProducts.Rows[e.NewSelectedIndex].FindControl("itemTemplate_NombreProducto")).Text;
      lblShowSelected.Text = $"{nameProduct} se ha agregado.";
      // Save data inside a DataTable for that show in another page.
      string idProducto = ((Label)gridProducts.Rows[e.NewSelectedIndex].FindControl("itemTemplate_IDProducto")).Text;
      string idProveedor = ((Label)gridProducts.Rows[e.NewSelectedIndex].FindControl("itemTemplate_IdProveedor")).Text;
      string precioUnidad = ((Label)gridProducts.Rows[e.NewSelectedIndex].FindControl("itemTemplate_PrecioUnidad")).Text;

      // Use a SESION variable
      if (Session["TableProduct"] == null)
      {
        Session["TableProduct"] = this.CreateTable();
      }

      DataRow row = this.GetExistingRow((DataTable)Session["TableProduct"], idProducto);
      if (row != null)
      {
        row["Cantidad"] = (int)row["Cantidad"] + 1;
      }
      else
      {
        this.AddRegister((DataTable)Session["TableProduct"], idProducto, nameProduct, idProveedor, precioUnidad, 1);
      }
    }
    private DataTable CreateTable()
    {
      // Create a Object Table
      DataTable table = new DataTable();
      // Create a Object Column
      DataColumn column = new DataColumn("IdProducto", System.Type.GetType("System.String"));
      // Add column to table
      table.Columns.Add(column);

      table.Columns.Add(new DataColumn("NombreProducto", System.Type.GetType("System.String")));
      table.Columns.Add(new DataColumn("IdProveedor", System.Type.GetType("System.String")));
      table.Columns.Add(new DataColumn("PrecioUnidad", System.Type.GetType("System.String")));
      // Added a new column:
      table.Columns.Add(new DataColumn("Cantidad", typeof(int)));

      return table;
    }
    private DataTable AddRegister(DataTable dataTable, string idProducto, string nameProducto, string idProveedor, string precioUnidad, int cantidad)
    {
      DataRow row = dataTable.NewRow();
      row["IdProducto"] = idProducto;
      row["NombreProducto"] = nameProducto;
      row["IdProveedor"] = idProveedor;
      row["PrecioUnidad"] = precioUnidad;
      row["Cantidad"] = cantidad;

      dataTable.Rows.Add(row);

      return dataTable;
    }
    private DataRow GetExistingRow(DataTable table, string idProducto)
    {
      foreach (DataRow row in table.Rows)
      {
        if (row["IdProducto"].ToString() == idProducto)
        {
          return row;
        }
      }
      return null;
    }
  }
}

/*
private bool IsRegisterRepeat(DataTable table, string idProducto)
{
  bool isRepeatRegister = false;
  foreach (DataRow row in table.Rows)
  {
    if (row["IdProducto"].ToString() == idProducto)
    {
      isRepeatRegister = true;
      break;
    }
  }
  return isRepeatRegister;
}
*/