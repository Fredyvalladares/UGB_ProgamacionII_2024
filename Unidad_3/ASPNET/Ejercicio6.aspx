<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ejercicio6.aspx.cs" Inherits="ASPNET.Ejercicio6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    Convertir Temperatura de <span lang="ES">Fahrenheit a Celsius </span>
</p>
<p>
    <asp:Label ID="Label1" runat="server" Text="Ingrese la temperatura en grados "></asp:Label>
    <span lang="ES">Fahrenheit:</span></p>
<p>
    <asp:TextBox ID="txtfahrenheit" runat="server" TextMode="Number" Width="62px"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" Text="°F"></asp:Label>
</p>
<p>
    <asp:Label ID="lblMenaje" runat="server"></asp:Label>
            </p>
<p>
    <asp:Button ID="Button1" runat="server" Height="38px" OnClick="Button1_Click" Text="Convertir a Celsius" Width="144px" />
</p>
</asp:Content>
