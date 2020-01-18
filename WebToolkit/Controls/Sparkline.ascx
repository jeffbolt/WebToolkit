<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Sparkline.ascx.cs" Inherits="WebToolkit.Sparkline" ClientIDMode="Static" %>
<asp:Panel ID="pnlSparkline" runat="server">
    <asp:Label ID="lblToolTip" CssClass="d-inline-block tooltipped tooltipped-s" runat="server">
        <svg id="svg" runat="server" width="155" height="30">
            <defs>
                <linearGradient id="lgrad" runat="server" x1="0" x2="0" y1="1" y2="0">
                    <stop offset="10%" stop-color="#d6e685"></stop>
                    <stop offset="33%" stop-color="#8cc665"></stop>
                    <stop offset="66%" stop-color="#44a340"></stop>
                    <stop offset="90%" stop-color="#1e6823"></stop>
                </linearGradient>
                <mask id="mask" runat="server" x="0" y="0" width="155" height="28">
                    <polyline id="polyline" runat="server" fill="transparent" stroke="#8cc665" stroke-width="2" transform="translate(0, 28) scale(1,-1)"
                        points="0,29.0 3,27.88 6,16.380000000000003 9,16.630000000000003 12,15.5 15,20.13 18,15.13 21,10.5 24,10.13 27,15.13 30,19.63 33,15.38 36,14.38 39,12.13 42,12.88 45,23.38 48,12.25 51,10.38 54,9.38 57,11.63 60,6.25 63,12.25 66,4.38 69,14.88 72,14.13 75,23.75 78,28.25 81,15.75 84,10.5 87,18.38 90,10.63 93,13.13 96,14.25 99,18.75 102,13.75 105,15.25 108,9.25 111,15.38 114,13.0 117,6.38 120,12.63 123,18.38 126,28.13 129,17.13 132,9.63 135,22.5 138,17.38 141,14.75 144,20.38 147,15.88 150,20.13 153,21.63 ">
                    </polyline>
                </mask>
            </defs>
            <g id="g" runat="server" transform="translate(0, 2.0)">
                <rect id="rect" runat="server" x="0" y="-2" width="155" height="30" style="stroke: none; fill: url(#gradient); mask: url(#mask)"></rect>
            </g>
        </svg>
    </asp:Label>
</asp:Panel>
