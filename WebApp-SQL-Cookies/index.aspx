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
            <li class="navBar__ul__li">
                <asp:HyperLink  ID="HyperLink2" 
                  runat="server" 
                  NavigateUrl=".aspx" 
                  CssClass="navBar__link active" >
                    Home
                </asp:HyperLink>
            </li>
        
            <li class="navBar__ul__li">
                <asp:HyperLink ID="linkListSuc" 
                  runat="server" 
                  NavigateUrl=".aspx" 
                  CssClass="navBar__link" >
                    Ejercicio-1 
                </asp:HyperLink>
            </li>
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
      </div>        
  </form>
</body>
</html>
