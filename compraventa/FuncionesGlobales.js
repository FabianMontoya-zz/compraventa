$(document).ready(function () {
    $("#Date_Born").datepicker({ dateFormat: 'dd/mm/yy', changeMonth: true, changeYear: true, yearRange: '1890:+0', maxDate: '-1' });
    var url = window.location.pathname.toString();
    if (url == "/Inicio.aspx") {
        $("#Web_Logo").attr("href", "Inicio.aspx");
        $("#Web_VentasCredito").attr("href", "VentasCredito/VentasCredito.aspx");
        $("#Web_2").attr("href", "Ventas/Ventas.aspx");
        $("#Web_3").attr("href", "Factura/About.aspx");
        $("#Web_4").attr("href", "#");
        $("#Web_5").attr("href", "Dowloads/ManualVentasCredito.pdf");
        $("#Web_6").attr("href", "Dowloads/ManualVentas.pdf");
        $("#Web_Salir").attr("href", "Login/Index.aspx");
    } else {
        $("#Web_Logo").attr("href", "../Inicio.aspx");
        $("#Web_VentasCredito").attr("href", "../VentasCredito/VentasCredito.aspx");
        $("#Web_2").attr("href", "../Ventas/Ventas.aspx");
        $("#Web_3").attr("href", "../Factura/About.aspx");
        $("#Web_4").attr("href", "#");
        $("#Web_5").attr("href", "../Dowloads/ManualVentasCredito.pdf");
        $("#Web_6").attr("href", "../Dowloads/ManualVentas.pdf");
        $("#Web_Salir").attr("href", "../Login/Index.aspx");
    }
});


function soloLetras(e) {
    key = e.keyCode || e.which;
    tecla = String.fromCharCode(key).toLowerCase();
    letras = " abcdefghijklmnopqrstuvwxyz";
    especiales = "8-37-39-46";

    tecla_especial = false
    for (var i in especiales) {
        if (key == especiales[i]) {
            tecla_especial = true;
            break;
        }
    }

    if (letras.indexOf(tecla) == -1 && !tecla_especial) {
        return false;
    }
}

function onlyNumbers(e) {
    tecla = (document.all) ? e.keyCode : e.which;

    //Tecla de retroceso para borrar, siempre la permite
    if (tecla == 8) {
        return true;
    }

    // Patrón de entrada, en este caso solo acepta numeros
    patron = /[0-9]/;
    tecla_final = String.fromCharCode(tecla);
    return patron.test(tecla_final);
}