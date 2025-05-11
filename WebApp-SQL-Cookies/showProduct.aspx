<%@ Page Language="C#" 
  AutoEventWireup="true" 
  CodeBehind="showProduct.aspx.cs" 
  Inherits="WebApp_SQL_Cookies.showProduct" 
  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mostrar Producto</title>
    <link type="text/css" rel="stylesheet" href="showProduct.css"/>
</head>
<body>
  <form id="form1" runat="server">
    <h1 class="title" >Productos Seleccionados por el usuario:</h1>
    <div>
      <asp:GridView ID="gridProductShow" runat="server" CssClass="grid-view">

      </asp:GridView>
    </div>
    <div class="contenedor_footer">
      <asp:HyperLink  ID="linkCookie" runat="server" NavigateUrl="~/cookie.aspx" CssClass="navBar__link" >
        Volver
      </asp:HyperLink>
    </div>
  </form>
</body>
</html>
