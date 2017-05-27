<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="compraventa.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script src="../JS/jquery-3.1.1.min.js" type="text/javascript"></script>

    <%-- DatePicker --%>
    <link rel="stylesheet" href="../JS/Datepicker/jquery-ui.css" />
    <link rel="stylesheet" href="../JS/Datepicker/Style.css" />
    <script src="../JS/Datepicker/jquery-1.12.4.js"></script>
    <script src="../JS/Datepicker/jquery-ui.js"></script>

    <link rel="icon" type="image/png" href="https://image.flaticon.com/icons/png/512/241/241966.png" />
    <title id="title_text">Login</title>

    <%-- Librerias del MDL, URL o descargadas --%>
    <%-- El Meta Viewport --%>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="../mdl/material.min.css" />
    <script defer src="../mdl/material.min.js"></script>
    <link rel="stylesheet" href="../mdl/material-icons/Material-Icons.css" />
    <%--<link rel="stylesheet" href="https://code.getmdl.io/1.3.0/material.indigo-pink.min.css" />
    <script defer src="https://code.getmdl.io/1.3.0/material.min.js"></script>
    <link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons" />--%>

    <%--Librerias para el Select getmdl-select--%>
    <link rel="stylesheet" href="../mdl/select/selectfield.min.css" />
    <script defer src="../mdl/select/selectfield.min.js"></script>
    <%--<link rel="stylesheet" href="https://rawgit.com/MEYVN-digital/mdl-selectfield/master/mdl-selectfield.min.css" />
    <script defer src="https://rawgit.com/MEYVN-digital/mdl-selectfield/master/mdl-selectfield.min.js"></script>--%>
    <link rel="stylesheet" href="../CSS/Generales.css" />
    <script src="../FuncionesGlobales.js" type="text/javascript"></script>
    <script src="Login.js" type="text/javascript"></script>

</head>
<body>
    <%-- Card que contiene todo el formulario --%>
    <div id="Div_Card" class="demo-card-wide mdl-card mdl-shadow--2dp">
        <div class="mdl-card__title" id="Title_Card">
            <h2 class="mdl-card__title-text">CUENTA DE USUARIO</h2>
        </div>

        <div class="mdl-card__actions mdl-card--border" id="Body_Card">
            <div class="mdl-grid" id="T_Document" style="width: 100%;">
                <div class="mdl-textfield mdl-js-textfield mdl-textfield--floating-label" style="width: 80%">
                    <input class="mdl-textfield__input" name="Document" type="text" title="El campo solo admite números" pattern="[0-9]{7,15}" id="Document" value="" maxlength="15" style="width: 100%;" onkeypress="return onlyNumbers(event);" />
                    <label class="mdl-textfield__label" for="Document">Documento</label>
                    <span class="mdl-textfield__error">Número de documento no valido</span>
                    <div class="mdl-tooltip" data-mdl-for="Document">Digite su número de Documento</div>
                </div>
            </div>
            <div class="mdl-grid" id="T_Password" style="width: 100%;">
                <div class="mdl-textfield mdl-js-textfield mdl-textfield--floating-label" style="width: 80%">
                    <input class="mdl-textfield__input" name="Password" type="password" title="Digite su password" id="Password" value="" maxlength="80" style="width: 100%;" />
                    <label class="mdl-textfield__label" for="Password">Password</label>
                    <span class="mdl-textfield__error">Entrada no valida</span>
                    <div class="mdl-tooltip" data-mdl-for="Password">Digite su Password</div>
                </div>
            </div>
        </div>

        <div class="mdl-card__actions mdl-card--border" id="End_Card">
            <button class="mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--colored" id="BTN_Enviar" onclick="Ingresar();">
                <i class="material-icons">&#xE163;</i> Ingresar
            </button>
            <div class="mdl-tooltip" data-mdl-for="BTN_Enviar">Ingresar</div>

             <button class="mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--colored" id="BTN_Registrarse" onclick="">
                <i class="material-icons">add</i> Registrarse
            </button>
            <div class="mdl-tooltip" data-mdl-for="BTN_Registrarse">Registrarse</div>
        </div>

    </div>


    <dialog class="mdl-dialog" style="width: 500px; height: 400px; overflow: auto;">
        <h4 class="mdl-dialog__title" id="Title_Dialog">Información Diligenciada</h4>
        <div class="mdl-dialog__content">
            <p id="Text_Dialog">
                Información Diligenciada.
            </p>
        </div>
        <div class="mdl-dialog__actions">
            <button type="button" class="mdl-button" id="BTN_Aceptar" onclick="Cerrar();">Aceptar</button>
        </div>
    </dialog>

    <%-- Pie de Página o Footer --%>
    <footer class="mdl-mega-footer">
        <div class="mdl-mega-footer__top-section">
            <div class="mdl-mega-footer__left-section">
                Fabian Dario Montoya
            </div>
            <div class="mdl-mega-footer__right-section">
                <a href="#top">
                    <button id="Btn_UP" class="mdl-button mdl-js-button mdl-button--fab mdl-js-ripple-effect">
                        <i class="material-icons">keyboard_arrow_up</i>
                    </button>
                </a>
                <div class="mdl-tooltip" data-mdl-for="Btn_UP">
                    Ir Arriba
                </div>
            </div>
        </div>
        <div class="mdl-mega-footer__middle-section">
            © 2017 Bogotá D.C. - COL
        </div>
    </footer>
</body>
</html>
