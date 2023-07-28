<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormIndex.aspx.cs" Inherits="_1_Evaluacion.WebFormIndex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css" rel="stylesheet"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.7.0.min.js"></script>
    <link href="Recursos/CSS/StyleSheetEstilos.css" rel="stylesheet" />
    <title>Sesion Exitosa</title>
</head>
<body class="bg-light">
    <div class="wrapper">
        <div class="formcontent">
            <form id="form_Index" class="form-control" runat="server">
                <div class="form-control">
                    <div class="row">
                        <asp:Label class="h2" id="LabelIngreso" runat="server" text="" CssClass="h3"></asp:Label>
                    </div>
                    <br />
                    <div>
                        <asp:Button ID="ButtonCerrarSesion" runat="server" Text="Cerrar Sesion" CssClass="btn btn-dark" OnClick="ButtonCerrarSesion_Click"/>
                    </div>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
