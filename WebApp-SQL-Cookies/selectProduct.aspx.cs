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

    private bool fisrtRegister = false;
    protected void gridProducts_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
      // Show in the same page 
      string nameProduct = ((Label)gridProducts.Rows[e.NewSelectedIndex].FindControl("itemTemplate_NombreProducto")).Text;
      lblShowSelected.Text = $"Productos Agregados:' {nameProduct} '";
      // Save data inside a DataTable for that show in another page.
      string idProducto = ((Label)gridProducts.Rows[e.NewSelectedIndex].FindControl("itemTemplate_IDProducto")).Text;
      string idProveedor = ((Label)gridProducts.Rows[e.NewSelectedIndex].FindControl("itemTemplate_IdProveedor")).Text;
      string precioUnidad = ((Label)gridProducts.Rows[e.NewSelectedIndex].FindControl("itemTemplate_PrecioUnidad")).Text;

      // Use a SESION variable
      //DataTable productTable;

      if (Session["TableProduct"] == null)
      {
        // productTable = this.CreateTable();
        // Session["TableProduct"] = productTable;
        Session["TableProduct"] = this.CreateTable();
        fisrtRegister = true;
      }

 
      if (fisrtRegister)
      {
        this.AddRegister((DataTable)Session["TableProduct"], idProducto, nameProduct, idProveedor, precioUnidad);
        fisrtRegister = false;
      }
      else
      {
        // Verification if the product has been registered yet
        bool isRepeatRegister = false;
        foreach (DataRow row in ((DataTable)Session["TableProduct"]).Rows)
        {
          if (row["IdProducto"].ToString() == idProducto)
          {
            isRepeatRegister = true;
            break;
          }
        }
        // If the register is not register
        if (!isRepeatRegister)
        {
          this.AddRegister((DataTable)Session["TableProduct"], idProducto, nameProduct, idProveedor, precioUnidad);
        }
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

      column = new DataColumn("NombreProducto", System.Type.GetType("System.String"));
      table.Columns.Add(column);

      column = new DataColumn("IdProveedor", System.Type.GetType("System.String"));
      table.Columns.Add(column);

      column = new DataColumn("PrecioUnidad", System.Type.GetType("System.String"));
      table.Columns.Add(column);

      return table;
    }
    private DataTable AddRegister(DataTable dataTable, string idProducto, string nameProducto, string idProveedor, string precioUnidad)
    {
      DataRow row = dataTable.NewRow();
      row["IdProducto"] = idProducto;
      row["NombreProducto"] = nameProducto;
      row["IdProveedor"] = idProveedor;
      row["PrecioUnidad"] = precioUnidad;

      dataTable.Rows.Add(row);

      return dataTable;
    }
  }
}