function ExibeMensagem(Msg, tipoMsg) {

    var icone = null;
    var timer;

    if (tipoMsg === "sucesso") {
        notify("top", "right", "", "success", "animated bounceIn", "animated bounceOut", Msg);
    }

    if (tipoMsg === "alerta") {
        notify("top", "right", "", "alert", "animated bounceIn", "animated bounceOut", Msg);
    }

    if (tipoMsg === "erro") {
        notify("top", "right", "", "danger", "animated bounceIn", "animated bounceOut", Msg);
    }

    if (tipoMsg === "info") {
        notify("top", "right", "", "info", "animated bounceIn", "animated bounceOut", Msg);
    }

}

function escondeMensagem() {
    $('#msg').animate({ 'top': '0px' }, 1000, function () {
        $(this).hide();
    });
}

function overlay() {
    $('#myModal').modal("show");
}

function removeoverlay() {
    $('#myModal').modal('hide');
}

function redirectToRecuperarSenhaConfirma() {
    $('#myModal').modal('hide');
    window.location.replace("RecuperarSenhaConfirma");
}

function redirectToAlteraSenhaExternoConfirma() {
    $('#myModal').modal('hide');
    
}


function onSuccess(dados) {

    var data = null;
    try {
        data = JSON.parse(dados);
    }
    catch (err) {
        data = dados;
    }

    if (data.status) {
        ExibeMensagem(data.MsgSucesso, data.tipoMsg);

        if (data.isRedirect) {
            window.location.href = data.url;
        }

        //Verifica se a requisição de atualização do grid deve ser ignorada
        if (typeof data.url !== 'undefined') {
            //Faz nova requisição Ajax para atualizar o grid por trás da caixa de diálogo
            $.ajax(
            {
                type: 'GET',
                url: data.url,
                dataType: 'html',
                cache: false,
                async: true,
                beforeSend: function () {
                    overlay();
                },
                complete: function () {
                    removeoverlay();
                },
                success: function (dataGrid) {
                    $("#Grid").html(dataGrid);
                }
            });
        }
    }
}

jQuery.fn.preventDoubleSubmit = function () {
    jQuery(this).submit(function () {
        if (this.beenSubmitted)
            return false;
        else
            this.beenSubmitted = true;
    });
};

function pad(num, size) {
    var s = num + "";
    while (s.length < size) s = "0" + s;
    return s;
}