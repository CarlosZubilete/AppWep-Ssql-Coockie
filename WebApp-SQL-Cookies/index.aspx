<%@Page 
  Language="C#" 
  AutoEventWireup="true" 
  CodeBehind="index.aspx.cs" 
  UnobtrusiveValidationMode="None"
  Inherits="WebApp_SQL_Cookies.Web_Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Index</title>
  <link rel="stylesheet" type="text/css" href="index.css"/>  
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
                  CssClass="navBar__link active" >
                    Home
                </asp:HyperLink>
            </li>
          <%-- PRODUCTS --%>
            <li class="navBar__ul__li">
                <asp:HyperLink ID="linkProducts" 
                  runat="server" 
                  NavigateUrl="~/products.aspx" 
                  CssClass="navBar__link" >
                    Productos 
                </asp:HyperLink>
            </li>
          <%-- EJERCIO-2 --%>
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
      <div>
        <h1 class="title" >Hi! Bienvenido a mi Página WEB</h1>
      </div>        
  </form>
</body>
</html>
