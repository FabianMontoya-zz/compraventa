var dialog;
var showDialogButton;
var closeDialogButton;


$(document).ready(function () {
    $("#Date_Born").datepicker({ dateFormat: 'dd/mm/yy', changeMonth: true, changeYear: true, yearRange: '1890:+0', maxDate: '-1' });

});



function Ingresar() {
    try {
        var valido = Validar();
        if (valido == true) {
            TransaccionIngresar("Login");
        } else {
        }
    } catch (ex) {
        alert("Ocurrió un error al intentar ingresar, favor verifique los datos.");
        console.error("Error .Ingresar: " + ex);
    }
}

function Validar() {
    var valido = false;

    var user = $("#Document").val().replace(" ", "");
    var pass = $("#Password").val();
    if (user.length <= 6 || pass.length <= 0) {
        if (user.length <= 6) {
            alert("El campo documento es obligatorio");
        } else if (pass.length <= 0) {
            alert("Debes ingresar la contraseña para poder ingresar");
        }
    } else {
        valido = true;
    }

    return valido;
}

// TRANSACCIONES AJAX

function TransaccionIngresar(action) {
    var user = $("#Document").val().replace(" ", "");
    var pass = $("#Password").val();
    $.ajax({
        type: "POST",
        url: "LoginTransaccionAjax.aspx",
        data: {
            "status": action,
            "user": user,
            "pass": pass
        },
        success: function (result) {
            console.log(result);
            if (result == "0") {
                alert("Lo sentimos, tu usuario o contraseña son incorrectos, por favor verifica tus datos");
            } else {
                window.location = "../Inicio.aspx";
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

