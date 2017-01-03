//Api do CEP
$(document).ready(function () {

    function limpa_formulário_cep() {
        // Limpa valores do formulário de cep.
        $("#rua").val("");
        $("#bairro").val("");
        $("#cidade").val("");
        $("#uf").val("");
        $("#ibge").val("");
    }
    
    removerToggled = function () {
        $('div.col-md-4:nth-child(5) > div:nth-child(1)').removeClass('fg-toggled');//UF
        $('div.card:nth-child(1) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(3) > div:nth-child(1)').removeClass('fg-toggled');//Cidade
        $('div.col-md-4:nth-child(4) > div:nth-child(1)').removeClass('fg-toggled');//Bairro
        $('div.col-md-2:nth-child(2) > div:nth-child(1)').removeClass('fg-toggled');//Logradouro
    }

    addToggled = function () {
        $('div.col-md-4:nth-child(5) > div:nth-child(1)').addClass('fg-toggled');//UF
        $('div.card:nth-child(1) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(3) > div:nth-child(1)').addClass('fg-toggled');//Cidade
        $('div.col-md-4:nth-child(4) > div:nth-child(1)').addClass('fg-toggled');//Bairro
        $('div.col-md-2:nth-child(2) > div:nth-child(1)').addClass('fg-toggled');//Logradouro
    }

    $('#cep').change(function () {
        if ($('#cep').val()!="")
            addToggled();
        else if ($('#cep').val() == "")
            removerToggled()
        
    });
    
    //Quando o campo cep perde o foco.
    $("#cep").blur(function () {

        //Nova variável "cep" somente com dígitos.
        var cep = $(this).val().replace(/\D/g, '');

        //Verifica se campo cep possui valor informado.
        if (cep != "") {

            //Expressão regular para validar o CEP.
            var validacep = /^[0-9]{8}$/;

            //Valida o formato do CEP.
            if (validacep.test(cep)) {

                //Preenche os campos com "..." enquanto consulta webservice.
                $("#rua").val("...");
                $("#bairro").val("...");
                $("#cidade").val("...");
                $("#uf").val("...");
                $("#ibge").val("...");

                //Consulta o webservice viacep.com.br/
                $.getJSON("//viacep.com.br/ws/" + cep + "/json/?callback=?", function (dados) {

                    if (!("erro" in dados)) {

                        //Atualiza os campos com os valores da consulta.
                        $("#rua").val(dados.logradouro);
                        if (dados.logradouro == "") {
                            $('div.col-md-4:nth-child(5) > div:nth-child(1)').removeClass('fg-toggled');
                        }
                        $("#bairro").val(dados.bairro);
                        if (dados.bairro == "") {
                            $('div.col-md-4:nth-child(4) > div:nth-child(1)').removeClass('fg-toggled');
                        }
                        $("#cidade").val(dados.localidade);
                        if (dados.localidade == "") {
                            $('div.card:nth-child(1) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(3) > div:nth-child(1)').removeClass('fg-toggled');
                        }
                        $("#uf").val(dados.uf);
                        if (dados.uf == "") {
                            $('div.col-md-2:nth-child(2) > div:nth-child(1)').removeClass('fg-toggled');
                        }

                        $("#ibge").val(dados.ibge);
                    } //end if.
                    else {
                        //CEP pesquisado não foi encontrado.
                        limpa_formulário_cep();

                        $("#modal_erroCep").modal("show");
                        if ($("#modal_erroCep > div:nth-child(1) > div:nth-child(1) > div:nth-child(3) > button:nth-child(1)").click(function () {
                            $("#modal_erroCep").modal("hide");
                            removerToggled();
                        }));
                    }
                });
            } //end if.
            else {
                //cep é inválido.
                limpa_formulário_cep();
                $("#modal_erroCep").modal("show");
                if ($("#modal_erroCep > div:nth-child(1) > div:nth-child(1) > div:nth-child(3) > button:nth-child(1)").click(function () {
                    $("#modal_erroCep").modal("hide");
                     removerToggled();
                }));
            }
        } //end if.
        else {
            //cep sem valor, limpa formulário.
            limpa_formulário_cep();
        }
    });
});