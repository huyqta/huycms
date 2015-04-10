'use strict';

//Make sure jQuery has been loaded before app.js
if (typeof jQuery === "undefined") {
    throw new Error("Manage page requires jQuery");
}

$(function () {
    var show_nav = true;

    $('.toggle-aside').click(function () {
        if (!show_nav) {
            $('nav').animate({
                width: 250
            }, 200);
        }
        else {
            $('nav').animate({
                width: 0
            }, 200);
        }
        show_nav = !show_nav;
    })

    $('.nav').find('li').click(function (e) {
        $('.nav').find('li').removeClass('nav-active');
        $(this).addClass('nav-active');
        
        if ($(this).find('li').length > 0) {
            $(this).find('ul').slideToggle(300);
        }
        e.stopPropagation();
    })

    $('.nav').find('li').hover(function (e) {
        $(this).toggleClass('li-hover');
        e.stopPropagation();
    })

    active_current_path();

    //$('.nav').find('li').hover(function () {
    //    $(this).toggleClass('nav-active');
    //})
    })

function active_current_path(){
    var path = $(location).attr('pathname');
    $.each($('.nav').find('li > a'), function () {
        var href = $(this).attr('href');
        console.log(href);
        if (href === path) {
            $(this).parent().addClass('nav-active');
        }
        else {
            $(this).parent().removeClass('nav-active');
        }
    });
}