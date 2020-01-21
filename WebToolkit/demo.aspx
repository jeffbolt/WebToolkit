<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="demo.aspx.cs" Inherits="WebToolkit.demo" ClientIDMode="Static" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head runat="server">
    <title>Sparkline Demo</title>
    <meta name="viewport" content="width=device-width" />
	<link href="/controls/sparkline.css" rel="stylesheet" />

	<style type="text/css">
		body {
			padding: 0 10px;
			font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;
		}

		code, pre {
			font-family: Consolas, "Liberation Mono", Menlo, Courier, monospace;
		}
	</style>
</head>
<body>
	<form id="Demo" runat="server">
		<h4>
			Sparkline Demo
		</h4>
		<div>
			<asp:PlaceHolder ID="phSparklines" runat="server"></asp:PlaceHolder>
		</div>
	</form>
</body>
</html>
