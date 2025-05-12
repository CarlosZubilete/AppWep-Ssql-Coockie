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
  <link type="text/css" rel="stylesheet" href="cookie.css" />
</head>
<body>
  <%-- Nav --%>
  <div class="navBar">
    <ul class="navBar__ul">
      <%-- INDEX --%>
      <li class="navBar__ul__li">
        <asp:HyperLink ID="linkIndex"
          runat="server"
          NavigateUrl="~/index.aspx"
          CssClass="navBar__link ">
                    Home
        </asp:HyperLink>
      </li>
      <%-- PRODUCTS --%>
      <li class="navBar__ul__li">
        <asp:HyperLink ID="linkProducts"
          runat="server"
          NavigateUrl="~/products.aspx"
          CssClass="navBar__link ">
                    Productos 
        </asp:HyperLink>
      </li>
      <%-- EJERCICIO-2--%>
      <li class="navBar__ul__li">
        <asp:HyperLink ID="linkCookie"
          runat="server" NavigateUrl="~/cookie.aspx"
          CssClass="navBar__link active">
                    Cookie 
        </asp:HyperLink>
      </li>
    </ul>
  </div>

  <form id="form1" runat="server">
    <h1 class="title">Inicio</h1>
    <ul class="navBar__form">
      <li class="navBar__form__item">
        <asp:HyperLink ID="linkSelectProduct" runat="server" NavigateUrl="~/selectProduct.aspx"
          CssClass="navBar__form__link">
                    Seleccionar Producto
        </asp:HyperLink>
      </li>

      <li class="navBar__form__item">
        <asp:LinkButton ID="btnDeleteProduct" runat="server"
          CssClass="navBar__form__link" OnClick="btnDeleteProduct_Click">
                Eliminar Productos Seleccionados
        </asp:LinkButton>
      </li>

      <li class="navBar__form__item">
        <asp:HyperLink ID="linkShowProduct" runat="server" NavigateUrl="~/showProduct.aspx"
          CssClass="navBar__form__link">
                    Mostrar Producto
        </asp:HyperLink>
      </li>
    </ul>
    <hr />
    <%-- S.O MESSAGE --%>
    <div>
    <%-- TEST OF THE TIMER --%>
      <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
      <asp:Timer ID="timerCount" runat="server" Interval="3000" OnTick="timerCount_Tick"></asp:Timer>
      <asp:Label ID="lblMessage" runat="server" CssClass="SO_message"></asp:Label>
    </div>
  </form>
</body>
</html>
