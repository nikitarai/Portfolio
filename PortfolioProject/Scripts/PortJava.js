$('.smooth').on('click', function () {
    $.smoothscroll({
        scrollelement: $('body'),
        scrolltarget: '#' + this.id
    });

    return false;
});