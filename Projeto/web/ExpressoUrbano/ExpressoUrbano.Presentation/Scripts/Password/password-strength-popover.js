$(document).ready(function () {

    //minimum 8 characters
    var bad = /(?=.{8,}).*/;
    //Alpha Numeric plus minimum 8
    var good = /^(?=\S*?[a-z])(?=\S*?[0-9])\S{8,}$/;
    //Must contain at least one upper case letter, one lower case letter and (one number OR one special char).
    var better = /^(?=\S*?[A-Z])(?=\S*?[a-z])((?=\S*?[0-9])|(?=\S*?[^\w\*]))\S{8,}$/;
    //Must contain at least one upper case letter, one lower case letter and (one number AND one special char).
    var best = /^(?=\S*?[A-Z])(?=\S*?[a-z])(?=\S*?[0-9])(?=\S*?[^\w\*])\S{8,}$/;

    $('#password').on('keyup', function () {
        var password = $(this);
        var pass = password.val();
        var passLabel = $('[for="password"]');
        var stength = 'Fraco';
        var pclass = 'danger';
        if (best.test(pass) == true) {
            stength = 'Muito Forte';
            pclass = 'success';
        } else if (better.test(pass) == true) {
            stength = 'Forte';
            pclass = 'warning';
        } else if (good.test(pass) == true) {
            stength = 'Médio';
            pclass = 'warning';
        } else if (bad.test(pass) == true) {
            stength = 'Fraco';
        } else {
            stength = 'Muito Fraco';
        }

        var popover = password.attr('data-content', stength).data('bs.popover');
        popover.setContent();
        popover.$tip.addClass(popover.options.placement).removeClass('danger success info warning primary').addClass(pclass);

    });

    $('input[data-toggle="popover"]').popover({
        placement: 'top',
        trigger: 'keypress'
    });

})