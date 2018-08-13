var timeRange = 86400000,
    step = 60000,
    min = 1532476800000,
    max = min + timeRange,
    from = 1532476800000,
    to = from + step * 10,
    isPlaying = false,
    showAnimUi = false,
    zX = 1;

$(() => {
    // Initialize RangeSlider for time movement
    $("#range").ionRangeSlider({
        min: min,
        max: max,
        from: from,
        to: to,
        prettify: num => {
            var m = new Date(num);
            if (num == min || num == max) {
                var dateString =
                    ("0" + (m.getUTCMonth() + 1)).slice(-2) + "/" +
                    ("0" + m.getUTCDate()).slice(-2) + "/" +
                    m.getUTCFullYear()
                return dateString;
            } else {
                var dateString =
                    ("0" + m.getUTCHours()).slice(-2) + ":" +
                    ("0" + m.getUTCMinutes()).slice(-2)
                return dateString;
            }
        },
        drag_interval: true,
        type: 'double',
        step: 60000,
        force_edges: true,
        onFinish: data => {
            from = data.from;
            to = data.to;
            updateHeatmap();
        },
        onUpdate: data => {
            stepForeward();
        }
    });

    // Initialize draggable for heatmap movement
    $("#moveable").draggable({
        containment: "heat-wrap",
        disabled: true
    });

    // Initalize tooltips
    $('[data-toggle="tooltip"]').tooltip();

    if (showAnimUi) {
        $("#animation-ui").show("slide");
    } else {
        $("#animation-ui").hide("slide");
    }
});

pageOver = function (direction) {
    min += (timeRange * direction);
    max += (timeRange * direction);
    $("#range").data("ionRangeSlider").update({
        min: min,
        max: max
    })
}

// Heatmap zoom behavior
window.addEventListener('wheel', e => {
    var options = $("#moveable").draggable("option");
    if (!e.ctrlKey || options.disabled) return;
    zX += (e.deltaY > 0) ? -0.1 : 0.1;
    zX = (zX > 2) ? 2 : zX;
    zX = (zX < .5) ? .5 : zX;
    $('#moveable').css({ 'transform': 'scale(' + zX + ')' });
    e.preventDefault();
    return;
});

// Options menu hover behavior
$("#options").hover(() => {
    $("#options").fadeTo("fast", 1);
    $('#collapse').toggle("fast");
}, () => {
    $("#options").fadeTo("fast", .5);
    $('#collapse').toggle("fast");
});

// Handler for Animation UI Display
$("#toggle-animation-ui").click(() => {
    $("#animation-ui").toggle("slide");
});

// Handler for step buttons
$("#step-foreward").click(() => {
    pageOver(1);
})

$("#step-back").click(() => {
    pageOver(-1);
})

// Handler to animate Heatmap
$("#animate-btn").click(() => {
    isPlaying = !isPlaying;

    if (isPlaying) {
        $("#animate-btn").html('| |');
        stepForeward();
    } else {
        $("#animate-btn").html('>');
    }
})