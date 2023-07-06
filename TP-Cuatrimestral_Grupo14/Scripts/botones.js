$('#btnConocimientos').on("click", function () {
    $('#contConocimiento').css('opacity', '1')

    $('#contProyectos').css('opacity', '0')
    $('#contContacto').css('opacity', '0')
    $('#contMenu').css('opacity', '0')

    $('#btnConocimientos').addClass('active')

    $('#btnMenu').removeClass('active')
    $('#btnProyectos').removeClass('active')
    $('#btnContacto').removeClass('active')
})

$('#btnMenu').on("click", function () {
    $('#contConocimiento').css('opacity', '0');
    $('#contProyectos').css('opacity', '0');
    $('#contContacto').css('opacity', '0');
    $('#contMenu').css('opacity', '1');

    $('#btnConocimientos').removeClass('active');
    $('#btnMenu').addClass('active');
    $('#btnProyectos').removeClass('active');
    $('#btnContacto').removeClass('active');
})

$('#btnProyectos').on("click", function () {
    $('#contConocimiento').css('opacity', '0')

    $('#contProyectos').css('opacity', '1')
    $('#contContacto').css('opacity', '0')
    $('#contMenu').css('opacity', '0')

    $('#btnConocimientos').removeClass('active')

    $('#btnMenu').removeClass('active')
    $('#btnProyectos').addClass('active')
    $('#btnContacto').removeClass('active')
})

$('#btnRedes').on("click", function () {
    $('#contConocimiento').css('opacity', '0')

    $('#contProyectos').css('opacity', '0')
    $('#contContacto').css('opacity', '0')
    $('#contMenu').css('opacity', '0')

    $('#btnConocimientos').removeClass('active')

    $('#btnMenu').removeClass('active')
    $('#btnProyectos').removeClass('active')
    $('#btnContacto').removeClass('active')
})

$('#btnContacto').on("click", function () {
    $('#contConocimiento').css('opacity', '0')

    $('#contProyectos').css('opacity', '0')
    $('#contContacto').css('opacity', '1')
    $('#contMenu').css('opacity', '0')

    $('#btnConocimientos').removeClass('active')

    $('#btnMenu').removeClass('active')
    $('#btnProyectos').removeClass('active')
    $('#btnContacto').addClass('active')
})