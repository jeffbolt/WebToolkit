<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="graphs.aspx.cs" Inherits="WebToolkit.graphs" ClientIDMode="Static" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head runat="server">
	<title>Graphs</title>
	<meta name="viewport" content="width=device-width" />
	<link href="/css/svg.css" rel="stylesheet" />
</head>
<body style="padding: 10px">
	<form id="form1" runat="server">
		<div>
			<h1>Web Toolkit</h1>
			<div style="padding-left: 8px">
				<h2>Graphs</h2>
				<div style="padding-left: 8px">
					<h4>GitHub-style Sparklines</h4>
					<div style="padding-top: 8px">
						<asp:PlaceHolder ID="phSparklines" runat="server"></asp:PlaceHolder>
					</div>
				</div>
			</div>
		</div>
	</form>
</body>
</html>
