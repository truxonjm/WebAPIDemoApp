$(function () {
    $("#moveable").draggable({
        containment: "heat-wrap",
        disabled: true
    });
});

var zX = 1;
window.addEventListener('wheel', function (e) {
    var options = $("#moveable").draggable("option");
    if (!e.ctrlKey || options.disabled) return;
    zX += (e.deltaY > 0) ? -0.1 : 0.1;
    zX = (zX > 2) ? 2 : zX;
    zX = (zX < .5) ? .5 : zX;
    $('#moveable').css({ 'transform': 'scale(' + zX + ')' });
    e.preventDefault();
    return;
});
