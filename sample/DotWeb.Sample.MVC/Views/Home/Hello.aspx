<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true"
	CodeBehind="Hello.aspx.cs" Inherits="H8.MVC.Views.Home.Hello" %>
	
<asp:Content ContentPlaceHolderID="Header" runat="server">
	<style>
		#box 
		{
			width: 300px;
			height: 300px;
			background-color: #000;
			color: #FFF;
		}
	</style>
</asp:Content>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
	<h2>Hello DotWeb!</h2>
	
	<br />
	
	<div id='box'>
		<br />
		<br />
		<br />
		<br />
		<center>Click anywhere in this box to fire an event!</center>
	</div>
	
	<%= Html.ClientCode(
			"DotWeb.Sample.Script.Hello, DotWeb.Sample.Script", 
			(string)ViewData["Mode"]) %>
</asp:Content>
