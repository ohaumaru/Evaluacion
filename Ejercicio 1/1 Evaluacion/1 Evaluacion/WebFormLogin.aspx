 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormLogin.aspx.cs" Inherits="_1_Evaluacion.WebFormLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css" rel="stylesheet"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.7.0.min.js"></script>
    <link href="Recursos/CSS/StyleSheetEstilos.css" rel="stylesheet" />
    <title>Validacion de formulario ASP</title>
</head>
<body class="bg-light">
    <div class="wrapper">
        <div class="formcontent">
            <form id="form_login" runat="server">
                <div class="form-control">
                    <div class="row">
                        <asp:Label class="h2" id="LabelBienvenida" runat="server" text="Inicio de sesion con validacion de campos"></asp:Label>
                    </div>
                    <div>
                        <asp:Label ID="LabelUsuario" runat="server" Text="Usuario:"></asp:Label>
                        <asp:TextBox ID="TextBoxUsuario" CssClass="form-control" runat="server" placeholder="Nombre de usuario"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RfvUsuario" ErrorMessage="Ingrese Usuario" CssClass="alert-danger" runat="server" ControlToValidate="TextBoxUsuario"></asp:RequiredFieldValidator>
                    </div>
                    <div>
                        <asp:Label ID="LabelContra" runat="server" Text="Contraseña:"></asp:Label>
                        <asp:TextBox ID="TextBoxContra" CssClass="form-control" TextMode="Password" runat="server" placeholder="********"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RfvContrasenia" ErrorMessage="Ingrese Contraseña" CssClass="alert-danger" runat="server" ControlToValidate="TextBoxContra"></asp:RequiredFieldValidator>
                    </div>
                    <div class="row">
                        <asp:Label ID="LabelError" runat="server" CssClass="alert-danger"></asp:Label>
                    </div>
                    <br />
                    <div class="row">
                        <asp:Button ID="ButtonIngresar" CssClass="btn btn-primary btn-dark" runat="server" Text="Ingresar" OnCLick="ButtonIngresar_Clic"/>
                    </div>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
