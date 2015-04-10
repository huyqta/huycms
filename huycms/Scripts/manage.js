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
            }, 300);
        }
        else {
            $('nav').animate({
                width: 0
            }, 300);
        }
    })
})