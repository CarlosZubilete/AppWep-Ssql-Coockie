using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp_SQL_Cookies.connection; // Added a carpet connection

namespace WebApp_SQL_Cookies
{
  public partial class Web_products : System.Web.UI.Page
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
    // Control the pagination:
    protected void gridProducts_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
      gridProducts.PageIndex = e.NewPageIndex;
      this.LoadGridView();
    }
    // Delete a register with their ID
    protected void gridProducts_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
      // First , I find a index of the identificator for deteled
      string idProducto = ((Label)gridProducts.Rows[e.RowIndex].FindControl("itemTemplate_IDProducto")).Text;

      Producto producto = new Producto();
      producto.Id = Convert.ToInt32(idProducto);

      HandleProducto handleProducto = new HandleProducto();
      handleProducto.DeleteProducto(producto);

      this.LoadGridView();
    }
  }
}