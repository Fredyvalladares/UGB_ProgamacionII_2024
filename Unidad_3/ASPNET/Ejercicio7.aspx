<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ejercicio7.aspx.cs" Inherits="ASPNET.Ejercicio7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <asp:Label ID="lblnum1" runat="server" Text="Ingrese el primer numero:"></asp:Label>
        <asp:TextBox ID="txtNum1" runat="server" Height="16px"></asp:TextBox>
        </p>
    <asp:Label ID="lblnum2" runat="server" Text="Ingrese el segundo numero:"></asp:Label>
    <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
    <p>
        &nbsp;</p>
    <p>
        <asp:RadioButton ID="rdbSuma" runat="server" Text="Suma" />
    <br />
        <asp:RadioButton ID="rdbResta" runat="server" Text="Resta" />
           <br />
        <asp:RadioButton ID="rdbMultiplicacion" runat="server" Text="Multiplicacion" />
    <br />
        <asp:RadioButton ID="rdbDivision" runat="server" Text="Division" />
    <br />
    <br />
    <asp:Button ID="btnRealizarop" runat="server" OnClick="Button1_Click" Text="Relizar Operacion" Height="35px" Width="178px" />
    <br />
    <br />
    <br />
    <asp:Label ID="lblMenaje" runat="server"></asp:Label>
        </p>
            </asp:Content>
