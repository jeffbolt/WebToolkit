<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="demo.aspx.cs" Inherits="WebToolkit.demo" ClientIDMode="Static" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head runat="server">
    <title>Sparkline Demo</title>
    <meta name="viewport" content="width=device-width" />
    <link href="/css/svg.css" rel="stylesheet" />
</head>
<body style="padding: 10px">
    <form id="form1" runat="server">
    <div>
        <asp:PlaceHolder ID="phGraphs" runat="server"></asp:PlaceHolder>
    </div>
    </form>
</body>
</html>
