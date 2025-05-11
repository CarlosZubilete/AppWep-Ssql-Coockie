using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApp_SQL_Cookies
{
  public partial class showProduct : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        if(Session["TableProduct"] != null)
        {
          gridProductShow.DataSource = ((DataTable)Session["TableProduct"]);
          gridProductShow.DataBind();  
        }
      }
    }
  }
}