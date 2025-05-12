using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_SQL_Cookies
{
  public partial class producto_2 : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        timerCount.Enabled = false;
      }
    }

    protected void btnDeleteProduct_Click(object sender, EventArgs e)
    {
      if(Session["TableProduct"] != null)
      {
        Session["TableProduct"] = null;
        lblMessage.Text = $"Se ha eliminado la Tabla";
        timerCount.Enabled = true;
      }
      else
      {
        lblMessage.Text = $"No hay Tabla Selecionada";
        timerCount.Enabled = true;
      }
    }

    protected void timerCount_Tick(object sender, EventArgs e)
    {
      lblMessage.Text = string.Empty;
      timerCount.Enabled = false;
    }
  }
}