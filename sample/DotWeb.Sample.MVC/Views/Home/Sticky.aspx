<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
	<%= Html.ClientCode(
			"DotWeb.Sample.Client.Sticky.Main, DotWeb.Sample.Script", 
			(string)ViewData["Mode"]) %>
</asp:Content>
