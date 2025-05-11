<%@ Page 
  Language="C#" 
  AutoEventWireup="true" 
  CodeBehind="cookie.aspx.cs" 
  UnobtrusiveValidationMode="None"
  Inherits="WebApp_SQL_Cookies.producto_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cookie</title>
    <link  type="text/css" rel="stylesheet" href="cookie.css"/>
</head>
<body>
      <%-- Nav --%>
    <div class="navBar">
        <ul class="navBar__ul">
          <%-- INDEX --%>
            <li class="navBar__ul__li">
                <asp:HyperLink  ID="linkIndex" 
                  runat="server" 
                  NavigateUrl="~/index.aspx" 
                  CssClass="navBar__link " >
                    Home
                </asp:HyperLink>
            </li>
          <%-- PRODUCTS --%> 
            <li class="navBar__ul__li">
                <asp:HyperLink ID="linkProducts" 
                  runat="server" 
                  NavigateUrl="~/products.aspx" 
                  CssClass="navBar__link " >
                    Productos 
                </asp:HyperLink>
            </li>
          <%-- EJERCICIO-2--%> 
            <li class="navBar__ul__li">          
                <asp:HyperLink ID="HyperLink1" 
                  runat="server" NavigateUrl="~/cookie.aspx" 
                  CssClass="navBar__link active">
                    Cookie 
                </asp:HyperLink>
            </li>
        </ul>
    </div>

  <h1 class="title">Inicio</h1>
    <form id="form1" runat="server">
        <div>
          <ul>
            <li>
              <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/selectProduct.aspx" 
                  CssClass="navBar__link">
                    Seleccionar Producto
              </asp:HyperLink>
            </li>
            <li>Elimnar Productos Seleccionados</li>
            <li>
              <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/showProduct.aspx" 
                  CssClass="navBar__link">
                    Mostrar Producto
              </asp:HyperLink>
            </li>
          </ul>  
        </div>
    </form>
</body>
</html>
