<%@ Page 
  Language="C#" 
  AutoEventWireup="true" 
  CodeBehind="products.aspx.cs" 
  UnobtrusiveValidationMode="None"
  Inherits="WebApp_SQL_Cookies.Web_products" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Products</title>
    <link  type="text/css" rel="stylesheet" href="products.css"/>
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
                  CssClass="navBar__link active" >
                    Productos 
                </asp:HyperLink>
            </li>
          <%-- EJERCICIO-2--%> 
            <li class="navBar__ul__li">          
                <asp:HyperLink ID="HyperLink1" 
                  runat="server" NavigateUrl=".aspx" 
                  CssClass="navBar__link">
                    Ejercicio-2 
                </asp:HyperLink>
            </li>
        </ul>
    </div>

  <form id="form1" runat="server">
    
    <h1 class="title">Productos</h1>
    <div>
      <asp:GridView ID="gridProducts" runat="server" 
        AutoGenerateColumns="False" 
        CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="10" AllowPaging="True" OnPageIndexChanging="gridProducts_PageIndexChanging">

        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <%-- COLUMNAS --%>
        <Columns>
          <%-- ID PRODUCTO  --%>
          <asp:TemplateField HeaderText="Id Producto">
            <%-- ADD --%>
            <ItemTemplate>
              <asp:Label ID="itemTemplate_IDProducto" runat="server" Text='<%# Bind("IdProducto") %>'></asp:Label>
            </ItemTemplate>
          </asp:TemplateField>
          <%-- NOMBRE DEL PRODUCTO --%>
          <asp:TemplateField HeaderText="Nombre del Producto">
            <%-- ADD --%>
            <ItemTemplate>
              <asp:Label ID="itemTemplate_NombreProducto" runat="server" Text='<%# Bind("NombreProducto") %>'></asp:Label>
            </ItemTemplate>
          </asp:TemplateField>
          <%-- CANTIDAD POR UNIDAD --%>
          <asp:TemplateField HeaderText="Cantidad Por Unidad">
            <%-- ADD --%>
            <ItemTemplate>
              <asp:Label ID="itemTemplate_cantidadPorUnidad" runat="server" Text='<%# Bind("CantidadPorUnidad") %>'></asp:Label>
            </ItemTemplate>
          </asp:TemplateField>
          <%-- PRECIO POR UNIDAD --%>
          <asp:TemplateField HeaderText="Precio Unidad">
            <ItemTemplate>
              <asp:Label ID="itemTemplate_PrecioUnidad" runat="server" Text='<%# Bind("PrecioUnidad") %>'></asp:Label>
            </ItemTemplate>
          </asp:TemplateField>
        </Columns>
        <%-- STYLOS GRID --%>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />

      </asp:GridView>
    </div>
  </form>
</body>
</html>
