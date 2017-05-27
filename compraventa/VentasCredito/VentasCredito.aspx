<%@ Page Title="Ventas Crédito" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="VentasCredito.aspx.cs" Inherits="compraventa.VentasCredito.VentasCredito" %>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <script src="../JS/jquery-3.1.1.min.js" type="text/javascript"></script>

    <%-- DatePicker --%>
    <link rel="stylesheet" href="../JS/Datepicker/jquery-ui.css" />
    <link rel="stylesheet" href="../JS/Datepicker/Style.css" />
    <script src="../JS/Datepicker/jquery-1.12.4.js"></script>
    <script src="../JS/Datepicker/jquery-ui.js"></script>
    <link rel="icon" type="image/png" href="https://image.flaticon.com/icons/png/512/294/294436.png" />
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
    <script src="VentasCredito.js" type="text/javascript"></script>
    <script src="TransaccionesAjaxVentasCredito.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <div id="Div_CardContend" class="demo-card-wide mdl-card mdl-shadow--2dp" style="padding-top: 64px;padding-bottom: 60px;">
        <div class="mdl-card__title" id="Title_Card">
            <h2 class="mdl-card__title-text">VENTAS A CRÉDITO</h2>
        </div>
        <div class="mdl-card__supporting-text" id="Text_Card">
            Por favor dilige los campos solicitados en este formulario.<br />
            Los campos marcados con asterisco (*) son obligatorios.
        </div>
        <div class="mdl-card__actions mdl-card--border" id="Body_Card">
            <div class="mdl-grid" id="T_TypeDocument" style="width: 100%;">
                <div class="mdl-cell mdl-cell--4-col mdl-cell--6-col-tablet">
                    <br />
                    *Persona Venta
                </div>
                <div class="mdl-cell mdl-cell--8-col mdl-cell--10-col-tablet">
                    <div id="Select_PersonVen_1" class="mdl-selectfield mdl-js-selectfield mdl-selectfield--floating-label" style="width: 60%">
                        <select id="Select_PersonVen" name="PersonVen" class="required mdl-selectfield__select" required="">
                            <option value=""></option>
                            <%-- Debe ir en blanco el value para que no ocurra error--%>
                        </select>
                        <label for="Select_PersonVen" class="mdl-selectfield__label">Persona venta</label>
                        <span class="mdl-selectfield__error">Campo Obligatorio</span>
                        <div class="mdl-tooltip" data-mdl-for="Select_PersonVen_1">Seleccione un elemento de la lista desplegable</div>
                    </div>
                </div>
            </div>

            <div class="mdl-grid" id="T_Fecha" style="width: 100%;">
                    <div class="mdl-cell mdl-cell--4-col mdl-cell--6-col-tablet">
                        <br />
                        *Fecha Fin Crédito
                    </div>
                    <div class="mdl-cell mdl-cell--8-col mdl-cell--10-col-tablet">
                        <div class="mdl-textfield mdl-js-textfield mdl-textfield--floating-label" style="width: 40%">
                            <input class="mdl-textfield__input" name="Date_FinCredito" type="text" title="Seleccione la fecha de fin del crédito" id="Date_FinCredito" value="" style="width: 100%;" readonly="" />
                            <span class="mdl-textfield__error">Entrada no valida</span>
                            <div class="mdl-tooltip" data-mdl-for="Date_FinCredito">Seleccione fecha de fin del crédito</div>
                        </div>

                    </div>
                </div>

            
            <div class="mdl-grid" id="T_Articulo" style="width: 100%;">
                <div class="mdl-cell mdl-cell--4-col mdl-cell--6-col-tablet">
                    <br />
                    *Articulo Venta
                </div>
                <div class="mdl-cell mdl-cell--8-col mdl-cell--10-col-tablet">
                    <div id="Select_Articulo_1" class="mdl-selectfield mdl-js-selectfield mdl-selectfield--floating-label" style="width: 60%">
                        <select id="Select_Articulo" name="Articulo" class="required mdl-selectfield__select" required="">
                            <option value=""></option>
                            <%-- Debe ir en blanco el value para que no ocurra error--%>
                        </select>
                        <label for="Select_Articulo" class="mdl-selectfield__label">Articulo venta</label>
                        <span class="mdl-selectfield__error">Campo Obligatorio</span>
                        <div class="mdl-tooltip" data-mdl-for="Select_Articulo_1">Seleccione un elemento de la lista desplegable</div>
                    </div>
                </div>
            </div>

            <div class="mdl-grid" id="T_Document" style="width: 100%;">
                <div class="mdl-cell mdl-cell--4-col mdl-cell--6-col-tablet">
                    <br />
                    *Valor venta
                </div>
                <div class="mdl-cell mdl-cell--8-col mdl-cell--10-col-tablet">
                    <div class="mdl-textfield mdl-js-textfield mdl-textfield--floating-label" style="width: 60%">
                        <input class="mdl-textfield__input" name="ValorVenta" type="text" title="El campo solo admite números" pattern="[0-9]{1,15}" id="ValorVenta" value="" maxlength="15" style="width: 100%;" onkeypress="return onlyNumbers(event);" />
                        <label class="mdl-textfield__label" for="ValorVenta">Valor Venta</label>
                        <span class="mdl-textfield__error">Valor digitado invalido</span>
                        <div class="mdl-tooltip" data-mdl-for="ValorVenta">Digite Valor de Venta</div>
                    </div>
                </div>
            </div>

             <div class="mdl-grid" id="T_Abono" style="width: 100%;">
                <div class="mdl-cell mdl-cell--4-col mdl-cell--6-col-tablet">
                    <br />
                    Primer pago
                </div>
                <div class="mdl-cell mdl-cell--8-col mdl-cell--10-col-tablet">
                    <div class="mdl-textfield mdl-js-textfield mdl-textfield--floating-label" style="width: 60%">
                        <input class="mdl-textfield__input" name="ValorPago" type="text" title="El campo solo admite números" pattern="[0-9]{1,15}" id="ValorPago" value="" maxlength="15" style="width: 100%;" onkeypress="return onlyNumbers(event);" />
                        <label class="mdl-textfield__label" for="ValorPago">Valor Primer Pago</label>
                        <span class="mdl-textfield__error">Valor digitado invalido</span>
                        <div class="mdl-tooltip" data-mdl-for="ValorPago">Digite Valor de Pago</div>
                    </div>
                </div>
            </div>

            <div class="mdl-grid" id="T_TipoAbono" style="width: 100%;">
                <div class="mdl-cell mdl-cell--4-col mdl-cell--6-col-tablet">
                    <br />
                    Tipo de Abono
                </div>
                <div class="mdl-cell mdl-cell--8-col mdl-cell--10-col-tablet">
                    <div id="Select_Abono_1" class="mdl-selectfield mdl-js-selectfield mdl-selectfield--floating-label" style="width: 60%">
                        <select id="Select_Abono" name="Abono" class="required mdl-selectfield__select" required="">
                            <option value=""></option>
                            <%-- Debe ir en blanco el value para que no ocurra error--%>
                        </select>
                        <label for="Select_Abono" class="mdl-selectfield__label">Tipo de Abono</label>
                        <span class="mdl-selectfield__error">Campo Obligatorio</span>
                        <div class="mdl-tooltip" data-mdl-for="Select_Abono_1">Seleccione un elemento de la lista desplegable</div>
                    </div>
                </div>
            </div>

        </div>

        <div class="mdl-card__actions mdl-card--border" id="End_Card">
            <button class="mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--colored" id="BTN_Enviar" onclick="VenderArticulo();">
                <i class="material-icons">&#xE163;</i> Ingresar
            </button>
            <div class="mdl-tooltip" data-mdl-for="BTN_Enviar">Ingresar</div>
        </div>

    </div>
</asp:Content>
