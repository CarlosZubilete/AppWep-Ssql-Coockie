﻿using System;
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
    // When the user press edit button
    protected void gridProducts_RowEditing(object sender, GridViewEditEventArgs e)
    {
      gridProducts.EditIndex = e.NewEditIndex;
      this.LoadGridView();
    }
    // The user is editing a register, but press cancel Button
    protected void gridProducts_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
      gridProducts.EditIndex = -1;
      this.LoadGridView();
    }
    // The user is editing a register and press acept button
    protected void gridProducts_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
      string id = ((Label)gridProducts.Rows[e.RowIndex].FindControl("edit_itemTemplate_IDProducto")).Text;
      string name = ((TextBox)gridProducts.Rows[e.RowIndex].FindControl("edit_itemTemplate_NombreProducto")).Text;
      string cantXunidad = ((TextBox)gridProducts.Rows[e.RowIndex].FindControl("edit_itemTemplate_CantidadPorUnidad")).Text; 
      string precioUnidad = ((TextBox)gridProducts.Rows[e.RowIndex].FindControl("edit_itemTemplate_PrecioUnidad")).Text;

      // Intance Producto
      Producto producto = new Producto( Convert.ToInt32(id), name, cantXunidad, Convert.ToDecimal(precioUnidad));

     
      HandleProducto handleProducto = new HandleProducto();
      handleProducto.UpdateProducto(producto);

      gridProducts.EditIndex = -1;
      this.LoadGridView();
    }
  
    // TODO: ADD try and catch , and send a ok message or bad message.
  }
}