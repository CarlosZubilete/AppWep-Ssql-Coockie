<%@ Page 
  Language="C#" 
  AutoEventWireup="true" 
  CodeBehind="selectProduct.aspx.cs" 
  UnobtrusiveValidationMode="None"
  Inherits="WebApp_SQL_Cookies.select" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Selecionar Productos</title>
     <link  type="text/css" rel="stylesheet" href="selectProduct.css"/>
</head>
<body>
  <form id="form1" runat="server">
    <%-- TITLE --%>
    <h1 class="title">Selecionar Productos</h1> 
    <%-- FOOTER --%>
      <div class="contenedor_footer">
        <%-- PRODUCTO SELECCIONADO --%>
        <asp:Label ID="lblShowSelected" runat="server" Text=""></asp:Label>
        <%-- VOLVER --%>
        <asp:HyperLink  ID="linkCookie" runat="server" NavigateUrl="~/cookie.aspx" CssClass="navBar__link" >
            Volver
        </asp:HyperLink>
      </div>
    <div>
    <%-- GRID --%>
       <asp:GridView runat="server" ID="gridProducts" AutoGenerateColumns="False" 
          PageSize="14" AllowPaging="True" 
          OnPageIndexChanging="gridProducts_PageIndexChanging" 
          AutoGenerateSelectButton="false" 
          OnSelectedIndexChanging="gridProducts_SelectedIndexChanging" CssClass="grid-view" >
         <Columns>
          <asp:CommandField ShowSelectButton="True" SelectText="   Select   " 
            ButtonType="Button" ItemStyle-CssClass="select-button"/>
          <%-- ID PRODUCTO  --%>
          <asp:TemplateField HeaderText="Id Producto">
            <ItemTemplate>
              <asp:Label ID="itemTemplate_IDProducto" runat="server" Text='<%# Bind("IdProducto") %>' ></asp:Label>
            </ItemTemplate>
          </asp:TemplateField>
          <%-- NOMBRE PRODUCTO  --%>
          <asp:TemplateField HeaderText="Nombre Producto">
            <ItemTemplate>
              <asp:Label ID="itemTemplate_NombreProducto" runat="server" Text='<%# Bind("NombreProducto") %>' ></asp:Label>
            </ItemTemplate>
          </asp:TemplateField>
          <%-- ID PROVEEDOR  --%>
          <asp:TemplateField HeaderText="Id Proveedor">
            <ItemTemplate>
              <asp:Label ID="itemTemplate_IdProveedor" runat="server" Text='<%# Bind("IdProveedor") %>' ></asp:Label>
            </ItemTemplate>
          </asp:TemplateField>
          <%-- PRECIO UNITARIO  --%>
          <asp:TemplateField HeaderText="Precio Unitario">
            <ItemTemplate>
              <asp:Label ID="itemTemplate_PrecioUnidad" runat="server" Text='<%# Bind("PrecioUnidad") %>' ></asp:Label>
            </ItemTemplate>
          </asp:TemplateField>
         </Columns>
      </asp:GridView>
    </div>
  </form>
</body>
</html>
