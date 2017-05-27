function TransaccionAjax_Personas(action) {
    MatrizPersonas = [];
    $.ajax({
        type: "POST",
        url: "TransaccionAjaxVentasCredito.aspx",
        data: {
            "status": action
        },
        success: function (result) {
            if (result == "") {
                MatrizPersonas = [];
            } else {
                MatrizPersonas = JSON.parse(result);
                CargarPersonas();
            }
        }
    })
 .done(function (data, textStatus, jqXHR) {
     if (console && console.log) {
         //console.log("La solicitud se ha completado correctamente.");
     }
 })
 .fail(function (jqXHR, textStatus, errorThrown) {
     if (console && console.log) {
         console.log("La solicitud a fallado: " + textStatus);
     }
 });
}

function TransaccionAjax_Tipos(action) {
    MatrizPersonas = [];
    $.ajax({
        type: "POST",
        url: "TransaccionAjaxVentasCredito.aspx",
        data: {
            "status": action
        },
        success: function (result) {
            if (result == "") {
                MatrizTipos = [];
            } else {
                MatrizTipos = JSON.parse(result);
                CargarTipos();
            }
        }
    })
 .done(function (data, textStatus, jqXHR) {
     if (console && console.log) {
         //console.log("La solicitud se ha completado correctamente.");
     }
 })
 .fail(function (jqXHR, textStatus, errorThrown) {
     if (console && console.log) {
         console.log("La solicitud a fallado: " + textStatus);
     }
 });
}

function TransaccionAjax_Articulos(action) {
    MatrizArticulos = [];
    $.ajax({
        type: "POST",
        url: "TransaccionAjaxVentasCredito.aspx",
        data: {
            "status": action
        },
        success: function (result) {
            if (result == "") {
                MatrizArticulos = [];
            } else {
                MatrizArticulos = JSON.parse(result);
                CargarArticulos();
            }
        }
    })
 .done(function (data, textStatus, jqXHR) {
     if (console && console.log) {
         //console.log("La solicitud se ha completado correctamente.");
     }
 })
 .fail(function (jqXHR, textStatus, errorThrown) {
     if (console && console.log) {
         console.log("La solicitud a fallado: " + textStatus);
     }
 });
}

function TransaccionAjax_InsertVentaCredito(action) {
    var persona = $("#Select_PersonVen").val();
    var fecha = $("#Date_FinCredito").val();
    var articulo = $("#Select_Articulo").val();
    var valor = $("#ValorVenta").val();
    var Abono = $("#ValorPago").val();
    console.log("OK");
    if (Abono.length == 0) {
        console.log("Abono en 0");
        Abono = "0";
    }
    $.ajax({
        type: "POST",
        url: "TransaccionAjaxVentasCredito.aspx",
        data: {
            "status": action,
            "persona": persona,
            "fecha_Fin": fecha,
            "articulo": articulo,
            "valor": valor,
            "Abono": Abono
        },
        success: function (result) {
            switch (result) {
                case "Exito":
                    alert("Venta Ingresada Correctamente.");
                    window.location = "../VentasCredito/VentasCredito.aspx";
                    break;
                default:
                    alert("Lo sentimos, ocurrió un error y no se ingresó la venta.");
                    break;
            }
        }
    })
 .done(function (data, textStatus, jqXHR) {
     if (console && console.log) {
         //console.log("La solicitud se ha completado correctamente.");
     }
 })
 .fail(function (jqXHR, textStatus, errorThrown) {
     if (console && console.log) {
         console.log("La solicitud a fallado: " + textStatus);
     }
 });
}