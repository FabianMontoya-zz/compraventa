var MatrizPersonas = [];
var MatrizArticulos = [];
var MatrizArticulos = [];

$(document).ready(function () {
    TransaccionAjax_Personas("Personas");
    TransaccionAjax_Articulos("Articulos");
    TransaccionAjax_Tipos("Tipos");
    $("#Date_FinCredito").datepicker({ dateFormat: 'yy-mm-dd', changeMonth: true, changeYear: true, yearRange: '+0:+15', minDate: "+0" });
    Change_Select_Articulo();
});

function CargarTipos() {
    $('#Select_Abono option').remove();
    $('#Select_Abono').append('<option value="" selected="selected"></option>');
    for (var i in MatrizTipos) {
        $("#Select_Abono").append('<option value="' + MatrizTipos[i].Id_Tipo + '">' + MatrizTipos[i].Id_Tipo + ' - ' + MatrizTipos[i].Tipo + '</option>');
    }
}

function CargarPersonas() {
    $('#Select_PersonVen option').remove();
    $('#Select_PersonVen').append('<option value="" selected="selected"></option>');
    for (var i in MatrizPersonas) {
        $("#Select_PersonVen").append('<option value="' + MatrizPersonas[i].cedula + '">' + MatrizPersonas[i].cedula + ' - ' + MatrizPersonas[i].primer_apellido + ' ' + MatrizPersonas[i].segundo_apellido + ' ' + MatrizPersonas[i].primer_nombre + '</option>');
    }
}

function CargarArticulos() {
    $('#Select_Articulo option').remove();
    $('#Select_Articulo').append('<option value="" selected="selected"></option>');
    for (var a = 0 in MatrizArticulos) {
        console.log(MatrizArticulos[a].ID_Inventario);
        console.log(MatrizArticulos[a].Art_Nombre);
        $("#Select_Articulo").append('<option value="' + MatrizArticulos[a].ID_Inventario + '"> ' + MatrizArticulos[a].ID_Inventario + ' - ' + MatrizArticulos[a].Art_Nombre + ' </option>');
    }
}

function Change_Select_Articulo() {
    $("#Select_Articulo").change(function () {
        var val = $(this).val();
        if (val.length == 0) {
            $('#ValorVenta').val("");
        } else {
            for (var i = 0 in MatrizArticulos) {
                if (MatrizArticulos[i].ID_Inventario == val) {
                    $('#ValorVenta').val(MatrizArticulos[i].Art_Precio);
                }
            }
        }
    });
}

function VenderArticulo() {
    var valido = ValidarCampos();

    if (valido == true) {
        TransaccionAjax_InsertVentaCredito("VentaCredito");
    }
}

function ValidarCampos() {
    var valido = false;
    var persona = $("#Select_PersonVen").val();
    var fecha = $("#Date_FinCredito").val();
    var articulo = $("#Select_Articulo").val();
    var valor = $("#ValorVenta").val();

    var abono = $("#ValorPago").val();
    var tipoAbono = $("#Select_Abono").val();

    if (persona.length == 0 || fecha.length == 0 || articulo.length == 0 || valor.length == 0) {
        alert("Todos los campos marcados con * son obligatorios, favor verificar los campos");
    } else {
        valido = true;
    }

    if (abono.length > 0) {
        if (tipoAbono.length > 0) {
            valido = true;
        } else {
            valido = false;
            alert("Si ingresar un valor como primer pago, debes indicar que tipo de abono es.");
        }
    }
    return valido;
}