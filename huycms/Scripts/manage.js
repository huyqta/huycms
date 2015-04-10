'use strict';

//Make sure jQuery has been loaded before app.js
if (typeof jQuery === "undefined") {
    throw new Error("Manage page requires jQuery");
}

$(function () {
    $('.toggle-aside').click(function () {
        if ($('nav').css('width') == '0px') {
            $('nav').animate({
                width: 250
            }, 200);
        }
        else {
            $('nav').animate({
                width: 0
            }, 200);
        }
    })

    $('.nav').find('li').click(function (e) {
        $('.nav').find('li').removeClass('nav-active');
        $(this).addClass('nav-active');
        
        if ($(this).find('li').length > 0) {
            $(this).find('ul').slideToggle(300);
        }
        
    })
})