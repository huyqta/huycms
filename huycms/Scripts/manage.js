'use strict';

//Make sure jQuery has been loaded before app.js
if (typeof jQuery === "undefined") {
    throw new Error("Manage page requires jQuery");
}

$(function () {
    $('.toggle-aside').click(function () {
        $('aside').toggle('slide', { direction: 'left' }, 1000);
    })
})