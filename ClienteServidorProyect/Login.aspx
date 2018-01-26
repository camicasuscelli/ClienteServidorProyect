<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ClienteServidorProyect.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="js/bootstrap.css" rel="stylesheet" />
    <script src="js/jquery-3.3.1.min.js"></script>
    <link href="css/estilosWeb.css" rel="stylesheet" />
    <title>Pagina de logueo</title>
</head>
<body>
    <div class="contenedor container">
        <h1 class="elementos">Login</h1>
        <div>
            Usuario:
            <br />
            <input class="elementos" id="user"/>
            <br />
            <hr />
            Contraseña:
            <br />
            <input class="elementos" id="contrasena"/>
            <br />
            <br />
            <button class="btn btn-info elementos" id="login">Iniciar Sesión</button>
            <br />
        </div>
    </div>

    <script type="text/javascript">
        $(document).ready(function (e) {
            $('#login').click(function (e) {
                var usuario = {};
                usuario.nombre = $('#user').val();
                usuario.password = $('#contrasena').val();
                //alert(usuario.nombre + " " + usuario.password);

                //dentro uso un post para envíar los datos como json:
                $.ajax({
                    type: 'POST',
                    url: 'http://localhost:50519/WebService.asmx/Login',
                    data: JSON.stringify(usuario),
                    contentType: "application/json;charset=utf-8",
                    dataType: "json",
                    success: function (msg) {
                        alert(msg.d);
                    },

                    error: function (e) {
                        alert("entro mal amea");
                    },
                })
            });
        });

    </script>
</body>
</html>
