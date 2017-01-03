function Mascaras() {

    jQuery(".jQ-data").mask("99/99/9999");
    jQuery(".jQ-data-person").mask("99/99/9999");
    jQuery(".jQ-cep").mask("99.999-999");
    jQuery(".jQ-cpf").mask("999.999.999-99");
    jQuery(".jQ-cnpj").mask("99.999.999/9999-99");
    jQuery(".jQ-telefone").mask("(99) 9999-9999");
    jQuery(".jQ-sgestado").mask("aa");

    jQuery(".jQ-numero").on("keyup", function () {
        jQuery("#" + this.id).val(jQuery("#" + this.id).val().replace(/[^0-9]/g, ''));
    });

    jQuery(".jQ-moeda").maskMoney({ prefix: '', allowNegative: false, thousands: '.', decimal: ',', affixesStay: false });
}

