using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// Added a carpet connection
using WebApp_SQL_Cookies.connection;
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
      string nameProduct = ((Label)gridProducts.Rows[e.NewSelectedIndex].FindControl("itemTemplate_NombreProducto")).Text;

      lblShowSelected.Text = $"Productos Agregados:' {nameProduct} '";
    }
  }
}