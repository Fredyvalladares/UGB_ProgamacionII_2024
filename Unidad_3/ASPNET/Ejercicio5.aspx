
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio5.aspx.cs" Inherits="ASPNET.Ejercicio5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="mb-3">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNombres" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
            &nbsp;<asp:Label ID="Label1" runat="server" class="form-label" Text="Nombre"></asp:Label>
            :&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtNombres" runat="server" class="form-control" ToolTip="Ingrese su primer y segundo nombre" Width="440px"></asp:TextBox>
            <br />
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtEdad" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
            &nbsp;&nbsp;Edad en años:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEdad" runat="server" class="form-control" ToolTip="Ingree su Edad" Width="54px" TextMode="Number"></asp:TextBox>
            <br />
&nbsp;
            <br />
            &nbsp;&nbsp; &nbsp;<asp:Label ID="Label4" runat="server" class="form-label" Text="Pude votar?:"></asp:Label>
            &nbsp;&nbsp;<asp:Label ID="lblMenaje" runat="server"></asp:Label>
            <br />
            &nbsp;</div>
        <p>
            <asp:Button ID="btnEnvia" runat="server" class="btn btn-primary" OnClick="btnEnvia_Click" Text="Consular" Width="109px" />
        </p>
    </form>
</body>
</html>
